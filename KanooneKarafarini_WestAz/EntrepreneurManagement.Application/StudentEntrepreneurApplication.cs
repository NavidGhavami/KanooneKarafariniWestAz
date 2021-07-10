using System.Collections.Generic;
using _0_Framework.Application;
using EntrepreneurManagement.Application.Contract.StudentEntrepreneur;
using EntrepreneurManagement.Domain.StudentEntrepreneur;

namespace EntrepreneurManagement.Application
{
    public class StudentEntrepreneurApplication : IStudentEntrepreneurApplication
    {
        private readonly IStudentEntrepreneurRepository _studentEntrepreneurRepository;
        private readonly IFileUploader _fileUploader;
        public StudentEntrepreneurApplication(IStudentEntrepreneurRepository studentEntrepreneurRepository, IFileUploader fileUploader)
        {
            _studentEntrepreneurRepository = studentEntrepreneurRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Register(RegisterStudentEntrepreneur command)
        {
            var operation = new OperationResult();
            var fileName = _fileUploader.Upload(command.StudentNationalCardPicture, "StudentNationalCard");

            var studentEntrepreneur = new StudentEntrepreneur(command.StudentName,command.StudentFamily,command.StudentNationalId,
                command.StudentBirthDate,command.Education,command.StudentCity,command.StudentSchool,command.ParentFullname,command.ParentNationalId,
                command.ParentJob,command.StudentPhone,command.StudentMobile,command.StudentAddress,fileName);

            _studentEntrepreneurRepository.Create(studentEntrepreneur);
            _studentEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditStudentEntrepreneur command)
        {
            var operation = new OperationResult();
            var studentEntrepreneur = _studentEntrepreneurRepository.Get(command.Id);

            if (studentEntrepreneur == null)
            {
                return operation.Failed(ApplicationMessages.RecordNotFound);
            }

            var fileName = _fileUploader.Upload(command.StudentNationalCardPicture, "StudentNationalCard");

            studentEntrepreneur.Edit(command.StudentName, command.StudentFamily, command.StudentNationalId,
                command.StudentBirthDate, command.Education, command.StudentCity, command.StudentSchool, command.ParentFullname, command.ParentNationalId,
                command.ParentJob, command.StudentPhone, command.StudentMobile, command.StudentAddress, fileName);

            _studentEntrepreneurRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditStudentEntrepreneur GetDetails(long id)
        {
            return _studentEntrepreneurRepository.GetDetails(id);
        }

        public List<StudentEntrepreneurViewModel> Search(StudentEntrepreneurSearchModel searchModel)
        {
            return _studentEntrepreneurRepository.Search(searchModel);
        }

        public StudentEntrepreneurViewModel GetStudentEntrepreneurInformationBy(long id)
        {
            return _studentEntrepreneurRepository.GetStudentEntrepreneurInformationBy(id);
        }

        public string GetNationalCardPictureBy(long id)
        {
            return _studentEntrepreneurRepository.GetNationalCardPictureBy(id);
        }
    }
}
