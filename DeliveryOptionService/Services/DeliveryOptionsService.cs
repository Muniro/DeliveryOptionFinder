using DeliveryOptionsDAL.Interfaces;
using DeliveryOptionsDAL.Models;
using DeliveryOptionsService.Interfaces;
using System.Collections.Generic;

namespace DeliveryOptionsService.Services
{
    public class DeliveryOptionsService : IDeliveryOptionsService
    {
        private readonly IDeliveryOptionsRepository deliveryRepository;

        public DeliveryOptionsService(DeliveryOptionsDAL.Interfaces.IDeliveryOptionsRepository deliveryRepository)
        {
            this.deliveryRepository = deliveryRepository;
        }
        public List<DeliveryOption> GetDeliveryOptionsByPostCode(string postCode)
        {

            return deliveryRepository.GetDeliveryOptionsByPostCode(postCode);
        }
    }
}
