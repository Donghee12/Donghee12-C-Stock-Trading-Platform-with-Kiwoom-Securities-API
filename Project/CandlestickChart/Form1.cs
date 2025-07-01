using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using JamongCommonLibrary;
using HtmlAgilityPack;
using System.Net.Http;
using System.IO;
using System.Net;



namespace CandlestickChart
{
    public partial class Form1 : Form
    {
        List<PriceInfoEntityObject> priceInfoList;

        private Series priceSeries;
        private Series volumeSeries;

        private string currentStockCode = "";
        private int selectedTickUnit = 1;
        private int selectedMinuteUnit = 1;
        private Boolean isMinuteSelected = false;
        private Boolean isTickSelected = false;
        private Timer accountTimer; // 전역으로 선언
        private MyOnSearchedItemSelectedListener searchedItemListener;
        private bool isProgrammaticCheck = false; // 자동 체크 여부 플래그
        private bool hasPromptedInterest = false; // 메시지박스 중복 방지

        JamongCommonClass jamongCommonClass;
        종목검색창 종목검색창;

        private List<NewsItem> newsList = new List<NewsItem>();


        public Form1()
        {
            InitializeComponent();

            this.axKHOpenAPI1.OnEventConnect += this.axKHOpenAPI_OnEventConnect;
            this.axKHOpenAPI1.OnReceiveTrData += this.axKHOpenAPI_OnReceiveTrData;
            this.axKHOpenAPI1.OnReceiveRealData += this.axKHOpenAPI_OnReceiveRealData;
            this.requestButton.Click += this.buttonClicked;
            this.dailyButton.Click += this.buttonClicked;
            this.weeklyButton.Click += this.buttonClicked;
            this.monthlyButton.Click += this.buttonClicked;
            this.minuteButton.Click += this.buttonClicked;
            this.tickButton.Click += this.buttonClicked;
            this.n1Button.Click += this.buttonClicked;
            this.n3Button.Click += this.buttonClicked;
            this.n5Button.Click += this.buttonClicked;
            this.n10Button.Click += this.buttonClicked;
            this.n15Button.Click += this.buttonClicked;
            this.n30Button.Click += this.buttonClicked;
            this.n45Button.Click += this.buttonClicked;
            this.n60Button.Click += this.buttonClicked;
            this.searchButton.Click += this.buttonClicked;
            this.btnAccountSerach.Click += this.buttonClicked;
            this.listBox1.DoubleClick += this.listBox1_DoubleClick;
            chkInterestBuy.CheckedChanged += InterestCheckBoxes_CheckedChanged;
            chkInterestSell.CheckedChanged += InterestCheckBoxes_CheckedChanged;

            listViewOrders.OwnerDraw = true;
            listViewOrders.DrawSubItem += listViewOrders_DrawSubItem;
            listViewOrders.DrawColumnHeader += listViewOrders_DrawColumnHeader;

            jamongCommonClass = JamongCommonClass.getInstance(this.axKHOpenAPI1); //jamongCommonClass 객체 불러오기

            priceSeries = chart1.Series["priceSeries"];
            priceSeries["PriceUpColor"] = "Red";
            priceSeries["PriceDownColor"] = "Blue";
            volumeSeries = chart1.Series["volumeSeries"];
            this.chart1.AxisViewChanged += this.chart1_AxisViewChanged;

            this.chart1.MouseMove += this.chart_MouseMove;

            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";
            chart1.ChartAreas[1].AxisY.LabelStyle.Format = "#,##0,K";

            new ToolTip().SetToolTip(currentPriceLabel, "현재가");
            new ToolTip().SetToolTip(netChangeLabel, "전일대비");
            new ToolTip().SetToolTip(fluctuationRateLabel, "등락률");
            new ToolTip().SetToolTip(accumulatedVolumeLabel, "누적거래량");
            new ToolTip().SetToolTip(volumeChangeLabel, "전일거래량 대비");
            new ToolTip().SetToolTip(turnoverRatioLabel, "거래량회전률");
            new ToolTip().SetToolTip(tradingValueLabel, "거래대금");
            new ToolTip().SetToolTip(openPriceLabel, "시가");
            new ToolTip().SetToolTip(highPriceLabel, "고가");
            new ToolTip().SetToolTip(lowPriceLabel, "저가");

            if (axKHOpenAPI1.CommConnect() != 0)
                System.Windows.Forms.MessageBox.Show("로그인 실패");
            searchedItemListener = new MyOnSearchedItemSelectedListener(this);
            LoadInterestStockAll();
        }

        private void axKHOpenAPI_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                // 이름 표시
                labelName.Text = axKHOpenAPI1.GetLoginInfo("USER_NAME");

                string serverType = axKHOpenAPI1.GetLoginInfo("GetServerGubun");
                if (serverType == "1")
                {
                    MessageBox.Show("※ 모의투자 서버에 접속 중입니다.");
                }
                else
                    MessageBox.Show("※ 실거래 서버에 접속 중입니다.");

                // 계좌목록 표시 (v로 시작하는 선물 계좌 제외)
                string[] accounts = axKHOpenAPI1.GetLoginInfo("ACCLIST").Split(';');
                var filtered = accounts.Where(acc => !acc.StartsWith("v") && acc.Length > 0).ToArray();

                cmbMyAccounts.Items.Clear();
                cmbMyAccounts.Items.AddRange(filtered);

