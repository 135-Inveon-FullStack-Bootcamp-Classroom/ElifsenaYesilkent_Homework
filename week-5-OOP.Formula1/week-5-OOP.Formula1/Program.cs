using System;
using week_5_OOP.Formula1.Entities;

namespace week_5_OOP.Formula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Team1 = new Team()
            {
                Id = 1,
                Name ="Ferrari",
                EngineName ="Ferrari"
            };
            var Team2 = new Team()
            {
                Id = 2,
                Name = "Mercedes",
                EngineName = "Mercedes-AMG"
            };
            var Team3 = new Team()
            {
                Id = 3,
                Name = "Red bull",
                EngineName = "Honda"
            };
            Console.WriteLine(Team3.Name);

            var Driver1 = new TeamDriver() {Id=1,Name= "Charles",Surname= "Leclerc",CarNo=16,Point=0,Team=Team1};
            var Driver2 = new TeamDriver() { Id = 2, Name = "Carlos", Surname = " Sainz", CarNo = 55, Point = 0, Team = Team1 };
            var Driver3 = new TeamDriver() { Id = 3, Name = "Max", Surname = "Verstappen", CarNo = 33, Point = 0, Team = Team3 };
            var Driver4= new TeamDriver() { Id = 4, Name = "Sergio", Surname = "Perez", CarNo = 11, Point = 0, Team = Team3 };
            var Driver5 = new TeamDriver() { Id = 5, Name = "Lewis", Surname = "Hamilton", CarNo = 44, Point = 0, Team = Team2 };
            var Driver6 = new TeamDriver() { Id=6,Name="Valtteri",Surname="Bottas",CarNo=77,Point=0,Team=Team2};

            Console.WriteLine(Driver4.Team.Name);
            

          


        }
    }
}
