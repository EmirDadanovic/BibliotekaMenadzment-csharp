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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NovaKnjiga";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int kid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
         
        {
           
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null) 
            {
                
                kid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NovaKnjiga where knjigaID='"+kid+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            
            txtimeKnjige.Text = ds.Tables[0].Rows[0][1].ToString();
            txtimeAutora.Text = ds.Tables[0].Rows[0][2].ToString();
            txtimeIzdavaca.Text = ds.Tables[0].Rows[0][3].ToString();
            txtDatum.Text = ds.Tables[0].Rows[0][4].ToString();
            txtCijena.Text = ds.Tables[0].Rows[0][5].ToString();
            txtKolicina.Text = ds.Tables[0].Rows[0][6].ToString();

            panel2.Visible = true;
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
           panel2.Visible = false;
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            if (txtPretrazi.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NovaKnjiga where ImeKnjige LIKE'"+txtPretrazi.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else 
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NovaKnjiga";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnosvjezi_Click(object sender, EventArgs e)
        {
            txtPretrazi.Clear();
            panel2.Visible = false;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Podaci o knjigi ce se promijneiti","Potvrdite",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK) 
            {
                string imeknjige = txtimeKnjige.Text;
                string imeautora = txtimeAutora.Text;
                string imeizdavaca = txtimeIzdavaca.Text;
                string datum = txtDatum.Text;
                Int64 cijena = Int64.Parse(txtCijena.Text);
                Int64 kolicina = Int64.Parse(txtKolicina.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Biblioteka; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update NovaKnjiga set ImeKnjige='" + imeknjige + "', ImeAutora='" + imeautora + "', ImeIzdavaca='" + imeizdavaca + "', Datum= '" + datum + "', Cijena =" + cijena + ",Kolicina =" + kolicina + " where knjigaID= " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Podaci o knjigi Biti izbrisani", "Potvrdite", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Biblioteka; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from NovaKnjiga where knjigaID=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
