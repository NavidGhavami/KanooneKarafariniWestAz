using System.Collections.Generic;

namespace _01_Query.Contract.Managers
{
    public interface IManagerQuery
    {
        List<ManagerQueryModel> GetManager();
    }
}
