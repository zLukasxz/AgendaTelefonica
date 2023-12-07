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
    public partial class AdicionarContato : Form
    {
        public AdicionarContato()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
           Pessoas.Nome1 = txb_Nome.Text;
            Pessoas.Fone1 = txb_Fone.Text;
            Pessoas.Email1 = txb_Email.Text;
            Pessoas.Endereco1 = txb_Endereco.Text;
            ManipulaPessoas manipulaPessoas = new ManipulaPessoas();
            manipulaPessoas.AdicionaPessoas();
        }
    }
}
