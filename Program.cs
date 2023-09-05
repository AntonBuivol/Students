using Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Program
    {
        public static void Main()
        {
            //Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
            //m1.Showmessage();
            //for (int i = 0; i < 1000; i++) { m1.AddLike(); };
            //Console.WriteLine(m1.GetPopularity());
            //Console.WriteLine();

            //Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
            //m2.Showmessage();

            //for (int i= 0; i < 1000; i++){ m2.AddLike(); } ;
            //Console.WriteLine(m2.GetPopularity());

            //Console.WriteLine(m1.popularinfo(m1.GetPopularity(), m2.GetPopularity()));

            //Message m3 = new Message("Tere", "Mari", DateTime.Now.AddDays(-1));

            //Message m4 = new Message("Guten Tag", "Hans", DateTime.Now.AddDays(-5));

            //Message m5 = new Message("Hei", "Marika", DateTime.Now.AddDays(-10));
            

            List<Message> list = new List<Message>();
            //list.Add(m1);
            //list.Add(m2);
            //list.Add(m3);
            //list.Add(m4);
            //list.Add(m5);

            Random random = new Random();
            Message m = new Message();
            int count=random.Next(1,10);
            
            for (int i = 0; i<count; i++)
            {
                Console.WriteLine("Kirjita sisu");
                string c = Console.ReadLine();
                Console.WriteLine("Kirjuta autorinimi");
                string a = Console.ReadLine();
                int t = -1*random.Next(0,1000000000);
                DateTime dhm = DateTime.Now.Date.AddSeconds(t);
                m = new Message(c, a,dhm) ;
                for (int j =0; j<random.Next(1,1000); j++)
                {
                    m.AddLike();
                }
                list.Add(m);
                m.Showmessage();
                Console.WriteLine();
            }


            Console.WriteLine(m.PopularInfon(list));

            Console.ReadLine();
        }

    }


}



