using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Nivel
    {
        public int Id {  get; set; }
        public string? Name { get; set; }    
        public string? Sigla { get; set; } 

        public Nivel() { }// isso é um método construtor quando usamos a expressão new em qualquer lugar estamos chamando o metodo construtor

        public Nivel(string? name, string? sigla)
        {
            Name = name;
            Sigla = sigla;
        }
        public Nivel(int id, string? name, string? sigla)
        {
            Id = id;
            Name = name;
            Sigla = sigla;
        }
    }
}
