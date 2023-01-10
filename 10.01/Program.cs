using System;
using System.Collections;
using System.Collections.Generic;

namespace _10._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentsApp<string, int> students = new StudentsApp<string, int>();

            students.Add("Hikmet", 18);
            students.Add("Nermin", 20);
            students.Add("Farid", 35);
            students.Add("Tofiq", 45);
           students.Remove("unvan1");

            StudentsApp<string, string> data = new StudentsApp<string, string>();
            data.Add("unvan1", "+9945045");
            data.Add("unvan2", "+99455565");
            data.Add("unvan4", "+994551568");
            data.Add("unvan5", "+994551546");
            Console.WriteLine(data.GetValue("Nermin"));

            Queue key = new Queue();
            key.Enqueue("students1");
            key.Enqueue("students2");
            key.Enqueue("students3");
            key.Enqueue("students4");
            foreach (var item in key)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(key.Peek());

            SortedList<string, int> data4 = new SortedList<string, int>();
            
            data4.Add("students1", 18);
            data4.Add("students2", 25);
            data4.Add("students3", 32);
            data4.Add("students4", 45);
            foreach (var item in data4)
            {
                Console.WriteLine( item.Value);
            }
            foreach (var item in data4)
                Console.Write(item); 


            Dictionary<string, int> students1 = new Dictionary<string, int>();
            students.Add("students", 45);
            students.Add("student1", 85);
            students.Add("student4", 65);

            Console.WriteLine(students1.TryAdd("Hikmet", 55));



            foreach (var item in students1)
            {
                if (item.Value > 45)
                {
                    Console.WriteLine(item.Key + " - " + item.Value);
                }
            }


            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

           
            //StudentsApp<string> groupno = new StudentsApp<string>(); *****

            //groupno.Add1("students1");
            //groupno.Add1("students2");
            //groupno.Add1("students3");
            //groupno.Add1("students4");


        }
    }
}
