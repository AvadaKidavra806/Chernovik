using System;

//Rabota.KvadratMassiv massiv = new Rabota.KvadratMassiv(); massiv.DmumerMassiv();
namespace Rabota
{
	public class KvadratMassiv
	{
		public void DmumerMassiv()
		{
			Console.WriteLine("Работа с квадратными массивами ");
			Console.Write("Введите номер задания: ");
			byte NomerZadaniy = 1; bool NomerZadaniyOut = true;
			while (NomerZadaniyOut)
			{
				if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
					Console.Write("Ошибка! Введите номер задания еще раз ");
				/*else if (NomerZadaniy <= 0 || NomerZadaniy > 6)
                    Console.Write("В дз всего 6 заданий, Введите номер задания еще раз ");*/
				else
					NomerZadaniyOut = false;

			}
			switch (NomerZadaniy)
			{
				case 1: n1(); break;
				case 2: n2(); break;
				case 3: n3(); break;
				case 4: n4(); break;
				case 5: n5(); break;
				case 6: n6(); break;
				case 7: n7(); break;
				case 8: n8(); break;
				case 9: n9(); break;
				case 10: n10(); break;
				default:
					Console.WriteLine("Пока что не готов этот номер");
					break;
			}
			void n1()
			{
				Console.Write("Введите разрядность квадратной матрицы: ");
				int Razryad = 0; bool OutRazryad = true;
				while (OutRazryad)
				{
					if (!int.TryParse(Console.ReadLine(), out Razryad))
						Console.Write("Ошибка! Введите разрядность квадратной матрицы еще раз ");
					else if (Razryad <= 0)
						Console.Write("Разрядность квадратной матрицы не может быть неположительным. Введите разряд квадратной матрицы еще раз ");
					else
						OutRazryad = false;
				}
				int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.Write($"Введите номер строки для нахождения элемента, находящегося на главной диагонали матрицы ");
				int NomerStroki = 0; bool OutNomerStroki = true;
				while (OutNomerStroki)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStroki))
						Console.Write("Ошибка! Введите номер строки еще раз ");
					else if (NomerStroki <= 0 || NomerStroki > Razryad)
						Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({Razryad}). Введите номер строки еще раз ");
					else
						OutNomerStroki = false;
				}
				Console.WriteLine($"Элемент, находящийся на пересечении главной диагонали матрицы и {NomerStroki}-ий строки: {massiv[NomerStroki - 1,   NomerStroki - 1]} ");
			}
			void n2()
			{
				Console.Write("Введите разрядность квадратной матрицы: ");
				int Razryad = 0; bool OutRazryad = true;
				while (OutRazryad)
				{
					if (!int.TryParse(Console.ReadLine(), out Razryad))
						Console.Write("Ошибка! Введите разрядность квадратной матрицы еще раз ");
					else if (Razryad <= 0)
						Console.Write("Разрядность квадратной матрицы не может быть неположительным. Введите разряд квадратной матрицы еще раз ");
					else
						OutRazryad = false;
				}
				int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.Write($"Введите номер столбца для нахождения элемента, находящегося на побочной диагонали матрицы ");
				int NomerStolb = 0; bool OutNomerStolb = true;
				while (OutNomerStolb)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStolb))
						Console.Write("Ошибка! Введите номер столбца еще раз ");
					else if (NomerStolb <= 0 || NomerStolb > Razryad)
						Console.Write($"Номер столбца не может быть неположительным и больше кол-ва столбцов в массиве ({Razryad}). Введите номер столбца еще раз ");
					else
						OutNomerStolb = false;
				}
				Console.WriteLine($"Элемент, находящийся на пересечении побочной диагонали матрицы и {NomerStolb}-ого столбца: {massiv[Razryad - NomerStolb, NomerStolb - 1]} ");
			}
			void n3()
			{
				Console.Write("Введите разрядность квадратной матрицы: ");
				int Razryad = 0; bool OutRazryad = true;
				while (OutRazryad)
				{
					if (!int.TryParse(Console.ReadLine(), out Razryad))
						Console.Write("Ошибка! Введите разрядность квадратной матрицы еще раз ");
					else if (Razryad <= 0)
						Console.Write("Разрядность квадратной матрицы не может быть неположительным. Введите разряд квадратной матрицы еще раз ");
					else
						OutRazryad = false;
				}
				int[,] massiv = new int[Razryad, Razryad];
				int[] glav = new int[Razryad];
				int[] poboch = new int[Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
						if (i == j)
							glav[i] = massiv[i, j];
						if (i + j == Razryad - 1)
							poboch[i] = massiv[i,j];
					}
					Console.WriteLine();
				}
				Array.Reverse(poboch);
				Console.WriteLine($"Элементы главной диагонали: {string.Join(", ", glav)}");
				Console.WriteLine($"Элементы побочной диагонали: {string.Join(", ", poboch)}");
			}
			void n4()
			{
				Console.Write("Введите разрядность квадратной матрицы: ");
				int Razryad = 0; bool OutRazryad = true;
				while (OutRazryad)
				{
					if (!int.TryParse(Console.ReadLine(), out Razryad))
						Console.Write("Ошибка! Введите разрядность квадратной матрицы еще раз ");
					else if (Razryad <= 0)
						Console.Write("Разрядность квадратной матрицы не может быть неположительным. Введите разряд квадратной матрицы еще раз ");
					else
						OutRazryad = false;
				}
				int[,] massiv = new int[Razryad, Razryad];
				int[] glav = new int[Razryad];
				int[] poboch = new int[Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
						if (i == j)
							glav[i] = massiv[i, j];
						if (i + j == Razryad - 1)
							poboch[i] = massiv[i, j];
					}
					Console.WriteLine();
				}
				Array.Reverse(glav);
				Console.WriteLine($"Элементы главной диагонали: {string.Join(", ", glav)}");
				Console.WriteLine($"Элементы побочной диагонали: {string.Join(", ", poboch)}");
			}
			void n5()
			{
				Console.Write("Введите разрядность квадратной матрицы: ");
				int Razryad = 0; bool OutRazryad = true;
				while (OutRazryad)
				{
					if (!int.TryParse(Console.ReadLine(), out Razryad))
						Console.Write("Ошибка! Введите разрядность квадратной матрицы еще раз ");
					else if (Razryad <= 0)
						Console.Write("Разрядность квадратной матрицы не может быть неположительным. Введите разряд квадратной матрицы еще раз ");
					else
						OutRazryad = false;
				}
				int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.Write($"Введите номер строки первого элемента для расчета суммы, находящегося на главной диагонали матрицы ");
				int NomerStroki = 0; bool OutNomerStroki = true;
				while (OutNomerStroki)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStroki))
						Console.Write("Ошибка! Введите номер строки еще раз ");
					else if (NomerStroki <= 0 || NomerStroki > Razryad)
						Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({Razryad}). Введите номер строки еще раз ");
					else
						OutNomerStroki = false;
				}
				Console.Write($"Введите номер строки второго элемента для расчета суммы, находящегося на главной диагонали матрицы ");
				int NomerStroki1 = 0; bool OutNomerStroki1 = true;
				while (OutNomerStroki1)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStroki1))
						Console.Write("Ошибка! Введите номер строки еще раз ");
					else if (NomerStroki1 <= 0 || NomerStroki1 > Razryad)
						Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({Razryad}). Введите номер строки еще раз ");
					else
						OutNomerStroki1 = false;
				}
				Console.WriteLine($"Сумма элементов, находящихся на пересечении главной диагонали и {NomerStroki}-й и {NomerStroki1}-й равна: {massiv[NomerStroki -1, NomerStroki -1] + massiv[NomerStroki1 - 1, NomerStroki1 - 1]}");
			}
			void n6()
			{
				Console.Write("Введите разрядность квадратной матрицы: ");
				int Razryad = 0; bool OutRazryad = true;
				while (OutRazryad)
				{
					if (!int.TryParse(Console.ReadLine(), out Razryad))
						Console.Write("Ошибка! Введите разрядность квадратной матрицы еще раз ");
					else if (Razryad <= 0)
						Console.Write("Разрядность квадратной матрицы не может быть неположительным. Введите разряд квадратной матрицы еще раз ");
					else
						OutRazryad = false;
				}
				int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.Write($"Введите номер строки первого элемента для расчета произведения, находящегося на побочной диагонали матрицы ");
				int NomerStroki = 0; bool OutNomerStroki = true;
				while (OutNomerStroki)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStroki))
						Console.Write("Ошибка! Введите номер строки еще раз ");
					else if (NomerStroki <= 0 || NomerStroki > Razryad)
						Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({Razryad}). Введите номер строки еще раз ");
					else
						OutNomerStroki = false;
				}
				Console.Write($"Введите номер строки второго элемента для расчета произведения, находящегося на побочной диагонали матрицы ");
				int NomerStroki1 = 0; bool OutNomerStroki1 = true;
				while (OutNomerStroki1)
				{
					if (!int.TryParse(Console.ReadLine(), out NomerStroki1))
						Console.Write("Ошибка! Введите номер строки еще раз ");
					else if (NomerStroki1 <= 0 || NomerStroki1 > Razryad)
						Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({Razryad}). Введите номер строки еще раз ");
					else
						OutNomerStroki1 = false;
				}
				Console.WriteLine($"Произведение элементов, находящихся на пересечении побочной диагонали и {NomerStroki}-й и {NomerStroki1}-й равна: {massiv[NomerStroki - 1, Razryad - NomerStroki] * massiv[NomerStroki1 - 1, Razryad - NomerStroki1]}");
			}
			void n7()
			{
				Console.Write("Введите разрядность квадратной матрицы: ");
				int Razryad = 0; bool OutRazryad = true;
				while (OutRazryad)
				{
					if (!int.TryParse(Console.ReadLine(), out Razryad))
						Console.Write("Ошибка! Введите разрядность квадратной матрицы еще раз ");
					else if (Razryad <= 0)
						Console.Write("Разрядность квадратной матрицы не может быть неположительным. Введите разряд квадратной матрицы еще раз ");
					else
						OutRazryad = false;
				}
				int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.WriteLine("Измененный двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						if (i == j)
						massiv[i, j] = 0;
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
			}
			void n8()
			{
				Console.Write("Введите разрядность квадратной матрицы: ");
				int Razryad = 0; bool OutRazryad = true;
				while (OutRazryad)
				{
					if (!int.TryParse(Console.ReadLine(), out Razryad))
						Console.Write("Ошибка! Введите разрядность квадратной матрицы еще раз ");
					else if (Razryad <= 0)
						Console.Write("Разрядность квадратной матрицы не может быть неположительным. Введите разряд квадратной матрицы еще раз ");
					else
						OutRazryad = false;
				}
				int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//=============================
				Console.WriteLine("Измененный двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						if (i + j == Razryad - 1)
							massiv[i, j] = 100;
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
			}
			void n9()
			{
				Console.Write("Введите разрядность квадратной матрицы: ");
				int Razryad = 0; bool OutRazryad = true;
				while (OutRazryad)
				{
					if (!int.TryParse(Console.ReadLine(), out Razryad))
						Console.Write("Ошибка! Введите разрядность квадратной матрицы еще раз ");
					else if (Razryad <= 0)
						Console.Write("Разрядность квадратной матрицы не может быть неположительным. Введите разряд квадратной матрицы еще раз ");
					else
						OutRazryad = false;
				}
				int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				int sumglav = 0;
				int sumpoboch = 0;
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
						if (i == j)
							sumglav += massiv[i, j];
						if (i + j == Razryad - 1)
							sumpoboch += massiv[i, j];
					}
					Console.WriteLine();
				}
				//=======================
				Console.WriteLine("a)Сумма элементов главной диагонали равна: " + sumglav);
				Console.WriteLine("б)Сумма элементов побочной диагонали равна: " + sumpoboch);
			
			}
			void n10()
			{
				Console.Write("Введите разрядность квадратной матрицы: ");
				int Razryad = 0; bool OutRazryad = true;
				while (OutRazryad)
				{
					if (!int.TryParse(Console.ReadLine(), out Razryad))
						Console.Write("Ошибка! Введите разрядность квадратной матрицы еще раз ");
					else if (Razryad <= 0)
						Console.Write("Разрядность квадратной матрицы не может быть неположительным. Введите разряд квадратной матрицы еще раз ");
					else
						OutRazryad = false;
				}
				int[,] massiv = new int[Razryad, Razryad];
				Random rnd = new Random();
				double sumglav = 0;
				double sumpoboch = 0;
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < Razryad; i++)
				{
					for (int j = 0; j < Razryad; j++)
					{
						massiv[i, j] = rnd.Next(-10, 10);
						Console.Write(massiv[i, j] + "\t");
						if (i == j)
							sumglav += massiv[i, j];
						if (i + j == Razryad - 1)
							sumpoboch += massiv[i, j];
					}
					Console.WriteLine();
				}
				//=======================
				Console.WriteLine("a)Среднее арифметическое элементов главной диагонали равна: " + sumglav / Razryad);
				Console.WriteLine("б)Среднее арифметическое элементов побочной диагонали равна: " + sumpoboch / Razryad);

			}
		}
	}
}