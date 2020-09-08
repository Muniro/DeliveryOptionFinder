using DeliveryOptionsDAL.Models;
using System.Collections.Generic;

namespace DeliveryOptionsDAL.Interfaces
{
    public interface IDeliveryOptionsRepository
    {
        List<DeliveryOption> GetDeliveryOptionsByPostCode(string postCode);
    }
}
