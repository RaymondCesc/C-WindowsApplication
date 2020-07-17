using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TravelExperts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // loads data into the 'travelExpertsDataSet.Packages_Products_Suppliers' table.
            this.packages_Products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Packages_Products_Suppliers);
            // loads data into the 'travelExpertsDataSet.Products_Suppliers' table.
            this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);
            // loads data into the 'travelExpertsDataSet.Suppliers' table. 
            this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);
            // loads data into the 'travelExpertsDataSet.Products' table. 
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            // loads data into the 'travelExpertsDataSet.Packages' table. 
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);

        }

        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            // TODO: HANDLE EXCEPTIONS
            this.packagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        private void productsBindingNavSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            // TODO: HANDLE EXCEPTIONS
            this.productsBindingSource.EndEdit();
            this.productsTableAdapter.Update(this.travelExpertsDataSet.Products);
        }

        private void suppBindingNavSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            // TODO: HANDLE EXCEPTIONS
            this.suppliersBindingSource.EndEdit();
            this.suppliersTableAdapter.Update(this.travelExpertsDataSet.Suppliers);
        }

        private void prodSuppBindingNavSaveITem_Click(object sender, EventArgs e)
        {
            this.Validate();
            // TODO: HANDLE EXCEPTIONS
            this.products_SuppliersBindingSource.EndEdit();
            this.products_SuppliersTableAdapter.Update(this.travelExpertsDataSet.Products_Suppliers);
        }

        private void packProdSupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            // TODO: HANDLE EXCEPTIONS
            this.packages_Products_SuppliersBindingSource.EndEdit();
            this.packages_Products_SuppliersTableAdapter.Update(this.travelExpertsDataSet.Packages_Products_Suppliers);
        }
    }
}
