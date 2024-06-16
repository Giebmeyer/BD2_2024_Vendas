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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void showMessageBox(String txt, String title = "Atenção!")
        {
            MessageBox.Show(txt, title);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
            {
                 using (var command = new NpgsqlCommand("SELECT version()", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            showMessageBox(reader.GetString(0));
                        }
                    }
                }

                listProducts();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listProducts()
        {
            listViewProducts.View = View.Details;
            listViewProducts.LabelEdit = true;
            listViewProducts.AllowColumnReorder = true;
            listViewProducts.GridLines = true;

            listViewProducts.Columns.Add("Código", 30, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Valor", 95, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Estoque", 95, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Fornecedor", 95, HorizontalAlignment.Left);

            using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
            {
                using (var command = new NpgsqlCommand("SELECT * FROM tb_produtos;", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string[] row = {
                                reader.GetInt64(0).ToString(),
                                reader.GetString(1),
                                reader.GetDouble(2).ToString(),
                                reader.GetInt16(3).ToString(),
                                reader.GetInt64(4).ToString()

                             };

                            var listViewItem = new ListViewItem(row);

                            listViewProducts.Items.Add(listViewItem);
                        }
                        connection.Close();
                    }
                }
            }
        }
    }
}
