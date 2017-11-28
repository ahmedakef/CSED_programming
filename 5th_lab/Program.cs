using System;

namespace _5th_lab
{
    class bankingAccount {
        protected string name;
        protected int id;
        protected double balance;
        public bankingAccount(string name, int id, double balance){
            this.name = name;
            this.balance = balance;
            this.id = id;
        }
        virtual public void withdraw( double money ) {
            
            if(balance-money <0){
                Console.WriteLine("You don't have enoght blance");
            }
            balance -= money;
        }
        virtual public void add( double money ) {
         balance += money;
        }
        public double current(  ) {
          return balance;
        }
        public void info(  ) {
          Console.WriteLine("Your name is {0}", name);
          Console.WriteLine("Your id is {0}", id);
          Console.WriteLine("Your balance {0:0.00}\n", balance);
        }

    }
    class saving_account : bankingAccount {
       double interest_rate ;

       public saving_account(string name, int id, double balance , double rate) : base(name, id, balance) {
           this.interest_rate = rate;
       }

        public void add_interest(  ) {
         balance += interest_rate * balance;
      }

    }
    class checking_account  : bankingAccount{
       public int number_of_trans = 0;
       public double fees = 10.0;

        public checking_account(string name, int id, double balance) : base(name, id, balance) {
            Console.WriteLine("Hello" );
        }
        override public void withdraw( double money ) {
            if(number_of_trans > 3){
                balance-=fees;
            }
            if(balance-money <0){
                Console.WriteLine("You don't have enoght blance");
            }
            balance -= money;
            number_of_trans++;
      }
        override public void add( double money ) {
        if(number_of_trans > 3){
                balance-=fees;
        }
         balance += money;
         number_of_trans++;
      }

    }
    class Program
    {
        static void Main(string[] args)
        {
            saving_account ahmed = new saving_account("ahmed",1,1000.0,0.025);
            ahmed.add_interest();
            Console.WriteLine(ahmed.current());
            ahmed.info();

            checking_account hoda = new checking_account("hoda",1,50.0);
            hoda.add(2.0);
            hoda.withdraw(5.0);
            Console.WriteLine(hoda.current());
            hoda.add(2.0);
            Console.WriteLine(hoda.current());
            hoda.withdraw(5.0);
            Console.WriteLine(hoda.current());
            hoda.withdraw(5.0);
            Console.WriteLine(hoda.current());
            ahmed.info();

        }
    }
}
