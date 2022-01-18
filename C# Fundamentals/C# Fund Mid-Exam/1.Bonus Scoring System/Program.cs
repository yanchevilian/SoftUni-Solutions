using System;

namespace _1.Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());
            double totalBonus = 0;
            double studentAttendances = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                int attendances = int.Parse(Console.ReadLine());

                double currentStudentBonus = (attendances * 1.0 / countOfLectures * 1.0) * (5 + (initialBonus));

                if (currentStudentBonus > totalBonus)
                {
                    totalBonus = currentStudentBonus;
                    studentAttendances = attendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(totalBonus)}.");
            Console.WriteLine($"The student has attended {studentAttendances} lectures.");

        }
    }
}
