namespace FIT_MIS_SeminarskiRad_3086.Forms
{
    partial class frm_PretragaCertifikata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PretragaCertifikata));
            this.txt_fName = new System.Windows.Forms.TextBox();
            this.txt_lName = new System.Windows.Forms.TextBox();
            this.cB_Kurs = new System.Windows.Forms.ComboBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.dGV_Certifikati = new System.Windows.Forms.DataGridView();
            this.btn_clearFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CertifikateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Certifikati)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_fName
            // 
            this.txt_fName.Location = new System.Drawing.Point(30, 28);
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(146, 20);
            this.txt_fName.TabIndex = 0;
            // 
            // txt_lName
            // 
            this.txt_lName.Location = new System.Drawing.Point(188, 28);
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.Size = new System.Drawing.Size(146, 20);
            this.txt_lName.TabIndex = 1;
            // 
            // cB_Kurs
            // 
            this.cB_Kurs.FormattingEnabled = true;
            this.cB_Kurs.Location = new System.Drawing.Point(346, 27);
            this.cB_Kurs.Name = "cB_Kurs";
            this.cB_Kurs.Size = new System.Drawing.Size(162, 21);
            this.cB_Kurs.TabIndex = 2;
            this.cB_Kurs.SelectionChangeCommitted += new System.EventHandler(this.cB_Kurs_SelectionChangeCommitted);
            // 
            // btn_filter
            // 
            this.btn_filter.BackgroundImage = global::FIT_MIS_SeminarskiRad_3086.Properties.Resources.filterr;
            this.btn_filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_filter.Location = new System.Drawing.Point(551, 19);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(40, 37);
            this.btn_filter.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_filter, "Filter (Enter)");
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // dGV_Certifikati
            // 
            this.dGV_Certifikati.AllowUserToAddRows = false;
            this.dGV_Certifikati.AllowUserToDeleteRows = false;
            this.dGV_Certifikati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Certifikati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Certifikati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.CertifikateID,
            this.TrainingID,
            this.ImePrezime,
            this.BirthDate,
            this.DeliveryDate,
            this.Delivered,
            this.Modul,
            this.Kurs,
            this.Print});
            this.dGV_Certifikati.Location = new System.Drawing.Point(30, 82);
            this.dGV_Certifikati.Name = "dGV_Certifikati";
            this.dGV_Certifikati.RowHeadersVisible = false;
            this.dGV_Certifikati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Certifikati.Size = new System.Drawing.Size(946, 517);
            this.dGV_Certifikati.TabIndex = 5;
            this.dGV_Certifikati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Certifikati_CellContentClick);
            // 
            // btn_clearFilter
            // 
            this.btn_clearFilter.BackgroundImage = global::FIT_MIS_SeminarskiRad_3086.Properties.Resources.M_Unfilter;
            this.btn_clearFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clearFilter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_clearFilter.Location = new System.Drawing.Point(597, 19);
            this.btn_clearFilter.Name = "btn_clearFilter";
            this.btn_clearFilter.Size = new System.Drawing.Size(40, 37);
            this.btn_clearFilter.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_clearFilter, "Ukloni filter (Esc)");
            this.btn_clearFilter.UseVisualStyleBackColor = true;
            this.btn_clearFilter.Click += new System.EventHandler(this.btn_clearFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(238, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(32, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Certifikati:";
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "PersonID";
            this.PersonID.HeaderText = "PersonID";
            this.PersonID.Name = "PersonID";
            this.PersonID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonID.Visible = false;
            // 
            // CertifikateID
            // 
            this.CertifikateID.DataPropertyName = "CertifikateID";
            this.CertifikateID.HeaderText = "CertifikateID";
            this.CertifikateID.Name = "CertifikateID";
            this.CertifikateID.Visible = false;
            // 
            // TrainingID
            // 
            this.TrainingID.DataPropertyName = "TrainingID";
            this.TrainingID.HeaderText = "TrainingID";
            this.TrainingID.Name = "TrainingID";
            this.TrainingID.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Datum rođenja";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Width = 102;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            this.DeliveryDate.HeaderText = "Datum uručenja";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Width = 98;
            // 
            // Delivered
            // 
            this.Delivered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Delivered.DataPropertyName = "Delivered";
            this.Delivered.HeaderText = "Uručeno";
            this.Delivered.Name = "Delivered";
            this.Delivered.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delivered.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delivered.Width = 73;
            // 
            // Modul
            // 
            this.Modul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Modul.DataPropertyName = "Modul";
            this.Modul.HeaderText = "Modul";
            this.Modul.Name = "Modul";
            this.Modul.Width = 61;
            // 
            // Kurs
            // 
            this.Kurs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kurs.DataPropertyName = "Kurs";
            this.Kurs.HeaderText = "Kurs";
            this.Kurs.Name = "Kurs";
            // 
            // Print
            // 
            this.Print.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Print.HeaderText = "Printati";
            this.Print.Image = ((System.Drawing.Image)(resources.GetObject("Print.Image")));
            this.Print.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Print.Name = "Print";
            this.Print.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Print.ToolTipText = "Printaj";
            this.Print.Width = 45;
            // 
            // frm_PretragaCertifikata
            // 
            this.AcceptButton = this.btn_filter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_clearFilter;
            this.ClientSize = new System.Drawing.Size(1018, 611);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_Certifikati);
            this.Controls.Add(this.btn_clearFilter);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.cB_Kurs);
            this.Controls.Add(this.txt_lName);
            this.Controls.Add(this.txt_fName);
            this.Name = "frm_PretragaCertifikata";
            this.Text = "frm_PretragaCertifikata";
            this.Load += new System.EventHandler(this.frm_PretragaCertifikata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Certifikati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_fName;
        private System.Windows.Forms.TextBox txt_lName;
        private System.Windows.Forms.ComboBox cB_Kurs;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DataGridView dGV_Certifikati;
        private System.Windows.Forms.Button btn_clearFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertifikateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
        private System.Windows.Forms.DataGridViewImageColumn Print;
    }
}