using System.Collections.Generic;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.BenefactorEntrepreneur;
using EntrepreneurManagement.Domain.BenefactorEntrepreneur;

namespace EntrepreneurManagement.Application
{
    public class BenefactorEntrepreneurApplication : IBenefactorEntrepreneurApplication
    {
        private readonly IBenefactorEntrepreneurRepository _benefactorEntrepreneurRepository;
        private readonly IFileUploader _fileUploader;

        public BenefactorEntrepreneurApplication(IBenefactorEntrepreneurRepository benefactorEntrepreneurRepository, IFileUploader fileUploader)
        {
            _benefactorEntrepreneurRepository = benefactorEntrepreneurRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Register(RegisterBenefactorEntrepreneur command)
        {
            var operation = new OperationResult();

            var trueEntrepreneur = new BenefactorEntrepreneur(command.BenefactorName,command.BenefactorFamily,command.BenefactorNationalId,command.BenefactorJob,
                command.BenefactorCooperation,command.BenefactorPhone,command.BenefactorMobile,command.BenefactorAddress,command.CooperationDescription);

            _benefactorEntrepreneurRepository.Create(trueEntrepreneur);
            _benefactorEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditBenefactorEntrepreneur command)
        {
            var operation = new OperationResult();
            var benefactorEntrepreneur = _benefactorEntrepreneurRepository.Get(command.Id);

            if (benefactorEntrepreneur == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }


            benefactorEntrepreneur.Edit(command.BenefactorName, command.BenefactorFamily, command.BenefactorNationalId, command.BenefactorJob,
                command.BenefactorCooperation, command.BenefactorPhone, command.BenefactorMobile, command.BenefactorAddress, command.CooperationDescription);

            _benefactorEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditBenefactorEntrepreneur GetDetails(long id)
        {
            return _benefactorEntrepreneurRepository.GetDetails(id);
        }

        public List<BenefactorEntrepreneurViewModel> Search(BenefactorEntrepreneurSearchModel searchModel)
        {
            return _benefactorEntrepreneurRepository.Search(searchModel);
        }

        public BenefactorEntrepreneurViewModel GetBenefactorEntrepreneurInformationBy(long id)
        {
            return _benefactorEntrepreneurRepository.GetBenefactorEntrepreneurInformationBy(id);
        }
    }
}
