using System;
using System.Collections.Generic;

namespace _21_02_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime fromDate = new DateTime(2023, 2, 1, 14, 30, 0);
            DateTime toDate = new DateTime(2023, 2, 10, 8, 0, 0);

            var diff = toDate - fromDate;

            Console.WriteLine(diff);
            Console.WriteLine(diff.Days);
            Console.WriteLine(diff.Hours);
            Console.WriteLine(diff.Minutes);


            Console.WriteLine(diff.TotalDays);
            Console.WriteLine(diff.TotalHours);
            Console.WriteLine(diff.TotalMinutes);

            Student std=new Student();
            std.Exams.Add(new Exam { Subject = "Programming 1", Point= 30, StartAt = new DateTime(2020, 10, 10, 10, 0, 0), FinishAt = new DateTime(2020, 10, 10, 11, 15, 0) });
            std.Exams.Add(new Exam { Subject = "Programming 3", Point = 64, StartAt = new DateTime(2020, 10, 11, 9, 0, 0), FinishAt = new DateTime(2020, 10, 11, 14, 0, 0) });
            std.Exams.Add(new Exam { Subject = "Programming 3", Point = 54, StartAt = new DateTime(2020, 10, 12, 14, 30, 0), FinishAt = new DateTime(2020, 10, 12, 15, 0, 0) });

            Console.WriteLine(std.GetTotalExamMinutes());


            Console.WriteLine("==========================================================");
            Dictionary<string, double> products = new Dictionary<string, double>();

            //Student student = new Student();
           
            //student.Exams.Add(new Exam { Point=20});
            //student.Exams.Add(new Exam { Point = 60 });

            //Console.WriteLine(student.GetAvgPoint());



            //string opt;
            //    do
            //    {
            //        Console.WriteLine("1. Mehsul elave et");
            //        Console.WriteLine("2. Butun mehsullara bax");
            //        Console.WriteLine("3. Secilmis mehsula bax");
            //        Console.WriteLine("0. Cix");

            //        Console.WriteLine("\nSecim edin:");
            //        opt = Console.ReadLine();

            //        switch (opt)
            //        {
            //            case "1":
            //                string name;

            //                Console.Write("Product name: ");
            //                name = Console.ReadLine();

            //                if (products.ContainsKey(name))
            //                {
            //                    Console.WriteLine($"{name} adli mehsul elave edilib");
            //                    break;
            //                }


            //                double price;

            //                do
            //                {
            //                    Console.Write("Product price: ");
            //                } while (!double.TryParse(Console.ReadLine(), out price));

            //                products.Add(name, price);
            //                break;
            //            case "2":
            //                foreach (var item in products)
            //                    Console.WriteLine(item.Key + " - " + item.Value);
            //                break;
            //            case "3":
            //                Console.Write("Product name: ");
            //                name = Console.ReadLine();

            //                if (!products.ContainsKey(name))
            //                {
            //                    Console.WriteLine($"{name} adli mehsul yoxdur. Yeni mehsul elave etmek isteyirsinizmi? (y/n)");
            //                    string cuuss = Console.ReadLine();

            //                    if (cuuss == "y")
            //                        goto case "1";

            //                    break;
            //                }

            //                Console.WriteLine(name + " - " + products[name]);
            //                break;
            //            case "0":
            //                Console.WriteLine("Proqram bitdi");
            //                break;
            //            default:
            //                Console.WriteLine("Seciminiz yanlisdir!");
            //                break;
            //        }

            //    } while (opt != "0");

            Console.WriteLine("======================ikinci Task=====================");

            List<Student> students = new List<Student>();



            string option;
            do
            {
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Butun telebelere bax");
                Console.WriteLine("3. Telebelerin ortalamasina bax");
                Console.WriteLine("0. Emelyati bitir");

                Console.WriteLine("\nSecim edin:");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":

                        Console.Write("FullName: ");
                        string fullname = Console.ReadLine();
                        Console.Write("GroupNo: ");
                        string groupNo = Console.ReadLine();

                        byte point;
                        string pointStr;
                        do
                        {
                            Console.WriteLine("Point: ");
                            pointStr= Console.ReadLine();

                        } while (!byte.TryParse(pointStr,out point));



                        Student std1 = new Student
                        {
                            FullName = fullname,
                            Group = groupNo,
                            Point = point
                        };

                        students.Add(std1);
                        break;
                    case "2":
                        foreach (var item in students)
                        {
                            Console.WriteLine($"{item.FullName} - {item.Group} - {item.Point}");
                        }
                            
                        break;
                    case "3":

                        if (students.Count == 0)
                        {
                            Console.WriteLine("Telebe yoxdur!");
                            break;
                        }
                        double sum = 0;
                        foreach (var item in students)
                        {
                            sum += item.Point;
                        }

                        Console.WriteLine(sum / students.Count);

                        break;
                    case "0":
                        Console.WriteLine("Program bitdi");
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir");
                        break;
                }

            } while (option != "0");


        }
    } 
}
