using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_OOP.Formula1.Entities;

namespace week_5_OOP.Formula1.Business
{
    public class PointAdd
    {
        public void Add(int point,TeamDriver driver)//poanların hesaplandığı class
        {

            driver.Point += point;
            Console.WriteLine(driver.Name + " " + driver.Surname + " puanı eklendi.Puan = " + driver.Point);
            driver.Team.Point += driver.Point;
            Console.WriteLine(driver.Team.Name+" takımının puanı = "+ driver.Team.Point);
        }
        
    }
}
