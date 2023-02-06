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
    public partial class EditarCategoria : Form
    {
        string nome, id;
        MySqlDataReader ler;
        MySqlCommand comando;
        public EditarCategoria()
        {
            InitializeComponent();
        }

        public void dado()
        {
            id = cbId.Text;
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
                string query = "SELECT * FROM categoria ORDER BY id";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbId.Items.Clear();
                cbId.Items.Add("");
                while (ler.Read())
                {
                    cbId.Items.Add(ler.GetString("id"));
                    //cbId.Items.Add(ler.GetString("nome"));
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
        private void cbId_Click(object sender, EventArgs e)
        {
            cbId.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbId.Text == "")
            {
                txtNome.Text = "";
           
            }
            else
            {
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                comando = conn.CreateCommand();

                try
                {
                    conn.Open();
                    string query = "SELECT * FROM categoria where id='" + cbId.Text + "'";
                    comando = new MySqlCommand(query, conn);
                    ler = comando.ExecuteReader();
                    while (ler.Read())
                    {
                        txtNome.Text = ler.GetString("nome");
                        
                    }
                    conn.Close();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
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
                cmd.CommandText = "DELETE FROM categoria WHERE id='" + id + "'";
                conn.Open();
                cmd.ExecuteNonQuery();
                ler = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Categoria removida com sucesso!");
                leCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cbId.Text = "";
            txtNome.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || cbId.Text == "")
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
                    cmd.CommandText = "UPDATE categoria SET nome='" + nome + "'WHERE id='" + id + "'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    ler = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Actualização efectuada com sucesso");
                    leCategoria();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cbId.Text = "";
            txtNome.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void EditarCategoria_Load(object sender, EventArgs e)
        {
            leCategoria();
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
        }
    }
}
