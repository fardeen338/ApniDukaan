
namespace ApniDukaan.Application.Features.Shops.RegisterShops
{
    public class RegisterShopRequest
    {
        public string ShopName { get; set; } =string.Empty;
        public string MobileNumber { get; set; }
        public string? GSTNUmber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
