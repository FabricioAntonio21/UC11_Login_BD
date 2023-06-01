namespace UC11_Login_BD
{
    partial class Form_PRODUTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PRODUTO));
            this.label_descicao = new System.Windows.Forms.Label();
            this.label_CATEGORIA = new System.Windows.Forms.Label();
            this.label_PRECO = new System.Windows.Forms.Label();
            this.textBox_CADASTRO = new System.Windows.Forms.TextBox();
            this.textBox_CATEGORIA = new System.Windows.Forms.TextBox();
            this.textBox_PRECO = new System.Windows.Forms.TextBox();
            this.button_CADASTRAR = new System.Windows.Forms.Button();
            this.button_LIMPAR = new System.Windows.Forms.Button();
            this.label_INFORMATIVO = new System.Windows.Forms.Label();
            this.button_DELETE = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_PRODUTOS = new System.Windows.Forms.DataGridView();
            this.button_ATUALIZAR = new System.Windows.Forms.Button();
            this.button_ALTERAR = new System.Windows.Forms.Button();
            this.button_COMPRAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PRODUTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label_descicao
            // 
            this.label_descicao.AutoSize = true;
            this.label_descicao.BackColor = System.Drawing.Color.Transparent;
            this.label_descicao.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_descicao.Location = new System.Drawing.Point(195, 7);
            this.label_descicao.Name = "label_descicao";
            this.label_descicao.Size = new System.Drawing.Size(61, 23);
            this.label_descicao.TabIndex = 0;
            this.label_descicao.Text = "Nome";
            // 
            // label_CATEGORIA
            // 
            this.label_CATEGORIA.AutoSize = true;
            this.label_CATEGORIA.BackColor = System.Drawing.Color.Transparent;
            this.label_CATEGORIA.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CATEGORIA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_CATEGORIA.Location = new System.Drawing.Point(177, 59);
            this.label_CATEGORIA.Name = "label_CATEGORIA";
            this.label_CATEGORIA.Size = new System.Drawing.Size(96, 23);
            this.label_CATEGORIA.TabIndex = 1;
            this.label_CATEGORIA.Text = "Categoria";
            // 
            // label_PRECO
            // 
            this.label_PRECO.AutoSize = true;
            this.label_PRECO.BackColor = System.Drawing.Color.Transparent;
            this.label_PRECO.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PRECO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_PRECO.Location = new System.Drawing.Point(195, 108);
            this.label_PRECO.Name = "label_PRECO";
            this.label_PRECO.Size = new System.Drawing.Size(62, 23);
            this.label_PRECO.TabIndex = 2;
            this.label_PRECO.Text = "Preço";
            // 
            // textBox_CADASTRO
            // 
            this.textBox_CADASTRO.Location = new System.Drawing.Point(11, 33);
            this.textBox_CADASTRO.Name = "textBox_CADASTRO";
            this.textBox_CADASTRO.Size = new System.Drawing.Size(417, 20);
            this.textBox_CADASTRO.TabIndex = 4;
            // 
            // textBox_CATEGORIA
            // 
            this.textBox_CATEGORIA.Location = new System.Drawing.Point(11, 85);
            this.textBox_CATEGORIA.Name = "textBox_CATEGORIA";
            this.textBox_CATEGORIA.Size = new System.Drawing.Size(417, 20);
            this.textBox_CATEGORIA.TabIndex = 5;
            // 
            // textBox_PRECO
            // 
            this.textBox_PRECO.Location = new System.Drawing.Point(11, 134);
            this.textBox_PRECO.Name = "textBox_PRECO";
            this.textBox_PRECO.Size = new System.Drawing.Size(417, 20);
            this.textBox_PRECO.TabIndex = 6;
            // 
            // button_CADASTRAR
            // 
            this.button_CADASTRAR.Location = new System.Drawing.Point(29, 173);
            this.button_CADASTRAR.Name = "button_CADASTRAR";
            this.button_CADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.button_CADASTRAR.TabIndex = 7;
            this.button_CADASTRAR.Text = "Cadastrar";
            this.button_CADASTRAR.UseVisualStyleBackColor = true;
            this.button_CADASTRAR.Click += new System.EventHandler(this.button_CADASTRAR_Click);
            // 
            // button_LIMPAR
            // 
            this.button_LIMPAR.Location = new System.Drawing.Point(332, 173);
            this.button_LIMPAR.Name = "button_LIMPAR";
            this.button_LIMPAR.Size = new System.Drawing.Size(75, 23);
            this.button_LIMPAR.TabIndex = 8;
            this.button_LIMPAR.Text = "Limpar";
            this.button_LIMPAR.UseVisualStyleBackColor = true;
            this.button_LIMPAR.Click += new System.EventHandler(this.button_LIMPAR_Click);
            // 
            // label_INFORMATIVO
            // 
            this.label_INFORMATIVO.AutoSize = true;
            this.label_INFORMATIVO.Location = new System.Drawing.Point(608, 407);
            this.label_INFORMATIVO.Name = "label_INFORMATIVO";
            this.label_INFORMATIVO.Size = new System.Drawing.Size(35, 13);
            this.label_INFORMATIVO.TabIndex = 9;
            this.label_INFORMATIVO.Text = "label1";
            // 
            // button_DELETE
            // 
            this.button_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DELETE.Image = global::UC11_Login_BD.Properties.Resources.botao_apagar;
            this.button_DELETE.Location = new System.Drawing.Point(18, 308);
            this.button_DELETE.Name = "button_DELETE";
            this.button_DELETE.Size = new System.Drawing.Size(111, 42);
            this.button_DELETE.TabIndex = 10;
            this.button_DELETE.Text = "Deletar";
            this.button_DELETE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_DELETE.UseVisualStyleBackColor = true;
            this.button_DELETE.Click += new System.EventHandler(this.button_DELETE_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(29, 282);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(85, 20);
            this.textBox_ID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Deletar (Por ID)";
            // 
            // dataGridView_PRODUTOS
            // 
            this.dataGridView_PRODUTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PRODUTOS.Location = new System.Drawing.Point(450, 12);
            this.dataGridView_PRODUTOS.Name = "dataGridView_PRODUTOS";
            this.dataGridView_PRODUTOS.Size = new System.Drawing.Size(338, 317);
            this.dataGridView_PRODUTOS.TabIndex = 13;
            this.dataGridView_PRODUTOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PRODUTOS_CellContentClick);
            this.dataGridView_PRODUTOS.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PRODUTOS_CellEndEdit);
            this.dataGridView_PRODUTOS.SelectionChanged += new System.EventHandler(this.dataGridView_PRODUTOS_SelectionChanged);
            // 
            // button_ATUALIZAR
            // 
            this.button_ATUALIZAR.Location = new System.Drawing.Point(450, 344);
            this.button_ATUALIZAR.Name = "button_ATUALIZAR";
            this.button_ATUALIZAR.Size = new System.Drawing.Size(338, 23);
            this.button_ATUALIZAR.TabIndex = 14;
            this.button_ATUALIZAR.Text = "Atualizar";
            this.button_ATUALIZAR.UseVisualStyleBackColor = true;
            this.button_ATUALIZAR.Click += new System.EventHandler(this.button_ATUALIZAR_Click);
            // 
            // button_ALTERAR
            // 
            this.button_ALTERAR.Location = new System.Drawing.Point(182, 173);
            this.button_ALTERAR.Name = "button_ALTERAR";
            this.button_ALTERAR.Size = new System.Drawing.Size(75, 23);
            this.button_ALTERAR.TabIndex = 15;
            this.button_ALTERAR.Text = "Alterar";
            this.button_ALTERAR.UseVisualStyleBackColor = true;
            this.button_ALTERAR.Click += new System.EventHandler(this.button_ALTERAR_Click);
            // 
            // button_COMPRAR
            // 
            this.button_COMPRAR.Location = new System.Drawing.Point(450, 373);
            this.button_COMPRAR.Name = "button_COMPRAR";
            this.button_COMPRAR.Size = new System.Drawing.Size(338, 23);
            this.button_COMPRAR.TabIndex = 16;
            this.button_COMPRAR.Text = "Comprar";
            this.button_COMPRAR.UseVisualStyleBackColor = true;
            this.button_COMPRAR.Click += new System.EventHandler(this.button_COMPRAR_Click);
            // 
            // Form_PRODUTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC11_Login_BD.Properties.Resources.estoque_bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_COMPRAR);
            this.Controls.Add(this.button_ALTERAR);
            this.Controls.Add(this.button_ATUALIZAR);
            this.Controls.Add(this.dataGridView_PRODUTOS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.button_DELETE);
            this.Controls.Add(this.label_INFORMATIVO);
            this.Controls.Add(this.button_LIMPAR);
            this.Controls.Add(this.button_CADASTRAR);
            this.Controls.Add(this.textBox_PRECO);
            this.Controls.Add(this.textBox_CATEGORIA);
            this.Controls.Add(this.textBox_CADASTRO);
            this.Controls.Add(this.label_PRECO);
            this.Controls.Add(this.label_CATEGORIA);
            this.Controls.Add(this.label_descicao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_PRODUTO";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form_PRODUTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PRODUTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_descicao;
        private System.Windows.Forms.Label label_CATEGORIA;
        private System.Windows.Forms.Label label_PRECO;
        private System.Windows.Forms.TextBox textBox_CADASTRO;
        private System.Windows.Forms.TextBox textBox_CATEGORIA;
        private System.Windows.Forms.TextBox textBox_PRECO;
        private System.Windows.Forms.Button button_CADASTRAR;
        private System.Windows.Forms.Button button_LIMPAR;
        private System.Windows.Forms.Label label_INFORMATIVO;
        private System.Windows.Forms.Button button_DELETE;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_PRODUTOS;
        private System.Windows.Forms.Button button_ATUALIZAR;
        private System.Windows.Forms.Button button_ALTERAR;
        private System.Windows.Forms.Button button_COMPRAR;
    }
}