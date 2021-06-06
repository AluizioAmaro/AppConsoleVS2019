using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsoleDemo
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int DataNascto { get; set; }


        public Aluno()
        {

        }

        public Aluno(int id ,string nome ,string sobrenome ,int datanascto)
        {
            this.Id = id;
            this.Nome = nome;
            this.SobreNome = sobrenome;
            this.DataNascto = datanascto;
        }
    }
}
