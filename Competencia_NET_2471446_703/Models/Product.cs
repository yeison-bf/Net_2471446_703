using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_NET_2471446_703.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }


        public Product(int id, string nombre, int cantidad, int  valor)
        {
            Id = id;
            Name = nombre;
            Count = cantidad;
            Value = valor;
        }
    }
}
