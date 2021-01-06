using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ConsoleApp12
{
    class Card
    {
        string sothe, name;
        float money;

        public Card()
        {
            sothe = "";
            name = "";
            Money = 0;
        }
        public Card(string sothe,string name,float money)
        {
            this.sothe = sothe;
            this.name = name;
            this.Money = money;
        }

        public float Money { get => money; set => money = value; }

        public void Output()
        {
            Console.WriteLine("Sothe:{0}\t HoTen:{1}\t TienDungTruoc:{2}", sothe, name, Money);
        }

    }
    interface ITransaction
    {
       void Buy(int m);
    }
    class CreditCard : Card, ITransaction
    {
        float hanmuc, laisuat;

        public float Hanmuc { get => hanmuc; set => hanmuc = value; }
        public float Laisuat { get => laisuat; set => laisuat = value; }

        public CreditCard():base()
        {
            Hanmuc = 0;
            Laisuat = 0;
        }
        public CreditCard(string sothe,string name,float money,float hanmuc ,float laisuat):base(sothe,name,money)
        {
            this.Hanmuc = hanmuc;
            this.Laisuat = laisuat;
        }
        public float Calculation()
        {
            if (Money > Hanmuc)
                return (Money - Hanmuc)*Laisuat;
            else
            return 0;
        }
        public void Buy(int m)
        {
          
            Money = Money - m;

        }
        public new void Output()
        {
            base.Output();
            Console.WriteLine("HanMuc:{0}\t TienLai:{1}", Hanmuc, Calculation());
        }
    }
    class nCreditCard
    {
        int n;
        List<CreditCard> ls = new List<CreditCard>();
        public void Input()
        {
            FileStream f = new FileStream("CreditCard.txt", FileMode.Open);
            StreamReader rd = new StreamReader(f, Encoding.UTF8);
           
            string line;
           try
            {
                while((line=rd.ReadLine())!=null)
                {
                    string sothe = line;
                    string name = rd.ReadLine();
                    float money = float.Parse(rd.ReadLine());
                    float hanmuc = float.Parse(rd.ReadLine());
                    float laisuat = float.Parse(rd.ReadLine());

                    CreditCard c = new CreditCard(sothe, name, money, hanmuc, laisuat);
                    ls.Add(c);
                }
                f.Close();
            }
            catch
            {
                Console.WriteLine("KHONG MO DUOC FILE");
            }
            n = ls.Count;
        }
        public void Output()
        {
            for(int i=0;i<ls.Count;i++)
            {
                Console.WriteLine("---------------");
                ls[i].Output();
            }
        }
        public void Delete()
        {
           float max = 0;
            int k = 0;
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].Calculation() > max)
                {
                    max = ls[i].Calculation();
                    k = i;
                }
              
            }
            ls.RemoveAt(k);
            Console.WriteLine("Danh sach sau khi xoa la : ");
            Output();
        }
        public void Paid(byte pos, int x)
        {
            for (int i = 0; i < ls.Count; i++)
                if (i == pos)
                {
                    ls[i].Buy(x);
                    break;
                }
        }
        public void SX()
        {
           
            for (int i = 0; i < ls.Count; i++)
                for (int j = i + 1; j < ls.Count; j++)
                    if (ls[i].Hanmuc < ls[j].Hanmuc)
                    {
                        CreditCard tam = new CreditCard();
                        tam = ls[i];
                        ls[i] = ls[j];
                        ls[j] = tam;
                    }
        }
    }
}
