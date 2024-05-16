namespace SchoolApp1
{
    partial class EditEquipmentForm
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
            dateTimePickerPurchaseDate = new DateTimePicker();
            textBoxSerialNumber = new TextBox();
            textBoxModel = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 147);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 16;
            label4.Text = "Дата покупки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 95);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 15;
            label3.Text = "Серийный номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 204);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 14;
            label2.Text = "Описание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 39);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 13;
            label1.Text = "Наименование";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(339, 204);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(320, 123);
            textBoxDescription.TabIndex = 12;
            // 
            // dateTimePickerPurchaseDate
            // 
            dateTimePickerPurchaseDate.Location = new Point(341, 147);
            dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            dateTimePickerPurchaseDate.Size = new Size(319, 31);
            dateTimePickerPurchaseDate.TabIndex = 11;
            // 
            // textBoxSerialNumber
            // 
            textBoxSerialNumber.Location = new Point(340, 95);
            textBoxSerialNumber.Name = "textBoxSerialNumber";
            textBoxSerialNumber.Size = new Size(320, 31);
            textBoxSerialNumber.TabIndex = 10;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(340, 39);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(319, 31);
            textBoxModel.TabIndex = 9;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(282, 356);
            button1.Name = "button1";
            button1.Size = new Size(148, 54);
            button1.TabIndex = 17;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(506, 356);
            button2.Name = "button2";
            button2.Size = new Size(153, 53);
            button2.TabIndex = 18;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // EditEquipmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDescription);
            Controls.Add(dateTimePickerPurchaseDate);
            Controls.Add(textBoxSerialNumber);
            Controls.Add(textBoxModel);
            Name = "EditEquipmentForm";
            Text = "EditEquipmentForm";
            Load += EditEquipmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxDescription;
        private DateTimePicker dateTimePickerPurchaseDate;
        private TextBox textBoxSerialNumber;
        private TextBox textBoxModel;
        private Button button1;
        private Button button2;
    }
}