using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of nums
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942, 13, 17, 88 };

            //List of student objects
            List<Student> students = new List<Student>();

            //student objects added to list
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justine", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Philip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            //---------------------- Nunbers Collection ----------------------
            Console.WriteLine("-------- Numbers Collection --------");
            //question 1: Find Minimum Value
            double minValue = nums.Min();
            Console.WriteLine("1) Minimum value: " + minValue);

            //question 2: Find Maximum Value
            double maxValue = nums.Max();
            Console.WriteLine("2) Max value: " + maxValue);

            //question 3: Find the maximum value less then 10000
            List<int> under10k = nums.Where(x => x < 10000).ToList();
            int numUnder10k = under10k.Max();
            Console.WriteLine("3) Max value under 10k: " + numUnder10k);

            //question 4: Find all values between 10 and 100
            List<int> between10an100 = nums.Where(x => x < 100 && x > 10).ToList();
            Console.WriteLine("4) All values between 10 and 100: ");
            foreach(int num in between10an100)
            {
                Console.Write(num +", ");
            }

            Console.WriteLine();
            //question 5: Find all values between 10000 and 999999 inclusive
            List<int> bewtween10kand99k = nums.Where(x => x >= 10000 && x <= 999999).ToList();
            Console.WriteLine("5) All values between 10,0000 an 999,999");
            foreach(int num in bewtween10kand99k)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();
            //question 6: Count all even numbers
            List<int> evenNums = nums.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("6) All even numbers: ");
            foreach(int num in evenNums)
            {
                Console.Write(num + ", ");
            }


            Console.WriteLine();
            Console.WriteLine();
            //---------------------- Students Collection ----------------------
            Console.WriteLine("-------- Students Collection --------");
            //question 1: Find all students age of 21 and over
            List<Student> over21 = students.Where(x => x.Age >= 21).ToList();
            Console.WriteLine("1) All students over 21");
            foreach(Student s in over21)
            {
                Console.WriteLine(s.Name);
            }

            //question 2: Find oldest student
            int oldest = students.Max(x => x.Age);
            Console.WriteLine("2) The oldest Student is: " + oldest);

            //question 3: Find the youngest student
            int youngest = students.Min(x => x.Age);
            Console.WriteLine("3) The youngest student is: " + youngest);

            //question 4: Find the oldest student under the age of 25
            List<Student> studentsUnder25 = students.Where(x => x.Age < 25).ToList();
            int oldestUnder25 = studentsUnder25.Max(x => x.Age);
            Console.WriteLine("4) The oldest student under 25 is: " + oldestUnder25);

            //question 5 Find all sutdents over 21 with even ages
            List<Student> older21Even = students.Where(x => x.Age > 21 && x.Age % 2 == 0).ToList();
            Console.WriteLine("5) Students over 21 with even age: ");
            foreach(Student s in older21Even)
            {
                Console.WriteLine($"{s.Name}, {s.Age}");
            }

            //question 6: Find all teenage Students (13 - 19 inclusive)
            List<Student> teenager = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            Console.WriteLine("6) All teenager: ");
            foreach(Student s in teenager)
            {
                Console.WriteLine($"{s.Name}, {s.Age}");
            }

            //question 7: Find all students whose name starts with a vowel -- a,e,i,o,u
            List<Student> nameHasVowel = students.Where(x => x.Name.ToLower().StartsWith('a') || x.Name.ToLower().StartsWith('u')
                || x.Name.ToLower().StartsWith('o') || x.Name.ToLower().StartsWith('e') || x.Name.ToLower().StartsWith('i')).ToList();
            Console.WriteLine("7) All names that start a vowel: ");
            foreach (Student s in nameHasVowel)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
