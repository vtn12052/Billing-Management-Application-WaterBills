namespace Water_Bills
{
    partial class UC2_BillsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC2_BillsManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.name = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.number = new System.Windows.Forms.TextBox();
            this.lastmonth = new System.Windows.Forms.TextBox();
            this.thismonth = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.list1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waterbillDataSet = new Water_Bills.waterbillDataSet();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.cusname_1 = new System.Windows.Forms.Label();
            this.num_1 = new System.Windows.Forms.Label();
            this.typecus_1 = new System.Windows.Forms.Label();
            this.dateset_1 = new System.Windows.Forms.Label();
            this.lmread_1 = new System.Windows.Forms.Label();
            this.tmread_1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.searchbt = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.searchico1 = new System.Windows.Forms.PictureBox();
            this.list1TableAdapter = new Water_Bills.waterbillDataSetTableAdapters.list1TableAdapter();
            this.addico = new System.Windows.Forms.PictureBox();
            this.clearico = new System.Windows.Forms.PictureBox();
            this.printico = new System.Windows.Forms.PictureBox();
            this.searchhidetext1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterbillDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printico)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(195, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 27);
            this.name.TabIndex = 0;
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
            this.type.TabIndex = 1;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // number
            // 
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(195, 83);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(60, 27);
            this.number.TabIndex = 2;
            // 
            // lastmonth
            // 
            this.lastmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastmonth.Location = new System.Drawing.Point(815, 38);
            this.lastmonth.Name = "lastmonth";
            this.lastmonth.Size = new System.Drawing.Size(165, 27);
            this.lastmonth.TabIndex = 3;
            // 
            // thismonth
            // 
            this.thismonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thismonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thismonth.Location = new System.Drawing.Point(815, 86);
            this.thismonth.Name = "thismonth";
            this.thismonth.Size = new System.Drawing.Size(165, 27);
            this.thismonth.TabIndex = 4;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(1060, 30);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(89, 40);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(76)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.statementDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.list1BindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(32, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 400);
            this.dataGridView1.TabIndex = 6;
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
            // datepick
            // 
            this.datepick.CalendarFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepick.CustomFormat = "dd/MM/yyyy";
            this.datepick.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepick.Location = new System.Drawing.Point(496, 83);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(113, 28);
            this.datepick.TabIndex = 7;
            // 
            // cusname_1
            // 
            this.cusname_1.AutoSize = true;
            this.cusname_1.BackColor = System.Drawing.Color.Transparent;
            this.cusname_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusname_1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusname_1.Location = new System.Drawing.Point(28, 39);
            this.cusname_1.Name = "cusname_1";
            this.cusname_1.Size = new System.Drawing.Size(128, 21);
            this.cusname_1.TabIndex = 8;
            this.cusname_1.Text = "Customer Name:";
            // 
            // num_1
            // 
            this.num_1.AutoSize = true;
            this.num_1.BackColor = System.Drawing.Color.Transparent;
            this.num_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num_1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_1.Location = new System.Drawing.Point(28, 86);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(143, 21);
            this.num_1.TabIndex = 9;
            this.num_1.Text = "Number Of People:";
            // 
            // typecus_1
            // 
            this.typecus_1.AutoSize = true;
            this.typecus_1.BackColor = System.Drawing.Color.Transparent;
            this.typecus_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typecus_1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecus_1.Location = new System.Drawing.Point(371, 39);
            this.typecus_1.Name = "typecus_1";
            this.typecus_1.Size = new System.Drawing.Size(47, 21);
            this.typecus_1.TabIndex = 10;
            this.typecus_1.Text = "Type:";
            // 
            // dateset_1
            // 
            this.dateset_1.AutoSize = true;
            this.dateset_1.BackColor = System.Drawing.Color.Transparent;
            this.dateset_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateset_1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateset_1.Location = new System.Drawing.Point(371, 89);
            this.dateset_1.Name = "dateset_1";
            this.dateset_1.Size = new System.Drawing.Size(78, 21);
            this.dateset_1.TabIndex = 11;
            this.dateset_1.Text = "Due Date:";
            // 
            // lmread_1
            // 
            this.lmread_1.AutoSize = true;
            this.lmread_1.BackColor = System.Drawing.Color.Transparent;
            this.lmread_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lmread_1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmread_1.Location = new System.Drawing.Point(624, 41);
            this.lmread_1.Name = "lmread_1";
            this.lmread_1.Size = new System.Drawing.Size(165, 21);
            this.lmread_1.TabIndex = 12;
            this.lmread_1.Text = "Last Month Water m³:";
            // 
            // tmread_1
            // 
            this.tmread_1.AutoSize = true;
            this.tmread_1.BackColor = System.Drawing.Color.Transparent;
            this.tmread_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tmread_1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmread_1.Location = new System.Drawing.Point(624, 89);
            this.tmread_1.Name = "tmread_1";
            this.tmread_1.Size = new System.Drawing.Size(165, 21);
            this.tmread_1.TabIndex = 13;
            this.tmread_1.Text = "This Month Water m³:";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(1060, 79);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(89, 40);
            this.clear.TabIndex = 14;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // search
            // 
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(67, 155);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(298, 28);
            this.search.TabIndex = 15;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.MouseEnter += new System.EventHandler(this.search_MouseEnter);
            this.search.MouseLeave += new System.EventHandler(this.search_MouseLeave);
            // 
            // searchbt
            // 
            this.searchbt.Location = new System.Drawing.Point(371, 155);
            this.searchbt.Name = "searchbt";
            this.searchbt.Size = new System.Drawing.Size(75, 28);
            this.searchbt.TabIndex = 16;
            this.searchbt.Text = "Search";
            this.searchbt.UseVisualStyleBackColor = true;
            this.searchbt.Click += new System.EventHandler(this.searchbt_Click);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(1060, 128);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(89, 40);
            this.print.TabIndex = 17;
            this.print.Text = "Print ";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // searchico1
            // 
            this.searchico1.Image = ((System.Drawing.Image)(resources.GetObject("searchico1.Image")));
            this.searchico1.Location = new System.Drawing.Point(31, 155);
            this.searchico1.Name = "searchico1";
            this.searchico1.Size = new System.Drawing.Size(34, 28);
            this.searchico1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchico1.TabIndex = 18;
            this.searchico1.TabStop = false;
            // 
            // list1TableAdapter
            // 
            this.list1TableAdapter.ClearBeforeFill = true;
            // 
            // addico
            // 
            this.addico.Image = ((System.Drawing.Image)(resources.GetObject("addico.Image")));
            this.addico.Location = new System.Drawing.Point(1027, 37);
            this.addico.Name = "addico";
            this.addico.Size = new System.Drawing.Size(27, 22);
            this.addico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addico.TabIndex = 19;
            this.addico.TabStop = false;
            // 
            // clearico
            // 
            this.clearico.Image = ((System.Drawing.Image)(resources.GetObject("clearico.Image")));
            this.clearico.Location = new System.Drawing.Point(1027, 87);
            this.clearico.Name = "clearico";
            this.clearico.Size = new System.Drawing.Size(27, 22);
            this.clearico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clearico.TabIndex = 20;
            this.clearico.TabStop = false;
            // 
            // printico
            // 
            this.printico.Image = ((System.Drawing.Image)(resources.GetObject("printico.Image")));
            this.printico.Location = new System.Drawing.Point(1027, 137);
            this.printico.Name = "printico";
            this.printico.Size = new System.Drawing.Size(27, 22);
            this.printico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printico.TabIndex = 21;
            this.printico.TabStop = false;
            // 
            // searchhidetext1
            // 
            this.searchhidetext1.AutoSize = true;
            this.searchhidetext1.BackColor = System.Drawing.Color.White;
            this.searchhidetext1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchhidetext1.Location = new System.Drawing.Point(71, 160);
            this.searchhidetext1.Name = "searchhidetext1";
            this.searchhidetext1.Size = new System.Drawing.Size(101, 16);
            this.searchhidetext1.TabIndex = 40;
            this.searchhidetext1.Text = "Enter username";
            this.searchhidetext1.MouseEnter += new System.EventHandler(this.search_MouseEnter);
            this.searchhidetext1.MouseLeave += new System.EventHandler(this.search_MouseLeave);
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Customer Name";
            this.dataGridViewTextBoxColumn19.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Customer Type";
            this.dataGridViewTextBoxColumn20.HeaderText = "Customer Type";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Number Of People";
            this.dataGridViewTextBoxColumn21.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 50;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Consumption";
            this.dataGridViewTextBoxColumn22.HeaderText = "Consumption";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Last Month Reading";
            this.dataGridViewTextBoxColumn23.HeaderText = "Last Month m³";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "This Month Reading";
            this.dataGridViewTextBoxColumn24.HeaderText = "This Month m³";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Total Bill";
            this.dataGridViewTextBoxColumn25.HeaderText = "Total Bill";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 125;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Include (VAT)";
            this.dataGridViewTextBoxColumn26.HeaderText = "Include (VAT)";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 125;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Due Date";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn27.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn27.HeaderText = "Due Date";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 125;
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
            // UC2_BillsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchhidetext1);
            this.Controls.Add(this.printico);
            this.Controls.Add(this.clearico);
            this.Controls.Add(this.addico);
            this.Controls.Add(this.searchico1);
            this.Controls.Add(this.print);
            this.Controls.Add(this.searchbt);
            this.Controls.Add(this.search);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.datepick);
            this.Controls.Add(this.type);
            this.Controls.Add(this.thismonth);
            this.Controls.Add(this.lastmonth);
            this.Controls.Add(this.name);
            this.Controls.Add(this.number);
            this.Controls.Add(this.tmread_1);
            this.Controls.Add(this.lmread_1);
            this.Controls.Add(this.dateset_1);
            this.Controls.Add(this.typecus_1);
            this.Controls.Add(this.num_1);
            this.Controls.Add(this.cusname_1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Name = "UC2_BillsManagement";
            this.Size = new System.Drawing.Size(1193, 639);
            this.Load += new System.EventHandler(this.bill_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterbillDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox lastmonth;
        private System.Windows.Forms.TextBox thismonth;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DateTimePicker datepick;
        private System.Windows.Forms.Label cusname_1;
        private System.Windows.Forms.Label num_1;
        private System.Windows.Forms.Label typecus_1;
        private System.Windows.Forms.Label dateset_1;
        private System.Windows.Forms.Label lmread_1;
        private System.Windows.Forms.Label tmread_1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastMonthReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thisMonthReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn includeVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button searchbt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.PictureBox searchico1;
        private System.Windows.Forms.BindingSource list1BindingSource;
        private waterbillDataSet waterbillDataSet;
        private waterbillDataSetTableAdapters.list1TableAdapter list1TableAdapter;
        private System.Windows.Forms.PictureBox addico;
        private System.Windows.Forms.PictureBox clearico;
        private System.Windows.Forms.PictureBox printico;
        private System.Windows.Forms.Label searchhidetext1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn statementDataGridViewTextBoxColumn;
    }
}
