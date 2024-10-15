namespace library_Management_Project
{
    partial class FRM_Add_Edit
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Add_Edit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.pictureclose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonAddBook = new Bunifu.Framework.UI.BunifuThinButton2();
            this.date = new System.Windows.Forms.GroupBox();
            this.linkLabeldelete = new System.Windows.Forms.LinkLabel();
            this.linkLabeldowload = new System.Windows.Forms.LinkLabel();
            this.pictureBook = new System.Windows.Forms.PictureBox();
            this.rate = new Bunifu.Framework.UI.BunifuRating();
            this.datebook = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtDeleteCat = new System.Windows.Forms.Button();
            this.BtAddCate = new System.Windows.Forms.Button();
            this.comboBoxcategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbbookcopies = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.author = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.titlebook = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).BeginInit();
            this.panel2.SuspendLayout();
            this.date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.LabelTitle);
            this.panel1.Controls.Add(this.pictureclose);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 60);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.LabelTitle, BunifuAnimatorNS.DecorationType.None);
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(272, 15);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(183, 30);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "add new book";
            // 
            // pictureclose
            // 
            this.pictureclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureclose.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition2.SetDecoration(this.pictureclose, BunifuAnimatorNS.DecorationType.None);
            this.pictureclose.Image = global::library_Management_Project.Properties.Resources.close2;
            this.pictureclose.Location = new System.Drawing.Point(659, 0);
            this.pictureclose.Name = "pictureclose";
            this.pictureclose.Size = new System.Drawing.Size(67, 60);
            this.pictureclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureclose.TabIndex = 1;
            this.pictureclose.TabStop = false;
            this.pictureclose.Click += new System.EventHandler(this.pictureclose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.ButtonAddBook);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 60);
            this.panel2.TabIndex = 0;
            // 
            // ButtonAddBook
            // 
            this.ButtonAddBook.ActiveBorderThickness = 20;
            this.ButtonAddBook.ActiveCornerRadius = 20;
            this.ButtonAddBook.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ButtonAddBook.ActiveForecolor = System.Drawing.Color.DarkGray;
            this.ButtonAddBook.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ButtonAddBook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonAddBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAddBook.BackgroundImage")));
            this.ButtonAddBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonAddBook.ButtonText = "إضافة ";
            this.ButtonAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.ButtonAddBook, BunifuAnimatorNS.DecorationType.None);
            this.ButtonAddBook.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddBook.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonAddBook.IdleBorderThickness = 3;
            this.ButtonAddBook.IdleCornerRadius = 20;
            this.ButtonAddBook.IdleFillColor = System.Drawing.Color.White;
            this.ButtonAddBook.IdleForecolor = System.Drawing.Color.DarkGreen;
            this.ButtonAddBook.IdleLineColor = System.Drawing.Color.Green;
            this.ButtonAddBook.Location = new System.Drawing.Point(268, 1);
            this.ButtonAddBook.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ButtonAddBook.Name = "ButtonAddBook";
            this.ButtonAddBook.Size = new System.Drawing.Size(202, 59);
            this.ButtonAddBook.TabIndex = 9;
            this.ButtonAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // date
            // 
            this.date.Controls.Add(this.linkLabeldelete);
            this.date.Controls.Add(this.linkLabeldowload);
            this.date.Controls.Add(this.pictureBook);
            this.date.Controls.Add(this.rate);
            this.date.Controls.Add(this.datebook);
            this.date.Controls.Add(this.label7);
            this.date.Controls.Add(this.label6);
            this.date.Controls.Add(this.label5);
            this.bunifuTransition2.SetDecoration(this.date, BunifuAnimatorNS.DecorationType.None);
            this.date.Font = new System.Drawing.Font("Marlett", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(31, 66);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(312, 453);
            this.date.TabIndex = 8;
            this.date.TabStop = false;
            this.date.Text = "المعلومات الثانوية";
            // 
            // linkLabeldelete
            // 
            this.linkLabeldelete.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.linkLabeldelete, BunifuAnimatorNS.DecorationType.None);
            this.linkLabeldelete.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabeldelete.Location = new System.Drawing.Point(17, 385);
            this.linkLabeldelete.Name = "linkLabeldelete";
            this.linkLabeldelete.Size = new System.Drawing.Size(117, 27);
            this.linkLabeldelete.TabIndex = 8;
            this.linkLabeldelete.TabStop = true;
            this.linkLabeldelete.Text = "حذف الصورة";
            this.linkLabeldelete.Visible = false;
            this.linkLabeldelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabeldelete_LinkClicked);
            // 
            // linkLabeldowload
            // 
            this.linkLabeldowload.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.linkLabeldowload, BunifuAnimatorNS.DecorationType.None);
            this.linkLabeldowload.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabeldowload.Location = new System.Drawing.Point(154, 387);
            this.linkLabeldowload.Name = "linkLabeldowload";
            this.linkLabeldowload.Size = new System.Drawing.Size(124, 27);
            this.linkLabeldowload.TabIndex = 7;
            this.linkLabeldowload.TabStop = true;
            this.linkLabeldowload.Text = "تحميل الصورة";
            this.linkLabeldowload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabeldowload_LinkClicked);
            // 
            // pictureBook
            // 
            this.bunifuTransition2.SetDecoration(this.pictureBook, BunifuAnimatorNS.DecorationType.None);
            this.pictureBook.Location = new System.Drawing.Point(75, 268);
            this.pictureBook.Name = "pictureBook";
            this.pictureBook.Size = new System.Drawing.Size(166, 108);
            this.pictureBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBook.TabIndex = 3;
            this.pictureBook.TabStop = false;
            // 
            // rate
            // 
            this.rate.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.rate, BunifuAnimatorNS.DecorationType.None);
            this.rate.Font = new System.Drawing.Font("Marlett", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.ForeColor = System.Drawing.Color.SeaGreen;
            this.rate.Location = new System.Drawing.Point(4, 182);
            this.rate.Margin = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(282, 34);
            this.rate.TabIndex = 6;
            this.rate.Value = 0;
            // 
            // datebook
            // 
            this.datebook.BackColor = System.Drawing.Color.Navy;
            this.datebook.BorderRadius = 0;
            this.bunifuTransition2.SetDecoration(this.datebook, BunifuAnimatorNS.DecorationType.None);
            this.datebook.ForeColor = System.Drawing.Color.White;
            this.datebook.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datebook.FormatCustom = null;
            this.datebook.Location = new System.Drawing.Point(4, 72);
            this.datebook.Margin = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.datebook.Name = "datebook";
            this.datebook.Size = new System.Drawing.Size(303, 48);
            this.datebook.TabIndex = 5;
            this.datebook.Value = new System.DateTime(2023, 8, 21, 23, 41, 54, 397);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(169, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 35);
            this.label7.TabIndex = 15;
            this.label7.Text = "غلاف الكتاب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(232, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 35);
            this.label6.TabIndex = 14;
            this.label6.Text = "التقييم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(224, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 35);
            this.label5.TabIndex = 13;
            this.label5.Text = "التاريخ";
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox2.Controls.Add(this.BtDeleteCat);
            this.groupBox2.Controls.Add(this.BtAddCate);
            this.groupBox2.Controls.Add(this.comboBoxcategory);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbbookcopies);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.price);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.author);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.titlebook);
            this.groupBox2.Controls.Add(this.label1);
            this.bunifuTransition2.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Font = new System.Drawing.Font("Marlett", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(375, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 457);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المعلومات الأساسية";
            // 
            // BtDeleteCat
            // 
            this.BtDeleteCat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtDeleteCat.BackgroundImage")));
            this.BtDeleteCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition2.SetDecoration(this.BtDeleteCat, BunifuAnimatorNS.DecorationType.None);
            this.BtDeleteCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDeleteCat.Location = new System.Drawing.Point(7, 406);
            this.BtDeleteCat.Name = "BtDeleteCat";
            this.BtDeleteCat.Size = new System.Drawing.Size(48, 42);
            this.BtDeleteCat.TabIndex = 13;
            this.BtDeleteCat.UseVisualStyleBackColor = true;
            this.BtDeleteCat.Click += new System.EventHandler(this.BtDeleteCat_Click);
            // 
            // BtAddCate
            // 
            this.BtAddCate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtAddCate.BackgroundImage")));
            this.BtAddCate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition2.SetDecoration(this.BtAddCate, BunifuAnimatorNS.DecorationType.None);
            this.BtAddCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAddCate.Location = new System.Drawing.Point(71, 406);
            this.BtAddCate.Name = "BtAddCate";
            this.BtAddCate.Size = new System.Drawing.Size(48, 42);
            this.BtAddCate.TabIndex = 13;
            this.BtAddCate.UseVisualStyleBackColor = true;
            this.BtAddCate.Click += new System.EventHandler(this.BtAddCate_Click);
            // 
            // comboBoxcategory
            // 
            this.comboBoxcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bunifuTransition2.SetDecoration(this.comboBoxcategory, BunifuAnimatorNS.DecorationType.None);
            this.comboBoxcategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxcategory.FormattingEnabled = true;
            this.comboBoxcategory.Location = new System.Drawing.Point(135, 407);
            this.comboBoxcategory.Name = "comboBoxcategory";
            this.comboBoxcategory.Size = new System.Drawing.Size(175, 41);
            this.comboBoxcategory.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(211, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "التصنيف";
            // 
            // tbbookcopies
            // 
            this.tbbookcopies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition2.SetDecoration(this.tbbookcopies, BunifuAnimatorNS.DecorationType.None);
            this.tbbookcopies.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.tbbookcopies.ForeColor = System.Drawing.Color.Black;
            this.tbbookcopies.HintForeColor = System.Drawing.Color.Empty;
            this.tbbookcopies.HintText = "";
            this.tbbookcopies.isPassword = false;
            this.tbbookcopies.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbbookcopies.LineIdleColor = System.Drawing.Color.Gray;
            this.tbbookcopies.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbbookcopies.LineThickness = 6;
            this.tbbookcopies.Location = new System.Drawing.Point(7, 320);
            this.tbbookcopies.Margin = new System.Windows.Forms.Padding(4);
            this.tbbookcopies.Name = "tbbookcopies";
            this.tbbookcopies.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbbookcopies.Size = new System.Drawing.Size(303, 43);
            this.tbbookcopies.TabIndex = 3;
            this.tbbookcopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbbookcopies.OnValueChanged += new System.EventHandler(this.tbbookcopies_OnValueChanged);
            this.tbbookcopies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbbookcopies_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(106, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 35);
            this.label8.TabIndex = 11;
            this.label8.Text = "عدد النسخ المتوفرة";
            // 
            // price
            // 
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition2.SetDecoration(this.price, BunifuAnimatorNS.DecorationType.None);
            this.price.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.HintForeColor = System.Drawing.Color.Empty;
            this.price.HintText = "";
            this.price.isPassword = false;
            this.price.LineFocusedColor = System.Drawing.Color.Blue;
            this.price.LineIdleColor = System.Drawing.Color.Gray;
            this.price.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.price.LineThickness = 6;
            this.price.Location = new System.Drawing.Point(7, 235);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.price.Size = new System.Drawing.Size(303, 43);
            this.price.TabIndex = 2;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(239, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "السعر";
            // 
            // author
            // 
            this.author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition2.SetDecoration(this.author, BunifuAnimatorNS.DecorationType.None);
            this.author.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.author.ForeColor = System.Drawing.Color.Black;
            this.author.HintForeColor = System.Drawing.Color.Empty;
            this.author.HintText = "";
            this.author.isPassword = false;
            this.author.LineFocusedColor = System.Drawing.Color.Blue;
            this.author.LineIdleColor = System.Drawing.Color.Gray;
            this.author.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.author.LineThickness = 6;
            this.author.Location = new System.Drawing.Point(7, 149);
            this.author.Margin = new System.Windows.Forms.Padding(4);
            this.author.Name = "author";
            this.author.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.author.Size = new System.Drawing.Size(303, 43);
            this.author.TabIndex = 1;
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(225, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "المؤلف";
            // 
            // titlebook
            // 
            this.titlebook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition2.SetDecoration(this.titlebook, BunifuAnimatorNS.DecorationType.None);
            this.titlebook.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.titlebook.ForeColor = System.Drawing.Color.Black;
            this.titlebook.HintForeColor = System.Drawing.Color.Empty;
            this.titlebook.HintText = "";
            this.titlebook.isPassword = false;
            this.titlebook.LineFocusedColor = System.Drawing.Color.Blue;
            this.titlebook.LineIdleColor = System.Drawing.Color.Gray;
            this.titlebook.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.titlebook.LineThickness = 6;
            this.titlebook.Location = new System.Drawing.Point(7, 62);
            this.titlebook.Margin = new System.Windows.Forms.Padding(4);
            this.titlebook.Name = "titlebook";
            this.titlebook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titlebook.Size = new System.Drawing.Size(303, 43);
            this.titlebook.TabIndex = 0;
            this.titlebook.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(192, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "إسم الكتاب";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation1;
            this.bunifuTransition2.Interval = 1500;
            this.bunifuTransition2.TimeStep = 100F;
            // 
            // FRM_Add_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 616);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Add_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM";
            this.Load += new System.EventHandler(this.FRM_Add_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.date.ResumeLayout(false);
            this.date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureclose;
        private System.Windows.Forms.GroupBox date;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox titlebook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxcategory;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox price;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabeldowload;
        private System.Windows.Forms.PictureBox pictureBook;
        private Bunifu.Framework.UI.BunifuRating rate;
        private Bunifu.Framework.UI.BunifuDatepicker datebook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonAddBook;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabeldelete;
        private System.Windows.Forms.Button BtAddCate;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private System.Windows.Forms.Button BtDeleteCat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbbookcopies;
        private System.Windows.Forms.Label label8;
    }
}