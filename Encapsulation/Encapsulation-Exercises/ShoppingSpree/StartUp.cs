using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class StartUp
    {
        public static void Main()
        {
            var listOfPeople = new List<Person>();
            var listOfProducts =new List<Product>();
            try
            {
                var people = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var products = Console.ReadLine().Split(new[] { ';','=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < people.Length; i+=2)
                {
                    var name = people[i];
                    var money = decimal.Parse(people[i+1]);

                    var person = new Person(name,money);
                    listOfPeople.Add(person);
                }

                for (int i = 0; i < products.Length; i+=2)
                {

                    var name = people[i];
                    var cost = decimal.Parse(people[i + 1]);

                    var product = new Person(name, cost);
                    listOfPeople.Add(product);
                }

                string purchase;

                while ((purchase = Console.ReadLine()) != "END")
                {
                    var arguments = purchase.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    var buyer = listOfPeople.FirstOrDefault(x => x.Name == arguments[0]);
                    var product = listOfProducts.FirstOrDefault(x => x.Name == arguments[1]);

                    buyer.BuyProduct(product);  
                }

                foreach (var per in listOfPeople)
                {
                    Console.WriteLine(per);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
        }
    }
}
