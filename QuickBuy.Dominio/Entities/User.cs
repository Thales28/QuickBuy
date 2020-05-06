using System.Collections.Generic;

namespace QuickBuy.Dominio.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AddMessage("Erro - Email deve estar preenchido");

            if (string.IsNullOrEmpty(Password))
                AddMessage("Erro - Senha deve estar preenchido");

            if (string.IsNullOrEmpty(Name))
                AddMessage("Erro - Nome deve estar preenchido");

            if (string.IsNullOrEmpty(Surname))
                AddMessage("Erro - Sobrenome deve estar preenchido");
        }
    }
}