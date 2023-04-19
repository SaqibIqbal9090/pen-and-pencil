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
    public partial class catagory : Form
    {
        public catagory()
        {
            InitializeComponent();
        }
        SqlConnection con =new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nas\Documents\pen and pencil.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnaddcat_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Insert into catagoryTbl values ('" + txtcatid.Text + "','"+txtcatname.Text+ "','" + txtcatdesc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Catagory Added Successfully");
                txtcatid.Text = "";
                txtcatname.Text = "";
                txtcatdesc.Text = "";
                con.Close();
                populate();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            con.Open();
            string query = "select * from catagoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            catDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void catagory_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void catDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcatid.Text = catDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtcatname.Text = catDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtcatdesc.Text = catDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btndeletecat_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtcatid.Text == "")
                {
                    MessageBox.Show("Please Select Catagory");
                }
                else
                {
                    con.Open();
                    string query = "delete from catagoryTbl where catId = " + txtcatid.Text + "";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Catagory Deleted Successfully");
                    txtcatid.Text = "";
                    txtcatname.Text = "";
                    txtcatdesc.Text = "";
                    con.Close();
                    populate();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btneditcat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcatid.Text == "" || txtcatdesc.Text == "" || txtcatname.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else { 
                    con.Open();
                    string query = "update catagoryTbl set catName='" + txtcatname.Text + "',catDesc='" + txtcatdesc.Text + "' where catId=" + txtcatid.Text + "; ";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Catagory Updated Successfully");
                    txtcatid.Text = "";
                    txtcatname.Text = "";
                    txtcatdesc.Text = "";
                    con.Close();
                    populate();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            product prod = new product();
            prod.Show();
            this.Hide();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
