using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing; 
using Controllers;
using Models; 

namespace Views {
    public class Usuarios : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUsuario;
        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        public ListView listView;
        public Usuarios()
        {
            this.lblUsuario = new Label();
            this.lblUsuario.Text = "Usuários";
            this.lblUsuario.Location = new Point(220, 10);

            this.Controls.Add(this.lblUsuario);

            listView = new ListView();
            listView.Location = new Point(50, 70);
            listView.Size = new Size(400, 400);
            listView.View = View.Details;
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Senha", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 500);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 500);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickUsuarioInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 500);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickUsuarioDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 500);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickUsuarioAtualizar);

            this.loadList();

            this.Controls.Add(listView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);
            this.ClientSize = new System.Drawing.Size(500, 600);
        }

        public void loadList() {
            this.listView.Items.Clear();
            IEnumerable<Usuario> usuarios = UsuarioController.VisualizarUsuario();
            foreach (Usuario item in usuarios)
            {    
                ListViewItem lvItem = new ListViewItem(item.Id.ToString());
                lvItem.SubItems.Add(item.Nome);
                lvItem.SubItems.Add(item.Email);
                lvItem.SubItems.Add(item.Senha);
                this.listView.Items.Add(lvItem);
            }
        }

        private void handleConfirmClickUsuarioAtualizar(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0) {
                AtualizarUsuario menu = new AtualizarUsuario(this);
                menu.Size = new Size(325, 300);
                menu.ShowDialog();
            } else {
                MessageBox.Show("Não há itens selecionados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void handleConfirmClickUsuarioDeletar(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0) {
                ListViewItem item = this.listView.SelectedItems[0];
                int id = Convert.ToInt32(item.Text);
                DialogResult result = MessageBox.Show($"Deseja excluir o usuário {id}?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    UsuarioController.RemoverUsuario(id);
                    this.loadList();
                }
            } else {
                MessageBox.Show("Não há itens selecionados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void handleConfirmClickUsuarioInserir(object sender, EventArgs e)
        {
            InserirUsuario menu = new InserirUsuario(this);
            menu.Size = new Size(325, 300);
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}