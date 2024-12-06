using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace TP3_A2.Entities
{
    public class CategoriaServico
    {
        public CategoriaServico()
        {
            ServicoCategorias = new List<ServicoCategoria>();
            IsDeleted = false;
        }

        public Guid CategoriaServicoId { get; set; } // Chave primária
        public string Nome { get; set; } // Nome da categoria

        public List<ServicoCategoria> ServicoCategorias { get; set; }
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
