using Npgsql;
using PostgresConnectionExample;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_2024.Forms
{
    public partial class MainForm : Form
    {
        private List<string> selectedProducts;
        private double totalValue;
        private int totalQuantity;

        public MainForm()
        {
            InitializeComponent();
            selectedProducts = new List<string>();
            totalValue = 0.0;
            totalQuantity = 0;
        }

        private void showMessageBox(String txt, String title = "Atenção!")
        {
            MessageBox.Show(txt, title);
        }

        private void hideNewVenda()
        {
            btnRegistraVenda.Enabled = false;
            dataGridProdutos.Visible = false;
            dataGridProdutosSelecionados.Visible = false;
            lblQtdeProdutos.Visible = false;
            lblQtdeProdutos_valor.Visible = false;
            lblValorTotal.Visible = false;
            lblValorTotal_valor.Visible = false;
            btnRegistraVenda.Visible = false;
        }

        private void showNewVenda()
        {
            btnRegistraVenda.Enabled = true;
            dataGridProdutos.Visible = true;
            dataGridProdutosSelecionados.Visible = true;
            lblQtdeProdutos.Visible = true;
            lblQtdeProdutos_valor.Visible = true;
            lblValorTotal.Visible = true;
            lblValorTotal_valor.Visible = true;
            btnRegistraVenda.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            hideNewVenda();

                listProducts();
                CheckUserGroupAndDisableButton();
            
        }

        private void CheckUserGroupAndDisableButton()
        {
            using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
            {
                try
                {
                    string currentUser = "current_user";
                    string query = "SELECT 1 FROM pg_user u JOIN pg_group g ON u.usesysid = ANY(g.grolist) " +
                        "WHERE u.usename = current_user AND g.groname = 'grupo_funcionarios'";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            BtnCdstFuncionario.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    showMessageBox($"Erro ao verificar o grupo do usuário: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideNewVenda();

            Form cadastrarUsuarioForm = new CadastrarUsuarioForm();
            cadastrarUsuarioForm.Show();
        }

        private void listProducts()
        {
            dataGridProdutos.Columns.Clear();
            dataGridProdutos.Rows.Clear();

            dataGridProdutos.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Select", HeaderText = "Select" });
            dataGridProdutos.Columns.Add("Código", "Código");
            dataGridProdutos.Columns.Add("Descrição", "Descrição");
            dataGridProdutos.Columns.Add("Valor", "Valor");
            dataGridProdutos.Columns.Add("Estoque", "Estoque");
            dataGridProdutos.Columns.Add("Fornecedor", "Fornecedor");

            using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
            {
                using (var command = new NpgsqlCommand("SELECT * FROM tb_produtos;", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridProdutos.Rows.Add(false,
                                reader.GetInt64(0).ToString(),
                                reader.GetString(1),
                                reader.GetDouble(2).ToString(),
                                reader.GetInt16(3).ToString(),
                                reader.GetInt64(4).ToString()
                             );
                        }
                    }
                }
            }

            dataGridProdutos.CellContentClick += new DataGridViewCellEventHandler(dataGridProdutos_CellContentClick);
            dataGridProdutosSelecionados.CellValueChanged += new DataGridViewCellEventHandler(dataGridProdutosSelecionados_CellValueChanged);

            dataGridProdutosSelecionados.Columns.Clear();
            dataGridProdutosSelecionados.Rows.Clear();

            dataGridProdutosSelecionados.Columns.Add("Código", "Código");
            dataGridProdutosSelecionados.Columns.Add("Descrição", "Descrição");
            dataGridProdutosSelecionados.Columns.Add("Valor", "Valor");
            dataGridProdutosSelecionados.Columns.Add("Quantidade", "Quantidade");
        }

        private void dataGridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridProdutos.Columns["Select"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)dataGridProdutos.Rows[e.RowIndex].Cells["Select"];
                bool isChecked = (bool)checkbox.EditedFormattedValue;

                string productCode = dataGridProdutos.Rows[e.RowIndex].Cells["Código"].Value.ToString();
                double productValue = Convert.ToDouble(dataGridProdutos.Rows[e.RowIndex].Cells["Valor"].Value);

                if (isChecked)
                {
                    selectedProducts.Add(productCode);
                    AddProductToSelectedGrid(e.RowIndex);
                    totalValue += productValue;
                    totalQuantity++;
                }
                else
                {
                    DataGridViewRow existingRow = dataGridProdutosSelecionados.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(row => row.Cells["Código"].Value != null && row.Cells["Código"].Value.ToString() == productCode);

                    if (existingRow != null)
                    {
                        int currentQuantity;
                        if (existingRow.Cells["Quantidade"].Value != null)
                        {
                            currentQuantity = Convert.ToInt32(existingRow.Cells["Quantidade"].Value);
                        }
                        else
                        {
                            currentQuantity = 1;
                        }

                        if (currentQuantity > 1)
                        {
                            existingRow.Cells["Quantidade"].Value = currentQuantity - 1;
                            totalValue -= productValue;
                            totalQuantity--;
                        }
                        else
                        {
                            selectedProducts.Remove(productCode);
                            RemoveProductFromSelectedGrid(productCode);
                            totalValue -= productValue;
                            totalQuantity--;
                        }
                    }
                }

                UpdateTotalValueLabel();
                UpdateTotalQuantityLabel();
            }
        }

        private void AddProductToSelectedGrid(int rowIndex)
        {
            DataGridViewRow selectedRow = dataGridProdutos.Rows[rowIndex];
            string[] row = {
                selectedRow.Cells["Código"].Value.ToString(),
                selectedRow.Cells["Descrição"].Value.ToString(),
                selectedRow.Cells["Valor"].Value.ToString(),
                "1" // Quantidade inicial padrão
            };

            dataGridProdutosSelecionados.Rows.Add(row);
        }

        private void RemoveProductFromSelectedGrid(string productCode)
        {
            foreach (DataGridViewRow row in dataGridProdutosSelecionados.Rows)
            {
                if (row.Cells["Código"].Value.ToString() == productCode)
                {
                    dataGridProdutosSelecionados.Rows.Remove(row);
                    break;
                }
            }
        }

        private void dataGridProdutosSelecionados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridProdutosSelecionados.Columns["Quantidade"].Index && e.RowIndex >= 0)
            {
                totalValue = 0;
                totalQuantity = 0;

                foreach (DataGridViewRow row in dataGridProdutosSelecionados.Rows)
                {
                    double productValue = Convert.ToDouble(row.Cells["Valor"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantidade"].Value);
                    totalValue += productValue * quantity;
                    totalQuantity += quantity;
                }

                UpdateTotalValueLabel();
                UpdateTotalQuantityLabel();
            }
        }

        private void UpdateTotalValueLabel()
        {
            lblValorTotal_valor.Text = $"R$ {totalValue:F2}";
        }

        private void UpdateTotalQuantityLabel()
        {
            if (totalQuantity.ToString().Length > 0)
            {
                btnRegistraVenda.Enabled = true;
            }
            else
            {
                btnRegistraVenda.Enabled = false;
            }
            lblQtdeProdutos_valor.Text = totalQuantity.ToString();
        }

        private void btnRegistraVenda_Click(object sender, EventArgs e)
        {
            long venCodigo = 0;
            NpgsqlTransaction transaction = null;

            try
            {
                using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
                {
                    transaction = connection.BeginTransaction();

                    using (var command = new NpgsqlCommand("INSERT INTO tb_vendas (ven_horario, ven_valor_total) VALUES (@ven_horario, @ven_valor_total) RETURNING ven_codigo", connection))
                    {
                        double totalValue = 0.0;
                        foreach (DataGridViewRow row in dataGridProdutosSelecionados.Rows)
                        {
                            int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                            double valorUnitario = Convert.ToDouble(row.Cells["Valor"].Value);
                            double valorParcial = quantidade * valorUnitario;
                            totalValue += valorParcial;
                        }

                        command.Parameters.AddWithValue("@ven_horario", DateTime.Now);
                        command.Parameters.AddWithValue("@ven_valor_total", totalValue);
                        venCodigo = (long)command.ExecuteScalar();
                    }

                    foreach (DataGridViewRow row in dataGridProdutosSelecionados.Rows)
                    {
                        long proCodigo = Convert.ToInt64(row.Cells["Código"].Value);
                        int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                        double valorUnitario = Convert.ToDouble(row.Cells["Valor"].Value);
                        double valorParcial = quantidade * valorUnitario;

                        bool proCodigoExists;
                        using (var checkCommand = new NpgsqlCommand("SELECT COUNT(*) FROM tb_produtos WHERE pro_codigo = @pro_codigo", connection))
                        {
                            checkCommand.Parameters.AddWithValue("@pro_codigo", proCodigo);
                            proCodigoExists = (long)checkCommand.ExecuteScalar() > 0;
                        }

                        if (proCodigoExists)
                        {
                            using (var insertCommand = new NpgsqlCommand("INSERT INTO tb_vendas_itens (vite_quantidade, vite_valor_parcial, tb_produtos_pro_codigo, tb_vendas_ven_codigo) " +
                                                                         "VALUES (@quantidade, @valor_parcial, @pro_codigo, @ven_codigo)", connection))
                            {
                                insertCommand.Parameters.AddWithValue("@quantidade", quantidade);
                                insertCommand.Parameters.AddWithValue("@valor_parcial", valorParcial);
                                insertCommand.Parameters.AddWithValue("@pro_codigo", proCodigo);
                                insertCommand.Parameters.AddWithValue("@ven_codigo", venCodigo);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // throw new Exception($"Produto com código {proCodigo} não encontrado.");
                            // transaction.Rollback();
                        }
                    }

                    transaction.Commit();

                    selectedProducts.Clear();
                    dataGridProdutosSelecionados.Rows.Clear();
                    totalValue = 0.0;
                    totalQuantity = 0;
                    UpdateTotalValueLabel();
                    UpdateTotalQuantityLabel();

                    UncheckAllProductCheckboxes();

                    showMessageBox("Venda registrada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                try
                {
                    if (transaction != null)
                    {
                        if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                        {
                            transaction.Rollback();
                        }
                    }
                }
                catch (InvalidOperationException exRollback)
                {
                    showMessageBox($"Erro ao tentar fazer rollback da transação: {exRollback.Message}", "Erro");
                }
                finally
                {
                    showMessageBox($"Erro ao registrar venda: {ex.Message}", "Erro");
                }
            }
        }

        private void UncheckAllProductCheckboxes()
        {
            foreach (DataGridViewRow row in dataGridProdutos.Rows)
            {
                DataGridViewCheckBoxCell checkboxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (checkboxCell != null)
                {
                    checkboxCell.Value = false;
                }
            }
        }

        private void BtnNovaVenda_Click(object sender, EventArgs e)
        {
            showNewVenda();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hideNewVenda();
        }
    }
}
