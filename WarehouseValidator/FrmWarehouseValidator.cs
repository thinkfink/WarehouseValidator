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
        int amountScanned;
        int amountTotal;
        string scannedLocation;

        List<LicensePlate> licensePlates = new List<LicensePlate>();
        List<Error> errors = new List<Error>();
        List<string> alreadyScannedLPs = new List<string>();

        public void ClearTextbox()
        {
            txtScan.Text = "";
            txtScan.Focus();
        }

        public FrmWarehouseValidator()
        {
            InitializeComponent();
        }

        //TODO: validate if lot number was scanned

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtScan.Text.StartsWith("A") || txtScan.Text.StartsWith("a"))
            {
                if (lstLicensePlates.Items.Contains(txtScan.Text) && !alreadyScannedLPs.Contains(txtScan.Text))
                {
                    alreadyScannedLPs.Add(txtScan.Text);
                    amountScanned++;
                }
                else
                {
                    Error error = new Error();
                    error.LicensePlateName = txtScan.Text;
                    error.LocationName = scannedLocation;
                    errors.Add(error);
                }

                /*int i = 0;
                foreach (var licensePlateName in lstLicensePlates.Items)
                {
                    if (txtScan.Text == lstLicensePlates.Items[i].ToString())
                    {
                        
                    }
                    else
                    {
                        Error error = new Error();
                        error.LicensePlateName = txtScan.Text;
                        error.LocationName = scannedLocation;
                        errors.Add(error);
                    }
                    i++;
                }*/

                lblAmountScanned.Text = amountScanned.ToString() + "/" + amountTotal.ToString() + " Scanned";

                ClearTextbox();
            }
            else if (txtScan.Text.StartsWith("P") || txtScan.Text.StartsWith("p"))
            {
                ClearTextbox();
            }
            else if (txtScan.Text.StartsWith("Q") || txtScan.Text.StartsWith("q"))
            {
                ClearTextbox();
            }
            else
            {
                alreadyScannedLPs = new List<string>();
                scannedLocation = txtScan.Text;
                //licensePlates = ReadCSVFile(licensePlates);

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

                amountTotal = lstLicensePlates.Items.Count;
                lblAmountScanned.Text = amountScanned.ToString() + "/" + amountTotal.ToString() + " Scanned";

                ClearTextbox();
            }
        }

        /*public static List<LicensePlate> ReadCSVFile(List<LicensePlate> licensePlates)
        {
            licensePlates = File.ReadAllLines("C:\\code\\WarehouseValidator\\WarehouseValidator\\" +
                                              "Warehouse LP List - JWMS.csv")
                                .Skip(1)
                                .Select(l => LicensePlate.FromCSV(l))
                                .ToList();
            return licensePlates;
        }*/

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save As";
            dialog.FileName = "WarehouseValidator_" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = File.CreateText(dialog.FileName);
                writer.WriteLine("License Plate,Location Scanned");

                int i = 0;
                foreach (var error in errors)
                {
                    writer.WriteLine(errors[i].LicensePlateName.ToString() + "," + errors[i].LocationName.ToString());
                    i++;
                }
                writer.Dispose();
            }
            else
            {
                MessageBox.Show("Export unsuccessful.");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Please choose a file to open";
            dialog.Filter = "CSV Files|*.csv";
            dialog.Filter += "|Excel Files|*.xlsx";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    StreamReader reader = File.OpenText(dialog.FileName);
                    //licensePlates = ReadCSVFile(licensePlates);
                    licensePlates = File.ReadAllLines(dialog.FileName)
                                .Skip(1)
                                .Select(l => LicensePlate.FromCSV(l))
                                .ToList();
                    reader.Dispose();
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
            else
            {
                MessageBox.Show("No file selected.");
            }
        }
    }
}
