namespace FIT_MIS_SeminarskiRad_3086.Reports
{
    partial class frm_reportUplate
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
            this.DS_UplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DS_UplateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DS_UplateBindingSource
            // 
            this.DS_UplateBindingSource.DataMember = "view_Uplate";
            this.DS_UplateBindingSource.DataSource = typeof(DAL_FIT_MIS_SeminarskiRad_3086.DS_Uplate);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Uplate";
            reportDataSource1.Value = this.DS_UplateBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "FIT_MIS_SeminarskiRad_3086.Reports.report_ListaUplata.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ShowBackButton = false;
            this.reportViewer.ShowFindControls = false;
            this.reportViewer.ShowRefreshButton = false;
            this.reportViewer.ShowStopButton = false;
            this.reportViewer.Size = new System.Drawing.Size(1038, 678);
            this.reportViewer.TabIndex = 0;
            // 
            // frm_reportUplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 678);
            this.Controls.Add(this.reportViewer);
            this.Name = "frm_reportUplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Report uplate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_reportUplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_UplateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource DS_UplateBindingSource;
    }
}