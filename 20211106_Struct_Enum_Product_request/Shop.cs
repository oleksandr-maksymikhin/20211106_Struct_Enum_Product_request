using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211106_Struct_Enum_Product_request
{

    public class Shop
    {
        private string _title;
        private Client[] _clients = null;
        private Article[] _articles = null;

        public string Title { get=> _title; set=> _title = value; }
        public Client[] Clients { get => _clients; private set => _clients = value; }
        public Article[] Articles { get => _articles; private set => _articles = value; }
        public Shop(string title)
        {
            _title = title;
            _clients = new Client[0];
            _articles = new Article[0];
        }

        public void AddClient(Client obj)
        {
            Client[] tmp = new Client[_clients.Length + 1];
            Array.Copy(_clients, 0, tmp, 0, _clients.Length);
            _clients = tmp;
            _clients[_clients.Length] = obj;
        }

        public void AddArticle(Article obj)
        {
            Article[] tmp = new Article[_articles.Length + 1];
            Array.Copy(_articles, 0, tmp, 0, _articles.Length);
            _articles = tmp;
            _articles[_clients.Length] = obj;
        }
    }
}
