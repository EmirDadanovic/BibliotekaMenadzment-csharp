
namespace Biblioteka
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajeKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajStudentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izdajKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vratiKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaljiKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem,
            this.studentiToolStripMenuItem,
            this.izdajKnjigeToolStripMenuItem,
            this.vratiKnjigeToolStripMenuItem,
            this.detaljiKnjigaToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 62);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajeKnjigeToolStripMenuItem,
            this.pregledajKnjigeToolStripMenuItem});
            this.knjigeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("knjigeToolStripMenuItem.Image")));
            this.knjigeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(134, 58);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // dodajeKnjigeToolStripMenuItem
            // 
            this.dodajeKnjigeToolStripMenuItem.Name = "dodajeKnjigeToolStripMenuItem";
            this.dodajeKnjigeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dodajeKnjigeToolStripMenuItem.Text = "Dodaje knjige ";
            this.dodajeKnjigeToolStripMenuItem.Click += new System.EventHandler(this.dodajeKnjigeToolStripMenuItem_Click);
            // 
            // pregledajKnjigeToolStripMenuItem
            // 
            this.pregledajKnjigeToolStripMenuItem.Name = "pregledajKnjigeToolStripMenuItem";
            this.pregledajKnjigeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pregledajKnjigeToolStripMenuItem.Text = "Pregledaj knjige";
            this.pregledajKnjigeToolStripMenuItem.Click += new System.EventHandler(this.pregledajKnjigeToolStripMenuItem_Click);
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajStudentaToolStripMenuItem,
            this.studentInfoToolStripMenuItem});
            this.studentiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentiToolStripMenuItem.Image")));
            this.studentiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(120, 58);
            this.studentiToolStripMenuItem.Text = "Studenti ";
            // 
            // dodajStudentaToolStripMenuItem
            // 
            this.dodajStudentaToolStripMenuItem.Name = "dodajStudentaToolStripMenuItem";
            this.dodajStudentaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dodajStudentaToolStripMenuItem.Text = "Dodaj Studenta";
            this.dodajStudentaToolStripMenuItem.Click += new System.EventHandler(this.dodajStudentaToolStripMenuItem_Click);
            // 
            // studentInfoToolStripMenuItem
            // 
            this.studentInfoToolStripMenuItem.Name = "studentInfoToolStripMenuItem";
            this.studentInfoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.studentInfoToolStripMenuItem.Text = "Student info ";
            this.studentInfoToolStripMenuItem.Click += new System.EventHandler(this.studentInfoToolStripMenuItem_Click);
            // 
            // izdajKnjigeToolStripMenuItem
            // 
            this.izdajKnjigeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("izdajKnjigeToolStripMenuItem.Image")));
            this.izdajKnjigeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.izdajKnjigeToolStripMenuItem.Name = "izdajKnjigeToolStripMenuItem";
            this.izdajKnjigeToolStripMenuItem.Size = new System.Drawing.Size(135, 58);
            this.izdajKnjigeToolStripMenuItem.Text = "Izdaj knjige ";
            this.izdajKnjigeToolStripMenuItem.Click += new System.EventHandler(this.izdajKnjigeToolStripMenuItem_Click);
            // 
            // vratiKnjigeToolStripMenuItem
            // 
            this.vratiKnjigeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vratiKnjigeToolStripMenuItem.Image")));
            this.vratiKnjigeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vratiKnjigeToolStripMenuItem.Name = "vratiKnjigeToolStripMenuItem";
            this.vratiKnjigeToolStripMenuItem.Size = new System.Drawing.Size(133, 58);
            this.vratiKnjigeToolStripMenuItem.Text = "Vrati Knjige";
            this.vratiKnjigeToolStripMenuItem.Click += new System.EventHandler(this.vratiKnjigeToolStripMenuItem_Click);
            // 
            // detaljiKnjigaToolStripMenuItem
            // 
            this.detaljiKnjigaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detaljiKnjigaToolStripMenuItem.Image")));
            this.detaljiKnjigaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detaljiKnjigaToolStripMenuItem.Name = "detaljiKnjigaToolStripMenuItem";
            this.detaljiKnjigaToolStripMenuItem.Size = new System.Drawing.Size(144, 58);
            this.detaljiKnjigaToolStripMenuItem.Text = "Detalji knjiga ";
            this.detaljiKnjigaToolStripMenuItem.Click += new System.EventHandler(this.detaljiKnjigaToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.izlazToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("izlazToolStripMenuItem.Image")));
            this.izlazToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(95, 58);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 622);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajeKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajStudentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izdajKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vratiKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaljiKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}