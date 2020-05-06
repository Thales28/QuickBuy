namespace QuickBuy.Dominio.Entities
{
    public class OrderItem : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            if (Quantity == 0)
                AddMessage("Erro - É necessário informar a quantidade");

            if (ProductId == 0)
                AddMessage("Erro - É necessário informar o produto");
        }
    }
}
