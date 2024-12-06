using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP3_A2.Entities;

namespace TP3_A2.Persistence
{
    public class ApplicationDbContext
    {
        public List<Despesa> Despesas { get; set; }

        public ApplicationDbContext() 
        {
            Despesas = new List<Despesa>();

        }
    }
}
