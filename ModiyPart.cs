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
    public partial class ModifyPart : Form
    {
        private int ModifyPartId;

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
                ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
                IOLabel.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                IOLabel.BackColor = System.Drawing.Color.White;

                ModifyPartSave.Enabled = allowSave();
            }

            if (string.IsNullOrWhiteSpace(IOTB.Text) || (isOutsourced && int.TryParse(IOTB.Text, out i)))
            {
                ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
            }
            else
            {
                IOLabel.BackColor = System.Drawing.Color.White;

                ModifyPartSave.Enabled = allowSave();
            }
        }

        public ModifyPart()
        {
            InitializeComponent();
        }

        public ModifyPart(Part part)
        {
            InitializeComponent();

            ModifyPartId = part.PartId;

            IdTB.Text = part.PartId.ToString();
            NameTB.Text = part.Name;
            InventoryTB.Text = part.InStock.ToString();
            PriceTB.Text = part.Price.ToString();
            MaxTB.Text = part.Max.ToString();
            MinTB.Text = part.Min.ToString();


            if (part is Inhouse)
            {
                InhouseRB.Checked = true;
                IOLabel.Text = "Machine ID";


                var InhousePart = (Inhouse)part;
                IOTB.Text = InhousePart.MachineId.ToString();
            }
            else
            {
                OutsourcedRB.Checked = true;
                IOLabel.Text = "Company Name";

                var OutsourcedPart = (Outsourced)part;
                IOTB.Text = OutsourcedPart.CompanyName;
            }
        }

        private void InHouseRB_CheckedChanged(object sender, EventArgs e)
        {
            IOLabel.Text = "Machine ID";
            IOTB.Name = "MachineText";
        }



        private void OutsourceRB_CheckedChanged(object sender, EventArgs e)
        {
            IOLabel.Text = "Company Name";
            IOTB.Name = "Company Name";
        }

        private void ModifyPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyPartSave_Click(object sender, EventArgs e)
        {

            int i;
            decimal d;

            // Visual tells user if Data is or is not enter in Name
            if (string.IsNullOrWhiteSpace(NameTB.Text))
            {
                ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
                NameTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Need to enter Name of Part");
                return;
            }

            else
            {
                ModifyPartSave.BackColor = System.Drawing.Color.White;
                NameTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Inventory
            if (!int.TryParse(InventoryTB.Text, out i))
            {
                ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Inventory Amount - Numeric Value");
                return;
            }
            else
            {
                ModifyPartSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Price
            if (!decimal.TryParse(PriceTB.Text, out d))
            {
                ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
                PriceTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Price of Part - Cost Value");
                return;
            }
            else
            {
                ModifyPartSave.BackColor = System.Drawing.Color.White;
                PriceTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Max
            if (!int.TryParse(MaxTB.Text, out i))
            {
                ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
                MaxTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Max of Parts - Numeric Value");
                return;
            }
            else
            {
                ModifyPartSave.BackColor = System.Drawing.Color.White;
                MaxTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user Inventory is above Max
            if (int.Parse(MaxTB.Text) < int.Parse(InventoryTB.Text))
            {
                ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Inventory is above Max Value");
                return;
            }
            else
            {
                ModifyPartSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user if Data is or is not enter in Min
            if (!int.TryParse(MinTB.Text, out i))
            {
                ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
                MinTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Add Min Parts - Numeric Value");
                return;
            }
            else
            {
                ModifyPartSave.BackColor = System.Drawing.Color.White;
                MinTB.BackColor = System.Drawing.Color.White;
            }

            // Visual tells user Inventory id below Min will still Save
            if (int.Parse(MinTB.Text) > int.Parse(InventoryTB.Text))
            {
                ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
                InventoryTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Inventory is below Min");
                return;
            }
            else
            {
                ModifyPartSave.BackColor = System.Drawing.Color.White;
                InventoryTB.BackColor = System.Drawing.Color.White;
            }


            // Visual tells user Inventory below Min will not Save
            if (int.Parse(MinTB.Text) > int.Parse(MaxTB.Text))
            {
                ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
                MinTB.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("Min cannot exceed Max");
                return;
            }

            else
            {
                ModifyPartSave.BackColor = System.Drawing.Color.White;
                MinTB.BackColor = System.Drawing.Color.White;
            }

            ModifyPartSave.Enabled = allowSave();

            var partId = int.Parse(IdTB.Text);
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
                    ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
                    IOTB.BackColor = System.Drawing.Color.Red;

                    MessageBox.Show("Add Machine ID - Numeric Value");
                    return;
                }

                else
                {
                    ModifyPartSave.BackColor = System.Drawing.Color.White;
                    IOTB.BackColor = System.Drawing.Color.White;
                }


                Part part = new Inhouse
                {
                    PartId = partId,
                    Name = newName,
                    InStock = newInStock,
                    Price = newPrice,
                    Max = newMax,
                    Min = newMin,
                    MachineId = int.Parse(IOTB.Text)
                };

                Inventory.updatePart(partId, part);

                MessageBox.Show("Modified Inhouse Part" + "\n" + "Part ID: " + partId.ToString());

                this.Close();
            }

            else
            {
                if (OutsourcedRB.Checked)
                {
                    // Visual tells user Company Name is or is not entered
                    if (string.IsNullOrWhiteSpace(IOTB.Text))
                    {
                        ModifyPartSave.BackColor = System.Drawing.Color.DarkGray;
                        IOTB.BackColor = System.Drawing.Color.Red;

                        MessageBox.Show("Add Company Name");
                        return;
                    }

                    else
                    {
                        ModifyPartSave.BackColor = System.Drawing.Color.White;
                        IOTB.BackColor = System.Drawing.Color.White;
                    }


                    Part part = new Outsourced
                    {
                        PartId = partId,
                        Name = newName,
                        InStock = newInStock,
                        Price = newPrice,
                        Max = newMax,
                        Min = newMin,
                        CompanyName = IOTB.Text
                    };

                    Inventory.updatePart(partId, part);

                    MessageBox.Show("Modified Outsourced Part" + "\n" + "Part ID: " + partId.ToString());

                    this.Close();
                }
            }
        }
    }
}
