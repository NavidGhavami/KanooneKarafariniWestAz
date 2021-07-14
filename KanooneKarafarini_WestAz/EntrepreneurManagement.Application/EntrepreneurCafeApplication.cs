using System.Collections.Generic;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.EntrepreneurServices.EntrepreneurCafe;
using EntrepreneurManagement.Domain.EntrepreneurServices.EntrepreneurCafe;

namespace EntrepreneurManagement.Application
{
    public class EntrepreneurCafeApplication : IEntrepreneurCafeApplication
    {
        private readonly IEntrepreneurCafeRepository _entrepreneurCafeRepository;

        public EntrepreneurCafeApplication(IEntrepreneurCafeRepository entrepreneurCafeRepository)
        {
            _entrepreneurCafeRepository = entrepreneurCafeRepository;
        }

        public OperationResult Create(CreateEntrepreneurCafe command)
        {
            var operation = new OperationResult();

            var entrepreneurCafe = new EntrepreneurCafe(command.CafeName,command.CafeCity,command.CafeManager,command.CafeLeader,command.CafeManagerMobile,command.CafeLeaderMobile);

            _entrepreneurCafeRepository.Create(entrepreneurCafe);
            _entrepreneurCafeRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditEntrepreneurCafe command)
        {
            var operation = new OperationResult();

            var entrepreneurCafe = _entrepreneurCafeRepository.Get(command.Id);

            if (entrepreneurCafe == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            entrepreneurCafe.Edit(command.CafeName, command.CafeCity, command.CafeManager, command.CafeLeader, command.CafeManagerMobile, command.CafeLeaderMobile);

            _entrepreneurCafeRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditEntrepreneurCafe GetDetails(long id)
        {
            return _entrepreneurCafeRepository.GetDetails(id);
        }

        public List<EntrepreneurCafeViewModel> Search(EntrepreneurCafeSearchModel searchModel)
        {
            return _entrepreneurCafeRepository.Search(searchModel);
        }
    }
}
