using System;

namespace PhoneCatalog
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.CodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.RamNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.CoreCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.SmartphoneRadioButton = new System.Windows.Forms.RadioButton();
            this.ButtonPhoneRadioButton = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.PhonesListBox = new System.Windows.Forms.ListBox();
            this.SmartphoneFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.ManufacturerFilterTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerFilterButton = new System.Windows.Forms.Button();
            this.RamSearchNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RamSearchButton = new System.Windows.Forms.Button();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.RamLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.CoreCountLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CodeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoreCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamSearchNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CodeNumericUpDown
            // 
            this.CodeNumericUpDown.Location = new System.Drawing.Point(150, 20);
            this.CodeNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.CodeNumericUpDown.Name = "CodeNumericUpDown";
            this.CodeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CodeNumericUpDown.TabIndex = 0;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(150, 50);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(200, 20);
            this.ModelTextBox.TabIndex = 1;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(150, 80);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(200, 20);
            this.ManufacturerTextBox.TabIndex = 2;
            // 
            // RamNumericUpDown
            // 
            this.RamNumericUpDown.Location = new System.Drawing.Point(150, 110);
            this.RamNumericUpDown.Maximum = new decimal(new int[] { 65536, 0, 0, 0 });
            this.RamNumericUpDown.Name = "RamNumericUpDown";
            this.RamNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.RamNumericUpDown.TabIndex = 3;
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.DecimalPlaces = 2;
            this.PriceNumericUpDown.Location = new System.Drawing.Point(150, 140);
            this.PriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.PriceNumericUpDown.Name = "PriceNumericUpDown";
            this.PriceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PriceNumericUpDown.TabIndex = 4;
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(150, 170);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(200, 20);
            this.OSTextBox.TabIndex = 5;
            this.OSTextBox.Visible = false;
            // 
            // CoreCountNumericUpDown
            // 
            this.CoreCountNumericUpDown.Location = new System.Drawing.Point(150, 200);
            this.CoreCountNumericUpDown.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            this.CoreCountNumericUpDown.Name = "CoreCountNumericUpDown";
            this.CoreCountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CoreCountNumericUpDown.TabIndex = 6;
            this.CoreCountNumericUpDown.Visible = false;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(150, 230);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(120, 20);
            this.CostTextBox.TabIndex = 7;
            // 
            // SmartphoneRadioButton
            // 
            this.SmartphoneRadioButton.AutoSize = true;
            this.SmartphoneRadioButton.Location = new System.Drawing.Point(150, 260);
            this.SmartphoneRadioButton.Name = "SmartphoneRadioButton";
            this.SmartphoneRadioButton.Size = new System.Drawing.Size(85, 17);
            this.SmartphoneRadioButton.TabIndex = 8;
            this.SmartphoneRadioButton.Text = "Смартфон";
            this.SmartphoneRadioButton.CheckedChanged += new System.EventHandler(this.SmartphoneRadioButton_CheckedChanged);
            // 
            // ButtonPhoneRadioButton
            // 
            this.ButtonPhoneRadioButton.AutoSize = true;
            this.ButtonPhoneRadioButton.Checked = true;
            this.ButtonPhoneRadioButton.Location = new System.Drawing.Point(250, 260);
            this.ButtonPhoneRadioButton.Name = "ButtonPhoneRadioButton";
            this.ButtonPhoneRadioButton.Size = new System.Drawing.Size(120, 17);
            this.ButtonPhoneRadioButton.TabIndex = 9;
            this.ButtonPhoneRadioButton.TabStop = true;
            this.ButtonPhoneRadioButton.Text = "Кнопочний телефон";
            this.ButtonPhoneRadioButton.CheckedChanged += new System.EventHandler(this.ButtonPhoneRadioButton_CheckedChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(20, 290);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(110, 290);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "Редагувати";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(200, 290);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(20, 320);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(75, 23);
            this.FirstButton.TabIndex = 13;
            this.FirstButton.Text = "Перший";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(110, 320);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(75, 23);
            this.LastButton.TabIndex = 14;
            this.LastButton.Text = "Останній";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(200, 320);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 15;
            this.NextButton.Text = "Наступний";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(290, 320);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 16;
            this.PrevButton.Text = "Попередній";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // PhonesListBox
            // 
            this.PhonesListBox.FormattingEnabled = true;
            this.PhonesListBox.Location = new System.Drawing.Point(400, 20);
            this.PhonesListBox.Name = "PhonesListBox";
            this.PhonesListBox.Size = new System.Drawing.Size(300, 277);
            this.PhonesListBox.TabIndex = 17;
            this.PhonesListBox.SelectedIndexChanged += new System.EventHandler(this.PhonesListBox_SelectedIndexChanged);
            // 
            // SmartphoneFilterCheckBox
            // 
            this.SmartphoneFilterCheckBox.AutoSize = true;
            this.SmartphoneFilterCheckBox.Location = new System.Drawing.Point(400, 310);
            this.SmartphoneFilterCheckBox.Name = "SmartphoneFilterCheckBox";
            this.SmartphoneFilterCheckBox.Size = new System.Drawing.Size(120, 17);
            this.SmartphoneFilterCheckBox.TabIndex = 18;
            this.SmartphoneFilterCheckBox.Text = "Показати смартфони";
            this.SmartphoneFilterCheckBox.UseVisualStyleBackColor = true;
            this.SmartphoneFilterCheckBox.CheckedChanged += new System.EventHandler(this.SmartphoneFilterCheckBox_CheckedChanged);
            // 
            // ManufacturerFilterTextBox
            // 
            this.ManufacturerFilterTextBox.Location = new System.Drawing.Point(400, 340);
            this.ManufacturerFilterTextBox.Name = "ManufacturerFilterTextBox";
            this.ManufacturerFilterTextBox.Size = new System.Drawing.Size(200, 20);
            this.ManufacturerFilterTextBox.TabIndex = 19;
            // 
            // ManufacturerFilterButton
            // 
            this.ManufacturerFilterButton.Location = new System.Drawing.Point(610, 340);
            this.ManufacturerFilterButton.Name = "ManufacturerFilterButton";
            this.ManufacturerFilterButton.Size = new System.Drawing.Size(90, 23);
            this.ManufacturerFilterButton.TabIndex = 20;
            this.ManufacturerFilterButton.Text = "Фільтрувати";
            this.ManufacturerFilterButton.UseVisualStyleBackColor = true;
            this.ManufacturerFilterButton.Click += new System.EventHandler(this.ManufacturerFilterButton_Click);
            // 
            // RamSearchNumericUpDown
            // 
            this.RamSearchNumericUpDown.Location = new System.Drawing.Point(400, 370);
            this.RamSearchNumericUpDown.Maximum = new decimal(new int[] { 65536, 0, 0, 0 });
            this.RamSearchNumericUpDown.Name = "RamSearchNumericUpDown";
            this.RamSearchNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.RamSearchNumericUpDown.TabIndex = 21;
            // 
            // RamSearchButton
            // 
            this.RamSearchButton.Location = new System.Drawing.Point(530, 370);
            this.RamSearchButton.Name = "RamSearchButton";
            this.RamSearchButton.Size = new System.Drawing.Size(90, 23);
            this.RamSearchButton.TabIndex = 22;
            this.RamSearchButton.Text = "Пошук";
            this.RamSearchButton.UseVisualStyleBackColor = true;
            this.RamSearchButton.Click += new System.EventHandler(this.RamSearchButton_Click);
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(20, 20);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(80, 13);
            this.CodeLabel.TabIndex = 23;
            this.CodeLabel.Text = "Код товару:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(20, 50);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(80, 13);
            this.ModelLabel.TabIndex = 24;
            this.ModelLabel.Text = "Модель:";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(20, 80);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(80, 13);
            this.ManufacturerLabel.TabIndex = 25;
            this.ManufacturerLabel.Text = "Виробник:";
            // 
            // RamLabel
            // 
            this.RamLabel.AutoSize = true;
            this.RamLabel.Location = new System.Drawing.Point(20, 110);
            this.RamLabel.Name = "RamLabel";
            this.RamLabel.Size = new System.Drawing.Size(80, 13);
            this.RamLabel.TabIndex = 26;
            this.RamLabel.Text = "Пам’ять (МБ):";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(20, 140);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(80, 13);
            this.PriceLabel.TabIndex = 27;
            this.PriceLabel.Text = "Ціна (грн):";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(20, 170);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(80, 13);
            this.OSLabel.TabIndex = 28;
            this.OSLabel.Text = "ОС:";
            this.OSLabel.Visible = false;
            // 
            // CoreCountLabel
            // 
            this.CoreCountLabel.AutoSize = true;
            this.CoreCountLabel.Location = new System.Drawing.Point(20, 200);
            this.CoreCountLabel.Name = "CoreCountLabel";
            this.CoreCountLabel.Size = new System.Drawing.Size(80, 13);
            this.CoreCountLabel.TabIndex = 29;
            this.CoreCountLabel.Text = "Кількість ядер:";
            this.CoreCountLabel.Visible = false;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(20, 230);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(80, 13);
            this.CostLabel.TabIndex = 30;
            this.CostLabel.Text = "Вартість:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CoreCountLabel);
            this.Controls.Add(this.OSLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.RamLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.RamSearchButton);
            this.Controls.Add(this.RamSearchNumericUpDown);
            this.Controls.Add(this.ManufacturerFilterButton);
            this.Controls.Add(this.ManufacturerFilterTextBox);
            this.Controls.Add(this.SmartphoneFilterCheckBox);
            this.Controls.Add(this.PhonesListBox);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ButtonPhoneRadioButton);
            this.Controls.Add(this.SmartphoneRadioButton);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.CoreCountNumericUpDown);
            this.Controls.Add(this.OSTextBox);
            this.Controls.Add(this.PriceNumericUpDown);
            this.Controls.Add(this.RamNumericUpDown);
            this.Controls.Add(this.ManufacturerTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.CodeNumericUpDown);
            this.Name = "Form1";
            this.Text = "Каталог телефонів";
            ((System.ComponentModel.ISupportInitialize)(this.CodeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoreCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamSearchNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown CodeNumericUpDown;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.NumericUpDown RamNumericUpDown;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.NumericUpDown CoreCountNumericUpDown;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.RadioButton SmartphoneRadioButton;
        private System.Windows.Forms.RadioButton ButtonPhoneRadioButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.ListBox PhonesListBox;
        private System.Windows.Forms.CheckBox SmartphoneFilterCheckBox;
        private System.Windows.Forms.TextBox ManufacturerFilterTextBox;
        private System.Windows.Forms.Button ManufacturerFilterButton;
        private System.Windows.Forms.NumericUpDown RamSearchNumericUpDown;
        private System.Windows.Forms.Button RamSearchButton;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label RamLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label CoreCountLabel;
        private System.Windows.Forms.Label CostLabel;

        private void SmartphoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OSLabel.Visible = true;
            OSTextBox.Visible = true;
            CoreCountLabel.Visible = true;
            CoreCountNumericUpDown.Visible = true;
        }

        private void ButtonPhoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OSLabel.Visible = false;
            OSTextBox.Visible = false;
            CoreCountLabel.Visible = false;
            CoreCountNumericUpDown.Visible = false;
        }
    }
}