using EventManager.Repositories;
using EventManager.Services;
using EventManager.Views.Home;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EventManager.Views.Login
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioService _usuarioService;

        public FrmLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService(new UsuarioRepository());
            btnEntrar.Enabled = false; 
            txtEmail.TextChanged += OnFieldsChanged;
            txtSenha.TextChanged += OnFieldsChanged;
        }

        private void OnFieldsChanged(object sender, EventArgs e)
        {
            btnEntrar.Enabled = !string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtSenha.Text);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                labelErro.Text = "Formato de email inválido";
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor; // Cursor de espera
                var usuario = _usuarioService.Autenticar(txtEmail.Text, txtSenha.Text);

                if (usuario != null)
                {
                    labelErro.Text = "";
                    MessageBox.Show("Logado com sucesso!");
                    Hide();
                    using (var frm = new FrmHome(usuario))
                    {
                        frm.ShowDialog();
                    }
                    Close();
                }
                else
                {
                    labelErro.Text = "Credenciais inválidas";
                    txtSenha.Clear();
                }
            }
            catch (Exception ex)
            {
                labelErro.Text = $"Erro ao tentar logar: {ex.Message}";
            }
            finally
            {
                Cursor = Cursors.Default; // Restaurar cursor padrão
            }
        }

        private bool IsValidEmail(string email)
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return emailRegex.IsMatch(email);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
