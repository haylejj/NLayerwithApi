using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entity;

namespace NLayer.Repository.Seeds
{
    internal class ProductFeautureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData
                (
                   new ProductFeature { Id=1, Color="Kırmızı", Height=100, Width=200, ProductId=1 },
                   new ProductFeature { Id=2, Color="Yeşil", Height=200, Width=300, ProductId=2 }
                );
        }
    }
}
