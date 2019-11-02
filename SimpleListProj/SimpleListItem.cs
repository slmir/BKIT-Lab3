using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleListProj
{
	public class SimpleListItem1<T>//класс - контейнер элемента списка
	{
		public T dataSave { get; set; }//свйоство - предназначено для хранения данных
		public SimpleListItem1<T> next { get; set; }//фактически - указатель на следующий элемент списка
		
		public SimpleListItem1(T param)//конструктор, передающий в свойство параметр data обобщенного типа T
		{
			this.dataSave = param;
		}
	}
}