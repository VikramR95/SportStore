using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Productdisplay
    {

        public List<ProductLine> Line { get; set; } = new List<ProductLine>();

        public virtual void AddItem(Product product, int quantity)
        {
            ProductLine line = Line
                .Where(p => p.Product.ProductID == product.ProductID)
                .FirstOrDefault();


            if (line == null)
            {
                Line.Add(new ProductLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }



        public virtual void RemoveLine(Product product) =>
            Line.RemoveAll(l => l.Product.ProductID == product.ProductID);

        public decimal ComputeTotalValue() =>
            Line.Sum(e => e.Product.Price * e.Quantity);
        public decimal ComputeTotalArticle() =>
            Line.Sum(e => e.Product.Price * e.Quantity);

        public virtual void Clear() => Line.Clear();
    }

    public class ProductLine
    {
        public int ProductLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}


