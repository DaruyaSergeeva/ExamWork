using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash.Servises
{
    class ComplexWash:Service
    {
        public ComplexWash( Client client,Staff staff, DateTime time) : base(client, staff, time)
        {
            Price = 790;
        }

        public void Message()
        {
            Console.WriteLine("Выполнена услуга 'Комплекс мойка'");
        }
    }
}
