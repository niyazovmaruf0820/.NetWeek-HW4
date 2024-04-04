namespace Domain.Models;

public class Orders
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public int ProductId { get; set; }
    public int ProductQuantity { get; set; }
    public decimal TotalAmount { get; set; }
}
