using System;

namespace Lab2
{
	public interface IMatrix3DCheckEmpty<T>
	{
		T getEmptyElem();//возвращает пустой элемент
		bool checkEmptyElem(T element);//проверка, что элемент является пустым
	}
}
