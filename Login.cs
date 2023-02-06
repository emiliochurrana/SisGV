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
    public partial class Login : Form
    {
        int contador;
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void barraLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconrestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void btnlogar_Click_1(object sender, EventArgs e)
        {
            if (cbperfil.Text == "")
            {
                MessageBox.Show("Escolha o perfil!");
            }
            else
            {
                //Login do Administrador 
                if (cbperfil.Text == "Admin")
                {
                    if (txtuser.Text == "" || txtSenha.Text == "")
                    {
                        MessageBox.Show("Por favor preenchar os campos");
                        return;
                    }
                    try
                    {
                        string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                        MySqlConnection conn = new MySqlConnection(conex);
                        MySqlCommand cmd = new MySqlCommand("Select * from administrador where user=@username and senha=@password", conn);
                        cmd.Parameters.AddWithValue("@username", txtuser.Text);
                        cmd.Parameters.AddWithValue("@password", txtSenha.Text);
                        conn.Open();
                        MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapt.Fill(ds);
                        conn.Close();
                        contador = ds.Tables[0].Rows.Count;
                        if (contador == 1)
                        {
                            MessageBox.Show("Bem vindo ao ambiente do administrador do sistema");
                            this.Hide();
                            Menu m = new Menu();
                            m.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nome do usuario/senha invalida");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }

                //Login Genrente da Loja 
                if (cbperfil.Text == "Gerente")
                {
                    if (txtuser.Text == "" || txtSenha.Text == "")
                    {
                        MessageBox.Show("Por favor preenchar os campos");
                        return;
                    }
                    try
                    {
                        string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                        MySqlConnection conn = new MySqlConnection(conex);
                        MySqlCommand cmd = new MySqlCommand("Select * from atendente where user=@username and senha=@password", conn);
                        cmd.Parameters.AddWithValue("@username", txtuser.Text);
                        cmd.Parameters.AddWithValue("@password", txtSenha.Text);
                        conn.Open();
                        MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapt.Fill(ds);
                        conn.Close();
                        contador = ds.Tables[0].Rows.Count;
                        if (contador == 1)
                        {
                            MessageBox.Show("Bem vindo ao ambiente do Gerente da Loja");
                            this.Hide();
                            MenuGerente m = new MenuGerente();
                            m.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nome do usuario/senha invalida");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }

                //Login do caixa da Loja 
                if (cbperfil.Text == "Caixa")
                {
                    if (txtuser.Text == "" || txtSenha.Text == "")
                    {
                        MessageBox.Show("Por favor preenchar os campos");
                        return;
                    }
                    try
                    {
                        string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                        MySqlConnection conn = new MySqlConnection(conex);
                        MySqlCommand cmd = new MySqlCommand("Select * from caixa where user=@username and senha=@password", conn);
                        cmd.Parameters.AddWithValue("@username", txtuser.Text);
                        cmd.Parameters.AddWithValue("@password", txtSenha.Text);
                        conn.Open();
                        MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapt.Fill(ds);
                        conn.Close();
                        contador = ds.Tables[0].Rows.Count;
                        if (contador == 1)
                        {
                            MessageBox.Show("Bem vindo ao ambiente do caixa da loja");
                            this.Hide();
                            MenuCaixa v = new MenuCaixa();
                            v.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nome do usuario/senha invalida");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }

                //Login do Gestor de Stock da Loja 
                if (cbperfil.Text == "Gestor de Stock")
                {
                    if (txtuser.Text == "" || txtSenha.Text == "")
                    {
                        MessageBox.Show("Por favor preenchar os campos");
                        return;
                    }
                    try
                    {
                        string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                        MySqlConnection conn = new MySqlConnection(conex);
                        MySqlCommand cmd = new MySqlCommand("Select * from gestor where user=@username and senha=@password", conn);
                        cmd.Parameters.AddWithValue("@username", txtuser.Text);
                        cmd.Parameters.AddWithValue("@password", txtSenha.Text);
                        conn.Open();
                        MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapt.Fill(ds);
                        conn.Close();
                        contador = ds.Tables[0].Rows.Count;
                        if (contador == 1)
                        {
                            MessageBox.Show("Bem vindo ao ambiente do Stock da loja");
                            this.Hide();
                            var user = txtSenha.Text;
                            MenuStock m = new MenuStock(user);
                            m.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nome do usuario/senha invalida");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
        }

        private void cbperfil_Click_1(object sender, EventArgs e)
        {
            cbperfil.BackColor = Color.White;
            panel6.BackColor = Color.White;
           panel7.BackColor = SystemColors.HotTrack;
            panel5.BackColor = SystemColors.HotTrack;
            txtuser.BackColor = SystemColors.HotTrack;
            txtSenha.BackColor = SystemColors.HotTrack;
        }
        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
            panel5.BackColor = Color.White;
            txtuser.BackColor = SystemColors.HotTrack;
            panel6.BackColor = SystemColors.HotTrack;
            panel7.BackColor = SystemColors.HotTrack;
            cbperfil.BackColor = SystemColors.HotTrack;
        }

        private void pictureBox3_MouseUp_1(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void pictureBox3_MouseDown_1(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtuser.BackColor = Color.White;
            panel7.BackColor = Color.White;
            //panel4.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.HotTrack;
            panel6.BackColor = SystemColors.HotTrack;
            cbperfil.BackColor = SystemColors.HotTrack;
            txtSenha.BackColor = SystemColors.HotTrack;
        }
    }
    }
