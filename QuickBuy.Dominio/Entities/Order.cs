using QuickBuy.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entities
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string FullAdress { get; set; }
        public int AdressNumber { get; set; }

        public int PaymentMethodId { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public override void Validate()
        {
            if (!OrderItems.Any())
                AddMessage("Erro - Pedido não pode ficar sem items");

            if (string.IsNullOrEmpty(ZipCode))
                AddMessage("Erro - CEP deve estar preenchido");
        }
    }
}
