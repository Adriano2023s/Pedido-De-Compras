using System;

namespace PedidoDeCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedidoDeCompras pedido = new PedidoDeCompras();

            Console.WriteLine("Digite o nome do produto que você comprou");
            pedido.Produtos = Console.ReadLine();

            Console.WriteLine($"Digite a quantidade de: {pedido.Produtos} comprados");
            pedido.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o valor do: {pedido.Produtos}");
            pedido.Preco = double.Parse(Console.ReadLine());

            double precoFinal = pedido.ValorTotal();

            Console.WriteLine($"O valor a pagar por {pedido.Produtos} é {precoFinal}.");
            Console.WriteLine($"Você está levando {pedido.Quantidade} unidades.");

        }
    }
}
