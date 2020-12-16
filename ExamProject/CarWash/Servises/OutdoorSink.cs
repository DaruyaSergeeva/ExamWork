using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash.Servises
{
    class OutdoorSink:Service
    {
        public OutdoorSink( Client client, Staff staff, DateTime time) : base(client,staff,time)
        {
            Price = 390;
        }

        public void Message()
        {
            Console.WriteLine("Выполнена услуга 'Наружная мойка'");
        }
    }
}
