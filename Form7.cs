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

namespace Biblioteka
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand("SELECT ImeKnjige FROM NovaKnjiga",con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while(Sdr.Read())
            {
                for (int i =0; i<Sdr.FieldCount;i++) 
                {
                    comboBox1.Items.Add(Sdr.GetString(i)); 
                }
                
            }
            con.Close();
            Sdr.Close();
        }
        int count;

        private void btnTraziStudenta_Click(object sender, EventArgs e)
        {
            if (txtbrojPrijave.Text !="") 
            {
                string edi = txtbrojPrijave.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT*FROM Studenti WHERE BrojPrijave ='"+edi+"' ";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                cmd.CommandText = "SELECT COUNT(std_brojprijave) from studentiKnjige WHERE std_brojprijave ='" + edi + "' and datum_izdavanja  is null ";
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da1.Fill(ds1);
                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtimestudenta.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtodsijek.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtsemstar.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtkontakt.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtemail.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else 
                { 
                txtimestudenta.Clear();
                    txtodsijek.Clear();
                    txtsemstar.Clear();
                    txtkontakt.Clear();
                    txtemail.Clear();
                    MessageBox.Show("Neposotojeci Broj prijave", "Upozorenje", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


            }
            
        }

        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            if (txtimestudenta.Text != "") 
            {
                if (comboBox1.SelectedIndex != -1 && count<=2) 
                {
                    String prijava = txtbrojPrijave.Text;
                    String sime = txtimestudenta.Text;
                    String sodsijek = txtodsijek.Text;
                    String ssemestar = txtsemstar.Text;
                    String semail = txtemail.Text;
                    Int64 skontakt = Int64.Parse(txtkontakt.Text);
                    String iimeknjige = comboBox1.Text;
                    String datumizdavanja = txtDatum.Text;

                    string edi = txtbrojPrijave.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "INSERT INTO studentiknjige (std_brojprijave, std_ime,std_odsijek,std_semestar,std_email, std_kontat,ime_knjige,datum_izdavanja) values('" + prijava+"','"+sime+"','"+sodsijek+"','"+ssemestar+"','"+semail+"',"+skontakt+",'"+iimeknjige+"','"+datumizdavanja+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Knjiga izdata","Uspijeh", MessageBoxButtons.OK,MessageBoxIcon.Information);


                }
            }

        }

        private void txtbrojPrijave_TextChanged(object sender, EventArgs e)
        {
            if (txtbrojPrijave.Text == "")
            {
                 txtbrojPrijave.Clear();
                 txtimestudenta.Clear();
                 txtodsijek.Clear();
                 txtsemstar.Clear();
                 txtemail.Clear();
                
                 
               

            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            txtbrojPrijave.Clear();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("da li ste sigurni da zelite izaci", "upozorenje",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes) {
                this.Close();
            }
            }
    }
}
