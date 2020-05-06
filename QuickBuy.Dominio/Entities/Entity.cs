using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entities
{
    public abstract class Entity
    {
        private List<string> _validationMessages { get; set; }
        private List<string> validationMessage
        {
            get { return _validationMessages ?? (_validationMessages = new List<string>()); }
        }

        protected void ClearMessages()
        {
            validationMessage.Clear();
        }
        protected void AddMessage(string message)
        {
            validationMessage.Add(message);
        }
        public abstract void Validate();
        protected bool IsValid
        {
            get { return (!validationMessage.Any()); }
        }
    }
}
