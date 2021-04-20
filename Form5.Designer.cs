
namespace Biblioteka
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtimeStudenta = new System.Windows.Forms.TextBox();
            this.txtbrojPrijave = new System.Windows.Forms.TextBox();
            this.txtOdsijek = new System.Windows.Forms.TextBox();
            this.txtSemestar = new System.Windows.Forms.TextBox();
            this.txtbrojTelefona = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnosvejzi = new System.Windows.Forms.Button();
            this.btnsacuvaj = new System.Windows.Forms.Button();
            this.btnizadji = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(28, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 154);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(168, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Novi Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime Studenta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj Prijave";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Odsijek";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Semestar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 406);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Broj Telefona";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 467);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "E-mail";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtimeStudenta
            // 
            this.txtimeStudenta.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtimeStudenta.Location = new System.Drawing.Point(186, 190);
            this.txtimeStudenta.Name = "txtimeStudenta";
            this.txtimeStudenta.Size = new System.Drawing.Size(225, 26);
            this.txtimeStudenta.TabIndex = 7;
            // 
            // txtbrojPrijave
            // 
            this.txtbrojPrijave.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtbrojPrijave.Location = new System.Drawing.Point(186, 246);
            this.txtbrojPrijave.Name = "txtbrojPrijave";
            this.txtbrojPrijave.Size = new System.Drawing.Size(225, 26);
            this.txtbrojPrijave.TabIndex = 8;
            // 
            // txtOdsijek
            // 
            this.txtOdsijek.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtOdsijek.Location = new System.Drawing.Point(186, 303);
            this.txtOdsijek.Name = "txtOdsijek";
            this.txtOdsijek.Size = new System.Drawing.Size(225, 26);
            this.txtOdsijek.TabIndex = 9;
            // 
            // txtSemestar
            // 
            this.txtSemestar.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtSemestar.Location = new System.Drawing.Point(186, 355);
            this.txtSemestar.Name = "txtSemestar";
            this.txtSemestar.Size = new System.Drawing.Size(225, 26);
            this.txtSemestar.TabIndex = 10;
            // 
            // txtbrojTelefona
            // 
            this.txtbrojTelefona.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtbrojTelefona.Location = new System.Drawing.Point(186, 406);
            this.txtbrojTelefona.Name = "txtbrojTelefona";
            this.txtbrojTelefona.Size = new System.Drawing.Size(225, 26);
            this.txtbrojTelefona.TabIndex = 11;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtemail.Location = new System.Drawing.Point(186, 467);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(225, 26);
            this.txtemail.TabIndex = 12;
            // 
            // btnosvejzi
            // 
            this.btnosvejzi.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnosvejzi.Location = new System.Drawing.Point(28, 585);
            this.btnosvejzi.Name = "btnosvejzi";
            this.btnosvejzi.Size = new System.Drawing.Size(149, 39);
            this.btnosvejzi.TabIndex = 13;
            this.btnosvejzi.Text = "Osvjezi";
            this.btnosvejzi.UseVisualStyleBackColor = false;
            this.btnosvejzi.Click += new System.EventHandler(this.btnosvejzi_Click);
            // 
            // btnsacuvaj
            // 
            this.btnsacuvaj.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnsacuvaj.Location = new System.Drawing.Point(196, 585);
            this.btnsacuvaj.Name = "btnsacuvaj";
            this.btnsacuvaj.Size = new System.Drawing.Size(139, 39);
            this.btnsacuvaj.TabIndex = 14;
            this.btnsacuvaj.Text = "Sacuvaj";
            this.btnsacuvaj.UseVisualStyleBackColor = false;
            this.btnsacuvaj.Click += new System.EventHandler(this.btnsacuvaj_Click);
            // 
            // btnizadji
            // 
            this.btnizadji.BackColor = System.Drawing.Color.Crimson;
            this.btnizadji.Location = new System.Drawing.Point(355, 585);
            this.btnizadji.Name = "btnizadji";
            this.btnizadji.Size = new System.Drawing.Size(145, 39);
            this.btnizadji.TabIndex = 15;
            this.btnizadji.Text = "Izadji";
            this.btnizadji.UseVisualStyleBackColor = false;
            this.btnizadji.Click += new System.EventHandler(this.btnizadji_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(522, 709);
            this.Controls.Add(this.btnizadji);
            this.Controls.Add(this.btnsacuvaj);
            this.Controls.Add(this.btnosvejzi);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtbrojTelefona);
            this.Controls.Add(this.txtSemestar);
            this.Controls.Add(this.txtOdsijek);
            this.Controls.Add(this.txtbrojPrijave);
            this.Controls.Add(this.txtimeStudenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtimeStudenta;
        private System.Windows.Forms.TextBox txtbrojPrijave;
        private System.Windows.Forms.TextBox txtOdsijek;
        private System.Windows.Forms.TextBox txtSemestar;
        private System.Windows.Forms.TextBox txtbrojTelefona;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnosvejzi;
        private System.Windows.Forms.Button btnsacuvaj;
        private System.Windows.Forms.Button btnizadji;
    }
}