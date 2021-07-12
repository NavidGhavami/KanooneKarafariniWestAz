using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.SubmitIdea;
using EntrepreneurManagement.Domain.EntrepreneurServices.SubmitIdea;

namespace EntrepreneurManagement.Infrastructure.EFCore.Repository
{
    public class SubmitIdeaRepository : RepositoryBase<long , SubmitIdea>, ISubmitIdeaRepository
    {
        private readonly EntrepreneurContext _entrepreneurContext;

        public SubmitIdeaRepository(EntrepreneurContext entrepreneurContext) : base(entrepreneurContext)
        {
            _entrepreneurContext = entrepreneurContext;
        }

        public EditSubmitIdea GetDetails(long id)
        {
            return _entrepreneurContext.SubmitIdeas.Select(x => new EditSubmitIdea
            {
                Id = x.Id,
                ApplicantName = x.ApplicantName,
                ApplicantFamily=x.ApplicantFamily,
                ApplicantNationalId = x.ApplicantNationalId,
                ProposalSubject = x.ProposalSubject,
                ApplicantPhone = x.ApplicantPhone,
                ApplicantMobile = x.ApplicantMobile,
                ApplicantAddress = x.ApplicantAddress,


            }).FirstOrDefault(x => x.Id == id);
        }

        public List<SubmitIdeaViewModel> GetList()
        {
            return _entrepreneurContext.SubmitIdeas.Select(x => new SubmitIdeaViewModel
            {
                Id = x.Id,
                ApplicantName = x.ApplicantName,
                ApplicantFamily = x.ApplicantFamily,
                ApplicantNationalId = x.ApplicantNationalId,
                ProposalSubject = x.ProposalSubject,
                ApplicantPhone = x.ApplicantPhone,
                ApplicantMobile = x.ApplicantMobile,
                ApplicantAddress = x.ApplicantAddress,
                CreationDate = x.CreationDate.ToFarsi()



            }).OrderByDescending(x=>x.Id).ToList();
        }

        public SubmitIdeaViewModel GetInformationBy(long id)
        {
            return _entrepreneurContext.SubmitIdeas.Select(x => new SubmitIdeaViewModel
            {
                Id = x.Id,
                ApplicantName = x.ApplicantName,
                ApplicantFamily = x.ApplicantFamily,
                ApplicantNationalId = x.ApplicantNationalId,
                ProposalSubject = x.ProposalSubject,
                ApplicantPhone = x.ApplicantPhone,
                ApplicantMobile = x.ApplicantMobile,
                ApplicantAddress = x.ApplicantAddress,
                CreationDate = x.CreationDate.ToFarsi()



            }).FirstOrDefault(x => x.Id == id);
        }

        public string GetSummaryProposalBy(long id)
        {
            var summaryProposal = _entrepreneurContext.SubmitIdeas.FirstOrDefault(x => x.Id == id);

            if (summaryProposal == null)
            {
                return new string("");
            }

            return summaryProposal.SummaryProposal;
        }
    }
}
