﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                
            }
        }
    }
}
