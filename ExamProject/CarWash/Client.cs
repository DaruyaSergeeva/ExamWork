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
        public int BuyService = 0;

        public string Fio
        {
            get
            {
                if (Sex == Sex.Female)
                {
                    return "Уважаемая " + LastName + " " + Name + " " + Patronymic;
                }
                return "Уважаемый " + LastName + " " + Name + " " + Patronymic;
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
            Client client2 = (Client)client1;
            if (this.BuyService < client2.BuyService)
            {
                return 1;
            }
            else if (this.BuyService == client2.BuyService)
            {
                if (this.Age < client2.Age)
                {
                    return 1;
                }
                else if (this.Age == client2.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
        
    }
}
