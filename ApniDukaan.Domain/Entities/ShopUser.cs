namespace ApniDukaan.Domain.Entities
{
    public class ShopUser
    {
        public Guid ShopUserId { get; set; }
        public Guid UserId { get; set; }
        public Guid ShopId { get; set; }
        public Guid RoleId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
