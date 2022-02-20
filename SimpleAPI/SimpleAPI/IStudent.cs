using System;
namespace SimpleAPI
{
	public interface IStudent
	{
		public  Task<string> GetTheBestStudentName();

		public Task<List<string>> GetAllStudents();

		public Task ChangeTheBestStudentName(string Name);

		public Task AddNewStudent(string Name);

		public Task DeleteBestStudent();

	}
}

