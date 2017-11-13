namespace FIT_MIS_SeminarskiRad_3086
{
    partial class frm_Uplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Uplate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_fName = new System.Windows.Forms.TextBox();
            this.dTP_From = new System.Windows.Forms.DateTimePicker();
            this.cB_Kursevi = new System.Windows.Forms.ComboBox();
            this.txt_lName = new System.Windows.Forms.TextBox();
            this.dTP_To = new System.Windows.Forms.DateTimePicker();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivModula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckGiven = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PaymentState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.More = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_search = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_removeCustomList = new System.Windows.Forms.Button();
            this.btn_reviewCustomList = new System.Windows.Forms.Button();
            this.btn_addToCustomList = new System.Windows.Forms.Button();
            this.btn_newCustomList = new System.Windows.Forms.Button();
            this.lbl_items = new System.Windows.Forms.Label();
            this.gB_customList = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gB_customList.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_fName
            // 
            this.txt_fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_fName.Location = new System.Drawing.Point(17, 27);
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(129, 21);
            this.txt_fName.TabIndex = 0;
            // 
            // dTP_From
            // 
            this.dTP_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dTP_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_From.Location = new System.Drawing.Point(317, 27);
            this.dTP_From.Name = "dTP_From";
            this.dTP_From.Size = new System.Drawing.Size(105, 21);
            this.dTP_From.TabIndex = 2;
            this.dTP_From.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cB_Kursevi
            // 
            this.cB_Kursevi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cB_Kursevi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cB_Kursevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cB_Kursevi.FormattingEnabled = true;
            this.cB_Kursevi.Location = new System.Drawing.Point(547, 26);
            this.cB_Kursevi.Name = "cB_Kursevi";
            this.cB_Kursevi.Size = new System.Drawing.Size(164, 23);
            this.cB_Kursevi.TabIndex = 4;
            this.cB_Kursevi.SelectionChangeCommitted += new System.EventHandler(this.cB_Kursevi_SelectionChangeCommitted);
            // 
            // txt_lName
            // 
            this.txt_lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_lName.Location = new System.Drawing.Point(165, 27);
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.Size = new System.Drawing.Size(129, 21);
            this.txt_lName.TabIndex = 1;
            // 
            // dTP_To
            // 
            this.dTP_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dTP_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_To.Location = new System.Drawing.Point(429, 27);
            this.dTP_To.Name = "dTP_To";
            this.dTP_To.Size = new System.Drawing.Size(102, 21);
            this.dTP_To.TabIndex = 3;
            this.dTP_To.Value = new System.DateTime(2016, 3, 9, 0, 24, 6, 0);
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ClearFilter.BackgroundImage")));
            this.btn_ClearFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ClearFilter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ClearFilter.Location = new System.Drawing.Point(806, 12);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(40, 37);
            this.btn_ClearFilter.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_ClearFilter, "Ukloni filter (Esc)");
            this.btn_ClearFilter.UseVisualStyleBackColor = true;
            this.btn_ClearFilter.Click += new System.EventHandler(this.btn_ClearFilter_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Kurs,
            this.NazivModula,
            this.PaymentDate,
            this.CheckGiven,
            this.PaymentState,
            this.Amount,
            this.More});
            this.dataGridView.Location = new System.Drawing.Point(17, 64);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(829, 513);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "ParticipantID";
            this.PersonID.HeaderText = "PersonID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            this.PersonID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Ime";
            this.FirstName.MinimumWidth = 50;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Prezime";
            this.LastName.MinimumWidth = 50;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 50;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Kurs
            // 
            this.Kurs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kurs.DataPropertyName = "Kurs";
            this.Kurs.HeaderText = "Kurs";
            this.Kurs.Name = "Kurs";
            this.Kurs.ReadOnly = true;
            this.Kurs.Width = 53;
            // 
            // NazivModula
            // 
            this.NazivModula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NazivModula.DataPropertyName = "Name";
            this.NazivModula.HeaderText = "NazivModula";
            this.NazivModula.Name = "NazivModula";
            this.NazivModula.ReadOnly = true;
            this.NazivModula.Width = 94;
            // 
            // PaymentDate
            // 
            this.PaymentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaymentDate.DataPropertyName = "PaymentDate";
            this.PaymentDate.HeaderText = "Datum plaćanja";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            this.PaymentDate.Width = 97;
            // 
            // CheckGiven
            // 
            this.CheckGiven.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CheckGiven.DataPropertyName = "CheckGiven";
            this.CheckGiven.HeaderText = "Račun izdat";
            this.CheckGiven.Name = "CheckGiven";
            this.CheckGiven.ReadOnly = true;
            this.CheckGiven.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckGiven.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckGiven.Width = 82;
            // 
            // PaymentState
            // 
            this.PaymentState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaymentState.DataPropertyName = "PaymentState";
            this.PaymentState.HeaderText = "Otplaćeno";
            this.PaymentState.Name = "PaymentState";
            this.PaymentState.ReadOnly = true;
            this.PaymentState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PaymentState.Width = 81;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "00.00";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle1;
            this.Amount.HeaderText = "Količina";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 69;
            // 
            // More
            // 
            this.More.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.More.HeaderText = "Više";
            this.More.Name = "More";
            this.More.ReadOnly = true;
            this.More.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.More.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.More.Text = "...";
            this.More.UseColumnTextForButtonValue = true;
            this.More.Width = 52;
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(760, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(40, 37);
            this.btn_search.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_search, "Filter (Enter)");
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Report.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Report.BackgroundImage")));
            this.btn_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Report.Location = new System.Drawing.Point(17, 594);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(47, 58);
            this.btn_Report.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_Report, "Izvještaj");
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_removeCustomList
            // 
            this.btn_removeCustomList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_removeCustomList.BackgroundImage")));
            this.btn_removeCustomList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_removeCustomList.Location = new System.Drawing.Point(6, 14);
            this.btn_removeCustomList.Name = "btn_removeCustomList";
            this.btn_removeCustomList.Size = new System.Drawing.Size(47, 58);
            this.btn_removeCustomList.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_removeCustomList, "Ukloni custom listu");
            this.btn_removeCustomList.UseVisualStyleBackColor = true;
            this.btn_removeCustomList.Click += new System.EventHandler(this.btn_removeCustomList_Click);
            // 
            // btn_reviewCustomList
            // 
            this.btn_reviewCustomList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reviewCustomList.BackgroundImage")));
            this.btn_reviewCustomList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reviewCustomList.Location = new System.Drawing.Point(169, 14);
            this.btn_reviewCustomList.Name = "btn_reviewCustomList";
            this.btn_reviewCustomList.Size = new System.Drawing.Size(47, 58);
            this.btn_reviewCustomList.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_reviewCustomList, "Pregledaj custom listu");
            this.btn_reviewCustomList.UseVisualStyleBackColor = true;
            this.btn_reviewCustomList.Click += new System.EventHandler(this.btn_reviewCustomList_Click);
            // 
            // btn_addToCustomList
            // 
            this.btn_addToCustomList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addToCustomList.BackgroundImage")));
            this.btn_addToCustomList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addToCustomList.Location = new System.Drawing.Point(87, 21);
            this.btn_addToCustomList.Name = "btn_addToCustomList";
            this.btn_addToCustomList.Size = new System.Drawing.Size(40, 51);
            this.btn_addToCustomList.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_addToCustomList, "Dodaj zapise na custom listu");
            this.btn_addToCustomList.UseVisualStyleBackColor = true;
            this.btn_addToCustomList.Click += new System.EventHandler(this.btn_addToCustomList_Click);
            // 
            // btn_newCustomList
            // 
            this.btn_newCustomList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_newCustomList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_newCustomList.BackgroundImage")));
            this.btn_newCustomList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_newCustomList.Location = new System.Drawing.Point(81, 594);
            this.btn_newCustomList.Name = "btn_newCustomList";
            this.btn_newCustomList.Size = new System.Drawing.Size(47, 58);
            this.btn_newCustomList.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_newCustomList, "Kreiraj custom listu");
            this.btn_newCustomList.UseVisualStyleBackColor = true;
            this.btn_newCustomList.Click += new System.EventHandler(this.btn_newCustomList_Click);
            // 
            // lbl_items
            // 
            this.lbl_items.Font = new System.Drawing.Font("Stencil", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_items.Location = new System.Drawing.Point(118, 51);
            this.lbl_items.Name = "lbl_items";
            this.lbl_items.Size = new System.Drawing.Size(61, 18);
            this.lbl_items.TabIndex = 1;
            this.lbl_items.Text = "0";
            this.lbl_items.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lbl_items, "Items");
            // 
            // gB_customList
            // 
            this.gB_customList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gB_customList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gB_customList.Controls.Add(this.btn_removeCustomList);
            this.gB_customList.Controls.Add(this.btn_reviewCustomList);
            this.gB_customList.Controls.Add(this.btn_addToCustomList);
            this.gB_customList.Controls.Add(this.lbl_items);
            this.gB_customList.Location = new System.Drawing.Point(75, 580);
            this.gB_customList.Name = "gB_customList";
            this.gB_customList.Size = new System.Drawing.Size(223, 77);
            this.gB_customList.TabIndex = 8;
            this.gB_customList.TabStop = false;
            this.toolTip1.SetToolTip(this.gB_customList, "Alati custom liste");
            this.gB_customList.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(65, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(199, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(355, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(466, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Do:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(611, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kurs:";
            // 
            // frm_Uplate
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_ClearFilter;
            this.ClientSize = new System.Drawing.Size(863, 674);
            this.Controls.Add(this.gB_customList);
            this.Controls.Add(this.btn_newCustomList);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_ClearFilter);
            this.Controls.Add(this.cB_Kursevi);
            this.Controls.Add(this.dTP_To);
            this.Controls.Add(this.dTP_From);
            this.Controls.Add(this.txt_lName);
            this.Controls.Add(this.txt_fName);
            this.Name = "frm_Uplate";
            this.ShowIcon = false;
            this.Text = "Uplate";
            this.Load += new System.EventHandler(this.frm_Uplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gB_customList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_fName;
        private System.Windows.Forms.DateTimePicker dTP_From;
        private System.Windows.Forms.ComboBox cB_Kursevi;
        private System.Windows.Forms.TextBox txt_lName;
        private System.Windows.Forms.DateTimePicker dTP_To;
        private System.Windows.Forms.Button btn_ClearFilter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gB_customList;
        private System.Windows.Forms.Button btn_removeCustomList;
        private System.Windows.Forms.Button btn_reviewCustomList;
        private System.Windows.Forms.Button btn_addToCustomList;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivModula;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckGiven;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PaymentState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewButtonColumn More;
        private System.Windows.Forms.Button btn_newCustomList;
        private System.Windows.Forms.Label lbl_items;
    }
}