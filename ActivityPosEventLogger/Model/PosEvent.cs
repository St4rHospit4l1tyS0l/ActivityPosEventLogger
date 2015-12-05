using System;
using ActivityPosEventLogger.Model;

namespace ActivityPosEventLogger
{
    public partial class PosEvent
    {
        public PosEvent(string eventName, int terminalId, PosEventEmployee employee)
        {
            Employee = employee;
            Terminal = terminalId;
            EventName = eventName;
            Date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        public PosEvent(string eventName, int terminalId, PosEventEmployee employee, PosEventItem item)
            : this(eventName, terminalId, employee)
        {
            Item = item;
        }


        public PosEvent(string eventName, int terminalId, PosEventEmployee employee, String sMessage)
            : this(eventName, terminalId, employee)
        {
            SpecialMessage = sMessage;
        }

        public PosEvent(string eventName, int terminalId, PosEventEmployee employee, PosEventPayment payment)
            : this(eventName, terminalId, employee)
        {
            Payment = payment;
        }

        public PosEvent(string eventName, int terminalId, PosEventEmployee employee, PosEventComp comp)
            : this(eventName, terminalId, employee)
        {
            Comp = comp;
        }

        public PosEvent(string eventName, int terminalId, PosEventEmployee employee, PosEventPromo promo)
            : this(eventName, terminalId, employee)
        {
            Promo = promo;
        }


        public static PosEventEmployee GetEmployeeNotFound(int iEmployeeId)
        {
            return new PosEventEmployee
            {
                FirstName = "No encontrado",
                LastName = "No encontrado",
                Id = iEmployeeId
            };
        }


        public static PosEventItem GetItemNotFound()
        {
            return new PosEventItem
            {
                Name = "No encontrado",
                Price = 0.0,
                Id = Constants.ID_NULL
            };
        }

        public static PosEventPayment GetPaymentNotFound()
        {
            return new PosEventPayment
            {
                Amount = 0.0,
                PaymentMethod = "No encontrado"
            };
        }

        public static PosEventComp GetCompNotFound()
        {
            return new PosEventComp
            {
                CompTypeId = Constants.ID_NULL,
                CompDesc = "No encontrado"
            };
        }


        public static PosEventPromo GetPromotionNotFound()
        {
            return new PosEventPromo
            {
                PromotionId = Constants.ID_NULL,
                PromoDesc = "No encontrado"
            };
        }
    }
}
