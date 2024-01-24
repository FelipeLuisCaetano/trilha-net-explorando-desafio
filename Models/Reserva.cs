namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        private List<Pessoa> Hospedes { get; set; }
        private Suite Suite { get; set; }
        private int DiasReservados { get; set; }
        private decimal ValorDesconto { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                
                
                throw new Exception("Quantidade de hospedes maior que a capacidade da suite.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            
            return Hospedes.Count;
        }

        public decimal ObterValorDesconto() 
        { 
            return ValorDesconto; 
        }

        public decimal CalcularValorDiaria()
        {
            
           
            
            decimal valor = DiasReservados * Suite.ValorDiaria;

            
            
            if (DiasReservados >= 10 )
            {
                decimal desconto = CalcularDesconto(valor, 10);
                valor = valor - desconto;
            }

            return valor;
        }

        private decimal CalcularDesconto(decimal valor, decimal percentualDesconto)
        {
            ValorDesconto = valor * percentualDesconto / 100;
            return ValorDesconto;
        }
    }
}