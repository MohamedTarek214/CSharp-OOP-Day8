using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public class Product : IComparable
    {
        #region Propertes
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        #endregion
        #region Methods
        public int CompareTo(object obj)
        {

            Product product = (Product)obj;
            if (this.Price > product.Price)
                return 1;
            else if (this.Price < product.Price)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        } 
        #endregion
    }
}
