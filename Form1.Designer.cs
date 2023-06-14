namespace Final_C_
{
    partial class Form1
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
            this.productImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addImageButton = new System.Windows.Forms.Button();
            this.productDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productImgPath = new System.Windows.Forms.TextBox();
            this.productPromotion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productData = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.productManagement = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.saveProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // productImg
            // 
            this.productImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImg.Location = new System.Drawing.Point(6, 19);
            this.productImg.Name = "productImg";
            this.productImg.Size = new System.Drawing.Size(124, 159);
            this.productImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImg.TabIndex = 0;
            this.productImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "SẢN PHẨM ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productCategory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addImageButton);
            this.groupBox1.Controls.Add(this.productDescription);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.productPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.productName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.productImgPath);
            this.groupBox1.Controls.Add(this.productPromotion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.productID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.productImg);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 215);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // productCategory
            // 
            this.productCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCategory.FormattingEnabled = true;
            this.productCategory.Location = new System.Drawing.Point(196, 120);
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(100, 21);
            this.productCategory.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Category";
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(5, 184);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(84, 23);
            this.addImageButton.TabIndex = 13;
            this.addImageButton.Text = "Image";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(373, 120);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(181, 20);
            this.productDescription.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(373, 69);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(181, 20);
            this.productPrice.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(373, 19);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(181, 20);
            this.productName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // productImgPath
            // 
            this.productImgPath.Location = new System.Drawing.Point(95, 185);
            this.productImgPath.Name = "productImgPath";
            this.productImgPath.Size = new System.Drawing.Size(459, 20);
            this.productImgPath.TabIndex = 6;
            // 
            // productPromotion
            // 
            this.productPromotion.Location = new System.Drawing.Point(196, 69);
            this.productPromotion.Name = "productPromotion";
            this.productPromotion.Size = new System.Drawing.Size(100, 20);
            this.productPromotion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Promotion";
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(196, 19);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(100, 20);
            this.productID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productData);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 179);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // productData
            // 
            this.productData.AllowUserToAddRows = false;
            this.productData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.productData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.productData.Location = new System.Drawing.Point(6, 19);
            this.productData.Name = "productData";
            this.productData.ReadOnly = true;
            this.productData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productData.Size = new System.Drawing.Size(764, 154);
            this.productData.TabIndex = 0;
            this.productData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productData_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.productManagement);
            this.groupBox3.Controls.Add(this.undoButton);
            this.groupBox3.Controls.Add(this.deleteProduct);
            this.groupBox3.Controls.Add(this.saveProduct);
            this.groupBox3.Controls.Add(this.addProduct);
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.searchInput);
            this.groupBox3.Location = new System.Drawing.Point(578, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 215);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hành động";
            // 
            // productManagement
            // 
            this.productManagement.Location = new System.Drawing.Point(6, 185);
            this.productManagement.Name = "productManagement";
            this.productManagement.Size = new System.Drawing.Size(198, 23);
            this.productManagement.TabIndex = 23;
            this.productManagement.Text = "Back to DashBoard";
            this.productManagement.UseVisualStyleBackColor = true;
            this.productManagement.Click += new System.EventHandler(this.productManagement_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(6, 156);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(198, 23);
            this.undoButton.TabIndex = 22;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(115, 66);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(89, 23);
            this.deleteProduct.TabIndex = 21;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // saveProduct
            // 
            this.saveProduct.Location = new System.Drawing.Point(6, 118);
            this.saveProduct.Name = "saveProduct";
            this.saveProduct.Size = new System.Drawing.Size(198, 23);
            this.saveProduct.TabIndex = 19;
            this.saveProduct.Text = "Save";
            this.saveProduct.UseVisualStyleBackColor = true;
            this.saveProduct.Click += new System.EventHandler(this.saveProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(6, 66);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(91, 23);
            this.addProduct.TabIndex = 18;
            this.addProduct.Text = "Add new";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(57, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(69, 19);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(135, 20);
            this.searchInput.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productImgPath;
        private System.Windows.Forms.TextBox productPromotion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.TextBox productDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox productCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button saveProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button productManagement;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.DataGridView productData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

