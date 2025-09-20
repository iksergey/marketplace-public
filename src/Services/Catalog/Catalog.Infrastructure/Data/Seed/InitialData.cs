namespace Catalog.Infrastructure.Data.Seed;

public static class InitialData
{
    public static IEnumerable<Brand> Brands => new List<Brand>
    {
        new Brand
        {
            Id = Guid.Parse("b0000001-0000-0000-0000-000000000001"),
            Title = "Polaris"
        },
        new Brand
        {
            Id = Guid.Parse("b0000001-0000-0000-0000-000000000002"),
            Title = "Redmond"
        },
        new Brand
        {
            Id = Guid.Parse("b0000001-0000-0000-0000-000000000003"),
            Title = "Vitek"
        },
        new Brand
        {
            Id = Guid.Parse("b0000001-0000-0000-0000-000000000004"),
            Title = "Scarlett"
        },
        new Brand
        {
            Id = Guid.Parse("b0000001-0000-0000-0000-000000000005"),
            Title = "Снеж"
        },
        new Brand
        {
            Id = Guid.Parse("b0000001-0000-0000-0000-000000000006"),
            Title = "Мир детства"
        },
        new Brand
        {
            Id = Guid.Parse("b0000001-0000-0000-0000-000000000007"),
            Title = "Светозар"
        },
        new Brand
        {
            Id = Guid.Parse("b0000001-0000-0000-0000-000000000008"),
            Title = "Детский мир"
        },
        new Brand
        {
            Id = Guid.Parse("b0000001-0000-0000-0000-000000000009"),
            Title = "Золотое яблоко"
        },
        new Brand
        {
            Id = Guid.Parse("b0000001-0000-0000-0000-000000000010"),
            Title = "Славянка"
        }
    };

    public static IEnumerable<Category> Categories => new List<Category>
    {
        new Category
        {
            Id = Guid.Parse("c0000001-0000-0000-0000-000000000001"),
            Title = "Бытовая техника"
        },
        new Category
        {
            Id = Guid.Parse("c0000001-0000-0000-0000-000000000002"),
            Title = "Электроника"
        },
        new Category
        {
            Id = Guid.Parse("c0000001-0000-0000-0000-000000000003"),
            Title = "Одежда"
        },
        new Category
        {
            Id = Guid.Parse("c0000001-0000-0000-0000-000000000004"),
            Title = "Детские товары"
        },
        new Category
        {
            Id = Guid.Parse("c0000001-0000-0000-0000-000000000005"),
            Title = "Косметика и уход"
        }
    };

