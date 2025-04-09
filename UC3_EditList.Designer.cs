namespace Water_Bills
{
    partial class UC3_EditList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC3_EditList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.list1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waterbillDataSet = new Water_Bills.waterbillDataSet();
            this.remove = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.removeall = new System.Windows.Forms.Button();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.type = new System.Windows.Forms.ComboBox();
            this.thismonth = new System.Windows.Forms.TextBox();
            this.lastmonth = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.tmread_2 = new System.Windows.Forms.Label();
            this.lmread_2 = new System.Windows.Forms.Label();
            this.dateset_2 = new System.Windows.Forms.Label();
            this.typecus_2 = new System.Windows.Forms.Label();
            this.num_2 = new System.Windows.Forms.Label();
            this.cusname_2 = new System.Windows.Forms.Label();
            this.searchbt1 = new System.Windows.Forms.Button();
            this.search1 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.searchico2 = new System.Windows.Forms.PictureBox();
            this.statement = new System.Windows.Forms.ComboBox();
            this.statem = new System.Windows.Forms.Label();
            this.list1TableAdapter = new Water_Bills.waterbillDataSetTableAdapters.list1TableAdapter();
            this.editico = new System.Windows.Forms.PictureBox();
            this.removeico = new System.Windows.Forms.PictureBox();
            this.removeallico = new System.Windows.Forms.PictureBox();
            this.searchhidetext2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterbillDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchico2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeallico)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeight = 60;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.statementDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.list1BindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView2.Location = new System.Drawing.Point(32, 213);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1118, 400);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // list1BindingSource
            // 
            this.list1BindingSource.DataMember = "list1";
            this.list1BindingSource.DataSource = this.waterbillDataSet;
            // 
            // waterbillDataSet
            // 
            this.waterbillDataSet.DataSetName = "waterbillDataSet";
            this.waterbillDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(1059, 80);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(91, 40);
            this.remove.TabIndex = 16;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(1059, 30);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(91, 40);
            this.edit.TabIndex = 15;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // removeall
            // 
            this.removeall.BackColor = System.Drawing.Color.Red;
            this.removeall.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.removeall.FlatAppearance.BorderSize = 0;
            this.removeall.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeall.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeall.ForeColor = System.Drawing.Color.Black;
            this.removeall.Location = new System.Drawing.Point(1028, 131);
            this.removeall.Name = "removeall";
            this.removeall.Size = new System.Drawing.Size(121, 40);
            this.removeall.TabIndex = 17;
            this.removeall.Text = "Remove All";
            this.removeall.UseVisualStyleBackColor = false;
            this.removeall.Click += new System.EventHandler(this.removeall_Click);
            // 
            // datepick
            // 
            this.datepick.CalendarFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepick.CustomFormat = "dd/MM/yyyy";
            this.datepick.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepick.Location = new System.Drawing.Point(496, 83);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(113, 28);
            this.datepick.TabIndex = 23;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Household",
            "Adminstrative Agency",
            "Public Services",
            "Production Units",
            "Business Services"});
            this.type.Location = new System.Drawing.Point(444, 38);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(165, 28);
            this.type.TabIndex = 19;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // thismonth
            // 
            this.thismonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thismonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thismonth.Location = new System.Drawing.Point(815, 85);
            this.thismonth.Name = "thismonth";
            this.thismonth.Size = new System.Drawing.Size(165, 27);
            this.thismonth.TabIndex = 22;
            // 
            // lastmonth
            // 
            this.lastmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastmonth.Location = new System.Drawing.Point(815, 38);
            this.lastmonth.Name = "lastmonth";
            this.lastmonth.Size = new System.Drawing.Size(165, 27);
            this.lastmonth.TabIndex = 21;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(195, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 27);
            this.name.TabIndex = 18;
            // 
            // number
            // 
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(195, 83);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(60, 27);
            this.number.TabIndex = 20;
            // 
            // tmread_2
            // 
            this.tmread_2.AutoSize = true;
            this.tmread_2.BackColor = System.Drawing.Color.Transparent;
            this.tmread_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tmread_2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmread_2.Location = new System.Drawing.Point(624, 88);
            this.tmread_2.Name = "tmread_2";
            this.tmread_2.Size = new System.Drawing.Size(165, 21);
            this.tmread_2.TabIndex = 29;
            this.tmread_2.Text = "This Month Water m³:";
            // 
            // lmread_2
            // 
            this.lmread_2.AutoSize = true;
            this.lmread_2.BackColor = System.Drawing.Color.Transparent;
            this.lmread_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lmread_2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmread_2.Location = new System.Drawing.Point(624, 41);
            this.lmread_2.Name = "lmread_2";
            this.lmread_2.Size = new System.Drawing.Size(165, 21);
            this.lmread_2.TabIndex = 28;
            this.lmread_2.Text = "Last Month Water m³:";
            // 
            // dateset_2
            // 
            this.dateset_2.AutoSize = true;
            this.dateset_2.BackColor = System.Drawing.Color.Transparent;
            this.dateset_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateset_2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateset_2.Location = new System.Drawing.Point(371, 89);
            this.dateset_2.Name = "dateset_2";
            this.dateset_2.Size = new System.Drawing.Size(78, 21);
            this.dateset_2.TabIndex = 27;
            this.dateset_2.Text = "Due Date:";
            // 
            // typecus_2
            // 
            this.typecus_2.AutoSize = true;
            this.typecus_2.BackColor = System.Drawing.Color.Transparent;
            this.typecus_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typecus_2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecus_2.Location = new System.Drawing.Point(371, 39);
            this.typecus_2.Name = "typecus_2";
            this.typecus_2.Size = new System.Drawing.Size(47, 21);
            this.typecus_2.TabIndex = 26;
            this.typecus_2.Text = "Type:";
            // 
            // num_2
            // 
            this.num_2.AutoSize = true;
            this.num_2.BackColor = System.Drawing.Color.Transparent;
            this.num_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_2.Location = new System.Drawing.Point(28, 86);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(143, 21);
            this.num_2.TabIndex = 25;
            this.num_2.Text = "Number Of People:";
            // 
            // cusname_2
            // 
            this.cusname_2.AutoSize = true;
            this.cusname_2.BackColor = System.Drawing.Color.Transparent;
            this.cusname_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusname_2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusname_2.Location = new System.Drawing.Point(28, 39);
            this.cusname_2.Name = "cusname_2";
            this.cusname_2.Size = new System.Drawing.Size(128, 21);
            this.cusname_2.TabIndex = 24;
            this.cusname_2.Text = "Customer Name:";
            // 
            // searchbt1
            // 
            this.searchbt1.Location = new System.Drawing.Point(371, 155);
            this.searchbt1.Name = "searchbt1";
            this.searchbt1.Size = new System.Drawing.Size(75, 28);
            this.searchbt1.TabIndex = 31;
            this.searchbt1.Text = "Search";
            this.searchbt1.UseVisualStyleBackColor = true;
            this.searchbt1.Click += new System.EventHandler(this.searchbt1_Click);
            // 
            // search1
            // 
            this.search1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search1.Location = new System.Drawing.Point(67, 155);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(298, 28);
            this.search1.TabIndex = 30;
            this.search1.TextChanged += new System.EventHandler(this.search1_TextChanged);
            this.search1.MouseEnter += new System.EventHandler(this.search1_MouseEnter);
            this.search1.MouseLeave += new System.EventHandler(this.search1_MouseLeave);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(1060, 30);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(89, 40);
            this.save.TabIndex = 32;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // searchico2
            // 
            this.searchico2.Image = ((System.Drawing.Image)(resources.GetObject("searchico2.Image")));
            this.searchico2.Location = new System.Drawing.Point(31, 155);
            this.searchico2.Name = "searchico2";
            this.searchico2.Size = new System.Drawing.Size(34, 28);
            this.searchico2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchico2.TabIndex = 33;
            this.searchico2.TabStop = false;
            // 
            // statement
            // 
            this.statement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statement.FormattingEnabled = true;
            this.statement.Items.AddRange(new object[] {
            "Paid",
            "Pending",
            "Overdue",
            "Cancelled"});
            this.statement.Location = new System.Drawing.Point(815, 132);
            this.statement.Name = "statement";
            this.statement.Size = new System.Drawing.Size(121, 28);
            this.statement.TabIndex = 34;
            // 
            // statem
            // 
            this.statem.AutoSize = true;
            this.statem.BackColor = System.Drawing.Color.Transparent;
            this.statem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statem.Location = new System.Drawing.Point(701, 135);
            this.statem.Name = "statem";
            this.statem.Size = new System.Drawing.Size(88, 21);
            this.statem.TabIndex = 35;
            this.statem.Text = "Statement:";
            // 
            // list1TableAdapter
            // 
            this.list1TableAdapter.ClearBeforeFill = true;
            // 
            // editico
            // 
            this.editico.Image = ((System.Drawing.Image)(resources.GetObject("editico.Image")));
            this.editico.Location = new System.Drawing.Point(1027, 37);
            this.editico.Name = "editico";
            this.editico.Size = new System.Drawing.Size(27, 22);
            this.editico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editico.TabIndex = 36;
            this.editico.TabStop = false;
            // 
            // removeico
            // 
            this.removeico.Image = ((System.Drawing.Image)(resources.GetObject("removeico.Image")));
            this.removeico.Location = new System.Drawing.Point(1027, 87);
            this.removeico.Name = "removeico";
            this.removeico.Size = new System.Drawing.Size(27, 22);
            this.removeico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeico.TabIndex = 37;
            this.removeico.TabStop = false;
            // 
            // removeallico
            // 
            this.removeallico.Image = ((System.Drawing.Image)(resources.GetObject("removeallico.Image")));
            this.removeallico.Location = new System.Drawing.Point(995, 138);
            this.removeallico.Name = "removeallico";
            this.removeallico.Size = new System.Drawing.Size(27, 22);
            this.removeallico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeallico.TabIndex = 38;
            this.removeallico.TabStop = false;
            // 
            // searchhidetext2
            // 
            this.searchhidetext2.AutoSize = true;
            this.searchhidetext2.BackColor = System.Drawing.Color.White;
            this.searchhidetext2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchhidetext2.Location = new System.Drawing.Point(71, 160);
            this.searchhidetext2.Name = "searchhidetext2";
            this.searchhidetext2.Size = new System.Drawing.Size(101, 16);
            this.searchhidetext2.TabIndex = 39;
            this.searchhidetext2.Text = "Enter username";
            this.searchhidetext2.MouseEnter += new System.EventHandler(this.search1_MouseEnter);
            this.searchhidetext2.MouseLeave += new System.EventHandler(this.search1_MouseLeave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Type";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Number Of People";
            this.dataGridViewTextBoxColumn3.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Consumption";
            this.dataGridViewTextBoxColumn4.HeaderText = "Consumption";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Last Month Reading";
            this.dataGridViewTextBoxColumn5.HeaderText = "Last Month m³";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "This Month Reading";
            this.dataGridViewTextBoxColumn6.HeaderText = "This Month m³";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Total Bill";
            this.dataGridViewTextBoxColumn7.HeaderText = "Total Bill";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Include (VAT)";
            this.dataGridViewTextBoxColumn8.HeaderText = "Include (VAT)";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Due Date";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn9.HeaderText = "Due Date";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // statementDataGridViewTextBoxColumn
            // 
            this.statementDataGridViewTextBoxColumn.DataPropertyName = "Statement";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statementDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.statementDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statementDataGridViewTextBoxColumn.Name = "statementDataGridViewTextBoxColumn";
            this.statementDataGridViewTextBoxColumn.ReadOnly = true;
            this.statementDataGridViewTextBoxColumn.Width = 125;
            // 
            // UC3_EditList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchhidetext2);
            this.Controls.Add(this.removeallico);
            this.Controls.Add(this.removeico);
            this.Controls.Add(this.editico);
            this.Controls.Add(this.statem);
            this.Controls.Add(this.statement);
            this.Controls.Add(this.searchico2);
            this.Controls.Add(this.searchbt1);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.datepick);
            this.Controls.Add(this.type);
            this.Controls.Add(this.thismonth);
            this.Controls.Add(this.lastmonth);
            this.Controls.Add(this.name);
            this.Controls.Add(this.number);
            this.Controls.Add(this.tmread_2);
            this.Controls.Add(this.lmread_2);
            this.Controls.Add(this.dateset_2);
            this.Controls.Add(this.typecus_2);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.cusname_2);
            this.Controls.Add(this.removeall);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.save);
            this.Name = "UC3_EditList";
            this.Size = new System.Drawing.Size(1193, 639);
            this.Load += new System.EventHandler(this.editlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterbillDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchico2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeallico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button removeall;
        private System.Windows.Forms.DateTimePicker datepick;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox thismonth;
        private System.Windows.Forms.TextBox lastmonth;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label tmread_2;
        private System.Windows.Forms.Label lmread_2;
        private System.Windows.Forms.Label dateset_2;
        private System.Windows.Forms.Label typecus_2;
        private System.Windows.Forms.Label num_2;
        private System.Windows.Forms.Label cusname_2;
        private System.Windows.Forms.Button searchbt1;
        private System.Windows.Forms.TextBox search1;
        private System.Windows.Forms.Button save;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastMonthReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thisMonthReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn includeVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox searchico2;
        private System.Windows.Forms.ComboBox statement;
        private System.Windows.Forms.Label statem;
        private System.Windows.Forms.BindingSource list1BindingSource;
        private waterbillDataSet waterbillDataSet;
        private waterbillDataSetTableAdapters.list1TableAdapter list1TableAdapter;
        private System.Windows.Forms.PictureBox editico;
        private System.Windows.Forms.PictureBox removeico;
        private System.Windows.Forms.PictureBox removeallico;
        private System.Windows.Forms.Label searchhidetext2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn statementDataGridViewTextBoxColumn;
    }
}
