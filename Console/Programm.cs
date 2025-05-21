using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PhoneCatalog
{
    class Programm
    {
        static List<Phone> phones = new List<Phone>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            LoadData();
            while (true)
            {
                Console.WriteLine("1) Додати телефон\n2) Редагувати ціну\n3) Видалити телефон\n4) Показати всі телефони\n5) Показати смартфони\n6) Показати смартфони фірми\n7) Пошук за пам’яттю\n8) Сортувати смартфони за ціною\n9) Вихід");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1: AddPhone(); break;
                    case 2: EditPrice(); break;
                    case 3: DeletePhone(); break;
                    case 4: ShowAllPhones(); break;
                    case 5: ShowSmartphones(); break;
                    case 6: ShowSmartphonesByManufacturer(); break;
                    case 7: SearchByRam(); break;
                    case 8: SortSmartphonesByPrice(); break;
                    case 9: return;
                }
            }
        }

        static void LoadData()
        {
            if (!File.Exists("Phones.txt")) File.WriteAllText("Phones.txt", "");
            using (StreamReader sr = new StreamReader("Phones.txt", Encoding.UTF8))
            {
                string[] lines = sr.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    string[] data = line.Split(';');
                    if (bool.Parse(data[5]))
                        phones.Add(new Smartphone(data));
                    else
                        phones.Add(new ButtonPhone(data));
                }
            }
        }

        static void AddPhone()
        {
            Console.WriteLine("Введіть код товару:");
            int code = int.Parse(Console.ReadLine());
            if (phones.Any(p => p.Code == code))
            {
                Console.WriteLine("Телефон з таким кодом уже існує!");
                ReturnToMenu();
                return;
            }
            Console.WriteLine("Введіть модель:");
            string model = Console.ReadLine();
            Console.WriteLine("Введіть фірму-виробника:");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Введіть оперативну пам’ять (МБ):");
            int ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть ціну (грн):");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Це смартфон? (1 - Так, 2 - Ні):");
            bool isSmartphone = Console.ReadLine() == "1";
            string os = "";
            int coreCount = 0;
            if (isSmartphone)
            {
                Console.WriteLine("Введіть операційну систему:");
                os = Console.ReadLine();
                Console.WriteLine("Введіть кількість ядер:");
                coreCount = int.Parse(Console.ReadLine());
            }

            Phone phone = isSmartphone
                ? new Smartphone { Code = code, Model = model, Manufacturer = manufacturer, Ram = ram, Price = price, IsSmartphone = true, OperatingSystem = os, CoreCount = coreCount }
                : new ButtonPhone { Code = code, Model = model, Manufacturer = manufacturer, Ram = ram, Price = price, IsSmartphone = false };

            phones.Add(phone);
            using (StreamWriter sw = new StreamWriter("Phones.txt", true, Encoding.UTF8))
            {
                sw.WriteLine(phone.ToFile());
            }
            Console.WriteLine("Телефон додано!");
            ReturnToMenu();
        }

        static void EditPrice()
        {
            Console.WriteLine("Введіть код телефону для редагування ціни:");
            int code = int.Parse(Console.ReadLine());
            var phone = phones.FirstOrDefault(p => p.Code == code);
            if (phone == null)
            {
                Console.WriteLine("Телефон не знайдено!");
                ReturnToMenu();
                return;
            }

            Console.WriteLine("Введіть нову ціну (грн):");
            string priceStr = Console.ReadLine();
            if (!string.IsNullOrEmpty(priceStr)) phone.Price = decimal.Parse(priceStr);

            UpdateFile();
            Console.WriteLine("Ціну відредаговано!");
            ReturnToMenu();
        }

        static void DeletePhone()
        {
            Console.WriteLine("Введіть код телефону для видалення:");
            int code = int.Parse(Console.ReadLine());
            var phone = phones.FirstOrDefault(p => p.Code == code);
            if (phone == null)
            {
                Console.WriteLine("Телефон не знайдено!");
                ReturnToMenu();
                return;
            }

            phones.Remove(phone);
            UpdateFile();
            Console.WriteLine("Телефон видалено!");
            ReturnToMenu();
        }

        static void ShowAllPhones()
        {
            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
            }
            ReturnToMenu();
        }

        static void ShowSmartphones()
        {
            var smartphones = phones.Where(p => p.IsSmartphone);
            foreach (var phone in smartphones)
            {
                Console.WriteLine(phone);
            }
            ReturnToMenu();
        }

        static void ShowSmartphonesByManufacturer()
        {
            Console.WriteLine("Введіть фірму-виробника:");
            string manufacturer = Console.ReadLine();
            var smartphones = phones.Where(p => p.IsSmartphone && p.Manufacturer.Equals(manufacturer, StringComparison.OrdinalIgnoreCase));
            foreach (var phone in smartphones)
            {
                Console.WriteLine(phone);
            }
            ReturnToMenu();
        }

        static void SearchByRam()
        {
            Console.WriteLine("Введіть об’єм оперативної пам’яті (МБ):");
            int ram = int.Parse(Console.ReadLine());
            var matchingPhones = phones.Where(p => p.Ram == ram);
            foreach (var phone in matchingPhones)
            {
                Console.WriteLine(phone);
            }
            ReturnToMenu();
        }

        static void SortSmartphonesByPrice()
        {
            var sortedSmartphones = phones.Where(p => p.IsSmartphone).OrderBy(p => p.Price);
            foreach (var phone in sortedSmartphones)
            {
                Console.WriteLine(phone);
            }
            ReturnToMenu();
        }

        static void UpdateFile()
        {
            using (StreamWriter sw = new StreamWriter("Phones.txt", false, Encoding.UTF8))
            {
                foreach (var phone in phones)
                {
                    sw.WriteLine(phone.ToFile());
                }
            }
        }

        static void ReturnToMenu()
        {
            Console.WriteLine("Натисніть будь-яку клавішу, щоб повернутися до меню...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}