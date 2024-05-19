using System.Text;
using desafio_hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Hospede> hospedes = new List<Hospede>();

Hospede p1 = new Hospede(nome: "Hóspede", sobrenome: "1");
Hospede p2 = new Hospede(nome: "Hóspede", sobrenome: "2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiariaCentavos: 25000);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
if (reserva.VerificarCapacidade(suite.Capacidade, hospedes.Count))
{
    reserva.CadastrarHospedes(hospedes);
}
else
{
    throw new Exception("A capacidade da suíte é menor que o número de hospedes");
}


// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");