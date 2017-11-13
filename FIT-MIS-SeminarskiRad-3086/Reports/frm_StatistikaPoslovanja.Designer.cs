namespace FIT_MIS_SeminarskiRad_3086.Reports
{
    partial class frm_StatistikaPoslovanja
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DS_UplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_UplateMonth_BS = new System.Windows.Forms.BindingSource(this.components);
            this.statistika_Uplate_MatrixDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabYear = new System.Windows.Forms.TabPage();
            this.rV_Uplate_Chart = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabMonth = new System.Windows.Forms.TabPage();
            this.rv_MonthTab = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cb_monthYears = new System.Windows.Forms.ComboBox();
            this.tabDay = new System.Windows.Forms.TabPage();
            this.rV_DayTab = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cB_Month_DayTab = new System.Windows.Forms.ComboBox();
            this.cB_Year_DayTab = new System.Windows.Forms.ComboBox();
            this.cB_chart = new System.Windows.Forms.CheckBox();
            this.cB_matrix = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.rV_Uplate_matrix = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cB_To = new System.Windows.Forms.ComboBox();
            this.cB_From = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DS_UplateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_UplateMonth_BS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistika_Uplate_MatrixDataTableBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabYear.SuspendLayout();
            this.tabMonth.SuspendLayout();
            this.tabDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // DS_UplateBindingSource
            // 
            this.DS_UplateBindingSource.DataMember = "statistika_Uplate_Matrix";
            this.DS_UplateBindingSource.DataSource = typeof(DAL_FIT_MIS_SeminarskiRad_3086.DS_Uplate);
            // 
            // statistika_Uplate_MatrixDataTableBindingSource
            // 
            this.statistika_Uplate_MatrixDataTableBindingSource.DataSource = typeof(DAL_FIT_MIS_SeminarskiRad_3086.DS_Uplate.statistika_Uplate_MatrixDataTable);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabYear);
            this.tabControl1.Controls.Add(this.tabMonth);
            this.tabControl1.Controls.Add(this.tabDay);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // tabYear
            // 
            this.tabYear.BackColor = System.Drawing.Color.White;
            this.tabYear.Controls.Add(this.rV_Uplate_Chart);
            this.tabYear.Location = new System.Drawing.Point(4, 29);
            this.tabYear.Name = "tabYear";
            this.tabYear.Padding = new System.Windows.Forms.Padding(3);
            this.tabYear.Size = new System.Drawing.Size(787, 334);
            this.tabYear.TabIndex = 0;
            this.tabYear.Text = "Years";
            // 
            // rV_Uplate_Chart
            // 
            this.rV_Uplate_Chart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rV_Uplate_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DS_UplateBindingSource;
            this.rV_Uplate_Chart.LocalReport.DataSources.Add(reportDataSource1);
            this.rV_Uplate_Chart.LocalReport.ReportEmbeddedResource = "FIT_MIS_SeminarskiRad_3086.Reports.report_statistikaUplateChart.rdlc";
            this.rV_Uplate_Chart.Location = new System.Drawing.Point(3, 3);
            this.rV_Uplate_Chart.Name = "rV_Uplate_Chart";
            this.rV_Uplate_Chart.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.rV_Uplate_Chart.ShowToolBar = false;
            this.rV_Uplate_Chart.Size = new System.Drawing.Size(781, 328);
            this.rV_Uplate_Chart.TabIndex = 6;
            // 
            // tabMonth
            // 
            this.tabMonth.Controls.Add(this.rv_MonthTab);
            this.tabMonth.Controls.Add(this.cb_monthYears);
            this.tabMonth.Location = new System.Drawing.Point(4, 29);
            this.tabMonth.Name = "tabMonth";
            this.tabMonth.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonth.Size = new System.Drawing.Size(787, 334);
            this.tabMonth.TabIndex = 1;
            this.tabMonth.Text = "Months";
            this.tabMonth.UseVisualStyleBackColor = true;
            // 
            // rv_MonthTab
            // 
            this.rv_MonthTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_MonthTab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource2.Name = "DS_UplateMonths";
            reportDataSource2.Value = this.DS_UplateMonth_BS;
            this.rv_MonthTab.LocalReport.DataSources.Add(reportDataSource2);
            this.rv_MonthTab.LocalReport.ReportEmbeddedResource = "FIT_MIS_SeminarskiRad_3086.Reports.report_statistikaUplateChartMonths.rdlc";
            this.rv_MonthTab.Location = new System.Drawing.Point(6, 35);
            this.rv_MonthTab.Name = "rv_MonthTab";
            this.rv_MonthTab.ShowToolBar = false;
            this.rv_MonthTab.Size = new System.Drawing.Size(775, 285);
            this.rv_MonthTab.TabIndex = 14;
            // 
            // cb_monthYears
            // 
            this.cb_monthYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_monthYears.FormattingEnabled = true;
            this.cb_monthYears.Location = new System.Drawing.Point(6, 6);
            this.cb_monthYears.Name = "cb_monthYears";
            this.cb_monthYears.Size = new System.Drawing.Size(121, 23);
            this.cb_monthYears.TabIndex = 13;
            this.cb_monthYears.SelectionChangeCommitted += new System.EventHandler(this.cb_monthYears_SelectionChangeCommitted);
            // 
            // tabDay
            // 
            this.tabDay.Controls.Add(this.rV_DayTab);
            this.tabDay.Controls.Add(this.cB_Month_DayTab);
            this.tabDay.Controls.Add(this.cB_Year_DayTab);
            this.tabDay.Location = new System.Drawing.Point(4, 29);
            this.tabDay.Name = "tabDay";
            this.tabDay.Size = new System.Drawing.Size(787, 334);
            this.tabDay.TabIndex = 2;
            this.tabDay.Text = "Days";
            this.tabDay.UseVisualStyleBackColor = true;
            // 
            // rV_DayTab
            // 
            this.rV_DayTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rV_DayTab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource3.Name = "DS_Uplate_Day";
            reportDataSource3.Value = this.DS_UplateBindingSource;
            this.rV_DayTab.LocalReport.DataSources.Add(reportDataSource3);
            this.rV_DayTab.LocalReport.ReportEmbeddedResource = "FIT_MIS_SeminarskiRad_3086.Reports.report_statistikaUplateChartDays.rdlc";
            this.rV_DayTab.Location = new System.Drawing.Point(6, 35);
            this.rV_DayTab.Name = "rV_DayTab";
            this.rV_DayTab.ShowToolBar = false;
            this.rV_DayTab.Size = new System.Drawing.Size(775, 296);
            this.rV_DayTab.TabIndex = 15;
            // 
            // cB_Month_DayTab
            // 
            this.cB_Month_DayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cB_Month_DayTab.FormattingEnabled = true;
            this.cB_Month_DayTab.Location = new System.Drawing.Point(133, 6);
            this.cB_Month_DayTab.Name = "cB_Month_DayTab";
            this.cB_Month_DayTab.Size = new System.Drawing.Size(121, 23);
            this.cB_Month_DayTab.TabIndex = 14;
            this.cB_Month_DayTab.SelectionChangeCommitted += new System.EventHandler(this.cB_Month_DayTab_SelectionChangeCommitted);
            // 
            // cB_Year_DayTab
            // 
            this.cB_Year_DayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cB_Year_DayTab.FormattingEnabled = true;
            this.cB_Year_DayTab.Location = new System.Drawing.Point(6, 6);
            this.cB_Year_DayTab.Name = "cB_Year_DayTab";
            this.cB_Year_DayTab.Size = new System.Drawing.Size(121, 23);
            this.cB_Year_DayTab.TabIndex = 14;
            this.cB_Year_DayTab.SelectionChangeCommitted += new System.EventHandler(this.cB_Year_DayTab_SelectionChangeCommitted);
            // 
            // cB_chart
            // 
            this.cB_chart.AutoSize = true;
            this.cB_chart.Checked = true;
            this.cB_chart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_chart.Location = new System.Drawing.Point(380, 36);
            this.cB_chart.Name = "cB_chart";
            this.cB_chart.Size = new System.Drawing.Size(15, 14);
            this.cB_chart.TabIndex = 19;
            this.cB_chart.UseVisualStyleBackColor = true;
            this.cB_chart.CheckedChanged += new System.EventHandler(this.cB_chart_CheckedChanged);
            // 
            // cB_matrix
            // 
            this.cB_matrix.AutoSize = true;
            this.cB_matrix.Checked = true;
            this.cB_matrix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_matrix.Location = new System.Drawing.Point(323, 36);
            this.cB_matrix.Name = "cB_matrix";
            this.cB_matrix.Size = new System.Drawing.Size(15, 14);
            this.cB_matrix.TabIndex = 20;
            this.cB_matrix.UseVisualStyleBackColor = true;
            this.cB_matrix.CheckedChanged += new System.EventHandler(this.cB_matrix_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(361, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Chart:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(303, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Matrix:";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Location = new System.Drawing.Point(15, 61);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.rV_Uplate_matrix);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer.Size = new System.Drawing.Size(799, 628);
            this.splitContainer.SplitterDistance = 251;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 16;
            // 
            // rV_Uplate_matrix
            // 
            this.rV_Uplate_matrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rV_Uplate_matrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rV_Uplate_matrix.IsDocumentMapWidthFixed = true;
            reportDataSource4.Name = "DS_statistika_Uplate";
            reportDataSource4.Value = this.statistika_Uplate_MatrixDataTableBindingSource;
            this.rV_Uplate_matrix.LocalReport.DataSources.Add(reportDataSource4);
            this.rV_Uplate_matrix.LocalReport.ReportEmbeddedResource = "FIT_MIS_SeminarskiRad_3086.Reports.report_statistikaUplate.rdlc";
            this.rV_Uplate_matrix.Location = new System.Drawing.Point(0, 0);
            this.rV_Uplate_matrix.Name = "rV_Uplate_matrix";
            this.rV_Uplate_matrix.ShowToolBar = false;
            this.rV_Uplate_matrix.Size = new System.Drawing.Size(795, 247);
            this.rV_Uplate_matrix.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(183, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(58, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Od:";
            // 
            // cB_To
            // 
            this.cB_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cB_To.FormattingEnabled = true;
            this.cB_To.Location = new System.Drawing.Point(140, 32);
            this.cB_To.Name = "cB_To";
            this.cB_To.Size = new System.Drawing.Size(121, 23);
            this.cB_To.TabIndex = 12;
            this.cB_To.SelectionChangeCommitted += new System.EventHandler(this.cB_To_SelectionChangeCommitted);
            // 
            // cB_From
            // 
            this.cB_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cB_From.FormattingEnabled = true;
            this.cB_From.Location = new System.Drawing.Point(15, 32);
            this.cB_From.Name = "cB_From";
            this.cB_From.Size = new System.Drawing.Size(121, 23);
            this.cB_From.TabIndex = 13;
            this.cB_From.SelectionChangeCommitted += new System.EventHandler(this.cB_From_SelectionChangeCommitted);
            // 
            // frm_StatistikaPoslovanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 701);
            this.Controls.Add(this.cB_chart);
            this.Controls.Add(this.cB_matrix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cB_To);
            this.Controls.Add(this.cB_From);
            this.Name = "frm_StatistikaPoslovanja";
            this.Text = "Statistika poslovanja";
            this.Load += new System.EventHandler(this.frm_StatistikaPoslovanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_UplateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_UplateMonth_BS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistika_Uplate_MatrixDataTableBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabYear.ResumeLayout(false);
            this.tabMonth.ResumeLayout(false);
            this.tabDay.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabYear;
        private System.Windows.Forms.TabPage tabMonth;
        private System.Windows.Forms.BindingSource statistika_Uplate_MatrixDataTableBindingSource;
        private System.Windows.Forms.BindingSource DS_UplateBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rV_Uplate_Chart;
        private System.Windows.Forms.CheckBox cB_chart;
        private System.Windows.Forms.CheckBox cB_matrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Microsoft.Reporting.WinForms.ReportViewer rV_Uplate_matrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_To;
        private System.Windows.Forms.ComboBox cB_From;
        private System.Windows.Forms.ComboBox cb_monthYears;
        private Microsoft.Reporting.WinForms.ReportViewer rv_MonthTab;
        private System.Windows.Forms.TabPage tabDay;
        private System.Windows.Forms.ComboBox cB_Month_DayTab;
        private System.Windows.Forms.ComboBox cB_Year_DayTab;
        private Microsoft.Reporting.WinForms.ReportViewer rV_DayTab;
        private System.Windows.Forms.BindingSource DS_UplateMonth_BS;
    }
}