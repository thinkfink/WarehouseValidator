
namespace WarehouseValidator
{
    partial class FrmWarehouseValidator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtScan = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstLicensePlates = new System.Windows.Forms.ListBox();
            this.lblAmountScanned = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(51, 12);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(225, 23);
            this.txtScan.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(282, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(31, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "->";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstLicensePlates
            // 
            this.lstLicensePlates.BackColor = System.Drawing.SystemColors.Menu;
            this.lstLicensePlates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLicensePlates.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstLicensePlates.FormattingEnabled = true;
            this.lstLicensePlates.ItemHeight = 18;
            this.lstLicensePlates.Location = new System.Drawing.Point(51, 62);
            this.lstLicensePlates.Name = "lstLicensePlates";
            this.lstLicensePlates.Size = new System.Drawing.Size(225, 234);
            this.lstLicensePlates.TabIndex = 2;
            // 
            // lblAmountScanned
            // 
            this.lblAmountScanned.AutoSize = true;
            this.lblAmountScanned.Location = new System.Drawing.Point(51, 41);
            this.lblAmountScanned.Name = "lblAmountScanned";
            this.lblAmountScanned.Size = new System.Drawing.Size(0, 15);
            this.lblAmountScanned.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(201, 311);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(51, 311);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click the Import button to import LP list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Click the Export button to save error report";
            // 
            // FrmWarehouseValidator
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblAmountScanned);
            this.Controls.Add(this.lstLicensePlates);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtScan);
            this.Name = "FrmWarehouseValidator";
            this.Text = "Warehouse Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstLicensePlates;
        private System.Windows.Forms.Label lblAmountScanned;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

