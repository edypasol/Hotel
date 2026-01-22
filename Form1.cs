using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Lista pentru camere
        List<Camera> camere = new List<Camera>();

        // Lista pentru rezervari
        List<Rezervare> rezervari = new List<Rezervare>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            IncarcaDate();
            RefreshCamere();
            RefreshRezervari();
        }

        private void IncarcaDate()
        {
            // Adaugam cateva camere de test
            //camere.Add(new Camera { NrCamera = 101, Tip = "Single", Pret = 120 });
            //camere.Add(new Camera { NrCamera = 102, Tip = "Double", Pret = 180 });
            //camere.Add(new Camera { NrCamera = 201, Tip = "Suite", Pret = 320 });

            // Afisare in DataGridView
            dgvCamere.DataSource = null;
            dgvCamere.DataSource = camere;

            // ComboBox camere pentru rezervari
            cmbCamera.DataSource = camere;
            cmbCamera.DisplayMember = "NrCamera";
            cmbCamera.ValueMember = "NrCamera";

            // Afisare rezervari
            dgvRezervari.DataSource = null;
            dgvRezervari.DataSource = rezervari;
        }

        private void btnAdaugaCamera_Click(object sender, EventArgs e)
        {
            Camera c = new Camera
            {
                NrCamera = int.Parse(txtNrCamera.Text),
                Tip = txtTipCamera.Text,
                Pret = decimal.Parse(txtPret.Text)
            };

            camere.Add(c);
            RefreshCamere();
        }

        private void btnModificaCamera_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(txtNrCamera.Text);
            var camera = camere.FirstOrDefault(x => x.NrCamera == nr);

            if (camera != null)
            {
                camera.Tip = txtTipCamera.Text;
                camera.Pret = decimal.Parse(txtPret.Text);
                RefreshCamere();
            }
        }

        private void btnStergeCamera_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(txtNrCamera.Text);
            var camera = camere.FirstOrDefault(x => x.NrCamera == nr);

            if (camera != null)
            {
                camere.Remove(camera);
                RefreshCamere();
            }
        }

        private void RefreshCamere()
        {
            dgvCamere.DataSource = null;
            dgvCamere.DataSource = camere;

            cmbCamera.DataSource = null;
            cmbCamera.DataSource = camere;
            cmbCamera.DisplayMember = "NrCamera";
            cmbCamera.ValueMember = "NrCamera";
        }

        private void btnAdaugaRezervare_Click(object sender, EventArgs e)
        {
            Rezervare r = new Rezervare
            {
                Nume = txtNume.Text,
                Telefon = txtTelefon.Text,
                NrCamera = int.Parse(cmbCamera.SelectedValue.ToString()),
                CheckIn = dtpCheckIn.Value,
                CheckOut = dtpCheckOut.Value
            };

            rezervari.Add(r);
            RefreshRezervari();
        }

        private void btnStergeRezervare_Click(object sender, EventArgs e)
        {
            if (dgvRezervari.CurrentRow != null)
            {
                Rezervare r = dgvRezervari.CurrentRow.DataBoundItem as Rezervare;
                rezervari.Remove(r);
                RefreshRezervari();
            }
        }

        private void RefreshRezervari()
        {
            dgvRezervari.DataSource = null;
            dgvRezervari.DataSource = rezervari;
        }

        
    }

    public class Camera
    {
        public int NrCamera { get; set; }
        public string Tip { get; set; }
        public decimal Pret { get; set; }
    }

    public class Rezervare
    {
        public string Nume { get; set; }
        public string Telefon { get; set; }
        public int NrCamera { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
