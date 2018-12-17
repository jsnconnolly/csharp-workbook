using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace week10
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student(1, "John Doe");
            Student jane = new Student(2, "Jane Doe");

            Console.WriteLine(jane);
            Console.WriteLine(john);
        }
    }
    public class Student
    {
        public int id { get; set; }
        public String name { get; set; }

        public Student(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        override
        public string ToString()
        {
            return id + ":" + name;
        }
    }
    public class Context : DbContext
    {
        public DbSet<Student> myStudents { get; set; }
        override
            protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./students.db");

        }


    }
}
