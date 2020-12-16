using System;
using System.Collections.Generic;
using ListaDeObjetos.Classes.cs;

namespace ListaDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produtos> produtos = new List<Produtos>();

            Console.WriteLine("\n---Produtos disponiveis--- \n");
            
            produtos.Add(new Produtos("Iphone 8 Plus", 63, 2799.99f));
            produtos.Add(new Produtos("Notebook Lenovo", 085, 3599.99f));
            produtos.Add(new Produtos("Tenis Oakley Flak 365", 056, 659.99f));
            produtos.Add(new Produtos("Sansung Galaxy A30", 86, 1899.99f));
            produtos.Add(new Produtos("Iphone X", 66, 4899.99f));
            produtos.Add(new Produtos("Iphone XII", 67, 6999.99f));
            
            Produtos p1 = new Produtos();
            p1.Nome = "Apple Watch";
            p1.Codigo = 70;
            p1.Preco = 1599.90f;

            produtos.Add(p1);

            foreach (Produtos elementos in produtos)
            {
                Console.WriteLine(elementos.Nome);
            }

            produtos.RemoveAt(3);

            Console.WriteLine("\n---Venda do produto de indice 3--- \n");
            foreach (Produtos elementos in produtos)
            {
                Console.WriteLine(elementos.Nome);
            }

            produtos.RemoveAll(x => x.Nome == "Notebook Lenovo");

            Console.WriteLine("\n---Indisponibilidade do Notebook Lenovo--- \n");
            foreach (Produtos elementos in produtos)
            {
                Console.WriteLine(elementos.Nome);
            }
        }
    }
}
