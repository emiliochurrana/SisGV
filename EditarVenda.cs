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
    public partial class EditarVenda : Form
    {
        MySqlCommand comando;
        MySqlDataReader ler;
        string id, observacao;
        public EditarVenda()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void dado()
        {
            id = cbIdVenda.Text;
            observacao = txtObservacao.Text;
        }
        public void lerdados()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            // comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM venda ORDER BY id_venda";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbIdVenda.Items.Clear();
                cbIdVenda.Items.Add("");
                while (ler.Read())
                {
                    cbIdVenda.Text = ler.GetString("id_venda");
                    


                }

                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void cbIdVenda_Click(object sender, EventArgs e)
        {
            cbIdVenda.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.ControlText;
            txtObservacao.BackColor = SystemColors.ControlText;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cbIdVenda.Text == "" || txtObservacao.Text == "")
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
                    cmd.CommandText = "UPDATE venda SET  observacao='" + observacao + "' order by id_venda";
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
            cbIdVenda.Text = " ";
            txtObservacao.Text = " ";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Barra_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cbIdVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdVenda.Text == "")
            {
                txtObservacao.Text = "";
            }
            else
            {
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                comando = conn.CreateCommand();

                try
                {
                    conn.Open();
                    string query = "SELECT * FROM venda where id_venda='" + cbIdVenda.Text + "'";
                    comando = new MySqlCommand(query, conn);
                    ler = comando.ExecuteReader();
                    while (ler.Read())
                    {
                        txtObservacao.Text = ler.GetString("observacao");

                    }
                    conn.Close();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void EditarVenda_Load(object sender, EventArgs e)
        {
            lerdados();
        }

        private void txtObservacao_Click(object sender, EventArgs e)
        {
            txtObservacao.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.ControlText;
            cbIdVenda.BackColor = SystemColors.ControlText;
        }
    }
}
