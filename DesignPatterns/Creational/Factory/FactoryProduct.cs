using System;

namespace DesignPatterns.Criacionais.Factory
{
    public class FactoryProduct
    {
        public Interface.IProduct CreateProduct(string productType)
        {
            switch (productType)
            {
                case "Lapis":
                    return new Pencil();
                case "Caderno":
                    return new Journal();
                case "Livro":
                    return new Book();
                default:
                    throw new NotImplementedException("Produto não encontrado");
            }
        }
    }
}
