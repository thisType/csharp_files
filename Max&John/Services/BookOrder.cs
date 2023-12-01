
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Max_John.Services
{
    internal class BookOrder: Iservice.IBook
    {

        



        public async Task<bool> AddNewBook(BookModel book)
        {
            HttpClient client = new HttpClient();
            string book_json = JsonSerializer.Serialize<BookModel>(book);

            var content = new StringContent(book_json, Encoding.UTF8, "application/json");


            var response = await client.PostAsync("http://localhost:3000/books", content);



            response.EnsureSuccessStatusCode();

            return true;



        }



        public async Task<BookModel[]> ListBook()
        {
            HttpClient client = new HttpClient();


            HttpResponseMessage response = await client.GetAsync("http://localhost:3000/books");
            response.EnsureSuccessStatusCode();
            var stream = await response.Content.ReadAsStreamAsync();

            BookModel[] books = await JsonSerializer.DeserializeAsync<BookModel[]>(stream);
            return books;





        }




        public async Task<bool> MakeOrder(OrderModel order)
        {
            HttpClient client = new HttpClient();

            string order_json = JsonSerializer.Serialize<OrderModel>(order);

            var content = new StringContent(order_json, Encoding.UTF8, "application/json");


            var response = await client.PostAsync("http://localhost:3000/orders", content);



            response.EnsureSuccessStatusCode();

            return true;




        }
    }
}
