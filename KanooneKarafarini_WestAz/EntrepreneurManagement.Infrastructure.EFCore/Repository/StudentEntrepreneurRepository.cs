using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using EntrepreneurManagement.Application.Contract.StudentEntrepreneur;
using EntrepreneurManagement.Domain.StudentEntrepreneur;

namespace EntrepreneurManagement.Infrastructure.EFCore.Repository
{
    public class StudentEntrepreneurRepository : RepositoryBase<long, StudentEntrepreneur>,IStudentEntrepreneurRepository
    {
        private readonly EntrepreneurContext _entrepreneurContext;
        public StudentEntrepreneurRepository(EntrepreneurContext entrepreneurContext) : base(entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public EditStudentEntrepreneur GetDetails(long id)
        {
            return _entrepreneurContext.StudentEntrepreneurs.Select(x => new EditStudentEntrepreneur
            {
                Id = x.Id,
                StudentName = x.StudentName,
                StudentFamily = x.StudentFamily,
                StudentNationalId = x.StudentNationalId,
                StudentBirthDate = x.StudentBirthDate,
                Education = x.Education,
                StudentSchool = x.StudentSchool,
                StudentCity = x.StudentCity,
                ParentFullname = x.ParentFullname,
                ParentNationalId = x.ParentNationalId,
                ParentJob = x.ParentJob,
                StudentPhone = x.StudentPhone,
                StudentMobile = x.StudentMobile,
                StudentAddress = x.StudentAddress


            }).FirstOrDefault(x => x.Id == id);
        }

        public List<StudentEntrepreneurViewModel> Search(StudentEntrepreneurSearchModel searchModel)
        {
            var query = _entrepreneurContext.StudentEntrepreneurs
                .Select(x => new StudentEntrepreneurViewModel

                {
                    Id = x.Id,
                    StudentName = x.StudentName,
                    StudentFamily = x.StudentFamily,
                    StudentNationalId = x.StudentNationalId,
                    StudentBirthDate = x.StudentBirthDate,
                    Education = x.Education,
                    StudentSchool = x.StudentSchool,
                    StudentCity = x.StudentCity,
                    ParentFullname = x.ParentFullname,
                    ParentNationalId = x.ParentNationalId,
                    ParentJob = x.ParentJob,
                    StudentPhone = x.StudentPhone,
                    StudentMobile = x.StudentMobile,
                    StudentAddress = x.StudentAddress,
                    CreationDate = x.CreationDate.ToFarsi()


                });

            if (!string.IsNullOrWhiteSpace(searchModel.StudentName))
            {
                query = query.Where(x => x.StudentName.Contains(searchModel.StudentName));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.StudentFamily))
            {
                query = query.Where(x => x.StudentFamily.Contains(searchModel.StudentFamily));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.StudentNationalId))
            {
                query = query.Where(x => x.StudentNationalId.Contains(searchModel.StudentNationalId));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.ParentFullname))
            {
                query = query.Where(x => x.ParentFullname.Contains(searchModel.ParentFullname));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.StudentMobile))
            {
                query = query.Where(x => x.StudentMobile.Contains(searchModel.StudentMobile));
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public StudentEntrepreneurViewModel GetStudentEntrepreneurInformationBy(long id)
        {
            var info = _entrepreneurContext.StudentEntrepreneurs.FirstOrDefault(x => x.Id == id);

            if (info == null)
            {
                return new StudentEntrepreneurViewModel();
            }

            var information = new StudentEntrepreneurViewModel
            {
                Id = info.Id,
                StudentName = info.StudentName,
                StudentFamily = info.StudentFamily,
                StudentNationalId = info.StudentNationalId,
                StudentBirthDate = info.StudentBirthDate,
                Education = info.Education,
                StudentSchool = info.StudentSchool,
                StudentCity = info.StudentCity,
                ParentFullname = info.ParentFullname,
                ParentNationalId = info.ParentNationalId,
                ParentJob = info.ParentJob,
                StudentPhone = info.StudentPhone,
                StudentMobile = info.StudentMobile,
                StudentAddress = info.StudentAddress,
                CreationDate = info.CreationDate.ToFarsi()
            };

            return information;
        }

        public string GetNationalCardPictureBy(long id)
        {
            var nationalCardPicture = _entrepreneurContext.StudentEntrepreneurs.FirstOrDefault(x => x.Id == id);

            if (nationalCardPicture == null)
            {
                return new string("");
            }

            return nationalCardPicture.StudentNationalCardPicture;
        }
    }
}
