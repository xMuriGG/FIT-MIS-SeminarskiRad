namespace FIT_MIS_SeminarskiRad_3086
{
    partial class frm_PlateZaposlenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PlateZaposlenika));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_fName = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dGV_Zaposlenici = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dTP_From = new System.Windows.Forms.DateTimePicker();
            this.txt_lName = new System.Windows.Forms.TextBox();
            this.dTP_To = new System.Windows.Forms.DateTimePicker();
            this.dGV_Plate = new System.Windows.Forms.DataGridView();
            this.EmployeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_DateClear = new System.Windows.Forms.Button();
            this.btn_DateSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Zaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Plate)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_fName
            // 
            this.txt_fName.Location = new System.Drawing.Point(23, 29);
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(155, 20);
            this.txt_fName.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.BackgroundImage")));
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Clear.Location = new System.Drawing.Point(446, 12);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(40, 37);
            this.btn_Clear.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_Clear, "Ukloni sve filtere (Esc)");
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dGV_Zaposlenici
            // 
            this.dGV_Zaposlenici.AllowUserToAddRows = false;
            this.dGV_Zaposlenici.AllowUserToDeleteRows = false;
            this.dGV_Zaposlenici.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Zaposlenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Zaposlenici.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGV_Zaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Zaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Gender,
            this.JobTitle,
            this.BirthDate,
            this.HireDate,
            this.Active});
            this.dGV_Zaposlenici.Location = new System.Drawing.Point(21, 78);
            this.dGV_Zaposlenici.Name = "dGV_Zaposlenici";
            this.dGV_Zaposlenici.ReadOnly = true;
            this.dGV_Zaposlenici.RowHeadersVisible = false;
            this.dGV_Zaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Zaposlenici.Size = new System.Drawing.Size(813, 237);
            this.dGV_Zaposlenici.TabIndex = 2;
            this.dGV_Zaposlenici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Zaposlenici_CellContentClick);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Visible = false;
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
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 57;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Spol";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 53;
            // 
            // JobTitle
            // 
            this.JobTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.JobTitle.DataPropertyName = "JobTitle";
            this.JobTitle.HeaderText = "Zvanje";
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.ReadOnly = true;
            this.JobTitle.Width = 65;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Datum rođenja";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Width = 94;
            // 
            // HireDate
            // 
            this.HireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HireDate.DataPropertyName = "HireDate";
            this.HireDate.HeaderText = "Datum zaposlenja";
            this.HireDate.Name = "HireDate";
            this.HireDate.ReadOnly = true;
            this.HireDate.Width = 106;
            // 
            // Active
            // 
            this.Active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Aktivan";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Active.Width = 68;
            // 
            // dTP_From
            // 
            this.dTP_From.Enabled = false;
            this.dTP_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_From.Location = new System.Drawing.Point(21, 341);
            this.dTP_From.Name = "dTP_From";
            this.dTP_From.Size = new System.Drawing.Size(95, 20);
            this.dTP_From.TabIndex = 3;
            this.dTP_From.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txt_lName
            // 
            this.txt_lName.Location = new System.Drawing.Point(196, 29);
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.Size = new System.Drawing.Size(155, 20);
            this.txt_lName.TabIndex = 1;
            // 
            // dTP_To
            // 
            this.dTP_To.Enabled = false;
            this.dTP_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_To.Location = new System.Drawing.Point(132, 341);
            this.dTP_To.Name = "dTP_To";
            this.dTP_To.Size = new System.Drawing.Size(95, 20);
            this.dTP_To.TabIndex = 3;
            // 
            // dGV_Plate
            // 
            this.dGV_Plate.AllowUserToAddRows = false;
            this.dGV_Plate.AllowUserToDeleteRows = false;
            this.dGV_Plate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Plate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Plate.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGV_Plate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Plate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeID,
            this.PersonID,
            this.ImePrezime,
            this.PayDate,
            this.Amount,
            this.Purpose});
            this.dGV_Plate.Enabled = false;
            this.dGV_Plate.Location = new System.Drawing.Point(21, 390);
            this.dGV_Plate.Name = "dGV_Plate";
            this.dGV_Plate.ReadOnly = true;
            this.dGV_Plate.RowHeadersVisible = false;
            this.dGV_Plate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Plate.Size = new System.Drawing.Size(813, 237);
            this.dGV_Plate.TabIndex = 2;
            // 
            // EmployeID
            // 
            this.EmployeID.DataPropertyName = "EmployeID";
            this.EmployeID.HeaderText = "EmployeID";
            this.EmployeID.Name = "EmployeID";
            this.EmployeID.ReadOnly = true;
            this.EmployeID.Visible = false;
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "PersonID";
            this.PersonID.HeaderText = "PersonID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            this.PersonID.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 86;
            // 
            // PayDate
            // 
            this.PayDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PayDate.DataPropertyName = "PayDate";
            this.PayDate.HeaderText = "PayDate";
            this.PayDate.Name = "PayDate";
            this.PayDate.ReadOnly = true;
            this.PayDate.Width = 73;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "00.00";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle1;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 68;
            // 
            // Purpose
            // 
            this.Purpose.DataPropertyName = "Purpose";
            this.Purpose.HeaderText = "Purpose";
            this.Purpose.Name = "Purpose";
            this.Purpose.ReadOnly = true;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search.Location = new System.Drawing.Point(400, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(40, 37);
            this.btn_Search.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_Search, "Filter zaposlenika (Enter)");
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_DateClear
            // 
            this.btn_DateClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DateClear.BackgroundImage")));
            this.btn_DateClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DateClear.Enabled = false;
            this.btn_DateClear.Location = new System.Drawing.Point(302, 332);
            this.btn_DateClear.Name = "btn_DateClear";
            this.btn_DateClear.Size = new System.Drawing.Size(34, 29);
            this.btn_DateClear.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_DateClear, "Ukloni filter plata");
            this.btn_DateClear.UseVisualStyleBackColor = true;
            this.btn_DateClear.Click += new System.EventHandler(this.btn_DateClear_Click);
            // 
            // btn_DateSearch
            // 
            this.btn_DateSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DateSearch.BackgroundImage")));
            this.btn_DateSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DateSearch.Enabled = false;
            this.btn_DateSearch.Location = new System.Drawing.Point(261, 332);
            this.btn_DateSearch.Name = "btn_DateSearch";
            this.btn_DateSearch.Size = new System.Drawing.Size(34, 29);
            this.btn_DateSearch.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_DateSearch, "Filter plata");
            this.btn_DateSearch.UseVisualStyleBackColor = true;
            this.btn_DateSearch.Click += new System.EventHandler(this.btn_DateSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(87, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(56, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(167, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Do:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(22, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(20, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Zaposlenici:";
            // 
            // btn_report
            // 
            this.btn_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_report.BackgroundImage = global::FIT_MIS_SeminarskiRad_3086.Properties.Resources.icon_ygg_report_E;
            this.btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_report.Location = new System.Drawing.Point(21, 633);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(47, 58);
            this.btn_report.TabIndex = 5;
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // frm_PlateZaposlenika
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Clear;
            this.ClientSize = new System.Drawing.Size(863, 696);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTP_To);
            this.Controls.Add(this.dTP_From);
            this.Controls.Add(this.dGV_Plate);
            this.Controls.Add(this.dGV_Zaposlenici);
            this.Controls.Add(this.btn_DateSearch);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_DateClear);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.txt_lName);
            this.Controls.Add(this.txt_fName);
            this.Name = "frm_PlateZaposlenika";
            this.Text = "Plate zaposlenika";
            this.Load += new System.EventHandler(this.frm_PlateZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Zaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Plate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_fName;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dGV_Zaposlenici;
        private System.Windows.Forms.DateTimePicker dTP_From;
        private System.Windows.Forms.TextBox txt_lName;
        private System.Windows.Forms.DateTimePicker dTP_To;
        private System.Windows.Forms.DataGridView dGV_Plate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.Button btn_DateClear;
        private System.Windows.Forms.Button btn_DateSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_report;
    }
}