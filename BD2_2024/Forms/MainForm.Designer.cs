
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.listViewProducts);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(269, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(895, 555);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // listViewProducts
            // 
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(3, 3);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(892, 552);
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1176, 582);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCdstFuncionario;
        private System.Windows.Forms.Button BtnNovaVenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView listViewProducts;
    }
}