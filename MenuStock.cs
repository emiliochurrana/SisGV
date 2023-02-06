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
    public partial class MenuStock : Form
    {
        
        public MenuStock(string usuario)
        {
            if (usuario == null)
            {
                btnUser.Text = usuario;
            }
            
            InitializeComponent();
            CustumaizeDesign();
        }


        private void CustumaizeDesign()
        {
            panelProdSubMenu.Visible = false;
            panelCateSubMenu.Visible = false;
            panelMarSubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelProdSubMenu.Visible == true)
                panelProdSubMenu.Visible = false;

            if (panelCateSubMenu.Visible == true)
                panelCateSubMenu.Visible = false;

            if (panelMarSubMenu.Visible == true)
                panelMarSubMenu.Visible = false;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
        private void btnslide_Click_1(object sender, EventArgs e)
        {
            if (panelMenu.Width == 66)
            {
                panelMenu.Width = 209;
            }
            else
                panelMenu.Width = 66;
        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconcerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void iconrestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
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

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            PerfilStock p = new PerfilStock();
            p.Show();
        }

        private void btnProdutos_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelProdSubMenu);
        }

        private void btnCategoria_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelCateSubMenu);
        }

        private void btnMarca_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelMarSubMenu);
        }

        private void btnNovoProduto_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Produto());
            hideSubMenu();
        }

        private void btnVisualizarProd_Click_1(object sender, EventArgs e)
        {
            openChildForm(new VerProduto());
            hideSubMenu();
        }

        private void btnEditarProduto_Click_1(object sender, EventArgs e)
        {
            openChildForm(new EditProduto());
            hideSubMenu();
        }

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            openChildForm(new Categoria());
            hideSubMenu();
        }

        private void btnVizualCategoria_Click(object sender, EventArgs e)
        {
            openChildForm(new VerCategoria());
            hideSubMenu();
        }

        private void btnEditCategoria_Click(object sender, EventArgs e)
        {
            openChildForm(new EditarCategoria());
            hideSubMenu();
        }

        private void btnNovaMarca_Click(object sender, EventArgs e)
        {
            openChildForm(new Marca());
            hideSubMenu();
        }

        private void btnVerMarca_Click(object sender, EventArgs e)
        {
            openChildForm(new VerMarca());
            hideSubMenu();
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            openChildForm(new EditarMarca());
            hideSubMenu();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            PerfilStock p = new PerfilStock();
            p.Show();
        }
    }
}
