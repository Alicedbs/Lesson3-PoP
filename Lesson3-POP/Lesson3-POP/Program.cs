using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_POP
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            //task4_2();
            //task5();
            Task5();
            Console.ReadKey();
        }

        static void task1()
        {
            Console.WriteLine("write the size of the first side of the triangle: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write the size of the second side of the triangle: ");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write the size of the thrid side of the triangle: ");
            int side3 = Convert.ToInt32(Console.ReadLine());
            string answer = "";
            if ((side1 == side2 || side2 == side3 || side1 == side3))
            {
                if (side1 == side2 && side2 == side3 && side1 == side3)
                {
                    Console.WriteLine("Three of the sides are equals, the triangle is equilateral");
                }
                if (side1 == side2) { answer = " side 1 and 2 are equals"; }
                if (side1 == side3) { answer = " side 1 and 3 are equals"; }
                if (side3 == side2) { answer = " side 2 and 3 are equals"; }

                else { Console.WriteLine("The triangle is isoscele" + answer); }
            }
            else { Console.WriteLine("The triangle is normal, none of the sides are equals"); }
        }

        static void task2()
        {
            int sum = 0;
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Give a number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 10 && number <= 20)
                {
                    numbers.Add(number);
                }
            }
            Console.WriteLine("The numbers between 10 and 20 are :");
            foreach (int a in numbers)
            {
                Console.WriteLine(a);
                sum += a;
            }
            Console.WriteLine("The sum of the numbers between 10 and 20 is: " + sum);
        }

        static void task3()
        {
            Console.WriteLine("enter your height in centimeter: ");
            int height = Convert.ToInt32(Console.ReadLine());
            if (height >= 175 && height <= 190)
            {
                Console.WriteLine("Athletic");
            }
            else if (height < 175)
            {
                Console.WriteLine("Horse Riding");
            }
            else { Console.WriteLine("Basketball"); }

        }

        static void task4()
        {
            Console.WriteLine("enter a number between 1 and 7 which reprenset the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());
            string dayName = "";
            switch (day)
            {
                case 1: dayName = ("Monday"); break;
                case 2: dayName = ("Tuesday"); break;
                case 3: dayName = ("Wednesday"); break;
                case 4: dayName = ("Thursday"); break;
                case 5: dayName = ("Friday"); break;
                case 6: dayName = ("Saturday"); break;
                case 7: dayName = ("Sunday"); break;
                default: Console.WriteLine("Error!"); break;
            }

            Console.WriteLine("enter a number between 1 and 23 which reprenset the time of the day: ");
            int time = Convert.ToInt32(Console.ReadLine());
            string dayTime = "";

            switch (time)
            {
                case 6: case 7: case 8: case 9: case 10: case 11: case 12: dayTime = ("good morning"); break;
                case 13: case 14: case 15: case 16: case 17: case 18: dayTime = ("good afternoon"); break;
                case 19: case 20: case 22: case 23: case 1: case 2: case 3: case 4: case 5: dayTime = ("good night"); break;
                default: Console.WriteLine("Error!"); break;
            }

            int comingWeekend = 7 - day;
            string weekEnd = "";
            switch (comingWeekend)
            {
                case 0: case 1: weekEnd = ("Weekend is here !"); break;
                case 2: weekEnd = ("Weekend is tomorrow !"); break;
                case 3: weekEnd = ("Weekend is in 2 days !"); break;
                case 4: weekEnd = ("Weekend is in 3 days !"); break;
                case 5: weekEnd = ("Weekend is in 4 days !"); break;
                case 6: weekEnd = ("Weekend is in 5 days !"); break;
            }

            Console.WriteLine(dayTime + " it is a lovely " + dayName + " today." + weekEnd);
        }

        static void task4_2()
        {
            DateTime date = DateTime.Now;
            int hour = date.Hour;

            string dayName = date.ToString("dddd");

            string dayTime = "";

            switch (hour)
            {
                case 6: case 7: case 8: case 9: case 10: case 11: case 12: dayTime = ("good morning"); break;
                case 13: case 14: case 15: case 16: case 17: case 18: dayTime = ("good afternoon"); break;
                case 19: case 20: case 22: case 23: case 1: case 2: case 3: case 4: case 5: dayTime = ("good night"); break;
                default: Console.WriteLine("Error!"); break;
            }

            int day = (int)date.DayOfWeek;
            int comingWeekend = 7 - day;
            string weekEnd = "";
            switch (comingWeekend)
            {
                case 0: case 1: weekEnd = ("Weekend is here !"); break;
                case 2: weekEnd = ("Weekend is tomorrow !"); break;
                case 3: weekEnd = ("Weekend is in 2 days !"); break;
                case 4: weekEnd = ("Weekend is in 3 days !"); break;
                case 5: weekEnd = ("Weekend is in 4 days !"); break;
                case 6: weekEnd = ("Weekend is in 5 days !"); break;
            }

            Console.WriteLine(dayTime + " it is a lovely " + dayName + " today." + weekEnd);
        }

        //Homework task5


        static void Task5()
        {
            bool check = false;
            string firstName = "";
            string lastName = "";
            int intYear = 0;
            int intMonth = 0;
            int intDay = 0;

            string id = "";
            string yearID = "";
            string ffID = "";
            string ssID = "";
            string nnnnID = "";

            DateTime todayDate = new DateTime();
            todayDate = DateTime.Now;

            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your first name : ");
                firstName = Console.ReadLine();
                if (firstName.Length > 100) Console.WriteLine("Error : limit is 100 char");
                else
                {
                    check = true;
                }
            }

            check = false;
            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your last name : ");
                lastName = Console.ReadLine();
                if (lastName.Length > 100) Console.WriteLine("Error : limit is 100 char");
                else
                {
                    check = true;
                }
            }

            check = false;
            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your year of birth : ");
                string year = Console.ReadLine();

                if (IsOnlyDigits(year) == false)
                {
                    Console.WriteLine("Error : please enter digits only");
                }
                else
                {
                    intYear = int.Parse(year);
                    if (todayDate.Year - intYear > 100)
                    {
                        Console.WriteLine("Error : wrong input : input is " + year + ", and date is " + todayDate.Year);
                    }
                    else
                    {
                        check = true;
                    }
                }
            }

            check = false;
            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your month of birth : ");
                string month = Console.ReadLine();
                if (IsOnlyDigits(month) == false) Console.WriteLine("Error : please enter digits only");
                else
                {
                    check = true;
                    intMonth = int.Parse(month);
                }
            }

            check = false;
            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your day of birth : ");
                string day = Console.ReadLine();
                if (IsOnlyDigits(day) == false) Console.WriteLine("Error : please enter digits only");
                else
                {
                    check = true;
                    intDay = int.Parse(day);
                }
            }
            DateTime birth = new DateTime(intYear, intMonth, intDay);

            check = false;
            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your student number : ");
                id = Console.ReadLine();
                if (IsOnlyDigits(id) == false || id.Length != 12) Console.WriteLine("Error : please enter digits only");

                else
                {
                    check = true;

                    if (id[4] != '0') check = false;
                    if (id[6] != '0') check = false;
                    if (IsOnlyDigitsTo5(id[7]) == false) check = false;

                    if (check == true)
                    {
                        for (int i = 0; i <= 11; i++)
                        {
                            if (i <= 3)
                            {
                                yearID += id[i];
                            }
                            if (i == 4 || i == 5)
                            {
                                ffID += id[i];
                            }
                            if (i == 6 || i == 7)
                            {
                                ssID += id[i];
                            }
                            if (i > 7)
                            {
                                nnnnID += id[i];
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("First name is " + firstName);
            Console.WriteLine("Last name is " + lastName);
            Console.WriteLine("Date of birth is " + birth.Day + "/" + birth.Month + "/" + birth.Year);


            Console.WriteLine("Student number is " + id + " with year = " + yearID + ", faculty code = " + ffID + ", specialty code = " + ssID + ", specialty = " + nnnnID);
            Console.ReadKey();
        }

        static bool IsOnlyDigits(string n)
        {
            foreach (char c in n)
            {
                if (c < '0' || c > '9') return false;
            }
            return true;
        }
        static bool IsOnlyDigitsTo5(char n)
        {
            bool check = true;
            if (n < '0' || n > '5') check = false;

            return check;
        }
    }
}

