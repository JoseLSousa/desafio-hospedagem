using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_hospedagem.Models
{
    public class Hospede
    {
        public Hospede(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}