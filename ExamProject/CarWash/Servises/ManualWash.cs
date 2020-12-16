using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash.Servises
{
    class ManualWash:Service
    {
        public ManualWash(Client client, Staff staff , DateTime time) : base(client,staff, time)
        {
            Price = 200;
        }

        public void Message()
        {
            Console.WriteLine("Выполнена услуга 'Ручная мойка'");
        }
    }
}
