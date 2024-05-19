using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_hospedagem.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, int valorDiariaCentavos)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiariaCentavos = valorDiariaCentavos;
        }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public int ValorDiariaCentavos { get; set; }
    }
}