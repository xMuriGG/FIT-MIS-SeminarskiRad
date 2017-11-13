namespace FIT_MIS_SeminarskiRad_3086
{
    partial class frm_PretragaKandidata
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PretragaKandidata));
            this.cB_Kurs = new System.Windows.Forms.ComboBox();
            this.cB_Modul = new System.Windows.Forms.ComboBox();
            this.dGV_Kursevi = new System.Windows.Forms.DataGridView();
            this.TrainingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_clearFilter = new System.Windows.Forms.Button();
            this.dGV_Grupe = new System.Windows.Forms.DataGridView();
            this.TrainingGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_Kandidati = new System.Windows.Forms.DataGridView();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfAdmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_PodaciOKandidatu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Kursevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Grupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Kandidati)).BeginInit();
            this.SuspendLayout();
            // 
            // cB_Kurs
            // 
            this.cB_Kurs.FormattingEnabled = true;
            this.cB_Kurs.Location = new System.Drawing.Point(24, 12);
            this.cB_Kurs.Name = "cB_Kurs";
            this.cB_Kurs.Size = new System.Drawing.Size(276, 21);
            this.cB_Kurs.TabIndex = 0;
            this.cB_Kurs.SelectedIndexChanged += new System.EventHandler(this.cB_Kurs_SelectedIndexChanged);
            // 
            // cB_Modul
            // 
            this.cB_Modul.Enabled = false;
            this.cB_Modul.FormattingEnabled = true;
            this.cB_Modul.Location = new System.Drawing.Point(358, 12);
            this.cB_Modul.Name = "cB_Modul";
            this.cB_Modul.Size = new System.Drawing.Size(276, 21);
            this.cB_Modul.TabIndex = 1;
            this.cB_Modul.SelectedIndexChanged += new System.EventHandler(this.cB_Modul_SelectedIndexChanged);
            // 
            // dGV_Kursevi
            // 
            this.dGV_Kursevi.AllowUserToAddRows = false;
            this.dGV_Kursevi.AllowUserToDeleteRows = false;
            this.dGV_Kursevi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Kursevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Kursevi.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGV_Kursevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Kursevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainingID,
            this.Type,
            this.Kurs,
            this.Duration,
            this.Price,
            this.Leader,
            this.Active});
            this.dGV_Kursevi.Location = new System.Drawing.Point(24, 57);
            this.dGV_Kursevi.Name = "dGV_Kursevi";
            this.dGV_Kursevi.ReadOnly = true;
            this.dGV_Kursevi.RowHeadersVisible = false;
            this.dGV_Kursevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Kursevi.Size = new System.Drawing.Size(814, 167);
            this.dGV_Kursevi.TabIndex = 1;
            this.dGV_Kursevi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Kursevi_CellContentClick);
            // 
            // TrainingID
            // 
            this.TrainingID.DataPropertyName = "TrainingID";
            this.TrainingID.HeaderText = "TrainingID";
            this.TrainingID.Name = "TrainingID";
            this.TrainingID.ReadOnly = true;
            this.TrainingID.Visible = false;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Kurs";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Kurs
            // 
            this.Kurs.DataPropertyName = "Name";
            this.Kurs.HeaderText = "Modul";
            this.Kurs.Name = "Kurs";
            this.Kurs.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Trajanje";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle1;
            this.Price.HeaderText = "Cijena";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Leader
            // 
            this.Leader.DataPropertyName = "Leader";
            this.Leader.HeaderText = "Predavač";
            this.Leader.Name = "Leader";
            this.Leader.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Aktivan";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // btn_clearFilter
            // 
            this.btn_clearFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clearFilter.BackgroundImage")));
            this.btn_clearFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clearFilter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_clearFilter.Location = new System.Drawing.Point(798, 3);
            this.btn_clearFilter.Name = "btn_clearFilter";
            this.btn_clearFilter.Size = new System.Drawing.Size(40, 37);
            this.btn_clearFilter.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_clearFilter, "Ukloni filter (Esc)");
            this.btn_clearFilter.UseVisualStyleBackColor = true;
            this.btn_clearFilter.Click += new System.EventHandler(this.btn_clearFilter_Click);
            // 
            // dGV_Grupe
            // 
            this.dGV_Grupe.AllowUserToAddRows = false;
            this.dGV_Grupe.AllowUserToDeleteRows = false;
            this.dGV_Grupe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Grupe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Grupe.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGV_Grupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Grupe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainingGroupID,
            this.Naziv,
            this.StartDate,
            this.EndDate});
            this.dGV_Grupe.Location = new System.Drawing.Point(24, 252);
            this.dGV_Grupe.Name = "dGV_Grupe";
            this.dGV_Grupe.ReadOnly = true;
            this.dGV_Grupe.RowHeadersVisible = false;
            this.dGV_Grupe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Grupe.Size = new System.Drawing.Size(814, 167);
            this.dGV_Grupe.TabIndex = 1;
            this.dGV_Grupe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Grupe_CellContentClick);
            // 
            // TrainingGroupID
            // 
            this.TrainingGroupID.DataPropertyName = "TrainingGroupID";
            this.TrainingGroupID.HeaderText = "TrainingGroupID";
            this.TrainingGroupID.Name = "TrainingGroupID";
            this.TrainingGroupID.ReadOnly = true;
            this.TrainingGroupID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Name";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Vrijeme početka";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "Vrijeme završetka";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // dGV_Kandidati
            // 
            this.dGV_Kandidati.AllowUserToAddRows = false;
            this.dGV_Kandidati.AllowUserToDeleteRows = false;
            this.dGV_Kandidati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Kandidati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Kandidati.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGV_Kandidati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Kandidati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.Email,
            this.DateOfAdmission,
            this.Notes});
            this.dGV_Kandidati.Location = new System.Drawing.Point(24, 450);
            this.dGV_Kandidati.Name = "dGV_Kandidati";
            this.dGV_Kandidati.ReadOnly = true;
            this.dGV_Kandidati.RowHeadersVisible = false;
            this.dGV_Kandidati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Kandidati.Size = new System.Drawing.Size(814, 167);
            this.dGV_Kandidati.TabIndex = 1;
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "PersonID";
            this.PersonID.HeaderText = "PersonID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            this.PersonID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Ime";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Prezime";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Spol";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 53;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 57;
            // 
            // DateOfAdmission
            // 
            this.DateOfAdmission.DataPropertyName = "DateOfAdmission";
            this.DateOfAdmission.HeaderText = "Datum upisa";
            this.DateOfAdmission.Name = "DateOfAdmission";
            this.DateOfAdmission.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Bilješke";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // btn_PodaciOKandidatu
            // 
            this.btn_PodaciOKandidatu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_PodaciOKandidatu.Location = new System.Drawing.Point(24, 640);
            this.btn_PodaciOKandidatu.Name = "btn_PodaciOKandidatu";
            this.btn_PodaciOKandidatu.Size = new System.Drawing.Size(124, 23);
            this.btn_PodaciOKandidatu.TabIndex = 3;
            this.btn_PodaciOKandidatu.Text = "Podaci o kandidatu";
            this.btn_PodaciOKandidatu.UseVisualStyleBackColor = true;
            this.btn_PodaciOKandidatu.Click += new System.EventHandler(this.btn_PodaciOKandidatu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kursevi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grupe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kandidati:";
            // 
            // frm_PretragaKandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_clearFilter;
            this.ClientSize = new System.Drawing.Size(863, 675);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PodaciOKandidatu);
            this.Controls.Add(this.btn_clearFilter);
            this.Controls.Add(this.dGV_Kandidati);
            this.Controls.Add(this.dGV_Grupe);
            this.Controls.Add(this.dGV_Kursevi);
            this.Controls.Add(this.cB_Modul);
            this.Controls.Add(this.cB_Kurs);
            this.Name = "frm_PretragaKandidata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga kurseva";
            this.Load += new System.EventHandler(this.frm_PretragaKandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Kursevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Grupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Kandidati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cB_Kurs;
        private System.Windows.Forms.ComboBox cB_Modul;
        private System.Windows.Forms.DataGridView dGV_Kursevi;
        private System.Windows.Forms.DataGridView dGV_Grupe;
        private System.Windows.Forms.DataGridView dGV_Kandidati;
        private System.Windows.Forms.Button btn_PodaciOKandidatu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leader;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAdmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_clearFilter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}