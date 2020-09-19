using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        public class person
        {
            public string Name ;
            private int PassN ;
            public string BornPlace ;
            public DateTime BornTime;
            
            public person(string name, int passn, string bornplase ,DateTime borntime)
            {
                Name = name;
                PassN = passn;
                BornPlace = bornplase;
                BornTime=borntime;
            }

            public override bool Equals(object obj)
            {
                if (!(obj is person))
                    return false;
                if (obj == null)
                    return false;
                var pers = (person)obj;
                return pers.Name == Name && pers.PassN == PassN && pers.BornPlace == BornPlace&& pers.BornTime==BornTime;
            }
            public override int GetHashCode()
            {
                return PassN;
            }
        }

        static void Main(string[] args)
        {
        	DateTime d1=new DateTime(1997,6,22);
        	DateTime d2=new DateTime(1997,6,22);
        	DateTime d3=new DateTime(1995,3,2);
        	person p1 = new person("Вася", 1213, "Ташлык",d1);
            person p2 = new person("Вася", 1213, "Ташлык",d2);
            person p3 = new person("Петя", 1213, "Слободзея",d3);
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p1.GetHashCode());
            Console.ReadLine();
        }
    }
}
