using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSectionManagement.Domain.AboutContactUs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CommonSectionManagement.Infrastructure.EFCore.Mapping
{
    public class AboutContactUsMapping : IEntityTypeConfiguration<AboutContactUs>
    {
        public void Configure(EntityTypeBuilder<AboutContactUs> builder)
        {
            builder.ToTable("AboutContactUs");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.AboutUsText).IsRequired();
            builder.Property(x => x.ContactUsText).IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(650);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Mobile).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Fax).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(350);
            builder.Property(x => x.GoogleMap).IsRequired();
        }
    }
}
