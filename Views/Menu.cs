using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Views
{
    public class Home : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblLogin;
        Button btnCategorias;
        Button btnTags;
        Button btnSenhas;
        Button btnUsuario;
        Button btnCancel;

        public Home()
        {
            this.lblLogin = new Label();
            this.lblLogin.Text = "Olá Usuário";
            this.lblLogin.Location = new Point(117, 20);

            this.btnCategorias = new Button();
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.Location = new Point(40, 60);
            this.btnCategorias.Size = new Size(100, 30);
            this.btnCategorias.Click += new EventHandler(this.handleCategoriaClick);


            this.btnTags = new Button();
            this.btnTags.Text = "Tags";
            this.btnTags.Location = new Point(160, 60);
            this.btnTags.Size = new Size(100, 30);
            this.btnTags.Click += new EventHandler(this.handleTagClick);

            this.btnUsuario = new Button();
            this.btnUsuario.Text = "Usuários";
            this.btnUsuario.Location = new Point(160, 100);
            this.btnUsuario.Size = new Size(100, 30);
            this.btnUsuario.Click += new EventHandler(this.handleUsuarioClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Sair";
            this.btnCancel.Location = new Point(110, 200);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblLogin);

            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnTags);
            this.Controls.Add(this.btnSenhas);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnCancel);

        }
        private void handleTagClick(object sender, EventArgs e)
        {
            Tags menu = new Tags();
            menu.ShowDialog();
        }
        private void handleCategoriaClick(object sender, EventArgs e)
        {
            Categorias menu = new Categorias();
            menu.ShowDialog();
        }
        private void handleUsuarioClick(object sender, EventArgs e)
        {
            Usuarios menu = new Usuarios();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}