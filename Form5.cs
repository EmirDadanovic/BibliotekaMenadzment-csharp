using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnosvejzi_Click(object sender, EventArgs e)
        {
            txtbrojPrijave.Clear();
            txtemail.Clear();
            txtbrojTelefona.Clear();
            txtimeStudenta.Clear();
            txtOdsijek.Clear();
            txtSemestar.Clear();


        }

        private void btnsacuvaj_Click(object sender, EventArgs e)
        {
            if (txtbrojPrijave.Text != "" && txtemail.Text!="" && txtbrojTelefona.Text!="" && txtimeStudenta.Text!=""&&txtOdsijek.Text!=""&& txtSemestar.Text!="") {
                string imeStudenta = txtimeStudenta.Text;
            string email = txtemail.Text;
             Int64 brojtelefona = Int64.Parse(txtbrojTelefona.Text);
            string brojprijave = txtbrojPrijave.Text;
            string odsijek = txtOdsijek.Text;
            string semestar = txtSemestar.Text;

            
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT into Studenti (ImeStudenta, BrojPrijave, Odsijek, Semestar, Kontakt,Email) values('" + imeStudenta + "', '" + brojprijave + "','" + odsijek + "','" + semestar + "'," + brojtelefona + ",'" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uspjesno Ste Unijeli novog Studenta", "Operacija uspjesno Izvrsena", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else 
            {
                MessageBox.Show("Molimo Ispunite Sva Polja","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private void btnizadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
