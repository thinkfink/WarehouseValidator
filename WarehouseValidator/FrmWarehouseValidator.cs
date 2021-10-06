using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseValidator.Models;

namespace WarehouseValidator
{
    public partial class FrmWarehouseValidator : Form
    {
        public FrmWarehouseValidator()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtScan.Text.StartsWith("A") || txtScan.Text.StartsWith("a"))
            {
                int i = 0;
                foreach (var licensePlateName in lstLicensePlates.Items)
                {
                    if (txtScan.Text == lstLicensePlates.Items[i].ToString())
                    {
                        //lstLicensePlates.Items[i].BackColor = ;
                    }
                    i++;
                }
            }
            else if (txtScan.Text.StartsWith("P") || txtScan.Text.StartsWith("p"))
            {

            }
            else if (txtScan.Text.StartsWith("Q") || txtScan.Text.StartsWith("q"))
            {

            }
            else
            {
                List<LicensePlate> licensePlates = new List<LicensePlate>();
                licensePlates = ReadCSVFile(licensePlates);

                List<string> licensePlateNames = new List<string>();
                int i = 0;

                foreach (var licensePlate in licensePlates)
                {
                    if (txtScan.Text == licensePlates[i].LocationName)
                    {
                        licensePlateNames.Add(licensePlate.Name);
                    }
                    i++;
                }

                lstLicensePlates.DataSource = licensePlateNames;
                lstLicensePlates.ClearSelected();

                txtScan.Text = "";
                txtScan.Focus();
            }
        }

        public static List<LicensePlate> ReadCSVFile(List<LicensePlate> licensePlates)
        {
            licensePlates = File.ReadAllLines("C:\\code\\WarehouseValidator\\WarehouseValidator\\" +
                                              "Warehouse LP List - JWMS.csv")
                                .Skip(1)
                                .Select(l => LicensePlate.FromCSV(l))
                                .ToList();
            return licensePlates;
        }
    }
}
