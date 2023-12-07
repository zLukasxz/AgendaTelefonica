using AgendaTelefonica.Controller;
using AgendaTelefonica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica.View
{
    public partial class ProcurarContatoNome : Form
    {
        public ProcurarContatoNome()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Pessoas.Nome1 = txb_Nome.Text;

            ManipulaPessoas.ProcurarPessoaNome();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.DataSource = ManipulaPessoas.ProcurarPessoaNome();
            dataGridView1.Columns[5].HeaderCell.Value = "Codigo";
            dataGridView1.Columns[6].HeaderCell.Value = "Nome";
            dataGridView1.Columns[7].HeaderCell.Value = "Telefone";
            dataGridView1.Columns[8].HeaderCell.Value = "Email";
            dataGridView1.Columns[9].HeaderCell.Value = "Endereco";
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
