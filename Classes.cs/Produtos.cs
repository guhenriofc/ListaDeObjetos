namespace ListaDeObjetos.Classes.cs
{
    public class Produtos
    {
        public string Nome { get; set; }
        
        public int Codigo { get; set; }
        
        public float Preco { get; set; }
        public Produtos(){

        }

        public Produtos(string _nome, int _codigo, float _preco){
            this.Nome = _nome;
            this.Codigo = _codigo;
            this.Preco = _preco;
        }
        
        
    }
}