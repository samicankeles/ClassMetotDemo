using System;
using System.Collections.Generic;
using ActionPanel;

namespace ActionPanel
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();

            Baslangıc:

            Console.WriteLine("Yapmak istediğiniz işlem numarasını seçiniz" +
                "\n 1- Kişileri Listele" +
                "\n 2- Kişi Ekle" +
                "\n 3- Kişi Sil" +
                "\n 4- Çıkış");

            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    customerManager.CustomerListView();
                    goto Baslangıc;
                case 2:
                    customerManager.Add();
                    goto Baslangıc;
                case 3:
                    customerManager.Delete();
                    goto Baslangıc;
                case 4:
                    break;
            }
        }
    }
}

