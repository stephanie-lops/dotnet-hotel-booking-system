namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verifica se a capacidade da suíte é suficiente para os hóspedes
            if (Suite != null && hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes cadastrados
            return Hospedes != null ? Hospedes.Count : 0;
        }
        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
                throw new InvalidOperationException("Nenhuma suíte cadastrada para calcular a diária.");

            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Aplica desconto de 10% se os dias reservados forem >= 10
            if (DiasReservados >= 10)
            {
                valor *= 0.9m; // desconto de 10%
            }

            return valor;
        }
    }
}