﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
	public class Square : Rectangle, IPrint
	{
		public Square(double side_size) : base(side_size, side_size)
		{
			this.Type = "Квадрат";
		}//конструктор, вызывающий конструтор класса Прямоугольник, но теперь
		 //он принимает длину прямоугольника как сторону квадрата и высоту прямоугольника как сторону квадрата, и передает в конструктор базового класса
		 //так как метод вычисления площади определен в родительском классе Прямоугольник, заново переопределять его не нужно
		 //он корректно выполнится аналогично как и в конструкторе, засчет передачи параметра длины одной стороны как длины и как ширины		}
	}
}