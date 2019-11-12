namespace Lab4_Window_Form
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.File_reading_button = new System.Windows.Forms.Button();
			this.textBox_download_time = new System.Windows.Forms.TextBox();
			this.textBox_save_time = new System.Windows.Forms.TextBox();
			this.Download_time_label = new System.Windows.Forms.Label();
			this.Save_time_label = new System.Windows.Forms.Label();
			this.textBox_word_for_finding = new System.Windows.Forms.TextBox();
			this.Word_add_for_finding_label = new System.Windows.Forms.Label();
			this.Word_find_button = new System.Windows.Forms.Button();
			this.listBox_Finded_word = new System.Windows.Forms.ListBox();
			this.Search_time_label = new System.Windows.Forms.Label();
			this.textBox_Serch_time_label = new System.Windows.Forms.TextBox();
			this.Close_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// File_reading_button
			// 
			this.File_reading_button.Location = new System.Drawing.Point(13, 13);
			this.File_reading_button.Name = "File_reading_button";
			this.File_reading_button.Size = new System.Drawing.Size(195, 53);
			this.File_reading_button.TabIndex = 0;
			this.File_reading_button.Text = "Чтение файла";
			this.File_reading_button.UseVisualStyleBackColor = true;
			this.File_reading_button.Click += new System.EventHandler(this.Button1_Click);
			// 
			// textBox_download_time
			// 
			this.textBox_download_time.Location = new System.Drawing.Point(544, 12);
			this.textBox_download_time.Name = "textBox_download_time";
			this.textBox_download_time.Size = new System.Drawing.Size(244, 20);
			this.textBox_download_time.TabIndex = 1;
			this.textBox_download_time.TextChanged += new System.EventHandler(this.TextBox_download_time_TextChanged);
			// 
			// textBox_save_time
			// 
			this.textBox_save_time.Location = new System.Drawing.Point(544, 45);
			this.textBox_save_time.Name = "textBox_save_time";
			this.textBox_save_time.Size = new System.Drawing.Size(244, 20);
			this.textBox_save_time.TabIndex = 2;
			this.textBox_save_time.TextChanged += new System.EventHandler(this.TextBox_save_time_TextChanged);
			// 
			// Download_time_label
			// 
			this.Download_time_label.AutoSize = true;
			this.Download_time_label.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Download_time_label.Location = new System.Drawing.Point(304, 13);
			this.Download_time_label.Name = "Download_time_label";
			this.Download_time_label.Size = new System.Drawing.Size(137, 13);
			this.Download_time_label.TabIndex = 3;
			this.Download_time_label.Text = "Время загрузки в список";
			this.Download_time_label.Click += new System.EventHandler(this.Download_time_label_Click);
			// 
			// Save_time_label
			// 
			this.Save_time_label.AutoSize = true;
			this.Save_time_label.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Save_time_label.Location = new System.Drawing.Point(304, 48);
			this.Save_time_label.Name = "Save_time_label";
			this.Save_time_label.Size = new System.Drawing.Size(150, 13);
			this.Save_time_label.TabIndex = 4;
			this.Save_time_label.Text = "Время сохранения в список";
			this.Save_time_label.Click += new System.EventHandler(this.Label2_Click);
			// 
			// textBox_word_for_finding
			// 
			this.textBox_word_for_finding.Location = new System.Drawing.Point(13, 126);
			this.textBox_word_for_finding.Name = "textBox_word_for_finding";
			this.textBox_word_for_finding.Size = new System.Drawing.Size(195, 20);
			this.textBox_word_for_finding.TabIndex = 5;
			this.textBox_word_for_finding.TextChanged += new System.EventHandler(this.TextBox_word_for_finding_TextChanged);
			// 
			// Word_add_for_finding_label
			// 
			this.Word_add_for_finding_label.AutoSize = true;
			this.Word_add_for_finding_label.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Word_add_for_finding_label.Location = new System.Drawing.Point(13, 107);
			this.Word_add_for_finding_label.Name = "Word_add_for_finding_label";
			this.Word_add_for_finding_label.Size = new System.Drawing.Size(159, 13);
			this.Word_add_for_finding_label.TabIndex = 6;
			this.Word_add_for_finding_label.Text = "Поле ввода для поиска слова";
			this.Word_add_for_finding_label.Click += new System.EventHandler(this.Word_add_for_finding_label_Click);
			// 
			// Word_find_button
			// 
			this.Word_find_button.Location = new System.Drawing.Point(307, 107);
			this.Word_find_button.Name = "Word_find_button";
			this.Word_find_button.Size = new System.Drawing.Size(103, 39);
			this.Word_find_button.TabIndex = 7;
			this.Word_find_button.Text = "Поиск слова";
			this.Word_find_button.UseVisualStyleBackColor = true;
			this.Word_find_button.Click += new System.EventHandler(this.Button2_Click);
			// 
			// listBox_Finded_word
			// 
			this.listBox_Finded_word.FormattingEnabled = true;
			this.listBox_Finded_word.Location = new System.Drawing.Point(544, 107);
			this.listBox_Finded_word.Name = "listBox_Finded_word";
			this.listBox_Finded_word.Size = new System.Drawing.Size(244, 95);
			this.listBox_Finded_word.TabIndex = 8;
			this.listBox_Finded_word.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
			// 
			// Search_time_label
			// 
			this.Search_time_label.AutoSize = true;
			this.Search_time_label.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Search_time_label.Location = new System.Drawing.Point(10, 189);
			this.Search_time_label.Name = "Search_time_label";
			this.Search_time_label.Size = new System.Drawing.Size(79, 13);
			this.Search_time_label.TabIndex = 9;
			this.Search_time_label.Text = "Время поиска";
			this.Search_time_label.Click += new System.EventHandler(this.Search_time_label_Click);
			// 
			// textBox_Serch_time_label
			// 
			this.textBox_Serch_time_label.Location = new System.Drawing.Point(96, 189);
			this.textBox_Serch_time_label.Name = "textBox_Serch_time_label";
			this.textBox_Serch_time_label.Size = new System.Drawing.Size(100, 20);
			this.textBox_Serch_time_label.TabIndex = 10;
			this.textBox_Serch_time_label.TextChanged += new System.EventHandler(this.TextBox_time_label_TextChanged);
			// 
			// Close_button
			// 
			this.Close_button.Location = new System.Drawing.Point(544, 397);
			this.Close_button.Name = "Close_button";
			this.Close_button.Size = new System.Drawing.Size(244, 41);
			this.Close_button.TabIndex = 11;
			this.Close_button.Text = "Закрыть форму";
			this.Close_button.UseVisualStyleBackColor = true;
			this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Close_button);
			this.Controls.Add(this.textBox_Serch_time_label);
			this.Controls.Add(this.Search_time_label);
			this.Controls.Add(this.listBox_Finded_word);
			this.Controls.Add(this.Word_find_button);
			this.Controls.Add(this.Word_add_for_finding_label);
			this.Controls.Add(this.textBox_word_for_finding);
			this.Controls.Add(this.Save_time_label);
			this.Controls.Add(this.Download_time_label);
			this.Controls.Add(this.textBox_save_time);
			this.Controls.Add(this.textBox_download_time);
			this.Controls.Add(this.File_reading_button);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button File_reading_button;
		private System.Windows.Forms.TextBox textBox_download_time;
		private System.Windows.Forms.TextBox textBox_save_time;
		private System.Windows.Forms.Label Download_time_label;
		private System.Windows.Forms.Label Save_time_label;
		private System.Windows.Forms.TextBox textBox_word_for_finding;
		private System.Windows.Forms.Label Word_add_for_finding_label;
		private System.Windows.Forms.Button Word_find_button;
		private System.Windows.Forms.ListBox listBox_Finded_word;
		private System.Windows.Forms.Label Search_time_label;
		private System.Windows.Forms.TextBox textBox_Serch_time_label;
		private System.Windows.Forms.Button Close_button;
	}
}

