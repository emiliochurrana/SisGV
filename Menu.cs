using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SisGV
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CustumaizeDesign();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CustumaizeDesign()
        {
            panelFuncSubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelFuncSubMenu.Visible == true)
                panelFuncSubMenu.Visible = false;
        }
        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;

        }

        private void btnproduto_Click(object sender, EventArgs e)
        {

        }

        private void btnvendas_Click(object sender, EventArgs e)
        {
            VerVendas v = new VerVendas();
            v.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            PerfilAdmin p = new PerfilAdmin(); 
            p.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnfuncionario_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelFuncSubMenu);
        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Funcionario());
            hideSubMenu();
        }

       
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                openChildForm(new VerFuncionario());
                hideSubMenu();
            
        }


        private void btnslide_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 66)
            {
                panelMenu.Width = 209;
            }
            else
                panelMenu.Width = 66;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l=new Login();
            l.Show();
            //Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;

        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEstatistica_Click(object sender, EventArgs e)
        {
            openChildForm(new Estatisticas());
            hideSubMenu();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            // openChildForm(new PerfilAdmin());
            //hideSubMenu();
            PerfilAdmin p = new PerfilAdmin();
            p.Show();
        }

        private void btnPerfil_Click_2(object sender, EventArgs e)
        {
            //openChildForm(new PerfilAdmin());
            //hideSubMenu();
            PerfilAdmin p = new PerfilAdmin();
            p.Show();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btnProduto_Click_1(object sender, EventArgs e)
        {
            openChildForm(new VerProduto());
            hideSubMenu();
        }

        private void btnVendas_Click_1(object sender, EventArgs e)
        {
            openChildForm(new VerVendas());
            hideSubMenu();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            openChildForm(new EditarFuncionario());
            hideSubMenu();
        }
    }
}
