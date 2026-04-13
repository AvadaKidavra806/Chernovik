//using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using Код_по_блок_схеме_на_10._02._26;
//using Расчет_суммы_или_колва_элементов_массива_9_2_26;

namespace Main
{
    internal class ClaasMain
    {
        static void Main()
        {
            //Черновик.Черновик черновик = new Черновик.Черновик(); черновик.Решение();
            //Zadachi.Zapolnenie zapolnenie = new Zadachi.Zapolnenie(); zapolnenie.Vuvod();
            //Raschet.Zadachi zadachi = new Raschet.Zadachi(); zadachi.DvuMassiv();
            ProverkaUslovia.PosleRaschetov posle = new ProverkaUslovia.PosleRaschetov(); posle.DmumerMassiv();
            //Otrabotka.Metodov metodov = new Otrabotka.Metodov(); metodov.TipoMain();
            Console.Write("Для завершения программы нажмите Enter");
            Console.ReadLine();
        }
    }
}
