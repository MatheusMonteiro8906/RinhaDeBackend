using System.ComponentModel.DataAnnotations;

namespace RinhaDeBackend.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Todo cliente deve ter um limite.")]
        [Range(0, int.MaxValue, ErrorMessage = "O limite não pode ser negativo.")]
        public int Limite { get; set; }

        public double SaldoInicial { get; set; } = 0;
    }
}