using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pen_and_pencil
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nas\Documents\pen and pencil.mdf;Integrated Security=True;Connect Timeout=30");


        private void fillcombo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select catName from catagoryTbl", con);
            SqlDataReader rdr;
            rdr= cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catName", typeof(string));
            dt.Load(rdr);
            combocat.ValueMember = "catName";
            combocat.DataSource= dt;
            con.Close();
            
        }
        private void fillsearchcat()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select catName from catagoryTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catName", typeof(string));
            dt.Load(rdr);
            searchcat.ValueMember = "catName";
            searchcat.DataSource = dt;
            con.Close();

        }

        private void product_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
            fillsearchcat();
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            catagory cat = new catagory();
            cat.Show();
            this.Hide();
        }

        private void btnaddprod_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string query = "Insert into productTbl values ('" + prodid.Text + "','" + prodname.Text + "','" + prodqty.Text + "', '" + prodprice.Text + "', '" + combocat.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                prodid.Text = "";
                prodname.Text = "";
                prodqty.Text = "";
                prodprice.Text = "";
                con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void populate()
        {
            con.Open();
            string query = "select * from productTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void prodDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodid.Text = prodDGV.SelectedRows[0].Cells[0].Value.ToString();
            prodname.Text = prodDGV.SelectedRows[0].Cells[1].Value.ToString();
            prodqty.Text = prodDGV.SelectedRows[0].Cells[2].Value.ToString();
            prodprice.Text = prodDGV.SelectedRows[0].Cells[3].Value.ToString();
            combocat.SelectedValue = prodDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btneditprod_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodid.Text == "" || prodname.Text == "" || prodqty.Text == "" || prodprice.Text == "" || combocat.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update productTbl set prodName='"+prodname.Text + "',  prodQty='" + prodqty.Text + "',  prodPrice='"+prodprice.Text+ "',prodCat='"+combocat.SelectedValue.ToString()+"' where prodId= " +prodid.Text+ ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("product Updated successfully");
                    prodid.Text = "";
                    prodname.Text = "";
                    prodqty.Text = "";
                    prodprice.Text = "";
                    con.Close();
                    populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndeleteprod_Click(object sender, EventArgs e)
        {
            if(prodid.Text== "")
            {
                MessageBox.Show("Please select the product");
            }
            else
            {
                con.Open();
                string query = "delete from productTbl where prodId ='" + prodid.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("product Deleted successfully");
                prodid.Text = "";
                prodname.Text = "";
                prodqty.Text = "";
                prodprice.Text = "";
                con.Close();
                populate();

            }
        }

        private void sellerbtn_Click(object sender, EventArgs e)
        {
            seller seller = new seller();
            seller.Show();
            this.Hide();
        }

        private void btnselling_Click(object sender, EventArgs e)
        {
            selling selling = new selling();
            selling.Show();
            this.Hide();
        }

        private void searchcat_SelectedIndexChanged(object sender, EventArgs e)

        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nas\Documents\pen and pencil.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "SELECT * FROM productTbl WHERE prodCat ='" + searchcat.SelectedValue.ToString() + "';";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
