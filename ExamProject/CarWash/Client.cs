using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject
{
    public enum Sex
    {
        Male,
        Female
    }

    class Client:IComparable
    {
        public DateTime TimeVisit;
        public Sex Sex;
        public string FIO;
        
        public string LastName;
        public string Name;
        public string Patronymic;
        public int Age;
        public int SpendMoney = 0;
        public int BuyService;

        public string Fio
        {
            get
            {
                if (Sex == Sex.Female)
                {
                    return "Уважаемая " + LastName + " " + Name + " " + Patronymic + " ,возраст " + Age;
                }
                return "Уважаемый " + LastName + " " + Name + " " + Patronymic + " ,возраст " + Age;
            }
            set {
                FIO = value;
            }
        }

        public string FullName
        {
            get
            {
                return LastName + " " + Name + " " + Patronymic;
            }
            set
            {
                FullName = value;
            }
        }

        public Client( string FIO, Sex sex, int age, DateTime timeVisit)
        {
            TimeVisit = timeVisit;
            LastName = FIO.Split(' ')[0];
            Name = FIO.Split(' ')[1];
            Patronymic = FIO.Split(' ')[2];
            Sex = sex;
            Age = age;
        }

        public void SpendKash()
        {
            if (Sex == Sex.Female)
            {
                Console.WriteLine(FullName + " купила услуги на сумму " + SpendMoney);
                return;
            }
            Console.WriteLine(FullName + " купил услуги на сумму " + SpendMoney);
        }

        public int CompareTo(object client1)
        {
            Client client2 = client1 as Client;
            var comp = BuyService.CompareTo(client2.BuyService);
            var age = Age.CompareTo(client2.Age);
            if (comp == 0)
            {
              return age;
            }
            else
            
                return comp;
            
                
        }
    }
}
