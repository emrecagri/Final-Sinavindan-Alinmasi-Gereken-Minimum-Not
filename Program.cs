using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaldenAlmanGerekenMinimumNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, vizeOrtalama, minimumFinaNotuOrtalamasi, minimumFinalNotu;

            Console.WriteLine("Dersi geçebilmek için finalden yada bütünlemeden en az kaç alman gerektiğini söyleyen program.");
            Console.WriteLine("Vizenin yüzde 40'ını finalin/bütünlemenin yüzde 60'ı alınmaktadır.");
            Console.WriteLine("Geçme notuda 60 olarak hesaplanmaktadır.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            while (true)
            {

                Console.Write("Vize notunu yaz: ");
                vize = Convert.ToInt32(Console.ReadLine());

                vizeOrtalama = (vize * 40) / 100; //Bu satırdaki 40 vizenin %40'ının alındığını belirtmektedir.
                minimumFinaNotuOrtalamasi = 60 - vizeOrtalama; //Bu satırdaki 60 geçme notudur.
                minimumFinalNotu = (minimumFinaNotuOrtalamasi * 100) / 60; //Bu satırdaki 60 finalin %60'ının alındığını belirtmektedir.
                Console.WriteLine("Finalden yada bütünlemeden alman gereken min not: " + minimumFinalNotu);

                Console.WriteLine("");
                Console.WriteLine("-----------Tekrar Hesapla-----------");
                Console.WriteLine("");
            }
        }
    }
}
