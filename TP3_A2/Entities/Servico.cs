using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TP3_A2.Entities
{
    public class Servico
    {

        public Servico()
        {
            ServicoCategorias = new List<ServicoCategoria>();
            IsDeleted = false;
        }
        public Guid ServicoId { get; set; }
        public DateTime Data { get; set; }
        public StatusServico Status { get; set; }
        public string Observacoes { get; set; }
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
        public int OficinaId { get; set; }
        public Oficina Oficina { get; set; }
        public List<ServicoCategoria> ServicoCategorias { get; set; }
        public bool IsDeleted { get; set; }
        public void Update(DateTime data, StatusServico status, string observacoes)
        {
            Data = data;
            Status = status;
            Observacoes = observacoes;
        }
        public void Delete()
        {
            IsDeleted = true;
        }

    }
}