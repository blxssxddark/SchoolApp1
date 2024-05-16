namespace SchoolApp1
{
    partial class Form2
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
            dataGridViewEquipment = new DataGridView();
            textBoxSearch = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipment).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewEquipment
            // 
            dataGridViewEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEquipment.Dock = DockStyle.Bottom;
            dataGridViewEquipment.Location = new Point(0, 187);
            dataGridViewEquipment.Name = "dataGridViewEquipment";
            dataGridViewEquipment.RowHeadersWidth = 62;
            dataGridViewEquipment.Size = new Size(800, 263);
            dataGridViewEquipment.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(387, 21);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(178, 31);
            textBoxSearch.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.Location = new Point(597, 14);
            button1.Name = "button1";
            button1.Size = new Size(174, 43);
            button1.TabIndex = 2;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 181);
            panel1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button4.Location = new Point(223, 73);
            button4.Name = "button4";
            button4.Size = new Size(174, 45);
            button4.TabIndex = 7;
            button4.Text = "Редактировать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.Location = new Point(422, 73);
            button3.Name = "button3";
            button3.Size = new Size(174, 45);
            button3.TabIndex = 6;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.Location = new Point(23, 73);
            button2.Name = "button2";
            button2.Size = new Size(174, 45);
            button2.TabIndex = 5;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(346, 25);
            label1.TabIndex = 3;
            label1.Text = "Поиск по наименованию оборудования";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(23, 135);
            label2.Name = "label2";
            label2.Size = new Size(252, 30);
            label2.TabIndex = 8;
            label2.Text = "Список оборудования";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridViewEquipment);
            Name = "Form2";
            Text = "Просмотр и управление списком компьютерного оборудования и программного обеспечения в школе";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipment).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEquipment;
        private TextBox textBoxSearch;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Label label2;
    }
}