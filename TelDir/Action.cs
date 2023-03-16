using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelDir
{
    internal class Action
    {
        List<Person> Persons = new List<Person>();
        public Action()
        {
            Persons.Add(new Person("leo", "messi", "101010"));
            Persons.Add(new Person("neymar", "jr", "111111"));
            Persons.Add(new Person("fenomen" ,"ronaldo", "090909"));
            Persons.Add(new Person("luiz", "suarez", "161616"));
            Persons.Add(new Person("sinan", "engin", "070707"));
        }

        public void add()
        {

            Console.Write("Ad Giriniz: ");
            String name = Console.ReadLine();


            Console.Write("Soyadını giriniz: ");
            String surName = Console.ReadLine();


            Console.Write("Lütfen kişi numarasını giriniz: ");
            String number = Console.ReadLine();

            Person newPerson = new Person(name, surName, number);
            Persons.Add(newPerson);
            Console.WriteLine(name + " Rehbere Kaydedilmiştir !");

        }

        public void delete()
        {
        head:
            Console.WriteLine("Lütfen kişinin ismini veya soyismini giriniz: ");
            String nameOrSurnameForDelete = Console.ReadLine();




            for (int i = 0; i < Persons.Count; i++)
            {


                if (Persons[i].Name.Equals(nameOrSurnameForDelete) || Persons[i].SurName.Equals(nameOrSurnameForDelete))// İsim veya soyisim uyuşuyorsa şartın sağlanması gerçekleştirilir
                {
                    Console.WriteLine(Persons[i].Name + " Adlı kişi silinecektir onaylıyorsanız (1) onaylamıyorsanız (0) tuşlayınız");
                    int chooseToValue = int.Parse(Console.ReadLine());
                    if (chooseToValue == 1)
                    {
                        Console.WriteLine(Persons[i].Name + " Adlı kişi rehberden silinmiştir..");
                        Persons.RemoveAt(i);
                        break;
                    }
                    else
                        break;

                }
                if (i == Persons.Count - 1)// Eğer listenin son elemanı bile uyuşmuyorsa demekki böyle bir eleman yoktur
                {
                    Console.WriteLine("Aranan kişi rehberde kayıtlı değildir..tekrar denemek için (1) silme işlemimnden çıkmak için (0) basınız");
                    int chooseToValue = int.Parse(Console.ReadLine());
                    if (chooseToValue == 1)
                        goto head;
                    else
                        break;
                }

            }

        }

        public void update()
        {
        head:
            Console.WriteLine("Lütfen kişinin ismini veya soyismini giriniz: "); String nameOrSurnameForDelete = Console.ReadLine();
            nameOrSurnameForDelete = nameOrSurnameForDelete.ToLower();


            for (int i = 0; i < Persons.Count; i++)
            {


                if (Persons[i].Name.Equals(nameOrSurnameForDelete) || Persons[i].SurName.Equals(nameOrSurnameForDelete))
                {
                    Console.WriteLine("(1) ADI GÜNCELLE\n(2) SOYADI GÜNCELLE\n (3) NUMARAYI GÜNCELLE\n(0)GÜNCELLEMEKTEN VAZGEÇ");
                    int chooseToValue = int.Parse(Console.ReadLine());
                    if (chooseToValue == 1)
                    {
                        Console.WriteLine("Lütfen yeni adı giriniz: "); string newName = Console.ReadLine();
                        Console.Write(Persons[i].Name + " adlı kişinin ismi ");
                        Persons[i].Name = newName;
                        Console.WriteLine(Persons[i].Name + " olarak güncellenmiştir");
                        break;
                    }
                    else if (chooseToValue == 2)
                    {
                        Console.WriteLine("Lütfen yeni soyadını  giriniz: "); string newSurname = Console.ReadLine();
                        Console.Write(Persons[i].SurName + " adlı kişinin ismi ");
                        Persons[i].Name = newSurname;
                        Console.WriteLine(Persons[i].SurName + " olarak güncellenmiştir");
                        break;
                    }
                    else if (chooseToValue == 3)
                    {
                        Console.WriteLine("Lütfen yeni numarayı giriniz: "); string newNumber = Console.ReadLine();
                        Console.Write(Persons[i].Number + " adlı kişinin numarası ");
                        Persons[i].Number = newNumber;
                        Console.WriteLine(Persons[i].Number + " olarak güncellenmiştir");
                        break;
                    }
                    else
                    {
                        break;
                    }


                }
                if (i == Persons.Count - 1)
                {
                    Console.WriteLine("Aranan kişi rehberde kayıtlı değildir..tekrar denemek için (1) güncelleme işlemimnden çıkmak için (0) basınız");
                    int chooseToValue = int.Parse(Console.ReadLine());
                    if (chooseToValue == 1)
                        goto head;
                    else
                        break;
                }

            }
        }

        public void asc()
        {
            var p = Persons.OrderBy(value => value.Name);

            foreach (var person in p)
            {

                Console.WriteLine("Kişi adı: " + person.Name);
                Console.WriteLine("Kişi soyadı: " + person.SurName);
                Console.WriteLine("Kişi numarası: " + person.Number);

            }
        }



        public void search()
        {
            Console.WriteLine("Aramak istediğiniz kişi: ");
            string snors = Console.ReadLine();

            for (int i = 0; i < Persons.Count; i++)
            {

                if (Persons[i].Name.Equals(snors) || Persons[i].SurName.Equals(snors))
                {

                    Console.WriteLine("Kişinin adı: " + Persons[i].Name);
                    Console.WriteLine("Kişinin adı: " + Persons[i].SurName);
                    Console.WriteLine("Kişinin adı: " + Persons[i].Number);


                }
                if (i == Persons.Count - 1)
                {
                    Console.WriteLine("Aranan kişi telefon rehber listesinde bulunmamaktadır! ");
                    break;
                }
            }

        }
    }
}
