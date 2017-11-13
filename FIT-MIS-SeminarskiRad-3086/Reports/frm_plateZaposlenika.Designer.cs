namespace FIT_MIS_SeminarskiRad_3086.Reports
{
    partial class frm_plateZaposlenika
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmployeePayHistoryDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ZaposleniciRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePayHistoryDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ZaposleniciRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Zaposlenik";
            reportDataSource1.Value = this.view_ZaposleniciRowBindingSource;
            reportDataSource2.Name = "DS_Isplate";
            reportDataSource2.Value = this.EmployeePayHistoryDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FIT_MIS_SeminarskiRad_3086.Reports.report_PlateZaposlenika.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(855, 566);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmployeePayHistoryDataTableBindingSource
            // 
            this.EmployeePayHistoryDataTableBindingSource.DataSource = typeof(DAL_FIT_MIS_SeminarskiRad_3086.DS_Zaposlenici.EmployeePayHistoryDataTable);
            // 
            // view_ZaposleniciRowBindingSource
            // 
            this.view_ZaposleniciRowBindingSource.DataSource = typeof(DAL_FIT_MIS_SeminarskiRad_3086.DS_Zaposlenici.view_ZaposleniciRow);
            // 
            // frm_plateZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 566);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_plateZaposlenika";
            this.Text = "Isplate zaposlenika";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_plateZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePayHistoryDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ZaposleniciRowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_ZaposleniciRowBindingSource;
        private System.Windows.Forms.BindingSource EmployeePayHistoryDataTableBindingSource;
    }
}