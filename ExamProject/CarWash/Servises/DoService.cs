using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash.Servises
{
    class DoService
    {
        public int Price;
        public DateTime Time;
        public Staff Staff;
        public Client Client;
        public Service Service;
        public string NameService;
        
        public DoService(Service service, Client client,Staff staff,DateTime time)
        {
            Service = service;
            Time = time;
            Price = service.Price;
            Client = client;
            Staff = staff;
            NameService = service.Name;
            
            
        }

        public void DoWork()
        {
            Staff.DoneWork++;
            Client.SpendMoney += Price;
            Client.BuyService++;
            Console.WriteLine("Для клиента " + Client.FullName + " выполнена услуга " + NameService);
        }

    }
}
