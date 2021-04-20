using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da lis te sigurni da zelite izaci iz aplikcaije","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void dodajeKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 dodajknjigu = new Form3();
            dodajknjigu.Show();
        }

        private void pregledajKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 pregledajknjige = new Form4();
            pregledajknjige.Show();

        }

        private void dodajStudentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 dodajstudentaa = new Form5();
            dodajstudentaa.Show();
        }

        private void studentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 studentinfo = new Form6();
            studentinfo.Show();
        }

        private void izdajKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 izdajknjigu = new Form7();
            izdajknjigu.Show();
        }

        private void vratiKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void detaljiKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }
    }
}
