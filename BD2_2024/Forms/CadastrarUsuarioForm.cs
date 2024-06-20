using System;
using System.Data;
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
            LoadGroups();
        }

        private void InitializeControls()
        {
        }

        private void CadastrarUsuarioForm_Load(object sender, EventArgs e)
        {
            LoadGroups();
            LoadUsers();
        }

        private void LoadGroups()
        {
            try
            {
                using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
                {
                    bool hasAdminGroupPermission = false;

                    // Verifica se o usuário atual tem permissão para inserir no grupo_administradores
                    string checkPermissionSql = @"
                SELECT has_table_privilege(current_user, 'pg_auth_members', 'INSERT')";

                    using (NpgsqlCommand checkPermissionCmd = new NpgsqlCommand(checkPermissionSql, connection))
                    {
                        hasAdminGroupPermission = (bool)checkPermissionCmd.ExecuteScalar();
                    }

                    string loadGroupsSql = "SELECT DISTINCT rolname FROM pg_roles WHERE rolcanlogin = false AND rolname LIKE 'grupo_%'";

                    using (NpgsqlCommand loadGroupsCmd = new NpgsqlCommand(loadGroupsSql, connection))
                    {
                        using (NpgsqlDataReader reader = loadGroupsCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string groupName = reader.GetString(0);

                                // Verifica se o grupo é grupo_administradores e se o usuário tem permissão
                                if (groupName == "grupo_administradores" && !hasAdminGroupPermission)
                                {
                                    continue; // Não adiciona o grupo_administradores se não tiver permissão
                                }

                                comboGrupos.Items.Add(groupName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar grupos: {ex.Message}");
            }
        }


        private void LoadUsers()
        {
            try
            {
                using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
                {
                    string loadUsersSql = @"
                        SELECT u.usename AS Usuario, r.rolname AS Grupo
                        FROM pg_user u
                        LEFT JOIN pg_auth_members m ON u.usesysid = m.member
                        LEFT JOIN pg_roles r ON m.roleid = r.oid
                        WHERE r.rolname IS NOT NULL";

                    using (NpgsqlCommand loadUsersCmd = new NpgsqlCommand(loadUsersSql, connection))
                    {
                        using (NpgsqlDataReader reader = loadUsersCmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            gridUsuarios.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}");
            }
        }

        private void showMessageBox(string txt, string title = "Atenção!")
        {
            MessageBox.Show(txt, title);
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;
            string grupoSelecionado = comboGrupos.SelectedItem?.ToString();

            if (String.IsNullOrEmpty(usuario))
            {
                showMessageBox("Preencha todos os campos.");
                return;
            }
            if (String.IsNullOrEmpty(senha))
            {
                showMessageBox("Preencha todos os campos.");
                return;
            }
            if (String.IsNullOrEmpty(grupoSelecionado))
            {
                showMessageBox("Selecione um grupo.");
                return;
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

                    sql = $"GRANT {grupoSelecionado} TO {usuario}";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuário cadastrado com sucesso!");

                    txt_usuario.ResetText();
                    txt_senha.ResetText();
                    comboGrupos.ResetText();

                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}");
            }
        }
    }
}
