using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211106_Struct_Enum_Product_request
{
    public struct Request
    {
        private int _requestID;
        private Client _client;
        private DateTime _requestDate;
        private RequestItem[] _arrRequestItems;
        public double Amount
        {
            get
            {
                double amount = 0;
                for (int i = 0; i < _arrRequestItems.Length; i++)
                {
                    amount += _arrRequestItems[i].Quantity * _arrRequestItems[i].Product.ProductPrice;
                }
                return amount;
            }
        }

        Request(int requestID, Client client, DateTime requestDate)
        {
            _requestID = requestID;
            _client = client;
            _requestDate = requestDate;
            _arrRequestItems = new RequestItem[0];

        }

    }
}
