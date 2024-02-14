using System;
using jogaOnline.controlador;
using jogaOnline.Prodduct;
using JogarOnline.livros;

namespace JogarOnline // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Books harry = new Books();

            harry.Nome = "hharry potter";
            harry.DataFabric = 12121983;
            harry.Autor = "jk";
            harry.Valor = 25;
            
            Estoque newEstoque = new Estoque();

            newEstoque.AlterarEstoque(harry, 2);
        }
    }
}