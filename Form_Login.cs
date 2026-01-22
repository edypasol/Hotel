using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin";

            if (txtUser.Text == user && txtPass.Text == pass)
            {
                // Deschide Form1
                Form1 main = new Form1();
                main.Show();

                // Ascunde login-ul
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username sau parola incorecte!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
