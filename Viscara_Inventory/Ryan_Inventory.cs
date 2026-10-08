using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Viscara_Inventory
{
    public partial class Ryan_Inventory : Form
    {
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;

        private BindingSource showProductList;

        public Ryan_Inventory()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void Ryan_Inventory_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = new string[]
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

            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                throw new StringFormatException("Product name must contain letters only (no spaces, numbers or symbols).");
            }
            return name;
        }

        public int Quantity(string qty)
        {
            int result;
            if (!Regex.IsMatch(qty, @"^[0-9]+$") || !int.TryParse(qty, out result))
            {
                throw new NumberFormatException("Quantity must be a whole number (digits only) within the allowed range.");
            }
            return result;
        }

        public double SellingPrice(string price)
        {
            double result;
            if (!Regex.IsMatch(price, @"^(\d*\.)?\d+$") || !double.TryParse(price, NumberStyles.Float, CultureInfo.InvariantCulture, out result))
            {
                throw new CurrencyFormatException("Sell price must be a valid amount, e.g. 25 or 25.50.");
            }
            return result;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                showProductList.Add(new Valencia_Inventory(_ProductName, _Category, _MfgDate,
                    _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(ex.Message, "StringFormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "NumberFormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message, "CurrencyFormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("Add product attempt finished.");
            }
        }
    }
}
