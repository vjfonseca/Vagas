using System;

namespace Vagas.Models
{
    public class Vaga
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Localizacao { get; set; }
        public float Salario { get; set; }
    }
}
