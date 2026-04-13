using System;

//ProverkaUslovia.PosleRaschetov posle = new ProverkaUslovia.PosleRaschetov(); posle.DmumerMassiv();
namespace ProverkaUslovia
{
    public class PosleRaschetov
    {
        public void DmumerMassiv()
        {
            //по 14 дз
            Console.WriteLine("Двумерный массив проверка условия после выполнения рассчетов ");
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
                Console.Write("Введите количество строк в массиве: ");
                int KolvoStrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (KolvoStrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    /*else if (kolvostrok < 2)
                        Console.Write("При таком кол-ве строк нельзя найти мин элемент второй строки. Введите кол-во строк еще раз ");*/
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int KolvoStolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb < 2)
                        Console.Write("При таком кол-ве столбцов нельзя найти произведение элементов второго столбца. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                int proiz = 1;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                        if (j == 1)
                            proiz *= massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //=============================
                if (Math.Abs(proiz) > 99 && Math.Abs(proiz) <= 999)
                    Console.WriteLine($"a) Произведение элементов второго столбца является 3х значным числом ({proiz})");
                else
                    Console.WriteLine($"a) Произведение элементов второго столбца не является 3х значным числом ({proiz})");
                //===================
                Console.WriteLine("Определить верно ли, что сумма элементов строки массива превышает заданное число");
                Console.Write($"Введите номер строки для нахождения суммы элементов этой строки для проверки условия ");
                int NomerStroki = 0; bool OutNomerStroki = true;
                while (OutNomerStroki)
                {
                    if (!int.TryParse(Console.ReadLine(), out NomerStroki))
                        Console.Write("Ошибка! Введите номер строки еще раз ");
                    else if (NomerStroki <= 0 || NomerStroki > KolvoStrok)
                        Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({KolvoStrok}). Введите номер строки еще раз ");
                    else
                        OutNomerStroki = false;
                }
                Console.Write("Введите число для проверки условия ");
                double Chislo = 0; bool OutChislo = true;
                while (OutChislo)
                {
                    if (!double.TryParse(Console.ReadLine(), out Chislo))
                        Console.Write("Ошибка! Введите число еще раз ");
                    else
                        OutChislo = false;
                }
                int sum = 0;
                for (int i = 0; i < KolvoStolb; i++) sum += massiv[NomerStroki - 1, i];
                if (sum > Chislo)
                    Console.WriteLine($"б) Верно, сумма элементов заданной строки превышает заданное число (sum: {sum}, chislo: {Chislo})");
                else
                    Console.WriteLine($"б) Не верно, сумма элементов заданной строки не превышает заданное число (sum: {sum}, chislo: {Chislo})");
            }
            void n2()
            {
                Console.Write("Введите количество строк в массиве: ");
                int KolvoStrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (KolvoStrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (KolvoStrok < 4)
                        Console.Write("При таком кол-ве строк нельзя найти сумму элементов четвертой строки. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int KolvoStolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");/*
                    else if (KolvoStolb < 2)
                        Console.Write("При таком кол-ве столбцов нельзя найти произведение элементов второго столбца. Введите кол-во столбцов еще раз ");*/
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                int sum = 0;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                        if (i == 3)
                            sum += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //=============================
                if (Math.Abs(sum) > 9 && Math.Abs(sum) <= 99)
                    Console.WriteLine($"a) Сумма элементов четвертой строки является 2х значным числом ({sum})");
                else
                    Console.WriteLine($"a) Сумма элементов четвертой строки не является 2х значным числом ({sum})");
                //===================
                Console.WriteLine("Определить верно ли, что произведение элементов столбца массива не превышает заданное число");
                Console.Write($"Введите номер столбца для нахождения произведения элементов этого столбца для проверки условия ");
                int NomerStolb = 0; bool OutNomerStolb = true;
                while (OutNomerStolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out NomerStolb))
                        Console.Write("Ошибка! Введите номер столбца еще раз ");
                    else if (NomerStolb <= 0 || NomerStolb > KolvoStolb)
                        Console.Write($"Номер столбца не может быть неположительным и больше кол-ва столбцов в массиве ({KolvoStolb}). Введите номер столбца еще раз ");
                    else
                        OutNomerStolb = false;
                }
                Console.Write("Введите число для проверки условия ");
                double Chislo = 0; bool OutChislo = true;
                while (OutChislo)
                {
                    if (!double.TryParse(Console.ReadLine(), out Chislo))
                        Console.Write("Ошибка! Введите число еще раз ");
                    else
                        OutChislo = false;
                }
                int proiz = 1;
                for (int i = 0; i < KolvoStrok; i++) proiz *= massiv[i, NomerStolb - 1];
                if (proiz < Chislo)
                    Console.WriteLine($"б) Верно, произведение элементов заданного столбца не превышает заданное число (proiz: {proiz}, chislo: {Chislo})");
                else
                    Console.WriteLine($"б) Не верно, произведение элементов заданного столбца превышает заданное число (proiz: {proiz}, chislo: {Chislo})");
            }
            void n3()
            {
                const int KolvoStrok = 18;
                const int KolvoStolb = 12;
                double[,] massiv = new double[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                double GodSum = 0;
                Console.WriteLine("информация о зарплатах 18 работников за год (тыс): ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = Math.Round(rnd.NextDouble() * 200, 3);
                        Console.Write(massiv[i, j] + "\t");
                        if (j == 0)
                            GodSum += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //=============================
                Console.WriteLine("Определить верно ли, что годовой оклад 1-го работника больше некоторого числа");
                Console.Write("Введите число для проверки условия ");
                double Chislo = 0; bool OutChislo = true;
                while (OutChislo)
                {
                    if (!double.TryParse(Console.ReadLine(), out Chislo))
                        Console.Write("Ошибка! Введите число еще раз ");
                    else
                        OutChislo = false;
                }
                if (GodSum > Chislo)
                    Console.WriteLine($"Верно, годовой оклад 1-го работника больше некоторого числа (GodSum: {GodSum}; chislo: {Chislo})");
                else
                    Console.WriteLine($"Не верно, годовой оклад 1-го работника меньше некоторого числа (GodSum: {GodSum}; chislo: {Chislo})");

            }
            void n4()
            {
                const int KolvoStrok = 10;
                const int KolvoStolb = 12;
                double[,] massiv = new double[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                double GodSum = 0;
                Console.WriteLine("информация о доходе 10 магазинов за год (тыс): ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = Math.Round(rnd.NextDouble() * 200, 3);
                        Console.Write(massiv[i, j] + "\t");
                        if (i == 8)
                            GodSum += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //=============================
                Console.WriteLine("Определить верно ли, что общий доход фирмы за сентябрь больше некоторого числа");
                Console.Write("Введите число для проверки условия ");
                double Chislo = 0; bool OutChislo = true;
                while (OutChislo)
                {
                    if (!double.TryParse(Console.ReadLine(), out Chislo))
                        Console.Write("Ошибка! Введите число еще раз ");
                    else
                        OutChislo = false;
                }
                if (GodSum > Chislo)
                    Console.WriteLine($"Верно, общий доход фирмы за сентябрь больше некоторого числа (GodSum: {GodSum}; chislo: {Chislo})");
                else
                    Console.WriteLine($"Не верно, общий доход фирмы за сентябрь меньше некоторого числа (GodSum: {GodSum}; chislo: {Chislo})");
            }
            void n5()
            {
                const int kolvostrok = 23;
                const int kolvostolb = 40;
                const int IndexRyda = 0;
                int[,] massiv = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Данные о местах: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        massiv[i, j] = rnd.Next(0, 2);
                        Console.Write(massiv[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                {
                    int j = 0;
                    bool Indikator = true;
                    while (j < kolvostolb && Indikator)
                    {
                        if (massiv[IndexRyda, j] == 0)
                        {
                            Indikator = false;
                            Console.WriteLine($"В {IndexRyda + 1}-м ряду есть свободные места");
                        }
                        j++;
                    }
                    if (Indikator)
                        Console.WriteLine($"В {IndexRyda + 1}-м ряду нет свободных мест");
                }
            }
            void n6()
            {
                const int kolvostrok = 18;
                const int kolvostolb = 36;

                int[,] massiv = new int[kolvostrok, kolvostolb];
                Random rnd = new Random();
                Console.WriteLine("Данные о местах в вагонах: ");
                for (int i = 0; i < kolvostrok; i++)
                {
                    for (int j = 0; j < kolvostolb; j++)
                    {
                        massiv[i, j] = rnd.Next(0, 2);
                        Console.Write(massiv[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Определить есть ли свободные места в выбранном вагоне");
                Console.Write("Введите номер вагона, в котором необходимо провести проверку ");
                int NomerVagona = 0; bool OutIndexRyda = true;
                while (OutIndexRyda)
                {
                    if (!int.TryParse(Console.ReadLine(), out NomerVagona))
                        Console.Write("Ошибка! Введите номер вагона еще раз ");
                    else if (NomerVagona <= 0 || NomerVagona > kolvostrok)
                        Console.Write($"Ошибка! Номер вагона не может быть неположительным и больше кол-ва вагонов ({kolvostrok}). Введите номер вагона еще раз  ");
                    else
                        OutIndexRyda = false;
                }
                {
                    int j = 0;
                    bool Indikator = true;
                    while (j < kolvostolb && Indikator)
                    {
                        if (massiv[NomerVagona - 1, j] == 0)
                        {
                            Indikator = false;
                            Console.WriteLine($"В {NomerVagona}-м вагоне есть свободные места");
                        }
                        j++;
                    }
                    if (Indikator)
                        Console.WriteLine($"В {NomerVagona}-м вагоне нет свободных мест");
                }
            }
            void n7()
            {
                Console.Write("Введите количество строк в массиве: ");
                int KolvoStrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (KolvoStrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    /*else if (kolvostrok < 2)
                        Console.Write("При таком кол-ве строк нельзя найти мин элемент второй строки. Введите кол-во строк еще раз ");*/
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int KolvoStolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    /*else if (KolvoStolb < 2)
                        Console.Write("При таком кол-ве столбцов нельзя найти произведение элементов второго столбца. Введите кол-во столбцов еще раз ");*/
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                int sum1 = 0;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                        if (i == 0)
                            sum1 += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //=============================
                if (sum1 % 2 == 0 && sum1 != 0)
                    Console.WriteLine("a) Верно, сумма элементов первой строки является четным числом (" + sum1 + ")");
                else
                    Console.WriteLine("a) Неверно, сумма элементов первой строки не является четным числом (" + sum1 + ")");
                //========================
                //===================
                Console.WriteLine("Определить верно ли, что сумма элементов столбца массива кратна заданномму числу");
                Console.Write($"Введите номер столбца для нахождения суммы элементов этого столбца для проверки условия ");
                int NomerStolb = 0; bool OutNomerStolb = true;
                while (OutNomerStolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out NomerStolb))
                        Console.Write("Ошибка! Введите номер столбца еще раз ");
                    else if (NomerStolb <= 0 || NomerStolb > KolvoStolb)
                        Console.Write($"Номер столбца не может быть неположительным и больше кол-ва столбцов в массиве ({KolvoStolb}). Введите номер столбца еще раз ");
                    else
                        OutNomerStolb = false;
                }
                Console.Write("Введите число для проверки условия ");
                double Chislo = 0; bool OutChislo = true;
                while (OutChislo)
                {
                    if (!double.TryParse(Console.ReadLine(), out Chislo))
                        Console.Write("Ошибка! Введите число еще раз ");
                    else
                        OutChislo = false;
                }
                int Sum = 0;
                for (int i = 0; i < KolvoStrok; i++) Sum += massiv[i, NomerStolb - 1];
                if (Sum % Chislo == 0)
                    Console.WriteLine($"б) Верно, сумма элементов заданного столбца кратна заданному числу (proiz: {Sum}, chislo: {Chislo})");
                else
                    Console.WriteLine($"б) Не верно, сумма элементов заданного столбца не кратна заданному числу (proiz: {Sum}, chislo: {Chislo})");
            }
            void n8()
            {
                Console.Write("Введите количество строк в массиве: ");
                int KolvoStrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (KolvoStrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int KolvoStolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb < 2)
                        Console.Write("При таком кол-ве столбцов нельзя найти сумму элементов второго столбца. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                int sum2 = 0;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                        if (j == 1)
                            sum2 += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //===================
                Console.WriteLine("Определить верно ли, что сумма элементов строки массива заканчивается нулем ");
                Console.Write($"Введите номер строки для нахождения суммы элементов этой строки для проверки условия ");
                int NomerStroki = 0; bool OutNomerStroki = true;
                while (OutNomerStroki)
                {
                    if (!int.TryParse(Console.ReadLine(), out NomerStroki))
                        Console.Write("Ошибка! Введите номер строки еще раз ");
                    else if (NomerStroki <= 0 || NomerStroki > KolvoStrok)
                        Console.Write($"Номер строки не может быть неположительным и больше кол-ва строк в массиве ({KolvoStrok}). Введите номер строки еще раз ");
                    else
                        OutNomerStroki = false;
                }
                int Sum = 0;
                for (int i = 0; i < KolvoStrok; i++) Sum += massiv[NomerStroki - 1, i];
                if (Sum % 10 == 0)
                    Console.WriteLine($"a) Верно, сумма элементов заданной строки заканчивается нулем (proiz: {Sum})");
                else
                    Console.WriteLine($"a) Не верно, сумма элементов заданной строки не заканчивается нулем (proiz: {Sum}, chislo)");
                //=============================
                if (sum2 % 2 == 0 && sum2 != 0)
                    Console.WriteLine("б) Cумма элементов первой строки является четным числом (" + sum2 + ")");
                else
                    Console.WriteLine("б) Сумма элементов первой строки не является четным числом (" + sum2 + ")");
                //========================
            }
            void n9()
            {
                Console.Write("Введите количество строк в массиве: ");
                int KolvoStrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (KolvoStrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (KolvoStrok < 2)
                        Console.Write("При таком кол-ве строк нельзя найти сумму элементов предпоследней строки (Первая строка - полседняя, предполследней не существует). Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int KolvoStolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb < 2)
                        Console.Write("При таком кол-ве столбцов нельзя найти сумму элементов второго столбца. Введите кол-во столбцов еще раз ");
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                int SumStrok1 = 0;
                int SumStrokPredLast = 0;
                int SumStolb2 = 0;
                int SumStolbLast = 0;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                        if (i == 0)
                            SumStrok1 += massiv[i, j];
                        if (i == KolvoStrok-2)
                            SumStrokPredLast += massiv[i, j];
                        if (j == 1)
                            SumStolb2 += massiv[i, j];
                        if (j == KolvoStolb - 1)
                            SumStolbLast += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //===================
                if (SumStrok1 > SumStrokPredLast)
                    Console.WriteLine($"a) В первой строке сумма элементов больше, чем в предпоследней (SumStrok1: {SumStrok1}, SumStrokPredLast {SumStrokPredLast})");
                else if (SumStrok1 < SumStrokPredLast)
                    Console.WriteLine($"a) В первой строке сумма элементов меньше, чем в предпоследней (SumStrok1: {SumStrok1}, SumStrokPredLast {SumStrokPredLast})");
                else
                    Console.WriteLine($"a) В первой строке сумма элементов равна сумме в предпоследней (SumStrok1: {SumStrok1}, SumStrokPredLast {SumStrokPredLast})");
                //==========
                if (SumStolb2 < SumStolbLast)
                    Console.WriteLine($"б) Во втором столбце сумма элементов меньше, чем в полседнем (SumStolb2: {SumStolb2}, SumStolbLast: {SumStolbLast})");
                else if (SumStolb2 > SumStolbLast)
                    Console.WriteLine($"б) Во втором столбце сумма элементов больше, чем в полседнем (SumStolb2: {SumStolb2}, SumStolbLast: {SumStolbLast})");
                else 
                    Console.WriteLine($"б) Во втором столбце сумма элементов равна сумме в полседнем (SumStolb2: {SumStolb2}, SumStolbLast: {SumStolbLast})");
            }
            void n10()
            {
                Console.Write("Введите количество строк в массиве: ");
                int KolvoStrok = 0; bool outkolvostrok = true;
                while (outkolvostrok)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStrok))
                        Console.Write("Ошибка! Введите кол-во строк еще раз ");
                    else if (KolvoStrok <= 0)
                        Console.Write("Кол-во строк не может быть неположительным. Введите кол-во строк еще раз ");
                    else if (KolvoStrok < 3)
                        Console.Write("При таком кол-ве строк нельзя найти сумму элементов третьей и второй строк. Введите кол-во строк еще раз ");
                    else
                        outkolvostrok = false;
                }
                Console.Write("Введите количество столбцов в массиве: ");
                int KolvoStolb = 0; bool outkolvostolb = true;
                while (outkolvostolb)
                {
                    if (!int.TryParse(Console.ReadLine(), out KolvoStolb))
                        Console.Write("Ошибка! Введите кол-во столбцов еще раз ");
                    else if (KolvoStolb <= 0)
                        Console.Write("Кол-во столбцов не может быть неположительным. Введите кол-во столбцов еще раз ");
                    /*else if (KolvoStolb < 1)
                        Console.Write("При таком кол-ве столбцов нельзя найти сумму элементов второго столбца. Введите кол-во столбцов еще раз ");*/
                    else
                        outkolvostolb = false;
                }
                int[,] massiv = new int[KolvoStrok, KolvoStolb];
                Random rnd = new Random();
                int SumStrok2 = 0;
                int SumStrok3 = 0;
                int SumStolb1 = 0;
                int SumStolbLast = 0;
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < KolvoStrok; i++)
                {
                    for (int j = 0; j < KolvoStolb; j++)
                    {
                        massiv[i, j] = rnd.Next(-10, 10);
                        Console.Write(massiv[i, j] + "\t");
                        if (i == 1)
                            SumStrok2 += massiv[i, j];
                        if (i == 2)
                            SumStrok3 += massiv[i, j];
                        if (j == 0)
                            SumStolb1 += massiv[i, j];
                        if (j == KolvoStolb - 1)
                            SumStolbLast += massiv[i, j];
                    }
                    Console.WriteLine();
                }
                //==========
                if (SumStolb1 < SumStolbLast)
                    Console.WriteLine($"а) В первом столбце сумма элементов меньше, чем в полседнем (SumStolb1: {SumStolb1}, SumStolbLast: {SumStolbLast})");
                else if (SumStolb1 > SumStolbLast)
                    Console.WriteLine($"а) В первом столбце сумма элементов больше, чем в полседнем (SumStolb1: {SumStolb1}, SumStolbLast: {SumStolbLast})");
                else
                    Console.WriteLine($"а) В первом столбце сумма элементов равна сумме в полседнем (SumStolb1: {SumStolb1}, SumStolbLast: {SumStolbLast})");
                //===================
                if (SumStrok2 > SumStrok3)
                    Console.WriteLine($"б) Во второй строке сумма элементов больше, чем в третьей (SumStrok2: {SumStrok2}, SumStrok3 {SumStrok3})");
                else if (SumStrok2 < SumStrok3)
                    Console.WriteLine($"б) Во второй строке сумма элементов больше, чем в третьей (SumStrok2: {SumStrok2}, SumStrok3 {SumStrok3})");
                else
                    Console.WriteLine($"б) Во второй строке сумма элементов равна сумме в третьей (SumStrok2: {SumStrok2}, SumStrok3 {SumStrok3})");
                
            }
        }
    }
}