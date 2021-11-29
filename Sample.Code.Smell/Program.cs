using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Code.Smell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            p.Add("ürün1", 3, "0x000123", false);
            p.Add("ürün2", 5, "0x000456", true);
        }

        class Product
        {    
            public void Add(string pName, int pAdet, string pColor, bool pStatus)
            {
                if (true)
                {
                    /*
                     * bla bla bla
                     */
                }
                else
                {

                }

                if (true /*other conditions*/)
                {
                    /*
                     * bla bla bla
                     */
                }
            }
        }

    }
}
