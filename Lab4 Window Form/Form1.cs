using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Lab4_Window_Form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		List<string> list = new List<string>();

		private void Button1_Click(object sender, EventArgs e)//кнопка чтения файла
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.Filter = "текстовые файлы|*.txt";//свойство Filter содержит список расширений файлов
			if (fd.ShowDialog() == DialogResult.OK)//ShowDialog производит открытие диалогового окна
			{
				Stopwatch DownloadTimer = new Stopwatch();//объявляется и запускается таймер загрузки файла
				Stopwatch SaveTimer = new Stopwatch();
				DownloadTimer.Start();
				SaveTimer.Start();
				string text = File.ReadAllText(fd.FileName);//содержимое файла считывается в виде переменной text типа string. Свойство fd.FileName возвращает путь и имя файла
				DownloadTimer.Stop();
				char[] razdelSimbols = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };//массив символов для разделения слов при чтении файла
				string[] textArray = text.Split(razdelSimbols);//массив слов файла, произведенный методом разделения Split на основе разделительных символов
				foreach (string strTemp in textArray)
				{
					string str = strTemp.Trim();//для корректной работы удаляем пробелы в начале и конце файла
					if (list.Contains(str) != true)//если строка не содержится в списке
						list.Add(str);//добавление строки в список
				}
				SaveTimer.Stop();
				this.textBox_download_time.Text = DownloadTimer.Elapsed.ToString();
				this.textBox_save_time.Text = SaveTimer.Elapsed.ToString();
			}
			else//если пользователь не выбрал текстовый файл
			{
				MessageBox.Show("Необходимо выбрать файл");
			}
		}

		private void Label2_Click(object sender, EventArgs e)//надпись времени сохранения
		{

		}

		private void Button2_Click(object sender, EventArgs e)//кнопка поиска слова
		{
			//Слово для поиска
			string word = this.textBox_word_for_finding.Text.Trim();

			//Если слово для поиска не пусто
			if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
			{
				//Слово для поиска в верхнем регистре
				string wordUpper = word.ToUpper();

				//Временные результаты поиска
				List<string> tempList = new List<string>();

				Stopwatch t = new Stopwatch();
				t.Start();

				foreach (string str in list)
				{
					if (str.ToUpper().Contains(wordUpper))
					{
						tempList.Add(str);
					}
				}

				t.Stop();
				this.textBox_Serch_time_label.Text = t.Elapsed.ToString();
				this.listBox_Finded_word.BeginUpdate();

				//Очистка списка
				this.listBox_Finded_word.Items.Clear();

				//Вывод результатов поиска 
				foreach (string str in tempList)
				{
					this.listBox_Finded_word.Items.Add(str);
				}
				this.listBox_Finded_word.EndUpdate();
			}
			else
			{
				MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
			}
		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)//список вывод слов
		{
			
		}

		private void Word_add_for_finding_label_Click(object sender, EventArgs e)//надпись поля ввода слова для поиска
		{
			
		}

		private void TextBox_word_for_finding_TextChanged(object sender, EventArgs e)//поле для ввода слова для поиска
		{

		}

		private void TextBox_download_time_TextChanged(object sender, EventArgs e)//вывод времени загрузки списка
		{

		}

		private void TextBox_save_time_TextChanged(object sender, EventArgs e)//вывод времени сохранения списка
		{

		}

		private void Download_time_label_Click(object sender, EventArgs e)//надпись о врмени загрузки
		{

		}

		private void Search_time_label_Click(object sender, EventArgs e)//надпись время поиска слова
		{

		}

		private void TextBox_time_label_TextChanged(object sender, EventArgs e)//поле для вывода времени поиска слова
		{

		}

		private void Close_button_Click(object sender, EventArgs e)//кнопка закрытия формы
		{
			this.Close();
		}
	}
}
