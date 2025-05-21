using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhoneCatalog
{
    public partial class Form1 : Form
    {
        private static LinkedList<Phone> phones = new LinkedList<Phone>();
        private static Phone currentPhone;
        private static int currentIndex;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            FirstButton_Click(null, null);
        }

        private void LoadData()
        {
            if (!File.Exists("Phones.txt")) File.WriteAllText("Phones.txt", "");
            using (StreamReader sr = new StreamReader("Phones.txt", Encoding.UTF8))
            {
                string[] lines = sr.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    string[] data = line.Split(';');
                    if (bool.Parse(data[5]))
                        phones.AddLast(new Smartphone(data));
                    else
                        phones.AddLast(new ButtonPhone(data));
                }
            }
            UpdateListBox();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            int code = (int)CodeNumericUpDown.Value;
            if (phones.Any(p => p.Code == code))
            {
                MessageBox.Show("Телефон з таким кодом уже існує!");
                return;
            }

            string model = ModelTextBox.Text;
            string manufacturer = ManufacturerTextBox.Text;
            int ram = (int)RamNumericUpDown.Value;
            decimal price = PriceNumericUpDown.Value;
            bool isSmartphone = SmartphoneRadioButton.Checked;
            string os = isSmartphone ? OSTextBox.Text : "";
            int coreCount = isSmartphone ? (int)CoreCountNumericUpDown.Value : 0;

            Phone phone = isSmartphone
                ? (Phone)new Smartphone { Code = code, Model = model, Manufacturer = manufacturer, Ram = ram, Price = price, IsSmartphone = true, OperatingSystem = os, CoreCount = coreCount }
                : (Phone)new ButtonPhone { Code = code, Model = model, Manufacturer = manufacturer, Ram = ram, Price = price, IsSmartphone = false };

            phones.AddLast(phone);
            using (StreamWriter sw = new StreamWriter("Phones.txt", true, Encoding.UTF8))
            {
                sw.WriteLine(phone.ToFile());
            }

            currentPhone = phone;
            currentIndex = phones.Count - 1;
            UpdateListBox();
            ShowCurrentPhone();
            MessageBox.Show("Телефон додано!");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (currentPhone == null) return;
            if (!ValidateInput()) return;

            int code = (int)CodeNumericUpDown.Value;
            if (code != currentPhone.Code && phones.Any(p => p.Code == code))
            {
                MessageBox.Show("Телефон з таким кодом уже існує!");
                return;
            }

            currentPhone.Code = code;
            currentPhone.Model = ModelTextBox.Text;
            currentPhone.Manufacturer = ManufacturerTextBox.Text;
            currentPhone.Ram = (int)RamNumericUpDown.Value;
            currentPhone.Price = PriceNumericUpDown.Value;

            if (SmartphoneRadioButton.Checked && currentPhone is Smartphone smartphone)
            {
                smartphone.OperatingSystem = OSTextBox.Text;
                smartphone.CoreCount = (int)CoreCountNumericUpDown.Value;
            }
            else if (ButtonPhoneRadioButton.Checked && currentPhone is Smartphone)
            {
                var newPhone = new ButtonPhone
                {
                    Code = currentPhone.Code,
                    Model = currentPhone.Model,
                    Manufacturer = currentPhone.Manufacturer,
                    Ram = currentPhone.Ram,
                    Price = currentPhone.Price,
                    IsSmartphone = false
                };
                var node = phones.Find(currentPhone);
                phones.AddAfter(node, newPhone);
                phones.Remove(node);
                currentPhone = newPhone;
            }
            else if (SmartphoneRadioButton.Checked && currentPhone is ButtonPhone)
            {
                var newPhone = new Smartphone
                {
                    Code = currentPhone.Code,
                    Model = currentPhone.Model,
                    Manufacturer = currentPhone.Manufacturer,
                    Ram = currentPhone.Ram,
                    Price = currentPhone.Price,
                    IsSmartphone = true,
                    OperatingSystem = OSTextBox.Text,
                    CoreCount = (int)CoreCountNumericUpDown.Value
                };
                var node = phones.Find(currentPhone);
                phones.AddAfter(node, newPhone);
                phones.Remove(node);
                currentPhone = newPhone;
            }

            UpdateFile();
            UpdateListBox();
            ShowCurrentPhone();
            MessageBox.Show("Телефон відредаговано!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (currentPhone == null) return;

            phones.Remove(currentPhone);
            UpdateFile();
            currentIndex = currentIndex >= phones.Count ? phones.Count - 1 : currentIndex;
            currentPhone = phones.ElementAtOrDefault(currentIndex);
            UpdateListBox();
            ShowCurrentPhone();
            MessageBox.Show("Телефон видалено!");
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < phones.Count; i++)
            {
                if (FilterCheck(phones.ElementAt(i)))
                {
                    currentPhone = phones.ElementAt(i);
                    currentIndex = i;
                    break;
                }
            }
            ShowCurrentPhone();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            for (int i = phones.Count - 1; i >= 0; i--)
            {
                if (FilterCheck(phones.ElementAt(i)))
                {
                    currentPhone = phones.ElementAt(i);
                    currentIndex = i;
                    break;
                }
            }
            ShowCurrentPhone();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            for (int i = currentIndex + 1; i < phones.Count; i++)
            {
                if (FilterCheck(phones.ElementAt(i)))
                {
                    currentPhone = phones.ElementAt(i);
                    currentIndex = i;
                    break;
                }
            }
            ShowCurrentPhone();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            for (int i = currentIndex - 1; i >= 0; i--)
            {
                if (FilterCheck(phones.ElementAt(i)))
                {
                    currentPhone = phones.ElementAt(i);
                    currentIndex = i;
                    break;
                }
            }
            ShowCurrentPhone();
        }

        private void ShowCurrentPhone()
        {
            if (currentPhone == null)
            {
                ClearForm();
                return;
            }

            CodeNumericUpDown.Value = currentPhone.Code;
            ModelTextBox.Text = currentPhone.Model;
            ManufacturerTextBox.Text = currentPhone.Manufacturer;
            RamNumericUpDown.Value = currentPhone.Ram;
            PriceNumericUpDown.Value = currentPhone.Price;
            CostTextBox.Text = currentPhone.CalculateCost().ToString();

            if (currentPhone is Smartphone smartphone)
            {
                SmartphoneRadioButton.Checked = true;
                OSTextBox.Text = smartphone.OperatingSystem;
                CoreCountNumericUpDown.Value = smartphone.CoreCount;
                OSLabel.Visible = true;
                OSTextBox.Visible = true;
                CoreCountLabel.Visible = true;
                CoreCountNumericUpDown.Visible = true;
            }
            else
            {
                ButtonPhoneRadioButton.Checked = true;
                OSTextBox.Text = "";
                CoreCountNumericUpDown.Value = 0;
                OSLabel.Visible = false;
                OSTextBox.Visible = false;
                CoreCountLabel.Visible = false;
                CoreCountNumericUpDown.Visible = false;
            }

            PhonesListBox.SelectedIndex = phones.ToList().IndexOf(currentPhone);
        }

        private void PhonesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PhonesListBox.SelectedIndex == -1) return;
            var selectedPhone = phones.FirstOrDefault(p => p.ToListBox() == PhonesListBox.SelectedItem.ToString());
            if (selectedPhone != null)
            {
                currentPhone = selectedPhone;
                currentIndex = phones.ToList().IndexOf(selectedPhone);
                ShowCurrentPhone();
            }
        }

        private void SmartphoneFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void ManufacturerFilterButton_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void RamSearchButton_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            PhonesListBox.Items.Clear();
            foreach (var phone in phones)
            {
                if (SmartphoneFilterCheckBox.Checked && !phone.IsSmartphone) continue;
                if (!string.IsNullOrEmpty(ManufacturerFilterTextBox.Text) && !phone.Manufacturer.Equals(ManufacturerFilterTextBox.Text, StringComparison.OrdinalIgnoreCase)) continue;
                if (RamSearchNumericUpDown.Value != 0 && phone.Ram != (int)RamSearchNumericUpDown.Value) continue;
                PhonesListBox.Items.Add(phone.ToListBox());
            }
            if (!FilterCheck(currentPhone)) FirstButton_Click(null, null);
            ShowCurrentPhone();
        }

        private bool FilterCheck(Phone phone)
        {
            if (phone == null) return false;
            if (SmartphoneFilterCheckBox.Checked && !phone.IsSmartphone) return false;
            if (!string.IsNullOrEmpty(ManufacturerFilterTextBox.Text) && !phone.Manufacturer.Equals(ManufacturerFilterTextBox.Text, StringComparison.OrdinalIgnoreCase)) return false;
            if (RamSearchNumericUpDown.Value != 0 && phone.Ram != (int)RamSearchNumericUpDown.Value) return false;
            return true;
        }

        private void UpdateFile()
        {
            using (StreamWriter sw = new StreamWriter("Phones.txt", false, Encoding.UTF8))
            {
                foreach (var phone in phones)
                {
                    sw.WriteLine(phone.ToFile());
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(ModelTextBox.Text) ||
                string.IsNullOrWhiteSpace(ManufacturerTextBox.Text) ||
                (SmartphoneRadioButton.Checked && string.IsNullOrWhiteSpace(OSTextBox.Text)))
            {
                MessageBox.Show("Заповніть усі обов’язкові поля!");
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            CodeNumericUpDown.Value = 0;
            ModelTextBox.Text = "";
            ManufacturerTextBox.Text = "";
            RamNumericUpDown.Value = 0;
            PriceNumericUpDown.Value = 0;
            OSTextBox.Text = "";
            CoreCountNumericUpDown.Value = 0;
            CostTextBox.Text = "";
            ButtonPhoneRadioButton.Checked = true;
        }
    }
}
