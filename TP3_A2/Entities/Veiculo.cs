using System.ComponentModel.DataAnnotations;

namespace TP3_A2.Entities
{
    public class Veiculo
    {
        public Veiculo() 
        {
            Servicos = new List<Servico>();
            Despesas = new List<Despesa>();
            IsDeleted = false;
        }
        public int MyProperty { get; set; }

        public Guid VeiculoId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public string Placa { get; set; }
        public string Observacoes { get; set; }
        public List<Servico> Servicos { get; set; }
        public List<Despesa> Despesas { get; set; }
        public bool IsDeleted { get; set; }
        public void Update(string marca, string modelo, int ano, int quilometragem, string placa, string observacoes)
        { 
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Quilometragem = quilometragem;
            Placa = placa;
            Observacoes = observacoes;
        }
        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
