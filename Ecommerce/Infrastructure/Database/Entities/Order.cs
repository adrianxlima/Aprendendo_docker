namespace Ecommerce.Infrastructure.Database.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalOrder { get; set; }

    }
}
