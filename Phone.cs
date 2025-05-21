using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCatalog
{
    abstract class Phone
    {
        public int Code { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Ram { get; set; } // In MB
        public decimal Price { get; set; }
        public bool IsSmartphone { get; set; }

        public Phone()
        {
            Code = -1;
            Model = "none";
            Manufacturer = "none";
            Ram = 0;
            Price = 0;
            IsSmartphone = false;
        }

        public Phone(string[] data)
        {
            Code = int.Parse(data[0]);
            Model = data[1];
            Manufacturer = data[2];
            Ram = int.Parse(data[3]);
            Price = decimal.Parse(data[4]);
            IsSmartphone = bool.Parse(data[5]);
        }

        public virtual decimal CalculateCost()
        {
            return Price;
        }

        public virtual string ToFile()
        {
            return $"{Code};{Model};{Manufacturer};{Ram};{Price};{IsSmartphone}";
        }

        public override string ToString()
        {
            return $"Код: {Code}\nМодель: {Model}\nВиробник: {Manufacturer}\nОперативна пам’ять: {Ram} МБ\nЦіна: {Price} грн\nТип: {(IsSmartphone ? "Смартфон" : "Кнопочний телефон")}\n";
        }

        public string ToListBox()
        {
            return $"{Code}: {Model} ({Manufacturer})";
        }
    }
}
