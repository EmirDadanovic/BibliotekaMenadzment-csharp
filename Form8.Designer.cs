
namespace Biblioteka
{
    partial class Form8
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbrojprijave = new System.Windows.Forms.TextBox();
            this.txtimeknjige = new System.Windows.Forms.TextBox();
            this.txtdatumizdavanja = new System.Windows.Forms.TextBox();
            this.txtdatumvracanja = new System.Windows.Forms.DateTimePicker();
            this.btnpretrazi = new System.Windows.Forms.Button();
            this.btnrefresuj = new System.Windows.Forms.Button();
            this.btnizadji = new System.Windows.Forms.Button();
            this.btnponisti = new System.Windows.Forms.Button();
            this.btnvratiknjigu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnizadji);
            this.panel1.Controls.Add(this.btnrefresuj);
            this.panel1.Controls.Add(this.btnpretrazi);
            this.panel1.Controls.Add(this.txtbrojprijave);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 466);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.btnvratiknjigu);
            this.panel2.Controls.Add(this.btnponisti);
            this.panel2.Controls.Add(this.txtdatumvracanja);
            this.panel2.Controls.Add(this.txtdatumizdavanja);
            this.panel2.Controls.Add(this.txtimeknjige);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 204);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 466);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.Transparent;
            this.lable1.Location = new System.Drawing.Point(23, 108);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(213, 20);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Unesite broj prijave Studneta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(144, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime Knjige";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(100, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum izdavanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(107, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum vracanja";
            // 
            // txtbrojprijave
            // 
            this.txtbrojprijave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbrojprijave.Location = new System.Drawing.Point(49, 162);
            this.txtbrojprijave.Name = "txtbrojprijave";
            this.txtbrojprijave.Size = new System.Drawing.Size(168, 26);
            this.txtbrojprijave.TabIndex = 1;
            this.txtbrojprijave.TextChanged += new System.EventHandler(this.txtbrojprijave_TextChanged);
            // 
            // txtimeknjige
            // 
            this.txtimeknjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimeknjige.Location = new System.Drawing.Point(233, 38);
            this.txtimeknjige.Name = "txtimeknjige";
            this.txtimeknjige.Size = new System.Drawing.Size(330, 26);
            this.txtimeknjige.TabIndex = 4;
            // 
            // txtdatumizdavanja
            // 
            this.txtdatumizdavanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatumizdavanja.Location = new System.Drawing.Point(233, 99);
            this.txtdatumizdavanja.Name = "txtdatumizdavanja";
            this.txtdatumizdavanja.Size = new System.Drawing.Size(330, 26);
            this.txtdatumizdavanja.TabIndex = 5;
            // 
            // txtdatumvracanja
            // 
            this.txtdatumvracanja.Location = new System.Drawing.Point(233, 151);
            this.txtdatumvracanja.Name = "txtdatumvracanja";
            this.txtdatumvracanja.Size = new System.Drawing.Size(330, 20);
            this.txtdatumvracanja.TabIndex = 6;
            // 
            // btnpretrazi
            // 
            this.btnpretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnpretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpretrazi.Location = new System.Drawing.Point(75, 207);
            this.btnpretrazi.Name = "btnpretrazi";
            this.btnpretrazi.Size = new System.Drawing.Size(111, 43);
            this.btnpretrazi.TabIndex = 2;
            this.btnpretrazi.Text = "Pretrazi";
            this.btnpretrazi.UseVisualStyleBackColor = false;
            this.btnpretrazi.Click += new System.EventHandler(this.btnpretrazi_Click);
            // 
            // btnrefresuj
            // 
            this.btnrefresuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnrefresuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefresuj.Location = new System.Drawing.Point(27, 303);
            this.btnrefresuj.Name = "btnrefresuj";
            this.btnrefresuj.Size = new System.Drawing.Size(88, 35);
            this.btnrefresuj.TabIndex = 3;
            this.btnrefresuj.Text = "refresuj";
            this.btnrefresuj.UseVisualStyleBackColor = false;
            this.btnrefresuj.Click += new System.EventHandler(this.btnrefresuj_Click);
            // 
            // btnizadji
            // 
            this.btnizadji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnizadji.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnizadji.Location = new System.Drawing.Point(142, 303);
            this.btnizadji.Name = "btnizadji";
            this.btnizadji.Size = new System.Drawing.Size(94, 35);
            this.btnizadji.TabIndex = 4;
            this.btnizadji.Text = "Izadji";
            this.btnizadji.UseVisualStyleBackColor = false;
            this.btnizadji.Click += new System.EventHandler(this.btnizadji_Click);
            // 
            // btnponisti
            // 
            this.btnponisti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnponisti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnponisti.Location = new System.Drawing.Point(630, 117);
            this.btnponisti.Name = "btnponisti";
            this.btnponisti.Size = new System.Drawing.Size(192, 42);
            this.btnponisti.TabIndex = 7;
            this.btnponisti.Text = "Ponisti";
            this.btnponisti.UseVisualStyleBackColor = false;
            this.btnponisti.Click += new System.EventHandler(this.btnponisti_Click);
            // 
            // btnvratiknjigu
            // 
            this.btnvratiknjigu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnvratiknjigu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvratiknjigu.Location = new System.Drawing.Point(630, 41);
            this.btnvratiknjigu.Name = "btnvratiknjigu";
            this.btnvratiknjigu.Size = new System.Drawing.Size(192, 40);
            this.btnvratiknjigu.TabIndex = 8;
            this.btnvratiknjigu.Text = "Vrati Knjigu";
            this.btnvratiknjigu.UseVisualStyleBackColor = false;
            this.btnvratiknjigu.Click += new System.EventHandler(this.btnvratiknjigu_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1024, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnizadji;
        private System.Windows.Forms.Button btnrefresuj;
        private System.Windows.Forms.Button btnpretrazi;
        private System.Windows.Forms.TextBox txtbrojprijave;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnvratiknjigu;
        private System.Windows.Forms.Button btnponisti;
        private System.Windows.Forms.DateTimePicker txtdatumvracanja;
        private System.Windows.Forms.TextBox txtdatumizdavanja;
        private System.Windows.Forms.TextBox txtimeknjige;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}