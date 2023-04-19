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
    public partial class seller : Form
    {
        public seller()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nas\Documents\pen and pencil.mdf;Integrated Security=True;Connect Timeout=30");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnaddseller_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into SellerTbl values ('" + txtsellerid.Text + "','" + txtsellername.Text + "','" + txtphoneno.Text + "','" + txtsellerpass.Text + "')";
                SqlCommand cmd = new SqlCommand( query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added successfully!");
                txtsellerid.Text = "";
                txtsellername.Text = "";
                txtphoneno.Text = "";
                txtsellerpass.Text = "";
                con.Close();
                populate();
              
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            
            }
        }
        private void populate()
        {

            con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sellerDGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void sellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtsellerid.Text = sellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtsellername.Text = sellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtphoneno.Text = sellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtsellerpass.Text = sellerDGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void btneditseller_Click(object sender, EventArgs e)
        {
            if(txtsellerid.Text==""|| txtsellername.Text==""||txtphoneno.Text==""||txtsellerpass.Text=="")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    con.Open();
                    string query = "update SellerTbl set    sellerName='" + txtsellername.Text + "',sellerPhone='" + txtphoneno.Text + "',sellerPass='" + txtsellerpass.Text + "' where sellerId=" + txtsellerid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller updated succesfully!");
                    txtsellerid.Text = "";
                    txtsellername.Text = "";
                    txtphoneno.Text = "";
                    txtsellerpass.Text = "";
                    con.Close();
                    populate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
              
            }
        }

        private void btndeleteseller_Click(object sender, EventArgs e)
        {
            if (txtsellerid.Text == "")
            {
                MessageBox.Show("Please select user");
            }
            else 
            {
                try
                {
                    con.Open();
                    string query = "delete from SellerTbl where sellerId=" + txtsellerid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted succesfully!");
                    txtsellerid.Text = "";
                    txtsellername.Text = "";
                    txtphoneno.Text = "";
                    txtsellerpass.Text = "";
                    con.Close();
                    populate();
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void seller_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            catagory cat = new catagory();
            cat.Show();
            this.Hide();
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            product cat = new product();
            cat.Show();
            this.Hide();
        }

        private void btnselling_Click(object sender, EventArgs e)
        {
            selling selling = new selling();
            selling.Show();
            this.Hide();
        }
    }
}
