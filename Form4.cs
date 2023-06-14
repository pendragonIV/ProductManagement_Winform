using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_C_
{
    public partial class Form4 : Form
    {
        static string connectSql = "Server=NGDANH; Database=final_c#; Trusted_Connection=true;";
        SqlConnection connect = new SqlConnection(connectSql);
        Thread th;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string countProductSQL = "Select count(product_id) as total_product from product";
            connect.Open();

            SqlCommand cmd; 
            cmd = new SqlCommand(countProductSQL, connect);
            SqlDataReader reader;
                
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                productDB.Text = "Tổng số sản phẩm: " + reader["total_product"].ToString();
            }

            string countCategorySQL = "Select count(category_id) as total_category from category";

            reader.Close();

            cmd = new SqlCommand(countCategorySQL, connect);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                categoryDB.Text = "Tổng số danh mục: " + reader["total_category"].ToString();
            }

            reader.Close();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT category_name, count(*) as total_product FROM category join product on product.product_category = category.category_id GROUP BY category_name", connect);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "product");
            productEachCate.DataSource = dataSet.Tables["product"].DefaultView;
            productEachCate.Columns[0].HeaderText = "Category name";
            productEachCate.Columns[1].HeaderText = "Total product";

            connect.Close();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();

            th = new Thread(logOut);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        public void logOut(object obj)
        {
            Application.Run(new Form3());
        }

        private void CateManagePage_Click(object sender, EventArgs e)
        {
            this.Close();

            th = new Thread(cateManagement);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        public void cateManagement(object obj)
        {
            Application.Run(new Form2());
        }

        private void productManagePage_Click(object sender, EventArgs e)
        {
            this.Close();

            th = new Thread(productManagement);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        public void productManagement(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
