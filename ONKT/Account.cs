using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ConsoleApp11
{
    class Account
    {
        string stk, name;
        float soDu;

        public Account()
        {
            Stk = "";
            Name = " ";
            SoDu = 0;
        }
        public Account(string stk, string name, float soDu)
        {
            this.Stk = stk; this.Name = name; this.SoDu = soDu;
        }

        public float SoDu { get => soDu; set => soDu = value; }
        public string Stk { get => stk; set => stk = value; }
        public string Name { get => name; set => name = value; }
    }
    interface ITransaction
    {
        void Input(int n);
        bool Withdraw(int m);
    }
    class PersonalAccount : Account, ITransaction,IComparable<PersonalAccount>
    {
        float lai;

        public PersonalAccount()
        {
            lai = 0;
        }
        public PersonalAccount(string stk,string name , float soDu,float lai):base(stk,name,soDu)
        {
            this.lai = lai;
        }
        public float Calculate()
        {
            return SoDu * lai;
        }
        public void Input(int n)
        {
            SoDu += n;
        }

        public bool Withdraw(int m)
        {
            if (m < SoDu)
            {
                SoDu = SoDu - m;
                return true;
            }
            else
                return false;
        }
        public void Output()
        {
            Console.WriteLine("STK: {0} | SoDu: {1} | Lai: {2}", Stk, SoDu, Calculate());
        }
        public static bool operator<(PersonalAccount l1,PersonalAccount l2)
        {
            return l1.Calculate() < l2.Calculate();
        }
        public static bool operator >(PersonalAccount l1, PersonalAccount l2)
        {
            return l1.Calculate() > l2.Calculate();
        }
        public int CompareTo(PersonalAccount F)
        {
            if (Calculate() > F.Calculate()) return 1;
            if (Calculate() < F.Calculate()) return -1;
            return 0;
        }
    }
    class nPersonalAccount
    {
        int n;
        List<PersonalAccount> ls = new List<PersonalAccount>();
       public void Input()
        {
            try
            {
                FileStream f = new FileStream("Personal.txt", FileMode.Open);
                StreamReader rd = new StreamReader(f, Encoding.UTF8);
                n = int.Parse(rd.ReadLine());
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    string stk = line;
                    string name = rd.ReadLine();
                    float soDu = float.Parse(rd.ReadLine());
                    float lai = float.Parse(rd.ReadLine());

                    PersonalAccount n = new PersonalAccount(stk, name, soDu, lai);
                    ls.Add(n);
                }
                f.Close();

                
            }
            catch
            {
                Console.WriteLine("Khong doc duoc file");
            }
            n = ls.Count;
        }
        public void Output()
        {
            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine("---------------");
                ls[i].Output();
            }
    }
        public void Add(byte pos, int n)
        {
            ls[pos].Input(n);
            Console.WriteLine("So du tai khoan sau khi nap:" + ls[pos].SoDu);
        }
        public void SX()
        {
            Console.WriteLine("-------------");
            ls.Sort();
            Console.WriteLine("DANH SACH SAU KHI SAP XEP LA: ");
            Output();
        }
        public void Check(string x)
        {
            Console.WriteLine("-------------");
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].Stk == x)
                {
                    Console.WriteLine("STK: {0} | Time: {1} | SoDu: {2}", x, DateTime.Now, ls[i].SoDu);
                    break;
                }
            }
        }
    }
    
}
