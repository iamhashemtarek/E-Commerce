using AutoMapper;
using ECommerce.APIs.DTOs;
using ECommerce.Core.Entities;
using ECommerce.Core.Entities.Order_Aggregate;

namespace ECommerce.APIs.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(dest => dest.Brand, o => o.MapFrom(src => src.ProductBrand.Name))
                .ForMember(dest => dest.Category, o => o.MapFrom(src => src.ProductCategory.Name));

            CreateMap<CustomerBasketDto, CustomerBasket>();
            
            CreateMap<BasketItemsDto, BasketItems>();

            CreateMap<AddressDto, Address>();

            CreateMap<Order, OrderToReturnDto>()
                .ForMember(d => d.DeliveryMethod, o => o.MapFrom(s => s.DeliveryMethod.ShortName))
                .ForMember(d => d.DeliveryMethodCost, o => o.MapFrom(s => s.DeliveryMethod.Cost));

            CreateMap<OrderItem, OrderItemDto>()
                .ForMember(d => d.ProductId, o => o.MapFrom(s => s.Product.ProductId))
                .ForMember(d => d.ProductName, o => o.MapFrom(s => s.Product.ProductName))
                .ForMember(d => d.PictureUrl, o => o.MapFrom(s => s.Product.PictureUrl));
        }
    }
}
