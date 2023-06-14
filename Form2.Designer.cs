namespace Final_C_
{
    partial class Form2
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.productManagement = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.deleteCategory = new System.Windows.Forms.Button();
            this.saveCategory = new System.Windows.Forms.Button();
            this.addCategory = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.categoryData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.productManagement);
            this.groupBox3.Controls.Add(this.undoButton);
            this.groupBox3.Controls.Add(this.deleteCategory);
            this.groupBox3.Controls.Add(this.saveCategory);
            this.groupBox3.Controls.Add(this.addCategory);
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.searchInput);
            this.groupBox3.Location = new System.Drawing.Point(578, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 182);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // productManagement
            // 
            this.productManagement.Location = new System.Drawing.Point(6, 153);
            this.productManagement.Name = "productManagement";
            this.productManagement.Size = new System.Drawing.Size(198, 23);
            this.productManagement.TabIndex = 23;
            this.productManagement.Text = "Back to DashBoard";
            this.productManagement.UseVisualStyleBackColor = true;
            this.productManagement.Click += new System.EventHandler(this.productManagement_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(6, 124);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(198, 23);
            this.undoButton.TabIndex = 22;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // deleteCategory
            // 
            this.deleteCategory.Location = new System.Drawing.Point(115, 66);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.Size = new System.Drawing.Size(89, 23);
            this.deleteCategory.TabIndex = 21;
            this.deleteCategory.Text = "Delete";
            this.deleteCategory.UseVisualStyleBackColor = true;
            this.deleteCategory.Click += new System.EventHandler(this.deleteCategory_Click);
            // 
            // saveCategory
            // 
            this.saveCategory.Location = new System.Drawing.Point(6, 95);
            this.saveCategory.Name = "saveCategory";
            this.saveCategory.Size = new System.Drawing.Size(198, 23);
            this.saveCategory.TabIndex = 19;
            this.saveCategory.Text = "Save";
            this.saveCategory.UseVisualStyleBackColor = true;
            this.saveCategory.Click += new System.EventHandler(this.saveCategory_Click);
            // 
            // addCategory
            // 
            this.addCategory.Location = new System.Drawing.Point(6, 66);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(91, 23);
            this.addCategory.TabIndex = 18;
            this.addCategory.Text = "Add new";
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categoryData);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 212);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu";
            // 
            // categoryData
            // 
            this.categoryData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.categoryData.Location = new System.Drawing.Point(6, 19);
            this.categoryData.Name = "categoryData";
            this.categoryData.ReadOnly = true;
            this.categoryData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryData.Size = new System.Drawing.Size(764, 187);
            this.categoryData.TabIndex = 0;
            this.categoryData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryData_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoryDescription);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.categoryName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.categoryID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin danh mục";
            // 
            // categoryDescription
            // 
            this.categoryDescription.Location = new System.Drawing.Point(72, 66);
            this.categoryDescription.Multiline = true;
            this.categoryDescription.Name = "categoryDescription";
            this.categoryDescription.Size = new System.Drawing.Size(482, 110);
            this.categoryDescription.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description";
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(321, 21);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(233, 20);
            this.categoryName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // categoryID
            // 
            this.categoryID.Location = new System.Drawing.Point(72, 21);
            this.categoryID.Name = "categoryID";
            this.categoryID.Size = new System.Drawing.Size(191, 20);
            this.categoryID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH MỤC";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button productManagement;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button deleteCategory;
        private System.Windows.Forms.Button saveCategory;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView categoryData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox categoryDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox categoryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}