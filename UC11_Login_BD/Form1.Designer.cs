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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TELALOGIN));
            this.textBox_USUARIO = new System.Windows.Forms.TextBox();
            this.textBox_SENHA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ENTRAR = new System.Windows.Forms.Button();
            this.button_LIMPAR = new System.Windows.Forms.Button();
            this.button_CADASTRAR = new System.Windows.Forms.Button();
            this.label_LOGIN = new System.Windows.Forms.Label();
            this.textBox_NOME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_USUARIO
            // 
            this.textBox_USUARIO.Location = new System.Drawing.Point(204, 144);
            this.textBox_USUARIO.Name = "textBox_USUARIO";
            this.textBox_USUARIO.Size = new System.Drawing.Size(227, 20);
            this.textBox_USUARIO.TabIndex = 0;
            // 
            // textBox_SENHA
            // 
            this.textBox_SENHA.Location = new System.Drawing.Point(204, 214);
            this.textBox_SENHA.Name = "textBox_SENHA";
            this.textBox_SENHA.PasswordChar = '*';
            this.textBox_SENHA.Size = new System.Drawing.Size(227, 20);
            this.textBox_SENHA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // button_ENTRAR
            // 
            this.button_ENTRAR.BackColor = System.Drawing.Color.LightGray;
            this.button_ENTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ENTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ENTRAR.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_ENTRAR.Image = global::UC11_Login_BD.Properties.Resources.conecte_se;
            this.button_ENTRAR.Location = new System.Drawing.Point(204, 268);
            this.button_ENTRAR.Name = "button_ENTRAR";
            this.button_ENTRAR.Size = new System.Drawing.Size(96, 40);
            this.button_ENTRAR.TabIndex = 4;
            this.button_ENTRAR.Text = "Entrar";
            this.button_ENTRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ENTRAR.UseVisualStyleBackColor = false;
            this.button_ENTRAR.Click += new System.EventHandler(this.button_ENTRAR_Click);
            // 
            // button_LIMPAR
            // 
            this.button_LIMPAR.BackColor = System.Drawing.Color.LightGray;
            this.button_LIMPAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LIMPAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LIMPAR.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_LIMPAR.Image = global::UC11_Login_BD.Properties.Resources.ico_limpar;
            this.button_LIMPAR.Location = new System.Drawing.Point(333, 268);
            this.button_LIMPAR.Name = "button_LIMPAR";
            this.button_LIMPAR.Size = new System.Drawing.Size(98, 40);
            this.button_LIMPAR.TabIndex = 5;
            this.button_LIMPAR.Text = "Limpar";
            this.button_LIMPAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_LIMPAR.UseVisualStyleBackColor = false;
            this.button_LIMPAR.Click += new System.EventHandler(this.button_LIMPAR_Click);
            // 
            // button_CADASTRAR
            // 
            this.button_CADASTRAR.BackColor = System.Drawing.Color.LightGray;
            this.button_CADASTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CADASTRAR.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_CADASTRAR.Location = new System.Drawing.Point(255, 428);
            this.button_CADASTRAR.Name = "button_CADASTRAR";
            this.button_CADASTRAR.Size = new System.Drawing.Size(128, 29);
            this.button_CADASTRAR.TabIndex = 6;
            this.button_CADASTRAR.Text = "Cadastrar";
            this.button_CADASTRAR.UseVisualStyleBackColor = false;
            this.button_CADASTRAR.Click += new System.EventHandler(this.button_CADASTRAR_Click);
            // 
            // label_LOGIN
            // 
            this.label_LOGIN.BackColor = System.Drawing.Color.MistyRose;
            this.label_LOGIN.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LOGIN.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label_LOGIN.Location = new System.Drawing.Point(153, 331);
            this.label_LOGIN.Name = "label_LOGIN";
            this.label_LOGIN.Size = new System.Drawing.Size(329, 22);
            this.label_LOGIN.TabIndex = 7;
            this.label_LOGIN.Text = "Usuário e/ou Senha incorretos";
            this.label_LOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_LOGIN.Click += new System.EventHandler(this.label_LOGIN_Click);
            // 
            // textBox_NOME
            // 
            this.textBox_NOME.Location = new System.Drawing.Point(204, 100);
            this.textBox_NOME.Name = "textBox_NOME";
            this.textBox_NOME.Size = new System.Drawing.Size(227, 20);
            this.textBox_NOME.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(201, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome";
            // 
            // Form_TELALOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 555);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NOME);
            this.Controls.Add(this.label_LOGIN);
            this.Controls.Add(this.button_CADASTRAR);
            this.Controls.Add(this.button_LIMPAR);
            this.Controls.Add(this.button_ENTRAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_SENHA);
            this.Controls.Add(this.textBox_USUARIO);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_TELALOGIN";
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.Form_TELALOGIN_Load);
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
        private System.Windows.Forms.Label label_LOGIN;
        private System.Windows.Forms.TextBox textBox_NOME;
        private System.Windows.Forms.Label label3;
    }
}

