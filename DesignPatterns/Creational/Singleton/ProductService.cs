namespace DesignPatterns.Criacionais.Singleton
{
    public class ProductService
    {
        public Product _product { get; set; }

        public Product Product {             get
            {
                if (_product == null)
                {
                    _product = new Product();
                }
                return _product;
            }
        }
    }
}
