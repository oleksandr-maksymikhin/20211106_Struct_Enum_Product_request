using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211106_Struct_Enum_Product_request
{
    public struct Client
    {
        private int _clientID;
        private string _clientName;
        private string _address;
        private string _tel;
        private int _ordersQuantity;
        private double _orderAmount;

        public Client(int clientID, string clientName, string address, string tel, int ordersQuantity, double orderAmount)
        {
            _clientID = clientID;
            _clientName = clientName;
            _address = address;
            _tel = tel;
            _ordersQuantity = ordersQuantity;
            _orderAmount = orderAmount;
        }

        public int ClientID { get => _clientID; set => _clientID = value; }
        public string ClientName { get => _clientName; set => _clientName = value; }
        public string Address { get => _address; set => _address = value; }
        public  string Tel
        {
            get
            {
                return _tel;
            }
            set
            {
                if (value.Length == 13 && value[0] == '+')
                {
                    _tel = value;
                }
                else
                {
                    _tel = "NA";
                }
            }
        }
        public int OrdersQuantity { get => _ordersQuantity; set => _ordersQuantity = value; }
        public double OrderAmount { get => _orderAmount; set => _orderAmount = value; }

        public override string ToString()
        {
            return $"{ClientID} - {ClientName} - {Address} - {Tel} - {OrdersQuantity} - {OrderAmount}";
        }

    }
}
