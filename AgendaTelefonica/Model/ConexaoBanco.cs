using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica.Model
{
    internal class ConexaoBanco
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lucas.bflor1\source\repos\AgendaTelefonica\AgendaTelefonica\BancoDeDados\AgendaTelefonica.mdf;Integrated Security=True";
        }
    }
}
