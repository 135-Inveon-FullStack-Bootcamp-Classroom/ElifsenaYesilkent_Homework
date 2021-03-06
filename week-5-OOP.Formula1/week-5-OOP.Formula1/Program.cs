using System;
using week_5_OOP.Formula1.Business;
using week_5_OOP.Formula1.Entities;

namespace week_5_OOP.Formula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //takımlar oluşturuldu
            Team Team1 = new Team()
            {
                Id = 1,
                Name = "Ferrari",
                EngineName = "Ferrari",
                Point = 0   
            };
            Team Team2 = new Team()
            {
                Id = 2,
                Name = "Mercedes",
                EngineName = "Mercedes-AMG",
                Point = 0
            };
            Team Team3 = new Team()
            {
                Id = 3,
                Name = "Red bull",
                EngineName = "Honda",
                Point = 0
            };
            //sürücüler oluşturuldu
            TeamDriver Driver1 = new TeamDriver() { Id = 1, Name = "Charles", Surname = "Leclerc", CarNo = 16, Point = 0, Team = Team1 };
            TeamDriver Driver2 = new TeamDriver() { Id = 2, Name = "Carlos", Surname = " Sainz", CarNo = 55, Point = 0, Team = Team1 };
            TeamDriver Driver3 = new TeamDriver() { Id = 3, Name = "Max", Surname = "Verstappen", CarNo = 33, Point = 0, Team = Team3 };
            TeamDriver Driver4 = new TeamDriver() { Id = 4, Name = "Sergio", Surname = "Perez", CarNo = 11, Point = 0, Team = Team3 };
            TeamDriver Driver5 = new TeamDriver() { Id = 5, Name = "Lewis", Surname = "Hamilton", CarNo = 44, Point = 0, Team = Team2 };
            TeamDriver Driver6 = new TeamDriver() { Id=6,Name="Valtteri",Surname="Bottas",CarNo=77,Point=0,Team=Team2};


            //takımlara ve sürücülere puanlar eklendi 
            PointAdd Point1 = new PointAdd();
            Point1.Add(25, Driver3);
            Point1.Add(18, Driver4);
            Point1.Add(18, Driver4);
            Point1.Add(15, Driver5);
            Point1.Add(12, Driver6);
            Point1.Add(10, Driver1);







        }
       
    }
}
