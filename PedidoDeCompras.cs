namespace PedidoDeCompras
{
    internal class PedidoDeCompras
    {
        private string _NomeDoProduto;
        private double _Preco;
        private int _Quantidade;

        public string NomeDoProduto
        {
            get
            {
                return _NomeDoProduto;
                }
            set
            {
                _NomeDoProduto = value;
            }
        }

        public double Preco
        {
            get
            {
                return _Preco;
            }
            set
            {
                _Preco = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return _Quantidade;
            }
            set
            {
                _Quantidade = value;
            }
        }

        public PedidoDeCompras()
        {

        }

        public PedidoDeCompras(string nomedoproduto, double preco, int quantidade)
        {
            NomeDoProduto = nomedoproduto;
            Preco = preco;
            Quantidade = quantidade;
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
