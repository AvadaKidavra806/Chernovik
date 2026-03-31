using System;

//с 1 по 6 1-5 перебором, 6 одномерным массивом
namespace DvumerMasMaxMin
{
    public class Reshenie
    {
        public void Nomerov()
        {
            Console.WriteLine("Двумерный массив макс и мин ");
            Console.Write("Введите номер задания: ");
            byte NomerZadaniy = 1; bool NomerZadaniyOut = true;
            while (NomerZadaniyOut)
            {
                if (!byte.TryParse(Console.ReadLine(), out NomerZadaniy) || NomerZadaniy <= 0)
                    Console.Write("Ошибка! Введите номер задания еще раз ");
                /*else if (NomerZadaniy <= 0 || NomerZadaniy > 5)
                    Console.Write("В дз всего 5 заданий, Введите номер задания еще раз ");*/
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
                    else if (kolvostrok < 2)
                        Console.Write("При таком кол-ве строк нельзя найти мин элемент второй строки. Введите кол-во строк еще раз ");
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
                    else if (kolvostolb < 3)
                        Console.Write("При таком кол-ве столбцов нельзя найти макс элемент третьего столбца. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        massiv[i, j] = rnd.Next(100);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //=============================
                int h = 1;
                int max3 = massiv[0, 2];
                while (h < kolvostrok)
                {
                    if (massiv[h, 2] > max3)
                        max3 = massiv[h, 2];
                    h++;
                }
                Console.WriteLine("a) Макс элемент 3-его столбца: " + max3);
                //===================
                h = 1;
                int min2 = massiv[1, 0];
                while (h < kolvostolb)
                {
                    if (massiv[1, h] < min2)
                        min2 = massiv[1, h];
                    h++;
                }
                Console.WriteLine("б) Мин элемент 2-й строки: " + min2);
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
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (kolvostrok < 5)
                        Console.Write("При таком кол-ве строк нельзя найти макс элемент пятой строки. Введите кол-во строк еще раз ");
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
                    else if (kolvostolb < 4)
                        Console.Write("При таком кол-ве столбцов нельзя найти мин элемент четвертого столбца. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        massiv[i, j] = rnd.Next(100);
                        Console.Write(massiv[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                //=============================
                int h = 1;
                int min5 = massiv[0, 2];
                while (h < kolvostrok)
                {
                    if (massiv[h, 2] < min5)
                        min5 = massiv[h, 2];
                    h++;
                }
                Console.WriteLine("a) Мин элемент 5-й строки: " + min5);
                //===================
                h = 1;
                int max4 = massiv[3, 0];
                while (h < kolvostolb)
                {
                    if (massiv[3, h] > max4)
                        max4 = massiv[3, h];
                    h++;
                }
                Console.WriteLine("б) Макс элемент 4-его столбца: " + max4);
            }
            void n3()
            { }
            void n4()
            { }
            void n5()
            { }
        }
    }
}