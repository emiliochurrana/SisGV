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
    public partial class Marca : Form
    {
        MySqlCommand comando;
        MySqlDataReader ler;
        string nome;
        public Marca()
        {
            InitializeComponent();
        }

        public void dado()
        {
            nome = txtNome.Text;
        }

        public void leMarca()
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
                string query = "SELECT * FROM marca";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridMarca.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.White;
            panel3.BackColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
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

                cmd.CommandText = "INSERT INTO marca (nome) VALUES('" + nome + "')";
                conn.Open();
                cmd.ExecuteNonQuery();
                string strSQL = "SELECT * FROM marca";
                MySqlDataAdapter da = new MySqlDataAdapter(strSQL, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridMarca.DataSource = dt;
                MessageBox.Show("Cadastro efeituado com sucesso!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtNome.Text = "";
        }

        private void Marca_Load(object sender, EventArgs e)
        {
            leMarca();
        }
    }
}
