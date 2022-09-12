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
    public partial class ModifyProduct : Form
    {
        Product modifyproduct = new Product();

        private int ModifyProductId;
        private bool allowSave()
        {
            return true;
        }

        public static BindingList<Part> DataSource { get; private set; }

        public ModifyProduct()
        {
            InitializeComponent();
        }

        public ModifyProduct(Product product)
        {
            InitializeComponent();

            foreach (Part part in product.AssociatedParts)
            {
                modifyproduct.addAssociatedPart(part);
            }

            // Parts Data Grid
            // Sets Products data source
            DGV_ModifyProductParts.DataSource = Inventory.AllParts;

            // Clear preselected row
            DGV_ModifyProductParts.ClearSelection();

            // Rename PartsId column to Part ID
            DGV_ModifyProductParts.Columns[0].HeaderText = "Part ID";

            // Rename InStock column to Inventory
            DGV_ModifyProductParts.Columns[2].HeaderText = "Inventory";

            // Parts Required Data Grid
            // Sets Products DataSource
            DGV_ModifyProductRequired.DataSource = modifyproduct.AssociatedParts;


            // Clear preselected row
            DGV_ModifyProductRequired.ClearSelection();

            // Rename PartsId column to Parts Id
            DGV_ModifyProductRequired.Columns[0].HeaderText = "Part ID";

            // Rename InStock column to Inventory
            DGV_ModifyProductRequired.Columns[2].HeaderText = "Inventory";


            ModifyProductId = product.ProductId;

            IdTB.Text = product.ProductId.ToString();
            NameTB.Text = product.Name;
            InventoryTB.Text = product.InStock.ToString();
            PriceTB.Text = product.Price.ToString();
            MaxTB.Text = product.Max.ToString();
            MinTB.Text = product.Min.ToString();
        }

        private void ModifyRequiredDelete_Click(object sender, EventArgs e)
        {
            // Checks if selection was made
            if (DGV_ModifyProductRequired.CurrentRow == null || !DGV_ModifyProductRequired.CurrentRow.Selected)
            {
                MessageBox.Show("Select Row in Parts Required");
                return;
            }

            // Deletes row
            foreach (DataGridViewRow row in DGV_ModifyProductRequired.SelectedRows)
            {
                MessageBox.Show("Click OK to Delete Selected Part");

                DGV_ModifyProductRequired.Rows.RemoveAt(row.Index);
            }
        }

        private void ModifySearchParts_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;

            if (ModifySearchPartsTB.Text == "")
            {
                MessageBox.Show("Enter Search in Parts");
            }

            if (ModifySearchPartsTB.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(ModifySearchPartsTB.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }

                if (found)
                {
                    DGV_ModifyProductParts.DataSource = TempList;

                    MessageBox.Show("Parts Found");

                    ModifySearchPartsTB.Text = String.Empty;
                }

                if (!found)
                {
                    MessageBox.Show("No Parts Found");
                }
            }
        }

        private void ModifyProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyProductSave_Click(object sender, EventArgs e)
        {
            int i;
            decimal d;

            // Visual tells user if Data is or is not enter in Name
            if (string.IsNullOrWhiteSpace(NameTB.Text))
            {
                ModifyProductSave.BackColor = System.Drawing.Color.DarkGray;
                NameTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Need to enter Name of Product");
                return;
            }
            else
            {
                ModifyProductSave.BackColor = System.Drawing.Color.White;
                NameTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Inventory
            if (!int.TryParse(InventoryTB.Text, out i))
            {
                ModifyProductSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Inventory Amount - Numeric Value");
                return;
            }
            else
            {
                ModifyProductSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Price
            if (!decimal.TryParse(PriceTB.Text, out d))
            {
                ModifyProductSave.BackColor = System.Drawing.Color.DarkGray;
                PriceTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Price of Product - Cost Value");
                return;
            }
            else
            {
                ModifyProductSave.BackColor = System.Drawing.Color.White;
                PriceTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Max
            if (!int.TryParse(MaxTB.Text, out i))
            {
                ModifyProductSave.BackColor = System.Drawing.Color.DarkGray;
                MaxTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Max of Product - Numeric Value");
                return;
            }
            else
            {
                ModifyProductSave.BackColor = System.Drawing.Color.White;
                MaxTB.BackColor = System.Drawing.Color.White;
            }

            // Visual Inventory can't be above Max will not Save
            if (int.Parse(MaxTB.Text) < int.Parse(InventoryTB.Text))
            {
                ModifyProductSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Inventory is above Max");
                return;
            }
            else
            {
                ModifyProductSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }



            // Visual tells user if Data is or is not enter in Min
            if (!int.TryParse(MinTB.Text, out i))
            {
                ModifyProductSave.BackColor = System.Drawing.Color.DarkGray;
                MinTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Min of Product - Numeric Value");
                return;
            }
            else
            {
                ModifyProductSave.BackColor = System.Drawing.Color.White;
                MinTB.BackColor = System.Drawing.Color.White;

                ModifyProductSave.Enabled = allowSave();
            }

            // Visual tells user Inventory below Min will not Save
            if (int.Parse(MinTB.Text) > int.Parse(MaxTB.Text))
            {
                ModifyProductSave.BackColor = System.Drawing.Color.DarkGray;
                MinTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Min cannot exceed Max");
                return;
            }
            else
            {
                ModifyProductSave.BackColor = System.Drawing.Color.White;
                MinTB.BackColor = System.Drawing.Color.White;
            }
            // Visual tells user Inventory below Min will still Save
            if (int.Parse(MinTB.Text) > int.Parse(InventoryTB.Text))
            {
                ModifyProductSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Inventory is below Min");
                return;
            }
            else
            {
                ModifyProductSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }



            DGV_ModifyProductParts.ClearSelection();

            ModifyProductSave.Enabled = allowSave();

            var productId = int.Parse(IdTB.Text);
            var newName = NameTB.Text;
            var newInStock = int.Parse(InventoryTB.Text);
            var newPrice = decimal.Parse(PriceTB.Text);
            var newMax = int.Parse(MaxTB.Text);
            var newMin = int.Parse(MinTB.Text);

            Product product = new Product
            {
                ProductId = productId,
                Name = newName,
                InStock = newInStock,
                Price = newPrice,
                Max = newMax,
                Min = newMin,
            };

            // Add Part to AssociatedParts Binding List for this Product

            foreach (DataGridViewRow row in DGV_ModifyProductRequired.Rows)
            {
                Part requiredPart = (Part)row.DataBoundItem;
                product.addAssociatedPart(requiredPart);
            }


            Inventory.updateProduct(productId, product);

            MessageBox.Show("Modified Product ID: " + productId.ToString());

            this.Close();

            DGV_ModifyProductRequired.ClearSelection();
        }

        private void ModifyAddParts_Click(object sender, EventArgs e)
        {
            // Checks if selection is made
            if (DGV_ModifyProductParts.CurrentRow == null || !DGV_ModifyProductParts.CurrentRow.Selected)
            {
                MessageBox.Show("Select Row in Parts to Transfer to Parts Required");
                return;
            }

            var SelectedPart = (Part)DGV_ModifyProductParts.CurrentRow.DataBoundItem;

            modifyproduct.addAssociatedPart(SelectedPart);
        }

        private void ModifyProductsPartsDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGV_ModifyProductParts.ClearSelection();
        }

        private void ModifyProductsRequiredDataBindinComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGV_ModifyProductRequired.ClearSelection();
        }
    }
}
