using System;
using System.Windows.Forms;

namespace CandlestickChart
{
    public partial class FormModifyOrder : Form
    {
        public string StockCode => txtStockCode.Text;
        public string StockName => txtStockName.Text;
        public int Quantity => (int)numQuantity.Value;
        public int Price => (int)numPrice.Value;
        public int OrderTypeIndex => cmbOrderType.SelectedIndex;

        public TextBox txtStockCode;
        public TextBox txtStockName;
        public NumericUpDown numPrice;
        public NumericUpDown numQuantity;
        public ComboBox cmbOrderType;
        public Button btnModifyOrder;
        public Button btnCancelOrder;
        public Button btnClose;

        public FormModifyOrder(string code, string name, int price, int qty)
        {
            InitializeComponent();

            txtStockCode.Text = code;
            txtStockName.Text = name;
            numPrice.Value = price;
            numQuantity.Value = qty;

            cmbOrderType.Items.AddRange(new string[]
            {
                "00: 지정가", "03: 시장가", "05: 조건부지정가", "06: 최유리지정가"
            });
            cmbOrderType.SelectedIndex = 0;
        }

        public void InitializeComponent()
        {
            this.Text = "주문 정정/취소";
            this.Size = new System.Drawing.Size(400, 300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            Label lblOrderType = new Label { Text = "주문유형", Location = new System.Drawing.Point(20, 20) };
            cmbOrderType = new ComboBox { Location = new System.Drawing.Point(120, 20), Width = 200 };

            Label lblStockCode = new Label { Text = "종목코드", Location = new System.Drawing.Point(20, 60) };
            txtStockCode = new TextBox { Location = new System.Drawing.Point(120, 60), Width = 200, ReadOnly = true };

            Label lblStockName = new Label { Text = "종목명", Location = new System.Drawing.Point(20, 100) };
            txtStockName = new TextBox { Location = new System.Drawing.Point(120, 100), Width = 200, ReadOnly = true };

            Label lblPrice = new Label { Text = "가격", Location = new System.Drawing.Point(20, 140) };
            numPrice = new NumericUpDown { Location = new System.Drawing.Point(120, 140), Width = 200, Maximum = 1000000 };

            Label lblQty = new Label { Text = "수량", Location = new System.Drawing.Point(20, 180) };
            numQuantity = new NumericUpDown { Location = new System.Drawing.Point(120, 180), Width = 200, Maximum = 1000000 };

            btnModifyOrder = new Button { Text = "정정", Location = new System.Drawing.Point(40, 220), Width = 80 };
            btnCancelOrder = new Button { Text = "취소", Location = new System.Drawing.Point(140, 220), Width = 80 };
            btnClose = new Button { Text = "닫기", Location = new System.Drawing.Point(240, 220), Width = 80 };

            btnModifyOrder.Click += BtnModifyOrder_Click;
            btnCancelOrder.Click += BtnCancelOrder_Click;
            btnClose.Click += BtnClose_Click;

            this.Controls.AddRange(new Control[]
            {
                lblOrderType, cmbOrderType,
                lblStockCode, txtStockCode,
                lblStockName, txtStockName,
                lblPrice, numPrice,
                lblQty, numQuantity,
                btnModifyOrder, btnCancelOrder, btnClose
            });
        }

        public void BtnModifyOrder_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        public void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
