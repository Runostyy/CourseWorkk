using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCatalog
{
    class ButtonPhone : Phone
    {
        public ButtonPhone() : base()
        {
            IsSmartphone = false;
        }

        public ButtonPhone(string[] data) : base(data)
        {
            IsSmartphone = false;
        }

        public override decimal CalculateCost()
        {
            if (Price > 2000)
            {
                // Discount: 100 UAH
                return Price - 100;
            }
            return Price;
        }

        public override string ToString()
        {
            return base.ToString() + $"Вартість (зі знижкою, якщо > 2 тис.): {CalculateCost()} грн\n";
        }
    }
}
