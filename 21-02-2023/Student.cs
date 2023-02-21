using System;
using System.Collections.Generic;
using System.Text;

namespace _21_02_2023
{
    internal class Student
    {
        public string FullName;
        public string Group;
        public byte Point;
        //public Dictionary<string, byte> Exams = new Dictionary<string, byte>();
        public List<Exam> Exams = new List<Exam>();


        //public double GetAvgPoint()
        //{
        //    double sum = 0;
        //    foreach (var item in Exams)
        //    {
        //        sum += item.Point;
        //    }

        //    return sum / Exams.Count;
        //}

        public List<Exam> GetExamsByPointRange(byte minPoint, byte maxPoint)
        {
            List<Exam> wantedExams = new List<Exam>();

            foreach (var item in Exams)
            {
                if (item.Point >= minPoint && item.Point <= maxPoint)
                    wantedExams.Add(item);
            }

            return wantedExams;
        }

        public List<Exam> GetExamsByDateRange(DateTime fromDate, DateTime toDate)
        {
            List<Exam> wantedExams = new List<Exam>();

            foreach (var item in Exams)
            {
                if (item.StartAt >= fromDate && item.FinishAt <= toDate)
                    wantedExams.Add(item);
            }

            return wantedExams;
        }

        public double GetTotalExamMinutes()
        {
            double totalMinutes = 0;
            foreach (var item in Exams)
            {
                var diff = item.FinishAt - item.StartAt;
                totalMinutes += diff.TotalMinutes;
            }

            return totalMinutes;
        }
    }
}
