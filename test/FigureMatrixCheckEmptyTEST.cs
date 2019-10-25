using System;
namespace Lab2
{
	public class FigureMatrixCheckEmpty : IMatrixCheckEmpty<Figure>
	{
		/// <summary>
		/// В качестве пустого элемента возвращается null
		/// </summary>
		public Figure getEmptyElem()
		{
			return null;
		}
		/// <summary>
		/// Проверка что переданный параметр равен null
		/// </summary>
		public bool checkEmptyElem(Figure element)
		{
			bool Result = false;
			if (element == null)
			{
				Result = true;
			}
			return Result;
		}
	}
}