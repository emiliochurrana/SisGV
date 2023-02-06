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
    public partial class Funcionario : Form
    {
        string escolha, escolhaest;
        String nome, data, gen, est, email, ender, senha, tel;

        private void txtdata_MouseCaptureChanged(object sender, EventArgs e)
        {
            txtdata.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel1.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;

        }

        private void cbGenero_Click(object sender, EventArgs e)
        {
            cbGenero.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel1.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtdata.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;

        }

        private void cbEstadoCivil_Click(object sender, EventArgs e)
        {
            cbEstadoCivil.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel1.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtdata.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
            panel6.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel1.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            txtdata.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {
            txtTelefone.BackColor = Color.White;
            panel7.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel1.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtdata.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void txtEndereco_Click(object sender, EventArgs e)
        {
            txtEndereco.BackColor = Color.White;
            panel8.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel1.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtdata.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
            panel10.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel1.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtdata.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel1.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            cbCategoria.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtdata.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }

        private void cbCategoria_Click(object sender, EventArgs e)
        {
            cbCategoria.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel2.BackColor = SystemColors.ControlText;
            panel3.BackColor = SystemColors.ControlText;
            panel4.BackColor = SystemColors.ControlText;
            panel5.BackColor = SystemColors.ControlText;
            panel6.BackColor = SystemColors.ControlText;
            panel7.BackColor = SystemColors.ControlText;
            panel8.BackColor = SystemColors.ControlText;
            panel10.BackColor = SystemColors.ControlText;
            txtNome.BackColor = SystemColors.ControlText;
            cbGenero.BackColor = SystemColors.ControlText;
            cbEstadoCivil.BackColor = SystemColors.ControlText;
            txtEmail.BackColor = SystemColors.ControlText;
            txtdata.BackColor = SystemColors.ControlText;
            txtEndereco.BackColor = SystemColors.ControlText;
            txtTelefone.BackColor = SystemColors.ControlText;
            txtSenha.BackColor = SystemColors.ControlText;
        }
        private void btnSeleciona_Click(object sender, EventArgs e)
        {
            if (cbCategoria.Text == "")
            {
                MessageBox.Show("Escolha a categoria do funcionario");

            }
            else if (cbCategoria.Text == "Gerente")
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
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        public Funcionario()
        {
            InitializeComponent();
        }
        public void dados()
        {
            nome = txtNome.Text;
            data = txtdata.Text;
            ender = txtEndereco.Text;
            gen = cbGenero.Text;
            est = cbEstadoCivil.Text;
            email = txtEmail.Text;
            senha = txtSenha.Text;
            tel = txtTelefone.Text;

        }
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            dados();
            if (cbCategoria.Text == "")
            {
                MessageBox.Show("Escolha a categoria do funcionario");

            }
            else if (cbCategoria.Text == "Gerente")
            {
                if (txtNome.Text == "" || txtdata.Text == "" || cbGenero.Text == "" || cbEstadoCivil.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha os campos");
                }
                try
                {
                    string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
                    MySqlConnection conn = new MySqlConnection(conex);
                    MySqlCommand cmd = conn.CreateCommand();
                    //string admin = "SELECT * FROM administrador order by id";

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
                    cmd.CommandText = "INSERT INTO atendente (nome_completo, data_nasc, genero, estado_civil, email, telefone, endereco, user, senha) VALUES('" + nome + "','" + data + "','" + gen + "','" + est + "','" + email + "','" + tel + "','" + ender + "','"+email+"','" + senha + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    string strSQL = "SELECT * FROM atendente";
                    MySqlDataAdapter da = new MySqlDataAdapter(strSQL, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridFuncionario.DataSource = dt;
                    MessageBox.Show("Cadastro do Gerente efeituado com sucesso!");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cbCategoria.Text == "Caixa")
            {
                if (txtNome.Text == "" || txtdata.Text == "" || cbGenero.Text == "" || cbEstadoCivil.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha os campos");
                }
                try
                {
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
                    cmd.CommandText = "INSERT INTO caixa (nome_completo, data_nasc, genero, estado_civil, email, telefone, endereco, user, senha) VALUES('" + nome + "','" + data + "','" + gen + "','" + est + "','" + email + "','" + tel + "','" + ender + "', '"+email+"','" + senha + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    string strSQL = "SELECT * FROM caixa";
                    MySqlDataAdapter da = new MySqlDataAdapter(strSQL, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridFuncionario.DataSource = dt;
                    MessageBox.Show("Cadastro do Caixa efeituado com sucesso!");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cbCategoria.Text == "Gestor de Stock")
            {
                if (txtNome.Text == "" || txtdata.Text == "" || cbGenero.Text == "" || cbEstadoCivil.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha os campos");
                }
                try
                {
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
                    cmd.CommandText = "INSERT INTO gestor (nome_completo, data_nasc, genero, estado_civil, email, telefone, endereco, user, senha) VALUES('" + nome + "','" + data + "','" + gen + "','" + est + "','" + email + "','" + tel + "','" + ender + "', '"+email+"','" + senha + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    string strSQL = "SELECT * FROM gestor";
                    MySqlDataAdapter da = new MySqlDataAdapter(strSQL, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridFuncionario.DataSource = dt;
                    MessageBox.Show("Cadastro do Gestor de Stock efeituado com sucesso!");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            cbCategoria.Text = "";
            txtNome.Text = "";
            txtdata.Text = "";
            cbGenero.Text = "";
            cbEstadoCivil.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtSenha.Text = "";
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void leGerente()
        {
            string conex = "Server = localhost; Database = sistemagestaovenda; Uid = root";
            MySqlConnection conn = new MySqlConnection(conex);
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
            // comando = conn.CreateCommand();
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

    }
    }

