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
    public partial class EditarCliente : Form
    {
        string id, nome, telefone, endereco;
        MySqlDataReader ler;
        MySqlCommand comando;
        public EditarCliente()
        {
            InitializeComponent();
        }

        public void dado()
        {
            id = cbId.Text;
            nome = txtNome.Text;
            telefone = txtTelefone.Text;
            endereco = txtEndereco.Text;
        }
        public void leCliente()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();

            try
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
            }
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

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            leCliente();
        }

        private void cbId_Click(object sender, EventArgs e)
        {
            cbId.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
        }

        private void txtEndereco_Click(object sender, EventArgs e)
        {
            txtEndereco.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbId.Text == "")
            {
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtEndereco.Text = "";
            }
            else
            {
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                comando = conn.CreateCommand();

                try
                {
                        conn.Open();
                        string query = "SELECT * FROM cliente where id_cliente='" + cbId.Text + "'";
                        comando = new MySqlCommand(query, conn);
                        ler = comando.ExecuteReader();
                        while (ler.Read())
                        {
                            txtNome.Text = ler.GetString("nome_completo");
                            txtEndereco.Text = ler.GetString("endereco");
                            txtTelefone.Text = ler.GetString("telefone");
                    }
                        conn.Close();
                    
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {
            txtTelefone.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            panel2.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbId.Text == "")
            {

                MessageBox.Show("Preencha o Id");
            }
            try
            {
                dado();
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM cliente WHERE id_cliente='" + id + "'";
                conn.Open();
                cmd.ExecuteNonQuery();
                ler = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Cliente removido com sucesso!");
                leCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || cbId.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "")
            {

                MessageBox.Show("Preencha os campos");
            }
            else
            {
                try
                {
                    dado();
                    string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                    MySqlConnection conn = new MySqlConnection(conex);
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE cliente SET nome_completo='" + nome + "', telefone='" + telefone + "', endereco='" + endereco + "'WHERE id_cliente='" + id + "'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    ler = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Actualização efectuada com sucesso");
                    leCliente();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cbId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        
    }
            
    }
}
