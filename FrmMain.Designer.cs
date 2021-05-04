
namespace HAL_Impromptu_Utility
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOfdExport = new System.Windows.Forms.Button();
            this.btnOfdExtract = new System.Windows.Forms.Button();
            this.opnFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.lblGoogleExport = new System.Windows.Forms.Label();
            this.lblHalExtract = new System.Windows.Forms.Label();
            this.btnReconcile = new System.Windows.Forms.Button();
            this.lstHalOrphans = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstGoogleOrphans = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Google Export:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "HAL Extract:";
            // 
            // btnOfdExport
            // 
            this.btnOfdExport.BackgroundImage = global::HAL_Impromptu_Utility.Properties.Resources.folder;
            this.btnOfdExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOfdExport.FlatAppearance.BorderSize = 0;
            this.btnOfdExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfdExport.Location = new System.Drawing.Point(14, 22);
            this.btnOfdExport.Name = "btnOfdExport";
            this.btnOfdExport.Size = new System.Drawing.Size(24, 24);
            this.btnOfdExport.TabIndex = 2;
            this.btnOfdExport.UseVisualStyleBackColor = true;
            this.btnOfdExport.Click += new System.EventHandler(this.btnOfdExport_Click);
            // 
            // btnOfdExtract
            // 
            this.btnOfdExtract.BackgroundImage = global::HAL_Impromptu_Utility.Properties.Resources.folder;
            this.btnOfdExtract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOfdExtract.FlatAppearance.BorderSize = 0;
            this.btnOfdExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfdExtract.Location = new System.Drawing.Point(14, 58);
            this.btnOfdExtract.Name = "btnOfdExtract";
            this.btnOfdExtract.Size = new System.Drawing.Size(24, 24);
            this.btnOfdExtract.TabIndex = 3;
            this.btnOfdExtract.UseVisualStyleBackColor = true;
            this.btnOfdExtract.Click += new System.EventHandler(this.btnOfdExtract_Click);
            // 
            // opnFileDlg
            // 
            this.opnFileDlg.FileName = "openFileDialog1";
            // 
            // lblGoogleExport
            // 
            this.lblGoogleExport.AutoSize = true;
            this.lblGoogleExport.Location = new System.Drawing.Point(160, 25);
            this.lblGoogleExport.Name = "lblGoogleExport";
            this.lblGoogleExport.Size = new System.Drawing.Size(38, 18);
            this.lblGoogleExport.TabIndex = 4;
            this.lblGoogleExport.Text = "TBD";
            // 
            // lblHalExtract
            // 
            this.lblHalExtract.AutoSize = true;
            this.lblHalExtract.Location = new System.Drawing.Point(160, 61);
            this.lblHalExtract.Name = "lblHalExtract";
            this.lblHalExtract.Size = new System.Drawing.Size(38, 18);
            this.lblHalExtract.TabIndex = 7;
            this.lblHalExtract.Text = "TBD";
            // 
            // btnReconcile
            // 
            this.btnReconcile.Location = new System.Drawing.Point(304, 106);
            this.btnReconcile.Name = "btnReconcile";
            this.btnReconcile.Size = new System.Drawing.Size(92, 29);
            this.btnReconcile.TabIndex = 8;
            this.btnReconcile.Text = "Reconcile";
            this.btnReconcile.UseVisualStyleBackColor = true;
            this.btnReconcile.Click += new System.EventHandler(this.btnReconcile_Click);
            // 
            // lstHalOrphans
            // 
            this.lstHalOrphans.FormattingEnabled = true;
            this.lstHalOrphans.ItemHeight = 18;
            this.lstHalOrphans.Location = new System.Drawing.Point(48, 196);
            this.lstHalOrphans.Name = "lstHalOrphans";
            this.lstHalOrphans.Size = new System.Drawing.Size(228, 94);
            this.lstHalOrphans.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "HAL Orphans";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Google Orphans";
            // 
            // lstGoogleOrphans
            // 
            this.lstGoogleOrphans.FormattingEnabled = true;
            this.lstGoogleOrphans.ItemHeight = 18;
            this.lstGoogleOrphans.Location = new System.Drawing.Point(439, 196);
            this.lstGoogleOrphans.Name = "lstGoogleOrphans";
            this.lstGoogleOrphans.Size = new System.Drawing.Size(228, 94);
            this.lstGoogleOrphans.TabIndex = 11;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 312);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstGoogleOrphans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstHalOrphans);
            this.Controls.Add(this.btnReconcile);
            this.Controls.Add(this.lblHalExtract);
            this.Controls.Add(this.lblGoogleExport);
            this.Controls.Add(this.btnOfdExtract);
            this.Controls.Add(this.btnOfdExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "HAL Impromptu Utility";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOfdExport;
        private System.Windows.Forms.Button btnOfdExtract;
        private System.Windows.Forms.OpenFileDialog opnFileDlg;
        private System.Windows.Forms.Label lblGoogleExport;
        private System.Windows.Forms.Label lblHalExtract;
        private System.Windows.Forms.Button btnReconcile;
        private System.Windows.Forms.ListBox lstHalOrphans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstGoogleOrphans;
    }
}

