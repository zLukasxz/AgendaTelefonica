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
    public partial class ProcurarContatoCod : Form
    {
        public ProcurarContatoCod()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Pessoas.Id1 = Convert.ToInt32(txb_Id.Text);
            ManipulaPessoas manipulaPessoas = new ManipulaPessoas();
            manipulaPessoas.ProcurarPessoaCodigo();

            txb_Nome.Text = Pessoas.Nome1;
            txb_Fone.Text = Pessoas.Fone1;
            txb_Email.Text = Pessoas.Email1;
            txb_Endereco.Text = Pessoas.Endereco1;
        }
    }
}
