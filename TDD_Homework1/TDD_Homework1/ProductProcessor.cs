using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Homework1
{
    public class ProductProcessor
    {
        private IEnumerable<Product> Products
        {
            get
            {
                return new List<Product> {
                    new Product { Id = 1, Cost = 2, Revenue = 11, SellPrice = 1 },
                    new Product { Id = 2, Cost = 1, Revenue = 6, SellPrice = 2 },
                    new Product { Id = 3, Cost = 3, Revenue = 7, SellPrice = 9 },
                    new Product { Id = 4, Cost = 5, Revenue = 3, SellPrice = 5 },
                    new Product { Id = 5, Cost = 6, Revenue = 4, SellPrice = 10 },
                    new Product { Id = 6, Cost = 8, Revenue = 3, SellPrice = 6 },
                    new Product { Id = 7, Cost = 4, Revenue = 1, SellPrice = 11},
                    new Product { Id = 8, Cost = 7, Revenue = 5, SellPrice = 3 },
                    new Product { Id = 9, Cost = 11, Revenue = 2, SellPrice = 8 },
                    new Product { Id = 10, Cost = 9, Revenue = 8, SellPrice = 7 },
                    new Product { Id = 11, Cost = 10, Revenue = 9, SellPrice = 4 },
                };
            }
            
        }

        public int[] SumFieldByCount(IEnumerable<Product> products, int count, string field)
        {
            throw new NotImplementedException();
        }
    }
}
