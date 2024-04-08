using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacionais.Factory
{
    public class Pencil : Interface.IProduct
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int Tamanho { get; set; }
        public bool Apontado { get; set; }
        public float Preco { get; set; }

        public string ReturnProductName()
        {
            throw new NotImplementedException();
        }
    }
}
