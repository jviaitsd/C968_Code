using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_PerformanceAssessment
{
    public partial class MainScreenForm : Form
    {
        public int Index { get; set; }

        public MainScreenForm()
        {
            InitializeComponent();

            // Parts Data Grid
            // Sets Parts data source
            DGV_Parts.DataSource = Inventory.AllParts;

            // Clear preselected row
            DGV_Parts.ClearSelection();

            // Rename PartId column to Part ID
            DGV_Parts.Columns[0].HeaderText = "Part ID";
            
            // Rename InStock column to Inventory
            DGV_Parts.Columns[2].HeaderText = "Inventory";

            // Products Data Grid
            // Sets Products data source
            DGV_Products.DataSource = Inventory.Products;

            // Clear preselected row
            DGV_Products.ClearSelection();

            // Rename ProductId column to Product ID
            DGV_Products.Columns[0].HeaderText = "Product ID";

            // Rename InStock column to Inventory
            DGV_Products.Columns[2].HeaderText = "Inventory";


        }

        // Exit Main Screen closes App
        private void ExitMainScreen_Click(object sender, EventArgs e)
        {
            DGV_Parts.ClearSelection();

            DGV_Products.ClearSelection();
            
            MessageBox.Show("Click OK to Exit");

            this.Close();
        }

        // Parts Data Grid
        // Create Search Parts Data Grid
        private void SearchParts_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;

            if (SearchPartsTB.Text == "")
            {
                MessageBox.Show("Enter Search Name of Part");
                return;
            }

            if (SearchPartsTB.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(SearchPartsTB.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                    
                if (found)
                {
                    DGV_Parts.DataSource = TempList;

                    MessageBox.Show("Parts Found");

                    SearchPartsTB.Text = String.Empty;
                }

                if (!found)
                {
                    MessageBox.Show("No Parts Found");
                    return;
                }
            }
        }

        // Returns to Parts Screen after Search
        private void ReturnParts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK to return to Parts Screen.");
            return;
        }


        // Create Add Parts Button and connect to Add Parts Screen
        private void AddParts_Click(object sender, EventArgs e)
        {
            // Add Parts Screen
            AddPart APT = new AddPart();
            APT.Show();

            DGV_Parts.ClearSelection();
        }

        // Create Modify Button and connet to Modify Parts Sreen
        private void ModifyParts_Click(object sender, EventArgs e)
        {
            // Checks if selection is made
            if (DGV_Parts.CurrentRow == null || !DGV_Parts.CurrentRow.Selected)
            {
                MessageBox.Show("Select Row to Modify in Parts");
                return;
            }

            var SelectedPart = (Part)DGV_Parts.CurrentRow.DataBoundItem;

            // Create Modify Parts Screen
            ModifyPart MPT = new ModifyPart(SelectedPart);
            MPT.Show();

            DGV_Parts.ClearSelection();
        }

        // Cteate Delete Parts Button
        private void DeleteParts_Click(object sender, EventArgs e)
        {
            // Checks if selection is made
            if (DGV_Parts.CurrentRow == null || !DGV_Parts.CurrentRow.Selected)
            {
                MessageBox.Show("Select Row to Delete in Parts");
                return;
            }

            // Deletes row
            foreach (DataGridViewRow row in DGV_Parts.SelectedRows)
            {
                MessageBox.Show("Click OK to Delete Selected Part");

                DGV_Parts.Rows.RemoveAt(row.Index);

                DGV_Parts.ClearSelection();
            }
        }

        // Products Data Grid
        // Create Search Products Data Grid
        private void SearchProducts_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempList = new BindingList<Product>();
            bool found = false;

            if (SearchProductsTB.Text == "")
            {
                MessageBox.Show("Enter Search Name of Products");
                return;
            }

            if (SearchProductsTB.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(SearchProductsTB.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.Products[i]);
                        found = true;
                    }
                }

                if (found)
                {
                    DGV_Products.DataSource = TempList;

                    MessageBox.Show("Products Found");
           
                    SearchProductsTB.Text = String.Empty;
                }

                if (!found)
                {
                    MessageBox.Show("No Products Found");
                    return;
                }
            }
        }

        // Create Add Products Button and connect to Add Products Screen
        private void AddProducts_Click(object sender, EventArgs e)
        {
            // Create Add Screen Products
            AddProductForm APD = new AddProductForm();
            APD.Show();

            DGV_Products.ClearSelection();
        }

        private void ModifyProducts_Click(object sender, EventArgs e)
        {
            // Checks if selection made
            if (DGV_Products.CurrentRow == null || !DGV_Products.CurrentRow.Selected)
            {
                MessageBox.Show("Select Row to Modify in Products");
                return;
            }

            var SelectedProduct = (Product)DGV_Products.CurrentRow.DataBoundItem;

            // Create Add Screen
            ModifyProduct MPD = new ModifyProduct(SelectedProduct);
            MPD.Show();

            DGV_Products.ClearSelection();
        }

        // Create Delete Button Products
        private void DeleteProducts_Click(object sender, EventArgs e)
        {
            // Checks if selection made
            if (DGV_Products.CurrentRow == null || !DGV_Products.CurrentRow.Selected)
            {
                MessageBox.Show("Select Row to Delete in Products");
                return;
            }

            // Checks if Product has Parts assigned 
            Product product = (Product)DGV_Products.CurrentRow.DataBoundItem;

            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Not able to Delete a Product with Parts Assigned in Parts Required." + "\n" +
                    "Need to Delete Parts in Parts Required to Delete this Product.");
                return;
            }

            // Deletes row
            foreach (DataGridViewRow row in DGV_Products.SelectedRows)
            {
                MessageBox.Show("Click OK to Delete Selected Product");

                DGV_Products.Rows.RemoveAt(row.Index);

                DGV_Products.ClearSelection();
            }
        }

        private void PartsDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGV_Parts.ClearSelection();
        }

        private void ProductsDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGV_Products.ClearSelection();
        }
    }
}
