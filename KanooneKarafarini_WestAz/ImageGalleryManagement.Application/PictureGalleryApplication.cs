using _0_Framework.Application;
using ImageGalleryManagement.Application.Contract.PictureGallery;
using ImageGalleryManagement.Domain.PictureGallery;
using System.Collections.Generic;

namespace ImageGalleryManagement.Application
{
    public class PictureGalleryApplication : IPictureGalleryApplication
    {

        private readonly IPictureGalleryRepository _pictureGalleryRepository;
        private readonly IFileUploader _fileUploader;

        public PictureGalleryApplication(IPictureGalleryRepository pictureGalleryRepository, IFileUploader fileUploader)
        {
            _pictureGalleryRepository = pictureGalleryRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreatePictureGallery command)
        {
            var operation = new OperationResult();
            var fileName = _fileUploader.Upload(command.Picture, "PictureGallery");

            var pictureGallery = new PictureGallery(fileName, command.PictureAlt, command.PictureTitle);

            _pictureGalleryRepository.Create(pictureGallery);
            _pictureGalleryRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditPictureGallery command)
        {
            var operation = new OperationResult();
            var pictureGallery = _pictureGalleryRepository.Get(command.Id);

            if (pictureGallery == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var fileName = _fileUploader.Upload(command.Picture, "PictureGallery");

            pictureGallery.Edit(fileName,command.PictureAlt,command.PictureTitle);

            _pictureGalleryRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditPictureGallery GetDetails(long id)
        {
            return _pictureGalleryRepository.GetDetails(id);
        }

        public List<PictureGalleryViewModel> GetList()
        {
            return _pictureGalleryRepository.GetList();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var pictureGallery = _pictureGalleryRepository.Get(id);

            if (pictureGallery == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            pictureGallery.Remove();

            _pictureGalleryRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var pictureGallery = _pictureGalleryRepository.Get(id);

            if (pictureGallery == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            pictureGallery.Restore();

            _pictureGalleryRepository.SaveChanges();

            return operation.Succedded();
        }
    }
}
