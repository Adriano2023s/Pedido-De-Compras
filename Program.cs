using System;

namespace PedidoDeCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedidoDeCompras pedido = new PedidoDeCompras();

            Console.WriteLine("Digite o nome do produto que você comprou");
            pedido.NomeDoProduto = Console.ReadLine();            

            Console.WriteLine($"Digite a quantidade de: {pedido.NomeDoProduto} comprados");
            pedido.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o valor do: {pedido.NomeDoProduto}");
            pedido.Preco = double.Parse(Console.ReadLine());

            double precoFinal = pedido.ValorTotal();

            Console.WriteLine($"O valor a pagar por {pedido.NomeDoProduto} é {precoFinal}.");
            Console.WriteLine($"Você está levando {pedido.Quantidade} unidades.");

        }
    }
}
