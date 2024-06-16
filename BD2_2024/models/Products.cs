using Npgsql;
using PostgresConnectionExample;
using System.Windows.Forms;

namespace BD2_2024.models
{
    internal class Products
    {
        public void listProductsInMain(ListView listViewProducts)
        {
            listViewProducts.View = View.Details;
            listViewProducts.LabelEdit = true;
            listViewProducts.AllowColumnReorder = true;
            listViewProducts.GridLines = true;

            listViewProducts.Columns.Add("Código", 50, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Valor", 95, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Estoque", 95, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Código Fornecedor", 95, HorizontalAlignment.Left);
            listViewProducts.Columns.Add("Fornecedor", 250, HorizontalAlignment.Left);

            using (var connection = DatabasePostgresConnection.GetInstance().GetConnection())
            {
                using (var command = new NpgsqlCommand("SELECT tp.pro_codigo,tp.pro_descricao, " +
                    "tp.pro_valor, tp.pro_quantidade, tp.tb_fornecedores_fun_codigo, tf.for_descricao " +
                    "FROM tb_produtos tp INNER JOIN tb_fornecedores tf ON tp.tb_fornecedores_fun_codigo = tf.for_codigo;", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string[] row = {
                                reader.GetInt64(0).ToString(),
                                reader.GetString(1),
                                "R$ " + reader.GetDouble(2).ToString(),
                                reader.GetInt16(3).ToString(),
                                reader.GetInt64(4).ToString(),
                                reader.GetString(5)

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
