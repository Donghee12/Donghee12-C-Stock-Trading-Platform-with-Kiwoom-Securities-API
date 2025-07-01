// Decompiled with JetBrains decompiler
// Type: JamongCommonLibrary.종목검색창
// Assembly: JamongCommonLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 748BA270-5F9B-4F61-B5E9-8CD1A89D3B35
// Assembly location: C:\Users\user\Downloads\JamongCommonLibrary.dll

using AxKHOpenAPILib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

#nullable disable
namespace JamongCommonLibrary
{
    public class 종목검색창 : Form
    {
        private AxKHOpenAPI axKHOpenAPI1;
        private OnSearchedItemSelectedListener onSearchedItemSelectedListener;
        private List<ItemEntityObject> itemAllList;
        private List<ItemEntityObject> kospiList;
        private List<ItemEntityObject> kosdaqList;
        private List<ItemEntityObject> elwList;
        private int[] chrint = new int[20]
        {
      44032,
      44620,
      45208,
      45796,
      46384,
      46972,
      47560,
      48148,
      48736,
      49324,
      49912,
      50500,
      51088,
      51676,
      52264,
      52852,
      53440,
      54028,
      54616,
      55204
        };
        private char[] chr = new char[19]
        {
      'ㄱ',
      'ㄲ',
      'ㄴ',
      'ㄷ',
      'ㄸ',
      'ㄹ',
      'ㅁ',
      'ㅂ',
      'ㅃ',
      'ㅅ',
      'ㅆ',
      'ㅇ',
      'ㅈ',
      'ㅉ',
      'ㅊ',
      'ㅋ',
      'ㅌ',
      'ㅍ',
      'ㅎ'
        };
        private string[] str = new string[19]
        {
      "가",
      "까",
      "나",
      "다",
      "따",
      "라",
      "마",
      "바",
      "빠",
      "사",
      "싸",
      "아",
      "자",
      "짜",
      "차",
      "카",
      "타",
      "파",
      "하"
        };
        private IContainer components;
        private Panel panel1;
        private Button elwButton;
        private Button kospiAndKosdaqButton;
        private Button kosdaqButton;
        private Button kospiButton;
        private Button allItemButton;
        private TextBox codeSearchTextBox;
        private TextBox nameSearchTextBox;
        private Button ㄱbutton;
        private DataGridView itemGridView;
        private Button numbutton;
        private Button Abutton;
        private Button ㅎbutton;
        private Button ㅍbutton;
        private Button ㅌbutton;
        private Button ㅋbutton;
        private Button ㅊbutton;
        private Button ㅈbutton;
        private Button ㅇbutton;
        private Button ㅅbutton;
        private Button ㅂbutton;
        private Button ㅁbutton;
        private Button ㄹbutton;
        private Button ㄷbutton;
        private Button ㄴbutton;
        private DataGridViewTextBoxColumn 종목명;
        private DataGridViewTextBoxColumn 코드;
        private DataGridView itemSearchGridView;

