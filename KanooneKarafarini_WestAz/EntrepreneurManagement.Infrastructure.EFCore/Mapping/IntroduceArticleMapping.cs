using System.Security.Cryptography.X509Certificates;
using EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceArticle;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrepreneurManagement.Infrastructure.EFCore.Mapping
{
    public class IntroduceArticleMapping : IEntityTypeConfiguration<IntroduceArticle>
    {
        public void Configure(EntityTypeBuilder<IntroduceArticle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("IntroduceArticle");

            builder.Property(x => x.Title).IsRequired().HasMaxLength(450);
            builder.Property(x => x.StateTitle).IsRequired().HasMaxLength(150);
        }
    }
}
