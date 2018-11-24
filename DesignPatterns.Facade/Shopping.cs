namespace DesignPatterns.Facade
{
    public class Shopping
    {
        private readonly Stock _stock;
        private readonly Order _order;

        public Shopping()
        {
            _stock = new Stock();
            _order = new Order();
        }

        public bool SalesToProduct(Product product)
        {
            if (_stock.CheckStokByProduct(product))
            {
                _stock.LookProductTemporary(product);
                _order.AddToProduct(product);

                return true;
            }

            return false;
        }
    }
}