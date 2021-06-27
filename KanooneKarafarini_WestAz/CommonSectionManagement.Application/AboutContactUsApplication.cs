using System.Collections.Generic;
using _0_Framework.Application;
using CommonSectionManagement.Application.Contract.AboutContactUs;
using CommonSectionManagement.Domain.AboutContactUs;

namespace CommonSectionManagement.Application
{
    public class AboutContactUsApplication : IAboutContactUsApplication
    {
        private readonly IAboutContactUsRepository _aboutContactUsRepository;

        public AboutContactUsApplication(IAboutContactUsRepository aboutContactUsRepository)
        {
            _aboutContactUsRepository = aboutContactUsRepository;
        }

        public OperationResult Create(CreateAboutContactUs command)
        {
            var operation = new OperationResult();

            var aboutContact = new AboutContactUs(command.AboutUsText,command.ContactUsText,command.Address,
                command.Phone,command.Mobile, command.Fax,command.Email,command.GoogleMap);

            _aboutContactUsRepository.Create(aboutContact);
            _aboutContactUsRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditAboutContactUs command)
        {
            var operation = new OperationResult();
            var aboutContact = _aboutContactUsRepository.Get(command.Id);

            if (aboutContact == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            aboutContact.Edit(command.AboutUsText, command.ContactUsText, command.Address,
                command.Phone, command.Mobile, command.Fax, command.Email, command.GoogleMap);

            _aboutContactUsRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var aboutContact = _aboutContactUsRepository.Get(id);

            if (aboutContact == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            aboutContact.Remove();

            _aboutContactUsRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var aboutContact = _aboutContactUsRepository.Get(id);

            if (aboutContact == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            aboutContact.Restore();

            _aboutContactUsRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditAboutContactUs GetDetails(long id)
        {
            return _aboutContactUsRepository.GetDetails(id);
        }

        public List<AboutContactUsViewModel> GetList()
        {
            return _aboutContactUsRepository.GetList();
        }
    }
}
