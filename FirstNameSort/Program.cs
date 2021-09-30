using System;
using System.Collections.Generic;

namespace FirstNameSort
{
    public delegate List<string> MethodContainer(List<string> list);
    class Program
    {
        public event MethodContainer JustGo;
        public event MethodContainer JustGoUnsort;

        static void Main(string[] args)
        {
            Program prog = new Program();
            List<string> firstName = new List<string>();

            firstName.Add("Сидоров");
            firstName.Add("Петров");
            firstName.Add("Антонов");
            firstName.Add("Павлов");
            firstName.Add("Тростников");

            prog.JustGo += prog.SortFirstName;
            prog.JustGoUnsort += prog.UnsortFirstName;

            int number;

            try
            {
                int.TryParse(Console.ReadLine(), out number);

                if (number == 1)
                {
                    prog.JustGo(firstName);
                }
                if (number == 2)
                {
                    prog.JustGoUnsort(firstName);
                }                
            }
            catch (FormatException ex)
            {
                if (ex is FormatException)
                {
                    Console.WriteLine("Введите цифры 1/2");
                    Console.WriteLine(ex.Message);                    
                }
            }
            catch (MoreTwoException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                foreach (var person in firstName)
                {
                    Console.WriteLine(person);
                }
            }           

        }
        public List<string> SortFirstName(List<string> users)
        {
            users.Sort();
            return users;            
        }

        public List<string> UnsortFirstName(List<string> users)
        {
            users.Sort();
            users.Reverse();
            return users;
        }
    }
}
