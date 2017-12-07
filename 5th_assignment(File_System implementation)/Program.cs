using System;
using System.Collections.Generic;
namespace _5th_lab
{
    class container {
       public string name;
       public DateTime date_of_last_modified = DateTime.Now ;
       public List<Directory> list_of_dir = new List<Directory>();
       public List<text_file> list_of_textFiles = new List<text_file>();
       public List<binary_file> list_of_binaryFiles = new List<binary_file>();

        public container(string name){
            this.name = name;
        }
        public Directory create_folder(string name) {
            Directory n_dir =  new Directory(name);
            list_of_dir.Add( n_dir );
            this.date_of_last_modified = DateTime.Now;
            return n_dir;
        }
        public text_file new_text_file(string name,string content) {
            text_file n_text_file = new text_file(name,content);
            list_of_textFiles.Add( n_text_file );
            this.date_of_last_modified = DateTime.Now;
            return n_text_file;
        }
        public binary_file new_binary_file(string name,byte[] content) {
            binary_file n_binary_file = new binary_file(name,content);
            list_of_binaryFiles.Add(n_binary_file);
            this.date_of_last_modified = DateTime.Now;
            return n_binary_file;

        }
        public void ls(){
            if(list_of_dir.Count != 0)
                Console.Write("List of directories is  : ");
            foreach (Directory dir in list_of_dir) {
                Console.Write(dir.name + " ");
            }
            Console.WriteLine();
            if(list_of_textFiles.Count != 0)
                Console.Write("List of textFiles is    : ");
            foreach (text_file textfile in list_of_textFiles) {
                Console.Write(textfile.name + " ");
            }
            Console.WriteLine();

            if(list_of_binaryFiles.Count != 0)
                Console.Write("List of binaryFiles is  : ");
            foreach (binary_file binaryfile in list_of_binaryFiles) {
                Console.Write(binaryfile.name + " ");
            }
            Console.WriteLine();
        }
        public virtual void info() {
          Console.WriteLine("container name is {0}", name);
          Console.WriteLine("Date of last modified is {0}", date_of_last_modified.ToString());
        }
        
    }
    class Device :container {
        public string type;
        
        public Device(string name , string type):base(name){
            this.type = type;
        }
        public override void info() {
          base.info();
          Console.WriteLine("Device type is {0}", type);
          Console.WriteLine();
        }

    }
    class Directory :container  {

       public Directory(string name):base(name) {}



    }
    class File  {
       public string name;
       public File(string name) {
           this.name = name;
       }
       DateTime date_of_creation = DateTime.Now ;
    }

    class text_file : File {
       string content;
       
       public text_file(string name ,string content) :base(name){
           this.content = content;
       }

    }


    class binary_file : File {
       byte[] content;
       
       public binary_file(string name ,byte[] content) :base(name){
           this.content = content;
       }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Device HDD = new Device("HDD1","HDD");
            HDD.info();
            Directory games = HDD.create_folder("games");
            HDD.create_folder("cartoon");
            HDD.create_folder("videos");
            HDD.ls();
            Directory need_for_speed = games.create_folder("need for speed");
            need_for_speed.new_binary_file("NFS.exe",new byte[] {0,1,1,1,0,0});
            need_for_speed.new_text_file("Readme.txt","this game is developed by ahmed akef");
            need_for_speed.ls();
            need_for_speed.info();

            
            Console.WriteLine("\n\nNice assignment but took my time :D");
            Console.WriteLine("All right to @ahmed_akef_");

        }
    }
}
