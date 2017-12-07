using System;

namespace _4th_assignment_files_
{
  public interface File_interface {
        int rename(string new_name);
        void delete();
        void open();
        string get_path();
    }
    class File : File_interface {
        string name;
        public File(string name){
            this.name = name;
        }
        public int rename(string new_name){
            bool same_name_in_dir = false ; // ToDo  we can call OS to jnow that
            if( !same_name_in_dir){
                this.name = new_name;
                Console.WriteLine("file renamed");
                return 0;
            }
            Console.WriteLine("file can't be renamed");
            return 1;
        }
        public void delete(){
            //To Do
            // OS.delete ( this.name );   // it will be some thinng like that
            Console.WriteLine("file deleted");
        }
        public string get_name(){
            
            return this.name;
        }
        virtual public void open(){
            Console.WriteLine("file is openned");
        }
        public string get_path(){
            //To Do
            // return OS.getPath ( this.name );   // it will be some thinng like that
            return "/Documents/C#/4th_assignment";
        }

    }

    class Text : File {
        public Text(string name) : base(name){ }
        override public void open(){
            Console.WriteLine("the text file is openned");
        }

    }

    class Audio : File {

        public Audio(string name) : base(name){ }
        public void play(){
            Console.WriteLine("the audio is playing now");
        }

    }


    class Image : File {

        public Image(string name) : base(name){ }
        public void view(){
            Console.WriteLine("the image is opened now");
        }
    }

    class Video : File {

        public Video(string name) : base(name){ }
        public void play(){
            Console.WriteLine("the video is playing now");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            File file1 = new File("file1");
            file1.open();
            file1.rename("ahmed");
            Console.WriteLine(file1.get_name());

            Text text1 = new Text("text1");
            text1.open();
            Image image1= new Image("image1");
            image1.open();
            Audio audio1 = new Audio("audio1");
            audio1.play();
            Video video1 = new Video("video1");
            video1.rename("hoda");
            Console.WriteLine(video1.get_name());
        }
    }
}
