using System;
namespace Lab2
{
	/// <summary>
	/// Проверка пустого элемента матрицы
	/// </summary>
	public interface IMatrixCheckEmpty<T>
	{
		/// <summary>
		/// Возвращает пустой элемент
		/// </summary>
		T getEmptyElem();
		/// <summary>
		/// Проверка что элемент является пустым
		/// </summary>
		bool checkEmptyElem(T element);
	}
}