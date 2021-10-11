using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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
        List<Scan> scans = new List<Scan>();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtScan.Text.StartsWith("A") || txtScan.Text.StartsWith("a"))
            {
                if (lstLicensePlates.Items.Contains(txtScan.Text) && !alreadyScannedLPs.Contains(txtScan.Text))
                {
                    txtScan.BackColor = Color.LightGreen;

                    Scan scan = new Scan();
                    scan.LicensePlateName = txtScan.Text;
                    scan.SystemLocationName = scannedLocation;
                    scan.ScannedLocationName = scannedLocation;
                    scan.Match = "Y";
                    scans.Add(scan);

                    alreadyScannedLPs.Add(txtScan.Text);
                    amountScanned++;
                }
                else if (lstLicensePlates.Items.Contains(txtScan.Text) && alreadyScannedLPs.Contains(txtScan.Text))
                {
                    ClearTextbox();
                }
                else
                {
                    txtScan.BackColor = Color.Red;

                    Scan scan = new Scan();
                    scan.LicensePlateName = txtScan.Text;
                    var lp = licensePlates.FirstOrDefault(l => l.Name == txtScan.Text);
                    scan.SystemLocationName = lp.LocationName;
                    scan.ScannedLocationName = scannedLocation;
                    scan.Match = "N";
                    scans.Add(scan);
                }

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
                txtScan.BackColor = Color.White;

                alreadyScannedLPs = new List<string>();
                amountScanned = 0;
                scannedLocation = txtScan.Text;

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
                lblAmountScanned.Text = amountScanned.ToString() + "/" + amountTotal.ToString() + " Scanned";
            }
            else
            {
                MessageBox.Show("No file selected.");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save As";
            dialog.Filter = "CSV Files|*.csv";
            dialog.Filter += "|Excel Files|*.xlsx";
            dialog.FileName = "WarehouseValidator_" + DateTime.Now.ToString("M-dd-yyyy_H.mm.ss") + ".csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = File.CreateText(dialog.FileName);
                writer.WriteLine("License Plate,System Location,Scanned Location,Match Y/N");

                int i = 0;
                foreach (var scan in scans)
                {
                    writer.WriteLine(scans[i].LicensePlateName + "," + scans[i].SystemLocationName + "," + scans[i].ScannedLocationName + "," + scans[i].Match);
                    i++;
                }

                writer.Dispose();
            }
            else
            {
                MessageBox.Show("Export unsuccessful.");
            }
        }
    }
}
