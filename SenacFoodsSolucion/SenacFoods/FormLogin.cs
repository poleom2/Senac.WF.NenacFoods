namespace SenacFoods
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool loginValido = validarLogin(textLogin.Text, textSenha.Text);

            if (loginValido)
            {

                this.Hide();
                var formPrincipal = new FormPrincipal(textLogin.Text, textSenha.Text);
                formPrincipal.Show();
            }
        }

        private bool validarLogin(string nome, string senha)
        {
            bool usuarioValido = false;
            //CONECTA NO BANCO
            using (var banco = new ComandaDBContest())
            {
                var usuario = banco
                    .Usuarios
                    .FirstOrDefault(u => u.Email.ToLower() == nome.ToLower() && u.Senha == senha);
                if (usuario is not null)

                    usuarioValido = true;
            }
            if (usuarioValido)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Login ou Senha Invalidos");
            }
            return false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {
            if (textLogin.Text == "USUARIO")
            {
                textLogin.Text = string.Empty;
            }
        }

        private void textLogin_Leave(object sender, EventArgs e)
        {
            if (textLogin.Text == string.Empty)
            {
                textLogin.Text = "Usuario";
            }
        }
    }
}
