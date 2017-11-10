using System;

namespace _2nd_lab
{
    class Program
    {
        public static void alpha(string name){
            for(int i=0 ; i<name.Length ; i++){
                if(name[i]==' ')
                    continue;
                Console.Write(name[i]-(int)'a');
                Console.Write(' ');
            }
            

        }
        public static int avr_arr(params int[]  arr){
            int sum=0;
            for(int i=0 ; i<arr.Length ; i++){
                sum += arr[i];
            }

            return sum/arr.Length;

        } 

        public static int biggest(int fst,int snd ){
            int max = fst>snd ?fst : snd;

            return max;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n the first program");
            alpha("ahmed akef");
            
            int avvr = avr_arr(5,3,2);
            Console.WriteLine("\n the second program");
            Console.WriteLine(avvr);

            int bigg = biggest(5,3);
            bigg = biggest(bigg,8);
            Console.WriteLine("\n the third program");
            Console.WriteLine(bigg);
        }
    }
}
