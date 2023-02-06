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
    public partial class Cliente : Form
    {
        string nome, telefone, endereco;
        MySqlCommand comando;
        MySqlDataReader ler;
        public Cliente()
        {
            InitializeComponent();
        }
        public void dado()
        {
            nome = txtNome.Text;
            telefone = txtTelefone.Text;
            endereco = txtEndereco.Text;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            leCliente();
        }

        public void leCliente()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();

            /*try
           {
                conn.Open();
                string query = "SELECT * FROM cliente ORDER BY id_cliente";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbId.Items.Clear();
                cbId.Items.Add("");
                while (ler.Read())
                {
                    cbId.Items.Add(ler.GetString("id_cliente"));
                }
                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }*/
            try
            {
                conn.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                DataSet tabel = new DataSet();
                BindingSource bsource = new BindingSource();
                string query = "SELECT * FROM cliente";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridCliente.DataSource = dt;
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
            panel2.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
        }

        private void txtEndereco_Click(object sender, EventArgs e)
        {
            txtEndereco.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {
            txtTelefone.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" )
            {
                MessageBox.Show("Preencha os campos");
            }
            try
            {
                dado();
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                MySqlCommand cmd = conn.CreateCommand();
                
                cmd.CommandText = "INSERT INTO cliente (nome_completo,telefone,endereco) VALUES('" + nome + "','" + telefone + "','" + endereco + "')";
                conn.Open();
                cmd.ExecuteNonQuery();
                string strSQL = "SELECT * FROM cliente";
                MySqlDataAdapter da = new MySqlDataAdapter(strSQL, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridCliente.DataSource = dt;
                MessageBox.Show("Cadastro efeituado com sucesso!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";

        }
    }
}
