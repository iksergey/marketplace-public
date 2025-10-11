namespace Promotion.Grpc.Persistence.Data;

public static class InitData
{
    public static IEnumerable<Promo> GetInitialPromos =>
    new List<Promo>
    {
        new Promo
        {
            Id = Guid.Parse("c0000100-0000-0000-0000-000000000001"),
            // Мультиварка Redmond RMC-M90
            CatalogItemId = "a0000001-0000-0000-0000-000000000001",
            Title = "Скидка 100 на продукт: Мультиварка Redmond RMC-M90",
            Value = 100m
        },
        new Promo
        {
            Id = Guid.Parse("c0000100-0000-0000-0000-000000000002"),
            // Смартфон Vitek VT-1234
            CatalogItemId = "a0000001-0000-0000-0000-000000000002",
            Title = "Скидка 1000 на продукт: Смартфон Vitek VT-1234",
            Value = 1000m
        },
        new Promo
        {
            Id = Guid.Parse("c0000100-0000-0000-0000-000000000003"),
            // Детский комбинезон Мир детства
            CatalogItemId = "a0000001-0000-0000-0000-000000000005",
            Title = "Скидка 150 на продукт: Детский комбинезон Мир детства",
            Value = 150m
        }
    };
}
