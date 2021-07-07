using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using EntrepreneurManagement.Application.Contract.LegalEntrepreneur;
using EntrepreneurManagement.Domain.LegalEntrepreneur;

namespace EntrepreneurManagement.Infrastructure.EFCore.Repository
{
    public class LegalEntrepreneurRepository : RepositoryBase<long, LegalEntrepreneur> , ILegalEntrepreneurRepository
    {
        private readonly EntrepreneurContext _entrepreneurContext;
        public LegalEntrepreneurRepository(EntrepreneurContext entrepreneurContext) : base(entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public EditLegalEntrepreneur GetDetails(long id)
        {
            return _entrepreneurContext.LegalEntrepreneurs.Select(x => new EditLegalEntrepreneur
            { 
                Id = x.Id,
                Company = x.Company,
                CompanyId = x.CompanyId,
                ManagerName = x.ManagerName,
                ManagerFamily = x.ManagerFamily,
                ManagerNationalId = x.ManagerNationalId,
                CompanySubject = x.CompanySubject,
                CompanyAddress = x.CompanyAddress,
                CompanyCity = x.CompanyCity,
                CompanyMobile = x.CompanyMobile,
                CompanyPhone = x.CompanyPhone,
                

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<LegalEntrepreneurViewModel> Search(LegalEntrepreneurSearchModel searchModel)
        {
            var query = _entrepreneurContext.LegalEntrepreneurs
                .Select(x => new LegalEntrepreneurViewModel
                   
                {
                    Id = x.Id,
                    Company = x.Company,
                    CompanyId = x.CompanyId,
                    ManagerName = x.ManagerName,
                    ManagerFamily = x.ManagerFamily,
                    ManagerNationalId = x.ManagerNationalId,
                    CompanySubject = x.CompanySubject,
                    CompanyAddress = x.CompanyAddress,
                    CompanyCity = x.CompanyCity,
                    CompanyMobile = x.CompanyMobile,
                    CompanyPhone = x.CompanyPhone,
                    CreationDate = x.CreationDate.ToFarsi()


                });

            if (!string.IsNullOrWhiteSpace(searchModel.Company))
            {
                query = query.Where(x => x.Company.Contains(searchModel.Company));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.CompanyId))
            {
                query = query.Where(x => x.CompanyId.Contains(searchModel.CompanyId));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.ManagerName))
            {
                query = query.Where(x => x.ManagerName.Contains(searchModel.ManagerName));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.ManagerFamily))
            {
                query = query.Where(x => x.ManagerFamily.Contains(searchModel.ManagerFamily));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.ManagerNationalId))
            {
                query = query.Where(x => x.ManagerNationalId.Contains(searchModel.ManagerNationalId));
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public LegalEntrepreneurViewModel GetLegalEntrepreneurInformationBy(long id)
        {
            var info = _entrepreneurContext.LegalEntrepreneurs.FirstOrDefault(x => x.Id == id);

            if (info == null)
            {
                return new LegalEntrepreneurViewModel();
            }

            var information = new LegalEntrepreneurViewModel
            {
                Id = info.Id,
                Company = info.Company,
                CompanyId = info.CompanyId,
                ManagerName = info.ManagerName,
                ManagerFamily = info.ManagerFamily,
                ManagerNationalId = info.ManagerNationalId,
                CompanySubject = info.CompanySubject,
                CompanyAddress = info.CompanyAddress,
                CompanyCity = info.CompanyCity,
                CompanyMobile = info.CompanyMobile,
                CompanyPhone = info.CompanyPhone,
                CreationDate = info.CreationDate.ToFarsi()
            };

            return information;
        }

        public string GetResumeBy(long id)
        {
            var companyResume = _entrepreneurContext.LegalEntrepreneurs.FirstOrDefault(x => x.Id == id);

            if (companyResume == null)
            {
                return new string("");
            }

            return companyResume.CompanyResume;
        }
    }
}
