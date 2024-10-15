namespace library_Management_Project
{
    partial class AddCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbCat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtAddCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "إسم الصنف ";
            // 
            // TbCat
            // 
            this.TbCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbCat.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.TbCat.ForeColor = System.Drawing.Color.Black;
            this.TbCat.HintForeColor = System.Drawing.Color.Empty;
            this.TbCat.HintText = "";
            this.TbCat.isPassword = false;
            this.TbCat.LineFocusedColor = System.Drawing.Color.Blue;
            this.TbCat.LineIdleColor = System.Drawing.Color.Navy;
            this.TbCat.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TbCat.LineThickness = 9;
            this.TbCat.Location = new System.Drawing.Point(146, 137);
            this.TbCat.Margin = new System.Windows.Forms.Padding(4);
            this.TbCat.Name = "TbCat";
            this.TbCat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TbCat.Size = new System.Drawing.Size(343, 59);
            this.TbCat.TabIndex = 1;
            this.TbCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtAddCategory
            // 
            this.BtAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtAddCategory.FlatAppearance.BorderSize = 0;
            this.BtAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtAddCategory.Location = new System.Drawing.Point(231, 251);
            this.BtAddCategory.Name = "BtAddCategory";
            this.BtAddCategory.Size = new System.Drawing.Size(164, 51);
            this.BtAddCategory.TabIndex = 2;
            this.BtAddCategory.Text = "إضافة";
            this.BtAddCategory.UseVisualStyleBackColor = false;
            this.BtAddCategory.Click += new System.EventHandler(this.BtAddCategory_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(645, 353);
            this.Controls.Add(this.BtAddCategory);
            this.Controls.Add(this.TbCat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TbCat;
        private System.Windows.Forms.Button BtAddCategory;
    }
}