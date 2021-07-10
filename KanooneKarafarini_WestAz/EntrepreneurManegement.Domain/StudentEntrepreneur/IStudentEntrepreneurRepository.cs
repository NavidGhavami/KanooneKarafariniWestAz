using System.Collections.Generic;
using _0_Framework.Domain;
using EntrepreneurManagement.Application.Contract.StudentEntrepreneur;

namespace EntrepreneurManagement.Domain.StudentEntrepreneur
{
    public interface IStudentEntrepreneurRepository : IRepository<long, StudentEntrepreneur>
    {
        EditStudentEntrepreneur GetDetails(long id);
        List<StudentEntrepreneurViewModel> Search(StudentEntrepreneurSearchModel searchModel);
        StudentEntrepreneurViewModel GetStudentEntrepreneurInformationBy(long id);
        string GetNationalCardPictureBy(long id);
    }
}
