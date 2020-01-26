using EFCoreExampleApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreExampleApp.Data.Mappings
{
    public class UserEmailMapping : IEntityTypeConfiguration<UserEmail>
    {
        public void Configure(EntityTypeBuilder<UserEmail> builder)
        {
            builder.ToTable("UserEmails").HasKey(p => p.Id);

            builder.OwnsOne(p => p.Email, email =>
            {
                email.Property(p => p.Address).HasColumnName("EmailAddress").IsRequired().HasMaxLength(50);
            });
        }
    }
}