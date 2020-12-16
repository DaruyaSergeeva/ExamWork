using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash.Servises
{
    class ExpressWash:Service
    {
        public ExpressWash(Client client,Staff staff, DateTime time) : base(client, staff, time)
        {
            Price = 250;
        }

        public void Message()
        {
            Console.WriteLine("Выполнена услуга 'Экспресс-мойка'");
        }
    }
}
