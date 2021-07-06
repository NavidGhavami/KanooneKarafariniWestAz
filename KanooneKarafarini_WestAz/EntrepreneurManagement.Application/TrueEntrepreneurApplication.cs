using System.Collections.Generic;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.TrueEntrepreneur;
using EntrepreneurManagement.Domain.TrueEntrepreneur;

namespace EntrepreneurManagement.Application
{
    public class TrueEntrepreneurApplication : ITrueEntrepreneurApplication
    {
        private readonly ITrueEntrepreneurRepository _trueEntrepreneurRepository;
        private readonly IFileUploader _fileUploader;

        public TrueEntrepreneurApplication(ITrueEntrepreneurRepository trueEntrepreneurRepository, IFileUploader fileUploader)
        {
            _trueEntrepreneurRepository = trueEntrepreneurRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Register(RegisterTrueEntrepreneur command)
        {
            var operation = new OperationResult();
            var fileName = _fileUploader.Upload(command.Resume, "TrueEntrepreneur");

            var trueEntrepreneur = new TrueEntrepreneur(command.Name, command.Family, command.NationalId, command.BirthDate,
                command.ActivitySubject, command.City, command.Address, command.Phone, command.Mobile, fileName);

            _trueEntrepreneurRepository.Create(trueEntrepreneur);
            _trueEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditTrueEntrepreneur command)
        {
            var operation = new OperationResult();
            var trueEntrepreneur = _trueEntrepreneurRepository.Get(command.Id);

            if (trueEntrepreneur == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var fileName = _fileUploader.Upload(command.Resume, "TrueEntrepreneur");

            trueEntrepreneur.Edit(command.Name, command.Family, command.NationalId, command.BirthDate,
                command.ActivitySubject, command.City, command.Address, command.Phone, command.Mobile, fileName);

            _trueEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditTrueEntrepreneur GetDetails(long id)
        {
            return _trueEntrepreneurRepository.GetDetails(id);
        }

        public List<TrueEntrepreneurViewModel> Search(TrueEntrepreneurSearchModel searchModel)
        {
            return _trueEntrepreneurRepository.Search(searchModel);
        }

        public TrueEntrepreneurViewModel GetTrueEntrepreneurInformationBy(long id)
        {
            return _trueEntrepreneurRepository.GetTrueEntrepreneurInformationBy(id);
        }

        public string GetResumeBy(long id)
        {
            return _trueEntrepreneurRepository.GetResumeBy(id);
        }
    }
}
