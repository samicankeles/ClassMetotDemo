using System;
using System.Collections.Generic;
using ActionPanel;

namespace ActionPanel
{
    public class CustomerManager
    {

        List<CustomersInfo> customersList = new List<CustomersInfo> { };


        public void Add()
        {
            Random random1 = new Random();
            int number1 = random1.Next();
            Random random2 = new Random();
            int number2 = random2.Next();
            long customerId = number1 + number2;
            if (customerId <= 0)
            {
                customerId = 0 - customerId;
            }

            Console.WriteLine("Yeni müşteri Oluşturma İşlemi \n \n Müşteri ID :  "+customerId);

            CustomersInfo customer = new CustomersInfo();
            customer.Id = customerId;
            Console.Write("Adı :  ");
            customer.FirstName = Console.ReadLine();
            Console.Write("Soyadı :  ");
            customer.LastName = Console.ReadLine();
            Console.Write("Uyruk :  ");
            customer.Nationality = Console.ReadLine();
            Console.Write("Kimlik Numarası :  ");
            customer.NationalityIdentityNumber = Console.ReadLine();
            Console.Write("Doğum Yılı :  ");
            customer.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doğum Ayı :  ");
            customer.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Doğum Günü :  ");
            customer.DayOfBirth = Convert.ToInt32(Console.ReadLine());

            customersList.Add(customer);

            Console.WriteLine(customer.NationalityIdentityNumber+" ("+customer.Nationality+") " +
                "Kimlik numaralı "+customer.FirstName+" "+customer.LastName+" eklendi" );

        }

        public void CustomerListView()
        {
            foreach (CustomersInfo i in customersList)
            {
                Console.WriteLine(i.Id + "   " + i.Nationality + "/"+i.NationalityIdentityNumber +"   " + i.FirstName + " " + i.LastName);
            }
        }

        public void Delete()
        {
            Console.Write("Silinecek Müşteri ID :  ");
            long deleteId = Convert.ToInt64(Console.ReadLine());

            int deleteLineNumber = -1;
            foreach (CustomersInfo customer in customersList)
            {
                    if (customer.Id==deleteId)
                    {

                    Console.WriteLine("\n ----- Silinecek Kişi Bilgileri ----- " +
                        "\n Id :  " + customer.Id +
                        "\n Uyruk / Kimlik Numarası :  " + customer.Nationality + " / " + customer.NationalityIdentityNumber +
                        "\n Ad Soyad :  " + customer.FirstName + " " + customer.LastName +
                        "\n Doğum Tarihi :  " + customer.DayOfBirth + "/" + customer.MonthOfBirth + "/" + customer.YearOfBirth );

                    int silmeOnayi;
                    Console.WriteLine(" Silmeyi onaylıyor musunuz ?    Evet:1  Hayır:0");
                    silmeOnayi = Convert.ToInt32(Console.ReadLine());

                    if (silmeOnayi==1)
                    {
                        deleteLineNumber = customersList.BinarySearch(customer);
                        customersList.Remove(customer);
                        Console.WriteLine("Kişi silindi");
                    }
                    goto sonucMesaji;
                    }
            }

            sonucMesaji:
            if (deleteLineNumber==-1)
            {
                Console.WriteLine("\nKişi Silinmedi");
            }

        }
    }
}

