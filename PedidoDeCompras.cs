using System;

namespace PedidoDeCompras
{
    internal class PedidoDeCompras
    {
        public string Produtos;
        public double Preco;
        public int Quantidade;

        public PedidoDeCompras()
        {
        }

        public PedidoDeCompras(string produtos, double preco, int quantidade)
        {
            this.Produtos = produtos;
            this.Preco = preco;
            this.Quantidade = quantidade;
            }

        public double CalcularDesconto()
        {
            if (Quantidade <= 10)
            {
                return 0;
            }
            else if (Quantidade <= 20)
            {
                return Preco * Quantidade * 0.10;
            }
            else if (Quantidade <= 50)
            {
                return Preco * Quantidade * 0.20;
            }
            else
            {
                return Preco * Quantidade * 0.25;
            }
        }
    
        public double ValorTotal()
        {
            double valorTotal = Preco * Quantidade;
            double desconto = CalcularDesconto();
            return valorTotal - desconto;
        }
    }
}
