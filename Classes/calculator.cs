using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator1.Classes
{
    public class Person
    {
          public int a;
        public int b;
        public string belgi;


        public void Amallar(){
            if(belgi == "+"){
               System.Console.WriteLine($"{a} + {b} = {a + b}");
            }
            else if(belgi == "-"){
               System.Console.WriteLine($"{a} - {b} = {a - b}");
            }
            else if(belgi == "*"){
                System.Console.WriteLine($"{a} * {b} = {a * b}");
            }
            else if(belgi == "/"){
                System.Console.WriteLine($"{a} / {b} = {a / b}");
            }
            else{
                System.Console.WriteLine("Not found!");
            }
        }
    }
}