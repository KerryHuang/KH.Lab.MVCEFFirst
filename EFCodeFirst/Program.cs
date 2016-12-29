using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CustomerContext())
            {
                db.ClientBasics.Add(new Customer { Name = "Sky" });
                db.SaveChanges();

                var list = db.ClientBasics.OrderBy(x => x.ID);
                foreach(var a in list)
                {
                    Console.WriteLine(a.Name);
                }
                Console.ReadLine();
            }
        }
    }
}
