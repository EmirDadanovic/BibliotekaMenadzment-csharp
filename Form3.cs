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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsacuvaj_Click(object sender, EventArgs e)
        {
            if (txtImeKnjige.Text!="" && txtImeAutora.Text!="" && txtIzdavac.Text!=""&& txtCijena.Text!=""&&txtDatum.Text!="" &txtKolicina.Text!= "") {
                String imeknjige = txtImeKnjige.Text;
                String imeautora = txtImeAutora.Text;
                String izdavac = txtIzdavac.Text;
                String datum = txtDatum.Text;
                Int64 cijena = Int64.Parse(txtCijena.Text);
                Int64 kolicina = Int64.Parse(txtKolicina.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT INTO NovaKnjiga (ImeKnjige,ImeAutora,ImeIzdavaca,Datum,Cijena,Kolicina) values('" + imeknjige + "','" + imeautora + "','" + izdavac + "','" + datum + "'," + cijena + "," + kolicina + ")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Podaci sacuvani", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtImeKnjige.Clear();
                txtImeAutora.Clear();
                txtIzdavac.Clear();
                txtCijena.Clear();
                txtKolicina.Clear();
            }
            else
            {
                MessageBox.Show("Ispunite sva Polja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonponisti_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ova akcija ce izbrisati nesacuvane Podatke","Dali ste sigurni",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) ==  DialogResult.OK) {
                this.Close();
            }
            }
    }
}
