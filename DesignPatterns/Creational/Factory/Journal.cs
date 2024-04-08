using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacionais.Factory
{
    public class Journal : Interface.IProduct
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int NumeroFolhas { get; set; }
        public bool Pautado { get; set; }
        public float Preco { get; set; }

        public string ReturnProductName()
        {
            throw new NotImplementedException();
        }
    }
}
