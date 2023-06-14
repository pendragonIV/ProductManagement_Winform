using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_C_
{
    public partial class Form2 : Form
    {

        static string connectSql = "Server=NGDANH; Database=final_c#; Trusted_Connection=true;";
        SqlConnection connect = new SqlConnection(connectSql);

        Thread th;

        static string selectSql = "SELECT * FROM category";


        public Form2()
        {
            InitializeComponent();
        }

        private void setDefault()
        {
            deleteCategory.Enabled = false;
            saveCategory.Enabled = false;
            undoButton.Enabled = false;
            addCategory.Enabled = true;

            categoryID.Enabled = false;
            categoryName.Enabled = false;
            categoryDescription.Enabled = false;

            categoryID.Text = null;
            categoryName.Text = null;
            categoryDescription.Text = null;
            searchInput.Text = "";
        }

        public void setInput()
        {
            saveCategory.Enabled = true;
            addCategory.Enabled = false;
            undoButton.Enabled = true;
            deleteCategory.Enabled = false;

            categoryID.Enabled = false;
            categoryName.Enabled = true;
            categoryDescription.Enabled = true;
        }

        private void setGridViewData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(selectSql, connect);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "product");
            categoryData.DataSource = dataSet.Tables["product"].DefaultView;
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
        private void Form2_Load(object sender, EventArgs e)
        {
            setDefault();
            connect.Open();

            setGridViewData();

            connect.Close();
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            setInput();
        }

        private void deleteCategory_Click(object sender, EventArgs e)
        {
            string recentCategoryId = categoryID.Text;
            string recentCategoryName = categoryName.Text;
            SqlCommand cmd;
            SqlDataReader reader;

            string getCategoryProduct = "select * from product where product_category = " + recentCategoryId + "";

            string deleteCategorySQL = "delete from category where category_id = " + recentCategoryId + "";

            connect.Open();

            cmd = new SqlCommand(getCategoryProduct, connect);
            reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }

            if(count > 0)
            {
                MessageBox.Show("Danh mục này đã có sản phẩm");
            }
            else
            {
                reader.Close();
                cmd = new SqlCommand(deleteCategorySQL, connect);
                cmd.ExecuteNonQuery();

                setGridViewData();

                setDefault();

                MessageBox.Show(recentCategoryName + " has been deleted!");
            }
            connect.Close();

        }

        private void saveCategory_Click(object sender, EventArgs e)
        {
            string insertName = categoryName.Text;
            string insertDescription = categoryDescription.Text;

            SqlCommand cmd;

            if (categoryID.Text == "" || categoryID.Text == null)
            {
                string getCategory = "select * from category where category_name = '"+insertName+"'";
                connect.Open();

                cmd = new SqlCommand(getCategory, connect);
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                reader.Close();

                if(count > 0)
                {
                    MessageBox.Show("Danh mục đã tồn tại!");
                }
                else
                {
                    string insertCategorySQL = "insert into category values('" + insertName + "','" + insertDescription + "')";

                    cmd = new SqlCommand(insertCategorySQL, connect);
                    cmd.ExecuteNonQuery();
                   

                    setGridViewData();

                    setDefault();

                    MessageBox.Show("New category has added");
                }
                connect.Close();
            }
            else
            {
                string getCategory = "select * from category where category_name = '" + insertName + "'";
                connect.Open();

                cmd = new SqlCommand(getCategory, connect);
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                reader.Close();

                if (count > 0)
                {
                    MessageBox.Show("Danh mục đã tồn tại!");
                }
                else
                {
                    string updateCategorySQL = "UPDATE category SET " +
                                          "category_name = '" + insertName + "'," +
                                          "category_description = '" + insertDescription + "'" +
                                          "WHERE category_id = " + categoryID.Text;
                    connect.Open();

                    cmd = new SqlCommand(updateCategorySQL, connect);
                    cmd.ExecuteNonQuery();

                    setGridViewData();

                    setDefault();
                    MessageBox.Show("Category information has been updated");
                }
                connect.Close();

               
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            setDefault();
            connect.Open();
            setGridViewData();
            connect.Close();
        }

        private void categoryData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setInput();
            deleteCategory.Enabled = true;

            categoryID.Text = categoryData.Rows[e.RowIndex].Cells["category_id"].Value.ToString();
            categoryName.Text = categoryData.Rows[e.RowIndex].Cells["category_name"].Value.ToString();
            categoryDescription.Text = categoryData.Rows[e.RowIndex].Cells["category_description"].Value.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchIn = searchInput.Text;
            if (searchInput.Text != null && !searchInput.Text.ToString().Equals(""))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM category WHERE category_name LIKE '%" + searchIn + "%'", connect);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "category");
                categoryData.DataSource = dataSet.Tables["category"].DefaultView;
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
