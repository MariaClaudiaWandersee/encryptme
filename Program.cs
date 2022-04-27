using System;
using System.Windows.Forms;
using System.Drawing;

namespace ExemploTela
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new FormLogin());
        }
    }

    public class FormLogin : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Label lblPass;

        TextBox txtUser;
        TextBox txtPass;

        Button btnConfirm;
        Button btnCancel;

        public FormLogin()
        {
            this.lblUser = new Label();
            this.lblUser.Text = "Nome";
            this.lblUser.Location = new Point(120, 20);

            this.lblPass = new Label();
            this.lblPass.Text = "Senha";
            this.lblPass.Location = new Point(120, 80);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(10, 50);
            this.txtUser.Size = new Size(280, 30);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(10, 110);
            this.txtPass.Size = new Size(280, 30);
            this.txtPass.PasswordChar = '*';

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 180);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);

            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void handleConfirmClick(object sender, EventArgs e)
        {

            if (this.txtUser.Text == "Maria" && this.txtPass.Text == "123")
            {
                FormInicial form = new FormInicial();
                form.Size = new Size(320, 300);
                form.Show();
            }
            else
            {
                FormPaciente form = new FormPaciente();
                form.Show();
            }
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormInicial : Form //Usuário e Dentista
    {
        private System.ComponentModel.IContainer components = null;

        Label lblLogin;
        Button btnDentista;
        Button btnPaciente;
        Button btnProcedi;
        Button btnEspeciali;
        Button btnSala;
        Button btnAgendamento;
        Button btnCancel;

        public FormInicial()
        {
            this.lblLogin = new Label();
            this.lblLogin.Text = "Olá Maria";
            this.lblLogin.Location = new Point(117, 20);

            this.btnDentista = new Button();
            this.btnDentista.Text = "Categorias";
            this.btnDentista.Location = new Point(40, 60);
            this.btnDentista.Size = new Size(100, 30);
            this.btnDentista.Click += new EventHandler(this.handleDentistaClick);

            this.btnPaciente = new Button();
            this.btnPaciente.Text = "Tags";
            this.btnPaciente.Location = new Point(160, 60);
            this.btnPaciente.Size = new Size(100, 30);
            this.btnPaciente.Click += new EventHandler(this.handlePacienteClick);

            this.btnProcedi = new Button();
            this.btnProcedi.Text = "Senhas";
            this.btnProcedi.Location = new Point(40, 100);
            this.btnProcedi.Size = new Size(100, 30);
            this.btnProcedi.Click += new EventHandler(this.handleProcedimentoClick);

            this.btnEspeciali = new Button();
            this.btnEspeciali.Text = "Usuário";
            this.btnEspeciali.Location = new Point(160, 100);
            this.btnEspeciali.Size = new Size(100, 30);
            this.btnEspeciali.Click += new EventHandler(this.handleEspecialidadeClick);

            this.btnSala = new Button();
            this.btnSala.Text = "Sala";
            this.btnSala.Location = new Point(40, 140);
            this.btnSala.Size = new Size(100, 30);
            this.btnSala.Click += new EventHandler(this.handleSalaClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Sair";
            this.btnCancel.Location = new Point(110, 200);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblLogin);

            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnProcedi);
            this.Controls.Add(this.btnEspeciali);
            this.Controls.Add(this.btnSala);
            this.Controls.Add(this.btnAgendamento);
            this.Controls.Add(this.btnCancel);

        }
        private void handlePacienteClick(object sender, EventArgs e)
        {
            FormPaciente menu = new FormPaciente();
            menu.ShowDialog();
        }
        private void handleDentistaClick(object sender, EventArgs e)
        {
            FormDentista menu = new FormDentista();
            menu.ShowDialog();
        }
        private void handleProcedimentoClick(object sender, EventArgs e)
        {
            FormProcedimento menu = new FormProcedimento();
            menu.ShowDialog();
        }
        private void handleEspecialidadeClick(object sender, EventArgs e)
        {
            FormEspecialidade menu = new FormEspecialidade();
            menu.ShowDialog();
        }
        private void handleSalaClick(object sender, EventArgs e)
        {
            FormSala menu = new FormSala();
            menu.ShowDialog();
        }
         private void handleAgendamentoClick(object sender, EventArgs e)
        {
            FormAgendamento menu = new FormAgendamento();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormPaciente : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblPaciente;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public FormPaciente()
        {
            this.lblPaciente = new Label();
            this.lblPaciente.Text = "Paciente";
            this.lblPaciente.Location = new Point(220, 10);

            this.Controls.Add(this.lblPaciente);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;

            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmPacienteInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmPacienteDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmPacienteAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmPacienteAtualizar(object sender, EventArgs e)
        {
            FormUpdatePaciente menu = new FormUpdatePaciente();
            menu.Size = new Size(325, 550);
            menu.ShowDialog();
        }
        private void handleConfirmPacienteDeletar(object sender, EventArgs e)
        {
            FormDeletarPaciente menu = new FormDeletarPaciente();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmPacienteInserir(object sender, EventArgs e)
        {
            FormInserirPaciente menu = new FormInserirPaciente();
            menu.Size = new Size(325, 510);
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormDentista : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDentista;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public FormDentista()
        {
            this.lblDentista = new Label();
            this.lblDentista.Text = "Dentista";
            this.lblDentista.Location = new Point(220, 10);

            this.Controls.Add(this.lblDentista);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("0");
            lista1.SubItems.Add("Maria");
            lista1.SubItems.Add("000.000.000-00");
            lista1.SubItems.Add("4002-8922");
            lista1.SubItems.Add("maria@gmail.com");
            lista1.SubItems.Add("MAR-01");
            lista1.SubItems.Add("R$1100,00");
            lista1.SubItems.Add("1");
            lista1.SubItems.Add("Endodontia");
            lista1.SubItems.Add("Estrutura dos dentes");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Registro", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Salário", -2, HorizontalAlignment.Left);
            listView.Columns.Add("ID da Especialidade", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Tarefas", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickDentistaInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickDentistaDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickDentistaAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickDentistaAtualizar(object sender, EventArgs e)
        {
            FormAtualizarDentista menu = new FormAtualizarDentista();
            menu.Size = new Size(325, 595);
            menu.ShowDialog();
        }
        private void handleConfirmClickDentistaDeletar(object sender, EventArgs e)
        {
            FormDeletarDentista menu = new FormDeletarDentista();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickDentistaInserir(object sender, EventArgs e)
        {
            FormInserirDentista menu = new FormInserirDentista();
            menu.Size = new Size(325, 595);
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormInserirPaciente : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblCpf;
        Label lblNascimento;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;

        TextBox txtNome;
        TextBox txtCpf;
        DateTimePicker dtpNascimento;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;

        Button btnConfirm;
        Button btnCancel;

        public FormInserirPaciente()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(132, 20);

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(135, 80);
            this.lblCpf.Size = new Size(300, 30);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(132, 140);
            this.lblTelefone.Size = new Size(300, 30);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(130, 200);
            this.lblEmail.Size = new Size(300, 30);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 260);
            this.lblSenha.Size = new Size(300, 30);

            this.lblNascimento = new Label();
            this.lblNascimento.Text = "Data de Nascimento";
            this.lblNascimento.Location = new Point(95, 320);
            this.lblNascimento.Size = new Size(300, 30);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(10, 110);
            this.txtCpf.Size = new Size(280, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(10, 170);
            this.txtTelefone.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 230);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 290);
            this.txtSenha.Size = new Size(280, 30);

            this.dtpNascimento = new DateTimePicker();
            this.dtpNascimento.Location = new Point(10, 350);
            this.dtpNascimento.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(70, 430);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 430);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class FormDeletarPaciente : Form
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public FormDeletarPaciente()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(55, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(145, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormUpdatePaciente : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblCpf;
        Label lblNascimento;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;
        Label lblId;

        TextBox txtNome;
        TextBox txtCpf;
        DateTimePicker dtpNascimento;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtId;

        Button btnConfirm;
        Button btnCancel;

        public FormUpdatePaciente()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(132, 20);

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(135, 80);
            this.lblCpf.Size = new Size(300, 30);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(132, 140);
            this.lblTelefone.Size = new Size(300, 30);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(130, 200);
            this.lblEmail.Size = new Size(300, 30);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 260);
            this.lblSenha.Size = new Size(300, 30);

            this.lblNascimento = new Label();
            this.lblNascimento.Text = "Data de Nascimento";
            this.lblNascimento.Location = new Point(95, 320);
            this.lblNascimento.Size = new Size(300, 30);

            this.lblId = new Label();
            this.lblId.Text = "ID de Alteração";
            this.lblId.Location = new Point(110, 380);
            this.lblId.Size = new Size(300, 30);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(10, 110);
            this.txtCpf.Size = new Size(280, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(10, 170);
            this.txtTelefone.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 230);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 290);
            this.txtSenha.Size = new Size(280, 30);

            this.dtpNascimento = new DateTimePicker();
            this.dtpNascimento.Location = new Point(10, 350);
            this.dtpNascimento.Size = new Size(280, 30);

            this.txtId = new TextBox();
            this.txtId.Location = new Point(10, 410);
            this.txtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(70, 460);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 460);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblId);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtId);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class FormInserirDentista : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblCpf;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;
        Label lblRegistro;
        Label lblSalario;
        Label lblEspecialidade;

        TextBox txtNome;
        TextBox txtCpf;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtRegistro;
        TextBox txtSalario;
        TextBox txtEspecialidade;

        Button btnConfirm;
        Button btnCancel;

        public FormInserirDentista()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(132, 20);

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(135, 80);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(132, 140);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(130, 200);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 260);

            this.lblRegistro = new Label();
            this.lblRegistro.Text = "Registro";
            this.lblRegistro.Location = new Point(128, 320);

            this.lblSalario = new Label();
            this.lblSalario.Text = "Salario";
            this.lblSalario.Location = new Point(128, 380);

            this.lblEspecialidade = new Label();
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.Location = new Point(120, 440);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(10, 110);
            this.txtCpf.Size = new Size(280, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(10, 170);
            this.txtTelefone.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 230);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 290);
            this.txtSenha.Size = new Size(280, 30);

            this.txtRegistro = new TextBox();
            this.txtRegistro.Location = new Point(10, 350);
            this.txtRegistro.Size = new Size(280, 30);

            this.txtSalario = new TextBox();
            this.txtSalario.Location = new Point(10, 410);
            this.txtSalario.Size = new Size(280, 30);

            this.txtEspecialidade = new TextBox();
            this.txtEspecialidade.Location = new Point(10, 470);
            this.txtEspecialidade.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(70, 520);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 520);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblEspecialidade);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEspecialidade);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Dentista ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormDeletarDentista : Form
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public FormDeletarDentista()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Dentista ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormAtualizarDentista : Form
    {
        Label lblNome;
        Label lblCpf;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;
        Label lblRegistro;
        Label lblSalario;
        Label lblEspecialidade;

        TextBox txtNome;
        TextBox txtCpf;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtRegistro;
        TextBox txtSalario;
        TextBox txtEspecialidade;

        Button btnConfirm;
        Button btnCancel;

        public FormAtualizarDentista()
        {

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(132, 20);

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(135, 80);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(132, 140);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(130, 200);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 260);

            this.lblRegistro = new Label();
            this.lblRegistro.Text = "Registro";
            this.lblRegistro.Location = new Point(128, 320);

            this.lblSalario = new Label();
            this.lblSalario.Text = "Salario";
            this.lblSalario.Location = new Point(128, 380);

            this.lblEspecialidade = new Label();
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.Location = new Point(120, 440);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(10, 110);
            this.txtCpf.Size = new Size(280, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(10, 170);
            this.txtTelefone.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 230);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 290);
            this.txtSenha.Size = new Size(280, 30);

            this.txtRegistro = new TextBox();
            this.txtRegistro.Location = new Point(10, 350);
            this.txtRegistro.Size = new Size(280, 30);

            this.txtSalario = new TextBox();
            this.txtSalario.Location = new Point(10, 410);
            this.txtSalario.Size = new Size(280, 30);

            this.txtEspecialidade = new TextBox();
            this.txtEspecialidade.Location = new Point(10, 470);
            this.txtEspecialidade.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(70, 520);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 520);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblEspecialidade);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEspecialidade);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Dentista ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormProcedimento : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblProcedimento;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public FormProcedimento()
        {
            this.lblProcedimento = new Label();
            this.lblProcedimento.Text = "Procedimento";
            this.lblProcedimento.Location = new Point(220, 10);

            this.Controls.Add(this.lblProcedimento);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("0");
            lista1.SubItems.Add("Extrair dente");
            lista1.SubItems.Add("R$ 330,00");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Preço", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickProcedimentoInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickProcedimentoDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickProcedimentoAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickProcedimentoAtualizar(object sender, EventArgs e)
        {
            FormAtualizarProcedimento menu = new FormAtualizarProcedimento();
            menu.ShowDialog();
        }
        private void handleConfirmClickProcedimentoDeletar(object sender, EventArgs e)
        {
            FormDeletarProcedimento menu = new FormDeletarProcedimento();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickProcedimentoInserir(object sender, EventArgs e)
        {
            FormInserirProcedimento menu = new FormInserirProcedimento();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {

            this.Close();
        }
    }

    public class FormInserirProcedimento : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblPreco;

        TextBox txtDescricao;
        TextBox txtPreco;

        Button btnConfirm;
        Button btnCancel;

        public FormInserirProcedimento()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblPreco = new Label();
            this.lblPreco.Text = "Preço";
            this.lblPreco.Location = new Point(130, 80);
            this.lblPreco.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtPreco = new TextBox();
            this.txtPreco.Location = new Point(10, 110);
            this.txtPreco.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 220);
            this.btnConfirm.Size = new Size(90, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 260);
            this.btnCancel.Size = new Size(90, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblPreco);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPreco);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Procedimento ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormDeletarProcedimento : Form
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public FormDeletarProcedimento()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Procedimento";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormAtualizarProcedimento : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblPreco;

        TextBox txtDescricao;
        TextBox txtPreco;

        Button btnConfirm;
        Button btnCancel;

        public FormAtualizarProcedimento()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblPreco = new Label();
            this.lblPreco.Text = "Preço";
            this.lblPreco.Location = new Point(130, 80);
            this.lblPreco.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtPreco = new TextBox();
            this.txtPreco.Location = new Point(10, 110);
            this.txtPreco.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 220);
            this.btnConfirm.Size = new Size(90, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 260);
            this.btnCancel.Size = new Size(90, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblPreco);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPreco);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Procedimento ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormEspecialidade : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblEspecialidade;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public FormEspecialidade()
        {
            this.lblEspecialidade = new Label();
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.Location = new Point(220, 10);

            this.Controls.Add(this.lblEspecialidade);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;

            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Tarefas", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickEspecialidadeInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickEspecialidadeDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickEspecialidadeAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickEspecialidadeAtualizar(object sender, EventArgs e)
        {
            FormAtualizarEspecilidade menu = new FormAtualizarEspecilidade();
            menu.ShowDialog();
        }
        private void handleConfirmClickEspecialidadeDeletar(object sender, EventArgs e)
        {
            FormDeletarEspecialidade menu = new FormDeletarEspecialidade();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickEspecialidadeInserir(object sender, EventArgs e)
        {
            FormInserirEspecialidade menu = new FormInserirEspecialidade();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormInserirEspecialidade : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblTarefas;

        TextBox txtDescricao;
        TextBox txtTarefas;

        Button btnConfirm;
        Button btnCancel;

        public FormInserirEspecialidade()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblTarefas = new Label();
            this.lblTarefas.Text = "Tarefas";
            this.lblTarefas.Location = new Point(125, 80);
            this.lblTarefas.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtTarefas = new TextBox();
            this.txtTarefas.Location = new Point(10, 110);
            this.txtTarefas.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTarefas);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTarefas);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Especialidade ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class FormDeletarEspecialidade : Form
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public FormDeletarEspecialidade()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Especialidade";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormAtualizarEspecilidade : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblTarefas;

        TextBox txtDescricao;
        TextBox txtTarefas;

        Button btnConfirm;
        Button btnCancel;

        public FormAtualizarEspecilidade()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblTarefas = new Label();
            this.lblTarefas.Text = "Tarefas";
            this.lblTarefas.Location = new Point(125, 80);
            this.lblTarefas.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtTarefas = new TextBox();
            this.txtTarefas.Location = new Point(10, 110);
            this.txtTarefas.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTarefas);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTarefas);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Especialidade ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormSala : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblSala;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public FormSala()
        {
            this.lblSala = new Label();
            this.lblSala.Text = "Sala";
            this.lblSala.Location = new Point(220, 10);

            this.Controls.Add(this.lblSala);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("1");
            lista1.SubItems.Add("01");
            lista1.SubItems.Add("Raio-X");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Número", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Equipamentos", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickSalaInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickSalaDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickSalaAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickSalaAtualizar(object sender, EventArgs e)
        {
            FormAtualizarSala menu = new FormAtualizarSala();
            menu.ShowDialog();
        }
        private void handleConfirmClickSalaDeletar(object sender, EventArgs e)
        {
            FormDeletarSala menu = new FormDeletarSala();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickSalaInserir(object sender, EventArgs e)
        {
            FormInserirSala menu = new FormInserirSala();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormInserirSala : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNumero;
        Label lblEquipamentos;

        TextBox txtNumero;
        TextBox txtEquipamentos;

        Button btnConfirm;
        Button btnCancel;

        public FormInserirSala()
        {
            this.lblNumero = new Label();
            this.lblNumero.Text = "Número";
            this.lblNumero.Location = new Point(120, 20);

            this.lblEquipamentos = new Label();
            this.lblEquipamentos.Text = "Equipamentos";
            this.lblEquipamentos.Location = new Point(110, 80);
            this.lblEquipamentos.Size = new Size(300, 30);

            this.txtNumero = new TextBox();
            this.txtNumero.Location = new Point(10, 50);
            this.txtNumero.Size = new Size(280, 30);

            this.txtEquipamentos = new TextBox();
            this.txtEquipamentos.Location = new Point(10, 110);
            this.txtEquipamentos.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEquipamentos);

            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEquipamentos);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Sala ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormDeletarSala : Form
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public FormDeletarSala()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Sala";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormAtualizarSala : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNumero;
        Label lblEquipamentos;

        TextBox txtNumero;
        TextBox txtEquipamentos;

        Button btnConfirm;
        Button btnCancel;

        public FormAtualizarSala()
        {
            this.lblNumero = new Label();
            this.lblNumero.Text = "Número";
            this.lblNumero.Location = new Point(120, 20);

            this.lblEquipamentos = new Label();
            this.lblEquipamentos.Text = "Equipamentos";
            this.lblEquipamentos.Location = new Point(110, 80);
            this.lblEquipamentos.Size = new Size(300, 30);

            this.txtNumero = new TextBox();
            this.txtNumero.Location = new Point(10, 50);
            this.txtNumero.Size = new Size(280, 30);

            this.txtEquipamentos = new TextBox();
            this.txtEquipamentos.Location = new Point(10, 110);
            this.txtEquipamentos.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEquipamentos);

            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEquipamentos);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Sala ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

        public class FormAgendamento : Form
        {
        private System.ComponentModel.IContainer components = null;

        
        Label lblAgendamento;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public FormAgendamento()
        {
            this.lblAgendamento = new Label();
            this.lblAgendamento.Text = "Agendamento";
            this.lblAgendamento.Location = new Point(200, 10);

            this.Controls.Add(this.lblAgendamento);

            listView = new ListView();
            listView.Location = new Point(100, 70);
            listView.Size = new Size(280, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("1");
            lista1.SubItems.Add("00");
            lista1.SubItems.Add("00");
            lista1.SubItems.Add("00");
            lista1.SubItems.Add("2022/03/21");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("PacienteId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("DentistaId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("SalaId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            
            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmAgendamentoInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmAgendamentoDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmAgendamentoAtualizar);

            this.Controls.Add(listView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(480, 300);   
        }

        private void handleConfirmAgendamentoAtualizar(object sender, EventArgs e)
        {
            FormAtualizarAgendamento menu = new FormAtualizarAgendamento();
            menu.Size = new Size(325, 510);
            menu.ShowDialog();
        }
        private void handleConfirmAgendamentoDeletar(object sender, EventArgs e)
        {
            FormAtualizarDeletar menu = new FormAtualizarDeletar();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmAgendamentoInserir(object sender, EventArgs e)
        {
            FormAtualizarInserir menu = new FormAtualizarInserir();
            menu.Size = new Size(325, 510);
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }

        public class FormAtualizarAgendamento : Form
        {
        private System.ComponentModel.IContainer components = null;

        Label lblPacienteId;
        Label lblDentistaId;
        Label lblSalaId;
        Label lblData;

        TextBox txtPacienteId;
        TextBox txtDentistaId;
        TextBox txtSalaId;
        TextBox txtData;

        Button btnConfirm;
        Button btnCancel;

        public FormAtualizarAgendamento()
        {
            this.lblPacienteId = new Label();
            this.lblPacienteId.Text = "PacienteId";
            this.lblPacienteId.Location = new Point(120, 20);

            this.lblDentistaId = new Label();
            this.lblDentistaId.Text = "DentistaId";
            this.lblDentistaId.Location = new Point(120, 80);
            this.lblDentistaId.Size = new Size(300, 30);

            this.lblSalaId = new Label();
            this.lblSalaId.Text = "SalaId";
            this.lblSalaId.Location = new Point(125, 140);
            this.lblSalaId.Size = new Size(300, 30);

            this.lblData = new Label();
            this.lblData.Text = "Data";
            this.lblData.Location = new Point(130, 200);
            this.lblData.Size = new Size(300, 30);

            this.txtPacienteId = new TextBox();
            this.txtPacienteId.Location = new Point(10, 50);
            this.txtPacienteId.Size = new Size(280, 30);

            this.txtDentistaId = new TextBox();
            this.txtDentistaId.Location = new Point(10, 110);
            this.txtDentistaId.Size = new Size(280, 30);

            this.txtSalaId = new TextBox();
            this.txtSalaId.Location = new Point(10, 170);
            this.txtSalaId.Size = new Size(280, 30);

            this.txtData = new TextBox();
            this.txtData.Location = new Point(10, 230);
            this.txtData.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(65, 280);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(155, 280);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblPacienteId);
            this.Controls.Add(this.lblDentistaId);
            this.Controls.Add(this.lblSalaId);
            this.Controls.Add(this.lblData);

            this.Controls.Add(this.txtPacienteId);
            this.Controls.Add(this.txtDentistaId);
            this.Controls.Add(this.txtSalaId);
            this.Controls.Add(this.txtData);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.ClientSize = new System.Drawing.Size(300, 400);

        }
         private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        public class FormAtualizarDeletar : Form
        {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public FormAtualizarDeletar()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(55, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(145, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void handleConfirmClick(object sender, EventArgs e)
        {

        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        public class FormAtualizarInserir : Form
        {
        private System.ComponentModel.IContainer components = null;

        Label lblPacienteId;
        Label lblDentistaId;
        Label lblSalaId;
        Label lblData;

        TextBox txtPacienteId;
        TextBox txtDentistaId;
        TextBox txtSalaId;
        TextBox txtData;

        Button btnConfirm;
        Button btnCancel;

        public FormAtualizarInserir()
        {
            this.lblPacienteId = new Label();
            this.lblPacienteId.Text = "PacienteId";
            this.lblPacienteId.Location = new Point(120, 20);

            this.lblDentistaId = new Label();
            this.lblDentistaId.Text = "DentistaId";
            this.lblDentistaId.Location = new Point(120, 80);
            this.lblDentistaId.Size = new Size(300, 30);

            this.lblSalaId = new Label();
            this.lblSalaId.Text = "SalaId";
            this.lblSalaId.Location = new Point(125, 140);
            this.lblSalaId.Size = new Size(300, 30);

            this.lblData = new Label();
            this.lblData.Text = "Data";
            this.lblData.Location = new Point(130, 200);
            this.lblData.Size = new Size(300, 30);

            this.txtPacienteId = new TextBox();
            this.txtPacienteId.Location = new Point(10, 50);
            this.txtPacienteId.Size = new Size(280, 30);

            this.txtDentistaId = new TextBox();
            this.txtDentistaId.Location = new Point(10, 110);
            this.txtDentistaId.Size = new Size(280, 30);

            this.txtSalaId = new TextBox();
            this.txtSalaId.Location = new Point(10, 170);
            this.txtSalaId.Size = new Size(280, 30);

            this.txtData = new TextBox();
            this.txtData.Location = new Point(10, 230);
            this.txtData.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(65, 280);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(155, 280);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblPacienteId);
            this.Controls.Add(this.lblDentistaId);
            this.Controls.Add(this.lblSalaId);
            this.Controls.Add(this.lblData);

            this.Controls.Add(this.txtPacienteId);
            this.Controls.Add(this.txtDentistaId);
            this.Controls.Add(this.txtSalaId);
            this.Controls.Add(this.txtData);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.ClientSize = new System.Drawing.Size(300, 400);
        }
         private void handleConfirmClick(object sender, EventArgs e)
        {

        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}