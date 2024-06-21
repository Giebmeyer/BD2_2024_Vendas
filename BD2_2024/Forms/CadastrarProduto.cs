using Npgsql;
using PostgresConnectionExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_2024.Forms
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            decimal estoque;
            decimal preco;

            if (!decimal.TryParse(txtPreco.Text, out preco))
            {
                MessageBox.Show("Preço inválido. Certifique-se de digitar um valor numérico.");
                return;
            }

            if (!decimal.TryParse(txtEstoque.Text, out estoque))
            {
                MessageBox.Show("Estoque inválido. Certifique-se de digitar um valor numérico.");
                return;
            }

            try
            {
                using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
                {
                    string sql = @"
                                INSERT INTO tb_produtos (pro_descricao, pro_valor, pro_quantidade, tb_fornecedores_fun_codigo)
                                VALUES (@descricao, @preco, @estoque, 1);";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@preco", preco);
                        cmd.Parameters.AddWithValue("@estoque", estoque);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produto cadastrado com sucesso!");
                    txtDescricao.Clear();
                    txtPreco.Clear();
                    txtEstoque.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar produto: {ex.Message}");
            }
        }

        private void CadastrarProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form main = new MainForm();            
            main.Show();
        }
    }
}
