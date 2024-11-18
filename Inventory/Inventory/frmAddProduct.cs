using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {  
        class NumberFormatException: Exception
        {
            public NumberFormatException(string quantity) : base(quantity) { }
        }
        class StringFormatException : Exception
        {
            public StringFormatException(string name) : base(name) { }
        }
        class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string price) : base(price) { }
        }

        private int _Quantity;
        private double _SellPrice;
        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        BindingSource showProductList;


        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] listOfPRoductCategory = new string[]
            {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };
            foreach (var item in listOfPRoductCategory)
            {
                comboBoxCategory.Items.Add(item);
            }    
        }
        public string Product_Name(string name)
        {
            try
            {
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                    throw new StringFormatException(name);
            }
            catch (StringFormatException sfe)
            {
                MessageBox.Show("String Format Input in Product Name. " + sfe.Message);
            }
            finally
            {
                Console.WriteLine("Input String Only In Product Name");
            }
            return name;
        }
        public int Quantity(string qty)
        {
            try
            {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                {
                    throw new NumberFormatException(qty);
                }
            }
            catch(NumberFormatException nfe)
            {
                MessageBox.Show("Number Format In Quantity" + nfe.Message);
            }
            return Convert.ToInt32(qty);

        }
        public double SellingPrice(string price)
        {
            try
            {
                if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                    throw new CurrencyFormatException(price);
                return Convert.ToDouble(price);
            }
            catch (CurrencyFormatException cfe)
            {
                MessageBox.Show("Currency Format Input in Price" + cfe.Message);
            }
            return Convert.ToDouble(price);
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            _ProductName = Product_Name(textBoxProductName.Text);
            _Category = comboBoxCategory.Text;
            _MfgDate = dateTimePickerMfgDate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dateTimePickerExpDate.Value.ToString("yyyy-MM-dd");
            _Description = richTextBoxDescription.Text;
            _Quantity = Quantity(textBoxQuantity.Text); 
            _SellPrice = SellingPrice(textBoxPrice.Text);
            showProductList.Add(new ProductClass(_ProductName,_Category,_MfgDate,_ExpDate,_SellPrice, _Quantity, _Description));

            dataGridViewProductLIst.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductLIst.DataSource = showProductList;
        }

        private void dataGridViewProductLIst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
