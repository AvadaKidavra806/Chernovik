using System;

//Dvumerny_massiv_obrabotka.Ghf Ghf = new Dvumerny_massiv_obrabotka.Ghf(); Ghf.Edf();
namespace Dvumerny_massiv_obrabotka
{
	public class Ghf
	{
		public void Edf()
		{
			Console.WriteLine("Двумерный массив обработка");
			Console.Write("Введите номер задания: ");
			byte NomerZadaniy = 1; bool NomerZadaniyOut = true;
			while (NomerZadaniyOut)
			{
				if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
					Console.Write("Ошибка! Введите номер задания еще раз ");
				/*else if (NomerZadaniy <= 0 || NomerZadaniy > 21)
					Console.Write("В дз всего 21 заданий, Введите номер задания еще раз ");*/
				else
					NomerZadaniyOut = false;

			}
			switch (NomerZadaniy)
			{
                case 1:
                    n1();
                    break;
			}
			void n1 ()
			{
                Console.Write("Введите количество строк в массиве: ");
                int kolvostrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out kolvostrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (kolvostrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (kolvostrok < 5)
                        Console.Write("При таком кол-ве строк нельзя найти элемент пятой строки. Введите кол-во строк еще раз ");
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
                    else
                        outkolvostolb = false;
                }
                int[,] nums = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                //bool f = true;
                //int i, j;
                int[] massiv5 = new int[kolvostolb];
                for (int i = 0; i < kolvostrok; i++)
                {
                    bool d = true;
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        if (i == 4)
                        {
                            while (Array.FindAll(massiv5, f => f == 13).Length < 1)
                            {
                                j = 0;
                                while (j < kolvostolb)
                                {
                                    nums[i, j] = rnd.Next(100);
                                    massiv5[j] = nums[i, j];
                                    j++;
                                }
                            }
                            for (int i1 = 0; i1 < kolvostrok; i1++)
                            {
                                for (int j1 = 0; j1 < kolvostolb; j1++)
                                {
                                    Console.Write(nums[i1, j1] + "\t");
                                }
                            }
                        }
                        else
                        {
                            nums[i, j] = rnd.Next(100);
                            Console.Write(nums[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
                void help (int i , int j, out bool d)
                {
                    nums[i, j] = rnd.Next(100);
                    if (nums[i, j] != 13)
                        d = true;
                    else 
                        d = false;
                }
                //проверку на 13 написать позже
                //============================
                int j2 = 0;
                while (j2 < kolvostolb && nums[4, j2] != 13 )
                    j2++;
                Console.WriteLine("Номер столбца, в котором расположен самый левый элемент 13 в пятой строке: "+j2);
            }
            Console.Write("Для завершения программы нажмите Enter");
            Console.ReadLine();
        }
	}
}