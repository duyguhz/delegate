using System;
using System.Collections.Generic;

namespace delegatehw
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();

            string student;
            do
            {
                Console.WriteLine("Student daxil edin:");
                student = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(student));

            string pointStr;
            double point;
            do
            {
                Console.WriteLine("Point daxil et:");
                pointStr = Console.ReadLine();
            } while (!double.TryParse(pointStr,out point));

            string sub;
            do
            {
                Console.WriteLine("Subject daxil et:");
                sub = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(sub));

            string examStartingStr;
            DateTime startDate;
            do
            {
                Console.WriteLine("Imtahanin baslama vaxtini qeyd edin:");
                examStartingStr = Console.ReadLine();

            } while (DateTime.TryParse(examStartingStr,out startDate));

            string examEndingStr;
            DateTime endDate;
            do
            {
                Console.WriteLine("Imtahanin bitme vaxtini qeyd edin:");
                examEndingStr = Console.ReadLine();

            } while (DateTime.TryParse(examEndingStr, out endDate));


            
            Exam exam = new Exam()
            {
                Student = student,
                Point = point,
                Subject = sub,
                StartDate = startDate,
                EndDate = endDate
            };
            exams.Add(exam);
            Console.WriteLine("elave olundu");

        }
    }
}
