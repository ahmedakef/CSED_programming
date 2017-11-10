using System;

namespace studentsDregrees
{
    class Program
    {
        string[] names = {"ahmed","ali","mona","khaled","radwan","balha"};
        int[]  degrees = {50,45,40,35,30,5};
        public int get_degree(){
            Console.WriteLine("Enter student name");
            string student_name = Console.ReadLine();
            int idx = Array.IndexOf(names,student_name);
            if( idx != -1 ){
                return degrees[idx];
            }else{
                Console.WriteLine("Enter correct name");
            }
            return 0;
            
        }
        public void Top_student(){
            Console.WriteLine("top student is : {0} and his degree is {1} " , names[0] , degrees[0] );
        }
        public void chane_name(){
            Console.WriteLine("Enter student name");
            string student_name = Console.ReadLine();
            int idx = Array.IndexOf(names,student_name) ;
            if( idx != -1 ){
                Console.WriteLine("Enter new name");
                string new_name = Console.ReadLine();
                names[idx] = new_name;
            }else{
                Console.WriteLine("Enter correct name");
            }

        }
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Please type a number : ");
            Console.WriteLine("1) search for student degree ");
            Console.WriteLine("2) get top student name and degree ");
            Console.WriteLine("3) change student name ");

            int ch = Convert.ToInt32(Console.ReadLine());

            Program p = new Program();

            if(ch==1){
                int degree = p.get_degree();
                Console.WriteLine(degree);
            }else if(ch==2){
                p.Top_student();
            }else if(ch==3){
                p.chane_name();
            }else{
                Console.WriteLine("choose correct number");
            }
        }
    }
}
