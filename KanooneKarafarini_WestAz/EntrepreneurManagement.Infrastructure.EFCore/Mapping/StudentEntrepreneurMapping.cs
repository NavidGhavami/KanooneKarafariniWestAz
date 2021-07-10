using EntrepreneurManagement.Domain.StudentEntrepreneur;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrepreneurManagement.Infrastructure.EFCore.Mapping
{
    public class StudentEntrepreneurMapping : IEntityTypeConfiguration<StudentEntrepreneur>
    {
        public void Configure(EntityTypeBuilder<StudentEntrepreneur> builder)
        {
            builder.ToTable("StudentEntrepreneur");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.StudentName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.StudentFamily).IsRequired().HasMaxLength(350);
            builder.Property(x => x.StudentNationalId).IsRequired().HasMaxLength(150);
            builder.Property(x => x.StudentBirthDate).IsRequired();
            builder.Property(x => x.Education).IsRequired().HasMaxLength(250);
            builder.Property(x => x.StudentSchool).IsRequired().HasMaxLength(350);
            builder.Property(x => x.StudentCity).IsRequired().HasMaxLength(450);
            builder.Property(x => x.ParentFullname).IsRequired().HasMaxLength(250);
            builder.Property(x => x.ParentNationalId).IsRequired().HasMaxLength(150);
            builder.Property(x => x.ParentJob).IsRequired().HasMaxLength(350);
            builder.Property(x => x.StudentPhone).IsRequired().HasMaxLength(50);
            builder.Property(x => x.StudentMobile).IsRequired().HasMaxLength(50);
            builder.Property(x => x.StudentAddress).IsRequired();
            builder.Property(x => x.StudentNationalCardPicture).IsRequired();
        }
    }
}
