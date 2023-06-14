using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_C_
{
    public partial class Form1 : Form
    {

        static string connectSql = "Server=NGDANH; Database=final_c#; Trusted_Connection=true;";
        SqlConnection connect = new SqlConnection(connectSql);

        private Dictionary<int, string> categoryDictionary;

        Thread th;

        static string selectSql = "SELECT * FROM product JOIN category ON category.category_id = product.product_category";

        public Form1()
        {
            InitializeComponent();
        }

        private void setCategory()
        {
            string selectCateSql = "SELECT * FROM category";
            categoryDictionary = new Dictionary<int, string>();
            SqlCommand selectCommand = new SqlCommand(selectCateSql, connect);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["category_id"];
                string name = (string)reader["category_name"];
                categoryDictionary.Add(id, name);
                
            }
            reader.Close();
        }

        private void setDefault()
        {
            deleteProduct.Enabled = false;
            saveProduct.Enabled = false;
            undoButton.Enabled = false;
            addImageButton.Enabled = false;
            addProduct.Enabled = true; 

            productID.Enabled = false;
            productName.Enabled = false;
            productDescription.Enabled = false;
            productPrice.Enabled = false;
            productPromotion.Enabled = false;
            productCategory.Enabled = false;
            productImgPath.Enabled = false;

            productID.Text = null;
            productName.Text = null;
            productDescription.Text = null;
            productPrice.Text = null;
            productPromotion.Text = null;
            productImgPath.Text = null;
            productImg.Image = null;

            searchInput.Text = "";
        }

        public void setInput()
        {
            saveProduct.Enabled = true;
            addProduct.Enabled = false;
            undoButton.Enabled = true;
            addImageButton.Enabled = true;
            deleteProduct.Enabled = false;

            productID.Enabled = false;
            productName.Enabled = true;
            productDescription.Enabled = true;
            productPrice.Enabled = true;
            productPromotion.Enabled = true;
            productCategory.Enabled = true;
        }


        private void setGridViewData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(selectSql, connect);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "product");
            productData.DataSource = dataSet.Tables["product"].DefaultView;
        }

        public string getImage(string path)
        {
            // create path
            string imagePath = $@"{path}";

            // check if the path exist
            if (System.IO.File.Exists(imagePath))
            {
                // return img path
                return imagePath;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tập tin ảnh.");
                return "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            connect.Open();

            setDefault();

            setGridViewData();

            setCategory();
            productCategory.DisplayMember = "Value";
            productCategory.ValueMember = "Key";
            productCategory.DataSource = new BindingSource(categoryDictionary, null);

            connect.Close();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            setInput();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            setDefault();
            connect.Open();
            setGridViewData();
            connect.Close();
        }

        private void saveProduct_Click(object sender, EventArgs e)
        {
            string insertName = productName.Text;
            string insertDescription = productDescription.Text;
            string price = productPrice.Text;
            string promotion = productPromotion.Text;
            string insertImg = productImgPath.Text;
            int selectedCategory = (int)productCategory.SelectedValue;

            SqlCommand cmd;

            if (insertName == ""
             || insertDescription == ""
             || price == ""
             || promotion == ""
             || insertImg == ""
             || productCategory.Text == null)
            {

                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");

            }
            else
            {

                int insertPrice;
                int insertPromotion;

                try
                {

                    insertPrice = int.Parse(price);
                    insertPromotion = int.Parse(promotion);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Giá tiền hoặc khuyến mãi không hợp lệ");
                    return;
                }

              

                if (productID.Text == "" || productID.Text == null)
                {
                    string insertProductSQL = "insert into product values('" + insertName + "'," + insertPrice + "," + insertPromotion + ",'" + insertImg + "','" + insertDescription + "'," + selectedCategory + ")";
                    connect.Open();

                    cmd = new SqlCommand(insertProductSQL, connect);
                    cmd.ExecuteNonQuery();

                    setGridViewData();

                    setDefault();

                    connect.Close();

                    MessageBox.Show("New product has added");
                }
                else
                {
                    string updateProductSQL = "UPDATE product SET " +
                                               "product_name = '" + insertName + "'," +
                                               "product_price = " + insertPrice + "," +
                                               "product_promotion = " + insertPromotion + "," +
                                               "product_image = '" + insertImg + "'," +
                                               "product_description = '" + insertDescription + "'," +
                                               "product_category = " + selectedCategory +
                                               "WHERE product_id = " + productID.Text;
                    connect.Open();

                    cmd = new SqlCommand(updateProductSQL, connect);
                    cmd.ExecuteNonQuery();

                    setGridViewData();

                    setDefault();

                    connect.Close();

                    MessageBox.Show("Product information has been updated");
                }
            }
           
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            // Show choose img dialog (OpenFileDialog)
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //get choosen img path
                    string imagePath = openFileDialog.FileName;

                    // create img object
                    Image image = Image.FromFile(imagePath);

                    // set img to PictureBox
                    productImg.Image = image;

                    productImgPath.Text = imagePath;
                }
            }
        }

        private void productData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setInput();
            deleteProduct.Enabled = true;

            
            productID.Text = productData.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
            productName.Text = productData.Rows[e.RowIndex].Cells["product_name"].Value.ToString();
            productDescription.Text = productData.Rows[e.RowIndex].Cells["product_description"].Value.ToString();
            productPrice.Text = productData.Rows[e.RowIndex].Cells["product_price"].Value.ToString();
            productPromotion.Text = productData.Rows[e.RowIndex].Cells["product_promotion"].Value.ToString();
            productImgPath.Text = productData.Rows[e.RowIndex].Cells["product_image"].Value.ToString();
            productCategory.Text = productData.Rows[e.RowIndex].Cells["category_name"].Value.ToString();

            string imagePath = getImage(productData.Rows[e.RowIndex].Cells["product_image"].Value.ToString());
            if (imagePath != "")
            {
                productImg.Image = System.Drawing.Image.FromFile(imagePath);
            }
            
            
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            string recentProductId = productID.Text;
            string recentProductName = productName.Text;
            string deleteProductSQL = "delete from product where product_id = " + recentProductId + "";

            connect.Open();

            SqlCommand cmd = new SqlCommand(deleteProductSQL, connect);
            cmd.ExecuteNonQuery();

            setGridViewData();

            setDefault();

            connect.Close();

            MessageBox.Show(recentProductName + " has been deleted!");
        }

        private void productManagement_Click(object sender, EventArgs e)
        {
            this.Close();

            th = new Thread(dashBoard);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        public void dashBoard(object obj)
        {
            Application.Run(new Form4());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchIn = searchInput.Text;
            if (searchInput.Text != null && !searchInput.Text.ToString().Equals(""))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM product JOIN category ON category.category_id = product.product_category WHERE product_name LIKE '%"+searchIn+"%'", connect);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "product");
                productData.DataSource = dataSet.Tables["product"].DefaultView;
                undoButton.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Khong tim thay");
                setDefault();
                connect.Open();
                setGridViewData();
                connect.Close();
                searchInput.Text = "";
            }
        }
    }
}
