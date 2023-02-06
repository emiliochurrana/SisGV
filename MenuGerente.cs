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
    public partial class MenuGerente : Form
    {
        public MenuGerente()
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
            panelClieSubMenu.Visible = false;
            panelCotSubMenu.Visible = false;
            panelFactSubMenu.Visible = false;
            panelVenSubMenu.Visible = false;
            panelProSubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelClieSubMenu.Visible == true)
                panelClieSubMenu.Visible = false;

            if (panelCotSubMenu.Visible == true)
                panelCotSubMenu.Visible = false;

            if (panelFactSubMenu.Visible == true)
                panelFactSubMenu.Visible = false;

            if (panelVenSubMenu.Visible == true)
                panelVenSubMenu.Visible = false;

            if (panelProSubMenu.Visible == true)
                panelProSubMenu.Visible = false;
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
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClieSubMenu);
        }

        private void btnCotacoes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCotSubMenu);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFactSubMenu);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVenSubMenu);
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProSubMenu);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            openChildForm(new Cliente());
            hideSubMenu();
        }

        private void btnVisualClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new VerCliente());
            hideSubMenu();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new EditarCliente());
            hideSubMenu();
        }

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 65)
            {
                panelMenu.Width = 209;
            }
            else
                panelMenu.Width = 65;
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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

        private void btnUserMale_Click(object sender, EventArgs e)
        {
            PerfilGerente p = new PerfilGerente();
            p.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            PerfilGerente p = new PerfilGerente();
            p.Show();
        }
    }
}
