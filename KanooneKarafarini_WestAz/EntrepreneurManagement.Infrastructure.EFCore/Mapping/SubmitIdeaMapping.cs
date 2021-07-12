using EntrepreneurManagement.Domain.EntrepreneurServices.SubmitIdea;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrepreneurManagement.Infrastructure.EFCore.Mapping
{
    public class SubmitIdeaMapping : IEntityTypeConfiguration<SubmitIdea>
    {
        public void Configure(EntityTypeBuilder<SubmitIdea> builder)
        {
            builder.ToTable("SubmitIdea");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ApplicantName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.ApplicantFamily).IsRequired().HasMaxLength(250);
            builder.Property(x => x.ApplicantNationalId).IsRequired().HasMaxLength(100);
            builder.Property(x => x.ProposalSubject).IsRequired().HasMaxLength(550);
            builder.Property(x => x.ApplicantPhone).IsRequired().HasMaxLength(80);
            builder.Property(x => x.ApplicantMobile).IsRequired().HasMaxLength(80);
            builder.Property(x => x.ApplicantAddress).IsRequired();
            builder.Property(x => x.SummaryProposal).IsRequired();
        }
    }
}
