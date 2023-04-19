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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nas\Documents\pen and pencil.mdf;Integrated Security=True;Connect Timeout=30");

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string Sellername;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            if (txtusername.Text =="" || txtpass.Text == "")
            {
                MessageBox.Show("Enter user name and Password");
            }
            else
            {
                
                    if (role.SelectedIndex > -1)
                    {
                        if (role.SelectedItem.ToString() == "ADMIN")
                        {
                            if (txtusername.Text == "Admin" && txtpass.Text == "Saqib123")
                            {
                            Sellername = "ADMIN";
                            product product = new product();
                            product.Show();
                            this.Hide();
                            }
                             else { MessageBox.Show("Invalid Username or Password"); }
                    
                            
                        }
                        else 
                        {
                           con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from SellerTbl where sellerName='"+txtusername.Text+"'and sellerPass='"+txtpass.Text+"'",con);
                        DataTable dt=new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString()=="1")
                        {
                            Sellername=txtusername.Text;
                            selling selling = new selling();
                            selling.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password");
                        }
                         con.Close();
                        }
                    }
                     
                }
                
                
            }

        
    }
    }

