using EntrepreneurManagement.Domain.RahyarEntrepreneur;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrepreneurManagement.Infrastructure.EFCore.Mapping
{
    public class RahyarEntrepreneurMapping : IEntityTypeConfiguration<RahyarEntrepreneur>
    {
        public void Configure(EntityTypeBuilder<RahyarEntrepreneur> builder)
        {
            builder.ToTable("RahyarEntrepreneur");
            builder.HasKey(x => x.Id);


            builder.Property(x => x.RahyarName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.RahyarFamily).IsRequired().HasMaxLength(350);
            builder.Property(x => x.RahyarNationalId).IsRequired().HasMaxLength(80);
            builder.Property(x => x.RahyarBirthDate).IsRequired().HasMaxLength(150);
            builder.Property(x => x.RahyarEducation).IsRequired().HasMaxLength(250);
            builder.Property(x => x.RahyarCourse).IsRequired().HasMaxLength(250);
            builder.Property(x => x.RahyarCity).IsRequired().HasMaxLength(350);
            builder.Property(x => x.RahyarPhone).IsRequired().HasMaxLength(150);
            builder.Property(x => x.RahyarMobile).IsRequired().HasMaxLength(150);
            builder.Property(x => x.RayharAddress).IsRequired();
            builder.Property(x => x.RahyarResume).IsRequired();
        }
    }
}
