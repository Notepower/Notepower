using System;
using System.Collections.Generic;
using System.Text;

namespace daylamotproject
{
    class Ticket    
    {
        public string airplanename;
        public DateTime airplanetime;
        public double price;
        public Ticket()
        {
            airplanename = " "; airplanetime = new DateTime(); price = 0;
        }
        public Ticket(string nameplane1,DateTime dateplane1,double price1)
        {
            airplanename = nameplane1;
            airplanetime = dateplane1;
            price = price1;
        }
        public void Set()
        {
            Console.Write("What is airplane name: ");
            airplanename = Console.ReadLine();
            Console.Write("What time: ");
            airplanetime = DateTime.Parse(Console.ReadLine());
            Console.Write("How much is it: ");
            price = double.Parse(Console.ReadLine());

        }
        public void Get()
        {
            Console.WriteLine("AirPlane Name : {0} || Time:{1} ||Price:{2} ||", airplanename, airplanetime.ToShortDateString(), price);
        }
    }
    class People
    {
        protected string name;
        protected bool gt;
        protected DateTime dfb;
        public People ()
        {
            name = " ";gt = true;dfb = new DateTime();
        }
        public People(string id,bool gt1,DateTime dfb1)
        {
            name = id; gt = gt1; dfb = dfb1;
        }
        public void Set()
        {
            Console.Write("FullName: ");
            name = Console.ReadLine();
            Console.Write("Sex [True - Male ||| False - Female]: ");
            gt = bool.Parse(Console.ReadLine());
            Console.Write("Date of birth: ");
            dfb = DateTime.Parse(Console.ReadLine());


        }
        public void Get()
        {
            string check = "";
            if (gt == true) check += "male";
            else check += "female";
            Console.WriteLine("FullName:{0} || Sex:{1} || Date of Birth:{2}||", name, check, dfb.ToShortDateString());
        }
    }
    class Guest:People
    {
        byte num;
        Ticket[] ls;
        public Guest()
        {
            num = 0;
        }
        public Guest (string id,bool gt1,DateTime dfb1,byte num1,Ticket[]ls1):base(id,gt1,dfb1)
        {
            num = num1;
            ls = ls1;
        }
        public new void Set()
        {
            base.Set();
            Console.Write("How many tickets: ");
            num = byte.Parse(Console.ReadLine());
            ls = new Ticket[num];
            for(int i=0;i<num;i++)
            {
                ls[i] = new Ticket();
                Console.WriteLine("---Ticket {0}---", i + 1);
                ls[i].Set();
                Console.WriteLine("----------");
            }
        }
        public double SumPrice()
        {
            double s = 0;
            for(int i=0;i<num;i++)
            {
                s = s + ls[i].price;
            }
            return s;
        }
        public new void Get()
        {
            base.Get();
            Console.WriteLine("Guest has {0} Tickets ", num);
            Console.WriteLine("------------");
            for (int i=0;i<num;i++)
            {
                Console.WriteLine("-------Ticket {0}-------", i + 1);
                ls[i].Get();
            }
            Console.WriteLine("Sum Price: {0} ", SumPrice());

        }
    }
}