                if (filtered.Length > 0)
                    cmbMyAccounts.SelectedIndex = 0;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("로그인 실패");
            }
        }


        public void buttonClicked(object sender, EventArgs e)
        {
            if (sender.Equals(this.requestButton))
            {
                currentStockCode = this.itemCodeTextBox.Text.Trim();
                itemNameLabel.Text = axKHOpenAPI1.GetMasterCodeName(currentStockCode);
                requestDailyChart();
                LoadNewsToListBox();
                //LoadInterestStockAll();
            }
            else if (sender.Equals(this.dailyButton))
            {
                if (currentStockCode.Length > 0)
                {
                    turnNButtonsEnabled(false);
                    requestDailyChart();
                }
            }
            else if (sender.Equals(this.weeklyButton))
            {
                if (currentStockCode.Length > 0)
                {
                    turnNButtonsEnabled(false);
                    requestWeeklyChart();
                }
            }
            else if (sender.Equals(this.monthlyButton))
            {
                if (currentStockCode.Length > 0)
                {
                    turnNButtonsEnabled(false);
                    requestMonthlyChart();
                }
            }
            else if (sender.Equals(this.minuteButton))
            {
                if (currentStockCode.Length > 0)
                {
                    turnNButtonsEnabled(true);
                    requestMinuteChart(selectedMinuteUnit);
                }
            }
            else if (sender.Equals(this.tickButton))
            {
                if (currentStockCode.Length > 0)
                {
                    n1Button.Enabled = true;
                    n3Button.Enabled = true;
                    n5Button.Enabled = true;
                    n10Button.Enabled = true;
                    n30Button.Enabled = true;
                    n15Button.Enabled = false;
                    n45Button.Enabled = false;
                    n60Button.Enabled = false;

                    isMinuteSelected = false;
                    isTickSelected = true;

                    requestTickChart(selectedTickUnit);
                }
            }
            else if (sender.Equals(this.n1Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 1;
                    requestMinuteChart(selectedMinuteUnit);
                }
                else if (isTickSelected)
                {
                    selectedTickUnit = 1;
                    requestTickChart(selectedTickUnit);
                }
            }
            else if (sender.Equals(this.n3Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 3;
                    requestMinuteChart(selectedMinuteUnit);
                }
                else if (isTickSelected)
                {
                    selectedTickUnit = 3;
                    requestTickChart(selectedTickUnit);
                }
            }
            else if (sender.Equals(this.n5Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 5;
                    requestMinuteChart(selectedMinuteUnit);
                }
                else if (isTickSelected)
                {
                    selectedTickUnit = 5;
                    requestTickChart(selectedTickUnit);
                }
            }
            else if (sender.Equals(this.n10Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 10;
                    requestMinuteChart(selectedMinuteUnit);
                }
                else if (isTickSelected)
                {
                    selectedTickUnit = 10;
                    requestTickChart(selectedTickUnit);
                }
            }
            else if (sender.Equals(this.n15Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 15;
                    requestMinuteChart(selectedMinuteUnit);
                }
            }
            else if (sender.Equals(this.n30Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 30;
                    requestMinuteChart(selectedMinuteUnit);
                }
                else if (isTickSelected)
                {
                    selectedTickUnit = 30;
                    requestTickChart(selectedTickUnit);
                }
            }
            else if (sender.Equals(this.n45Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 45;
                    requestMinuteChart(selectedMinuteUnit);
                }
            }
            else if (sender.Equals(this.n60Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 60;
                    requestMinuteChart(selectedMinuteUnit);
                }
            }
            else if (sender.Equals(this.searchButton))
            {
                tabPage2.Controls.Clear(); // 기존 내용 제거

                종목검색창 = jamongCommonClass.Get종목검색창();   //종목검색창 객체 불러오기
                종목검색창.setOnSearchedItemSelectedListener(new MyOnSearchedItemSelectedListener(this)); //종목 선택 이벤트 등록
                                                                                                     //종목검색창.Show(); //종목검색창 띄우기
                종목검색창.TopLevel = false;
                종목검색창.FormBorderStyle = FormBorderStyle.None;
                종목검색창.Dock = DockStyle.Fill;

                tabPage2.Controls.Clear();
                tabPage2.Controls.Add(종목검색창);

                종목검색창.Size = new Size(473, 551);
                AdjustButtonLayoutForWidePanel();
                종목검색창.Show();
                LoadNewsToListBox();
            }
            else if (sender.Equals(this.btnAccountSerach))
            {
                if (cmbMyAccounts.SelectedItem == null) return;

                string account = cmbMyAccounts.SelectedItem.ToString();
                if (accountTimer == null)
                {
                    accountTimer = new Timer();
                    accountTimer.Interval = 1000; // 1초 주기
                    accountTimer.Tick += (s, ev) =>
                    {
                        if (cmbMyAccounts.SelectedItem == null) return;
                        account = cmbMyAccounts.SelectedItem.ToString();

                        // ✅ 예수금 조회
                        axKHOpenAPI1.SetInputValue("계좌번호", account);
                        axKHOpenAPI1.SetInputValue("비밀번호", "6571");
                        axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
                        axKHOpenAPI1.SetInputValue("조회구분", "3");
                        axKHOpenAPI1.CommRqData("예수금조회", "opw00001", 0, "2000");

                        // ✅ 평가손익 조회 추가 (OPW00018)
                        axKHOpenAPI1.SetInputValue("계좌번호", account);
                        axKHOpenAPI1.SetInputValue("비밀번호", "6571");
                        axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
                        axKHOpenAPI1.SetInputValue("조회구분", "1");
                        axKHOpenAPI1.CommRqData("계좌평가잔고내역요청", "opw00018", 0, "2001");

                    };
                }
                // 미체결 매수, 매도 조회
                RequestUnfulfilledOrders(account);
                accountTimer.Start(); // 중복 생성 없이 재사용!
            }
        }



        private void turnNButtonsEnabled(Boolean isEnable)
        {
            n1Button.Enabled = isEnable;
            n3Button.Enabled = isEnable;
            n5Button.Enabled = isEnable;
            n10Button.Enabled = isEnable;
            n15Button.Enabled = isEnable;
            n30Button.Enabled = isEnable;
            n45Button.Enabled = isEnable;
            n60Button.Enabled = isEnable;

            isMinuteSelected = isEnable;
            isTickSelected = false;
        }

        private void requestDailyChart()
        {
            axKHOpenAPI1.SetInputValue("종목코드", currentStockCode);
            axKHOpenAPI1.SetInputValue("기준일자", DateTime.Now.ToString("yyyyMMdd"));
            axKHOpenAPI1.SetInputValue("수정주가구분", "1");

            int nRet = axKHOpenAPI1.CommRqData("JM_주식일봉차트조회", "OPT10081", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 일봉 정보요청 성공");
            else
                Console.WriteLine("주식 일봉 정보요청 실패");
        }

        private void requestWeeklyChart()
        {
            axKHOpenAPI1.SetInputValue("종목코드", currentStockCode);
            axKHOpenAPI1.SetInputValue("기준일자", DateTime.Now.ToString("yyyyMMdd"));
            axKHOpenAPI1.SetInputValue("끝일자", "");
            axKHOpenAPI1.SetInputValue("수정주가구분", "1");

            int nRet = axKHOpenAPI1.CommRqData("JM_주식주봉차트조회", "OPT10082", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 주봉 정보요청 성공");
            else
                Console.WriteLine("주식 주봉 정보요청 실패");
        }

        private void requestMonthlyChart()
        {
            axKHOpenAPI1.SetInputValue("종목코드", currentStockCode);
            axKHOpenAPI1.SetInputValue("기준일자", DateTime.Now.ToString("yyyyMMdd"));
            axKHOpenAPI1.SetInputValue("끝일자", "");
            axKHOpenAPI1.SetInputValue("수정주가구분", "1");

            int nRet = axKHOpenAPI1.CommRqData("JM_주식월봉차트조회", "OPT10083", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 월봉 정보요청 성공");
            else
                Console.WriteLine("주식 월봉 정보요청 실패");
        }

        private void requestMinuteChart(int minuteUnit)
        {
            axKHOpenAPI1.SetInputValue("종목코드", currentStockCode);
            axKHOpenAPI1.SetInputValue("틱범위", minuteUnit + "");
            axKHOpenAPI1.SetInputValue("수정주가구분", "1");

            int nRet = axKHOpenAPI1.CommRqData("JM_주식분봉차트조회", "OPT10080", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 분봉 정보요청 성공");
            else
                Console.WriteLine("주식 분봉 정보요청 실패");
        }

        private void requestTickChart(int tickUnit)
        {
            axKHOpenAPI1.SetInputValue("종목코드", currentStockCode);
            axKHOpenAPI1.SetInputValue("틱범위", tickUnit.ToString());
            axKHOpenAPI1.SetInputValue("수정주가구분", "1");

            int nRet = axKHOpenAPI1.CommRqData("JM_주식틱봉차트조회", "OPT10079", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 틱봉 정보요청 성공");
            else
                Console.WriteLine("주식 틱봉 정보요청 실패");
        }

        private void requestStockInfo(string 종목코드)
        {
            axKHOpenAPI1.SetInputValue("종목코드", this.itemCodeTextBox.Text.Trim());

            int nRet = axKHOpenAPI1.CommRqData("JM_주식기본정보요청", "OPT10001", 0, "1003");

            if (nRet == 0)
                Console.WriteLine("주식기본정보요청 성공");
            else
                Console.WriteLine("주식기본정보요청 실패");
        }

        private void axKHOpenAPI_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName == "JM_주식일봉차트조회" || e.sRQName == "JM_주식주봉차트조회" || e.sRQName == "JM_주식월봉차트조회" || e.sRQName == "JM_주식분봉차트조회" || e.sRQName == "JM_주식틱봉차트조회")
            {
                try
                {
                    int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                    priceInfoList = new List<PriceInfoEntityObject>();
                    priceSeries.Points.Clear();
                    volumeSeries.Points.Clear();

                    if (e.sRQName == "JM_주식분봉차트조회" || e.sRQName == "JM_주식틱봉차트조회")
                        chart1.ChartAreas[1].AxisY.LabelStyle.Format = "#,##0";
                    else
                        chart1.ChartAreas[1].AxisY.LabelStyle.Format = "#,##0,K";
                    ChartArea priceChartArea = chart1.ChartAreas["PriceChartArea"];
                    do
                    {
                        priceChartArea.AxisX.ScaleView.ZoomReset();
                    }
                    while (priceChartArea.AxisX.ScaleView.IsZoomed);

                    int maxValue = 0;
                    int minValue = int.MaxValue;

                    for (int nIdx = 0; nIdx < nCnt; nIdx++)
                    {
                        if (e.sRQName == "JM_주식분봉차트조회" || e.sRQName == "JM_주식틱봉차트조회")
                            priceInfoList.Add(new PriceInfoEntityObject()
                            {
                                일자 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "체결시간").Trim(),
                                시가 = Math.Abs(Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "시가").Trim())),
                                고가 = Math.Abs(Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "고가").Trim())),
                                저가 = Math.Abs(Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "저가").Trim())),
                                종가 = Math.Abs(Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "현재가").Trim())),
                                거래량 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "거래량").Trim()),
                            });
                        else
                            priceInfoList.Add(new PriceInfoEntityObject()
                            {
                                일자 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "일자").Trim(),
                                시가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "시가").Trim()),
                                고가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "고가").Trim()),
                                저가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "저가").Trim()),
                                종가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "현재가").Trim()),
                                거래량 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "거래량").Trim()),
                            });
                        if (priceInfoList[nIdx].고가 > maxValue)
                            maxValue = priceInfoList[nIdx].고가;
                        if (priceInfoList[nIdx].저가 < minValue)
                            minValue = priceInfoList[nIdx].저가;

                        // adding date and high
                        priceSeries.Points.AddXY(priceInfoList[nIdx].일자, priceInfoList[nIdx].고가);
                        // adding low
                        priceSeries.Points[nIdx].YValues[1] = priceInfoList[nIdx].저가;
                        //adding open
                        priceSeries.Points[nIdx].YValues[2] = priceInfoList[nIdx].시가;
                        // adding close
                        priceSeries.Points[nIdx].YValues[3] = priceInfoList[nIdx].종가;

                        priceSeries.Points[nIdx].ToolTip = "일자 : " + priceInfoList[nIdx].일자 + "\n"
                                                          + "시가 : " + String.Format("{0:#,###}", priceInfoList[nIdx].시가) + "\n"
                                                          + "고가 : " + String.Format("{0:#,###}", priceInfoList[nIdx].고가) + "\n"
                                                          + "저가 : " + String.Format("{0:#,###}", priceInfoList[nIdx].저가) + "\n"
                                                          + "종가 : " + String.Format("{0:#,###}", priceInfoList[nIdx].종가) + "\n"
                                                          + "거래량 : " + String.Format("{0:#,###}", priceInfoList[nIdx].거래량);

                        volumeSeries.Points.AddXY(priceInfoList[nIdx].일자, priceInfoList[nIdx].거래량);

                        volumeSeries.Points[nIdx].ToolTip = "일자 : " + priceInfoList[nIdx].일자 + "\n"
                                                           + "거래량 : " + String.Format("{0:#,###}", priceInfoList[nIdx].거래량);

                    }

                    requestStockInfo(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드").Trim());

                    if (nCnt > 0)
                    {
                        priceChartArea.AxisX.ScaleView.ZoomReset();

                        priceChartArea.AxisY.Maximum = maxValue;
                        priceChartArea.AxisY.Minimum = minValue;

                        if (!priceChartArea.AxisX.ScaleView.IsZoomed)
                            chart1_AxisViewChanged(chart1, new ViewEventArgs(priceChartArea.AxisX, 0));
                    }

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message.ToString());
                }

            }
            else if (e.sRQName == "JM_주식기본정보요청")
            {
                try
                {
                    int 현재가 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가"));
                    int 전일대비 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비"));
                    double 등락율 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim());
                    double 거래량 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량"));
                    double 거래대비 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래대비"));
                    int 시가 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "시가"));
                    int 고가 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "고가"));
                    int 저가 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "저가"));

                    SetStockInfo(현재가, 전일대비, 등락율, 거래량, 거래대비, 0, 0, 시가, 고가, 저가);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message.ToString());
                }
            }

            else if (e.sRQName == "예수금조회")
            {
                try
                {
                    string depositStr = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "예수금").Trim();
                    string buyableStr = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "주문가능금액").Trim();

                    long deposit = long.Parse(depositStr.Replace(",", ""));
                    long buyable = long.Parse(buyableStr.Replace(",", ""));

                    // 예수금 라벨
                    labelTotal.Text = $"{deposit:N0} 원";
                    labelTotal.ForeColor = deposit >= 0 ? Color.Black : Color.Red;


                    // 주문가능금액 라벨
                    labelBuyable.Text = $"{buyable:N0} 원";
                    labelBuyable.ForeColor = buyable >= 0 ? Color.Black : Color.Red;

                    UpdateBuyQuantityLimit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("예수금 조회 오류: " + ex.Message);
                    labelTotal.Text = "조회 실패";
                    labelBuyable.Text = "조회 실패";
                    labelTotal.ForeColor = Color.Black;
                    labelBuyable.ForeColor = Color.Black;
                }
            }




            else if (e.sRQName == "계좌평가잔고내역요청")
            {
                string 손익 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "평가손익").Trim();
                string 매입금액 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총매입금액").Trim();
                string 평가금액 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총평가금액").Trim();

                if (long.TryParse(매입금액.Replace(",", ""), out long buy) &&
                    long.TryParse(평가금액.Replace(",", ""), out long eval))
                {
                    double 수익률 = ((double)(eval - buy) / buy) * 100;

                    labelProfit.Text = $"{(eval - buy):N0} 원 ({수익률:F2}%)";
                    labelProfit.ForeColor = (eval - buy) >= 0 ? Color.Red : Color.Blue;

                    labelTotalBuy.Text = $"{buy:N0} 원"; // 총매입금액
                    labelTotalEval.Text = $"{eval:N0} 원"; // ⬅ 총평가금액 추가 표시!
                }
                else
                {
                    labelProfit.Text = "조회 실패";
                    labelTotalBuy.Text = "조회 실패";
                }

                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                listViewHoldings.Items.Clear();

                for (int i = 0; i < nCnt; i++)
                {
                    string name = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();  //정상
                    string qtyStr = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량");  // 정상
                    string avgPriceStr = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "평균단가"); // 정상
                    if (string.IsNullOrWhiteSpace(avgPriceStr))
                    {
                        avgPriceStr = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입가"); //정상
                    }
                    string currentPriceStr = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가"); //정상


                    string profitStr = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "평가금액"); //비정상
                    string code = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목번호").Trim();
                    if (code.StartsWith("A")) code = code.Substring(1); // 앞의 A 제거


                    ListViewItem item = new ListViewItem(name);

                    try
                    {
                        long quantity = long.Parse(CleanString(qtyStr));
                        long avgPrice = long.Parse(CleanAndParse(avgPriceStr));
                        long nowPrice = long.Parse(CleanString(currentPriceStr));


                        // ✅ 계산식 적용
                        long profit = (nowPrice - avgPrice) * quantity;
                        double rate = avgPrice > 0 ? ((double)(nowPrice - avgPrice) / avgPrice) * 100 : 0;
                        long profita = long.Parse(CleanString(profitStr));
                        //double rate = double.Parse(CleanString(rateStr));

                        item.SubItems.Add($"{quantity:N0}");
                        item.SubItems.Add($"{avgPrice:N0}");
                        item.SubItems.Add($"{nowPrice:N0}");


                        item.SubItems.Add($"{profita:N0}");

                        ListViewItem.ListViewSubItem profitSubItem = new ListViewItem.ListViewSubItem();
                        profitSubItem.Text = $"{profit:N0} ({rate:F2}%)";
                        profitSubItem.ForeColor = profit >= 0 ? Color.Red : Color.Blue;

                        item.SubItems.Add(profitSubItem);
                        item.SubItems.Add($"{code}"); // ✅ 종목코드 열
                    }
                    catch
                    {
                        item.SubItems.Add(qtyStr.Trim());
                        item.SubItems.Add(avgPriceStr.Trim());
                        item.SubItems.Add(currentPriceStr.Trim());
                        item.SubItems.Add("계산 실패");
                        item.SubItems.Add("N/A");
                    }

                    listViewHoldings.Items.Add(item);
                }

            }

            else if (e.sRQName == "미체결요청")
            {
                listViewOrders.Items.Clear();
                int count = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                for (int i = 0; i < count; i++)
                {
                    string orderNo = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문번호").Trim();
                    string name = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    string code = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();
                    // 부호 제거하고 명확하게 표시
                    string rawType = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문구분").Trim();
                    string type = rawType.Contains("매도") ? "매도" : "매수";

                    string quantity = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문수량").Trim();
                    string price = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문가격").Trim();
                    string executed = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "체결량").Trim();
                    string remainQty = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "미체결수량").Trim();
                    string status = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문상태").Trim();

                    if (int.TryParse(remainQty.Replace(",", ""), out int remain) && remain == 0)
                        continue;

                    ListViewItem item = new ListViewItem(orderNo);
                    item.SubItems.Add(name);
                    item.SubItems.Add(code);
                    item.SubItems.Add(type);
                    item.SubItems.Add(quantity);
                    item.SubItems.Add(price);
                    item.SubItems.Add(executed);
                    item.SubItems.Add(remainQty);
                    item.SubItems.Add(status);

                    listViewOrders.Items.Add(item);

                }
            }

            else if (e.sRQName.StartsWith("관심_"))
            {
                try
                {
                    string code = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드").Trim();
                    string 현재가str = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim();
                    string 등락율str = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim();

                    //MessageBox.Show(code);
                    int 현재가 = Math.Abs(int.Parse(현재가str));
                    double 등락률 = double.Parse(등락율str);

                    if (code.StartsWith("A")) code = code.Substring(1); // 앞의 A 제거

                    foreach (ListViewItem item in listViewInterest.Items)
                    {
                        if (item.SubItems[1].Text == code)
                        {
                            item.SubItems[2].Text = $"{현재가:N0}";
                            item.SubItems[3].Text = $"{등락률:F2}%";

                            item.SubItems[3].ForeColor = 등락률 >= 0 ? Color.Red : Color.Blue;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("관심종목 정보 업데이트 오류: " + ex.Message);
                }
                finally
                {
                    isRequesting = false;
                    RequestNextInterest(); // ❗ 반드시 finally 블록에서 호출
                }

            }
            

        }
        private void listViewOrders_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }



        private void listViewOrders_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex == 3) // 주문구분(매수/매도)
            {
                string text = e.SubItem.Text;
                Color color = text.Contains("매수") ? Color.Red : text.Contains("매도") ? Color.Blue : Color.Black;

                using (Brush brush = new SolidBrush(color))
                {
                    e.Graphics.DrawString(text, listViewOrders.Font, brush, e.Bounds);
                }
            }
            else
            {
                e.DrawDefault = true;
            }
        }


        string CleanString(string input)
        {
            input = input.Replace(",", "").Trim();

            // 전부 0이거나 비어있을 경우 0 반환
            if (string.IsNullOrWhiteSpace(input) || input.All(c => c == '0'))
                return "0";

            return input.TrimStart('0');
        }
        string CleanAndParse(string raw)
        {
            raw = raw.Replace(",", "").Trim();

            // 전부 0이거나 비어있으면 "0"
            if (string.IsNullOrWhiteSpace(raw) || raw.All(c => c == '0'))
                return "0";

            return raw.TrimStart('0');
        }


        private void SetStockInfo(int 현재가, int 전일대비, double 등락율, double 거래량, double 거래대비, double 거래회전율, double 거래대금, int 시가, int 고가, int 저가)
        {
            if (전일대비 > 0)
            {
                currentPriceLabel.ForeColor = Color.Red;
                netChangeLabel.ForeColor = Color.Red;
                fluctuationRateLabel.ForeColor = Color.Red;
            }
            else if (전일대비 < 0)
            {
                currentPriceLabel.ForeColor = Color.Blue;
                netChangeLabel.ForeColor = Color.Blue;
                fluctuationRateLabel.ForeColor = Color.Blue;

                현재가 *= -1;
            }

            if (거래대비 > 0)
                volumeChangeLabel.ForeColor = Color.Red;
            else if (거래대비 < 0)
            {
                volumeChangeLabel.ForeColor = Color.Blue;
                거래대비 *= -1;
            }

            if (시가 > 0)
                openPriceLabel.ForeColor = Color.Red;
            else if (시가 < 0)
            {
                openPriceLabel.ForeColor = Color.Blue;
                시가 *= -1;
            }
            if (고가 > 0)
                highPriceLabel.ForeColor = Color.Red;
            else if (고가 < 0)
            {
                highPriceLabel.ForeColor = Color.Blue;
                고가 *= -1;
            }
            if (저가 > 0)
                lowPriceLabel.ForeColor = Color.Red;
            else if (저가 < 0)
            {
                lowPriceLabel.ForeColor = Color.Blue;
                저가 *= -1;
            }

            currentPriceLabel.Text = String.Format("{0:#,###}", 현재가);
            netChangeLabel.Text = String.Format("{0:#,###}", 전일대비);
            fluctuationRateLabel.Text = 등락율 + "%";
            accumulatedVolumeLabel.Text = String.Format("{0:#,###}", 거래량);
            volumeChangeLabel.Text = 거래대비 + "%";
            turnoverRatioLabel.Text = 거래회전율 + "%";
            tradingValueLabel.Text = String.Format("{0:#,###}", 거래대금) + "백만";
            openPriceLabel.Text = String.Format("{0:#,###}", 시가);
            highPriceLabel.Text = String.Format("{0:#,###}", 고가);
            lowPriceLabel.Text = String.Format("{0:#,###}", 저가);
            Console.WriteLine(시가);
            if (cmbBuyOrderType.SelectedIndex == 1) // 1 = 시장가
            {
                try
                {
                    numBuyPrice.Value = 현재가;
                }
                catch
                {
                    numBuyPrice.Value = 0;
                }
            }
            if (cmbSellOrderType.SelectedIndex == 1)
            {
                try
                {
                    numSellPrice.Value = 현재가;
                }
                catch
                {
                    numSellPrice.Value = 0;
                }
            }
        }

        private void cmbBuyOrderType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            numBuyPrice.Enabled = (cmbBuyOrderType.SelectedIndex != 1); // 시장가면 입력 비활성화
        }
        private void cmbSellOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            numSellPrice.Enabled = (cmbSellOrderType.SelectedIndex != 1);
        }
        private void axKHOpenAPI_OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            if (e.sRealType == "주식체결")
            {
                string 종목코드 = e.sRealKey;
                //Console.WriteLine(종목코드);
                if (currentStockCode.Equals(종목코드))
                {
                    int 현재가 = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 10));
                    int 전일대비 = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 11));
                    double 등락율 = double.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 12));
                    double 거래량 = double.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 13));
                    double 거래대비 = double.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 30));
                    double 거래회전율 = double.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 31));
                    double 거래대금 = double.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 14));
                    int 시가 = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 16));
                    int 고가 = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 17));
                    int 저가 = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 18));

                    SetStockInfo(현재가, 전일대비, 등락율, 거래량, 거래대비, 거래회전율, 거래대금, 시가, 고가, 저가);
                }
            }
        }

        private void chart1_AxisViewChanged(object sender, ViewEventArgs e)
        {
            if (sender.Equals(chart1))
            {
                try
                {
                    int startPosition = (int)e.Axis.ScaleView.ViewMinimum;
                    int endPosition = (int)e.Axis.ScaleView.ViewMaximum;

                    int max = 0;
                    int min = int.MaxValue;

                    int volumeMax = 0;
                    int volumeMin = int.MaxValue;

                    for (int i = startPosition - 1; i < endPosition; i++)
                    {
                        if (i >= priceInfoList.Count)
                            break;
                        if (i < 0)
                            i = 0;

                        if (priceInfoList[i].고가 > max)
                            max = priceInfoList[i].고가;
                        if (priceInfoList[i].저가 < min)
                            min = priceInfoList[i].저가;

                        if (priceInfoList[i].거래량 > volumeMax)
                            volumeMax = priceInfoList[i].거래량;
                        if (priceInfoList[i].거래량 < volumeMin)
                            volumeMin = priceInfoList[i].거래량;
                    }

                    double offset = 0.2 * (max - min);
                    this.chart1.ChartAreas[0].AxisY.Maximum = max + offset;
                    this.chart1.ChartAreas[0].AxisY.Minimum = min - offset;

                    double volumeOffset = 0.2 * (volumeMax - volumeMin);
                    this.chart1.ChartAreas[1].AxisY.Maximum = volumeMax + volumeOffset;
                    if (volumeMin - volumeOffset > 0)
                        this.chart1.ChartAreas[1].AxisY.Minimum = volumeMin - volumeOffset;
                    else
                        this.chart1.ChartAreas[1].AxisY.Minimum = 0;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message.ToString());
                }
            }

        }

        private void chart_MouseMove(object sender, MouseEventArgs e)
        {
            ChartArea priceChartArea = chart1.ChartAreas[0];
            ChartArea volumeChartArea = chart1.ChartAreas[1];
            Point mousePoint = new Point(e.X, e.Y);


            if (chart1.Height * 0.05 < e.Y && e.Y < chart1.Height * 0.57)
            {
                chartYLabel.Visible = true;
                priceChartArea.CursorX.SetCursorPixelPosition(mousePoint, true);
                priceChartArea.CursorY.SetCursorPixelPosition(mousePoint, true);


                chartYLabel.Text = String.Format("{0:#,###}", priceChartArea.CursorY.Position);
                chartYLabel.Location = new Point((int)(chart1.Width * 0.9), e.Y - chartYLabel.Height / 2);
            }
            else if (chart1.Height * 0.605 < e.Y && e.Y < chart1.Height * 0.915)
            {
                chartYLabel.Visible = true;
                volumeChartArea.CursorX.SetCursorPixelPosition(mousePoint, true);
                volumeChartArea.CursorY.SetCursorPixelPosition(mousePoint, true);

                chartYLabel.Text = String.Format("{0:#,###}", volumeChartArea.CursorY.Position);
                chartYLabel.Location = new Point((int)(chart1.Width * 0.9), e.Y - chartYLabel.Height / 2);
            }
            else
            {
                chartYLabel.Visible = false;
            }
        }


        class MyOnSearchedItemSelectedListener : OnSearchedItemSelectedListener
        {
            Form1 form1;
            public MyOnSearchedItemSelectedListener(Form1 form1)
            {
                this.form1 = form1;
            }
            public void OnSelected(string 종목명, string 종목코드)
            {
                try
                {
                    //Console.WriteLine("종목명=" + 종목명 + " 종목코드=" + 종목코드);
                form1.itemCodeTextBox.Text = 종목코드;

                form1.currentStockCode = 종목코드;

                form1.cmbBuyStockCode.Text = 종목코드; // <- 콤보박스에도 선택된 코드 반영
                form1.txtStockName.Text = 종목명;

                form1.cmbSellStockCode.Text = 종목코드;         // 💸 매도 종목코드 자동 입력
                form1.txtSellStockName.Text = 종목명;           // 💸 매도 종목명 자동 표시

                form1.itemNameLabel.Text = form1.axKHOpenAPI1.GetMasterCodeName(form1.currentStockCode);

                // ✅ 주문유형: 시장가 자동 선택
                form1.cmbBuyOrderType.SelectedIndex = 1;
                form1.cmbSellOrderType.SelectedIndex = 1;       // 💸 매도 주문유형도 '시장가'로 기본

                try { form1.ApplyInterestCheckStatus(종목코드, 종목명); }
                catch (Exception ex) { MessageBox.Show("ApplyInterestCheckStatus 오류: " + ex.Message); }

                try { form1.requestDailyChart(); }
                catch (Exception ex) { MessageBox.Show("requestDailyChart 오류: " + ex.Message); }

                try { form1.LoadNewsToListBox(); }
                catch (Exception ex) { MessageBox.Show("LoadNewsToListBox 오류: " + ex.Message); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ OnSelected 내부 오류: " + ex.Message);
                }
            }
        }

        private void btnBuyOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string stockCode = cmbBuyStockCode.Text.Trim(); // 종목코드
                int quantity = (int)numBuyQuantity.Value;
                int price = (int)numBuyPrice.Value;

                if (string.IsNullOrEmpty(stockCode) || quantity <= 0 || cmbMyAccounts.SelectedItem == null)
                {
                    MessageBox.Show("주문 정보를 정확히 입력해주세요.");
                    return;
                }

                // 호가구분 코드 매핑
                string[] hogaGbCodes = { "00", "03", "05", "06" };
                string orderType = hogaGbCodes[cmbBuyOrderType.SelectedIndex];

                // 선택된 계좌 사용
                string account = cmbMyAccounts.SelectedItem.ToString();

                int result = axKHOpenAPI1.SendOrder(
                    "매수주문",
                    GetScreenNo(),
                    account,
                    1, // 매수
                    stockCode,
                    quantity,
                    price,
                    orderType,
                    ""
                );

                if (result == 0)
                {
                    MessageBox.Show("매수 주문 요청 성공!");

                    RequestUnfulfilledOrders(account);
                }
                else
                    MessageBox.Show("매수 주문 요청 실패! 코드: " + result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
        }


        private string GetScreenNo()
        {
            string stockCode = itemCodeTextBox.Text.Trim();

            // 종목코드가 6자리 이상일 때만 처리
            if (!string.IsNullOrEmpty(stockCode) && stockCode.Length >= 6)
            {
                // 예시: 종목코드 마지막 3자리 + 접두사
                return "1" + stockCode.Substring(stockCode.Length - 3);  // 예: 1ABC
            }

            // 기본 스크린 번호
            return "1000";
        }

        public async void LoadNewsToListBox()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            listBox1.Visible = true;

            string url = $"https://finance.naver.com/item/news_news.naver?code={currentStockCode}&page=1&sm=title_entity_id.basic";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            client.DefaultRequestHeaders.Add("Referer", "https://finance.naver.com");

            string html;
            try
            {
                html = await client.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("뉴스를 가져오는 데 실패했습니다: " + ex.Message);
                return;
            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var newsRows = doc.DocumentNode.SelectNodes("//table[@class='type5']//tr");

            if (newsRows == null)
            {
                MessageBox.Show("❌ 뉴스 항목을 찾을 수 없습니다.");
                return;
            }

            newsList.Clear();
            listBox1.Items.Clear();

            foreach (var row in newsRows)
            {
                var titleNode = row.SelectSingleNode(".//a");
                var timeNode = row.SelectSingleNode(".//td[@class='date']");

                if (titleNode != null && timeNode != null)
                {
                    string title = WebUtility.HtmlDecode(titleNode.InnerText.Trim());
                    string time = timeNode.InnerText.Trim();
                    string link = "https://finance.naver.com" + titleNode.GetAttributeValue("href", "#");

                    string itemText = $"[{time}] {title}";
                    newsList.Add(new NewsItem { Title = itemText, Link = link });
                    listBox1.Items.Add(itemText);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index >= 0 && index < newsList.Count)
            {
                string link = newsList[index].Link;
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = link,
                    UseShellExecute = true // 필수 (링크 브라우저에서 열기)
                });
            }
        }
        private void StyleListBox()
        {
            listBox1.Font = new Font("맑은 고딕", 9, FontStyle.Regular);
            listBox1.ItemHeight = 30;
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;

            listBox1.DrawItem += (s, e) =>
            {
                if (e.Index < 0) return;

                string text = listBox1.Items[e.Index].ToString();
                bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

                e.DrawBackground();
                using (Brush brush = new SolidBrush(selected ? Color.LightSkyBlue : Color.White))
                    e.Graphics.FillRectangle(brush, e.Bounds);

                using (Brush textBrush = new SolidBrush(Color.Black))
                    e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds);

                e.DrawFocusRectangle();
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBuyOrderType.Items.AddRange(new string[] { "00: 지정가", "03: 시장가", "05: 조건부지정가", "06: 최유리지정가" });
            cmbBuyOrderType.SelectedIndex = 0;
            cmbSellOrderType.Items.AddRange(new string[] { "00: 지정가", "03: 시장가", "05: 조건부지정가", "06: 최유리지정가" });
            cmbSellOrderType.SelectedIndex = 0;
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            StyleListBox();

            listViewHoldings.OwnerDraw = true;
            listViewHoldings.DrawSubItem += listViewHoldings_DrawSubItem;
            listViewHoldings.DrawColumnHeader += listViewHoldings_DrawColumnHeader;

            listViewInterest.OwnerDraw = true;
            listViewInterest.DrawSubItem += listViewInterest_DrawSubItem;
            listViewInterest.DrawColumnHeader += listViewInterest_DrawColumnHeader;

              
        }
        private void listViewHoldings_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true; // 이거 없으면 헤더가 안 보여!
        }
        private void listViewInterest_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listViewHoldings_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex == 5) // 손익률이 있는 컬럼 (예: 5번째면 Index 4)
            {
                string text = e.SubItem.Text;

                Brush brush = text.Contains("-") ? Brushes.Blue : Brushes.Red;

                e.Graphics.DrawString(text, listViewHoldings.Font, brush, e.Bounds);
            }
            else
            {
                e.DrawDefault = true; // 나머지는 기본 출력
            }
        }
        private void listViewInterest_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Color color = Color.Black;

            if (e.ColumnIndex == 3) // 등락률 컬럼
            {
                string text = e.SubItem.Text.Replace("%", "").Trim();
                if (double.TryParse(text, out double rate))
                {
                    color = rate > 0 ? Color.Red : rate < 0 ? Color.Blue : Color.Black;
                }
            }

            e.Graphics.DrawString(e.SubItem.Text, listViewInterest.Font, new SolidBrush(color), e.Bounds);
        }



        public void AdjustButtonLayoutForWidePanel()
        {
            int newX = 416; // 기존 324에서 +112 이동

            // 위치 재조정
            종목검색창.ㄱbutton.Location = new Point(newX, 85);
            종목검색창.ㄴbutton.Location = new Point(newX, 112);
            종목검색창.ㄷbutton.Location = new Point(newX, 139);
            종목검색창.ㄹbutton.Location = new Point(newX, 165);
            종목검색창.ㅁbutton.Location = new Point(newX, 191);
            종목검색창.ㅂbutton.Location = new Point(newX, 218);
            종목검색창.ㅅbutton.Location = new Point(newX, 245);
            종목검색창.ㅇbutton.Location = new Point(newX, 272);
            종목검색창.ㅈbutton.Location = new Point(newX, 299);
            종목검색창.ㅊbutton.Location = new Point(newX, 326);
            종목검색창.ㅋbutton.Location = new Point(newX, 353);
            종목검색창.ㅌbutton.Location = new Point(newX, 380);
            종목검색창.ㅍbutton.Location = new Point(newX, 407);
            종목검색창.ㅎbutton.Location = new Point(newX, 434);
            종목검색창.Abutton.Location = new Point(newX, 461);
            종목검색창.numbutton.Location = new Point(newX, 488);

            //종목검색창.itemSearchGridView.Size = new Size(newX, 600);
            종목검색창.itemGridView.Size = new Size(newX - 20, 430);

            종목검색창.panel1.Size = new Size(473, 551);
        }

        private void btnSellOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string stockCode = cmbSellStockCode.Text.Trim(); // 종목코드 콤보박스
                int quantity = (int)numSellQuantity.Value;
                int price = (int)numSellPrice.Value;

                if (string.IsNullOrEmpty(stockCode) || quantity <= 0 || cmbMyAccounts.SelectedItem == null)
                {
                    MessageBox.Show("주문 정보를 정확히 입력해주세요.");
                    return;
                }

                // 호가구분 코드 (매수 때와 동일)
                string[] hogaGbCodes = { "00", "03", "05", "06" };
                string orderType = hogaGbCodes[cmbSellOrderType.SelectedIndex]; // 매도용 콤보박스

                string account = cmbMyAccounts.SelectedItem.ToString();

                int result = axKHOpenAPI1.SendOrder(
                    "매도주문",
                    GetScreenNo(),
                    account,
                    2, // ✅ 매도는 2번
                    stockCode,
                    quantity,
                    price,
                    orderType,
                    ""
                );

                if (result == 0)
                {
                    MessageBox.Show("매도 주문 요청 성공!");
                    RequestUnfulfilledOrders(account);
                }
                else
                    MessageBox.Show("매도 주문 요청 실패! 코드: " + result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("매도 오류: " + ex.Message);
            }
        }

        private void cmbSellStockCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string code = cmbSellStockCode.Text.Trim();

            if (!string.IsNullOrEmpty(code))
            {
                string name = axKHOpenAPI1.GetMasterCodeName(code);
                txtSellStockName.Text = name; // ✅ 종목명 텍스트박스에 표시
            }
        }

        private void UpdateBuyQuantityLimit()
        {
            try
            {
                long buyable = long.Parse(labelBuyable.Text.Replace("원", "").Replace(",", "").Trim());
                int price = (int)numBuyPrice.Value;

                if (price > 0)
                {
                    int maxQty = (int)(buyable / price);
                    numBuyQuantity.Maximum = maxQty > 0 ? maxQty : 1;

                    // ✅ 여기!
                    lblMaxBuyQuantity.Text = $"(최대 {numBuyQuantity.Maximum}주)";
                }
                else
                {
                    numBuyQuantity.Maximum = 1;
                    lblMaxBuyQuantity.Text = "(가격 없음)";
                }
            }
            catch
            {
                numBuyQuantity.Maximum = 1;
                lblMaxBuyQuantity.Text = "(조회 실패)";
            }
        }

        private void listViewHoldings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHoldings.SelectedItems.Count > 0)
            {
                var selectedItem = listViewHoldings.SelectedItems[0];
                string selectedCode = selectedItem.SubItems[6].Text;

                // 보유수량은 2번째 컬럼
                if (long.TryParse(selectedItem.SubItems[1].Text.Replace(",", ""), out long maxSellQty))
                {
                    numSellQuantity.Maximum = maxSellQty;
                    lblMaxSellQuantity.Text = $"(최대 {maxSellQty:N0}주)";
                }

                searchedItemListener = new MyOnSearchedItemSelectedListener(this);
                searchedItemListener.OnSelected(selectedItem.Text, selectedCode);
            }
        }

        private void SaveInterestStock(string stockCode, string stockName)
        {
            string path = "interest.env";
            string entry = $"{stockCode},{stockName}";

            var lines = File.Exists(path) ? File.ReadAllLines(path).ToList() : new List<string>();

            if (!lines.Contains(entry))
            {
                lines.Add(entry);
                File.WriteAllLines(path, lines);
            }
        }


        private void InterestCheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticCheck) return; // 자동체크일 경우 무시

            // 서로 연동되도록 구성
            if (sender == chkInterestBuy && !chkInterestSell.Checked)
            {
                isProgrammaticCheck = true;
                chkInterestSell.Checked = true;
                isProgrammaticCheck = false;
            }
            else if (sender == chkInterestSell && !chkInterestBuy.Checked)
            {
                isProgrammaticCheck = true;
                chkInterestBuy.Checked = true;
                isProgrammaticCheck = false;
            }


            // 두 개가 모두 true가 되었을 때만 메시지박스 등장 + 저장
            if (chkInterestBuy.Checked && chkInterestSell.Checked && !hasPromptedInterest)
            {
                hasPromptedInterest = true;

                var result = MessageBox.Show("관심종목에 추가하시겠습니까?", "관심종목 추가", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveInterestStock(cmbBuyStockCode.Text, txtStockName.Text);
                    LoadInterestStockAll();
                }
            }
        }

        Queue<string> 관심종목큐 = new Queue<string>();
        bool isRequesting = false;

        private async void RequestNextInterest()
        {
            if (isRequesting || 관심종목큐.Count == 0) return;

            string code = 관심종목큐.Dequeue();
            isRequesting = true;

            await Task.Delay(300); // 🔥 딜레이 넣기

            axKHOpenAPI1.SetInputValue("종목코드", code);
            axKHOpenAPI1.CommRqData("관심_" + code, "OPT10001", 0, "5000");
        }


        public void LoadInterestStockAll()
        {
            hasPromptedInterest = false;

            chkInterestBuy.CheckedChanged -= InterestCheckBoxes_CheckedChanged;
            chkInterestSell.CheckedChanged -= InterestCheckBoxes_CheckedChanged;

            chkInterestBuy.Checked = false;
            chkInterestSell.Checked = false;
            listViewInterest.Items.Clear();
            관심종목큐.Clear(); // ✅ 큐 초기화 (중복 방지!!)
            isRequesting = false; // ✅ 여기서 false 초기화


            string path = "interest.env";
            if (!File.Exists(path)) return;

            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 2)
                {
                    string code = parts[0];
                    string name = parts[1];

                    // 리스트뷰에 추가
                    ListViewItem item = new ListViewItem(name);
                    item.SubItems.Add(code);
                    item.SubItems.Add("조회중..."); // 현재가 자리
                    item.SubItems.Add("조회중..."); // 변동률 자리
                    item.SubItems.Add("❌ 삭제");            // ⛔ 삭제 버튼 역할 텍스트

                    listViewInterest.Items.Add(item);

                    관심종목큐.Enqueue(parts[0]); // 종목코드


                    //// 현재 선택된 종목이면 체크
                    if (code == cmbBuyStockCode.Text && name == txtStockName.Text)
                    {
                        chkInterestBuy.Checked = true;
                        chkInterestSell.Checked = true;
                    }
                }

            }
            //MessageBox.Show("큐 상태: " + string.Join(", ", 관심종목큐));
            RequestNextInterest();
            chkInterestBuy.CheckedChanged += InterestCheckBoxes_CheckedChanged;
            chkInterestSell.CheckedChanged += InterestCheckBoxes_CheckedChanged;
        }



        private void ApplyInterestCheckStatus(string selectedStockCode, string selectedStockName)
        {
            string path = "interest.env";
            string entry = $"{selectedStockCode},{selectedStockName}";

            // 중복 메시지 방지용 플래그 초기화
            hasPromptedInterest = false;

            // 이벤트 핸들러 잠시 해제
            chkInterestBuy.CheckedChanged -= InterestCheckBoxes_CheckedChanged;
            chkInterestSell.CheckedChanged -= InterestCheckBoxes_CheckedChanged;

            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                bool found = lines.Any(line => line.Trim() == entry);

                chkInterestBuy.Checked = found;
                chkInterestSell.Checked = found;
            }
            else
            {
                chkInterestBuy.Checked = false;
                chkInterestSell.Checked = false;
            }

            // 다시 핸들러 연결
            chkInterestBuy.CheckedChanged += InterestCheckBoxes_CheckedChanged;
            chkInterestSell.CheckedChanged += InterestCheckBoxes_CheckedChanged;

            LoadInterestStockAll(); // 리스트뷰 갱신 등 필요시
        }

        private void listViewInterest_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewInterest.HitTest(e.Location);

            if (info.Item != null)
            {
                string 종목명 = info.Item.SubItems[0].Text;
                string 종목코드 = info.Item.SubItems[1].Text;

                // 🔔 선택된 종목 자동 반영
                new MyOnSearchedItemSelectedListener(this).OnSelected(종목명, 종목코드);
            }
        }

        private void RemoveInterestStock(string stockCode, string stockName)
        {
            string path = "interest.env";
            if (!File.Exists(path)) return;

            string entry = $"{stockCode},{stockName}";
            var lines = File.ReadAllLines(path).ToList();

            lines.RemoveAll(line => line.Trim() == entry);
            File.WriteAllLines(path, lines);
        }

        private void listViewInterest_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewInterest.HitTest(e.Location);
            if (info.Item != null && info.SubItem != null)
            {
                int subItemIndex = info.Item.SubItems.IndexOf(info.SubItem);

                // 2번째 인덱스(3번째 열)가 "삭제" 버튼
                if (subItemIndex == 4 && info.SubItem.Text.Contains("삭제"))
                {
                    string stockName = info.Item.SubItems[0].Text;
                    string stockCode = info.Item.SubItems[1].Text;

                    var confirm = MessageBox.Show($"{stockName} ({stockCode}) 관심종목에서 제거하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        RemoveInterestStock(stockCode, stockName);
                        LoadInterestStockAll(); // 갱신
                    }
                }
            }
        }
        
        private void btnModifyOrder_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("정정할 주문을 선택하세요.");
                return;
            }

            var selected = listViewOrders.SelectedItems[0];
            string orderNo = selected.SubItems[0].Text.Trim();
            string stockName = selected.SubItems[1].Text.Trim();
            string stockCode = selected.SubItems[2].Text.Trim();
            string orderTypeText = selected.SubItems[3].Text.Trim();
            string qtyText = selected.SubItems[4].Text.Replace(",", "").Trim();
            string priceText = selected.SubItems[5].Text.Replace(",", "").Trim();

            if (!int.TryParse(qtyText, out int originalQty) || !int.TryParse(priceText, out int originalPrice))
            {
                MessageBox.Show("수량 또는 가격 형식이 잘못되었습니다.");
                return;
            }

            var form = new FormModifyOrder(stockCode, stockName, originalPrice, originalQty);
            if (form.ShowDialog() != DialogResult.OK) return;

            int newQty = form.Quantity;
            int newPrice = form.Price;
            int orderType = orderTypeText.Contains("매도") ? 2 : 1;
            string hogaGb = new[] { "00", "03", "05", "06" }[form.OrderTypeIndex];


            string account = cmbMyAccounts.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(account)) return;

            // 👉 수량과 가격 모두 변경한 경우 → 기존 주문 취소 후 신규 주문
            if (newQty != originalQty && newPrice != originalPrice)
            {
                CancelAndReorder(account, orderNo, stockCode, newQty, newPrice, orderType, hogaGb);
            }
            else if (newQty != originalQty)
            {
                // ❗ 수량만 변경은 정정 불가 → 취소 후 신규 주문
                CancelAndReorder(account, orderNo, stockCode, newQty, originalPrice, orderType, hogaGb);
            }
            else if (newPrice != originalPrice)
            {
                // ✅ 가격만 변경 시 정정 가능
                int modType = (orderType == 1) ? 5 : 6;

                int result = axKHOpenAPI1.SendOrder(
                    "정정주문", GetScreenNo(), account, modType,
                    stockCode, newQty, newPrice, hogaGb, orderNo
                );


                MessageBox.Show(result == 0 ? "정정 주문 성공!" : $"정정 실패! 코드: {result}");
                if (result == 0) RequestUnfulfilledOrders(account);

            }
            else
            {
                MessageBox.Show("변경된 내용이 없습니다.");
            }
        }

        private void CancelAndReorder(string account, string orderNo, string stockCode, int qty, int price, int originalOrderType, string hogaGb)
        {
            int cancelType = (originalOrderType == 1) ? 3 : 4; // 매수: 3, 매도: 4

            int cancelResult = axKHOpenAPI1.SendOrder(
                "주문취소", GetScreenNo(), account,
                cancelType, stockCode, 0, 0, "00", orderNo
            );

            if (cancelResult != 0)
            {
                MessageBox.Show("기존 주문 취소 실패!");
                return;
            }

            int newOrderType = (originalOrderType == 1) ? 1 : 2; // 매수: 1, 매도: 2
            int newOrderResult = axKHOpenAPI1.SendOrder(
                "신규주문", GetScreenNo(), account,
                newOrderType, stockCode, qty, price, hogaGb, ""
            );

            MessageBox.Show(newOrderResult == 0 ? "재주문 성공!" : $"재주문 실패! 코드: {newOrderResult}");
            if (newOrderResult == 0) RequestUnfulfilledOrders(account);
        }


        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("취소할 주문을 선택하세요.");
                return;
            }

            var selected = listViewOrders.SelectedItems[0];
            string orderNo = selected.SubItems[0].Text.Trim();
            string stockCode = selected.SubItems[2].Text.Trim();
            string orderTypeText = selected.SubItems[3].Text.Trim();

            string account = cmbMyAccounts.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(account))
            {
                MessageBox.Show("계좌를 선택하세요.");
                return;
            }

            // 주문유형 설정: 3 = 매수취소, 4 = 매도취소
            int orderType = orderTypeText.Contains("매도") ? 4 : 3;


            string hogaGb = "00"; // 기본 지정가 취소

            int result = axKHOpenAPI1.SendOrder(
                "주문취소",
                GetScreenNo(),
                account,
                orderType,
                stockCode,
                0, // 수량 0 → 취소 시 무시됨
                0, // 가격 0 → 취소 시 무시됨
                hogaGb,
                orderNo
            );

            if (result == 0)
            {
                MessageBox.Show("취소 주문 성공!");
                // 미체결 매수, 매도 조회
                RequestUnfulfilledOrders(account);
            }
            else
            {
                MessageBox.Show("취소 주문 실패! 코드: " + result);
            }
        }
        private void RequestUnfulfilledOrders(string account)
        {
            axKHOpenAPI1.SetInputValue("계좌번호", account);
            axKHOpenAPI1.SetInputValue("전체종목구분", "0"); // 0: 전체
            axKHOpenAPI1.SetInputValue("매매구분", "0");     // 0: 전체
            axKHOpenAPI1.SetInputValue("조회구분", "1");     // 1: 미체결

            axKHOpenAPI1.CommRqData("미체결요청", "OPT10075", 0, "9000"); // 화면번호는 고유값 유지
        }

        private void requestButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void listViewInterest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    class PriceInfoEntityObject
    {
        public String 일자 { get; set; }
        public int 시가 { get; set; }
        public int 고가 { get; set; }
        public int 저가 { get; set; }
        public int 종가 { get; set; }
        public int 거래량 { get; set; }
    }

    public class NewsItem
    {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}


