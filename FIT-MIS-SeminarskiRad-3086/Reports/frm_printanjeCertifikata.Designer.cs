﻿namespace FIT_MIS_SeminarskiRad_3086.Reports
{
    partial class frm_printanjeCertifikata
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.view_CertifikatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Area5 = new System.Windows.Forms.Button();
            this.btn_Area4 = new System.Windows.Forms.Button();
            this.btn_Area3 = new System.Windows.Forms.Button();
            this.btn_Area2 = new System.Windows.Forms.Button();
            this.btn_Area1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cB = new System.Windows.Forms.ComboBox();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.tB3 = new System.Windows.Forms.TextBox();
            this.tB4 = new System.Windows.Forms.TextBox();
            this.tB5 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.view_CertifikatiBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // view_CertifikatiBindingSource
            // 
            this.view_CertifikatiBindingSource.DataSource = typeof(DAL_FIT_MIS_SeminarskiRad_3086.DS_Certifikati.view_CertifikatiDataTable);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_Area5);
            this.panel1.Controls.Add(this.btn_Area4);
            this.panel1.Controls.Add(this.btn_Area3);
            this.panel1.Controls.Add(this.btn_Area2);
            this.panel1.Controls.Add(this.btn_Area1);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 594);
            this.panel1.TabIndex = 0;
            // 
            // btn_Area5
            // 
            this.btn_Area5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Area5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Area5.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Area5.Location = new System.Drawing.Point(447, 437);
            this.btn_Area5.Name = "btn_Area5";
            this.btn_Area5.Size = new System.Drawing.Size(43, 23);
            this.btn_Area5.TabIndex = 1;
            this.btn_Area5.TabStop = false;
            this.btn_Area5.Text = "5";
            this.btn_Area5.UseVisualStyleBackColor = false;
            this.btn_Area5.Visible = false;
            this.btn_Area5.Click += new System.EventHandler(this.btn_Area1_Click);
            // 
            // btn_Area4
            // 
            this.btn_Area4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Area4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Area4.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Area4.Location = new System.Drawing.Point(447, 390);
            this.btn_Area4.Name = "btn_Area4";
            this.btn_Area4.Size = new System.Drawing.Size(43, 23);
            this.btn_Area4.TabIndex = 1;
            this.btn_Area4.TabStop = false;
            this.btn_Area4.Text = "4";
            this.btn_Area4.UseVisualStyleBackColor = false;
            this.btn_Area4.Visible = false;
            this.btn_Area4.Click += new System.EventHandler(this.btn_Area1_Click);
            // 
            // btn_Area3
            // 
            this.btn_Area3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Area3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Area3.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Area3.Location = new System.Drawing.Point(447, 325);
            this.btn_Area3.Name = "btn_Area3";
            this.btn_Area3.Size = new System.Drawing.Size(43, 23);
            this.btn_Area3.TabIndex = 1;
            this.btn_Area3.TabStop = false;
            this.btn_Area3.Text = "3";
            this.btn_Area3.UseVisualStyleBackColor = false;
            this.btn_Area3.Visible = false;
            this.btn_Area3.Click += new System.EventHandler(this.btn_Area1_Click);
            // 
            // btn_Area2
            // 
            this.btn_Area2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Area2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Area2.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Area2.Location = new System.Drawing.Point(447, 222);
            this.btn_Area2.Name = "btn_Area2";
            this.btn_Area2.Size = new System.Drawing.Size(43, 23);
            this.btn_Area2.TabIndex = 1;
            this.btn_Area2.TabStop = false;
            this.btn_Area2.Text = "2";
            this.btn_Area2.UseVisualStyleBackColor = false;
            this.btn_Area2.Visible = false;
            this.btn_Area2.Click += new System.EventHandler(this.btn_Area1_Click);
            // 
            // btn_Area1
            // 
            this.btn_Area1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Area1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Area1.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Area1.Location = new System.Drawing.Point(447, 175);
            this.btn_Area1.Name = "btn_Area1";
            this.btn_Area1.Size = new System.Drawing.Size(43, 23);
            this.btn_Area1.TabIndex = 1;
            this.btn_Area1.TabStop = false;
            this.btn_Area1.Text = "1";
            this.btn_Area1.UseVisualStyleBackColor = false;
            this.btn_Area1.Visible = false;
            this.btn_Area1.Click += new System.EventHandler(this.btn_Area1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DS_Certifikati";
            reportDataSource2.Value = this.view_CertifikatiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FIT_MIS_SeminarskiRad_3086.Reports.report_printanjeCertifikata.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(1053, 594);
            this.reportViewer1.TabIndex = 0;
            // 
            // cB
            // 
            this.cB.FormattingEnabled = true;
            this.cB.Location = new System.Drawing.Point(12, 12);
            this.cB.Name = "cB";
            this.cB.Size = new System.Drawing.Size(183, 21);
            this.cB.TabIndex = 1;
            this.cB.SelectionChangeCommitted += new System.EventHandler(this.cB_SelectionChangeCommitted);
            this.cB.Enter += new System.EventHandler(this.cB_Enter);
            // 
            // tB1
            // 
            this.tB1.BackColor = System.Drawing.SystemColors.MenuText;
            this.tB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB1.ForeColor = System.Drawing.SystemColors.Window;
            this.tB1.Location = new System.Drawing.Point(868, 12);
            this.tB1.Name = "tB1";
            this.tB1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB1.Size = new System.Drawing.Size(100, 26);
            this.tB1.TabIndex = 2;
            this.tB1.Text = " ";
            this.tB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB1.Visible = false;
            this.tB1.Leave += new System.EventHandler(this.tB1_Leave);
            // 
            // tB2
            // 
            this.tB2.BackColor = System.Drawing.SystemColors.MenuText;
            this.tB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB2.ForeColor = System.Drawing.SystemColors.Window;
            this.tB2.Location = new System.Drawing.Point(868, 12);
            this.tB2.Name = "tB2";
            this.tB2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB2.Size = new System.Drawing.Size(100, 26);
            this.tB2.TabIndex = 3;
            this.tB2.Text = " ";
            this.tB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB2.Visible = false;
            this.tB2.Leave += new System.EventHandler(this.tB1_Leave);
            // 
            // tB3
            // 
            this.tB3.BackColor = System.Drawing.SystemColors.MenuText;
            this.tB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB3.ForeColor = System.Drawing.SystemColors.Window;
            this.tB3.Location = new System.Drawing.Point(868, 11);
            this.tB3.Name = "tB3";
            this.tB3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB3.Size = new System.Drawing.Size(100, 26);
            this.tB3.TabIndex = 4;
            this.tB3.Text = " ";
            this.tB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB3.Visible = false;
            this.tB3.Leave += new System.EventHandler(this.tB1_Leave);
            // 
            // tB4
            // 
            this.tB4.BackColor = System.Drawing.SystemColors.MenuText;
            this.tB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB4.ForeColor = System.Drawing.SystemColors.Window;
            this.tB4.Location = new System.Drawing.Point(868, 11);
            this.tB4.Name = "tB4";
            this.tB4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB4.Size = new System.Drawing.Size(100, 26);
            this.tB4.TabIndex = 5;
            this.tB4.Text = " ";
            this.tB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB4.Visible = false;
            this.tB4.Leave += new System.EventHandler(this.tB1_Leave);
            // 
            // tB5
            // 
            this.tB5.BackColor = System.Drawing.SystemColors.MenuText;
            this.tB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tB5.ForeColor = System.Drawing.SystemColors.Window;
            this.tB5.Location = new System.Drawing.Point(868, 12);
            this.tB5.Name = "tB5";
            this.tB5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB5.Size = new System.Drawing.Size(100, 26);
            this.tB5.TabIndex = 6;
            this.tB5.Text = " ";
            this.tB5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB5.Visible = false;
            this.tB5.Leave += new System.EventHandler(this.tB1_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(239, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Edit";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frm_printanjeCertifikata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 689);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tB5);
            this.Controls.Add(this.tB4);
            this.Controls.Add(this.tB3);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.cB);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(820, 670);
            this.Name = "frm_printanjeCertifikata";
            this.Text = "frm_printanjeCertifikata";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_printanjeCertifikata_Load);
            this.SizeChanged += new System.EventHandler(this.frm_printanjeCertifikata_SizeChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frm_printanjeCertifikata_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.view_CertifikatiBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cB;
        private System.Windows.Forms.BindingSource view_CertifikatiBindingSource;
        private System.Windows.Forms.Button btn_Area1;
        private System.Windows.Forms.Button btn_Area2;
        private System.Windows.Forms.Button btn_Area3;
        private System.Windows.Forms.Button btn_Area5;
        private System.Windows.Forms.Button btn_Area4;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.TextBox tB3;
        private System.Windows.Forms.TextBox tB4;
        private System.Windows.Forms.TextBox tB5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}