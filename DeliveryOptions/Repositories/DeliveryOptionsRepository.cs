using DeliveryOptionsDAL.Interfaces;
using DeliveryOptionsDAL.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DeliveryOptionsDAL.Repositories
{
    public class DeliveryOptionsRepository : IDeliveryOptionsRepository
    {
       

        public DeliveryOptionsRepository()
        {
         
        }
        public List<DeliveryOption> GetDeliveryOptionsByPostCode(string postCode)
        {
            //load the json file and show
            //In real life, this would be using an Entity framework (or any ORM) and
            // the data wpuld be in SQL server database, or any other database.

            return GetDeliveryOptions().Where(x => x.PostCode==postCode).ToList<DeliveryOption>();
        } 

        private List<DeliveryOption> GetDeliveryOptions()
        {
            List<DeliveryOption> list = new List<DeliveryOption>();
         
            var appDomain = System.AppDomain.CurrentDomain;
            var basePath = appDomain.RelativeSearchPath ?? appDomain.BaseDirectory;
           var jsonFile= Path.Combine(basePath, "Persistence", "DeliveryOptions.json");

            using (StreamReader sr = new StreamReader(jsonFile)) 
            {
                list = JsonConvert.DeserializeObject<List<DeliveryOption>>(sr.ReadToEnd());
            }

            

            return list;
        }
    }
}
