using System.Collections.Generic;
using _0_Framework.Application;
using ImageGalleryManagement.Application.Contract.Managers;
using ImageGalleryManagement.Application.Contract.Slider;
using ImageGalleryManagement.Domain.Managers;
using Microsoft.AspNetCore.Http;

namespace ImageGalleryManagement.Application
{
    public class ManagersApplication : IManagersApplication
    {
        private readonly IManagersRepository _managersRepository;
        private readonly IFileUploader _fileUploader;

        public ManagersApplication(IManagersRepository managersRepository, IFileUploader fileUploader)
        {
            _managersRepository = managersRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateManagers command)
        {
            var operation = new OperationResult();
            var fileName = _fileUploader.Upload(command.Picture, "Managers");

            var manager = new Managers(command.Fullname,command.JobPosition,command.OrganizationType,command.Email,command.Phone,
                command.Mobile,fileName,command.PictureAlt,command.PictureTitle);

            _managersRepository.Create(manager);
            _managersRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditManagers command)
        {
            var operation = new OperationResult();
            var manager = _managersRepository.Get(command.Id);

            if (manager == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var fileName = _fileUploader.Upload(command.Picture, "Slider");

            manager.Edit(command.Fullname, command.JobPosition, command.OrganizationType, command.Email, command.Phone,
                command.Mobile, fileName, command.PictureAlt, command.PictureTitle);

            _managersRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var manager = _managersRepository.Get(id);

            if (manager == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            manager.Remove();

            _managersRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var manager = _managersRepository.Get(id);

            if (manager == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            manager.Restore();

            _managersRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditManagers GetDetails(long id)
        {
            return _managersRepository.GetDetails(id);
        }

        public List<ManagersViewModel> GetList()
        {
            return _managersRepository.GetList();
        }
    }
}
