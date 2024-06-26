﻿using BD2_2024.models;
using Npgsql;
using PostgresConnectionExample;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Diagnostics;

namespace BD2_2024.Forms
{
    public partial class MainForm : Form
    {
        private List<string> selectedProducts;
        private double totalValue;
        private int totalQuantity;
        private int salesCounter;

        public MainForm()
        {
            InitializeComponent();
            buildMainForm();
            selectedProducts = new List<string>();
            totalValue = 0.0;
            totalQuantity = 0;
            salesCounter = 0;
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

                lblTitulo.Text = "Adicionar venda";
                hideNewProduct();
                listProducts();
                CheckUserGroupAndDisableButton();
            
        }

        private void hideNewProduct()
        {
           // btnCadastrar.Visible = false;
          //  lblDesc.Visible = false;
            //lblEstoque.Visible = false;
            //label2.Visible = false;
            //txtDescricao.Visible = false;
            //txtEstoque.Visible = false;
            //txtPreco.Visible = false;
        }

        private void showNewProduct()
        {
            //  btnCadastrar.Visible = true;
            //  lblDesc.Visible = true;
            //  lblEstoque.Visible = true;
            //  label2.Visible = true;
            //  txtDescricao.Visible = true;
            //  txtEstoque.Visible = true;
            //  txtPreco.Visible = true;
        }

        private void AddProductToSelectedGrid(int rowIndex)
        {
            DataGridViewRow selectedRow = dataGridProdutos.Rows[rowIndex];
            string productCode = selectedRow.Cells["Código"].Value.ToString();

            var existingRow = dataGridProdutosSelecionados.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells["Código"].Value != null && row.Cells["Código"].Value.ToString() == productCode);

            if (existingRow != null)
            {
                if (existingRow.Cells["Quantidade"].Value == null || existingRow.Cells["Quantidade"].Value == DBNull.Value)
                {
                    existingRow.Cells["Quantidade"].Value = 1;
                }
                else
                {
                    int currentQuantity;
                    if (int.TryParse(existingRow.Cells["Quantidade"].Value.ToString(), out currentQuantity))
                    {
                        existingRow.Cells["Quantidade"].Value = currentQuantity + 1;
                    }
                    else
                    {
                        throw new InvalidCastException("Valor da quantidade não é um número válido.");
                    }
                }
            }
            else
            {
                string[] row = {
            selectedRow.Cells["Código"].Value.ToString(),
            selectedRow.Cells["Descrição"].Value.ToString(),
            selectedRow.Cells["Valor"].Value.ToString(),
            "1", 
            selectedRow.Cells["Estoque"].Value.ToString()
        };

                dataGridProdutosSelecionados.Rows.Add(row);
            }
        }

        private void CheckUserGroupAndDisableButton()
        {
            using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
            {
                try
                {
                    string query = "SELECT has_table_privilege(current_user, 'tb_produtos', 'INSERT') AS podeCriarProduto";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool canInsertProducts = reader.GetBoolean(0);
                                //Estoura erro na tela de remover!!!
                                //BtnNovoProduto.Enabled = canInsertProducts;
                            }
                        }
                    }

                    query = "SELECT has_table_privilege(current_user, 'tb_funcionarios', 'INSERT') AS podeCriarFuncionarios";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool podeCriarFuncionarios = reader.GetBoolean(0);

                                BtnCdstFuncionario.Enabled = podeCriarFuncionarios;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    showMessageBox($"Erro ao verificar permissões do usuário: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                using (var command = new NpgsqlCommand("SELECT * FROM tb_produtos ORDER BY pro_codigo ASC;", connection))
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
            dataGridProdutosSelecionados.Columns.Add("Estoque", "Estoque");

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
                        int currentQuantity = Convert.ToInt32(existingRow.Cells["Quantidade"].Value);

                        if (currentQuantity > 1)
                        {
                            existingRow.Cells["Quantidade"].Value = currentQuantity - 1;
                            totalValue -= productValue;
                            totalQuantity--;
                        }
                        else
                        {
                            dataGridProdutosSelecionados.Rows.Remove(existingRow);
                            totalValue -= productValue;
                            totalQuantity--;
                        }
                    }
                }

                UpdateTotalValueLabel();
                UpdateTotalQuantityLabel();
            }
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
               // btnRegistraVenda.Enabled = true;
            }
            else
            {
              //  btnRegistraVenda.Enabled = false;
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
                        int estoque = Convert.ToInt32(row.Cells["Estoque"].Value);
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

                            using (var updateCommand = new NpgsqlCommand("UPDATE tb_produtos SET pro_quantidade = @pro_qtd WHERE pro_codigo = @pro_cod", connection))
                            {
                                int estoqueTotal = estoque - quantidade;
                                updateCommand.Parameters.AddWithValue("@pro_qtd", estoqueTotal);
                                updateCommand.Parameters.AddWithValue("@pro_cod", proCodigo);
                                updateCommand.ExecuteNonQuery();
                                
                            }
                        }
                    }

                    salesCounter++;

                    if (salesCounter % 3 == 0)
                    {
                        //BackupUtility backupUtility = new BackupUtility();
                        //backupUtility.RealizarBackup();
                    }

                    if (dataGridProdutosSelecionados.Rows.Count <= 1) // Validação para "forçar" o Rollback
                    {
                        transaction.Rollback();
                        throw new Exception($"Venda sem produtos...");
                    }

                    transaction.Commit();

                    selectedProducts.Clear();
                    dataGridProdutosSelecionados.Rows.Clear();
                    listProducts();
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

        private void BtnNovoProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CadastrarProduto = new CadastrarProduto();
            CadastrarProduto.Show();
            // showNewVenda();
            //lblTitulo.Text = "Adicionar venda";
            //showNewProduct();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hideNewVenda();
            lblTitulo.Text = "Editar permissões de usuários";

        }

        private void buildMainForm()
        {
            lblTitulo.Text = "Produtos";
            // Products products = new Products();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            buildMainForm();
            hideNewVenda();
        }

        private void BtnCdstFuncionario_Click(object sender, EventArgs e)
        {
            Form cadastrarUsuarioForm = new CadastrarUsuarioForm();
            cadastrarUsuarioForm.Show();
        }

        private void dataGridProdutosSelecionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
