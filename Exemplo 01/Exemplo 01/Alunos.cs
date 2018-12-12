using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    class Alunos
    {
        private int idMatricula;
        private string nome;
        private string endereco;
        private string cidade;

        public int IdMatricula { get => idMatricula; set => idMatricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        
    }
}
