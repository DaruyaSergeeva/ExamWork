using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash.Servises
{
    class Service
    {
        public int Price;
        public DateTime Time;
        public Staff Staff;
        public Client Client;
        public Service(Client client,Staff staff, DateTime time)
        {
            Time = time;
            
            Client = client;
            Staff = staff;
        }

        public void DoWork()
        {

            Staff.DoneWork++;
            Client.SpendMoney += Price;
            Client.BuyService++;
        }
    }
}
