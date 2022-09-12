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
    public partial class AddProductForm : Form
    {
        Product addproduct = new Product();

        private bool allowSave()
        {
            return true;
        }


        public AddProductForm()
        {
            InitializeComponent();

            // Parts Data Grid
            // Sets Products data source
            DGV_AddProductParts.DataSource = Inventory.AllParts;

            // Clear preselected row
            DGV_AddProductParts.ClearSelection();

            //Rename PartsId column to Parts ID
            DGV_AddProductParts.Columns[0].HeaderText = "Part ID";

            // Rename InStock column to Inventory
            DGV_AddProductParts.Columns[2].HeaderText = "Inventory";

            // Parts Required Data Grid
            // Sets Products data source
            DGV_AddProductRequired.DataSource = addproduct.AssociatedParts;

            // Clear preselected row
            DGV_AddProductRequired.ClearSelection();

            // Rename PartdId to Parts ID
            DGV_AddProductRequired.Columns[0].HeaderText = "Part ID";

            // Rename InStock column to Inventory
            DGV_AddProductRequired.Columns[2].HeaderText = "Inventory";
        }

        private void AddProductCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddProductSave_Click(object sender, EventArgs e)
        {
            int i;
            decimal d;

            // Visual tells user if Data is or is not entered in Name
            if (string.IsNullOrWhiteSpace(NameTB.Text))
            {
                AddProductSave.BackColor = System.Drawing.Color.DarkGray;
                NameTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Need to enter Name of Product");
                return;
            }
            else
            {
                AddProductSave.BackColor = System.Drawing.Color.White;
                NameTB.BackColor = System.Drawing.Color.White;
                
            }

            // Visual tells user if Data is or is not enter in Inventory
            if (!int.TryParse(InventoryTB.Text, out i))
            {
                AddProductSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Inventory Amount - Numeric Value");
                return;
            }
            else
            {
                AddProductSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Price
            if (!decimal.TryParse(PriceTB.Text, out d))
            {
                AddProductSave.BackColor = System.Drawing.Color.DarkGray;
                PriceTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Price of Product - Cost Value");
                return;
            }
            else
            {
                AddProductSave.BackColor = System.Drawing.Color.White;
                PriceTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Max
            if (!int.TryParse(MaxTB.Text, out i))
            {
                AddProductSave.BackColor = System.Drawing.Color.DarkGray;
                MaxTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Max Product - Numeric Value");
                return;
            }
            else
            {
                AddProductSave.BackColor = System.Drawing.Color.White;
                MaxTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user Inventory id below Min will still Save
            if (int.Parse(MaxTB.Text) < int.Parse(InventoryTB.Text))
            {
                AddProductSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Inventory is above Max");
                return;
            }
            else
            {
                AddProductSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Min
            if (!int.TryParse(MinTB.Text, out i))
            {
                AddProductSave.BackColor = System.Drawing.Color.DarkGray;
                MinTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Min Product - Numeric Value");
                return;
            }
            else
            {
                AddProductSave.BackColor = System.Drawing.Color.White;
                MinTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user Inventory below Min will not Save
            if (int.Parse(MinTB.Text) > int.Parse(MaxTB.Text))
            {
                AddProductSave.BackColor = System.Drawing.Color.DarkGray;
                MinTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Min cannot exceed Max");
                return;
            }
            else
            {
                AddProductSave.BackColor = System.Drawing.Color.White;
                MinTB.BackColor = System.Drawing.Color.White;
            }
            // Visual tells user Inventory id below Min will still Save
            if (int.Parse(MinTB.Text) > int.Parse(InventoryTB.Text))
            {
                AddProductSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;


                MessageBox.Show("Inventory is below Min");
                return;
            }
            else
            {
                AddProductSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }

            AddProductSave.Enabled = allowSave();

            var random = new Random();
            var newProductId = random.Next(100);
            var newName = NameTB.Text;
            var newInStock = int.Parse(InventoryTB.Text);
            var newPrice = decimal.Parse(PriceTB.Text);
            var newMax = int.Parse(MaxTB.Text);
            var newMin = int.Parse(MinTB.Text);

            Product product = new Product

            {
                ProductId = newProductId,
                Name = newName,
                InStock = newInStock,
                Price = newPrice,
                Max = newMax,
                Min = newMin
            };

            // Add Part to AssociatedParts Binding List for this Product

            foreach (DataGridViewRow row in DGV_AddProductRequired.Rows)
            {
                Part requiredPart = (Part)row.DataBoundItem;
                product.addAssociatedPart(requiredPart);
            }

            Inventory.addProduct(product);

            MessageBox.Show("Added New Product Id: " + newProductId.ToString());

            DGV_AddProductParts.ClearSelection();

            this.Close();
        }

        private void SearchParts_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;

            if (SearchPartsTB.Text == "")
            {
                MessageBox.Show("Enter Search in Parts");
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
                    DGV_AddProductParts.DataSource = TempList;

                    MessageBox.Show("Parts Found");

                    SearchPartsTB.Text = String.Empty;
                }

                if (!found)
                {
                    MessageBox.Show("No Parts Found");
                }
            }
        }

        private void AddRequiredDelete_Click(object sender, EventArgs e)
        {
            // Checks if selection made
            if (DGV_AddProductRequired.CurrentRow == null || !DGV_AddProductRequired.CurrentRow.Selected)
            {
                MessageBox.Show("Select Row in Parts Required");
                return;
            }

            // Deletes row
            foreach (DataGridViewRow row in DGV_AddProductRequired.SelectedRows)
            {
                MessageBox.Show("Click OK to Delete Selected Part");

                DGV_AddProductRequired.Rows.RemoveAt(row.Index);
            }
        }

        private void AddParts_Click(object sender, EventArgs e)
        {
            if (DGV_AddProductParts.CurrentRow == null || !DGV_AddProductParts.CurrentRow.Selected)
            {
                MessageBox.Show("Select Row in Parts to Transfer to Parts Required");
                return;
            }
            var SelectedPart = (Part)DGV_AddProductParts.CurrentRow.DataBoundItem;

            addproduct.addAssociatedPart(SelectedPart);

            DGV_AddProductParts.ClearSelection();

            DGV_AddProductRequired.ClearSelection();
        }

        private void AddProductPartsDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGV_AddProductParts.ClearSelection();
        }

        private void AddProductRequiredDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGV_AddProductRequired.ClearSelection();
        }
    }
}
