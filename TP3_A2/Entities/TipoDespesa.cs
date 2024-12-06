namespace TP3_A2.Entities
{
    public class TipoDespesa
    {
        public TipoDespesa()
        {
            Despesas = new List<Despesa>();
            IsDeleted = false;
        }

        public Guid TipoDespesaId { get; set; }
        public string Nome { get; set; }

        // Relacionamento com Despesa
        public List<Despesa> Despesas { get; set; }
        public bool IsDeleted { get; set; }
        public void Update(string nome)
        {
            Nome = nome;
        }
        public void Delete()
        {
            IsDeleted = true;
        }
    }
}