using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ConsoleApp1
{
    class Program
    {

        private class Student
        {
            public string fio;
            public int s1;
            public int s2;
            public int s3;

            public Student(String fio, int s1, int s2, int s3)
            {
                this.fio = fio;
                this.s1 = s1;
                this.s2 = s2;
                this.s3 = s3;
            }
            
        }

        static void Main(string[] args) {

            string subj1 = "Предмет1";
            string subj2 = "Предмет2";
            string subj3 = "Предмет3";

            List<Student> students = new List<Student>();
            students.Add(new Student("Лукашенко Андрей Андреевич", 5, 5, 5));
            students.Add(new Student("Хандрыга Митяй Митяевич", 3, 2, 2));

            bool start = true;
            Console.WriteLine("Добро пожаловать в программу!");
            Console.WriteLine();
            while (start)
            {
                int choose;
                Console.WriteLine("1. Ввести данные нового студента");
                Console.WriteLine("2. Изменить данные студента");
                Console.WriteLine("3. Вывести список всех студентов");
                Console.WriteLine("4. Вывести список студентов с отличными оценками");
                Console.WriteLine("5. Ввести список студентов которые имеют хотя бы одну плохую оценку");
                Console.WriteLine("6. Выйти с программы");
                choose = int.Parse(Console.ReadLine());

                if (choose == 1)
                {
                    string tempname;
                    int tempmark1, tempmark2, tempmark3;
                    Console.WriteLine("Введите ФИО студента: ");
                    tempname = Console.ReadLine();
                    Console.WriteLine("Введите оценку студента с предмета {0}: ", subj1);
                    tempmark1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите оценку студента с предмета {0}: ", subj2);
                    tempmark2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите оценку студента с предмета {0}: ", subj3);
                    tempmark3 = int.Parse(Console.ReadLine());
                    students.Add(new Student(tempname, tempmark1, tempmark2, tempmark3));
                    Console.WriteLine("Студент {0} успешно добавлен в список!", tempname);
                    continue;
                }

                if (choose == 2)
                {
                    int i = 0;
                    Console.WriteLine("Кого из этих студентов требуется отредактировать?" + "\n");
                    foreach (Student s in students)
                    {
                        i = i + 1;
                        Console.WriteLine("{0}. " + s.fio, i);
                    }
                    int vyb;
                    vyb = int.Parse(Console.ReadLine());
                    vyb = vyb - 1;
                    students.RemoveAt(vyb);
                    string tempname;
                    int tempmark1, tempmark2, tempmark3;
                    Console.WriteLine("Отредактируйте ФИО студента: ");
                    tempname = Console.ReadLine();
                    Console.WriteLine("Отредактируйте оценку студента с предмета {0}: ", subj1);
                    tempmark1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Отредактируйте оценку студента с предмета {0}: ", subj2);
                    tempmark2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Отредактируйте оценку студента с предмета {0}: ", subj3);
                    tempmark3 = int.Parse(Console.ReadLine());
                    students.Add(new Student(tempname, tempmark1, tempmark2, tempmark3));
                    Console.WriteLine("Студент {0} успешно отредактирован и добавлен в список!", tempname);
                    continue;
                }

                if (choose == 3)
                {
                    foreach (Student s in students)
                    {
                        Console.WriteLine();
                        Console.WriteLine(s.fio + "\n");
                        Console.WriteLine("Оценка с предмета {0}: {1}", subj1, s.s1);
                        Console.WriteLine("Оценка с предмета {0}: {1}", subj2, s.s2);
                        Console.WriteLine("Оценка с предмета {0}: {1}", subj3, s.s3);
                        Console.WriteLine();
                    }
                    continue;
                }

                if (choose == 4)
                {

                    foreach (Student s in students)
                    {
                        if (s.s1 >= 4 && s.s2 >= 4 && s.s3 >= 4)
                        {
                            Console.WriteLine();
                            Console.WriteLine(s.fio + "\n");
                            Console.WriteLine("Оценка с предмета {0}: {1}", subj1, s.s1);
                            Console.WriteLine("Оценка с предмета {0}: {1}", subj2, s.s2);
                            Console.WriteLine("Оценка с предмета {0}: {1}", subj3, s.s3);
                            Console.WriteLine();
                        }
                    }
                    continue;
                }

                if (choose == 5)
                {
                    foreach (Student s in students)
                    {
                        if (s.s1 < 4 || s.s2 < 4 || s.s3 < 4)
                        {
                            Console.WriteLine();
                            Console.WriteLine(s.fio + "\n");
                            Console.WriteLine("Оценка с предмета {0}: {1}", subj1, s.s1);
                            Console.WriteLine("Оценка с предмета {0}: {1}", subj2, s.s2);
                            Console.WriteLine("Оценка с предмета {0}: {1}", subj3, s.s3);
                            Console.WriteLine();
                        }
                    }
                    continue;
                }

                if (choose == 6)
                {
                    Console.WriteLine("Осуществляем выход с программы...");
                    break;
                }

                else
                {
                    Console.WriteLine("Введено неверное значение!");
                    continue;
                }

            }
        }
    }
}
                