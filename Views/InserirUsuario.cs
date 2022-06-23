using System;
using System.Windows.Forms;
using System.Drawing;
using Controllers;


   public class InserirUsuario : Form 
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

        public InserirUsuario(Usuarios parent)
        {
            this.parent = parent;

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(10, 20);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(10, 90);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(10, 145);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 115);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 170);
            this.txtSenha.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(60, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 220);
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
            this.Text = "Inserir Usuário ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            try 
            {
                UsuarioController.IncluirUsuario(this.txtNome.Text, this.txtEmail.Text , this.txtSenha.Text);
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
            Close();
        }
    }