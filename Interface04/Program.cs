using Entitites;
using System;
using System.Collections.Generic;
using System.IO;

namespace Interface04 {
    class Program {
        static void Main(string[] args) {
            string path = @"D:\Estagio\ws-vs2019\Projetos\Section 14 - Interfaces\Projetos\Interface04\in.txt";
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee employee in list) {
                        Console.WriteLine(employee);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
