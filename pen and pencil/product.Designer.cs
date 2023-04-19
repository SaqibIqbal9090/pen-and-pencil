namespace pen_and_pencil
{
    partial class product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            this.mainprodpanl = new System.Windows.Forms.Panel();
            this.prodDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.searchcat = new System.Windows.Forms.ComboBox();
            this.manageprod = new System.Windows.Forms.Label();
            this.btneditprod = new Guna.UI2.WinForms.Guna2Button();
            this.btndeleteprod = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddprod = new Guna.UI2.WinForms.Guna2Button();
            this.combocat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prodprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.prodid = new Guna.UI2.WinForms.Guna2TextBox();
            this.prodname = new Guna.UI2.WinForms.Guna2TextBox();
            this.prodqty = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.btncat = new Guna.UI2.WinForms.Guna2Button();
            this.btnselling = new Guna.UI2.WinForms.Guna2Button();
            this.sellerbtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnminimize = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainprodpanl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainprodpanl
            // 
            this.mainprodpanl.BackColor = System.Drawing.Color.DarkOrange;
            this.mainprodpanl.Controls.Add(this.prodDGV);
            this.mainprodpanl.Controls.Add(this.guna2Button1);
            this.mainprodpanl.Controls.Add(this.searchcat);
            this.mainprodpanl.Controls.Add(this.manageprod);
            this.mainprodpanl.Controls.Add(this.btneditprod);
            this.mainprodpanl.Controls.Add(this.btndeleteprod);
            this.mainprodpanl.Controls.Add(this.btnaddprod);
            this.mainprodpanl.Controls.Add(this.combocat);
            this.mainprodpanl.Controls.Add(this.label4);
            this.mainprodpanl.Controls.Add(this.label3);
            this.mainprodpanl.Controls.Add(this.label5);
            this.mainprodpanl.Controls.Add(this.label1);
            this.mainprodpanl.Controls.Add(this.label2);
            this.mainprodpanl.Controls.Add(this.prodprice);
            this.mainprodpanl.Controls.Add(this.prodid);
            this.mainprodpanl.Controls.Add(this.prodname);
            this.mainprodpanl.Controls.Add(this.prodqty);
            this.mainprodpanl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainprodpanl.ForeColor = System.Drawing.Color.DarkOrange;
            this.mainprodpanl.Location = new System.Drawing.Point(179, 47);
            this.mainprodpanl.Name = "mainprodpanl";
            this.mainprodpanl.Size = new System.Drawing.Size(1154, 761);
            this.mainprodpanl.TabIndex = 0;
            // 
            // prodDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.prodDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prodDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prodDGV.ColumnHeadersHeight = 28;
            this.prodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.prodDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV.Location = new System.Drawing.Point(510, 158);
            this.prodDGV.Name = "prodDGV";
            this.prodDGV.RowHeadersVisible = false;
            this.prodDGV.RowHeadersWidth = 51;
            this.prodDGV.RowTemplate.Height = 24;
            this.prodDGV.Size = new System.Drawing.Size(625, 587);
            this.prodDGV.TabIndex = 12;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prodDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prodDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.prodDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.prodDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.prodDGV.ThemeStyle.ReadOnly = false;
            this.prodDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkOrange;
            this.prodDGV.ThemeStyle.RowsStyle.Height = 24;
            this.prodDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDGV_CellContentClick);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Orange;
            this.guna2Button1.Location = new System.Drawing.Point(891, 93);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(145, 36);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Refresh";
            // 
            // searchcat
            // 
            this.searchcat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchcat.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchcat.FormattingEnabled = true;
            this.searchcat.Location = new System.Drawing.Point(589, 93);
            this.searchcat.Name = "searchcat";
            this.searchcat.Size = new System.Drawing.Size(283, 36);
            this.searchcat.TabIndex = 10;
            this.searchcat.Text = "Select Catagory";
            this.searchcat.SelectedIndexChanged += new System.EventHandler(this.searchcat_SelectedIndexChanged);
            // 
            // manageprod
            // 
            this.manageprod.AutoSize = true;
            this.manageprod.BackColor = System.Drawing.Color.DarkOrange;
            this.manageprod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageprod.ForeColor = System.Drawing.Color.White;
            this.manageprod.Location = new System.Drawing.Point(373, 10);
            this.manageprod.Name = "manageprod";
            this.manageprod.Size = new System.Drawing.Size(292, 45);
            this.manageprod.TabIndex = 9;
            this.manageprod.Text = "Manage Products";
            // 
            // btneditprod
            // 
            this.btneditprod.BackColor = System.Drawing.Color.DarkOrange;
            this.btneditprod.BorderColor = System.Drawing.Color.White;
            this.btneditprod.BorderRadius = 8;
            this.btneditprod.BorderThickness = 2;
            this.btneditprod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneditprod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneditprod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneditprod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneditprod.FillColor = System.Drawing.Color.White;
            this.btneditprod.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditprod.ForeColor = System.Drawing.Color.Orange;
            this.btneditprod.Location = new System.Drawing.Point(179, 463);
            this.btneditprod.Name = "btneditprod";
            this.btneditprod.Size = new System.Drawing.Size(125, 50);
            this.btneditprod.TabIndex = 7;
            this.btneditprod.Text = "EDIT";
            this.btneditprod.Click += new System.EventHandler(this.btneditprod_Click);
            // 
            // btndeleteprod
            // 
            this.btndeleteprod.BackColor = System.Drawing.Color.DarkOrange;
            this.btndeleteprod.BorderColor = System.Drawing.Color.White;
            this.btndeleteprod.BorderRadius = 8;
            this.btndeleteprod.BorderThickness = 2;
            this.btndeleteprod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteprod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteprod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndeleteprod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndeleteprod.FillColor = System.Drawing.Color.White;
            this.btndeleteprod.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteprod.ForeColor = System.Drawing.Color.Orange;
            this.btndeleteprod.Location = new System.Drawing.Point(325, 463);
            this.btndeleteprod.Name = "btndeleteprod";
            this.btndeleteprod.Size = new System.Drawing.Size(125, 50);
            this.btndeleteprod.TabIndex = 7;
            this.btndeleteprod.Text = "DELETE";
            this.btndeleteprod.Click += new System.EventHandler(this.btndeleteprod_Click);
            // 
            // btnaddprod
            // 
            this.btnaddprod.BackColor = System.Drawing.Color.DarkOrange;
            this.btnaddprod.BorderColor = System.Drawing.Color.White;
            this.btnaddprod.BorderRadius = 8;
            this.btnaddprod.BorderThickness = 2;
            this.btnaddprod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddprod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddprod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddprod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddprod.FillColor = System.Drawing.Color.White;
            this.btnaddprod.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddprod.ForeColor = System.Drawing.Color.Orange;
            this.btnaddprod.Location = new System.Drawing.Point(30, 463);
            this.btnaddprod.Name = "btnaddprod";
            this.btnaddprod.Size = new System.Drawing.Size(125, 50);
            this.btnaddprod.TabIndex = 7;
            this.btnaddprod.Text = "ADD";
            this.btnaddprod.Click += new System.EventHandler(this.btnaddprod_Click);
            // 
            // combocat
            // 
            this.combocat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocat.ForeColor = System.Drawing.Color.DarkOrange;
            this.combocat.FormattingEnabled = true;
            this.combocat.Location = new System.Drawing.Point(169, 394);
            this.combocat.Name = "combocat";
            this.combocat.Size = new System.Drawing.Size(283, 36);
            this.combocat.TabIndex = 6;
            this.combocat.Text = "Select Catagory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Catagory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // prodprice
            // 
            this.prodprice.BackColor = System.Drawing.Color.White;
            this.prodprice.BorderColor = System.Drawing.Color.DarkOrange;
            this.prodprice.BorderThickness = 2;
            this.prodprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodprice.DefaultText = "";
            this.prodprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodprice.ForeColor = System.Drawing.Color.Black;
            this.prodprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodprice.Location = new System.Drawing.Point(169, 336);
            this.prodprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prodprice.Name = "prodprice";
            this.prodprice.PasswordChar = '\0';
            this.prodprice.PlaceholderText = "";
            this.prodprice.SelectedText = "";
            this.prodprice.Size = new System.Drawing.Size(281, 42);
            this.prodprice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.prodprice.TabIndex = 3;
            // 
            // prodid
            // 
            this.prodid.BackColor = System.Drawing.Color.White;
            this.prodid.BorderColor = System.Drawing.Color.DarkOrange;
            this.prodid.BorderThickness = 2;
            this.prodid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodid.DefaultText = "";
            this.prodid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodid.ForeColor = System.Drawing.Color.Black;
            this.prodid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodid.Location = new System.Drawing.Point(169, 158);
            this.prodid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prodid.Name = "prodid";
            this.prodid.PasswordChar = '\0';
            this.prodid.PlaceholderText = "";
            this.prodid.SelectedText = "";
            this.prodid.Size = new System.Drawing.Size(281, 42);
            this.prodid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.prodid.TabIndex = 3;
            // 
            // prodname
            // 
            this.prodname.BackColor = System.Drawing.Color.White;
            this.prodname.BorderColor = System.Drawing.Color.DarkOrange;
            this.prodname.BorderThickness = 2;
            this.prodname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodname.DefaultText = "";
            this.prodname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodname.ForeColor = System.Drawing.Color.Black;
            this.prodname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodname.Location = new System.Drawing.Point(169, 215);
            this.prodname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prodname.Name = "prodname";
            this.prodname.PasswordChar = '\0';
            this.prodname.PlaceholderText = "";
            this.prodname.SelectedText = "";
            this.prodname.Size = new System.Drawing.Size(281, 42);
            this.prodname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.prodname.TabIndex = 3;
            // 
            // prodqty
            // 
            this.prodqty.BackColor = System.Drawing.Color.White;
            this.prodqty.BorderColor = System.Drawing.Color.DarkOrange;
            this.prodqty.BorderThickness = 2;
            this.prodqty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodqty.DefaultText = "";
            this.prodqty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodqty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodqty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodqty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodqty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodqty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodqty.ForeColor = System.Drawing.Color.Black;
            this.prodqty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodqty.Location = new System.Drawing.Point(169, 275);
            this.prodqty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prodqty.Name = "prodqty";
            this.prodqty.PasswordChar = '\0';
            this.prodqty.PlaceholderText = "";
            this.prodqty.SelectedText = "";
            this.prodqty.Size = new System.Drawing.Size(281, 42);
            this.prodqty.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.prodqty.TabIndex = 3;
            // 
            // btnclose
            // 
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnclose.Location = new System.Drawing.Point(1297, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(48, 39);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "x";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btncat
            // 
            this.btncat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncat.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.btncat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncat.ForeColor = System.Drawing.Color.DarkOrange;
            this.btncat.Location = new System.Drawing.Point(15, 307);
            this.btncat.Name = "btncat";
            this.btncat.Size = new System.Drawing.Size(149, 45);
            this.btncat.TabIndex = 1;
            this.btncat.Text = "Catagory";
            this.btncat.Click += new System.EventHandler(this.btncat_Click);
            // 
            // btnselling
            // 
            this.btnselling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnselling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnselling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnselling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnselling.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnselling.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselling.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnselling.Location = new System.Drawing.Point(15, 358);
            this.btnselling.Name = "btnselling";
            this.btnselling.Size = new System.Drawing.Size(149, 45);
            this.btnselling.TabIndex = 1;
            this.btnselling.Text = "Selling";
            this.btnselling.Click += new System.EventHandler(this.btnselling_Click);
            // 
            // sellerbtn
            // 
            this.sellerbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sellerbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sellerbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sellerbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sellerbtn.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.sellerbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.sellerbtn.Location = new System.Drawing.Point(15, 256);
            this.sellerbtn.Name = "sellerbtn";
            this.sellerbtn.Size = new System.Drawing.Size(149, 45);
            this.sellerbtn.TabIndex = 1;
            this.sellerbtn.Text = "Seller";
            this.sellerbtn.Click += new System.EventHandler(this.sellerbtn_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnminimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnminimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnminimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnminimize.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnminimize.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnminimize.Location = new System.Drawing.Point(1233, 2);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(56, 39);
            this.btnminimize.TabIndex = 1;
            this.btnminimize.Text = "-";
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 820);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnselling);
            this.Controls.Add(this.sellerbtn);
            this.Controls.Add(this.btncat);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.mainprodpanl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            this.mainprodpanl.ResumeLayout(false);
            this.mainprodpanl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainprodpanl;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2Button btncat;
        private Guna.UI2.WinForms.Guna2Button btnselling;
        private Guna.UI2.WinForms.Guna2Button sellerbtn;
        private Guna.UI2.WinForms.Guna2Button btnminimize;
        private System.Windows.Forms.ComboBox combocat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox prodprice;
        private Guna.UI2.WinForms.Guna2TextBox prodid;
        private Guna.UI2.WinForms.Guna2TextBox prodqty;
        private Guna.UI2.WinForms.Guna2Button btneditprod;
        private Guna.UI2.WinForms.Guna2Button btndeleteprod;
        private Guna.UI2.WinForms.Guna2Button btnaddprod;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ComboBox searchcat;
        private System.Windows.Forms.Label manageprod;
        private Guna.UI2.WinForms.Guna2DataGridView prodDGV;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox prodname;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}