namespace DesignPatterns.Criacionais.Factory
{
    public class Book : Interface.IProduct
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public string Editora { get; set; }
        public float Preco { get; set; }

        public string ReturnProductName()
        {
            throw new System.NotImplementedException();
        }
    }
}
