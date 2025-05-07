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
           if(nome == "admin" && senha == "123")
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
            if (textLogin.Text == "USUARIO"){ 
            textLogin.Text = string.Empty;}
        }
    }
}
