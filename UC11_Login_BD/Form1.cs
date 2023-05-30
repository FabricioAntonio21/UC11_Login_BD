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
    public partial class Form_TELALOGIN : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public Form_TELALOGIN()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=login_bd;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

            label_LOGIN.Text = "";
            label_LOGIN.BackColor = Color.Transparent;
            
        }

        // ------------------------------------------------------------------------------------------------------------------

        private void button_ENTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, senha FROM tbl_usuários WHERE usuario = '" + textBox_USUARIO.Text + "' AND senha = '" + textBox_SENHA.Text + "';";

                MySqlDataReader resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    label_LOGIN.Text = "Usuário e Senha corretos!";
                    label_LOGIN.BackColor = Color.MistyRose;

                    Form_PRODUTO Form_TELALOGIN = new Form_PRODUTO();
                    textBox_USUARIO.Clear();
                    textBox_SENHA.Clear();
                    Form_TELALOGIN.ShowDialog();
                }
                else
                {
                    label_LOGIN.Text = "Usuário e/ou Senha incorretos";
                    label_LOGIN.BackColor = Color.MistyRose;
                }
                if (textBox_USUARIO.Text == "" || textBox_SENHA.Text == "")
                {
                    label_LOGIN.Text = "Por favor, prencha o Usuário e/ou Senha";
                    label_LOGIN.BackColor = Color.MistyRose;
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

            

        }

        // ----------------------------------------------------------------------------------------------------------------------

        private void button_CADASTRAR_Click(object sender, EventArgs e)
        {


            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, senha FROM tbl_usuários WHERE usuario = '" + textBox_USUARIO.Text + "';";

                MySqlDataReader valida_usuario = comando.ExecuteReader();


                if (valida_usuario.Read())
                {
                    MessageBox.Show("Usuário já cadastrado!");
                }
                else
                {
                    conexao.Close();
                    conexao.Open();
                    comando.CommandText = "INSERT INTO tbl_usuários (usuario, senha) VALUES ('" + textBox_USUARIO.Text + "', '" + textBox_SENHA.Text + "');";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuário Cadastrado com sucesso!");
                } if (textBox_USUARIO.Text != "" && textBox_SENHA.Text != "")
                {
                    label_LOGIN.Text = "Por favor, prencha o Usuário e/ou Senha";
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


        }

        // ----------------------------------------------------------------------------------------------------------------------

        private void Form_TELALOGIN_Load(object sender, EventArgs e)
        {

        }

        private void label_LOGIN_Click(object sender, EventArgs e)
        {

        }

        private void button_LIMPAR_Click(object sender, EventArgs e)
        {
            textBox_USUARIO.Clear();
            textBox_SENHA.Clear();
            label_LOGIN.Text = "";
        }
    }
}
