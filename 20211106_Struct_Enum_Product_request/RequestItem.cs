using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211106_Struct_Enum_Product_request
{
    public struct RequestItem
    {
        Article _product;
        int _quantity;

        public RequestItem(Article product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }
        
        public Article Product { get => _product; set => _product = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }


        //method add item
    }
}
