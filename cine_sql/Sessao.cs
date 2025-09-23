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
    public partial class Sessao : Form
    {
        Model.Usuario usuario;
        public Sessao(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            Model.Sessao sessao = new Model.Sessao();
            // Mostrar as informações do bd no DataGridView
            dgvSessoes.DataSource = sessao.Listar();
        }

        private void btnCadastrarSessoes_Click(object sender, EventArgs e)
        {
            // Validar Campos:
            if (txbFilmeSessao.Text.Length < 2)
            {
                MessageBox.Show("O filme deve ter no mínimo 2 caracteres.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoSessao.Text.Length < 1)
            {
                MessageBox.Show("O valor do ingresso não corresponde ao mínimo.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbHorarioSessao.Text.Length != 5)
            {
                MessageBox.Show("Defina o Horário para o filme.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer o cadastro...
                Model.Sessao sessao = new Model.Sessao();

                sessao.Filme = txbFilmeSessao.Text;
                sessao.Preco = double.Parse(txbPrecoSessao.Text);
                sessao.HorarioSessao = txbHorarioSessao.Text;

                // Executar o INSERT:
                if (sessao.Cadastrar())
                {
                    MessageBox.Show("Sessão Cadastrada com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dvg:
                    AtualizarDgv();

                    // Apagar os campos de cadastro:
                    txbFilmeSessao.Clear();
                    txbPrecoSessao.Clear();
                    txbHorarioSessao.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar a sessão!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
