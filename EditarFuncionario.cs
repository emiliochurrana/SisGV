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
    public partial class EditarFuncionario : Form
    {
        string escolha, escolhaest;
        String nome, data, gen, est, email, ender, senha, tel, id, username;
        MySqlDataReader ler;
        MySqlCommand comando;

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCategoria_Click(object sender, EventArgs e)
        {
            cbCategoria.BackColor = Color.White;
            panel11.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.ControlText;
            txtNomeCom.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtDataNasc.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void cbId_Click(object sender, EventArgs e)
        {
            cbId.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel11.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.ControlText;
            txtNomeCom.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtDataNasc.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;

        }

        private void txtNomeCom_Click(object sender, EventArgs e)
        {
            txtNomeCom.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel11.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtDataNasc.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void cbGenero_Click(object sender, EventArgs e)
        {
            cbGenero.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel11.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.ControlText;
            txtNomeCom.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtDataNasc.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void cbEstadoCivil_Click(object sender, EventArgs e)
        {
            cbEstadoCivil.BackColor = Color.White;
            panel6.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel11.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.ControlText;
            txtNomeCom.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtDataNasc.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
            panel7.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel11.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.ControlText;
            txtNomeCom.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            txtDataNasc.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {
            txtTelefone.BackColor = Color.White;
            panel8.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel11.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.ControlText;
            txtNomeCom.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtDataNasc.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void txtEndereco_Click(object sender, EventArgs e)
        {
            txtEndereco.BackColor = Color.White;
            panel9.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel11.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.ControlText;
            txtNomeCom.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtDataNasc.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbId_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbId.Text == "") {
                txtNomeCom.Text = "";
                txtDataNasc.Text = "";
                cbGenero.Text = "";
                cbEstadoCivil.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";
                txtEndereco.Text = "";
                txtUser.Text = "";
                txtSenha.Text = "";
            }
            else
            {
                string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                MySqlConnection conn = new MySqlConnection(conex);
                comando = conn.CreateCommand();

                try
                {
                    if (cbCategoria.Text == "Gerente")
                    {
                        conn.Open();
                        string query = "SELECT * FROM atendente where cod_atend='" + cbId.Text + "'";
                        comando = new MySqlCommand(query, conn);
                        ler = comando.ExecuteReader();
                        while (ler.Read())
                        {
                            txtNomeCom.Text = ler.GetString("nome_completo");
                            txtDataNasc.Text = ler.GetString("data_nasc");
                            cbGenero.Text = ler.GetString("genero");
                            cbEstadoCivil.Text = ler.GetString("estado_civil");
                            txtEmail.Text = ler.GetString("email");
                            txtTelefone.Text = ler.GetString("telefone");
                            txtEndereco.Text = ler.GetString("endereco");
                            txtUser.Text = ler.GetString("user");
                            txtSenha.Text = ler.GetString("senha");

                        }
                        conn.Close();
                    }
                    if (cbCategoria.Text == "Caixa")
                    {
                        conn.Open();
                        string query = "SELECT * FROM caixa where cod_caixa='" + cbId.Text + "'";
                        comando = new MySqlCommand(query, conn);
                        ler = comando.ExecuteReader();
                        while (ler.Read())
                        {
                            txtNomeCom.Text = ler.GetString("nome_completo");
                            txtDataNasc.Text = ler.GetString("data_nasc");
                            cbGenero.Text = ler.GetString("genero");
                            cbEstadoCivil.Text = ler.GetString("estado_civil");
                            txtEmail.Text = ler.GetString("email");
                            txtTelefone.Text = ler.GetString("telefone");
                            txtEndereco.Text = ler.GetString("endereco");
                            txtUser.Text = ler.GetString("user");
                            txtSenha.Text = ler.GetString("senha");

                        }
                        conn.Close();
                    }
                    if (cbCategoria.Text == "Gestor de Stock")
                    {
                        conn.Open();
                        string query = "SELECT * FROM gestor where cod_gest='" + cbId.Text + "'";
                        comando = new MySqlCommand(query, conn);
                        ler = comando.ExecuteReader();
                        while (ler.Read())
                        {
                            txtNomeCom.Text = ler.GetString("nome_completo");
                            txtDataNasc.Text = ler.GetString("data_nasc");
                            cbGenero.Text = ler.GetString("genero");
                            cbEstadoCivil.Text = ler.GetString("estado_civil");
                            txtEmail.Text = ler.GetString("email");
                            txtTelefone.Text = ler.GetString("telefone");
                            txtEndereco.Text = ler.GetString("endereco");
                            txtUser.Text = ler.GetString("user");
                            txtSenha.Text = ler.GetString("senha");

                        }
                        conn.Close();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void txtSenha_Click_1(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
            panel14.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            panel11.BackColor = SystemColors.ControlText;
            txtNomeCom.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtDataNasc.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;

        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.White;
            panel10.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            panel11.BackColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.ControlText;
            txtNomeCom.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtDataNasc.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void txtDataNasc_MouseCaptureChanged(object sender, EventArgs e)
        {
            txtDataNasc.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel11.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel9.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            panel14.BackColor = SystemColors.ControlText;
            txtNomeCom.BackColor = SystemColors.ControlText;
            cbId.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtUser.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
       
        }

        private void btnSeleciona_Click_1(object sender, EventArgs e)
        {
            if (cbCategoria.Text == "Gerente")
            {
                leGerente();
            }
            else if (cbCategoria.Text == "Caixa")
            {
                leCaixa();
            }
            else if (cbCategoria.Text == "Gestor de Stock")
            {
                leGestStock();
            }
            cbId.Text = "";
            txtNomeCom.Text = "";
            txtDataNasc.Text = "";
            cbGenero.Text = "";
            cbEstadoCivil.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtUser.Text = "";
        }

        /*private void EditarFuncionario_Load(object sender, EventArgs e)
        {*/


        // }
        public EditarFuncionario()
        {
          
            InitializeComponent();
        }

        public void dados()
        {
            id = cbId.Text;
            nome = txtNomeCom.Text;
            data = txtDataNasc.Text;
            ender = txtEndereco.Text;
            gen = cbGenero.Text;
            est = cbEstadoCivil.Text;
            email = txtEmail.Text;
            username = txtUser.Text;
            senha = txtUser.Text;
            tel = txtTelefone.Text;

        }

        public void leGerente()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
             comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM atendente ORDER BY cod_atend";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbId.Items.Clear();
                cbId.Items.Add("");
                while (ler.Read())
                {
                    cbId.Items.Add(ler.GetString("cod_atend"));
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
                string query = "SELECT * FROM atendente";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridFuncionario.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void leCaixa()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
            comando = conn.CreateCommand();
            try
            {
                conn.Open();
                string query = "SELECT * FROM caixa ORDER BY cod_caixa";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbId.Items.Clear();
                cbId.Items.Add("");
                while (ler.Read())
                {
                    cbId.Items.Add(ler.GetString("cod_caixa"));
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
                string query = "SELECT * FROM caixa";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridFuncionario.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void leGestStock()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
           comando = conn.CreateCommand();

            try
            {
                conn.Open();
                string query = "SELECT * FROM gestor ORDER BY cod_gest";
                comando = new MySqlCommand(query, conn);
                ler = comando.ExecuteReader();
                cbId.Items.Clear();
                cbId.Items.Add("");
                while (ler.Read())
                {
                    cbId.Items.Add(ler.GetString("cod_gest"));
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
                string query = "SELECT * FROM gestor";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridFuncionario.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            if (cbCategoria.Text == "")
            {
                MessageBox.Show("Escolha a categoria do funcionario");

            }
            else if (cbCategoria.Text == "Gerente")
            {
                  if (txtNomeCom.Text == "" || cbId.Text==""|| txtDataNasc.Text == "" || cbGenero.Text == "" || cbEstadoCivil.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtUser.Text == "")
                {
                   
                   MessageBox.Show("Preencha os campos");
                }
                try
                {
                    dados();
                    string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                    MySqlConnection conn = new MySqlConnection(conex);
                    MySqlCommand cmd = conn.CreateCommand();
                    //escolha do  genero
                    if (escolha == "Masculino")
                    {
                        cbGenero.Text = "Masculino";
                    }
                    else if (escolha == "Feminino")
                    {
                        cbGenero.Text = "Feminino";
                    }
                    else if (escolha == "Outro")
                    {
                        cbGenero.Text = "Outro";
                    }
                    //escolha de estado civil 
                    if (escolhaest == "Solteiro")
                    {
                        cbEstadoCivil.Text = "Solteiro";
                    }
                    else if (escolhaest == "Casado")
                    {
                        cbEstadoCivil.Text = "Casado";
                    }
                    cmd.CommandText = "UPDATE atendente SET nome_completo='" + nome + "', data_nasc='" + data + "', genero='" + gen + "', estado_civil='" + est + "', email='" + email + "', telefone='" + tel + "', endereco='" + ender + "', user='"+username+"', senha='" + senha + "' WHERE cod_atend='"+id+"'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    ler = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Actualização efectuada com sucesso");
                    leGerente();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (cbCategoria.Text == "Caixa")
            {
                if (txtNomeCom.Text == "" || cbId.Text == "" || txtDataNasc.Text == "" || cbGenero.Text == "" || cbEstadoCivil.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtUser.Text == "")
                {
                    
                   MessageBox.Show("Preencha os campos");
                }
                try
                {
                    dados();
                    string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                    MySqlConnection conn = new MySqlConnection(conex);
                    MySqlCommand cmd = conn.CreateCommand();
                    //escolha do  genero
                    if (escolha == "Masculino")
                    {
                        cbGenero.Text = "Masculino";
                    }
                    else if (escolha == "Feminino")
                    {
                        cbGenero.Text = "Feminino";
                    }
                    else if (escolha == "Outro")
                    {
                        cbGenero.Text = "Outro";
                    }
                    //escolha de estado civil 
                    if (escolhaest == "Solteiro")
                    {
                        cbEstadoCivil.Text = "Solteiro";
                    }
                    else if (escolhaest == "Casado")
                    {
                        cbEstadoCivil.Text = "Casado";
                    }

                    cmd.CommandText = "UPDATE caixa SET  nome_completo = '" + nome + "', data_nasc = '" + data + "', genero = '" + gen + "', estado_civil = '" + est + "', email = '" + email + "', telefone = '" + tel + "', endereco = '" + ender + "', user='"+username+"', senha = '" + senha + "' WHERE cod_caixa='"+id+"'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    ler = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Actualização efectuada com sucesso");
                    leCaixa();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (cbCategoria.Text == "Gestor de Stock")
            {
                
                if (txtNomeCom.Text == "" || cbId.Text == "" || txtDataNasc.Text == "" || cbGenero.Text == "" || cbEstadoCivil.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtUser.Text == "")
                {
                    
                    MessageBox.Show("Preencha os campos");
                }
                try
                {
                    dados();
                    string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                    MySqlConnection conn = new MySqlConnection(conex);
                    MySqlCommand cmd = conn.CreateCommand();
                    //escolha do  genero
                    if (escolha == "Masculino")
                    {
                        cbGenero.Text = "Masculino";
                    }
                    else if (escolha == "Feminino")
                    {
                        cbGenero.Text = "Feminino";
                    }
                    else if (escolha == "Outro")
                    {
                        cbGenero.Text = "Outro";
                    }
                    //escolha de estado civil 
                    if (escolhaest == "Solteiro")
                    {
                        cbEstadoCivil.Text = "Solteiro";
                    }
                    else if (escolhaest == "Casado")
                    {
                        cbEstadoCivil.Text = "Casado";
                    }
                    cmd.CommandText = "UPDATE gestor SET nome_completo = '" + nome + "', data_nasc = '" + data + "', genero = '" + gen + "', estado_civil = '" + est + "', email = '" + email + "', telefone = '" + tel + "', endereco = '" + ender + "', user='" + username + "', senha = '" + senha + "' WHERE cod_gest='"+id+"'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    ler = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Actualização efectuada com sucesso");
                    leGestStock();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            cbId.Text = "";
            txtNomeCom.Text = "";
            txtDataNasc.Text = "";
            cbGenero.Text = "";
            cbEstadoCivil.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtUser.Text = "";
            txtSenha.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbCategoria.Text == "")
            {
                MessageBox.Show("Escolha a categoria do funcionario");

            }
            else if (cbCategoria.Text == "Gerente")
            {
                if (cbId.Text=="")
                {

                    MessageBox.Show("Preencha o Id");
                }
                try
                {
                    dados();
                    string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                    MySqlConnection conn = new MySqlConnection(conex);
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM atendente WHERE cod_atend='"+id+"'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    ler = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Gerente removido com sucesso!");
                    leGerente();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (cbCategoria.Text == "Caixa")
            {
                if (cbId.Text=="")
                {

                    MessageBox.Show("Preencha o Id");
                }
                try
                {
                    dados();
                    string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                    MySqlConnection conn = new MySqlConnection(conex);
                    MySqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "DELETE FROM caixa WHERE cod_caixa='"+id+"'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    ler = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Caixa removido com sucesso!");
                    leCaixa();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (cbCategoria.Text == "Gestor de Stock")
            {

                if (cbId.Text=="")
                {

                    MessageBox.Show("Preencha o id");
                }
                try
                {
                    dados();
                    string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                    MySqlConnection conn = new MySqlConnection(conex);
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM gestor WHERE cod_gest='"+id+"'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    ler = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Gestor de stock removido com sucesso!");
                    leGestStock();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            cbId.Text = "";

        }
    }
}
