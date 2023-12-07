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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            DeletarContato deletarContato = new DeletarContato();
            deletarContato.Show();
        }

        private void btn_Adicionar_Click_1(object sender, EventArgs e)
        {
            AdicionarContato adicionarContato = new AdicionarContato();
            adicionarContato.Show();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            AlterarContato alterarContato = new AlterarContato();
            alterarContato.Show();
        }

        private void btn_BuscarCodigo_Click(object sender, EventArgs e)
        {
            ProcurarContatoCod procurarContatoCod = new ProcurarContatoCod();
            procurarContatoCod.Show();
        }

        private void btn_BuscarNome_Click(object sender, EventArgs e)
        {
            ProcurarContatoNome procurarContatoNome = new ProcurarContatoNome();
            procurarContatoNome.Show();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
