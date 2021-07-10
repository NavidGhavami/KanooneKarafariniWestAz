using System.Collections.Generic;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.RahyarEntrepreneur;
using EntrepreneurManagement.Domain.RahyarEntrepreneur;

namespace EntrepreneurManagement.Application
{
    public class RahyarEntrepreneurApplication : IRahyarEntrepreneurApplication
    {
        private readonly IRahyarEntrepreneurRepository _rahyarEntrepreneurRepository;
        private readonly IFileUploader _fileUploader;

        public RahyarEntrepreneurApplication(IRahyarEntrepreneurRepository rahyarEntrepreneurRepository, IFileUploader fileUploader)
        {
            _rahyarEntrepreneurRepository = rahyarEntrepreneurRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Register(RegisterRahyarEntrepreneur command)
        {
            var operation = new OperationResult();
            var fileName = _fileUploader.Upload(command.RahyarResume, "RahyarEntrepreneur");

            var rahyarEntrepreneur = new RahyarEntrepreneur(command.RahyarName,command.RahyarFamily,command.RahyarNationalId,command.RahyarBirthDate,command.RahyarEducation,
                command.RahyarCourse,command.RahyarCity,command.RahyarPhone,command.RahyarMobile,command.RahyarAddress,fileName);

            _rahyarEntrepreneurRepository.Create(rahyarEntrepreneur);
            _rahyarEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditRahyarEntrepreneur command)
        {
            var operation = new OperationResult();
            var rahyarEntrepreneur = _rahyarEntrepreneurRepository.Get(command.Id);

            if (rahyarEntrepreneur == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var fileName = _fileUploader.Upload(command.RahyarResume, "RahyarEntrepreneur");

            rahyarEntrepreneur.Edit(command.RahyarName, command.RahyarFamily, command.RahyarNationalId, command.RahyarBirthDate, command.RahyarEducation,
                command.RahyarCourse, command.RahyarCity, command.RahyarPhone, command.RahyarMobile, command.RahyarAddress, fileName);

            _rahyarEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditRahyarEntrepreneur GetDetails(long id)
        {
            return _rahyarEntrepreneurRepository.GetDetails(id);
        }

        public List<RahyarEntrepreneurViewModel> Search(RahyarEntrepreneurSearchModel searchModel)
        {
            return _rahyarEntrepreneurRepository.Search(searchModel);
        }

        public RahyarEntrepreneurViewModel GetRahyarEntrepreneurInformationBy(long id)
        {
            return _rahyarEntrepreneurRepository.GetRahyarEntrepreneurInformationBy(id);
        }

        public string GetResumeBy(long id)
        {
            return _rahyarEntrepreneurRepository.GetResumeBy(id);
        }
    }
}
