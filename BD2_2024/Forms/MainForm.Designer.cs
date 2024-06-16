
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCdstFuncionario
            // 
            this.BtnCdstFuncionario.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCdstFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCdstFuncionario.FlatAppearance.BorderSize = 0;
            this.BtnCdstFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCdstFuncionario.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCdstFuncionario.ForeColor = System.Drawing.Color.Ivory;
            this.BtnCdstFuncionario.Location = new System.Drawing.Point(13, 166);
            this.BtnCdstFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCdstFuncionario.Name = "BtnCdstFuncionario";
            this.BtnCdstFuncionario.Padding = new System.Windows.Forms.Padding(10);
            this.BtnCdstFuncionario.Size = new System.Drawing.Size(238, 70);
            this.BtnCdstFuncionario.TabIndex = 0;
            this.BtnCdstFuncionario.Text = "Cadastrar Funcionários";
            this.BtnCdstFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCdstFuncionario.UseVisualStyleBackColor = false;
            this.BtnCdstFuncionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.BackColor = System.Drawing.Color.DarkRed;
            this.BtnNovaVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovaVenda.FlatAppearance.BorderSize = 0;
            this.BtnNovaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovaVenda.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovaVenda.ForeColor = System.Drawing.Color.Ivory;
            this.BtnNovaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovaVenda.Location = new System.Drawing.Point(13, 89);
            this.BtnNovaVenda.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Padding = new System.Windows.Forms.Padding(10);
            this.BtnNovaVenda.Size = new System.Drawing.Size(238, 70);
            this.BtnNovaVenda.TabIndex = 1;
            this.BtnNovaVenda.Text = "Nova Venda";
            this.BtnNovaVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovaVenda.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(13, 244);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(238, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar Permissões";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(193, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.listViewProducts);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(269, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(907, 493);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // listViewProducts
            // 
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(3, 3);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(904, 490);
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(200, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 39);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(200, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 39);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(266, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produtos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnNovaVenda);
            this.Controls.Add(this.BtnCdstFuncionario);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCdstFuncionario;
        private System.Windows.Forms.Button BtnNovaVenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}