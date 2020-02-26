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
namespace testandoMysql4
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            
            InitializeComponent();
        }
      
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;uid=root;pwd=;database=bd_prod");
                conexao.Open();
                MySqlCommand objcm = new MySqlCommand("insert into tbl_prod(item, Code_prod, Price_prod) values(?, ?, ?)", conexao);
                objcm.Parameters.Add("@item", MySqlDbType.Double, 11).Value = txtItem.Text;
                objcm.Parameters.Add("@Code_prod", MySqlDbType.Double, 10).Value = txtCodigo.Text;
                objcm.Parameters.Add("@Price_prod", MySqlDbType.Decimal).Value = txtPreco.Text;
                objcm.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!!!");
                txtItem.Clear();
                txtCodigo.Clear();
                txtPreco.Clear();
                conexao.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao cadastrar, verifique!!!!!" + error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;uid=root;pwd=;database=bd_prod");
                conexao.Open();
                MessageBox.Show("conectado!!");
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Desconectado");
            }
        }
    }
}
