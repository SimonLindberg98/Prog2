using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Läxa_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee emp = new HourlyEmployee();

            Console.Write("\nMata in namn:\t");
            emp.name = Console.ReadLine();

            Console.Write("\nMata in timlön:\t");
            emp.hourlyWage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            String input;
            for (int i = 0; i < 5; i++)
            {
                emp.dailyWorkTime[i] = new Time();

                Console.Write("Arbetstid " + "dag " + (i + 1) + " i veckan (tim mellanslag min):\t");
                input = Console.ReadLine();
                emp.dailyWorkTime[i].hour = Convert.ToInt32(input.Substring(0, 1));
                emp.dailyWorkTime[i].min = Convert.ToInt32(input.Substring(2, 2));
            }

            emp.Salary();
            Console.WriteLine();
            Console.WriteLine(emp.Output());
            Console.WriteLine();
        }

        class Time
        {
            public int hour, min;                   //Datamedlemmar

            public Time Sum(Time t)                 //Metod som tar in en Time,
            {                                       //adderar den med klassens 
                Time temp = new Time();             //data och returnerar
                temp.min = (min + t.min) % 60;      //summan som Time
                temp.hour = (hour + t.hour) + (min + t.min) / 60;
                return temp;
            }

            public double ToDecimal()               //Metod som omvandlar
            {                                       //tiden till decimaltal
                return (60 * hour + min) / 60.0;    //60.0 påtvingar double
            }
        }

        class HourlyEmployee
        {
            public String name;
            public double hourlyWage, weeklyWage, control;
            public Time weeklyTime;
            public Time[] dailyWorkTime = new Time[5];

            public void Salary()
            {
                weeklyTime = dailyWorkTime[0];
                for (int i = 0; i < 5; i++)
                    weeklyTime = weeklyTime.Sum(dailyWorkTime[i]);
                weeklyWage = weeklyTime.ToDecimal() * hourlyWage;

                double decimalSum = 0;
                for (int j = 0; j < 5; j++)
                    decimalSum += dailyWorkTime[j].ToDecimal();
                control = decimalSum * hourlyWage;
            }

            public String Output()
            {
                return "Den anställda " + name + '\n' +
                       "har arbetat denna vecka:\t" + weeklyTime.hour +
                       " timmar och " + weeklyTime.min + " minuter" +
                       "\n\nVeckolönen är\t\t\t" + weeklyWage.ToString("c") +
                       "\n\nKontrollräkning:\t\t" + control.ToString("c");
            }
        }
    }
}
