using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;  
using Controllers;
using Models;

  public class AtualizarUsuario : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblEmail;
        Label lblSenha;
        TextBox txtNome;
        TextBox txtEmail;
        TextBox txtSenha;
        Button btnConfirm;
        Button btnCancel;
        Usuarios parent;
        int id;

        public AtualizarUsuario(Usuarios parent)
        {
            this.parent = parent;
            ListViewItem item = this.parent.listView.SelectedItems[0];
            int id = Convert.ToInt32(item.Text);
            this.id = id;
            Usuario usuario = UsuarioController.GetUsuario(id);

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(10, 20);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(10, 110);
            
            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(10, 110);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);
            this.txtNome.Text = usuario.Nome;

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 135);
            this.txtEmail.Size = new Size(280, 30);
            this.txtEmail.Text = usuario.Email;

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 135);
            this.txtSenha.Size = new Size(280, 30);
            this.txtSenha.Text = usuario.Senha;

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(60, 200);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 200);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Usuário ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
           try 
            {
                UsuarioController.AlterarUsuario(this.id, this.txtNome.Text, this.txtEmail.Text, this.txtSenha.Text);
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                this.parent.loadList();
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }