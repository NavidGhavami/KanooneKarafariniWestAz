using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using EntrepreneurManagement.Application.Contract.TrueEntrepreneur;
using EntrepreneurManagement.Domain.TrueEntrepreneur;

namespace EntrepreneurManagement.Infrastructure.EFCore.Repository
{
    public class TrueEntrepreneurRepository : RepositoryBase<long, TrueEntrepreneur>, ITrueEntrepreneurRepository
    {
        private readonly EntrepreneurContext _entrepreneurContext;
        public TrueEntrepreneurRepository(EntrepreneurContext entrepreneurContext) : base(entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public EditTrueEntrepreneur GetDetails(long id)
        {
            return _entrepreneurContext.TrueEntrepreneurs.Select(x => new EditTrueEntrepreneur
            {
                Id = x.Id,
                Name = x.Name,
                Family = x.Family,
                NationalId = x.NationalId,
                ActivitySubject = x.ActivitySubject,
                City = x.City,
                Address = x.Address,
                Phone = x.Phone,
                Mobile = x.Mobile,
                BirthDate = x.BirthDate,



            }).FirstOrDefault(x => x.Id == id);
        }

        public List<TrueEntrepreneurViewModel> Search(TrueEntrepreneurSearchModel searchModel)
        {
            var query = _entrepreneurContext.TrueEntrepreneurs
                .Select(x => new TrueEntrepreneurViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Family = x.Family,
                    NationalId = x.NationalId,
                    ActivitySubject = x.ActivitySubject,
                    City = x.City,
                    Address = x.Address,
                    Phone = x.Phone,
                    Mobile = x.Mobile,
                    BirthDate = x.BirthDate,
                    Resume = x.Resume,
                    CreationDate = x.CreationDate.ToFarsi()

                });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
            {
                query = query.Where(x => x.Name.Contains(searchModel.Name));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.Family))
            {
                query = query.Where(x => x.Family.Contains(searchModel.Family));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.NationalId))
            {
                query = query.Where(x => x.NationalId.Contains(searchModel.NationalId));
            }
            if (!string.IsNullOrWhiteSpace(searchModel.Mobile))
            {
                query = query.Where(x => x.Mobile.Contains(searchModel.Mobile));
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public TrueEntrepreneurViewModel GetTrueEntrepreneurInformationBy(long id)
        {
            var info = _entrepreneurContext.TrueEntrepreneurs.FirstOrDefault(x => x.Id == id);

            if (info == null)
            {
                return new TrueEntrepreneurViewModel();
            }

            var information = new TrueEntrepreneurViewModel
            {
                Id = info.Id,
                Name = info.Name,
                Family = info.Family,
                NationalId = info.NationalId,
                ActivitySubject = info.ActivitySubject,
                BirthDate = info.BirthDate,
                City = info.City,
                Phone = info.Phone,
                Mobile = info.Mobile,
                Address = info.Address,
                CreationDate = info.CreationDate.ToFarsi()
            };

            return information;
        }

        public string GetResumeBy(long id)
        {
            var resume = _entrepreneurContext.TrueEntrepreneurs.FirstOrDefault(x => x.Id == id);

            if (resume==null)
            {
                return new string("");
            }

            return resume.Resume;

        }
    }
}
