using QuickBuy.Dominio.Enumerate;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ValueObject
{
    class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsUndefined
        {
            get { return Id == (int)PaymentMethodTypeEnum.Undefined; }
        }

        public bool IsBankSlip
        {
            get { return Id == (int)PaymentMethodTypeEnum.BankSlip; }
        }

        public bool IsCreditCard
        {
            get { return Id == (int)PaymentMethodTypeEnum.CreditCard; }
        }

        public bool IsDeposit
        {
            get { return Id == (int)PaymentMethodTypeEnum.Deposit; }
        }
    }
}
