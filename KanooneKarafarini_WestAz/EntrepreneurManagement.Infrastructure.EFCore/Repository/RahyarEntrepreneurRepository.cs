using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using EntrepreneurManagement.Application.Contract.RahyarEntrepreneur;
using EntrepreneurManagement.Domain.RahyarEntrepreneur;

namespace EntrepreneurManagement.Infrastructure.EFCore.Repository
{
    public class RahyarEntrepreneurRepository : RepositoryBase<long, RahyarEntrepreneur> , IRahyarEntrepreneurRepository
    {
        private readonly EntrepreneurContext _entrepreneurContext;
        public RahyarEntrepreneurRepository(EntrepreneurContext entrepreneurContext) : base(entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public EditRahyarEntrepreneur GetDetails(long id)
        {
            return _entrepreneurContext.RahyarEntrepreneurs.Select(x => new EditRahyarEntrepreneur
            {
                Id = x.Id,
                RahyarName = x.RahyarName,
                RahyarFamily = x.RahyarFamily,
                RahyarNationalId = x.RahyarNationalId,
                RahyarBirthDate = x.RahyarBirthDate,
                RahyarEducation = x.RahyarEducation,
                RahyarCourse = x.RahyarCourse,
                RahyarCity = x.RahyarCity,
                RahyarPhone = x.RahyarPhone,
                RahyarMobile = x.RahyarMobile,
                RahyarAddress = x.RayharAddress,



            }).FirstOrDefault(x => x.Id == id);
        }

        public List<RahyarEntrepreneurViewModel> Search(RahyarEntrepreneurSearchModel searchModel)
        {
            var query = _entrepreneurContext.RahyarEntrepreneurs
                .Select(x => new RahyarEntrepreneurViewModel
                {
                    Id = x.Id,
                    RahyarName = x.RahyarName,
                    RahyarFamily = x.RahyarFamily,
                    RahyarNationalId = x.RahyarNationalId,
                    RahyarBirthDate = x.RahyarBirthDate,
                    RahyarEducation = x.RahyarEducation,
                    RahyarCourse = x.RahyarCourse,
                    RahyarCity = x.RahyarCity,
                    RahyarPhone = x.RahyarPhone,
                    RahyarMobile = x.RahyarMobile,
                    RahyarAddress = x.RayharAddress,
                    CreationDate = x.CreationDate.ToFarsi()

                });

            if (!string.IsNullOrWhiteSpace(searchModel.RahyarName))
            {
                query = query.Where(x => x.RahyarName.Contains(searchModel.RahyarName));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.RahyarFamily))
            {
                query = query.Where(x => x.RahyarFamily.Contains(searchModel.RahyarFamily));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.RahyarNationalId))
            {
                query = query.Where(x => x.RahyarNationalId.Contains(searchModel.RahyarNationalId));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.RahyarMobile))
            {
                query = query.Where(x => x.RahyarMobile.Contains(searchModel.RahyarMobile));
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public RahyarEntrepreneurViewModel GetRahyarEntrepreneurInformationBy(long id)
        {
            var info = _entrepreneurContext.RahyarEntrepreneurs.FirstOrDefault(x => x.Id == id);

            if (info == null)
            {
                return new RahyarEntrepreneurViewModel();
            }

            var information = new RahyarEntrepreneurViewModel
            {
                Id = info.Id,
                RahyarName = info.RahyarName,
                RahyarFamily = info.RahyarFamily,
                RahyarNationalId = info.RahyarNationalId,
                RahyarBirthDate = info.RahyarBirthDate,
                RahyarEducation = info.RahyarEducation,
                RahyarCourse = info.RahyarCourse,
                RahyarCity = info.RahyarCity,
                RahyarPhone = info.RahyarPhone,
                RahyarMobile = info.RahyarMobile,
                RahyarAddress = info.RayharAddress,
                CreationDate = info.CreationDate.ToFarsi()
            };

            return information;
        }

        public string GetResumeBy(long id)
        {
            var resume = _entrepreneurContext.RahyarEntrepreneurs.FirstOrDefault(x => x.Id == id);

            if (resume == null)
            {
                return new string("");
            }

            return resume.RahyarResume;
        }
    }
}
