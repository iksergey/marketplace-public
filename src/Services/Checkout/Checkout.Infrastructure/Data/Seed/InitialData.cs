namespace Checkout.Infrastructure.Data.Seed;

public static class InitialData
{
    public static IEnumerable<Order> Orders => new List<Order>
    {
        new Order
        {
            AccountName = "test_account",
            TotalAmount = 15670m,
            CurrentOrderStatus = OrderStatus.Paid,
            CurrentPaymentMethod = PaymentMethod.CreditCard,
            CurrentPaymentStatus = PaymentStatus.Completed,
            ContactInfo = new("Иван", "Иванов", "ivan@test.com"),
            DeliveryAddress = new("Ленина 1", "Москва", "Московская", "101000"),
            CardDetails = new("Иван Иванов", "4111111111111111", "12/25", "123"),
            Items = new List<OrderItem>
            {
                new("Мультиварка Redmond RMC-M90", 1, 5890m),
                new("Бюджетный смартфон с хорошей камерой", 1, 7990m),
                new("Фен Polaris PHD 2077", 1, 1790m)
            }
        },
        new Order
        {
            AccountName = "admin@example.com",
            TotalAmount = 3290m,
            CurrentOrderStatus = OrderStatus.Submitted,
            CurrentPaymentMethod = PaymentMethod.BankTransfer,
            CurrentPaymentStatus = PaymentStatus.Pending,
            ContactInfo = new("Анна", "Петрова", "anna@example.com"),
            DeliveryAddress = new("Тверская 12", "Москва", "Московская", "101001"),
            CardDetails = null,
            Items = new List<OrderItem>
            {
                new("Кофеварка Polaris PCM 1516E", 1, 3290m)
            }
        }
    };
}
