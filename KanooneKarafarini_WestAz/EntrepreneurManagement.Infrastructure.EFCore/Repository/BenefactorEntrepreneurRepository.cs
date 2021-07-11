using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using EntrepreneurManagement.Application.Contract.BenefactorEntrepreneur;
using EntrepreneurManagement.Domain.BenefactorEntrepreneur;
using Microsoft.EntityFrameworkCore;

namespace EntrepreneurManagement.Infrastructure.EFCore.Repository
{
    public class BenefactorEntrepreneurRepository : RepositoryBase<long,BenefactorEntrepreneur>, IBenefactorEntrepreneurRepository
    {
        private readonly EntrepreneurContext _entrepreneurContext;
        public BenefactorEntrepreneurRepository(EntrepreneurContext entrepreneurContext) : base(entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public EditBenefactorEntrepreneur GetDetails(long id)
        {
            return _entrepreneurContext.BenefactorEntrepreneurs.Select(x => new EditBenefactorEntrepreneur
            {
                Id = x.Id,
                BenefactorName = x.BenefactorName,
                BenefactorFamily = x.BenefactorFamily,
                BenefactorNationalId = x.BenefactorNationalId,
                BenefactorJob = x.BenefactorJob,
                BenefactorCooperation = x.BenefactorCooperation,
                BenefactorPhone = x.BenefactorPhone,
                BenefactorMobile = x.BenefactorMobile,
                BenefactorAddress = x.BenefactorAddress,
                CooperationDescription = x.CooperationDescription



            }).FirstOrDefault(x => x.Id == id);
        }

        public List<BenefactorEntrepreneurViewModel> Search(BenefactorEntrepreneurSearchModel searchModel)
        {
            var query = _entrepreneurContext.BenefactorEntrepreneurs
                .Select(x => new BenefactorEntrepreneurViewModel
                {
                    Id = x.Id,
                    BenefactorName = x.BenefactorName,
                    BenefactorFamily = x.BenefactorFamily,
                    BenefactorNationalId = x.BenefactorNationalId,
                    BenefactorJob = x.BenefactorJob,
                    BenefactorCooperation = x.BenefactorCooperation,
                    BenefactorPhone = x.BenefactorPhone,
                    BenefactorMobile = x.BenefactorMobile,
                    BenefactorAddress = x.BenefactorAddress,
                    CooperationDescription = x.CooperationDescription,
                    CreationDate = x.CreationDate.ToFarsi()

                });

            if (!string.IsNullOrWhiteSpace(searchModel.BenefactorName))
            {
                query = query.Where(x => x.BenefactorName.Contains(searchModel.BenefactorName));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.BenefactorFamily))
            {
                query = query.Where(x => x.BenefactorFamily.Contains(searchModel.BenefactorFamily));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.BenefactorNationalId))
            {
                query = query.Where(x => x.BenefactorNationalId.Contains(searchModel.BenefactorNationalId));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.BenefactorMobile))
            {
                query = query.Where(x => x.BenefactorMobile.Contains(searchModel.BenefactorMobile));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.BenefactorCooperation))
            {
                query = query.Where(x => x.BenefactorCooperation.Contains(searchModel.BenefactorCooperation));
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public BenefactorEntrepreneurViewModel GetBenefactorEntrepreneurInformationBy(long id)
        {
            var info = _entrepreneurContext.BenefactorEntrepreneurs.FirstOrDefault(x => x.Id == id);

            if (info == null)
            {
                return new BenefactorEntrepreneurViewModel();
            }

            var information = new BenefactorEntrepreneurViewModel
            {
                Id = info.Id,
                BenefactorName = info.BenefactorName,
                BenefactorFamily = info.BenefactorFamily,
                BenefactorNationalId = info.BenefactorNationalId,
                BenefactorJob = info.BenefactorJob,
                BenefactorCooperation = info.BenefactorCooperation,
                CooperationDescription = info.CooperationDescription,
                BenefactorPhone = info.BenefactorPhone,
                BenefactorMobile = info.BenefactorMobile,
                BenefactorAddress = info.BenefactorAddress,
                CreationDate = info.CreationDate.ToFarsi()
            };

            return information;
        }
    }
}