        public 종목검색창(AxKHOpenAPI axKHOpenAPI1)
        {
            this.InitializeComponent();
            this.axKHOpenAPI1 = axKHOpenAPI1;
            this.nameSearchTextBox.GotFocus += new EventHandler(this.textBox_GotFocus);
            this.nameSearchTextBox.LostFocus += new EventHandler(this.textBox_LostFocus);
            this.codeSearchTextBox.GotFocus += new EventHandler(this.textBox_GotFocus);
            this.codeSearchTextBox.LostFocus += new EventHandler(this.textBox_LostFocus);
            this.nameSearchTextBox.TextChanged += new EventHandler(this.textBox_TextChanged);
            this.codeSearchTextBox.TextChanged += new EventHandler(this.textBox_TextChanged);
            this.itemGridView.SelectionChanged += new EventHandler(this.DataGridView_SelectionChanged);
            this.itemSearchGridView.SelectionChanged += new EventHandler(this.DataGridView_SelectionChanged);
            this.allItemButton.Click += new EventHandler(this.buttonClicked);
            this.kospiButton.Click += new EventHandler(this.buttonClicked);
            this.kosdaqButton.Click += new EventHandler(this.buttonClicked);
            this.elwButton.Click += new EventHandler(this.buttonClicked);
            this.kospiAndKosdaqButton.Click += new EventHandler(this.buttonClicked);
            this.ㄱbutton.Click += new EventHandler(this.buttonClicked);
            this.ㄴbutton.Click += new EventHandler(this.buttonClicked);
            this.ㄷbutton.Click += new EventHandler(this.buttonClicked);
            this.ㄹbutton.Click += new EventHandler(this.buttonClicked);
            this.ㅁbutton.Click += new EventHandler(this.buttonClicked);
            this.ㅂbutton.Click += new EventHandler(this.buttonClicked);
            this.ㅅbutton.Click += new EventHandler(this.buttonClicked);
            this.ㅇbutton.Click += new EventHandler(this.buttonClicked);
            this.ㅈbutton.Click += new EventHandler(this.buttonClicked);
            this.ㅊbutton.Click += new EventHandler(this.buttonClicked);
            this.ㅋbutton.Click += new EventHandler(this.buttonClicked);
            this.ㅌbutton.Click += new EventHandler(this.buttonClicked);
            this.ㅍbutton.Click += new EventHandler(this.buttonClicked);
            this.ㅎbutton.Click += new EventHandler(this.buttonClicked);
            this.Abutton.Click += new EventHandler(this.buttonClicked);
            this.numbutton.Click += new EventHandler(this.buttonClicked);
            this.init();
        }

        public void setOnSearchedItemSelectedListener(
          OnSearchedItemSelectedListener onSearchedItemSelectedListener)
        {
            this.onSearchedItemSelectedListener = onSearchedItemSelectedListener;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            try
            {
                if (dataGridView.SelectedCells.Count <= 0)
                    return;
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                string 종목명 = dataGridView["종목명", rowIndex].Value.ToString();
                string 종목코드 = dataGridView["코드", rowIndex].Value.ToString();
                if (this.onSearchedItemSelectedListener == null)
                    return;
                this.onSearchedItemSelectedListener.OnSelected(종목명, 종목코드);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (sender.Equals((object)this.nameSearchTextBox) && this.nameSearchTextBox.Focused)
            {
                string text = this.nameSearchTextBox.Text;
                if (text.Length > 0)
                {
                    this.itemSearchGridView.Visible = true;
                    try
                    {
                        string pattern = "";
                        for (int index1 = 0; index1 < text.Length; ++index1)
                        {
                            if (text[index1] >= 'ㄱ' && text[index1] <= 'ㅎ')
                            {
                                for (int index2 = 0; index2 < this.chr.Length; ++index2)
                                {
                                    if ((int)text[index1] == (int)this.chr[index2])
                                        pattern += string.Format("[{0}-{1}]", (object)this.str[index2], (object)(char)(this.chrint[index2 + 1] - 1));
                                }
                            }
                            else if (text[index1] >= '가')
                            {
                                int num1 = ((int)text[index1] - 44032) % 588;
                                if (num1 == 0)
                                {
                                    pattern += string.Format("[{0}-{1}]", (object)text[index1], (object)(char)((uint)text[index1] + 27U));
                                }
                                else
                                {
                                    int num2 = 27 - num1 % 28;
                                    pattern += string.Format("[{0}-{1}]", (object)text[index1], (object)(char)((uint)text[index1] + (uint)num2));
                                }
                            }
                            else if (text[index1] >= 'A' && text[index1] <= 'z')
                                pattern += (string)(object)text[index1];
                            else if (text[index1] >= '0' && text[index1] <= '9')
                                pattern += (string)(object)text[index1];
                        }
                        IEnumerable<ItemEntityObject> collection = this.itemAllList.Where<ItemEntityObject>((Func<ItemEntityObject, bool>)(c => Regex.IsMatch(c.종목명, pattern)));
                        List<ItemEntityObject> itemEntityObjectList = new List<ItemEntityObject>();
                        itemEntityObjectList.AddRange(collection);
                        this.itemSearchGridView.DataSource = (object)itemEntityObjectList;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());
                    }
                }
                else
                    this.itemSearchGridView.Visible = false;
            }
            else
            {
                if (!sender.Equals((object)this.codeSearchTextBox) || !this.codeSearchTextBox.Focused)
                    return;
                string x = this.codeSearchTextBox.Text;
                if (x.Length > 0)
                {
                    this.itemSearchGridView.Visible = true;
                    IEnumerable<ItemEntityObject> collection = this.itemAllList.Where<ItemEntityObject>((Func<ItemEntityObject, bool>)(c => c.종목코드.Contains(x)));
                    List<ItemEntityObject> itemEntityObjectList = new List<ItemEntityObject>();
                    itemEntityObjectList.AddRange(collection);
                    this.itemSearchGridView.DataSource = (object)itemEntityObjectList;
                }
                else
                    this.itemSearchGridView.Visible = false;
            }
        }

