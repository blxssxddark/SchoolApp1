namespace SchoolApp1
{
    partial class RepairsForm
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            dataGridViewRepairs = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRepairs).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 112);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(247, 28);
            label1.TabIndex = 1;
            label1.Text = "История обслуживания";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(577, 28);
            button1.Name = "button1";
            button1.Size = new Size(198, 60);
            button1.TabIndex = 0;
            button1.Text = "Добавить событие";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewRepairs
            // 
            dataGridViewRepairs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRepairs.Dock = DockStyle.Bottom;
            dataGridViewRepairs.Location = new Point(0, 113);
            dataGridViewRepairs.Name = "dataGridViewRepairs";
            dataGridViewRepairs.RowHeadersWidth = 62;
            dataGridViewRepairs.Size = new Size(800, 414);
            dataGridViewRepairs.TabIndex = 1;
            dataGridViewRepairs.CellContentClick += dataGridViewRepairs_CellContentClick;
            // 
            // RepairsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 527);
            Controls.Add(dataGridViewRepairs);
            Controls.Add(panel1);
            Name = "RepairsForm";
            Text = "Ремонты и обслуживание";
            Load += RepairsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRepairs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewRepairs;
        private Button button1;
        private Label label1;
    }
}