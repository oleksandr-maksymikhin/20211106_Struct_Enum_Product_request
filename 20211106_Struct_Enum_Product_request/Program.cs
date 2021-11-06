using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211106_Struct_Enum_Product_request
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Описать структуру Article, содержащую следующие поля: код
            товара, название товара, цена товара. Описать структуру
            Client, содержащую поля: код клиента, ФИО, адрес, телефон,
            количество заказов, осуществленных клиентом, общая сумма
            заказов клиента.Описать структуру RequestItem, содержащую
            поля: товар, количество единиц товара.Описать структуру
            Request, содержащую поля: код заказа, клиент, дата заказа,
            перечень заказанных товаров, сумма заказа(реализовать
            вычисляемым свойством). Продемонстрировать работу
            программы.
            */
            /*
            2.Описать перечисление ArticleType, определяющее типы
            товаров и добавить соответствующее поле в структуру Article
            из предыдущего задания.
            */
            //Products
            Article bread = new Article(10, "Bread", 18.50);
            Article milk = new Article(10, "Milk", 25.30);
            Article sausage = new Article(10, "Sausage", 160.00);
            Article zhyvchik = new Article(20, "Zhyvchik", 25.00);
            Article cola = new Article(20, "Cola", 32.00);
            Article pepsi = new Article(20, "Pepsi", 29.00);
            Article fluecold = new Article(30, "Fluecold", 45.50);
            Article azitromicyn = new Article(30, "Azitromicyn", 180.70);
            Article pertusin = new Article(30, "Pertusin", 35.20);

            //Clients
            Client vasya = new Client(111, "Vasya", "Kyiv, Khreschatuk, 11", "+380671112233", 1, 100.10);
            Client petya = new Client(222, "Petya", "Kharkiv, Svobody, 22", "+380501112233", 2, 200.20);
            Client tolya = new Client(333, "Tolya", "Lviv, Stryska, 33", "+380731112233", 3, 300.30);

            Shop myShop = new Shop("Albatros");
            myShop.AddArticle(bread);
            myShop.AddArticle(milk);
            myShop.AddArticle(sausage);
            myShop.AddArticle(zhyvchik);
            myShop.AddArticle(cola);
            myShop.AddArticle(pepsi);
            myShop.AddArticle(fluecold);
            myShop.AddArticle(azitromicyn);
            myShop.AddArticle(pertusin);

            myShop.AddClient(vasya);
            myShop.AddClient(petya);
            myShop.AddClient(tolya);


        }
    }
}
