using System;

namespace PedidoDeCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedidoDeCompras Compras = new PedidoDeCompras();

            Console.WriteLine("Digite o nome do produto que você comprou");
            Compras.Produtos = Console.ReadLine();

            Console.WriteLine($"Digite a quantidade de: {Compras.Produtos} comprados");
            Compras.Quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o valor do: {Compras.Produtos}");
            Compras.Preco = double.Parse(Console.ReadLine());

            double desconto = Compras.CalcularDesconto();

            double precoFinal = Compras.Preco - desconto;

            Console.WriteLine($"Produto: {Compras.Produtos}, unidades: {Compras.Quantidade}, e o valor é: {Compras.Preco}");
            Console.WriteLine($"Desconto: R${desconto:0.00}");
            Console.WriteLine($"Valor final do produto: {precoFinal:0.00}");
        }
    }
}
