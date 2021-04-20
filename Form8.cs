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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnpretrazi_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
           
            cmd.CommandText="SELECT * FROM studentiknjige where std_brojprijave ='"+txtbrojprijave.Text+"' and datum_vracanja IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Pogresan broj prijave","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtbrojprijave.Clear();
        }
        string imeknjige;
        string datumzidavanja;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) 
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                imeknjige = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                datumzidavanja = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

                txtimeknjige.Text = imeknjige;
                txtdatumizdavanja.Text = datumzidavanja;
            }

        }

        private void btnvratiknjigu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Biblioteka;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update studentiknjige set datum_vracanja='"+txtdatumvracanja+"' where std_brojprijave='"+txtbrojprijave.Text+"' and id = "+rowid+"";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnrefresuj_Click(object sender, EventArgs e)
        {
            txtbrojprijave.Clear();
        }

        private void btnizadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnponisti_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtbrojprijave_TextChanged(object sender, EventArgs e)
        {
            if (txtbrojprijave.Text == "") 
            {
                dataGridView1.DataSource = null;
            }
        }
    }
}
