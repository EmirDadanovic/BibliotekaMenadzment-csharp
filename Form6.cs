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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Studenti";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        int sid;
        Int64 rowid;
        private void btnosvjezi_Click_1(object sender, EventArgs e)
        {
            txtPretrazi.Clear();
            panel2.Visible = false;

        }
        
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    sid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Studenti where studentID='" + sid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                txtimeStudenta.Text = ds.Tables[0].Rows[0][1].ToString();
                txtbrojPrijave.Text = ds.Tables[0].Rows[0][2].ToString();
                txtOdsijek.Text = ds.Tables[0].Rows[0][3].ToString();
                txtSemestar.Text = ds.Tables[0].Rows[0][4].ToString();
                txtKontakt.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();

                panel2.Visible = true;
            }
            catch(Exception a )
            {
                MessageBox.Show(a.Message);
                
            }

        }

        private void btnUredi_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Podaci o Studntu ce se promijneiti", "Potvrdite", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string imestudenta = txtimeStudenta.Text;
                string brojprijave = txtbrojPrijave.Text;
                string odsijek = txtOdsijek.Text;
                string semestar = txtSemestar.Text;
                Int64 kontakt = Int64.Parse(txtKontakt.Text);
                string email = txtEmail.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Biblioteka; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Studenti set ImeStudenta='" + imestudenta + "', BrojPrijave='" + brojprijave + "', Odsijek='" + odsijek + "', Semestar= '" + semestar + "', Kontakt =" + kontakt + ", Email='" + email + "'  where studentID= " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnIzbrisi_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Podaci o knjigi Biti izbrisani", "Potvrdite", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Biblioteka; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Studenti where studentID=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }

        }

        private void btnPonisti_Click_1(object sender, EventArgs e)
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
                cmd.CommandText = "select * from Studenti where ImeStudenta LIKE'" + txtPretrazi.Text + "%'";
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
                cmd.CommandText = "select * from Studenti";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
