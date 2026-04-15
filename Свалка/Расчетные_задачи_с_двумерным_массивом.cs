using System;

//
namespace Raschet
{
	public class Zadachi
	{
		public void DvuMassiv()
		{
			Console.WriteLine("Расчетные задачи с двумерными массивами ");
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
				default:
					Console.WriteLine("Пока что не готов этот номер");
					break;
			}
			void n1()
			{
				Console.Write("Введите количество строк в массиве: ");
				int kolvostrok = 0; bool outkolvostrok = true;
				while (outkolvostrok)
				{
					if (!int.TryParse(Console.ReadLine(), out kolvostrok))
						Console.Write("Ошибка! Введите кол-во строк еще раз ");
					else if (kolvostrok <= 0)
						Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
					else if (kolvostrok < 3)
						Console.Write("При таком кол-ве строк нельзя найти сумму элементов третьей строки. Введите кол-во строк еще раз ");
					else
						outkolvostrok = false;
				}
				Console.Write("Введите количество столбцов в массиве: ");
				int kolvostolb = 0; bool outkolvostolb = true;
				while (outkolvostolb)
				{
					if (!int.TryParse(Console.ReadLine(), out kolvostolb))
						Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
					else if (kolvostolb <= 0)
						Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");/*
					else if (kolvostolb < 3)
						Console.Write("При таком кол-ве столбцов нельзя найти макс элемент третьего столбца. Введите кол-во столбцов еще раз ");*/
					else
						outkolvostolb = false;
				}
				int[,] massiv = new int[kolvostrok, kolvostolb];
				Random rnd = new Random();
				int sum3 = 0;
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < kolvostrok; i++)
				{
					for (int j = 0; j < kolvostolb; j++)
					{
						massiv[i, j] = rnd.Next(100);
						Console.Write(massiv[i, j] + "\t");
						if (i == 2)
						{
							sum3 += massiv[i, j];
						}
					}
					Console.WriteLine();
				}
				//=============================
				Console.WriteLine($"а) Сумма элементов третьей строки равна: {sum3}");
				//=============================
				Console.Write("Введите s-ий столбец: ");
				int s = 0; bool Outs = true;
				while (Outs)
				{
					if (!int.TryParse(Console.ReadLine(), out s))
						Console.Write("Ошибка! Введите s-ий столбец еще раз ");
					else if (s <= 0 || s > kolvostolb)
						Console.Write("Ошибка! s-ий столбец должен быть положительным и меньше количества столбцов. Введите s-ий столбец ещё раз ");
					else
						Outs = false;
				}
				int sums = 0;
				for (int i = 0; i < kolvostrok; i++)
				{
					sums += massiv[i, s - 1];
				}
				Console.WriteLine($"б) Сумма {s}-ого столбца равна: {sums}");
			}
			void n2()
			{
				Console.Write("Введите количество строк в массиве: ");
				int kolvostrok = 0; bool outkolvostrok = true;
				while (outkolvostrok)
				{
					if (!int.TryParse(Console.ReadLine(), out kolvostrok))
						Console.Write("Ошибка! Введите кол-во строк еще раз ");
					else if (kolvostrok <= 0)
						Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");/*
					else if (kolvostrok < 3)
						Console.Write("При таком кол-ве строк нельзя найти сумму элементов третьей строки. Введите кол-во строк еще раз ");*/
					else
						outkolvostrok = false;
				}
				Console.Write("Введите количество столбцов в массиве: ");
				int kolvostolb = 0; bool outkolvostolb = true;
				while (outkolvostolb)
				{
					if (!int.TryParse(Console.ReadLine(), out kolvostolb))
						Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
					else if (kolvostolb <= 0)
						Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
					else if (kolvostolb < 2)
						Console.Write("При таком кол-ве столбцов нельзя найти сумму элементов второго столбца. Введите кол-во столбцов еще раз ");
					else
						outkolvostolb = false;
				}
				int[,] massiv = new int[kolvostrok, kolvostolb];
				Random rnd = new Random();
				int sum2 = 0;
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < kolvostrok; i++)
				{
					for (int j = 0; j < kolvostolb; j++)
					{
						massiv[i, j] = rnd.Next(100);
						Console.Write(massiv[i, j] + "\t");
						if (j == 1)
						{
							sum2 += massiv[i, j];
						}
					}
					Console.WriteLine();
				}
				//=============================
				Console.WriteLine($"а) Сумма элементов второго столбца равна: {sum2}");
				//=============================
				Console.Write("Введите k-ую строку: ");
				int k = 0; bool Outk = true;
				while (Outk)
				{
					if (!int.TryParse(Console.ReadLine(), out k))
						Console.Write("Ошибка! Введите k-ую строку еще раз ");
					else if (k <= 0 || k > kolvostrok)
						Console.Write("Ошибка! k-ая строка должна быть положительной и меньше количества строк. Введите k-ую строку ещё раз ");
					else
						Outk = false;
				}
				int sumk = 0;
				for (int i = 0; i < kolvostolb; i++)
				{
					sumk += massiv[ k - 1, i];
				}
				Console.WriteLine($"б) Сумма {k}-ой строки равна: {sumk}");
			}
			void n3()
			{
				const int kolvostrok = 11;
				const int kolvostolb = 4;
				int[,] massiv = new int[kolvostrok, kolvostolb];
				Random rnd = new Random();
				int sum2 = 0;
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < kolvostrok; i++)
				{
					for (int j = 0; j < kolvostolb; j++)
					{
						massiv[i, j] = rnd.Next(25, 32);
						Console.Write(massiv[i, j] + "\t");
						if (i == 4)
						{
							sum2 += massiv[i, j];
						}
					}
					Console.WriteLine();
				}
				Console.WriteLine($"Общее число учеников в параллели 5-х классов равна: {sum2}");
				
			}
			void n4()
			{
				const int kolvostrok = 20;
				const int kolvostolb = 5;
				int[,] massiv = new int[kolvostrok, kolvostolb];
				Random rnd = new Random();
				int sum2 = 0;
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < kolvostrok; i++)
				{
					for (int j = 0; j < kolvostolb; j++)
					{
						massiv[i, j] = rnd.Next(0, 50);
						Console.Write(massiv[i, j] + "\t");
						if (i == 2)
						{
							sum2 += massiv[i, j];
						}
					}
					Console.WriteLine();
				}
				Console.WriteLine($"Общее количество баллов третьего спортсмена равно: {sum2}");

			}
			void n5()
			{
				const int kolvostrok = 25;
				const int kolvostolb = 36;
				int[,] massiv = new int[kolvostrok, kolvostolb];
				Random rnd = new Random();
				int sum2 = 0;
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < kolvostrok; i++)
				{
					for (int j = 0; j < kolvostolb; j++)
					{
						massiv[i, j] = rnd.Next(0, 2);
						Console.Write(massiv[i, j] + " ");
						if (i == 11)
						{
							sum2 += massiv[i, j];
						}
					}
					Console.WriteLine();
				}
				Console.WriteLine($"Общее количество проданных билетов в 12-ом ряду: {sum2}");

			}
			void n6()
			{
				const int kolvostrok = 5;
				const int kolvostolb = 8;
				int[,] massiv = new int[kolvostrok, kolvostolb];
				Random rnd = new Random();
				int sum2 = 0;
				Console.WriteLine("Двумерный массив: ");
				for (int i = 0; i < kolvostrok; i++)
				{
					for (int j = 0; j < kolvostolb; j++)
					{
						massiv[i, j] = rnd.Next(24, 26);
						Console.Write(massiv[i, j] + "\t");
					}
					Console.WriteLine();
				}
				//========================
				Console.Write("Введите номер курса: ");
				int s = 0; bool outs = true;
				while (outs)
				{
					if (!int.TryParse(Console.ReadLine(), out s))
						Console.Write("Ошибка! Введите номер курса еще раз ");
					else if (s <= 0)
						Console.Write("Номер курса не может быть неположительным. Введите номер курса еще раз ");
					else if (s > kolvostrok)
						Console.Write($"Номер курса не может быть больше {kolvostrok}. Введите номер курса еще раз ");
					else
						outs = false;
				}
				for (int i = 0; i < kolvostolb; i++)
				{
					sum2 += massiv[s - 1, i];
				}
				Console.WriteLine($"Общее количество студентов на {s}-ом курсе: {sum2}");

			}
		}
	}
}