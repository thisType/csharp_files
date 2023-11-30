using Max_John.Services.Iservice;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Max_John.Services
{
    internal class OrderService :IOrder
    {
        HttpClient client = new HttpClient();

        public async Task OrderBook(OrderModel model)
        {


            string model_json = JsonSerializer.Serialize<OrderModel>(model);

            var content = new StringContent(model_json, Encoding.UTF8, "application/json");


            var response = await client.PostAsync("http://localhost:3000/orders", content);



            response.EnsureSuccessStatusCode();

            return true;


        }
    }
}
