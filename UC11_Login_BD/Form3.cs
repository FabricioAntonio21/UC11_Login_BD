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
    public partial class Form_COMPRAS : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        string qualGRID = "";
        string vendaATIVA = "";
        
        public Form_COMPRAS()
        {
            InitializeComponent();

            servidor = "Server=localhost;Database=vendas_porta_a_porta;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

            label_DATA.Text = System.DateTime.Now.ToString();

            
            atualizar_dataGRID();
            
        }

        private void atualizar_dataGRID()
        {
            try
            {
                conexao.Open();
                

                if (qualGRID == "")
                {
                    comando.CommandText = "SELECT * FROM tbl_produtos";
                }
                if(qualGRID == "GRIDitem")
                {
                    comando.CommandText = "SELECT * FROM tbl_produtos INNER JOIN tbl_venda_itens ON (tbl_venda_itens.fk_produto = tbl_produtos.id) WHERE fk_venda = " + vendaATIVA;
                }
                MySqlDataAdapter adaptador_DataGrid = new MySqlDataAdapter(comando);
                DataTable tabelaPRODUTOS = new DataTable();


               
                adaptador_DataGrid.Fill(tabelaPRODUTOS);

                if(qualGRID == "")
                {
                    dataGridView_PRODUTOS.DataSource = adaptador_DataGrid;
                }
                if (qualGRID == "GRIDitem")
                {
                    dataGridView_ITENS.DataSource = adaptador_DataGrid;
                }

                dataGridView_PRODUTOS.DataSource = tabelaPRODUTOS;
                dataGridView_PRODUTOS.Columns["id"].HeaderText = "Código";
                dataGridView_PRODUTOS.Columns["descricao_produto"].HeaderText = "Descrição";
                dataGridView_PRODUTOS.Columns["categoria_produto"].HeaderText = "Categoria";
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

        
        

        private void button_ADICIONAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_venda_itens(fk_produto, fk_venda, valor_venda, desconto) VALUES (" + dataGridView_PRODUTOS.CurrentRow.Cells[0].Value.ToString() + ", '" + vendaATIVA + "');'";
                comando.ExecuteNonQuery();

                qualGRID = "GRIDitem";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

            
        }

        private void button_NOVAENDA_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_vendas(data_venda, fk_usuario) VALUES ('" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 1)";
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

            try
            {
                conexao.Open();
                comando.CommandText = "SELECT MAX(id) FROM tbl_vendas;";

                MySqlDataReader readerVENDA = comando.ExecuteReader();


                if (readerVENDA.Read())
                {
                    vendaATIVA = readerVENDA.GetString(0);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

            label_VENDA.Text = vendaATIVA;
        }
    }
}
