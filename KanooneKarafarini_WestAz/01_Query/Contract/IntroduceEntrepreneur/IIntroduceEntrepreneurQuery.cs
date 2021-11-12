using System.Collections.Generic;

namespace _01_Query.Contract.IntroduceEntrepreneur
{
    public interface IIntroduceEntrepreneurQuery
    {
        List<IntroduceEntrepreneurQueryModel> GetIntroduceEntrepreneur();
        string GetResumeBy(long id);


    }
}
