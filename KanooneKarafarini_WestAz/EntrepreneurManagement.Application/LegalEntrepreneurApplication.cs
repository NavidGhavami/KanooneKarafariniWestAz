using System.Collections.Generic;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.LegalEntrepreneur;
using EntrepreneurManagement.Domain.LegalEntrepreneur;

namespace EntrepreneurManagement.Application
{
    public class LegalEntrepreneurApplication : ILegalEntrepreneurApplication
    {
        private readonly ILegalEntrepreneurRepository _legalEntrepreneurRepository;
        private readonly IFileUploader _fileUploader;

        public LegalEntrepreneurApplication(ILegalEntrepreneurRepository legalEntrepreneurRepository, IFileUploader fileUploader)
        {
            _legalEntrepreneurRepository = legalEntrepreneurRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Register(RegisterLegalEntrepreneur command)
        {
            var operation = new OperationResult();
            var fileName = _fileUploader.Upload(command.CompanyResume, "LegalEntrepreneur");

            var legalEntrepreneur = new LegalEntrepreneur(command.Company,command.CompanyId,command.ManagerName,command.ManagerFamily,
                command.ManagerNationalId,command.CompanySubject,command.CompanyCity,command.CompanyAddress,command.CompanyPhone,
                command.CompanyMobile,fileName);

            _legalEntrepreneurRepository.Create(legalEntrepreneur);
            _legalEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditLegalEntrepreneur command)
        {
            var operation = new OperationResult();
            var legalEntrepreneur = _legalEntrepreneurRepository.Get(command.Id);

            if (legalEntrepreneur == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var fileName = _fileUploader.Upload(command.CompanyResume, "LegalEntrepreneur");

            legalEntrepreneur.Edit(command.Company, command.CompanyId, command.ManagerName, command.ManagerFamily,
                command.ManagerNationalId, command.CompanySubject, command.CompanyCity, command.CompanyAddress, command.CompanyPhone,
                command.CompanyMobile, fileName);

            _legalEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditLegalEntrepreneur GetDetails(long id)
        {
            return _legalEntrepreneurRepository.GetDetails(id);
        }

        public List<LegalEntrepreneurViewModel> Search(LegalEntrepreneurSearchModel searchModel)
        {
            return _legalEntrepreneurRepository.Search(searchModel);
        }

        public LegalEntrepreneurViewModel GetLegalEntrepreneurInformationBy(long id)
        {
            return _legalEntrepreneurRepository.GetLegalEntrepreneurInformationBy(id);
        }

        public string GetResumeBy(long id)
        {
            return _legalEntrepreneurRepository.GetResumeBy(id);
        }
    }
}
