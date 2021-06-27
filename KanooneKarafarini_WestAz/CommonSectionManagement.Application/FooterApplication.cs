using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using _0_Framework.Application;
using CommonSectionManagement.Application.Contract.Footer;
using CommonSectionManagement.Domain.Footer;

namespace CommonSectionManagement.Application
{
    public class FooterApplication : IFooterApplication
    {
        private readonly IFooterRepository _footerRepository;

        public FooterApplication(IFooterRepository footerRepository)
        {
            _footerRepository = footerRepository;
        }

        public OperationResult Create(CreateFooter command)
        {
            var operation = new OperationResult();

            var slider = new Footer(command.Address,command.Phone,command.Mobile,command.Fax,command.Email);

            _footerRepository.Create(slider);
            _footerRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditFooter command)
        {
            var operation = new OperationResult();
            var footer = _footerRepository.Get(command.Id);

            if (footer == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

          

            footer.Edit(command.Address, command.Phone, command.Mobile, command.Fax, command.Email);

            _footerRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var footer = _footerRepository.Get(id);

            if (footer == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            footer.Remove();

            _footerRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var footer = _footerRepository.Get(id);

            if (footer == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            footer.Restore();

            _footerRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditFooter GetDetails(long id)
        {
            return _footerRepository.GetDetails(id);
        }

        public List<FooterViewModel> GetList()
        {
            return _footerRepository.GetList();
        }
    }
}
