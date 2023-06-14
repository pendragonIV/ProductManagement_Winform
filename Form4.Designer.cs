namespace Final_C_
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productEachCate = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryDB = new System.Windows.Forms.Label();
            this.productDB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.CateManagePage = new System.Windows.Forms.Button();
            this.productManagePage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productEachCate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productEachCate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.categoryDB);
            this.groupBox1.Controls.Add(this.productDB);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // productEachCate
            // 
            this.productEachCate.AllowUserToAddRows = false;
            this.productEachCate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productEachCate.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.productEachCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productEachCate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.productEachCate.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productEachCate.Location = new System.Drawing.Point(12, 55);
            this.productEachCate.Name = "productEachCate";
            this.productEachCate.ReadOnly = true;
            this.productEachCate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productEachCate.Size = new System.Drawing.Size(765, 131);
            this.productEachCate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(425, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số sản phẩm theo danh mục";
            // 
            // categoryDB
            // 
            this.categoryDB.AutoSize = true;
            this.categoryDB.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDB.Location = new System.Drawing.Point(399, 209);
            this.categoryDB.Name = "categoryDB";
            this.categoryDB.Size = new System.Drawing.Size(89, 36);
            this.categoryDB.TabIndex = 2;
            this.categoryDB.Text = "label3";
            // 
            // productDB
            // 
            this.productDB.AutoSize = true;
            this.productDB.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDB.Location = new System.Drawing.Point(6, 209);
            this.productDB.Name = "productDB";
            this.productDB.Size = new System.Drawing.Size(89, 36);
            this.productDB.TabIndex = 0;
            this.productDB.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logOutBtn);
            this.groupBox2.Controls.Add(this.CateManagePage);
            this.groupBox2.Controls.Add(this.productManagePage);
            this.groupBox2.Location = new System.Drawing.Point(12, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(533, 35);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(244, 39);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // CateManagePage
            // 
            this.CateManagePage.Location = new System.Drawing.Point(270, 35);
            this.CateManagePage.Name = "CateManagePage";
            this.CateManagePage.Size = new System.Drawing.Size(244, 39);
            this.CateManagePage.TabIndex = 2;
            this.CateManagePage.Text = "Category management";
            this.CateManagePage.UseVisualStyleBackColor = true;
            this.CateManagePage.Click += new System.EventHandler(this.CateManagePage_Click);
            // 
            // productManagePage
            // 
            this.productManagePage.Location = new System.Drawing.Point(6, 35);
            this.productManagePage.Name = "productManagePage";
            this.productManagePage.Size = new System.Drawing.Size(244, 39);
            this.productManagePage.TabIndex = 1;
            this.productManagePage.Text = "Product management";
            this.productManagePage.UseVisualStyleBackColor = true;
            this.productManagePage.Click += new System.EventHandler(this.productManagePage_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productEachCate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label categoryDB;
        private System.Windows.Forms.Label productDB;
        private System.Windows.Forms.DataGridView productEachCate;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button CateManagePage;
        private System.Windows.Forms.Button productManagePage;
    }
}