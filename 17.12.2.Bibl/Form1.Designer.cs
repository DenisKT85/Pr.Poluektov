namespace _17._12._2.Bibl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			this.label1 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.Дата = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Транспортная компания";
			// 
			// listView1
			// 
			this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listView1.AllowColumnReorder = true;
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Дата,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader2,
            this.columnHeader3});
			this.listView1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.listView1.GridLines = true;
			this.listView1.HoverSelection = true;
			this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			listViewItem1.Checked = true;
			listViewItem1.StateImageIndex = 1;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.listView1.Location = new System.Drawing.Point(12, 105);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(840, 258);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "№п/п";
			this.columnHeader1.Width = 50;
			// 
			// Дата
			// 
			this.Дата.Text = "Дата";
			this.Дата.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Дата.Width = 80;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Перевозчик";
			this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader11.Width = 90;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Груз";
			this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader12.Width = 80;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Клиент";
			this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader13.Width = 80;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Водитель";
			this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader14.Width = 80;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Транспорт";
			this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader15.Width = 80;
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "Цена клиента";
			this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader16.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Цена перевозчика";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Прибыль";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 80;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Список перевозок:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(12, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 45);
			this.button1.TabIndex = 3;
			this.button1.Text = "Новая перевозка";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Coral;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button2.Location = new System.Drawing.Point(204, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(157, 22);
			this.button2.TabIndex = 4;
			this.button2.Text = "Показать все";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(403, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 21);
			this.label4.TabIndex = 6;
			this.label4.Text = "Прибыль:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(208, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Выбрать период:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(223, 68);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(124, 23);
			this.dateTimePicker1.TabIndex = 8;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(383, 68);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(126, 23);
			this.dateTimePicker2.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(204, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "c:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(353, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "по:";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(543, 68);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(125, 22);
			this.button3.TabIndex = 12;
			this.button3.Text = "Показать";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(381, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(468, 35);
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 375);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 22);
			this.button4.TabIndex = 14;
			this.button4.Text = "Редактировать";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(777, 375);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 15;
			this.button5.Text = "Удалить";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 410);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Главная";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Label label2;
        private Button button1;
		private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button2;
        private ColumnHeader Дата;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Label label6;
        private Button button3;
        private PictureBox pictureBox1;
		private Button button4;
		private Button button5;
	}
}