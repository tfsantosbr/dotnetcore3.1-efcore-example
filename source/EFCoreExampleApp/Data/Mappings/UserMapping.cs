using EFCoreExampleApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreExampleApp.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users").HasKey(p => p.Id);

            builder.OwnsOne(p => p.CompleteName, completeName =>
            {
                completeName.Property(p => p.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
                completeName.Property(p => p.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            });

            builder.OwnsOne(p => p.Cpf, cpf =>
            {
                cpf.Property(p => p.Number).HasColumnName("Cpf").HasMaxLength(50);
            });

            builder.HasMany(p => p.Emails).WithOne().HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}