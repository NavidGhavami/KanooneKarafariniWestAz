using System.Collections.Generic;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.SubmitIdea;
using EntrepreneurManagement.Domain.EntrepreneurServices.SubmitIdea;

namespace EntrepreneurManagement.Application
{
    public class SubmitIdeaApplication : ISubmitIdeaApplication
    {
        private readonly ISubmitIdeaRepository _submitIdeaRepository;
        private readonly IFileUploader _fileUploader;

        public SubmitIdeaApplication(ISubmitIdeaRepository submitIdeaRepository, IFileUploader fileUploader)
        {
            _submitIdeaRepository = submitIdeaRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateSubmitIdea command)
        {
            var operation = new OperationResult();
            var fileName = _fileUploader.Upload(command.SummaryProposal, "SummaryProposalFile");

            var submitIdea = new SubmitIdea(command.ApplicantName,command.ApplicantFamily,command.ApplicantNationalId,command.ProposalSubject,
                command.ApplicantPhone,command.ApplicantMobile,command.ApplicantAddress,fileName);

            _submitIdeaRepository.Create(submitIdea);
            _submitIdeaRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditSubmitIdea command)
        {
            var operation = new OperationResult();
            var submitIdea = _submitIdeaRepository.Get(command.Id);

            if (submitIdea == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var fileName = _fileUploader.Upload(command.SummaryProposal, "SummaryProposalFile");

            submitIdea.Edit(command.ApplicantName, command.ApplicantFamily, command.ApplicantNationalId, command.ProposalSubject,
                command.ApplicantPhone, command.ApplicantMobile, command.ApplicantAddress, fileName);

            _submitIdeaRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditSubmitIdea GetDetails(long id)
        {
            return _submitIdeaRepository.GetDetails(id);
        }

        public SubmitIdeaViewModel GetInformationBy(long id)
        {
            return _submitIdeaRepository.GetInformationBy(id);
        }

        public List<SubmitIdeaViewModel> GetList()
        {
            return _submitIdeaRepository.GetList();
        }

        public string GetSummaryProposalBy(long id)
        {
            return _submitIdeaRepository.GetSummaryProposalBy(id);
        }
    }
}
