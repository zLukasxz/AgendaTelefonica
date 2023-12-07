using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica.Model
{
    internal class Pessoas
    {
        private static int Id;
        private static string Nome;
        private static string Fone;
        private static string Email;
        private static string Endereco;

        public static int Id1 { get => Id; set => Id = value; }
        public static string Nome1 { get => Nome; set => Nome = value; }
        public static string Fone1 { get => Fone; set => Fone = value; }
        public static string Email1 { get => Email; set => Email = value; }
        public static string Endereco1 { get => Endereco; set => Endereco = value; }
    }
}
