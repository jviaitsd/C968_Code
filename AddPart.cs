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
    public partial class AddPart : Form
    {
        private bool allowSave()
        {
            return true;
        }

        bool isInhouse;

        bool isOutsourced;
        private void checkOnRBSwitch()
        {
            int i;
            string s;

            if (string.IsNullOrWhiteSpace(IOTB.Text) || (isInhouse && !int.TryParse(IOTB.Text, out i)))
            {
                AddPartSave.BackColor = System.Drawing.Color.DarkGray;
            }
            else
            {
                IOLabel.BackColor = System.Drawing.Color.White;

                AddPartSave.Enabled = allowSave();
            }

            if (string.IsNullOrWhiteSpace(IOTB.Text) || (isOutsourced && int.TryParse(IOTB.Text, out i)))
            {
                AddPartSave.BackColor = System.Drawing.Color.DarkGray;
            }
            else
            {
                IOLabel.BackColor = System.Drawing.Color.White;

                AddPartSave.Enabled = allowSave();
            }
        }
        
        public AddPart()
        {
            InitializeComponent();
        }

        private void InhouseRB_CheckedChanged(object sender, EventArgs e)
        {
            IOLabel.Text = "Machine ID";
            IOTB.Name = "MachineText";
        }

        private void OutsourceRB_CheckedChanged(object sender, EventArgs e)
        {
            IOLabel.Text = "Company Name";
            IOTB.Name = "Company Name";
        }

        private void AddPartSave_Click(object sender, EventArgs e)
        {            
            int i;
            decimal d;

            // Visual tells user if Data is or is not enter in Name
            if (string.IsNullOrWhiteSpace(NameTB.Text))
            {
                AddPartSave.BackColor = System.Drawing.Color.DarkGray;
                NameTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Need to enter Name of Part");
                return;
            }
            else
            {
                AddPartSave.BackColor = System.Drawing.Color.White;
                NameTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Inventory
            if (!int.TryParse(InventoryTB.Text, out i))
            {
                AddPartSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Inventory Amount - Numeric Value");
                return;
            }
            else
            {
                AddPartSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Price
            if (!decimal.TryParse(PriceTB.Text, out d))
            {
                AddPartSave.BackColor = System.Drawing.Color.DarkGray;
                PriceTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Price of Part - Cost Value");
                return;
            }
            else
            {
                AddPartSave.BackColor = System.Drawing.Color.White;
                PriceTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Max
            if (!int.TryParse(MaxTB.Text, out i))
            {
                AddPartSave.BackColor = System.Drawing.Color.DarkGray;
                MaxTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Max Parts - Numeric Value");
                return;
            }
            else
            {
                AddPartSave.BackColor = System.Drawing.Color.White;
                MaxTB.BackColor = System.Drawing.Color.White;
            }


            // Visual tells user Inventory is above Max will not Save
            if (int.Parse(MaxTB.Text) < int.Parse(InventoryTB.Text))
            {
                AddPartSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Inventory is above Max");
                return;
            }
            else
            {
                AddPartSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }


            // Visual tells user if Data is or is not entered in Min
            if (!int.TryParse(MinTB.Text, out i))
            {
                AddPartSave.BackColor = System.Drawing.Color.DarkGray;
                MinTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Min Parts - Numeric Value");
                return;
            }

            else
            {
                AddPartSave.BackColor = System.Drawing.Color.White;
                MinTB.BackColor = System.Drawing.Color.White;
            }

            // Visual Inventory below Min will not Save
            if (int.Parse(MinTB.Text) > int.Parse(MaxTB.Text))
            {
                AddPartSave.BackColor = System.Drawing.Color.DarkGray;
                MinTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Min cannot exceed Max");
                return;
            }
            else
            {
                AddPartSave.BackColor = System.Drawing.Color.White;
                MinTB.BackColor = System.Drawing.Color.White;
            }


            // Visual tells user Inventory id below Min will still Save
            if (int.Parse(MinTB.Text) > int.Parse(InventoryTB.Text))
            {
                AddPartSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Inventory is below Min");
                return;
            }

            else
            {
                AddPartSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }

            AddPartSave.Enabled = allowSave();

            var random = new Random();
            var newPartId = random.Next(1000);
            var newName = NameTB.Text;
            var newInStock = int.Parse(InventoryTB.Text);
            var newPrice = decimal.Parse(PriceTB.Text);
            var newMax = int.Parse(MaxTB.Text);
            var newMin = int.Parse(MinTB.Text);

            if (InhouseRB.Checked)
            {
                // Visual tells user Machine Id is or is not entered
                if (!int.TryParse(IOTB.Text, out i))
                {
                    AddPartSave.BackColor = System.Drawing.Color.DarkGray;
                    IOTB.BackColor = System.Drawing.Color.Red;

                    MessageBox.Show("Add Machine ID - Numeric Value");
                    return;
                }
                else
                {
                    AddPartSave.BackColor = System.Drawing.Color.White;
                    IOTB.BackColor = System.Drawing.Color.White;
                }

                Part part = new Inhouse
                {
                    PartId = newPartId,
                    Name = newName,
                    InStock = newInStock,
                    Price = newPrice,
                    Max = newMax,
                    Min = newMin,
                    MachineId = int.Parse(IOTB.Text) 
            };

                Inventory.addPart(part);

                MessageBox.Show("New Inhouse Part Added" + "\n" + "New Part ID: " + newPartId.ToString());

                this.Close();
            }

            else
            {
                if (OutsourceRB.Checked)
                {
                    // Visual tells user Company Name is or is not entered
                    if (string.IsNullOrWhiteSpace(IOTB.Text))
                    {
                        AddPartSave.BackColor = System.Drawing.Color.DarkGray;
                        IOTB.BackColor = System.Drawing.Color.Red;

                        MessageBox.Show("Add Company Name");
                        return;
                    }
                    else
                    {
                        AddPartSave.BackColor = System.Drawing.Color.White;
                        IOTB.BackColor = System.Drawing.Color.White;
                    }

                    Part part = new Outsourced
                    {
                        PartId = newPartId,
                        Name = newName,
                        InStock = newInStock,
                        Price = newPrice,
                        Max = newMax,
                        Min = newMin,
                        CompanyName = IOTB.Text
                    };

                    Inventory.addPart(part);

                    MessageBox.Show("New Outsourced Part Added" + "\n" + "New Part ID: " + newPartId.ToString());

                    this.Close();
                }
            }
        }

        private void AddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
