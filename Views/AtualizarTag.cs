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

namespace Views {
  public class AtualizarTag : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        TextBox txtDescricao;
        Button btnConfirm;
        Button btnCancel;
        Tags parent;
        int id;

        public AtualizarTag(Tags parent)
        {
            this.parent = parent;
            ListViewItem item = this.parent.listView.SelectedItems[0];
            int id = Convert.ToInt32(item.Text);
            this.id = id;
            Tag tag = TagController.GetTag(id);

            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Tag";
            this.lblDescricao.Location = new Point(10, 20);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);
            this.txtDescricao.Text = tag.Descricao;

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

            this.Controls.Add(this.lblDescricao);

            this.Controls.Add(this.txtDescricao);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Tag ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
           try 
            {
                TagController.AlterarTag(this.id, this.txtDescricao.Text);
                MessageBox.Show("Tag cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK);
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
}