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
        public Zaloguj()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();  
       
        {  
            SqlConnection con = new SqlConnection();  
            con.ConnectionString = "Data Source=DESKTOP-H9TN478\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";  
  
            InitializeComponent();  
        }  
  
    string myconn = ConfigurationManager.ConnectionStrings["Mojepoloczenie"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(myconn);
            string sqlquery = "select * from [dbo].[Pacjent] where values (@Email, @Pesel)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn);
             sqlcomm.Parameters.AddWithValue("@Email", zalEmail.Text);
            sqlcomm.Parameters.AddWithValue("@Pesel", zalPesel.Text);
            sqlcomm.ExecuteNonQuery();
           
            sqlconn.Close();
            using (Zaloguj zaloguj = new Zaloguj())
                zaloguj.ShowDialog();

            
        
        public static string welcomeuser = "";
        private void zalLogin_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();  
            con.ConnectionString = "Data Source=DESKTOP-H9TN478\SQLEXPRESS;Integrated Security=True";  
            con.Open();  
            string userid = zalEmail.Text;  
            string password = zalPesel.Text;  
            SqlCommand cmd = new SqlCommand("select userid,password from Email where userid='" + zalEmail.Text + "'and password='" + zalPesel.Text + "'", con);  
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable();  
            da.Fill(dt);  
            if (dt.Rows.Count > 0  )  
            {  
                Start ss = new Start();
                        this.Hide();
                        ss.Show();
            }  
            else  
            {  
                MessageBox.Show("Invalid Login please check username and password");  
            }  
            con.Close();  
        }  
  

          
        
    }
}
