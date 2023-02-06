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
using System.Runtime.InteropServices;

namespace SisGV
{
    public partial class PerfilAdmin : Form
    {
        MySqlCommand comando;
        MySqlDataReader ler;
        string user,nome, senha;
        public PerfilAdmin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private Form activeForm = null;
        public void dado()
        {
            nome = txtNome.Text;
            user = txtUser.Text;
            senha = txtSenha.Text;
        }

        private void PerfimAdmin_Load(object sender, EventArgs e)
        {
            lerdados();
        }

        public void lerdados()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            // comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM administrador ORDER BY id_admin";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                //cbId.Items.Clear();
                // cbId.Items.Add("");
               while (ler.Read())
                {
                    //cbId.Items.Add(ler.GetString("id_admin"));
                    txtNome.Text = ler.GetString("nome");
                    txtUser.Text = ler.GetString("user");
                    txtSenha.Text = ler.GetString("senha");


                }

                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
           /*try
            {
                conn.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                DataSet tabel = new DataSet();
                BindingSource bsource = new BindingSource();
                string query = "SELECT * FROM administrador";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridAdmin.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtUser.Text == "" || txtSenha.Text == "")
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
                    cmd.CommandText = "UPDATE administrador SET nome='"+nome+"', user='" + user + "',  senha='" + senha + "' order by id_admin";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    ler = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Actualização efectuada com sucesso");
                    lerdados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            txtNome.Text = "";
            txtUser.Text = "";
            txtSenha.Text = "";
        }
    }
}
