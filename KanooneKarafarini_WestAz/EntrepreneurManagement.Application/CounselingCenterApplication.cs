using System.Collections.Generic;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.CounselingCenter;
using EntrepreneurManagement.Domain.EntrepreneurServices.CouncelingCenter;

namespace EntrepreneurManagement.Application
{
    public class CounselingCenterApplication : ICounselingCenterApplication
    {
        private readonly ICouncelingCenterRepository _councelingCenterRepository;

        public CounselingCenterApplication(ICouncelingCenterRepository councelingCenterRepository)
        {
            _councelingCenterRepository = councelingCenterRepository;
        }

        public OperationResult Create(CreateCouncelingCenter command)
        {
            var operation = new OperationResult();

            var counselingCenter = new CounselingCenter(command.CouncelingCenterName,command.CouncelingCenterActivity,command.ManagerName,
                command.CouncelingCenterPhone,command.CouncelingCenterMobile,command.CouncelingCenterAddress,command.Description);

            _councelingCenterRepository.Create(counselingCenter);
            _councelingCenterRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditCouncelingCenter command)
        {
            var operation = new OperationResult();
            var counselingCenter = _councelingCenterRepository.Get(command.Id);

            if (counselingCenter == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }


            counselingCenter.Edit(command.CouncelingCenterName,command.CouncelingCenterActivity,command.ManagerName,
            command.CouncelingCenterPhone,command.CouncelingCenterMobile,command.CouncelingCenterAddress,command.Description);

            _councelingCenterRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditCouncelingCenter GetDetails(long id)
        {
            return _councelingCenterRepository.GetDetails(id);
        }

        public CouncelingCenterViewModel GetInformationBy(long id)
        {
            return _councelingCenterRepository.GetInformationBy(id);
        }

        public List<CouncelingCenterViewModel> GetList()
        {
            return _councelingCenterRepository.GetList();
        }

        public List<CouncelingCenterViewModel> Search(CounselingCenterSearchModel searchModel)
        {
            return _councelingCenterRepository.Search(searchModel);
        }
    }
}
