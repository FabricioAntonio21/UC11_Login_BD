namespace UC11_Login_BD
{
    partial class Form_COMPRAS
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
            this.dataGridView_ITENS = new System.Windows.Forms.DataGridView();
            this.dataGridView_PRODUTOS = new System.Windows.Forms.DataGridView();
            this.button_ADICIONAR = new System.Windows.Forms.Button();
            this.button_CANCELAR = new System.Windows.Forms.Button();
            this.button_EXCLUIR = new System.Windows.Forms.Button();
            this.textBox_PESQUISA = new System.Windows.Forms.TextBox();
            this.label_PRECO = new System.Windows.Forms.Label();
            this.button_PESQUISAR = new System.Windows.Forms.Button();
            this.label_DATA = new System.Windows.Forms.Label();
            this.button_NOVAENDA = new System.Windows.Forms.Button();
            this.label_VENDA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ITENS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PRODUTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ITENS
            // 
            this.dataGridView_ITENS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ITENS.Location = new System.Drawing.Point(420, 61);
            this.dataGridView_ITENS.Name = "dataGridView_ITENS";
            this.dataGridView_ITENS.Size = new System.Drawing.Size(340, 250);
            this.dataGridView_ITENS.TabIndex = 0;
            // 
            // dataGridView_PRODUTOS
            // 
            this.dataGridView_PRODUTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PRODUTOS.Location = new System.Drawing.Point(26, 61);
            this.dataGridView_PRODUTOS.Name = "dataGridView_PRODUTOS";
            this.dataGridView_PRODUTOS.Size = new System.Drawing.Size(340, 250);
            this.dataGridView_PRODUTOS.TabIndex = 1;
            // 
            // button_ADICIONAR
            // 
            this.button_ADICIONAR.Location = new System.Drawing.Point(245, 317);
            this.button_ADICIONAR.Name = "button_ADICIONAR";
            this.button_ADICIONAR.Size = new System.Drawing.Size(104, 28);
            this.button_ADICIONAR.TabIndex = 2;
            this.button_ADICIONAR.Text = "Adicionar";
            this.button_ADICIONAR.UseVisualStyleBackColor = true;
            this.button_ADICIONAR.Click += new System.EventHandler(this.button_ADICIONAR_Click);
            // 
            // button_CANCELAR
            // 
            this.button_CANCELAR.Location = new System.Drawing.Point(453, 399);
            this.button_CANCELAR.Name = "button_CANCELAR";
            this.button_CANCELAR.Size = new System.Drawing.Size(104, 28);
            this.button_CANCELAR.TabIndex = 3;
            this.button_CANCELAR.Text = "Cancelar";
            this.button_CANCELAR.UseVisualStyleBackColor = true;
            // 
            // button_EXCLUIR
            // 
            this.button_EXCLUIR.Location = new System.Drawing.Point(636, 399);
            this.button_EXCLUIR.Name = "button_EXCLUIR";
            this.button_EXCLUIR.Size = new System.Drawing.Size(104, 28);
            this.button_EXCLUIR.TabIndex = 4;
            this.button_EXCLUIR.Text = "Excluir";
            this.button_EXCLUIR.UseVisualStyleBackColor = true;
            // 
            // textBox_PESQUISA
            // 
            this.textBox_PESQUISA.Location = new System.Drawing.Point(26, 35);
            this.textBox_PESQUISA.Name = "textBox_PESQUISA";
            this.textBox_PESQUISA.Size = new System.Drawing.Size(340, 20);
            this.textBox_PESQUISA.TabIndex = 5;
            // 
            // label_PRECO
            // 
            this.label_PRECO.AutoSize = true;
            this.label_PRECO.Location = new System.Drawing.Point(432, 38);
            this.label_PRECO.Name = "label_PRECO";
            this.label_PRECO.Size = new System.Drawing.Size(35, 13);
            this.label_PRECO.TabIndex = 6;
            this.label_PRECO.Text = "label1";
            // 
            // button_PESQUISAR
            // 
            this.button_PESQUISAR.Location = new System.Drawing.Point(43, 317);
            this.button_PESQUISAR.Name = "button_PESQUISAR";
            this.button_PESQUISAR.Size = new System.Drawing.Size(94, 28);
            this.button_PESQUISAR.TabIndex = 7;
            this.button_PESQUISAR.Text = "Pesquisar";
            this.button_PESQUISAR.UseVisualStyleBackColor = true;
            // 
            // label_DATA
            // 
            this.label_DATA.AutoSize = true;
            this.label_DATA.Location = new System.Drawing.Point(725, 38);
            this.label_DATA.Name = "label_DATA";
            this.label_DATA.Size = new System.Drawing.Size(35, 13);
            this.label_DATA.TabIndex = 8;
            this.label_DATA.Text = "label1";
            // 
            // button_NOVAENDA
            // 
            this.button_NOVAENDA.Location = new System.Drawing.Point(126, 399);
            this.button_NOVAENDA.Name = "button_NOVAENDA";
            this.button_NOVAENDA.Size = new System.Drawing.Size(104, 28);
            this.button_NOVAENDA.TabIndex = 9;
            this.button_NOVAENDA.Text = "Nova Venda";
            this.button_NOVAENDA.UseVisualStyleBackColor = true;
            this.button_NOVAENDA.Click += new System.EventHandler(this.button_NOVAENDA_Click);
            // 
            // label_VENDA
            // 
            this.label_VENDA.AutoSize = true;
            this.label_VENDA.Location = new System.Drawing.Point(145, 383);
            this.label_VENDA.Name = "label_VENDA";
            this.label_VENDA.Size = new System.Drawing.Size(29, 13);
            this.label_VENDA.TabIndex = 10;
            this.label_VENDA.Text = "label";
            // 
            // Form_COMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_VENDA);
            this.Controls.Add(this.button_NOVAENDA);
            this.Controls.Add(this.label_DATA);
            this.Controls.Add(this.button_PESQUISAR);
            this.Controls.Add(this.label_PRECO);
            this.Controls.Add(this.textBox_PESQUISA);
            this.Controls.Add(this.button_EXCLUIR);
            this.Controls.Add(this.button_CANCELAR);
            this.Controls.Add(this.button_ADICIONAR);
            this.Controls.Add(this.dataGridView_PRODUTOS);
            this.Controls.Add(this.dataGridView_ITENS);
            this.Name = "Form_COMPRAS";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ITENS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PRODUTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ITENS;
        private System.Windows.Forms.DataGridView dataGridView_PRODUTOS;
        private System.Windows.Forms.Button button_ADICIONAR;
        private System.Windows.Forms.Button button_CANCELAR;
        private System.Windows.Forms.Button button_EXCLUIR;
        private System.Windows.Forms.TextBox textBox_PESQUISA;
        private System.Windows.Forms.Label label_PRECO;
        private System.Windows.Forms.Button button_PESQUISAR;
        private System.Windows.Forms.Label label_DATA;
        private System.Windows.Forms.Button button_NOVAENDA;
        private System.Windows.Forms.Label label_VENDA;
    }
}