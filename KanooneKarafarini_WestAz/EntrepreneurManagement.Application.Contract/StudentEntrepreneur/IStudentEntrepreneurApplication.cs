using System.Collections.Generic;
using _0_Framework.Application;

namespace EntrepreneurManagement.Application.Contract.StudentEntrepreneur
{
    public interface IStudentEntrepreneurApplication
    {
        OperationResult Register(RegisterStudentEntrepreneur command);
        OperationResult Edit(EditStudentEntrepreneur command);
        EditStudentEntrepreneur GetDetails(long id);
        List<StudentEntrepreneurViewModel> Search(StudentEntrepreneurSearchModel searchModel);
        StudentEntrepreneurViewModel GetStudentEntrepreneurInformationBy(long id);
        string GetNationalCardPictureBy(long id);
    }
}
