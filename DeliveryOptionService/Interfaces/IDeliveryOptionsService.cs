using DeliveryOptionsDAL.Models;
using System.Collections.Generic;

namespace DeliveryOptionsService.Interfaces
{
    public interface IDeliveryOptionsService
    {
        List<DeliveryOption> GetDeliveryOptionsByPostCode(string postCode);
    }
}
