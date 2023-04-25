namespace UC11_Login_BD
{
    partial class Form_TELALOGIN
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_USUARIO = new System.Windows.Forms.TextBox();
            this.textBox_SENHA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ENTRAR = new System.Windows.Forms.Button();
            this.button_LIMPAR = new System.Windows.Forms.Button();
            this.button_CADASTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_USUARIO
            // 
            this.textBox_USUARIO.Location = new System.Drawing.Point(163, 128);
            this.textBox_USUARIO.Name = "textBox_USUARIO";
            this.textBox_USUARIO.Size = new System.Drawing.Size(227, 20);
            this.textBox_USUARIO.TabIndex = 0;
            // 
            // textBox_SENHA
            // 
            this.textBox_SENHA.Location = new System.Drawing.Point(163, 198);
            this.textBox_SENHA.Name = "textBox_SENHA";
            this.textBox_SENHA.Size = new System.Drawing.Size(227, 20);
            this.textBox_SENHA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // button_ENTRAR
            // 
            this.button_ENTRAR.Location = new System.Drawing.Point(163, 252);
            this.button_ENTRAR.Name = "button_ENTRAR";
            this.button_ENTRAR.Size = new System.Drawing.Size(75, 23);
            this.button_ENTRAR.TabIndex = 4;
            this.button_ENTRAR.Text = "Entrar";
            this.button_ENTRAR.UseVisualStyleBackColor = true;
            // 
            // button_LIMPAR
            // 
            this.button_LIMPAR.Location = new System.Drawing.Point(315, 252);
            this.button_LIMPAR.Name = "button_LIMPAR";
            this.button_LIMPAR.Size = new System.Drawing.Size(75, 23);
            this.button_LIMPAR.TabIndex = 5;
            this.button_LIMPAR.Text = "Limpar";
            this.button_LIMPAR.UseVisualStyleBackColor = true;
            // 
            // button_CADASTRAR
            // 
            this.button_CADASTRAR.Location = new System.Drawing.Point(214, 412);
            this.button_CADASTRAR.Name = "button_CADASTRAR";
            this.button_CADASTRAR.Size = new System.Drawing.Size(128, 23);
            this.button_CADASTRAR.TabIndex = 6;
            this.button_CADASTRAR.Text = "Cadastrar";
            this.button_CADASTRAR.UseVisualStyleBackColor = true;
            // 
            // Form_TELALOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 545);
            this.Controls.Add(this.button_CADASTRAR);
            this.Controls.Add(this.button_LIMPAR);
            this.Controls.Add(this.button_ENTRAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_SENHA);
            this.Controls.Add(this.textBox_USUARIO);
            this.Name = "Form_TELALOGIN";
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_USUARIO;
        private System.Windows.Forms.TextBox textBox_SENHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ENTRAR;
        private System.Windows.Forms.Button button_LIMPAR;
        private System.Windows.Forms.Button button_CADASTRAR;
    }
}

