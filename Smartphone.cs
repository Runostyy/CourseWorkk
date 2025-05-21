using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCatalog
{
    class Smartphone : Phone
    {
        public string OperatingSystem { get; set; }
        public int CoreCount { get; set; }

        public Smartphone() : base()
        {
            IsSmartphone = true;
            OperatingSystem = "none";
            CoreCount = 0;
        }

        public Smartphone(string[] data) : base(data)
        {
            IsSmartphone = true;
            OperatingSystem = data[6];
            CoreCount = int.Parse(data[7]);
        }

        public override decimal CalculateCost()
        {
            if (Price > 40000)
            {
                // Credit: 1 year, 2% interest
                decimal interest = Price * 0.02m;
                return Price + interest;
            }
            return Price;
        }

        public override string ToFile()
        {
            return base.ToFile() + $";{OperatingSystem};{CoreCount}";
        }

        public override string ToString()
        {
            return base.ToString() + $"ОС: {OperatingSystem}\nКількість ядер: {CoreCount}\nВартість (з кредитом, якщо > 40 тис.): {CalculateCost()} грн\n";
        }
    }
}
