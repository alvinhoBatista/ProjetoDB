using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_01
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=alvaro;Pwd=alvaro123;");

        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void CarregarDados()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();


            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from alunos";
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet dados = new DataSet();
            adapter.Fill(dados, "alunos");
            con.Close();

            TabelaAluno.DataMember = "alunos";
            TabelaAluno.DataSource = dados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "insert into alunos values ('" + textBox1.Text + "', '" + textBox2.Text + "', '"
            + textBox3.Text + "', '" + textBox4.Text + "')";
            
            int valor = command.ExecuteNonQuery();
            MessageBox.Show("Cadastro realizado com sucesso!");
            con.Close();

            CarregarDados();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "update alunos set ";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabelaAluno_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("clicou");
        }
    }
}
