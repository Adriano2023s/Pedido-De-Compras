using System;

namespace PedidoDeCompras
{
    internal class PedidoDeCompras
    {
        public string Produtos;
        public double Preco;
        public double Quantidade;

        public double CalcularDesconto()
        {
            double desconto = 0.00;

            if (Quantidade <= 10)
            {
                desconto = ProdutoSemDesconto();
            }
            else if (Quantidade > 11 && Quantidade < 20)
            {
                desconto = CalculaPrimeiroDesconto();
            }
            else if (Quantidade > 21 && Quantidade <= 50)
            {
                desconto = CalculaSegundoDesconto();
            }
            else if (Quantidade > 50)
            {
                desconto = CalculaTerceiroDesconto();
            }
            return desconto;
        }

        public double ProdutoSemDesconto()
        {
            return 0.0;
        }

        public double CalculaPrimeiroDesconto()
        {
            return Preco * 0.10;
        }

        public double CalculaSegundoDesconto()
        {
            return Preco * 0.20;
        }

        public double CalculaTerceiroDesconto()
        {
            return Preco * 0.25;
        }
    }
}
