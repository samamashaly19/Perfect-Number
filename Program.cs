using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number_1
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {

            int n, i, sum;
            Console.WriteLine("please enter the first number");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int n2 = int.Parse(Console.ReadLine());
            for(n=n1 ; n<=n2; n++)
            {
                i = 1;
                sum = 0;
                while(i<n)
                {
                    if(n%i==0)
                       sum=sum+i;   
                    i++;

                    
                }
                if(sum==n)
                    Console.WriteLine("{0}",n);
                  
            }


        }
       
    }
}
