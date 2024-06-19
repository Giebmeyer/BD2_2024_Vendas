using System;
using System.Windows.Forms;
using Npgsql;
using PostgresConnectionExample;

namespace BD2_2024.Forms
{
    public partial class CadastrarUsuarioForm : Form
    {

        public CadastrarUsuarioForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {

        }

        private void CadastrarUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void showMessageBox(String txt, String title = "Atenção!")
        {
            MessageBox.Show(txt, title);
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

            if (String.IsNullOrEmpty(usuario))
            {
                showMessageBox("Preencha todos os campos.");
            }
            else if (String.IsNullOrEmpty(senha))
            {
                showMessageBox("Preencha todos os campos.");
            }

            try
            {
                using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
                {

                    string sql = $"CREATE USER {usuario} WITH PASSWORD '{senha}'";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    if (checkIsFuncionario.Checked)
                    {
                        sql = $"GRANT grupo_funcionarios TO {usuario}";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}");
            }
        }
    }
}
