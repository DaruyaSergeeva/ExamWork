using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash
{   
    public class Staff
    {
        
        public int DoneWork;
        public string FIO;
        public Staff(string fio)
        {
            FIO = fio;
        }
        public void DoWork()
        {
            Console.WriteLine(FIO + " выполнил " + DoneWork + " услуг");
        }
    }
}
