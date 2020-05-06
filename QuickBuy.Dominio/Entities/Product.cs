namespace QuickBuy.Dominio.Entities
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AddMessage("Erro - Nome deve estar preenchido");

            if (Price == 0)
                AddMessage("Erro - É necessário informar o preço do produto");
        }
    }
}
