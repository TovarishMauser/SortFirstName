using System;
using System.Collections.Generic;
using System.IO;

namespace FirstNameSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exeptions = new Exception[5];               //массив исключений                      

            try
            {
                exeptions[0] = new DivideByZeroException();         //как мне их вызвать в блоке catch?
                exeptions[1] = new FormatException();
                exeptions[2] = new IndexOutOfRangeException();
                exeptions[3] = new FileNotFoundException();
                exeptions[4] = new SomeException();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Divide by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Format exeption!");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Out of range!");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("File not exist!");
            }
            catch (SomeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Some exeption!");
            }
        }
    }
}
