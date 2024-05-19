using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_hospedagem.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        private List<Hospede> Hospedes { get; set; }
        private Suite Suite { get; set; }
        private int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Hospede> hospedes)
        {
           Hospedes = hospedes;
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public bool VerificarCapacidade(int capacidade, int hospedes)
        {
            if (capacidade < hospedes)
                return false;

            return true;
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }
        public int CalcularValorDiaria()
        {
            return (DiasReservados * Suite.ValorDiariaCentavos) / 100;
        }
    }
}