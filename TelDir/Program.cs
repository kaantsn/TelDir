using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelDir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action Actions = new Action();

            Boolean status = true;
            while (status)
            {
                
                Console.WriteLine("Telefon Rehberi \n\n\n" +
                    "1-Numara kaydet\n" +
                    "2-Numara sil\n" +
                    "3-Kişi güncelle\n" +
                    "4-Listele\n" +
                    "5-Rehberde arama\n" +
                    "0-Çıkış");


                int rq = int.Parse(Console.ReadLine());
                switch (rq)
                {
                    case 0:
                        status = false;
                        break;

                    case 1:
                        Actions.add();
                        Console.WriteLine("********");
                        break;
                    case 2:
                        Actions.delete();
                        Console.WriteLine("********");
                        break;
                    case 3:
                        Actions.update();
                        Console.WriteLine("********");
                        break;
                    case 4:
                        Actions.asc();
                        Console.WriteLine("********");
                        break;
          
                    case 5:
                        Actions.search();
                        break;
                   

                }
            }

        }
    }
}