    public static IEnumerable<CatalogItem> CatalogItems => new List<CatalogItem>
    {
        new CatalogItem
        {
            Id = Guid.Parse("a0000001-0000-0000-0000-000000000001"),
            Title = "Мультиварка Redmond RMC-M90",
            ShortDescription = "Умная мультиварка с 45 программами",
            FullDescription = "Мультиварка Redmond RMC-M90 с антипригарной чашей, сенсорным управлением и функцией 3D-нагрева.",
            ImageUrl = "https://example.com/images/redmond-m90.jpg",
            Brand = Brands.First(b => b.Id == Guid.Parse("b0000001-0000-0000-0000-000000000002")),
            Category = Categories.First(c => c.Id == Guid.Parse("c0000001-0000-0000-0000-000000000001")),
            Price = 5990m
        },
        new CatalogItem
        {
            Id = Guid.Parse("a0000001-0000-0000-0000-000000000002"),
            Title = "Смартфон Vitek VT-1234",
            ShortDescription = "Бюджетный смартфон с хорошей камерой",
            FullDescription = "Смартфон Vitek VT-1234 с 4 ГБ ОЗУ, двойной камерой и аккумулятором 4000 мАч.",
            ImageUrl = "https://example.com/images/vitek-vt1234.jpg",
            Brand = Brands.First(b => b.Id == Guid.Parse("b0000001-0000-0000-0000-000000000003")),
            Category = Categories.First(c => c.Id == Guid.Parse("c0000001-0000-0000-0000-000000000002")),
            Price = 8990m
        },
        new CatalogItem
        {
            Id = Guid.Parse("a0000001-0000-0000-0000-000000000003"),
            Title = "Фен Polaris PHD 2077",
            ShortDescription = "Компактный фен для волос",
            FullDescription = "Фен Polaris PHD 2077 с мощностью 2000 Вт, 2 режимами нагрева и функцией ионизации.",
            ImageUrl = "https://example.com/images/polaris-phd2077.jpg",
            Brand = Brands.First(b => b.Id == Guid.Parse("b0000001-0000-0000-0000-000000000001")),
            Category = Categories.First(c => c.Id == Guid.Parse("c0000001-0000-0000-0000-000000000001")),
            Price = 1790m
        },
        new CatalogItem
        {
            Id = Guid.Parse("a0000001-0000-0000-0000-000000000004"),
            Title = "Электрочайник Scarlett SC-EK21",
            ShortDescription = "Стильный чайник с подсветкой",
            FullDescription = "Электрочайник Scarlett SC-EK21 с объемом 1,7 л, защитой от перегрева и LED-подсветкой.",
            ImageUrl = "https://example.com/images/scarlett-ek21.jpg",
            Brand = Brands.First(b => b.Id == Guid.Parse("b0000001-0000-0000-0000-000000000004")),
            Category = Categories.First(c => c.Id == Guid.Parse("c0000001-0000-0000-0000-000000000001")),
            Price = 1290m
        },
        new CatalogItem
        {
            Id = Guid.Parse("a0000001-0000-0000-0000-000000000005"),
            Title = "Детский комбинезон Мир детства",
            ShortDescription = "Тёплый комбинезон для малышей",
            FullDescription = "Зимний комбинезон Мир детства с капюшоном, утеплителем и светоотражающими элементами.",
            ImageUrl = "https://example.com/images/mirdetstva-combi.jpg",
            Brand = Brands.First(b => b.Id == Guid.Parse("b0000001-0000-0000-0000-000000000006")),
            Category = Categories.First(c => c.Id == Guid.Parse("c0000001-0000-0000-0000-000000000004")),
            Price = 2990m
        },
        new CatalogItem
        {
            Id = Guid.Parse("a0000001-0000-0000-0000-000000000006"),
            Title = "Светильник Светозар SZ-100",
            ShortDescription = "Настольный светодиодный светильник",
            FullDescription = "Светильник Светозар SZ-100 с регулировкой яркости, USB-зарядкой и энергосбережением.",
            ImageUrl = "https://example.com/images/svetozar-sz100.jpg",
            Brand = Brands.First(b => b.Id == Guid.Parse("b0000001-0000-0000-0000-000000000007")),
            Category = Categories.First(c => c.Id == Guid.Parse("c0000001-0000-0000-0000-000000000002")),
            Price = 990m
        },
        new CatalogItem
        {
            Id = Guid.Parse("a0000001-0000-0000-0000-000000000007"),
            Title = "Платье Детский мир Летнее",
            ShortDescription = "Лёгкое хлопковое платье",
            FullDescription = "Платье из 100% хлопка для девочек, размерный ряд 92-140 см, яркий принт.",
            ImageUrl = "https://example.com/images/detskiy-mir-dress.jpg",
            Brand = Brands.First(b => b.Id == Guid.Parse("b0000001-0000-0000-0000-000000000008")),
            Category = Categories.First(c => c.Id == Guid.Parse("c0000001-0000-0000-0000-000000000003")),
            Price = 1190m
        },
        new CatalogItem
        {
            Id = Guid.Parse("a0000001-0000-0000-0000-000000000008"),
            Title = "Косметический набор Золотое яблоко",
            ShortDescription = "Подарочный набор для ухода за кожей",
            FullDescription = "В наборе: крем для лица, маска, гель для умывания. Подходит для всех типов кожи.",
            ImageUrl = "https://example.com/images/gold-apple-set.jpg",
            Brand = Brands.First(b => b.Id == Guid.Parse("b0000001-0000-0000-0000-000000000009")),
            Category = Categories.First(c => c.Id == Guid.Parse("c0000001-0000-0000-0000-000000000005")),
            Price = 2490m
        },
        new CatalogItem
        {
            Id = Guid.Parse("a0000001-0000-0000-0000-000000000009"),
            Title = "Шоколад Славянка Аленка",
            ShortDescription = "Молочный шоколад 100 г",
            FullDescription = "Классический молочный шоколад 'Аленка' от фабрики Славянка, 100 грамм.",
            ImageUrl = "https://example.com/images/slavyanka-alenka.jpg",
            Brand = Brands.First(b => b.Id == Guid.Parse("b0000001-0000-0000-0000-000000000010")),
            Category = Categories.First(c => c.Id == Guid.Parse("c0000001-0000-0000-0000-000000000004")),
            Price = 120m
        },
        new CatalogItem
        {
            Id = Guid.Parse("a0000001-0000-0000-0000-000000000010"),
            Title = "Кофеварка Polaris PCM 1516E",
            ShortDescription = "Капельная кофеварка 600 Вт",
            FullDescription = "Кофеварка Polaris PCM 1516E с функцией автоотключения, резервуаром на 1,5 л и индикатором уровня воды.",
            ImageUrl = "https://example.com/images/polaris-pcm1516e.jpg",
            Brand = Brands.First(b => b.Id == Guid.Parse("b0000001-0000-0000-0000-000000000001")),
            Category = Categories.First(c => c.Id == Guid.Parse("c0000001-0000-0000-0000-000000000001")),
            Price = 3290m
        }
    };
}
