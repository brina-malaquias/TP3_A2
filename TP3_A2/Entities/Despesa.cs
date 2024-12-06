using System.ComponentModel.DataAnnotations;

namespace TP3_A2.Entities
{
    public class Despesa
    {
        public Despesa()
        {
            IsDeleted = false;
        }
        public Guid DespesaId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Observacoes { get; set; }

        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

        public int TipoDespesaId { get; set; }
        public TipoDespesa TipoDespesa { get; set; }
        public bool IsDeleted { get; set; }
        public void Update(decimal valor, DateTime data, string observacoes)
        {
            Valor = valor;
            Data = data;
            Observacoes = observacoes;
        }
        public void Delete()
        {
            IsDeleted = true;
        }
    }
}