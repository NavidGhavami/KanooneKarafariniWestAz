using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.IntroduceArticle;
using EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceArticle;
using EntrepreneurManagement.Domain.EntrepreneurServices.IntroduceEntrepreneur;

namespace EntrepreneurManagement.Application
{
    public class IntroduceArticleApplication : IIntroduceArticleApplication
    {
        private readonly IIntroduceArticleRepository _introduceArticleRepository;
        private readonly IFileUploader _fileUploader;

        public IntroduceArticleApplication(IIntroduceArticleRepository introduceArticleRepository, IFileUploader fileUploader)
        {
            _introduceArticleRepository = introduceArticleRepository;
            _fileUploader = fileUploader;
        }
        public OperationResult Create(CreateIntroduceArticle command)
        {
            var operation = new OperationResult();
            var filePath = $"{"IntroduceArticle"}/{"File"}";
            var photoPath = $"{"IntroduceArticle"}/{"Photo"}";
            var fileName = _fileUploader.Upload(command.File, filePath);
            var fileNamePhoto = _fileUploader.Upload(command.Photo, photoPath);

            var introduceArticle = new IntroduceArticle(command.Title,command.StateTitle,fileNamePhoto,fileName);

            _introduceArticleRepository.Create(introduceArticle);
            _introduceArticleRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditIntroduceArticle command)
        {
            var operation = new OperationResult();
            var introduceArticle = _introduceArticleRepository.Get(command.Id);

            if (introduceArticle == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var filePath = $"{"IntroduceArticle"}/{"File"}";
            var photoPath = $"{"IntroduceArticle"}/{"Photo"}";
            var fileName = _fileUploader.Upload(command.File, filePath);
            var fileNamePhoto = _fileUploader.Upload(command.Photo, photoPath);

            introduceArticle.Edit(command.Title, command.StateTitle, fileNamePhoto, fileName);

            _introduceArticleRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditIntroduceArticle GetDetails(long id)
        {
            return _introduceArticleRepository.GetDetails(id);
        }

        public List<IntroduceArticleViewModel> Search(IntroduceArticleSearchModel searchModel)
        {
            return _introduceArticleRepository.Search(searchModel);
        }

        public IntroduceArticleViewModel GetIntroduceArticleInformationBy(long id)
        {
            return _introduceArticleRepository.GetIntroduceArticleInformationBy(id);
        }

        public string GetResumeBy(long id)
        {
            return _introduceArticleRepository.GetResumeBy(id);
        }
    }
}
