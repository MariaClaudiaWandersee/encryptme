using System;
using System.Windows.Forms;
using System.Drawing;
using Controllers;

namespace Views {
   public class InserirTag : Form 
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        TextBox txtDescricao;
        Button btnConfirm;
        Button btnCancel;
        Tags parent;

        public InserirTag(Tags parent)
        {
            this.parent = parent;

            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descricao";
            this.lblDescricao.Location = new Point(10, 20);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

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

            this.Controls.Add(this.lblDescricao);

            this.Controls.Add(this.txtDescricao);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Tag ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            try 
            {
                TagController.IncluirTag(this.txtDescricao.Text);
                MessageBox.Show("Tag cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);
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
}