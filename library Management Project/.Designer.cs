namespace library_Management_Project
{
    partial class BookScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.panelAbove = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureclose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBelow = new System.Windows.Forms.Panel();
            this.BtSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonAddBook = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelFill = new System.Windows.Forms.Panel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelAbove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).BeginInit();
            this.panelBelow.SuspendLayout();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAbove
            // 
            this.panelAbove.BackColor = System.Drawing.Color.White;
            this.panelAbove.Controls.Add(this.pictureBox3);
            this.panelAbove.Controls.Add(this.pictureBox2);
            this.panelAbove.Controls.Add(this.pictureclose);
            this.panelAbove.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.panelAbove, BunifuAnimatorNS.DecorationType.None);
            this.panelAbove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAbove.Location = new System.Drawing.Point(0, 0);
            this.panelAbove.Name = "panelAbove";
            this.panelAbove.Size = new System.Drawing.Size(936, 45);
            this.panelAbove.TabIndex = 0;
            this.panelAbove.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAbove_Paint);
            this.panelAbove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAbove_MouseDown);
            this.panelAbove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAbove_MouseMove);
            this.panelAbove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelAbove_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Location = new System.Drawing.Point(833, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 43);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(782, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 43);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureclose
            // 
            this.pictureclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureclose.BackgroundImage")));
            this.pictureclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.pictureclose, BunifuAnimatorNS.DecorationType.None);
            this.pictureclose.Location = new System.Drawing.Point(884, 1);
            this.pictureclose.Name = "pictureclose";
            this.pictureclose.Size = new System.Drawing.Size(51, 43);
            this.pictureclose.TabIndex = 2;
            this.pictureclose.TabStop = false;
            this.pictureclose.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(384, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "إدارة الكتب";
            // 
            // panelBelow
            // 
            this.panelBelow.BackColor = System.Drawing.Color.White;
            this.panelBelow.Controls.Add(this.BtSearch);
            this.panelBelow.Controls.Add(this.bunifuThinButton23);
            this.panelBelow.Controls.Add(this.bunifuThinButton22);
            this.panelBelow.Controls.Add(this.bunifuThinButton21);
            this.panelBelow.Controls.Add(this.ButtonAddBook);
            this.bunifuTransition1.SetDecoration(this.panelBelow, BunifuAnimatorNS.DecorationType.None);
            this.panelBelow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBelow.Location = new System.Drawing.Point(0, 518);
            this.panelBelow.Name = "panelBelow";
            this.panelBelow.Size = new System.Drawing.Size(936, 76);
            this.panelBelow.TabIndex = 1;
            // 
            // BtSearch
            // 
            this.BtSearch.ActiveBorderThickness = 20;
            this.BtSearch.ActiveCornerRadius = 20;
            this.BtSearch.ActiveFillColor = System.Drawing.Color.Magenta;
            this.BtSearch.ActiveForecolor = System.Drawing.Color.DarkGray;
            this.BtSearch.ActiveLineColor = System.Drawing.Color.Cyan;
            this.BtSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtSearch.BackColor = System.Drawing.Color.White;
            this.BtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtSearch.BackgroundImage")));
            this.BtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtSearch.ButtonText = "بحث";
            this.BtSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.BtSearch, BunifuAnimatorNS.DecorationType.None);
            this.BtSearch.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtSearch.IdleBorderThickness = 3;
            this.BtSearch.IdleCornerRadius = 20;
            this.BtSearch.IdleFillColor = System.Drawing.Color.White;
            this.BtSearch.IdleForecolor = System.Drawing.Color.Navy;
            this.BtSearch.IdleLineColor = System.Drawing.Color.Indigo;
            this.BtSearch.Location = new System.Drawing.Point(25, 7);
            this.BtSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(159, 59);
            this.BtSearch.TabIndex = 0;
            this.BtSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtSearch.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 20;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Magenta;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.DarkGray;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton23.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuThinButton23.ButtonText = "التفاصيل";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton23, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton23.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 3;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Navy;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton23.Location = new System.Drawing.Point(207, 7);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(159, 59);
            this.bunifuThinButton23.TabIndex = 0;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 20;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Magenta;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.DarkGray;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuThinButton22.ButtonText = "حذف الكتاب";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 3;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Navy;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton22.Location = new System.Drawing.Point(389, 7);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(159, 59);
            this.bunifuThinButton22.TabIndex = 0;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 20;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Magenta;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.DarkGray;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuThinButton21.ButtonText = "تعديل الكتاب الحالي";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 3;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Navy;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton21.Location = new System.Drawing.Point(571, 7);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(159, 59);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // ButtonAddBook
            // 
            this.ButtonAddBook.ActiveBorderThickness = 20;
            this.ButtonAddBook.ActiveCornerRadius = 20;
            this.ButtonAddBook.ActiveFillColor = System.Drawing.Color.Magenta;
            this.ButtonAddBook.ActiveForecolor = System.Drawing.Color.Blue;
            this.ButtonAddBook.ActiveLineColor = System.Drawing.Color.Cyan;
            this.ButtonAddBook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonAddBook.BackColor = System.Drawing.Color.White;
            this.ButtonAddBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAddBook.BackgroundImage")));
            this.ButtonAddBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonAddBook.ButtonText = "إضافة كتاب جديد";
            this.ButtonAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.ButtonAddBook, BunifuAnimatorNS.DecorationType.None);
            this.ButtonAddBook.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddBook.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonAddBook.IdleBorderThickness = 3;
            this.ButtonAddBook.IdleCornerRadius = 20;
            this.ButtonAddBook.IdleFillColor = System.Drawing.Color.White;
            this.ButtonAddBook.IdleForecolor = System.Drawing.Color.Navy;
            this.ButtonAddBook.IdleLineColor = System.Drawing.Color.Indigo;
            this.ButtonAddBook.Location = new System.Drawing.Point(753, 7);
            this.ButtonAddBook.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ButtonAddBook.Name = "ButtonAddBook";
            this.ButtonAddBook.Size = new System.Drawing.Size(159, 59);
            this.ButtonAddBook.TabIndex = 0;
            this.ButtonAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.dgv1);
            this.bunifuTransition1.SetDecoration(this.panelFill, BunifuAnimatorNS.DecorationType.None);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 45);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(936, 473);
            this.panelFill.TabIndex = 2;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv1.ColumnHeadersHeight = 39;
            this.bunifuTransition1.SetDecoration(this.dgv1, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.GridColor = System.Drawing.Color.Gray;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 20;
            this.dgv1.RowTemplate.Height = 30;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(936, 473);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
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
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 3;
            this.bunifuTransition1.TimeStep = 0.09F;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 594);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelBelow);
            this.Controls.Add(this.panelAbove);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAbove.ResumeLayout(false);
            this.panelAbove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureclose)).EndInit();
            this.panelBelow.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAbove;
        private System.Windows.Forms.Panel panelBelow;
        private System.Windows.Forms.Panel panelFill;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonAddBook;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtSearch;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureclose;
    }
}

