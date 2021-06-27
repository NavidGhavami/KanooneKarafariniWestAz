using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSectionManagement.Domain.Footer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CommonSectionManagement.Infrastructure.EFCore.Mapping
{
    public class FooterMapping : IEntityTypeConfiguration<Footer>
    {
        public void Configure(EntityTypeBuilder<Footer> builder)
        {
            builder.ToTable("Footers");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Mobile).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(250);
            builder.Property(x => x.Fax).HasMaxLength(50);
        }
    }
}
