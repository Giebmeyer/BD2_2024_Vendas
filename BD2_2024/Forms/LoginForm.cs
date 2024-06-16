using BD2_2024.Forms;
using PostgresConnectionExample;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BD2_2024
{
    public partial class Login : Form
    {

        private void showMessageBox(String txt, String title = "Atenção!")
        {
            MessageBox.Show(txt,title);
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var txtUsuario = txtBoxLoginUsuario.Text;
            var txtSenha = txtBoxLoginSenha.Text;
            int port = 3307;

            if (String.IsNullOrEmpty(txtUsuario))
            {
                showMessageBox("Preencha todos os campos.");
            }
            else if (String.IsNullOrEmpty(txtSenha))
            {
                showMessageBox("Preencha todos os campos.");
            } 
            else
            { 
                try
                {
                    var connectionString = $"Host=127.0.0.1;Port={port};Username={txtUsuario};Password={txtSenha};Database=mySales";
                    var database = DatabasePostgresConnection.GetInstance(connectionString);
                    
                    this.Hide();

                    Form mainForm = new MainForm();
                    mainForm.Show();
                }
                catch (Exception ex)
                {
                    showMessageBox($"Erro ao tentar inicializar a conexão: {ex.Message}");
                }

                
            }

        }

    }
 
}
