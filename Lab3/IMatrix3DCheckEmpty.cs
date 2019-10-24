using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	public interface IMatrix3DCheckEmpty<T>
	{
		T returnEmptyElem();//возвращает пустой элемент
		bool checkEmptyElem(T element);//проверка, что элемент является пустым
	}
}
