using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
	public class Matrix3D<T>
	{
		/*Основная структура данных для хранения разреженной матрицы - словарь _matrix*/
		Dictionary<string, T> _matrix = new Dictionary<string, T>();//словарь для хранения значений
		int maxST_X;//количество элементов трехмерной матрицы по горизонтали (максимальное количество столбцов)
		int maxSTR_Y;// количество элементов трехмерной матрицы по вертикали (максимальное количество строк)
		int maxGL_Z;//количество элементов трехмерной матрицы в глубину
		IMatrix3DCheckEmpty<T> nullElemCheck;//пустой элемент, который возвращается если элемент с нужными координатами не был задан
		public Matrix3D(int px, int py,int pz, IMatrix3DCheckEmpty<T> nullElemParam)//конструктор
		{
			this.maxST_X = px;
			this.maxSTR_Y = py;
			this.maxGL_Z = pz;
			this.nullElemCheck = nullElemParam;
		}
		public T this[int x, int y, int z]//индексатор доступа к данным
		{
			set
			{
				CheckBounds(x, y, z);//метод проверки границ
				string key = DictKey(x, y, z);//метод формирования ключа
				this._matrix.Add(key, value);//добавление в матрицу значения по ключу (x,y)
			}
			get
			{
				CheckBounds(x, y, z);
				string key = DictKey(x, y, z);
				if (this._matrix.ContainsKey(key))
				{
					return this._matrix[key];
				}
				else
				{
					return this.nullElemCheck.returnEmptyElem();
				}
			}
	
		}
		void CheckBounds(int x, int y, int z)//проверка границ
		{
			if (x < 0 || x >= this.maxST_X)
				throw new Exception("x=" + x + " выходит за границы");
			if (y < 0 || y >= this.maxSTR_Y)
				throw new Exception("y=" + y + " выходит за границы");
			if (z < 0 || z >= this.maxGL_Z)
				throw new Exception("z=" + z + " выходит за границы");
		}
		string DictKey(int x, int y, int z)//формирование ключа
		{
			return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
		}
		public override string ToString()
		{
			StringBuilder LongStr = new StringBuilder();//для построения длинных строк
			for (int k = 0; k < this.maxGL_Z; k++)
			{
				for (int j = 0; j < this.maxSTR_Y; j++)
				{
					LongStr.Append("[");
					for (int i = 0; i < this.maxST_X; i++)
					{
						if (i > 0)
						{
							LongStr.Append("\t");
						}
						if (!this.nullElemCheck.checkEmptyElem(this[i, j, k]))
						{
							//Добавить приведенный к строке текущий элемент
							LongStr.Append(this[i, j, k].ToString());
						}
						else
						{
							//Иначе добавить признак пустого значения
							LongStr.Append(" - ");
						}
					}
				}
				LongStr.Append("]\n");
			}
			return LongStr.ToString();
		}
	}
}