        public void textBox_GotFocus(object sender, EventArgs e)
        {
            if (sender.Equals((object)this.nameSearchTextBox))
            {
                this.nameSearchTextBox.ForeColor = Color.Black;
                this.nameSearchTextBox.Text = "";
                this.itemGridView.Sort(this.itemGridView.Columns[0], ListSortDirection.Ascending);
                this.codeSearchTextBox.ForeColor = Color.LightGray;
                this.codeSearchTextBox.Text = "코드검색";
            }
            else
            {
                if (!sender.Equals((object)this.codeSearchTextBox))
                    return;
                this.codeSearchTextBox.ForeColor = Color.Black;
                this.codeSearchTextBox.Text = "";
                this.itemGridView.Sort(this.itemGridView.Columns[1], ListSortDirection.Ascending);
                this.nameSearchTextBox.ForeColor = Color.LightGray;
                this.nameSearchTextBox.Text = "종목명, 초성검색";
            }
        }

        public void textBox_LostFocus(object sender, EventArgs e)
        {
            if (sender.Equals((object)this.nameSearchTextBox) && this.codeSearchTextBox.Focused)
            {
                this.itemSearchGridView.Visible = false;
                this.nameSearchTextBox.ForeColor = Color.LightGray;
                this.nameSearchTextBox.Text = "종목명, 초성검색";
            }
            else
            {
                if (!sender.Equals((object)this.codeSearchTextBox) || !this.nameSearchTextBox.Focused)
                    return;
                this.itemSearchGridView.Visible = false;
                this.codeSearchTextBox.ForeColor = Color.LightGray;
                this.codeSearchTextBox.Text = "코드검색";
            }
        }

        private void init()
        {
            this.itemAllList = new List<ItemEntityObject>();
            string[] strArray = this.axKHOpenAPI1.GetCodeListByMarket((string)null).Split(';');
            for (int rowIndex = 0; rowIndex < strArray.Length; ++rowIndex)
            {
                string str = strArray[rowIndex];
                if (str.Length > 0)
                {
                    string masterCodeName = this.axKHOpenAPI1.GetMasterCodeName(str);
                    this.itemAllList.Add(new ItemEntityObject()
                    {
                        종목명 = masterCodeName,
                        종목코드 = str
                    });
                    this.itemGridView.Rows.Add();
                    this.itemGridView["종목명", rowIndex].Value = (object)masterCodeName;
                    this.itemGridView["코드", rowIndex].Value = (object)str;
                }
            }
            this.itemGridView.Sort(this.itemGridView.Columns[0], ListSortDirection.Ascending);
        }

