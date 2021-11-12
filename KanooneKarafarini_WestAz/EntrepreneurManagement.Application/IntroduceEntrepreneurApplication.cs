using System.Collections.Generic;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceEntrepreneur;
using EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceEntrepreneur;

namespace EntrepreneurManagement.Application
{
    public class IntroduceEntrepreneurApplication : IIntroduceEntrepreneurApplication
    {
        private readonly IIntroduceEntrepreneurRepository _introduceEntrepreneurRepository;
        private readonly IFileUploader _fileUploader;

        public IntroduceEntrepreneurApplication(IIntroduceEntrepreneurRepository introduceEntrepreneurRepository, IFileUploader fileUploader)
        {
            _introduceEntrepreneurRepository = introduceEntrepreneurRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateIntroduceEntrepreneur command)
        {
            var operation = new OperationResult();
            var resumePath = $"{"IntroduceEntrepreneur"}/{"Resume"}";
            var photoPath = $"{"IntroduceEntrepreneur"}/{"Photo"}";
            var fileNameResume = _fileUploader.Upload(command.ResumeFile, resumePath);
            var fileNamePhoto = _fileUploader.Upload(command.Photo, photoPath);

            var introduceEntrepreneur = new IntroduceEntrepreneur(command.Fullname,command.Job,command.StateTitle,fileNameResume,command.ResumeDescription,fileNamePhoto);

            _introduceEntrepreneurRepository.Create(introduceEntrepreneur);
            _introduceEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditIntroduceEntrepreneur command)
        {
            var operation = new OperationResult();
            var introduceEntrepreneur = _introduceEntrepreneurRepository.Get(command.Id);

            if (introduceEntrepreneur == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var resumePath = $"{"IntroduceEntrepreneur"}/{"Resume"}";
            var photoPath = $"{"IntroduceEntrepreneur"}/{"Photo"}";
            var fileNameResume = _fileUploader.Upload(command.ResumeFile, resumePath);
            var fileNamePhoto = _fileUploader.Upload(command.Photo, photoPath);

            introduceEntrepreneur.Edit(command.Fullname, command.Job, command.StateTitle, fileNameResume, command.ResumeDescription, fileNamePhoto);

            _introduceEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditIntroduceEntrepreneur GetDetails(long id)
        {
            return _introduceEntrepreneurRepository.GetDetails(id);
        }

        public List<IntroduceEntrepreneurViewModel> Search(IntroduceEntrepreneurSearchModel searchModel)
        {
            return _introduceEntrepreneurRepository.Search(searchModel);
        }

        public IntroduceEntrepreneurViewModel GetIntroduceEntrepreneurInformationBy(long id)
        {
            return _introduceEntrepreneurRepository.GetIntroduceEntrepreneurInformationBy(id);
        }

        public string GetResumeBy(long id)
        {
            return _introduceEntrepreneurRepository.GetResumeBy(id);
        }
    }
}
