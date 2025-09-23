using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar se apessoa digitou o email e a senha:
            if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("Digite um Email Válido!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 4)
            {
                MessageBox.Show("Digite uma Senha Válida!",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir...
                Model.Usuario usuario = new Model.Usuario();

                // Colocar os valores dos campos nos atributos do usuário:
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;

                // Tabela que vai receber o resultado do SELECT (Logar)
                DataTable resultado = usuario.Logar();

                // Verificar se acertou o e-mail e senha:
                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("E-mail e/ou senha inválidos!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Armazenar as infos vindas do bd no objeto "usuario"
                    usuario.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();

                    // Mudar para o MenuPrincipal:
                    MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                    Hide(); // Esconder a janela atual:
                    menuPrincipal.ShowDialog(); // Mostrar o menu principal:

                    Show(); // Mostrar a tela de login ao sair do menu principal:
                }
            }
        }
    }   
}
