/* by :   ahmed hamed osman akef  */
using System;

namespace hexaToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number in hexaDecimal");
            string hexa = Console.ReadLine();
            
            hexa = hexa.ToUpper();
            int i =1,digit, dec=0;
            int[] values = { 10,11,12,13,14,15 };
            for(int j=hexa.Length -1 ; j >= 0 ; j--){

                digit = Convert.ToInt32(char.GetNumericValue(hexa[j])); 
                
                if(digit == -1){
                    digit = values[(int) hexa[j]-'A'];
                }
                dec += digit * i;
                i*=16; 
            }

            Console.WriteLine("the decimal is : " + dec );
        }
    }
}
