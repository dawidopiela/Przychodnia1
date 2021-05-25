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
    public partial class Rejestracja : MetroSetForm: Zaloguj
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }

        private void btnzarejestruj_Click(object sender, EventArgs e)
        {
            string myconn = ConfigurationManager.ConnectionStrings["Mojepoloczenie"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(myconn);
            string sqlquery = "insert into [dbo].[Pacjent] values (@Imie, @Nazwisko, @Email, @Pesel)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn);
            sqlcomm.Parameters.AddWithValue("@Imie", rejImie.Text);
            sqlcomm.Parameters.AddWithValue("@Nazwisko", rejNazwisko.Text);
            sqlcomm.Parameters.AddWithValue("@Email", rejEmail.Text);
            sqlcomm.Parameters.AddWithValue("@Pesel", rejPesel.Text);
            sqlcomm.ExecuteNonQuery();
            rejInfo.Text ="Pomyślnie zarejestrowano";
            sqlconn.Close();
            using (Zaloguj zaloguj = new Zaloguj())
                zaloguj.ShowDialog();
        }
    }
}
