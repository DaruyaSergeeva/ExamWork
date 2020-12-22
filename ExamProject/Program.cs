using System;
using ExamProject.CarWash;
using ExamProject.CarWash.Servises;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            static int NumberOfVisitirsPerPeriod(Client[] Name, DateTime Start, DateTime Finish)
            {
                var start = Start.ToBinary();
                var finish = Finish.ToBinary();
                int number = 0;
                for (int i = 0; i < Name.Length; i++)
                {
                    var time = Name[i].TimeVisit.ToBinary();
                    if (time >= start && time <= finish)
                    {
                        number++;
                    }
                }

                return number;
            }
            Client[] SessionLog = { new Client("Иванов Иван Иванович", Sex.Male, 30, new DateTime(2020, 12, 24)),
            new Client("Сергеев Сергей Сергеевич", Sex.Male, 40, new DateTime(2020, 12, 25)),
            new Client("Петров Петр Петрович", Sex.Male, 20, new DateTime(2020, 12, 25)),
            new Client("Николаев Николай Николаевич", Sex.Male, 35, new DateTime(2020, 12,26)),
            new Client("Егоров Егор Егорович", Sex.Male, 25, new DateTime(2020, 12, 26)),
            new Client("Сергеева Дарья Вячеславовна", Sex.Female, 18, new DateTime(2020, 12, 24)),
            };
            

            Staff[] staffs = {
            new Staff("Васильев Петр Сергеевич"),
            new Staff("Крылов Иван Сергеевич"),
            new Staff("Сидоров Евгений Викторович"),
            new Staff("Кузьминых Владимир Николаевич"),
            };

            int k = SessionLog.Length;//Кол-во посетителей
            int n = 3; //Кол-во услуг
            var rnd = new Random();
            int c = rnd.Next(0, k); // берем рандомного человека
            var client = SessionLog[c];
            int s = rnd.Next(0, 3); // и рандомного сотрудника
            var staff = staffs[s];

            DoService[] dos = {
                new DoService(new Service("Стандарт-мойка", 400),client, staff,client.TimeVisit),
                new DoService(new Service("Экспресс-мойка", 300), client, staff, client.TimeVisit),
                new DoService(new Service("Комфорт-мойка", 500), client, staff, client.TimeVisit),
                new DoService(new Service("Престиж-мойка", 750), client, staff, client.TimeVisit)
            };

            Console.WriteLine("____________________Выполненные услуги:_____________________");

            for (int i = 0; i < n; i++)
            {
                
                int wash = rnd.Next(0, 4);
                var randserv = dos[wash];
                randserv.DoWork();
            }
            Console.WriteLine();

            Console.WriteLine("_______________Сумма, потраченная посетителем:_______________");
            Console.WriteLine();
            SessionLog[c].SpendKash();
            Console.WriteLine();

            Array.Sort(SessionLog);
            Console.WriteLine("________________Журнал посетителей автомойки_________________");

            Console.WriteLine();

            for (int i = 0; i < SessionLog.Length; i++)
            {
                Console.WriteLine(SessionLog[i].Fio);
            }

           
            //Console.WriteLine($"кол-во купленных услуг = " + client.BuyService);


            Console.WriteLine();
            Console.WriteLine("______Количество работы выполненой сотрудником автомойки_____");
            Console.WriteLine();
            staffs[s].DoWork();
            Console.WriteLine();
           
            
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("Посетителей в периоде: " + NumberOfVisitirsPerPeriod(SessionLog, new DateTime(2020, 12, 24), new DateTime(2020, 12, 26)));
            Console.WriteLine("_____________________________________________________________");
            Console.ReadLine();

            
        }
    }
}
