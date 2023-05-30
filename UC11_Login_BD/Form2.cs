using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC11_Login_BD
{
    public partial class Form_PRODUTO : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;


        public Form_PRODUTO()
        {
            InitializeComponent();

            textBox_ID.Enabled = false;

            servidor = "Server=localhost;Database=login_bd;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

            label_INFORMATIVO.Text = "";

            atualizar_dataGRID();


        }

        private void atualizar_dataGRID()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM venda_online_bd;";

                MySqlDataAdapter adaptadorPRODUTOS = new MySqlDataAdapter(comando);
                DataTable tabelaPRODUTOS = new DataTable();

                adaptadorPRODUTOS.Fill(tabelaPRODUTOS);

                dataGridView_PRODUTOS.DataSource = tabelaPRODUTOS;
                dataGridView_PRODUTOS.Columns["id"].HeaderText = "Código";
                dataGridView_PRODUTOS.Columns["descricao_produto"].HeaderText = "Descrição";
                dataGridView_PRODUTOS.Columns["categoria_produtos"].HeaderText = "Categoria";
                dataGridView_PRODUTOS.Columns["preco_produto"].HeaderText = "Preço";




            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Form_PRODUTO_Load(object sender, EventArgs e)
        {

        }

        private void button_CADASTRAR_Click(object sender, EventArgs e)
        {

            try
            {
                conexao.Open();
                comando.CommandText = "SELECT descricao_produto, categoria_produtos FROM venda_online_bd WHERE descricao_produto = '" + textBox_CADASTRO.Text + "' AND categoria_produtos = '" + textBox_CATEGORIA.Text + "';";

                MySqlDataReader resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    label_INFORMATIVO.Text = "Produto já Cadastrado!";


                }
                if (textBox_CADASTRO.Text == "" || textBox_CATEGORIA.Text == "" || textBox_PRECO.Text == "")
                {
                    label_INFORMATIVO.Text = "Por favor, prencha os campos para cadastrar";
                }
                else
                {

                    conexao.Close();
                    conexao.Open();
                    comando.CommandText = "INSERT INTO venda_online_bd (descricao_produto, categoria_produtos, preco_produto) VALUES ('" + textBox_CADASTRO.Text + "', '" + textBox_CATEGORIA.Text + "', '" + textBox_PRECO.Text.Replace(",", ".") + "' );";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso!");

                    

                }
            }
            catch (Exception ERRO)
            {
                MessageBox.Show(ERRO.Message);
            }
            finally
            {
                conexao.Close();
            }

            atualizar_dataGRID();
        }

        private void button_LIMPAR_Click(object sender, EventArgs e)
        {
            textBox_CADASTRO.Clear();
            textBox_CATEGORIA.Clear();
            textBox_PRECO.Clear();
        }

        private void button_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "DELETE FROM venda_online_bd WHERE id = '" + textBox_ID.Text + "';";
                comando.ExecuteNonQuery();

                label_INFORMATIVO.Text = "Produto apagado com sucesso";
            }
            catch (Exception ERRO)
            {
                MessageBox.Show(ERRO.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void button_ATUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM venda_online_bd;";

                MySqlDataAdapter adaptadorPRODUTOS = new MySqlDataAdapter(comando);
                DataTable tabelaPRODUTOS = new DataTable();

                adaptadorPRODUTOS.Fill(tabelaPRODUTOS);

                dataGridView_PRODUTOS.DataSource = tabelaPRODUTOS;
                dataGridView_PRODUTOS.Columns["id"].HeaderText = "Código";
                dataGridView_PRODUTOS.Columns["descricao_produto"].HeaderText = "Descrição";
                dataGridView_PRODUTOS.Columns["categoria_produtos"].HeaderText = "Categoria";
                dataGridView_PRODUTOS.Columns["preco_produto"].HeaderText = "Preço";




            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }



        private void dataGridView_PRODUTOS_SelectionChanged(object sender, EventArgs e)
        {
            textBox_ID.Text = dataGridView_PRODUTOS.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_ALTERAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE venda_online_bd SET descricao_produto = '" + textBox_CADASTRO.Text + "' , categoria_produtos = '" + textBox_CATEGORIA.Text + "' , preco_produto = '" + textBox_PRECO.Text.Replace(",", ".") + "' WHERE id = '" + textBox_ID.Text + "';";
                comando.ExecuteNonQuery();

                label_INFORMATIVO.Text = "Produto Modificado com Sucesso";

                if (textBox_CADASTRO.Text == "" || textBox_CATEGORIA.Text == "" || textBox_PRECO.Text == "")
                {
                    label_INFORMATIVO.Text = "Por favor, prencha os campos para realizar a alteração";
                }
            }
            catch (Exception ERRO)
            {
                MessageBox.Show(ERRO.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void dataGridView_PRODUTOS_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conexao.Open();


                if (textBox_CADASTRO.Text == "" || textBox_CATEGORIA.Text == "" || textBox_PRECO.Text == "")
                {
                    label_INFORMATIVO.Text = "Por favor, prencha os campos para realizar a alteração";
                }
                else
                {

                    comando.CommandText = "UPDATE venda_online_bd SET descricao_produto = '" + dataGridView_PRODUTOS.CurrentRow.Cells[1].Value.ToString() + "' , categoria_produtos = '" + dataGridView_PRODUTOS.CurrentRow.Cells[2].Value.ToString() + "' , preco_produto = '" + dataGridView_PRODUTOS.CurrentRow.Cells[3].Value.ToString().Replace(".", ",") + "' WHERE id = '" + textBox_ID.Text + "';";
                    comando.ExecuteNonQuery();

                    label_INFORMATIVO.Text = "Produto Modificado com Sucesso";
                }
            }
            catch (Exception ERRO)
            {
                MessageBox.Show(ERRO.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}