        public void buttonClicked(object sender, EventArgs e)
        {
            this.itemSearchGridView.Visible = false;
            if (sender.Equals((object)this.allItemButton))
            {
                this.itemGridView.Rows.Clear();
                for (int index = 0; index < this.itemAllList.Count; ++index)
                {
                    this.itemGridView.Rows.Add();
                    this.itemGridView["종목명", index].Value = (object)this.itemAllList[index].종목명;
                    this.itemGridView["코드", index].Value = (object)this.itemAllList[index].종목코드;
                }
                this.itemGridView.Sort(this.itemGridView.Columns[0], ListSortDirection.Ascending);
            }
            else if (sender.Equals((object)this.kospiButton) || sender.Equals((object)this.kosdaqButton) || sender.Equals((object)this.elwButton))
            {
                this.itemGridView.Rows.Clear();
                List<ItemEntityObject> itemEntityObjectList1 = (List<ItemEntityObject>)null;
                string str1 = (string)null;
                if (sender.Equals((object)this.kospiButton))
                {
                    itemEntityObjectList1 = this.kospiList;
                    str1 = "0";
                }
                else if (sender.Equals((object)this.kosdaqButton))
                {
                    itemEntityObjectList1 = this.kosdaqList;
                    str1 = "10";
                }
                else if (sender.Equals((object)this.elwButton))
                {
                    itemEntityObjectList1 = this.elwList;
                    str1 = "3";
                }
                if (itemEntityObjectList1 == null)
                {
                    List<ItemEntityObject> itemEntityObjectList2 = new List<ItemEntityObject>();
                    string[] strArray = this.axKHOpenAPI1.GetCodeListByMarket(str1).Split(';');
                    for (int rowIndex = 0; rowIndex < strArray.Length; ++rowIndex)
                    {
                        string str2 = strArray[rowIndex];
                        if (str2.Length > 0)
                        {
                            string masterCodeName = this.axKHOpenAPI1.GetMasterCodeName(str2);
                            itemEntityObjectList2.Add(new ItemEntityObject()
                            {
                                종목명 = masterCodeName,
                                종목코드 = str2
                            });
                            this.itemGridView.Rows.Add();
                            this.itemGridView["종목명", rowIndex].Value = (object)masterCodeName;
                            this.itemGridView["코드", rowIndex].Value = (object)str2;
                        }
                    }
                }
                else
                {
                    for (int index = 0; index < itemEntityObjectList1.Count; ++index)
                    {
                        this.itemGridView.Rows.Add();
                        this.itemGridView["종목명", index].Value = (object)itemEntityObjectList1[index].종목명;
                        this.itemGridView["코드", index].Value = (object)itemEntityObjectList1[index].종목코드;
                    }
                }
                this.itemGridView.Sort(this.itemGridView.Columns[0], ListSortDirection.Ascending);
            }
            else if (sender.Equals((object)this.kospiAndKosdaqButton))
            {
                this.itemGridView.Rows.Clear();
                if (this.kospiList == null || this.kosdaqList == null)
                {
                    if (this.kospiList == null)
                    {
                        this.kospiList = new List<ItemEntityObject>();
                        string codeListByMarket = this.axKHOpenAPI1.GetCodeListByMarket("0");
                        char[] chArray = new char[1] { ';' };
                        foreach (string str in codeListByMarket.Split(chArray))
                        {
                            if (str.Length > 0)
                            {
                                string masterCodeName = this.axKHOpenAPI1.GetMasterCodeName(str);
                                this.kospiList.Add(new ItemEntityObject()
                                {
                                    종목명 = masterCodeName,
                                    종목코드 = str
                                });
                            }
                        }
                    }
                    if (this.kosdaqList == null)
                    {
                        this.kosdaqList = new List<ItemEntityObject>();
                        string codeListByMarket = this.axKHOpenAPI1.GetCodeListByMarket("10");
                        char[] chArray = new char[1] { ';' };
                        foreach (string str in codeListByMarket.Split(chArray))
                        {
                            if (str.Length > 0)
                            {
                                string masterCodeName = this.axKHOpenAPI1.GetMasterCodeName(str);
                                this.kosdaqList.Add(new ItemEntityObject()
                                {
                                    종목명 = masterCodeName,
                                    종목코드 = str
                                });
                            }
                        }
                    }
                }
                for (int index = 0; index < this.kospiList.Count; ++index)
                {
                    this.itemGridView.Rows.Add();
                    this.itemGridView["종목명", index].Value = (object)this.kospiList[index].종목명;
                    this.itemGridView["코드", index].Value = (object)this.kospiList[index].종목코드;
                }
                for (int index = 0; index < this.kosdaqList.Count; ++index)
                {
                    this.itemGridView.Rows.Add();
                    this.itemGridView["종목명", index + this.kospiList.Count].Value = (object)this.kosdaqList[index].종목명;
                    this.itemGridView["코드", index + this.kospiList.Count].Value = (object)this.kosdaqList[index].종목코드;
                }
                this.itemGridView.Sort(this.itemGridView.Columns[0], ListSortDirection.Ascending);
            }
            else
            {
                for (int rowIndex = 0; rowIndex < this.itemGridView.Rows.Count - 1; ++rowIndex)
                {
                    int num1 = (int)this.itemGridView["종목명", rowIndex].Value.ToString()[0];
                    int num2 = 0;
                    int num3 = 0;
                    if (sender.Equals((object)this.ㄱbutton))
                    {
                        num2 = 44032;
                        num3 = 45208;
                    }
                    else if (sender.Equals((object)this.ㄴbutton))
                    {
                        num2 = 45208;
                        num3 = 45796;
                    }
                    else if (sender.Equals((object)this.ㄷbutton))
                    {
                        num2 = 45796;
                        num3 = 46972;
                    }
                    else if (sender.Equals((object)this.ㄹbutton))
                    {
                        num2 = 46972;
                        num3 = 47560;
                    }
                    else if (sender.Equals((object)this.ㅁbutton))
                    {
                        num2 = 47560;
                        num3 = 48148;
                    }
                    else if (sender.Equals((object)this.ㅂbutton))
                    {
                        num2 = 48148;
                        num3 = 49324;
                    }
                    else if (sender.Equals((object)this.ㅅbutton))
                    {
                        num2 = 49324;
                        num3 = 50500;
                    }
                    else if (sender.Equals((object)this.ㅇbutton))
                    {
                        num2 = 50500;
                        num3 = 51088;
                    }
                    else if (sender.Equals((object)this.ㅈbutton))
                    {
                        num2 = 51088;
                        num3 = 52264;
                    }
                    else if (sender.Equals((object)this.ㅊbutton))
                    {
                        num2 = 52264;
                        num3 = 52852;
                    }
                    else if (sender.Equals((object)this.ㅋbutton))
                    {
                        num2 = 52852;
                        num3 = 53440;
                    }
                    else if (sender.Equals((object)this.ㅌbutton))
                    {
                        num2 = 53440;
                        num3 = 54028;
                    }
                    else if (sender.Equals((object)this.ㅍbutton))
                    {
                        num2 = 54028;
                        num3 = 54616;
                    }
                    else if (sender.Equals((object)this.ㅎbutton))
                    {
                        num2 = 54616;
                        num3 = 55204;
                    }
                    else if (sender.Equals((object)this.Abutton))
                    {
                        num2 = 65;
                        num3 = 122;
                    }
                    else if (sender.Equals((object)this.numbutton))
                    {
                        num2 = 48;
                        num3 = 57;
                    }
                    if (num1 >= num2 && num1 < num3)
                    {
                        this.itemGridView.FirstDisplayedScrollingRowIndex = rowIndex;
                        break;
                    }
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new Panel();
            this.itemSearchGridView = new DataGridView();
            this.numbutton = new Button();
            this.Abutton = new Button();
            this.ㅎbutton = new Button();
            this.ㅍbutton = new Button();
            this.ㅌbutton = new Button();
            this.ㅋbutton = new Button();
            this.ㅊbutton = new Button();
            this.ㅈbutton = new Button();
            this.ㅇbutton = new Button();
            this.ㅅbutton = new Button();
            this.ㅂbutton = new Button();
            this.ㅁbutton = new Button();
            this.ㄹbutton = new Button();
            this.ㄷbutton = new Button();
            this.ㄴbutton = new Button();
            this.ㄱbutton = new Button();
            this.itemGridView = new DataGridView();
            this.종목명 = new DataGridViewTextBoxColumn();
            this.코드 = new DataGridViewTextBoxColumn();
            this.codeSearchTextBox = new TextBox();
            this.nameSearchTextBox = new TextBox();
            this.elwButton = new Button();
            this.kospiAndKosdaqButton = new Button();
            this.kosdaqButton = new Button();
            this.kospiButton = new Button();
            this.allItemButton = new Button();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.itemSearchGridView).BeginInit();
            ((ISupportInitialize)this.itemGridView).BeginInit();
            this.SuspendLayout();
            this.panel1.BackColor = SystemColors.ActiveCaption;
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add((Control)this.itemSearchGridView);
            this.panel1.Controls.Add((Control)this.numbutton);
            this.panel1.Controls.Add((Control)this.Abutton);
            this.panel1.Controls.Add((Control)this.ㅎbutton);
            this.panel1.Controls.Add((Control)this.ㅍbutton);
            this.panel1.Controls.Add((Control)this.ㅌbutton);
            this.panel1.Controls.Add((Control)this.ㅋbutton);
            this.panel1.Controls.Add((Control)this.ㅊbutton);
            this.panel1.Controls.Add((Control)this.ㅈbutton);
            this.panel1.Controls.Add((Control)this.ㅇbutton);
            this.panel1.Controls.Add((Control)this.ㅅbutton);
            this.panel1.Controls.Add((Control)this.ㅂbutton);
            this.panel1.Controls.Add((Control)this.ㅁbutton);
            this.panel1.Controls.Add((Control)this.ㄹbutton);
            this.panel1.Controls.Add((Control)this.ㄷbutton);
            this.panel1.Controls.Add((Control)this.ㄴbutton);
            this.panel1.Controls.Add((Control)this.ㄱbutton);
            this.panel1.Controls.Add((Control)this.itemGridView);
            this.panel1.Controls.Add((Control)this.codeSearchTextBox);
            this.panel1.Controls.Add((Control)this.nameSearchTextBox);
            this.panel1.Controls.Add((Control)this.elwButton);
            this.panel1.Controls.Add((Control)this.kospiAndKosdaqButton);
            this.panel1.Controls.Add((Control)this.kosdaqButton);
            this.panel1.Controls.Add((Control)this.kospiButton);
            this.panel1.Controls.Add((Control)this.allItemButton);
            this.panel1.Location = new Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(361, 535);
            this.panel1.TabIndex = 1;
            this.itemSearchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.itemSearchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemSearchGridView.Location = new Point(5, 95);
            this.itemSearchGridView.Name = "itemSearchGridView";
            this.itemSearchGridView.RowHeadersVisible = false;
            this.itemSearchGridView.RowTemplate.Height = 27;
            this.itemSearchGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.itemSearchGridView.Size = new Size(317, 432);
            this.itemSearchGridView.TabIndex = 25;
            this.itemSearchGridView.Visible = false;
            this.numbutton.Location = new Point(324, 498);
            this.numbutton.Name = "numbutton";
            this.numbutton.Size = new Size(32, 29);
            this.numbutton.TabIndex = 24;
            this.numbutton.Text = "9";
            this.numbutton.UseVisualStyleBackColor = true;
            this.Abutton.Location = new Point(324, 471);
            this.Abutton.Name = "Abutton";
            this.Abutton.Size = new Size(32, 29);
            this.Abutton.TabIndex = 23;
            this.Abutton.Text = "A";
            this.Abutton.UseVisualStyleBackColor = true;
            this.ㅎbutton.Location = new Point(324, 444);
            this.ㅎbutton.Name = "ㅎbutton";
            this.ㅎbutton.Size = new Size(32, 29);
            this.ㅎbutton.TabIndex = 22;
            this.ㅎbutton.Text = "ㅎ";
            this.ㅎbutton.UseVisualStyleBackColor = true;
            this.ㅍbutton.Location = new Point(324, 417);
            this.ㅍbutton.Name = "ㅍbutton";
            this.ㅍbutton.Size = new Size(32, 29);
            this.ㅍbutton.TabIndex = 21;
            this.ㅍbutton.Text = "ㅍ";
            this.ㅍbutton.UseVisualStyleBackColor = true;
            this.ㅌbutton.Location = new Point(324, 390);
            this.ㅌbutton.Name = "ㅌbutton";
            this.ㅌbutton.Size = new Size(32, 29);
            this.ㅌbutton.TabIndex = 20;
            this.ㅌbutton.Text = "ㅌ";
            this.ㅌbutton.UseVisualStyleBackColor = true;
            this.ㅋbutton.Location = new Point(324, 363);
            this.ㅋbutton.Name = "ㅋbutton";
            this.ㅋbutton.Size = new Size(32, 29);
            this.ㅋbutton.TabIndex = 19;
            this.ㅋbutton.Text = "ㅋ";
            this.ㅋbutton.UseVisualStyleBackColor = true;
            this.ㅊbutton.Location = new Point(324, 336);
            this.ㅊbutton.Name = "ㅊbutton";
            this.ㅊbutton.Size = new Size(32, 29);
            this.ㅊbutton.TabIndex = 18;
            this.ㅊbutton.Text = "ㅊ";
            this.ㅊbutton.UseVisualStyleBackColor = true;
            this.ㅈbutton.Location = new Point(324, 309);
            this.ㅈbutton.Name = "ㅈbutton";
            this.ㅈbutton.Size = new Size(32, 29);
            this.ㅈbutton.TabIndex = 17;
            this.ㅈbutton.Text = "ㅈ";
            this.ㅈbutton.UseVisualStyleBackColor = true;
            this.ㅇbutton.Location = new Point(324, 282);
            this.ㅇbutton.Name = "ㅇbutton";
            this.ㅇbutton.Size = new Size(32, 29);
            this.ㅇbutton.TabIndex = 16;
            this.ㅇbutton.Text = "ㅇ";
            this.ㅇbutton.UseVisualStyleBackColor = true;
            this.ㅅbutton.Location = new Point(324, (int)byte.MaxValue);
            this.ㅅbutton.Name = "ㅅbutton";
            this.ㅅbutton.Size = new Size(32, 29);
            this.ㅅbutton.TabIndex = 15;
            this.ㅅbutton.Text = "ㅅ";
            this.ㅅbutton.UseVisualStyleBackColor = true;
            this.ㅂbutton.Location = new Point(324, 228);
            this.ㅂbutton.Name = "ㅂbutton";
            this.ㅂbutton.Size = new Size(32, 29);
            this.ㅂbutton.TabIndex = 14;
            this.ㅂbutton.Text = "ㅂ";
            this.ㅂbutton.UseVisualStyleBackColor = true;
            this.ㅁbutton.Location = new Point(324, 201);
            this.ㅁbutton.Name = "ㅁbutton";
            this.ㅁbutton.Size = new Size(32, 29);
            this.ㅁbutton.TabIndex = 13;
            this.ㅁbutton.Text = "ㅁ";
            this.ㅁbutton.UseVisualStyleBackColor = true;
            this.ㄹbutton.Location = new Point(324, 175);
            this.ㄹbutton.Name = "ㄹbutton";
            this.ㄹbutton.Size = new Size(32, 29);
            this.ㄹbutton.TabIndex = 12;
            this.ㄹbutton.Text = "ㄹ";
            this.ㄹbutton.UseVisualStyleBackColor = true;
            this.ㄷbutton.Location = new Point(324, 149);
            this.ㄷbutton.Name = "ㄷbutton";
            this.ㄷbutton.Size = new Size(32, 29);
            this.ㄷbutton.TabIndex = 11;
            this.ㄷbutton.Text = "ㄷ";
            this.ㄷbutton.UseVisualStyleBackColor = true;
            this.ㄴbutton.Location = new Point(324, 122);
            this.ㄴbutton.Name = "ㄴbutton";
            this.ㄴbutton.Size = new Size(32, 29);
            this.ㄴbutton.TabIndex = 10;
            this.ㄴbutton.Text = "ㄴ";
            this.ㄴbutton.UseVisualStyleBackColor = true;
            this.ㄱbutton.Location = new Point(324, 95);
            this.ㄱbutton.Name = "ㄱbutton";
            this.ㄱbutton.Size = new Size(32, 29);
            this.ㄱbutton.TabIndex = 0;
            this.ㄱbutton.Text = "ㄱ";
            this.ㄱbutton.UseVisualStyleBackColor = true;
            this.itemGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.itemGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange((DataGridViewColumn)this.종목명, (DataGridViewColumn)this.코드);
            this.itemGridView.Location = new Point(5, 95);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowHeadersVisible = false;
            this.itemGridView.RowTemplate.Height = 27;
            this.itemGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.itemGridView.Size = new Size(317, 432);
            this.itemGridView.TabIndex = 8;
            this.종목명.FillWeight = 130f;
            this.종목명.HeaderText = "종목명";
            this.종목명.Name = "종목명";
            this.종목명.ReadOnly = true;
            this.코드.FillWeight = 60f;
            this.코드.HeaderText = "코드";
            this.코드.Name = "코드";
            this.코드.ReadOnly = true;
            this.codeSearchTextBox.ForeColor = Color.LightGray;
            this.codeSearchTextBox.Location = new Point(166, 64);
            this.codeSearchTextBox.Name = "codeSearchTextBox";
            this.codeSearchTextBox.Size = new Size(100, 25);
            this.codeSearchTextBox.TabIndex = 7;
            this.codeSearchTextBox.Text = "코드검색";
            this.nameSearchTextBox.ForeColor = Color.LightGray;
            this.nameSearchTextBox.Location = new Point(5, 64);
            this.nameSearchTextBox.Name = "nameSearchTextBox";
            this.nameSearchTextBox.Size = new Size(159, 25);
            this.nameSearchTextBox.TabIndex = 6;
            this.nameSearchTextBox.Text = "종목명, 초성검색";
            this.elwButton.Location = new Point(5, 30);
            this.elwButton.Name = "elwButton";
            this.elwButton.Size = new Size(64, 28);
            this.elwButton.TabIndex = 4;
            this.elwButton.Text = "ELW";
            this.elwButton.UseVisualStyleBackColor = true;
            this.kospiAndKosdaqButton.Location = new Point(214, 4);
            this.kospiAndKosdaqButton.Name = "kospiAndKosdaqButton";
            this.kospiAndKosdaqButton.Size = new Size((int)sbyte.MaxValue, 26);
            this.kospiAndKosdaqButton.TabIndex = 3;
            this.kospiAndKosdaqButton.Text = "거래소+코스닥";
            this.kospiAndKosdaqButton.UseVisualStyleBackColor = true;
            this.kosdaqButton.Location = new Point(146, 4);
            this.kosdaqButton.Name = "kosdaqButton";
            this.kosdaqButton.Size = new Size(62, 26);
            this.kosdaqButton.TabIndex = 2;
            this.kosdaqButton.Text = "코스닥";
            this.kosdaqButton.UseVisualStyleBackColor = true;
            this.kospiButton.Location = new Point(75, 4);
            this.kospiButton.Name = "kospiButton";
            this.kospiButton.Size = new Size(65, 26);
            this.kospiButton.TabIndex = 1;
            this.kospiButton.Text = "거래소";
            this.kospiButton.UseVisualStyleBackColor = true;
            this.allItemButton.Location = new Point(5, 4);
            this.allItemButton.Name = "allItemButton";
            this.allItemButton.Size = new Size(64, 26);
            this.allItemButton.TabIndex = 0;
            this.allItemButton.Text = "전종목";
            this.allItemButton.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new SizeF(8f, 15f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(388, 583);
            this.Controls.Add((Control)this.panel1);
            this.Name = nameof(종목검색창);
            this.Text = nameof(종목검색창);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.itemSearchGridView).EndInit();
            ((ISupportInitialize)this.itemGridView).EndInit();
            this.ResumeLayout(false);
        }
    }
}
