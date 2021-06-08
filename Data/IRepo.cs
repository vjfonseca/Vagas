using System.Collections.Generic;
using Vagas.Models;

namespace Vagas.Data
{
    public interface IRepo
    {
        public IEnumerable<Vaga> GetAll();
    }
}