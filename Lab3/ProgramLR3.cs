using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace Lab3
{
	class ProgramLR3
	{
		static void Main(string[] args)
		{
			Console.Title = "Мирсонов Вячеслав РТ5-31Б";
			Rectangle rect = new Rectangle(10, 12);
			Square square = new Square(15);
			Circle circle = new Circle(10);

			/*Необощенный список*/
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nКоллекция класса ArrayList");
			Console.ForegroundColor = ConsoleColor.Gray;
			ArrayList AL = new ArrayList();
			AL.Add(circle);
			AL.Add(rect);
			AL.Add(square);
			Console.WriteLine("Перед сортировкой:");
			foreach (object o in AL)
			{
				string type = o.GetType().Name;
				Console.WriteLine(o.ToString());
			}

			Console.WriteLine("\nПосле сортировки:");
			AL.Sort();
			foreach (object o in AL)
			{
				string type = o.GetType().Name;
				Console.WriteLine(o.ToString());
			}

			/*Коллекция класса Figure*/
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nКоллекция класса List<Figure>");
			Console.ForegroundColor = ConsoleColor.Gray;
			List<Figure> LF = new List<Figure>();
			LF.Add(circle);
			LF.Add(rect);
			LF.Add(square);
			Console.WriteLine("Перед сортировкой:");
			foreach (var x in LF)
				Console.WriteLine(x);

			Console.WriteLine("\nПосле сортировки:");
			LF.Sort();
			foreach (var x in LF)
				Console.WriteLine(x);

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nМатрица");
			Console.ForegroundColor = ConsoleColor.Gray;
			Matrix3D<Figure> cube = new Matrix3D<Figure>(3, 3, 3, null);
			cube[0, 0, 0] = rect;
			cube[1, 1, 1] = square;
			cube[2, 2, 2] = circle;
			Console.WriteLine(cube.ToString());
			
			
			/*Console.WriteLine("\nМатрица");
			Matrix<Figure> matrix = new Matrix<Figure>(3, 3, new FigureMatrixCheckEmpty());
			matrix[0, 0] = rect;
			matrix[1, 1] = square;
			matrix[2, 2] = circle;
			Console.WriteLine(matrix.ToString());
			
			/*Console.WriteLine("\nСтек");
			SimpleStack<Figure> stack = new SimpleStack<Figure>();
			stack.Push(rect);
			stack.Push(square);
			stack.Push(circle);

			while (stack.Count > 0)
			{
				Figure f = stack.Pop();
				Console.WriteLine(f);
			}
			*/
			Console.ReadLine();
		}
	}
}