using System;
using ExamProject.CarWash;
using ExamProject.CarWash.Servises;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            static int NumberOfVisitirsPerPeriod(Client[] Name , DateTime Start, DateTime Finish)
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
            Client[] SessionLog = { new Client("Иванов Иван Иванович", Sex.Male, 25, new DateTime(2020, 12, 24)),
            new Client("Сергеев Сергей Сергеевич", Sex.Male, 75, new DateTime(2020, 12, 25)),
            new Client("Петров Петр Петрович", Sex.Male, 20, new DateTime(2020, 12, 25)),
            new Client("Николаев Николай Николаевич", Sex.Male, 25, new DateTime(2020, 12,26)),
            new Client("Егоров Егор Егорович", Sex.Male, 30, new DateTime(2020, 12, 26)),
            new Client("Сергеева Дарья Вячеславовна", Sex.Female, 20, new DateTime(2020, 12, 24)),
            };

            Staff staff1 = new Staff("Васильев Петр Сергеевич");              //персонал
            Staff staff2 = new Staff("Крылов Иван Сергеевич");                //персонал
            Staff staff3 = new Staff("Сидоров Евгений Викторович");           //персонал
            Staff staff4 = new Staff("Кузьминых Владимир Николаевич");        //персонал

            Console.WriteLine("_____Журнал посетителей автомойки_____");

            ComplexWash serv = new ComplexWash(SessionLog[5], staff1, new DateTime(2020,12,24)); // теперь у последнего человека на 1 больше 
            serv.DoWork();                                                                       // услуг и он должен быть в начале списка
            
            Console.WriteLine();
            Array.Sort(SessionLog);
            for (int i = 0; i < SessionLog.Length; i++)
            {
                Console.WriteLine(SessionLog[i].Fio);
            }
            Console.WriteLine("______________________________________");
            Console.WriteLine("Посетителей в периоде: " + NumberOfVisitirsPerPeriod(SessionLog, new DateTime(2020, 12, 24), new DateTime(2020, 12, 26)));
            Console.WriteLine("______________________________________");

            int k = SessionLog.Length;//Кол-во посетителей
            int n = 3; //Кол-во услуг
            var rnd = new Random();
           
            for (int i = 0; i < k; i++)
            {
                var client = SessionLog[i];
                Console.WriteLine("Для клиента " + SessionLog[i].FullName);
                for (int j = 0; j < n; j++)
                {
                    int numWash = rnd.Next(0, 4);
                    if (numWash == 0)
                    {
                        var service = new ComplexWash(client, staff1, client.TimeVisit);
                        service.DoWork();
                        service.Message();
                    }
                    else if (numWash == 1)
                    {
                        var service = new ExpressWash(client, staff2, client.TimeVisit);
                        service.DoWork();
                        service.Message();
                    }
                    else if (numWash == 2)
                    {
                        var service = new ManualWash(client, staff3, client.TimeVisit);
                        service.DoWork();
                        service.Message();
                    }
                    else if (numWash == 3)
                    {
                        var service = new OutdoorSink(client, staff4, client.TimeVisit);
                        service.DoWork();
                        service.Message();
                    }
                }
               
            }
            Console.WriteLine();
            Console.WriteLine("_____Количество работы выполненой сотрудниками автомойки_____");
            Console.WriteLine();
            staff1.DoWork();
            Console.WriteLine();
            staff2.DoWork();
            Console.WriteLine();
            staff3.DoWork();
            Console.WriteLine();
            staff4.DoWork();
            Console.WriteLine();
            Console.WriteLine("_______________Сумма, потраченная посетителем:_______________");
            Console.WriteLine();
            SessionLog[0].SpendKash();

            Console.ReadLine();

            
        }
    }
}
