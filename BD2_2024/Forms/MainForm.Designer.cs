﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCdstFuncionario = new System.Windows.Forms.Button();
            this.BtnNovoProduto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridProdutosSelecionados = new System.Windows.Forms.DataGridView();
            this.btnRegistraVenda = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblQtdeProdutos = new System.Windows.Forms.Label();
            this.lblValorTotal_valor = new System.Windows.Forms.Label();
            this.lblQtdeProdutos_valor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutosSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCdstFuncionario
            // 
            this.BtnCdstFuncionario.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnCdstFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCdstFuncionario.FlatAppearance.BorderSize = 0;
            this.BtnCdstFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCdstFuncionario.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCdstFuncionario.ForeColor = System.Drawing.Color.CadetBlue;
            this.BtnCdstFuncionario.Location = new System.Drawing.Point(14, 12);
            this.BtnCdstFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCdstFuncionario.Name = "BtnCdstFuncionario";
            this.BtnCdstFuncionario.Padding = new System.Windows.Forms.Padding(10);
            this.BtnCdstFuncionario.Size = new System.Drawing.Size(238, 62);
            this.BtnCdstFuncionario.TabIndex = 0;
            this.BtnCdstFuncionario.Text = "Cadastrar funcionário";
            this.BtnCdstFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCdstFuncionario.UseVisualStyleBackColor = false;
            this.BtnCdstFuncionario.Click += new System.EventHandler(this.BtnCdstFuncionario_Click);
            // 
            // BtnNovoProduto
            // 
            this.BtnNovoProduto.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnNovoProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovoProduto.FlatAppearance.BorderSize = 0;
            this.BtnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovoProduto.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoProduto.ForeColor = System.Drawing.Color.CadetBlue;
            this.BtnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovoProduto.Location = new System.Drawing.Point(14, 82);
            this.BtnNovoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNovoProduto.Name = "BtnNovoProduto";
            this.BtnNovoProduto.Size = new System.Drawing.Size(238, 62);
            this.BtnNovoProduto.TabIndex = 1;
            this.BtnNovoProduto.Text = "Cadastrar produto";
            this.BtnNovoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovoProduto.UseVisualStyleBackColor = false;
            this.BtnNovoProduto.Click += new System.EventHandler(this.BtnNovoProduto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(196, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridProdutosSelecionados
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dataGridProdutosSelecionados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProdutosSelecionados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProdutosSelecionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridProdutosSelecionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProdutosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutosSelecionados.Location = new System.Drawing.Point(709, 79);
            this.dataGridProdutosSelecionados.Name = "dataGridProdutosSelecionados";
            this.dataGridProdutosSelecionados.Size = new System.Drawing.Size(400, 480);
            this.dataGridProdutosSelecionados.TabIndex = 5;
            this.dataGridProdutosSelecionados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProdutosSelecionados_CellContentClick);
            // 
            // btnRegistraVenda
            // 
            this.btnRegistraVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistraVenda.BackColor = System.Drawing.Color.IndianRed;
            this.btnRegistraVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistraVenda.FlatAppearance.BorderSize = 0;
            this.btnRegistraVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistraVenda.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistraVenda.ForeColor = System.Drawing.Color.Ivory;
            this.btnRegistraVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistraVenda.Location = new System.Drawing.Point(606, 2);
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
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(18, 15);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(74, 17);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.Text = "Valor total:";
            // 
            // lblQtdeProdutos
            // 
            this.lblQtdeProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtdeProdutos.AutoSize = true;
            this.lblQtdeProdutos.Location = new System.Drawing.Point(18, 39);
            this.lblQtdeProdutos.Name = "lblQtdeProdutos";
            this.lblQtdeProdutos.Size = new System.Drawing.Size(111, 17);
            this.lblQtdeProdutos.TabIndex = 8;
            this.lblQtdeProdutos.Text = "Qtde. produtos: ";
            // 
            // lblValorTotal_valor
            // 
            this.lblValorTotal_valor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal_valor.AutoSize = true;
            this.lblValorTotal_valor.Location = new System.Drawing.Point(95, 15);
            this.lblValorTotal_valor.Name = "lblValorTotal_valor";
            this.lblValorTotal_valor.Size = new System.Drawing.Size(57, 17);
            this.lblValorTotal_valor.TabIndex = 9;
            this.lblValorTotal_valor.Text = "R$ 0,00";
            // 
            // lblQtdeProdutos_valor
            // 
            this.lblQtdeProdutos_valor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtdeProdutos_valor.AutoSize = true;
            this.lblQtdeProdutos_valor.Location = new System.Drawing.Point(125, 39);
            this.lblQtdeProdutos_valor.Name = "lblQtdeProdutos_valor";
            this.lblQtdeProdutos_valor.Size = new System.Drawing.Size(16, 17);
            this.lblQtdeProdutos_valor.TabIndex = 10;
            this.lblQtdeProdutos_valor.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(196, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 37);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.lblQtdeProdutos);
            this.panel1.Controls.Add(this.lblValorTotal_valor);
            this.panel1.Controls.Add(this.btnRegistraVenda);
            this.panel1.Controls.Add(this.lblQtdeProdutos_valor);
            this.panel1.Location = new System.Drawing.Point(259, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 76);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(259, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 62);
            this.panel2.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Ivory;
            this.lblTitulo.Location = new System.Drawing.Point(16, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(77, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "lblTitulo";
            // 
            // dataGridProdutos
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dataGridProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Location = new System.Drawing.Point(259, 79);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.Size = new System.Drawing.Size(400, 480);
            this.dataGridProdutos.TabIndex = 15;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(14, 210);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(238, 24);
            this.txtDescricao.TabIndex = 16;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(12, 256);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 24);
            this.txtPreco.TabIndex = 17;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(152, 256);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(100, 24);
            this.txtEstoque.TabIndex = 18;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 190);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(67, 17);
            this.lblDesc.TabIndex = 19;
            this.lblDesc.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Preço";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(149, 237);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(58, 17);
            this.lblEstoque.TabIndex = 21;
            this.lblEstoque.Text = "Estoque";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 295);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(240, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1119, 653);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dataGridProdutos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridProdutosSelecionados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnNovoProduto);
            this.Controls.Add(this.BtnCdstFuncionario);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G7 PDV";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutosSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCdstFuncionario;
        private System.Windows.Forms.Button BtnNovoProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridProdutosSelecionados;
        private System.Windows.Forms.Button btnRegistraVenda;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblQtdeProdutos;
        private System.Windows.Forms.Label lblValorTotal_valor;
        private System.Windows.Forms.Label lblQtdeProdutos_valor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnCadastrar;
    }
}