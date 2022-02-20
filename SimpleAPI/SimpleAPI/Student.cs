using System;

namespace SimpleAPI
{
	public class Student : IStudent
	{
        private string theBestStudentName { get; set; }

        private List<string> students { get; set; } = new List<string>();

        public Student()
		{
            theBestStudentName = "Hamza";
		}

        public async Task AddNewStudent(string Name)
        {
            this.students.Add(Name);
        }

        public async Task ChangeTheBestStudentName(string Name)
        {
            this.theBestStudentName = Name;
        }

        public async Task<List<string>> GetAllStudents()
        {
            return students;
        }

        public async Task<string> GetTheBestStudentName()
        {
            return theBestStudentName;
        }

        public async Task DeleteBestStudent()
        {
            this.theBestStudentName = "No Student";
        }
    }
}

