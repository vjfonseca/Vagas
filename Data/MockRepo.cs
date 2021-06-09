using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vagas.Models;

namespace Vagas.Data
{
    public class MockRepo : IRepo
    {
        private List<Vaga> _data;
        public MockRepo()
        {
            _data = Seed(new Random().Next(8, 8));
        }
        private List<Vaga> Seed(int n)
        {
            List<Vaga> output = new List<Vaga>();
            string cargo = "Desenvolvedor Arquiteto Programador Assistente Engenheiro";
            string tec = "Asp.net C# Java Backend Frontend Fullstack Angular React";
            string cidades = "Barueri-SP Salvador-BA Brasilia-DF Recife-PE Marilia-SP Betim-MG";
            for (int i = 0; i < n; i++)
            {
                output.Add(new Vaga()
                {
                    Id = i+1,
                    Titulo = GetRandomWords(cargo, 1) + " " + GetRandomWords(tec, 1),
                    Localizacao = GetRandomWords(cidades, 1),
                    Salario = new Random().Next(1000, 20000)
                });
            }
            return output;
        }
        private static string GetRandomWords(string data, int x)
        {
           // Split data into words.
            var words = data.Split(' ');
            // Find a random place to start, at least x words back.
            Random random = new Random();
            var start = random.Next(0, words.Length - x);
            // Select the words.
            var selectedWords = words.Skip(start).Take(x);
            return string.Join(" ", selectedWords);
        }

        public IEnumerable<Vaga> GetAll()
        {
            return _data;
        }
    }
}