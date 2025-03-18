using System.ComponentModel.DataAnnotations;
using ECommerce.Core.Entities.Order_Aggregate;

namespace ECommerce.APIs.DTOs
{
    public class OrderDto
    {
        [Required]
        public string BasketId { get; set; }
        [Required]
        public int DeliveryMethodId { get; set; }
        public AddressDto ShippingAddress { get; set; }
    }
}
