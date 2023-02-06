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
    public partial class PerfilCaixa : Form
    {
        MySqlCommand comando;
        MySqlDataReader ler;
        string user, senha;
        public PerfilCaixa()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void dado()
        {
            user = txtUser.Text;
            senha = txtSenha.Text;
        }
        public void lerdados()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            // comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM caixa ORDER BY cod_caixa";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                //cbId.Items.Clear();
                // cbId.Items.Add("");
                while (ler.Read())
                {
                    txtUser.Text = ler.GetString("user");
                    txtSenha.Text = ler.GetString("senha");


                }

                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtSenha.Text == "")
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
                    cmd.CommandText = "UPDATE caixa SET  user='" + user + "',  senha='" + senha + "' order by cod_caixa";
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
            txtUser.Text = "";
            txtSenha.Text = "";
        }

        private void PerfilCaixa_Load(object sender, EventArgs e)
        {
            lerdados();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
