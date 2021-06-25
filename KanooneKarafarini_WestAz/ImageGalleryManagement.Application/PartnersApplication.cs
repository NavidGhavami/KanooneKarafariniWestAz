using System.Collections.Generic;
using _0_Framework.Application;
using ImageGalleryManagement.Application.Contract.Partners;
using ImageGalleryManagement.Domain.Partners;

namespace ImageGalleryManagement.Application
{
    public class PartnersApplication : IPartnersApplication
    {
        private readonly IPartnersRepository _partnersRepository;
        private readonly IFileUploader _fileUploader;

        public PartnersApplication(IPartnersRepository partnersRepository, IFileUploader fileUploader)
        {
            _partnersRepository = partnersRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreatePartners command)
        {
            var operation = new OperationResult();
            var fileName = _fileUploader.Upload(command.Picture, "Partners");

            var partner = new Partners(command.Name,fileName,command.PictureAlt,command.PictureTitle,command.Link);

            _partnersRepository.Create(partner);
            _partnersRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditPartners command)
        {
            var operation = new OperationResult();
            var slider = _partnersRepository.Get(command.Id);

            if (slider == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var fileName = _fileUploader.Upload(command.Picture, "Partners");

            slider.Edit(command.Name, fileName, command.PictureAlt, command.PictureTitle, command.Link);

            _partnersRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var partner = _partnersRepository.Get(id);

            if (partner == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            partner.Remove();

            _partnersRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var partner = _partnersRepository.Get(id);

            if (partner == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            partner.Restore();

            _partnersRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditPartners GetDetails(long id)
        {
            return _partnersRepository.GetDetails(id);
        }

        public List<PartnersViewModel> GetList()
        {
            return _partnersRepository.GetList();
        }
    }
}
