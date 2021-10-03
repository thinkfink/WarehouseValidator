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
                foreach (var licensePlate in licensePlates)
                {
                    licensePlateNames.Add(licensePlate.Name);
                }

                lstLicensePlates.DataSource = licensePlateNames;

                lstLicensePlates.SelectedIndex = -1;
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
