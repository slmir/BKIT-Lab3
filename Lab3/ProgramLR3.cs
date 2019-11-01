using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;
using SimpleListProj;

namespace Lab3
{
	class ProgramLR3
	{
		static void Main(string[] args)
		{
			Console.Title = "Мирсонов Вячеслав РТ5-31Б";
			Rectangle rect = new Rectangle(10, 5);//объект класса Прямоугольник со сторонами 10 и 12
			Square square = new Square(30);//объект класса Квадрат со стороной 15
			Circle circle = new Circle(10);//объект класса Окружность с радиусом 10

			/*Необощенный список*/
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nКоллекция класса ArrayList");
			Console.ResetColor();
			ArrayList AL = new ArrayList();//создане необобщенного списка
			/*добавление в необобщенный список рассматриваемых элементов*/
			AL.Add(circle);
			AL.Add(square);
			AL.Add(rect);
			/*вывод элементов необобщенного списка перед сортировкой*/
			Console.WriteLine("Перед сортировкой:");
			foreach (object o in AL)
				Console.WriteLine(o.ToString());
			AL.Sort();//сортировка
			/*вывод после сортировки*/
			Console.WriteLine("\nПосле сортировки:");
			foreach (object o in AL)
				Console.WriteLine(o.ToString());

			/*Коллекция класса Figure*/
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nКоллекция класса List<Figure>");
			Console.ResetColor();
			List<Figure> LF = new List<Figure>();// создане списка (коллекции класса Figure)
			/*добавление в список рассматриваемых элементов*/
			LF.Add(circle);
			LF.Add(square);
			LF.Add(rect);
			/*вывод элементов списка перед сортировкой*/
			Console.WriteLine("Перед сортировкой:");
			foreach (var x in LF)
				Console.WriteLine(x);
			LF.Sort();//сортировка
			/*вывод после сортировки*/
			Console.WriteLine("\nПосле сортировки:");
			foreach (var x in LF)
				Console.WriteLine(x);


			/*Односвязный список ListFigures*/
			SimpleList<Figure> OneCommunicationListFigures = new SimpleList<Figure>();//создание односвязного списка
			/*добавление элементов в односвязный список*/
			OneCommunicationListFigures.Add(square);
			OneCommunicationListFigures.Add(circle);
			OneCommunicationListFigures.Add(rect);
			OneCommunicationListFigures.Sort();//сортировка


			/*Трехмерная разреженная матрица*/
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nТрехмерная разреженная матрица");
			Console.ResetColor();
			Matrix3D<Figure> cube = new Matrix3D<Figure>(3, 3, 3, null);//создание трехмерной разреженной матрицы 3х3х3 с передачей в качестве нулевого элемента - null
			cube[0, 0, 0] = OneCommunicationListFigures.Get(0);
			cube[1, 1, 1] = OneCommunicationListFigures.Get(1);
			cube[2, 2, 2] = OneCommunicationListFigures.Get(2);
			Console.WriteLine(cube.ToString());

			/*Реализация стека*/
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nСтек");
			Console.ResetColor();
			SimpleStack<Figure> stack = new SimpleStack<Figure>();//создание стека
			/*доабвление отсортированных элементов списка OneCommunicationListFigures в стек по прицнипу LIFO*/
			stack.Push(OneCommunicationListFigures.Get(0));
			stack.Push(OneCommunicationListFigures.Get(1));
			stack.Push(OneCommunicationListFigures.Get(2));

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Реализация метода Pop() на основе стека,составленного на основе Push(elem)");
			Console.ResetColor();
			while (stack.Count > 0)//чтение из данных (элемента) с удалением из стека
			{
				Figure figur = stack.Pop();
				Console.WriteLine(figur);
			}

			Console.ReadLine();
		}
	}
}