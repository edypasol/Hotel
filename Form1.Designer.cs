namespace HotelManagement
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCamere;
        private System.Windows.Forms.TabPage tabRezervari;

        private System.Windows.Forms.DataGridView dgvCamere;
        private System.Windows.Forms.TextBox txtNrCamera;
        private System.Windows.Forms.TextBox txtTipCamera;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Button btnAdaugaCamera;
        private System.Windows.Forms.Button btnModificaCamera;
        private System.Windows.Forms.Button btnStergeCamera;

        private System.Windows.Forms.DataGridView dgvRezervari;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Button btnAdaugaRezervare;
        private System.Windows.Forms.Button btnStergeRezervare;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCamere = new System.Windows.Forms.TabPage();
            this.dgvCamere = new System.Windows.Forms.DataGridView();
            this.txtNrCamera = new System.Windows.Forms.TextBox();
            this.txtTipCamera = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.btnAdaugaCamera = new System.Windows.Forms.Button();
            this.btnModificaCamera = new System.Windows.Forms.Button();
            this.btnStergeCamera = new System.Windows.Forms.Button();
            this.tabRezervari = new System.Windows.Forms.TabPage();
            this.dgvRezervari = new System.Windows.Forms.DataGridView();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnAdaugaRezervare = new System.Windows.Forms.Button();
            this.btnStergeRezervare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCamere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamere)).BeginInit();
            this.tabRezervari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervari)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCamere);
            this.tabControl1.Controls.Add(this.tabRezervari);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCamere
            // 
            this.tabCamere.Controls.Add(this.label3);
            this.tabCamere.Controls.Add(this.label2);
            this.tabCamere.Controls.Add(this.label1);
            this.tabCamere.Controls.Add(this.dgvCamere);
            this.tabCamere.Controls.Add(this.txtNrCamera);
            this.tabCamere.Controls.Add(this.txtTipCamera);
            this.tabCamere.Controls.Add(this.txtPret);
            this.tabCamere.Controls.Add(this.btnAdaugaCamera);
            this.tabCamere.Controls.Add(this.btnModificaCamera);
            this.tabCamere.Controls.Add(this.btnStergeCamera);
            this.tabCamere.Location = new System.Drawing.Point(4, 25);
            this.tabCamere.Name = "tabCamere";
            this.tabCamere.Padding = new System.Windows.Forms.Padding(3);
            this.tabCamere.Size = new System.Drawing.Size(526, 369);
            this.tabCamere.TabIndex = 0;
            this.tabCamere.Text = "Camere";
            this.tabCamere.UseVisualStyleBackColor = true;
            // 
            // dgvCamere
            // 
            this.dgvCamere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamere.Location = new System.Drawing.Point(20, 20);
            this.dgvCamere.Name = "dgvCamere";
            this.dgvCamere.RowHeadersWidth = 51;
            this.dgvCamere.Size = new System.Drawing.Size(487, 200);
            this.dgvCamere.TabIndex = 0;
            // 
            // txtNrCamera
            // 
            this.txtNrCamera.Location = new System.Drawing.Point(116, 248);
            this.txtNrCamera.Name = "txtNrCamera";
            this.txtNrCamera.Size = new System.Drawing.Size(100, 22);
            this.txtNrCamera.TabIndex = 1;
            // 
            // txtTipCamera
            // 
            this.txtTipCamera.Location = new System.Drawing.Point(116, 276);
            this.txtTipCamera.Name = "txtTipCamera";
            this.txtTipCamera.Size = new System.Drawing.Size(100, 22);
            this.txtTipCamera.TabIndex = 2;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(116, 304);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 22);
            this.txtPret.TabIndex = 3;
            // 
            // btnAdaugaCamera
            // 
            this.btnAdaugaCamera.Location = new System.Drawing.Point(240, 242);
            this.btnAdaugaCamera.Name = "btnAdaugaCamera";
            this.btnAdaugaCamera.Size = new System.Drawing.Size(100, 30);
            this.btnAdaugaCamera.TabIndex = 4;
            this.btnAdaugaCamera.Text = "Adauga";
            this.btnAdaugaCamera.Click += new System.EventHandler(this.btnAdaugaCamera_Click);
            // 
            // btnModificaCamera
            // 
            this.btnModificaCamera.Location = new System.Drawing.Point(240, 273);
            this.btnModificaCamera.Name = "btnModificaCamera";
            this.btnModificaCamera.Size = new System.Drawing.Size(100, 30);
            this.btnModificaCamera.TabIndex = 5;
            this.btnModificaCamera.Text = "Modifica";
            this.btnModificaCamera.Click += new System.EventHandler(this.btnModificaCamera_Click);
            // 
            // btnStergeCamera
            // 
            this.btnStergeCamera.Location = new System.Drawing.Point(240, 304);
            this.btnStergeCamera.Name = "btnStergeCamera";
            this.btnStergeCamera.Size = new System.Drawing.Size(100, 30);
            this.btnStergeCamera.TabIndex = 6;
            this.btnStergeCamera.Text = "Sterge";
            this.btnStergeCamera.Click += new System.EventHandler(this.btnStergeCamera_Click);
            // 
            // tabRezervari
            // 
            this.tabRezervari.Controls.Add(this.label8);
            this.tabRezervari.Controls.Add(this.label7);
            this.tabRezervari.Controls.Add(this.label6);
            this.tabRezervari.Controls.Add(this.label5);
            this.tabRezervari.Controls.Add(this.label4);
            this.tabRezervari.Controls.Add(this.dgvRezervari);
            this.tabRezervari.Controls.Add(this.txtNume);
            this.tabRezervari.Controls.Add(this.txtTelefon);
            this.tabRezervari.Controls.Add(this.cmbCamera);
            this.tabRezervari.Controls.Add(this.dtpCheckIn);
            this.tabRezervari.Controls.Add(this.dtpCheckOut);
            this.tabRezervari.Controls.Add(this.btnAdaugaRezervare);
            this.tabRezervari.Controls.Add(this.btnStergeRezervare);
            this.tabRezervari.Location = new System.Drawing.Point(4, 25);
            this.tabRezervari.Name = "tabRezervari";
            this.tabRezervari.Padding = new System.Windows.Forms.Padding(3);
            this.tabRezervari.Size = new System.Drawing.Size(526, 369);
            this.tabRezervari.TabIndex = 1;
            this.tabRezervari.Text = "Rezervari";
            this.tabRezervari.UseVisualStyleBackColor = true;
            // 
            // dgvRezervari
            // 
            this.dgvRezervari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervari.Location = new System.Drawing.Point(20, 20);
            this.dgvRezervari.Name = "dgvRezervari";
            this.dgvRezervari.RowHeadersWidth = 51;
            this.dgvRezervari.Size = new System.Drawing.Size(487, 200);
            this.dgvRezervari.TabIndex = 0;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(85, 225);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(85, 253);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 2;
            // 
            // cmbCamera
            // 
            this.cmbCamera.Location = new System.Drawing.Point(85, 281);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(100, 24);
            this.cmbCamera.TabIndex = 3;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(304, 223);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 22);
            this.dtpCheckIn.TabIndex = 4;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(304, 253);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 22);
            this.dtpCheckOut.TabIndex = 5;
            // 
            // btnAdaugaRezervare
            // 
            this.btnAdaugaRezervare.Location = new System.Drawing.Point(106, 323);
            this.btnAdaugaRezervare.Name = "btnAdaugaRezervare";
            this.btnAdaugaRezervare.Size = new System.Drawing.Size(100, 30);
            this.btnAdaugaRezervare.TabIndex = 6;
            this.btnAdaugaRezervare.Text = "Adauga";
            this.btnAdaugaRezervare.Click += new System.EventHandler(this.btnAdaugaRezervare_Click);
            // 
            // btnStergeRezervare
            // 
            this.btnStergeRezervare.Location = new System.Drawing.Point(317, 323);
            this.btnStergeRezervare.Name = "btnStergeRezervare";
            this.btnStergeRezervare.Size = new System.Drawing.Size(100, 30);
            this.btnStergeRezervare.TabIndex = 7;
            this.btnStergeRezervare.Text = "Sterge";
            this.btnStergeRezervare.Click += new System.EventHandler(this.btnStergeRezervare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Camere";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Check-In";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Check-Out";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(534, 398);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Hotel Management";
            
            this.tabControl1.ResumeLayout(false);
            this.tabCamere.ResumeLayout(false);
            this.tabCamere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamere)).EndInit();
            this.tabRezervari.ResumeLayout(false);
            this.tabRezervari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervari)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
