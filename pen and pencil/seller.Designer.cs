namespace pen_and_pencil
{
    partial class seller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seller));
            this.btnselling = new Guna.UI2.WinForms.Guna2Button();
            this.productbtn = new Guna.UI2.WinForms.Guna2Button();
            this.btncat = new Guna.UI2.WinForms.Guna2Button();
            this.btnminimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.mainprodpanl = new System.Windows.Forms.Panel();
            this.sellerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.manageprod = new System.Windows.Forms.Label();
            this.btneditseller = new Guna.UI2.WinForms.Guna2Button();
            this.btndeleteseller = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddseller = new Guna.UI2.WinForms.Guna2Button();
            this.sellerpass = new System.Windows.Forms.Label();
            this.phoneno = new System.Windows.Forms.Label();
            this.sellername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsellerpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtphoneno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsellerid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsellername = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainprodpanl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnselling.Location = new System.Drawing.Point(7, 363);
            this.btnselling.Name = "btnselling";
            this.btnselling.Size = new System.Drawing.Size(149, 45);
            this.btnselling.TabIndex = 4;
            this.btnselling.Text = "Selling";
            this.btnselling.Click += new System.EventHandler(this.btnselling_Click);
            // 
            // productbtn
            // 
            this.productbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productbtn.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.productbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.productbtn.Location = new System.Drawing.Point(7, 261);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(149, 45);
            this.productbtn.TabIndex = 5;
            this.productbtn.Text = "Product";
            this.productbtn.Click += new System.EventHandler(this.productbtn_Click);
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
            this.btncat.Location = new System.Drawing.Point(7, 312);
            this.btncat.Name = "btncat";
            this.btncat.Size = new System.Drawing.Size(149, 45);
            this.btncat.TabIndex = 6;
            this.btncat.Text = "Catagory";
            this.btncat.Click += new System.EventHandler(this.btncat_Click);
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
            this.btnminimize.Location = new System.Drawing.Point(1225, 7);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(56, 39);
            this.btnminimize.TabIndex = 7;
            this.btnminimize.Text = "-";
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
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
            this.btnclose.Location = new System.Drawing.Point(1289, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(48, 39);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "x";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // mainprodpanl
            // 
            this.mainprodpanl.BackColor = System.Drawing.Color.DarkOrange;
            this.mainprodpanl.Controls.Add(this.sellerDGV);
            this.mainprodpanl.Controls.Add(this.manageprod);
            this.mainprodpanl.Controls.Add(this.btneditseller);
            this.mainprodpanl.Controls.Add(this.btndeleteseller);
            this.mainprodpanl.Controls.Add(this.btnaddseller);
            this.mainprodpanl.Controls.Add(this.sellerpass);
            this.mainprodpanl.Controls.Add(this.phoneno);
            this.mainprodpanl.Controls.Add(this.sellername);
            this.mainprodpanl.Controls.Add(this.label2);
            this.mainprodpanl.Controls.Add(this.txtsellerpass);
            this.mainprodpanl.Controls.Add(this.txtphoneno);
            this.mainprodpanl.Controls.Add(this.txtsellerid);
            this.mainprodpanl.Controls.Add(this.txtsellername);
            this.mainprodpanl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainprodpanl.ForeColor = System.Drawing.Color.DarkOrange;
            this.mainprodpanl.Location = new System.Drawing.Point(171, 52);
            this.mainprodpanl.Name = "mainprodpanl";
            this.mainprodpanl.Size = new System.Drawing.Size(1154, 761);
            this.mainprodpanl.TabIndex = 3;
            // 
            // sellerDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.sellerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sellerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sellerDGV.ColumnHeadersHeight = 28;
            this.sellerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sellerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.sellerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellerDGV.Location = new System.Drawing.Point(516, 158);
            this.sellerDGV.Name = "sellerDGV";
            this.sellerDGV.RowHeadersVisible = false;
            this.sellerDGV.RowHeadersWidth = 51;
            this.sellerDGV.RowTemplate.Height = 24;
            this.sellerDGV.Size = new System.Drawing.Size(606, 578);
            this.sellerDGV.TabIndex = 10;
            this.sellerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.sellerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.sellerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.sellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.sellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.sellerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.sellerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sellerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sellerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sellerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sellerDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.sellerDGV.ThemeStyle.ReadOnly = false;
            this.sellerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sellerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkOrange;
            this.sellerDGV.ThemeStyle.RowsStyle.Height = 24;
            this.sellerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellerDGV_CellContentClick);
            // 
            // manageprod
            // 
            this.manageprod.AutoSize = true;
            this.manageprod.BackColor = System.Drawing.Color.DarkOrange;
            this.manageprod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageprod.ForeColor = System.Drawing.Color.White;
            this.manageprod.Location = new System.Drawing.Point(380, 3);
            this.manageprod.Name = "manageprod";
            this.manageprod.Size = new System.Drawing.Size(256, 45);
            this.manageprod.TabIndex = 9;
            this.manageprod.Text = "Manage Sellers";
            // 
            // btneditseller
            // 
            this.btneditseller.BackColor = System.Drawing.Color.DarkOrange;
            this.btneditseller.BorderColor = System.Drawing.Color.White;
            this.btneditseller.BorderRadius = 8;
            this.btneditseller.BorderThickness = 2;
            this.btneditseller.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneditseller.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneditseller.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneditseller.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneditseller.FillColor = System.Drawing.Color.White;
            this.btneditseller.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditseller.ForeColor = System.Drawing.Color.Orange;
            this.btneditseller.Location = new System.Drawing.Point(171, 404);
            this.btneditseller.Name = "btneditseller";
            this.btneditseller.Size = new System.Drawing.Size(125, 50);
            this.btneditseller.TabIndex = 7;
            this.btneditseller.Text = "EDIT";
            this.btneditseller.Click += new System.EventHandler(this.btneditseller_Click);
            // 
            // btndeleteseller
            // 
            this.btndeleteseller.BackColor = System.Drawing.Color.DarkOrange;
            this.btndeleteseller.BorderColor = System.Drawing.Color.White;
            this.btndeleteseller.BorderRadius = 8;
            this.btndeleteseller.BorderThickness = 2;
            this.btndeleteseller.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteseller.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteseller.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndeleteseller.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndeleteseller.FillColor = System.Drawing.Color.White;
            this.btndeleteseller.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteseller.ForeColor = System.Drawing.Color.Orange;
            this.btndeleteseller.Location = new System.Drawing.Point(317, 404);
            this.btndeleteseller.Name = "btndeleteseller";
            this.btndeleteseller.Size = new System.Drawing.Size(125, 50);
            this.btndeleteseller.TabIndex = 7;
            this.btndeleteseller.Text = "DELETE";
            this.btndeleteseller.Click += new System.EventHandler(this.btndeleteseller_Click);
            // 
            // btnaddseller
            // 
            this.btnaddseller.BackColor = System.Drawing.Color.DarkOrange;
            this.btnaddseller.BorderColor = System.Drawing.Color.White;
            this.btnaddseller.BorderRadius = 8;
            this.btnaddseller.BorderThickness = 2;
            this.btnaddseller.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddseller.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddseller.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddseller.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddseller.FillColor = System.Drawing.Color.White;
            this.btnaddseller.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddseller.ForeColor = System.Drawing.Color.Orange;
            this.btnaddseller.Location = new System.Drawing.Point(22, 404);
            this.btnaddseller.Name = "btnaddseller";
            this.btnaddseller.Size = new System.Drawing.Size(125, 50);
            this.btnaddseller.TabIndex = 7;
            this.btnaddseller.Text = "ADD";
            this.btnaddseller.Click += new System.EventHandler(this.btnaddseller_Click);
            // 
            // sellerpass
            // 
            this.sellerpass.AutoSize = true;
            this.sellerpass.BackColor = System.Drawing.Color.DarkOrange;
            this.sellerpass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerpass.ForeColor = System.Drawing.Color.White;
            this.sellerpass.Location = new System.Drawing.Point(16, 354);
            this.sellerpass.Name = "sellerpass";
            this.sellerpass.Size = new System.Drawing.Size(122, 27);
            this.sellerpass.TabIndex = 5;
            this.sellerpass.Text = "Password";
            this.sellerpass.Click += new System.EventHandler(this.label4_Click);
            // 
            // phoneno
            // 
            this.phoneno.AutoSize = true;
            this.phoneno.BackColor = System.Drawing.Color.DarkOrange;
            this.phoneno.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneno.ForeColor = System.Drawing.Color.White;
            this.phoneno.Location = new System.Drawing.Point(17, 292);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(121, 27);
            this.phoneno.TabIndex = 5;
            this.phoneno.Text = "Phone No";
            // 
            // sellername
            // 
            this.sellername.AutoSize = true;
            this.sellername.BackColor = System.Drawing.Color.DarkOrange;
            this.sellername.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellername.ForeColor = System.Drawing.Color.White;
            this.sellername.Location = new System.Drawing.Point(17, 231);
            this.sellername.Name = "sellername";
            this.sellername.Size = new System.Drawing.Size(74, 27);
            this.sellername.TabIndex = 5;
            this.sellername.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // txtsellerpass
            // 
            this.txtsellerpass.BackColor = System.Drawing.Color.White;
            this.txtsellerpass.BorderColor = System.Drawing.Color.DarkOrange;
            this.txtsellerpass.BorderThickness = 2;
            this.txtsellerpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsellerpass.DefaultText = "";
            this.txtsellerpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsellerpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsellerpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsellerpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsellerpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsellerpass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsellerpass.ForeColor = System.Drawing.Color.Black;
            this.txtsellerpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsellerpass.Location = new System.Drawing.Point(161, 339);
            this.txtsellerpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsellerpass.Name = "txtsellerpass";
            this.txtsellerpass.PasswordChar = '\0';
            this.txtsellerpass.PlaceholderText = "";
            this.txtsellerpass.SelectedText = "";
            this.txtsellerpass.Size = new System.Drawing.Size(281, 42);
            this.txtsellerpass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtsellerpass.TabIndex = 3;
            // 
            // txtphoneno
            // 
            this.txtphoneno.BackColor = System.Drawing.Color.White;
            this.txtphoneno.BorderColor = System.Drawing.Color.DarkOrange;
            this.txtphoneno.BorderThickness = 2;
            this.txtphoneno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphoneno.DefaultText = "";
            this.txtphoneno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphoneno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphoneno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphoneno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphoneno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphoneno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneno.ForeColor = System.Drawing.Color.Black;
            this.txtphoneno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphoneno.Location = new System.Drawing.Point(161, 277);
            this.txtphoneno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.PasswordChar = '\0';
            this.txtphoneno.PlaceholderText = "";
            this.txtphoneno.SelectedText = "";
            this.txtphoneno.Size = new System.Drawing.Size(281, 42);
            this.txtphoneno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtphoneno.TabIndex = 3;
            // 
            // txtsellerid
            // 
            this.txtsellerid.BackColor = System.Drawing.Color.White;
            this.txtsellerid.BorderColor = System.Drawing.Color.DarkOrange;
            this.txtsellerid.BorderThickness = 2;
            this.txtsellerid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsellerid.DefaultText = "";
            this.txtsellerid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsellerid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsellerid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsellerid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsellerid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsellerid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsellerid.ForeColor = System.Drawing.Color.Black;
            this.txtsellerid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsellerid.Location = new System.Drawing.Point(161, 158);
            this.txtsellerid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsellerid.Name = "txtsellerid";
            this.txtsellerid.PasswordChar = '\0';
            this.txtsellerid.PlaceholderText = "";
            this.txtsellerid.SelectedText = "";
            this.txtsellerid.Size = new System.Drawing.Size(281, 42);
            this.txtsellerid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtsellerid.TabIndex = 3;
            // 
            // txtsellername
            // 
            this.txtsellername.BackColor = System.Drawing.Color.White;
            this.txtsellername.BorderColor = System.Drawing.Color.DarkOrange;
            this.txtsellername.BorderThickness = 2;
            this.txtsellername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsellername.DefaultText = "";
            this.txtsellername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsellername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsellername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsellername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsellername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsellername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsellername.ForeColor = System.Drawing.Color.Black;
            this.txtsellername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsellername.Location = new System.Drawing.Point(161, 216);
            this.txtsellername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsellername.Name = "txtsellername";
            this.txtsellername.PasswordChar = '\0';
            this.txtsellername.PlaceholderText = "";
            this.txtsellername.SelectedText = "";
            this.txtsellername.Size = new System.Drawing.Size(281, 42);
            this.txtsellername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtsellername.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 820);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnselling);
            this.Controls.Add(this.productbtn);
            this.Controls.Add(this.btncat);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.mainprodpanl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "seller";
            this.Load += new System.EventHandler(this.seller_Load);
            this.mainprodpanl.ResumeLayout(false);
            this.mainprodpanl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnselling;
        private Guna.UI2.WinForms.Guna2Button productbtn;
        private Guna.UI2.WinForms.Guna2Button btncat;
        private Guna.UI2.WinForms.Guna2Button btnminimize;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Panel mainprodpanl;
        private System.Windows.Forms.Label manageprod;
        private Guna.UI2.WinForms.Guna2Button btneditseller;
        private Guna.UI2.WinForms.Guna2Button btndeleteseller;
        private Guna.UI2.WinForms.Guna2Button btnaddseller;
        private System.Windows.Forms.Label sellerpass;
        private System.Windows.Forms.Label phoneno;
        private System.Windows.Forms.Label sellername;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtphoneno;
        private Guna.UI2.WinForms.Guna2TextBox txtsellerid;
        private Guna.UI2.WinForms.Guna2TextBox txtsellername;
        private Guna.UI2.WinForms.Guna2TextBox txtsellerpass;
        private Guna.UI2.WinForms.Guna2DataGridView sellerDGV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}