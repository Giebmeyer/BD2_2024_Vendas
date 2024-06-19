namespace BD2_2024.Forms
{
    partial class CadastrarUsuarioForm
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.checkIsFuncionario = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(15, 34);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(202, 20);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(15, 77);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(202, 20);
            this.txt_senha.TabIndex = 1;
            // 
            // checkIsFuncionario
            // 
            this.checkIsFuncionario.AutoSize = true;
            this.checkIsFuncionario.Location = new System.Drawing.Point(223, 36);
            this.checkIsFuncionario.Name = "checkIsFuncionario";
            this.checkIsFuncionario.Size = new System.Drawing.Size(81, 17);
            this.checkIsFuncionario.TabIndex = 3;
            this.checkIsFuncionario.Text = "Funcionário";
            this.checkIsFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(223, 77);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // CadastrarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 113);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.checkIsFuncionario);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.MaximumSize = new System.Drawing.Size(327, 152);
            this.MinimumSize = new System.Drawing.Size(327, 152);
            this.Name = "CadastrarUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar usuário";
            this.Load += new System.EventHandler(this.CadastrarUsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.CheckBox checkIsFuncionario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}