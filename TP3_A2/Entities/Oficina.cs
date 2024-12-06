using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP3_A2.Entities
{
    public class Oficina
    {
        public Oficina()
        {
            Servicos = new List<Servico>();
            IsDeleted = false;
        }
        public Guid OficinaId { get; set; }
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }

        // Relacionamento com Serviço
        public List<Servico> Servicos { get; set; }
        public bool IsDeleted { get; set; }
        public void Update(string nome, string responsavel, string telefone)
        {
            Nome = nome;
            Responsavel = responsavel;  
            Telefone = telefone;    
        }
        public void Delete()
        {
            IsDeleted = true;
        }
    }
}