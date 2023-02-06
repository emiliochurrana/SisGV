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

namespace SisGV
{
    public partial class Categoria : Form
    {
        string nome;
        MySqlCommand comando;
        MySqlDataReader ler;
        public Categoria()
        {
            InitializeComponent();
        }

        public void dado()
        {
            nome = txtNome.Text;
        }

        public void leCategoria()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();
            try
            {
                conn.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                DataSet tabel = new DataSet();
                BindingSource bsource = new BindingSource();
                string query = "SELECT * FROM categoria";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridCategoria.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.White;
            panel2.BackColor = Color.White;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo");
            }
            try
            {
                dado();
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO categoria (nome) VALUES('" + nome + "')";
                conn.Open();
                cmd.ExecuteNonQuery();
                string strSQL = "SELECT * FROM categoria";
                MySqlDataAdapter da = new MySqlDataAdapter(strSQL, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridCategoria.DataSource = dt;
                MessageBox.Show("Cadastro efeituado com sucesso!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtNome.Text = "";
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            leCategoria();
        }
    }
}
