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
    public partial class Ingresso : Form
    {
        Model.Usuario usuario;
        int idUsuario = 0;
        int idIngresso = 0;
        int idSessao = 0;

        public Ingresso(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            Model.Ingresso ingresso = new Model.Ingresso();
            Model.Sessao sessao = new Model.Sessao();
            // Mostrar as informações do bd no DataGridView
            dgvIngressos.DataSource = ingresso.Listar();
            dgvUsuarios.DataSource = usuario.Listar();
            dgvSessoes.DataSource = sessao.Listar();
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que não vai dar erro se clicar no cabeçalho
            if (e.RowIndex >= 0)
            {
                // Seleciona a linha inteira
                dgvUsuarios.Rows[e.RowIndex].Selected = true;
                // Pegar a linha selecionada:
                int ls = dgvUsuarios.SelectedCells[0].RowIndex;

                // Armazenar o ID de quem foi selecionado:
                idUsuario = (int)dgvUsuarios.Rows[ls].Cells[0].Value;
            }
        }

        private void dgvSessoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que não vai dar erro se clicar no cabeçalho
            if (e.RowIndex >= 0)
            {
                // Seleciona a linha inteira
                dgvSessoes.Rows[e.RowIndex].Selected = true;
                // Pegar a linha selecionada:
                int ls = dgvSessoes.SelectedCells[0].RowIndex;

                // Armazenar o ID de quem foi selecionado:
                idSessao = (int)dgvSessoes.Rows[ls].Cells[0].Value;
            }
        }

        private void dgvIngressos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que não vai dar erro se clicar no cabeçalho
            if (e.RowIndex >= 0)
            {
                // Seleciona a linha inteira
                dgvIngressos.Rows[e.RowIndex].Selected = true;
                // Pegar a linha selecionada:
                int ls = dgvIngressos.SelectedCells[0].RowIndex;

                // Armazenar o ID de quem foi selecionado:
                idIngresso = (int)dgvIngressos.Rows[ls].Cells[0].Value;
            }
        }

        private void btnCadastrarIngressos_Click(object sender, EventArgs e)
        {
            
            // Verificar se a quantidade foi preenchida:
            if (txbQtdIngressos.Text.Length == 0)
            {
                MessageBox.Show("Informe a quantidade de Ingressos!", "Erro!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.Ingresso ingresso = new Model.Ingresso();
                ingresso.IdSessao = idSessao;
                ingresso.IdUsuario = idUsuario;
                ingresso.QtdIngresso = int.Parse(txbQtdIngressos.Text);

                if (ingresso.Cadastrar())
                {
                    MessageBox.Show("Ingresso Cadastrado com sucesso!", "Sucesso!",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o Ingresso!", "Erro!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
