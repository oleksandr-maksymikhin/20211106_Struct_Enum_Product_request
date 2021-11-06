using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211106_Struct_Enum_Product_request
{
    public struct Article
    {
        int _productID;
        string _productName;
        double _productPrice;

        public Article(int productID, string productName, double productPrice)
        {
            _productID = productID;
            _productName = productName;
            _productPrice = productPrice;
        }

        public int ProductID { get => _productID; set => _productID = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public double ProductPrice { get => _productPrice; set => _productPrice = value; }

        public override string ToString()
        {
            return $"{ProductID:-5} | {ProductName: -15} | {ProductPrice}";
        }
    }
}
