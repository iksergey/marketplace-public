namespace Checkout.Infrastructure.Data.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.AccountName)
               .HasMaxLength(100)
               .IsRequired();

        builder.Property(o => o.TotalAmount)
               .HasColumnType("decimal(18,2)");

        builder.Property(o => o.CurrentOrderStatus)
               .HasConversion<string>()
               .HasMaxLength(50);

        builder.Property(o => o.CurrentPaymentMethod)
               .HasConversion<string>()
               .HasMaxLength(50);

        builder.Property(o => o.CurrentPaymentStatus)
               .HasConversion<string>()
               .HasMaxLength(50);

        builder.OwnsOne(o => o.ContactInfo, contact =>
        {
            contact.Property(c => c.FirstName).HasMaxLength(100);
            contact.Property(c => c.LastName).HasMaxLength(100);
            contact.Property(c => c.Email).HasMaxLength(255);
        });

        builder.OwnsOne(o => o.DeliveryAddress, address =>
        {
            address.Property(a => a.Street).HasMaxLength(200);
            address.Property(a => a.City).HasMaxLength(100);
            address.Property(a => a.Region).HasMaxLength(100);
            address.Property(a => a.PostalCode).HasMaxLength(20);
        });

        builder.OwnsOne(o => o.CardDetails, card =>
        {
            card.Property(c => c.CardName).HasMaxLength(100);
            card.Property(c => c.CardNumber).HasMaxLength(20);
            card.Property(c => c.Expiration).HasMaxLength(10);
            card.Property(c => c.Cvv).HasMaxLength(10);
        });

        builder.OwnsMany(o => o.Items, item =>
        {
            item.Property(i => i.CatalogItemName)
                .HasMaxLength(200)
                .IsRequired();

            item.Property(i => i.UnitPrice)
                .HasColumnType("decimal(18,2)");

            item.Property(i => i.Quantity)
                .IsRequired();
        });

        builder.HasIndex(o => o.AccountName);
        builder.HasIndex(o => o.CurrentOrderStatus);
        builder.HasIndex(o => o.CurrentPaymentStatus);
    }
}
