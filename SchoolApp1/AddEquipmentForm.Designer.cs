namespace SchoolApp1
{
    partial class AddEquipmentForm
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
            button1 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDescription = new TextBox();
            dateTimePickerPurchaseDate = new DateTimePicker();
            textBoxSerialNumber = new TextBox();
            textBoxModel = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(189, 371);
            button1.Name = "button1";
            button1.Size = new Size(160, 58);
            button1.TabIndex = 0;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(dateTimePickerPurchaseDate);
            panel1.Controls.Add(textBoxSerialNumber);
            panel1.Controls.Add(textBoxModel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 351);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 145);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 8;
            label4.Text = "Дата покупки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 93);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 7;
            label3.Text = "Серийный номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 202);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 6;
            label2.Text = "Описание";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 37);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 5;
            label1.Text = "Наименование";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(341, 202);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(320, 123);
            textBoxDescription.TabIndex = 4;
            // 
            // dateTimePickerPurchaseDate
            // 
            dateTimePickerPurchaseDate.Location = new Point(343, 145);
            dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            dateTimePickerPurchaseDate.Size = new Size(319, 31);
            dateTimePickerPurchaseDate.TabIndex = 2;
            // 
            // textBoxSerialNumber
            // 
            textBoxSerialNumber.Location = new Point(342, 93);
            textBoxSerialNumber.Name = "textBoxSerialNumber";
            textBoxSerialNumber.Size = new Size(320, 31);
            textBoxSerialNumber.TabIndex = 1;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(342, 37);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(319, 31);
            textBoxModel.TabIndex = 0;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(485, 371);
            button2.Name = "button2";
            button2.Size = new Size(153, 58);
            button2.TabIndex = 2;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddEquipmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "AddEquipmentForm";
            Text = "Добавление нового обрудования/программного обеспечения";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private DateTimePicker dateTimePickerPurchaseDate;
        private TextBox textBoxSerialNumber;
        private TextBox textBoxModel;
        private TextBox textBoxDescription;
        private Button button2;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
    }
}