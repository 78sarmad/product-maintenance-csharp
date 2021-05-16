using System;
using System.Windows.Forms;
using Product_Maintenance.Controllers;
using Product_Maintenance.Models;
using System.IO;

namespace Product_Maintenance
{
    public partial class MainForm : Form
    {
        Inventory_Functions Inv_Funcs;
        Product prod;
        Inventory inv;

        private BindingSource source;
        public MainForm()
        {
            InitializeComponent();

            Inv_Funcs = new Inventory_Functions();
            prod = new Product();
            inv = new Inventory();

            source = new BindingSource();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFileData();
        }
        public void LoadFileData()
        {
            ProductsGrid.Rows.Clear();
            source = new BindingSource();

            // load products and populate data grid
            inv.Products = Inv_Funcs.LoadProducts();
            source.DataSource = inv.Products;
            ProductsGrid.DataSource = source;
        }

        public bool areInputsValid()
        {
            ErrorProvider EP = new ErrorProvider();

            if (ProductIDInput.Text == "")
                EP.SetError(ProductIDInput, "Product ID cannot be empty.");

            if  (ProductNameInput.Text == "")
                EP.SetError(ProductNameInput, "Product Name cannot be empty.");

            if (ProductPriceInput.Text == "")
                EP.SetError(ProductPriceInput, "Product Price cannot be empty.");

            if (ProductIDInput.Text != "" && ProductNameInput.Text != "" && ProductPriceInput.Text != "")
            {
                EP.Clear();
                return true;
            }

            return false;
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (areInputsValid()) // check form inputs
            {
                prod.ID = Int32.Parse(ProductIDInput.Text);
                prod.Name = ProductNameInput.Text;
                prod.Price = Convert.ToDouble(ProductPriceInput.Text);
                prod.MFG_Date = MfgDatePicker.Value.ToString();
                prod.Expiry_Date = ExpiryDatePicker.Value.ToString();
                prod.Discontinued = false; // initially set to false for each product

                Inv_Funcs.SaveProduct(prod); // save product
                MessageBox.Show("Product has been added.", "Success");

                LoadFileData();
                ProductsGrid.Refresh();
            }
        }
        private void writeDataGridToFile()
        {
            using (StreamWriter tw = new StreamWriter(@"Products.txt"))
            {
                for (int i = 0; i < ProductsGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < ProductsGrid.Columns.Count; j++)
                        tw.WriteLine(ProductsGrid.Rows[i].Cells[i].Value != null ? ProductsGrid.Rows[i].Cells[j].Value.ToString() : "");
                }
            }
        }
        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow product in ProductsGrid.SelectedRows)
                ProductsGrid.Rows[ProductsGrid.CurrentCell.RowIndex].Cells[5].Value = "True";

            writeDataGridToFile();
            LoadFileData();
            ProductsGrid.Refresh();

            MessageBox.Show("Product has been deleted.", "Success");
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            writeDataGridToFile();
            LoadFileData();
            ProductsGrid.Refresh();

            MessageBox.Show("Changes have been saved.", "Success");
        }
    }
}
