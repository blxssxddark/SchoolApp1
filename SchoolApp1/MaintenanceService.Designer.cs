namespace SchoolApp1
{
    partial class MaintenanceService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDescription = new TextBox();
            dateTimePickerRepairDate = new DateTimePicker();
            textBoxSerialNumber = new TextBox();
            button2 = new Button();
            button1 = new Button();
            comboBoxRepairType = new ComboBox();
            label5 = new Label();
            textBoxCost = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 144);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 16;
            label4.Text = "Дата обслуживания";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 92);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 15;
            label3.Text = "Серийный номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 267);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 14;
            label2.Text = "Описание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 36);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 13;
            label1.Text = "Тип события";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(330, 267);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(320, 123);
            textBoxDescription.TabIndex = 12;
            // 
            // dateTimePickerRepairDate
            // 
            dateTimePickerRepairDate.Location = new Point(330, 144);
            dateTimePickerRepairDate.Name = "dateTimePickerRepairDate";
            dateTimePickerRepairDate.Size = new Size(319, 31);
            dateTimePickerRepairDate.TabIndex = 11;
            // 
            // textBoxSerialNumber
            // 
            textBoxSerialNumber.Location = new Point(329, 92);
            textBoxSerialNumber.Name = "textBoxSerialNumber";
            textBoxSerialNumber.Size = new Size(320, 31);
            textBoxSerialNumber.TabIndex = 10;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(495, 432);
            button2.Name = "button2";
            button2.Size = new Size(153, 58);
            button2.TabIndex = 18;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(199, 432);
            button1.Name = "button1";
            button1.Size = new Size(160, 58);
            button1.TabIndex = 17;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxRepairType
            // 
            comboBoxRepairType.FormattingEnabled = true;
            comboBoxRepairType.Location = new Point(329, 28);
            comboBoxRepairType.Name = "comboBoxRepairType";
            comboBoxRepairType.Size = new Size(320, 33);
            comboBoxRepairType.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 205);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 20;
            label5.Text = "Стоимость";
            // 
            // textBoxCost
            // 
            textBoxCost.Location = new Point(329, 205);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(319, 31);
            textBoxCost.TabIndex = 21;
            // 
            // MaintenanceService
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(textBoxCost);
            Controls.Add(label5);
            Controls.Add(comboBoxRepairType);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDescription);
            Controls.Add(dateTimePickerRepairDate);
            Controls.Add(textBoxSerialNumber);
            Name = "MaintenanceService";
            Text = "MaintenanceService";
            Load += MaintenanceService_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxDescription;
        private DateTimePicker dateTimePickerRepairDate;
        private TextBox textBoxSerialNumber;
        private Button button2;
        private Button button1;
        private ComboBox comboBoxRepairType;
        private Label label5;
        private TextBox textBoxCost;
    }
}