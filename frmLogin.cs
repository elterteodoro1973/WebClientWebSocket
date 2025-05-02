using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebClientWebSocket
{
    public partial class frmLogin : Form
    {
        bool logado = false;
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Text = "user";
            txtSenha.Text = string.Empty;
            //txtSenha.Text = "pass123";
        }

        public static void GetHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        private bool Validacao(string usuario, string senha)
        {
            if (string.IsNullOrEmpty(usuario) || senha.Length < 5)
            {
                MessageBox.Show("Usuário não pode ser vazio ou com menos de 4 caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(senha) || senha.Length < 5)
            {
                MessageBox.Show("Senha não pode ser vazio ou com menos de 5 caracteres ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!logado)
                {
                    if (MessageBox.Show("Você não está logado. Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Termina a aplicação
                        Application.Exit();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            logado = false;

            if (!Validacao(txtUsuario.Text, txtSenha.Text))
            {
                txtUsuario.Focus();
                return;
            }

            string url = "https://beta.axiafutures.com/api/mock-login";
            // Corrected JSON string to use double quotes instead of single quotes
            string json = $@"{{""username"": ""{txtUsuario.Text}"", ""password"": ""{txtSenha.Text}""}}";

            using (HttpClient client = new HttpClient())
            {
                GetHeaders(client);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync(url, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    logado = true;                    
                    Close();
                }
                else
                {
                    txtSenha.Text = string.Empty;
                    txtSenha.Focus();
                    MessageBox.Show("Falha no login. Verifique suas credenciais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
