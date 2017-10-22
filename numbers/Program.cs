using System;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "", "one", "two", "three", "four", "five", "six", "seven",
		                    "eight", "nine" };
            string[] b = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen",
		                    "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] c = { "", "ten", "twenty ", "thirty ", "fourty ", "fifty ", "sixty ",
                            "seventy ", "eighty ", "ninty " };
            
            Console.WriteLine("Please enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            string numE = "";
            if(num<10){
                numE = a[num];
            }else if(num < 20  && num != 10){
                numE = b[num%10];
            }else if(num < 100 ){
                numE = c[num/10];
                if(num%10 != 0)
                    numE+= " "+ a[num%10];
            }else {
                numE = a[num/100] + " hundred";
                if(!(num % 100 == 0 && num %10 == 0)){
                    numE += " and ";
                    num = num%100;
                    numE += c[num/10];
                    numE += " " + a[num%10];
                }
            }

            Console.WriteLine(numE);
        }
    }

}
