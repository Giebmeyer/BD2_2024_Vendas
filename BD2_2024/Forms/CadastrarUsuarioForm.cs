using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using PostgresConnectionExample;

namespace BD2_2024.Forms
{
    public partial class CadastrarUsuarioForm : Form
    {
        private bool isAdmin = false;

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
            gridUsuarios.CellContentClick += new DataGridViewCellEventHandler(gridUsuarios_CellContentClick);

            CheckAdminPrivileges();
            LoadGroups();
            LoadUsers();
        }

        private void CheckAdminPrivileges()
        {
            try
            {
                using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
                {
                    string checkAdminSql = @"
                SELECT 
                    EXISTS (
                        SELECT 1
                        FROM pg_roles
                        WHERE pg_has_role(current_user::regrole, oid, 'member')
                        AND rolname = 'grupo_administradores'
                    )
                    OR
                    (
                        SELECT rolsuper FROM pg_roles WHERE rolname = current_user
                    ) AS is_admin";

                    using (NpgsqlCommand checkAdminCmd = new NpgsqlCommand(checkAdminSql, connection))
                    {
                        object result = checkAdminCmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            isAdmin = Convert.ToBoolean(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar privilégios de administrador: {ex.Message}");
            }
        }


        private void LoadGroups()
        {
            try
            {
                using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
                {
                    string loadGroupsSql = "SELECT DISTINCT rolname FROM pg_roles WHERE rolname LIKE 'grupo_%'";

                    using (NpgsqlCommand loadGroupsCmd = new NpgsqlCommand(loadGroupsSql, connection))
                    {
                        using (NpgsqlDataReader reader = loadGroupsCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string groupName = reader.GetString(0);

                                if (groupName == "grupo_administradores" && !isAdmin)
                                {
                                    continue;
                                }

                                if (!comboGrupos.Items.Contains(groupName))
                                {
                                    comboGrupos.Items.Add(groupName);

                                }

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
                    SELECT u.usename AS Usuario, r.rolname AS Grupo,
                           has_table_privilege(u.usename, 'tb_produtos', 'INSERT') AS PodeCadastrarProduto
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

                            gridUsuarios.DataSource = null;
                            gridUsuarios.Columns.Clear();
                            gridUsuarios.AutoGenerateColumns = false;

                            gridUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                            {
                                DataPropertyName = "Usuario",
                                HeaderText = "Usuário",
                                Name = "Usuario"
                            });

                            gridUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                            {
                                DataPropertyName = "Grupo",
                                HeaderText = "Grupo",
                                Name = "Grupo"
                            });

                            if (isAdmin)
                            {
                                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn
                                {
                                    DataPropertyName = "PodeCadastrarProduto",
                                    HeaderText = "Pode cadastrar produtos",
                                    Name = "PodeCadastrarProduto"
                                };
                                gridUsuarios.Columns.Add(checkboxColumn);
                            }

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

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gridUsuarios.Columns["PodeCadastrarProduto"].Index)
            {
                string usuario = gridUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                bool podeInserir = (bool)gridUsuarios.Rows[e.RowIndex].Cells["PodeCadastrarProduto"].EditedFormattedValue;

                try
                {
                    using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
                    {
                        string sql;

                        if (podeInserir)
                        {
                            sql = $"REVOKE INSERT ON tb_produtos FROM {usuario}";
                        }
                        else
                        {
                            sql = $"GRANT INSERT ON tb_produtos TO {usuario}";
                        }

                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        LoadUsers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar permissão de inserção: {ex.Message}");
                }
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;
            string grupoSelecionado = comboGrupos.SelectedItem?.ToString();

            if (String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(senha) || String.IsNullOrEmpty(grupoSelecionado))
            {
                showMessageBox("Preencha todos os campos.");
                return;
            }

            try
            {
                using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
                {
                    string sql = $"CREATE ROLE {usuario} LOGIN PASSWORD '{senha}' IN ROLE {grupoSelecionado}";
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
