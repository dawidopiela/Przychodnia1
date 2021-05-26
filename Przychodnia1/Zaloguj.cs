using MetroSet_UI.Forms;
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
using System.Configuration;

namespace Przychodnia1
{
    public partial class Zaloguj : MetroSetForm
    {
        Rejestracja rejestracja = new Rejestracja();

        //SqlConnection loginCon = new SqlConnection("Data Source=DESKTOP-H9TN478\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True");

        public Zaloguj()
        {
            InitializeComponent();
        }


        //private void zalLogin_Click(object sender, EventArgs e)
        //{

            //    SqlConnection con = new SqlConnection();  
            //public Form1()  
            //{  
            //    SqlConnection con = new SqlConnection();  
            //    con.ConnectionString = "Data Source=DESKTOP-H9TN478\SQLEXPRESS;Integrated Security=True";  

            //    InitializeComponent();  
        //}


        private void zalLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H9TN478\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            string userid = zalEmail.Text;
            string password = zalPesel.Text;
            SqlCommand cmd = new SqlCommand("select Email, Pesel from [Przychodnia].[dbo].[Pacjent] where Email='" + zalEmail.Text + "'and Pesel='" + zalPesel.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0 )
            {
                    using (Start start = new Start())
                        start.ShowDialog();
                   // MessageBox.Show("Login sucess Welcome to Homepage ");

                
               

            }
            else
            {
                MessageBox.Show("Niepoprawny login lub hasło");
            }
            con.Close();
        }









    }
}
