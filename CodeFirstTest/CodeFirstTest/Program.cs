using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BloggingContext();
            Console.WriteLine("Enter a name for a new Blog:");

            var name = Console.ReadLine();
            var blog = new Blog { Name = name };

            db.Blogs.Add(blog);

            db.SaveChanges();

            // IOrderedQueryable<Blog>
            var query = from b in db.Blogs
                        orderby b.Name
                        select b;

            Console.WriteLine("All blogs are in the database:");

            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Press any key to exit....");

            Console.ReadKey();
        }
    }
}
