using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppLinq
{
    public class ClassName
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
        public int NameClass { get; set; }
        public int Rating1 { get; set; }
        public int Rating2 { get; set; }
        public int Rating3 { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var className = new List<ClassName>()
            {
                new ClassName()
                {
                    Id = 1,
                    Name = "Радуга"
                },
                new ClassName()
                {
                    Id = 2,
                    Name = "Мудрі"
                },
                new ClassName()
                {
                    Id = 3,
                    Name = "Ковбой"
                },
                new ClassName()
                {
                    Id = 4,
                    Name = "Садочок"
                },
                new ClassName()
                {
                    Id = 5,
                    Name = "Геймери"
                },
            };

            var students = new List<Student>()
            {
                new Student()
                {
                    Name = "Петро Паращак",
                    NameClass = 1,
                    Rating1 = 4,
                    Rating2 = 3,
                    Rating3 = 4
                },
                new Student()
                {
                    Name = "Олександр Яцик",
                    NameClass = 2,
                    Rating1 = 5,
                    Rating2 = 5,
                    Rating3 = 5
                },
                new Student()
                {
                    Name = "Станіслав Булеца",
                    NameClass = 3,
                    Rating1 = 3,
                    Rating2 = 5,
                    Rating3 = 4
                },
                new Student()
                {
                    Name = "Владислав Гаврилешко",
                    NameClass = 4,
                    Rating1 = 2,
                    Rating2 = 3,
                    Rating3 = 2
                },
                new Student()
                {
                    Name = "Владислав Готра",
                    NameClass = 5,
                    Rating1 = 2,
                    Rating2 = 2,
                    Rating3 = 5
                }
            };

            var s = students[1];


            // вивести інформацію про всіх студентів
            var info = students
                .Join(className,
                    s => s.NameClass,
                    c => c.Id,
                    (s, c) => new 
                    {
                        Name = s.Name,
                        NameClass = c.Name,
                        Rating1 = s.Rating1,
                        Rating2 = s.Rating2,
                        Rating3 = s.Rating3
                    });

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(info));


            Console.ReadKey();
        }
    }
}
