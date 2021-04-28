using System;
namespace CsharpIntermediateLevel
{
    class Student
    {
        public int Id;
        public string Name;
        public Student()
        {

        }
        public Student(int id)
        {
            this.Id = id;

        }
        public Student(int val, string name)
        {
            this.Id = val;
            this.Name = name;
        }
    }

    class program
    {
        public static void Main(String[] args)
        {
            Student s1 = new Student();
            s1.Id = 2;
            s1.Name = "sai";
            Student s2 = new Student(1, "mahesh");
            Console.WriteLine(s2.Id);
            Console.WriteLine(s2.Name);
        }
    }
}
