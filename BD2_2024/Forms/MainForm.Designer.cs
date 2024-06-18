
namespace BD2_2024.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtnCdstFuncionario = new System.Windows.Forms.Button();
            this.BtnNovaVenda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridProdutosSelecionados = new System.Windows.Forms.DataGridView();
            this.btnRegistraVenda = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblQtdeProdutos = new System.Windows.Forms.Label();
            this.lblValorTotal_valor = new System.Windows.Forms.Label();
            this.lblQtdeProdutos_valor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutosSelecionados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCdstFuncionario
            // 
            this.BtnCdstFuncionario.BackColor = System.Drawing.Color.LightYellow;
            this.BtnCdstFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCdstFuncionario.FlatAppearance.BorderSize = 0;
            this.BtnCdstFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCdstFuncionario.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnCdstFuncionario.Location = new System.Drawing.Point(14, 92);
            this.BtnCdstFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCdstFuncionario.Name = "BtnCdstFuncionario";
            this.BtnCdstFuncionario.Size = new System.Drawing.Size(238, 70);
            this.BtnCdstFuncionario.TabIndex = 0;
            this.BtnCdstFuncionario.Text = "Cadastrar Funcionários";
            this.BtnCdstFuncionario.UseVisualStyleBackColor = false;
            this.BtnCdstFuncionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.BackColor = System.Drawing.Color.Honeydew;
            this.BtnNovaVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovaVenda.FlatAppearance.BorderSize = 0;
            this.BtnNovaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovaVenda.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovaVenda.Location = new System.Drawing.Point(14, 15);
            this.BtnNovaVenda.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Size = new System.Drawing.Size(238, 70);
            this.BtnNovaVenda.TabIndex = 1;
            this.BtnNovaVenda.Text = "Nova Venda";
            this.BtnNovaVenda.UseVisualStyleBackColor = false;
            this.BtnNovaVenda.Click += new System.EventHandler(this.BtnNovaVenda_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar Permissões";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(34, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 37);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridProdutos
            // 
            this.dataGridProdutos.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Location = new System.Drawing.Point(259, 15);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.Size = new System.Drawing.Size(422, 555);
            this.dataGridProdutos.TabIndex = 4;
            // 
            // dataGridProdutosSelecionados
            // 
            this.dataGridProdutosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutosSelecionados.Location = new System.Drawing.Point(687, 15);
            this.dataGridProdutosSelecionados.Name = "dataGridProdutosSelecionados";
            this.dataGridProdutosSelecionados.Size = new System.Drawing.Size(422, 555);
            this.dataGridProdutosSelecionados.TabIndex = 5;
            // 
            // btnRegistraVenda
            // 
            this.btnRegistraVenda.BackColor = System.Drawing.Color.Honeydew;
            this.btnRegistraVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistraVenda.FlatAppearance.BorderSize = 0;
            this.btnRegistraVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistraVenda.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistraVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistraVenda.Location = new System.Drawing.Point(868, 577);
            this.btnRegistraVenda.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistraVenda.Name = "btnRegistraVenda";
            this.btnRegistraVenda.Size = new System.Drawing.Size(238, 70);
            this.btnRegistraVenda.TabIndex = 6;
            this.btnRegistraVenda.Text = "Finalizar venda";
            this.btnRegistraVenda.UseVisualStyleBackColor = false;
            this.btnRegistraVenda.Click += new System.EventHandler(this.btnRegistraVenda_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(259, 604);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(71, 16);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.Text = "Valor total:";
            // 
            // lblQtdeProdutos
            // 
            this.lblQtdeProdutos.AutoSize = true;
            this.lblQtdeProdutos.Location = new System.Drawing.Point(259, 628);
            this.lblQtdeProdutos.Name = "lblQtdeProdutos";
            this.lblQtdeProdutos.Size = new System.Drawing.Size(101, 16);
            this.lblQtdeProdutos.TabIndex = 8;
            this.lblQtdeProdutos.Text = "Qtde. produtos: ";
            // 
            // lblValorTotal_valor
            // 
            this.lblValorTotal_valor.AutoSize = true;
            this.lblValorTotal_valor.Location = new System.Drawing.Point(336, 604);
            this.lblValorTotal_valor.Name = "lblValorTotal_valor";
            this.lblValorTotal_valor.Size = new System.Drawing.Size(51, 16);
            this.lblValorTotal_valor.TabIndex = 9;
            this.lblValorTotal_valor.Text = "R$ 0,00";
            // 
            // lblQtdeProdutos_valor
            // 
            this.lblQtdeProdutos_valor.AutoSize = true;
            this.lblQtdeProdutos_valor.Location = new System.Drawing.Point(366, 628);
            this.lblQtdeProdutos_valor.Name = "lblQtdeProdutos_valor";
            this.lblQtdeProdutos_valor.Size = new System.Drawing.Size(14, 16);
            this.lblQtdeProdutos_valor.TabIndex = 10;
            this.lblQtdeProdutos_valor.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1119, 653);
            this.Controls.Add(this.lblQtdeProdutos_valor);
            this.Controls.Add(this.lblValorTotal_valor);
            this.Controls.Add(this.lblQtdeProdutos);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnRegistraVenda);
            this.Controls.Add(this.dataGridProdutosSelecionados);
            this.Controls.Add(this.dataGridProdutos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnNovaVenda);
            this.Controls.Add(this.BtnCdstFuncionario);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutosSelecionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCdstFuncionario;
        private System.Windows.Forms.Button BtnNovaVenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.DataGridView dataGridProdutosSelecionados;
        private System.Windows.Forms.Button btnRegistraVenda;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblQtdeProdutos;
        private System.Windows.Forms.Label lblValorTotal_valor;
        private System.Windows.Forms.Label lblQtdeProdutos_valor;
    }
}