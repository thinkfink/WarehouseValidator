
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
            this.lstLicensePlates.Location = new System.Drawing.Point(51, 41);
            this.lstLicensePlates.Name = "lstLicensePlates";
            this.lstLicensePlates.Size = new System.Drawing.Size(225, 234);
            this.lstLicensePlates.TabIndex = 2;
            // 
            // FrmWarehouseValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 330);
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
    }
}

