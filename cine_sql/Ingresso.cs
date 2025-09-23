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
        int idSelecionado = 0;

        public Ingresso(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            Model.Ingresso ingresso = new Model.Ingresso();
            // Mostrar as informações do bd no DataGridView
            dgvIngressos.DataSource = ingresso.Listar();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
