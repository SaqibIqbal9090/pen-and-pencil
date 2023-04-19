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
using System.Security.Cryptography;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace pen_and_pencil
{
    public partial class selling : Form
    {
        public selling()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nas\Documents\pen and pencil.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sellerbtn_Click(object sender, EventArgs e)
        {
            if (sellerlbl.Text == "ADMIN")
            {
                seller seller = new seller();
                seller.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied!");
            }
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            if (sellerlbl.Text == "ADMIN")
            {
                product prod = new product();
            prod.Show();
            this.Hide();
        }
            else
            {
                MessageBox.Show("Access Denied!");
            }
}

        private void btnselling_Click(object sender, EventArgs e)
        {
            if (sellerlbl.Text == "ADMIN")
            {
                catagory cat = new catagory();
                cat.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied!");
            }

            }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void prodDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            prodname.Text = prodDGV1.SelectedRows[0].Cells[1].Value.ToString();
            prodprice.Text = prodDGV1.SelectedRows[0].Cells[3].Value.ToString();
          
        }
        private void populate()
        {
            con.Open();
            string query = "select * from productTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void populatebills()
        {
            con.Open();
            string query = "select * from Billtbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            billDGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void selling_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            sellerlbl.Text = loginform.Sellername;

            date.Text = DateTime.Now.ToString();
        }

        int grndtotal = 0, n = 0;

        private void addbill_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into Billtbl values ('" + billid.Text + "','"+sellerlbl.Text+"','" + date.Text + "', '" + totalamount.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Added successfully");
            con.Close();
            populatebills();
        }

        private void btnaddprod_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(prodprice.Text) * Convert.ToInt32(prodqty.Text);
       


            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(addprodDGV);
            newRow.Cells[0].Value = n + 1;
             newRow.Cells[1].Value = prodname.Text;
            newRow.Cells[2].Value = prodprice.Text;
            newRow.Cells[3].Value = prodqty.Text;
            newRow.Cells[4].Value = Convert.ToInt32(prodprice.Text) * Convert.ToInt32(prodqty.Text);
            addprodDGV.Rows.Add(newRow);
            n++;
            prodname.Text = "";
            prodprice.Text = "";
            prodqty.Text = "";

            grndtotal = grndtotal + total;
            totalamount.Text = "RS: " + grndtotal;





        }
        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("PEN AND PENCIL", new Font("Arial", 40, FontStyle.Bold),Brushes.DarkOrange, new Point(230,15));
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(0, 60));
            e.Graphics.DrawString("Recipt", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(340, 90));
             e.Graphics.DrawString("____________________________________________________________________________", new Font("Arial", 25, FontStyle.Bold),Brushes.Black, new Point(0,110));
            e.Graphics.DrawString("Branch: Main Branch ", new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(40, 160));
            e.Graphics.DrawString("Address: Gulberg III, Lahore ", new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(40, 210));
            e.Graphics.DrawString("Bill ID : "+billDGV.SelectedRows[0].Cells[0].Value.ToString(),new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(40, 260));
            e.Graphics.DrawString("Date : " + billDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(40, 310));
            e.Graphics.DrawString("Seller : " + billDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(40, 360));
            e.Graphics.DrawString("============================================================================== : " , new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(0, 410));
            e.Graphics.DrawString("Total Amount : " + billDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(40, 460));
            e.Graphics.DrawString("Paid Amount : " + billDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(40, 510));
            e.Graphics.DrawString("Change: 0", new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(40, 560));
            e.Graphics.DrawString("============================================================================== : ", new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(0, 610));
            e.Graphics.DrawString(" THANK YOU ", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, new Point(240, 660));
            e.Graphics.DrawString("============================================================================== : ", new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(0, 710));

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform log =new loginform();
            log.Show();
        }

        private void deletebill_Click(object sender, EventArgs e)
        {
            /*
                con.Open();
                string query = "DELETE  FROM Billtbl WHERE Billid ='"+billDGV.SelectedRows+"' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill record Deleted successfully");
                con.Close();
                populatebills();*/

            
        }

 

        private void printbill_Click(object sender, EventArgs e)
        {
            if(dialog.ShowDialog()==DialogResult.OK) { }
            {
                printDocument1.Print();
            }
        }

       

       


       

    
    }
}
