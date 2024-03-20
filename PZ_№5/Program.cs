using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ__5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> allBooks=new List<Book>();


            bool flag = true;
            while (flag)
            {
               Console.WriteLine($"1-добавить книгу\n2-поставить на учет\n3-Вывевсти всю информацию о книге");
               int i=int.Parse( Console.ReadLine() );
            
                switch (i)
                {
                    case 1:
                        Console.Write("Введите название книги:");
                        string name = Console.ReadLine();
                        Console.Write("id книги: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Цена книги: ");
                        int cost=int.Parse( Console.ReadLine() );
                        Book book = new Book(name, id, cost);
                        allBooks.Add(book);
                        Console.WriteLine("Книга успешно добавлена");
                        break;

                    case 2:
                        {
                            Bibliotecue_rep bibliotecue = new Bibliotecue_rep();

                        }
                        break;

                    case 3:
                        foreach (var item in allBooks)
                        {
                            Console.WriteLine($"[{item.Id}] {item.Name}:{item.Cost}rub");
                        }
                    break;
                }
            }
        }
    }
}
