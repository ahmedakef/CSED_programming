using System;
using System.IO;

namespace _6th_assignment_CRUD_using_file_
{
    class Student {
        public static int id = 0;
        public string name;
        public string email;
        public int phone;
        public string major;
        public int gender;

        public Student(string name,string email,int phone,string major,int gender){
            id++;
            this.name = name;
            this.email =email;
            this.phone = phone;
            this.major = major;
            this.gender = gender;
        }
    }
    static class CRUD {
        public static void insert(Student student){
            try{
                StreamWriter sw = new StreamWriter("student.csv",true);
                sw.WriteLine(Student.id + "," + student.name + "," + student.email + "," + student.phone + "," + student.major + "," + student.gender);
                sw.Close();
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("File already in use, please close if open in another program");
                return;
            }

        }
        public static string select(string name){
            string[] lines = File.ReadAllLines("student.csv");
            int n = lines.Length;
            for (int i = 0; i < n; i++)
            {
                string[] line = lines[i].Split(',');
                if(line[1] == name){
                    return lines[i];
                }
            }
            return "";
        }
        public static void select_All(){
            Console.WriteLine("\n\n\n ========= \n All lines \n ========= \n");
            string[] lines = File.ReadAllLines("student.csv");
            int n = lines.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
        public static void update(string name,string field,string value){
            string[] ret = CRUD.select(name).Split(',');
            string[] fields = {"id","name","email","phone","major","gender"};
            int f = Array.IndexOf(fields,field);
            ret[f] = value;
            string[] lines = File.ReadAllLines("student.csv");
            lines[Convert.ToInt32(ret[0])-1] = ret[0]+","+ret[1]+","+ret[2]+","+ret[3]+","+ret[4]+","+ret[5];
            File.WriteAllLines("student.csv",lines);
        }
        public static void Delete(string name){
            string[] ret = CRUD.select(name).Split(',');
            string[] lines = File.ReadAllLines("student.csv");
            int n = lines.Length;
            for (int i = Convert.ToInt32(ret[0])-1; i < n-1; i++)
            {
                lines[i]=lines[i+1];
            }
            lines[n-1]="";
            File.WriteAllLines("student.csv",lines);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student ahmed = new Student("ahmed","ahmed@akef.com",0100254585,"CSED",1);
            CRUD.insert(ahmed);
            Student salama = new Student("salama","salama@akef.com",0100254585,"CSED",1);
            CRUD.insert(salama);
            string stu_salama = CRUD.select("salama");
            Console.WriteLine(stu_salama);
            CRUD.update("ahmed","email","aemed.akef.1@gmail.com");
            string stu_ahmed = CRUD.select("ahmed");
            Console.WriteLine(stu_ahmed);
            Student balha = new Student("balha","balha@akef.com",0100854585,"CSED",1);
            CRUD.insert(balha);
            Student Ali = new Student("Ali","Ali@akef.com",010256585,"CSED",1);
            CRUD.insert(Ali);
            CRUD.Delete("salama");
            CRUD.select_All();
        }
    }
}
