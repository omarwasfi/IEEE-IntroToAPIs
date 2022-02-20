using System;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class StudentController : ControllerBase
	{ 
		private IStudent _student { get; set; }

        public StudentController(IStudent student)
		{
			this._student = student;
		}

		[HttpGet]
		[Route("GetTheBestStudentName")]
		public async Task<ActionResult<string>> GetTheBestStudentName()
        {
		
			return Ok(await _student.GetTheBestStudentName());
        }

		[HttpPut]
		[Route("ChangeTheBestStudentName")]
		public async Task<ActionResult> ChangeTheBestStudentName(string name)
		{
			await _student.ChangeTheBestStudentName(name);
			return Ok();
		}

		[HttpDelete]
		[Route("DeleteBestStudent")]
		public async Task<ActionResult<string>> DeleteBestStudent()
		{
			await _student.DeleteBestStudent();
			return Ok();
		}

		[HttpPost]
		[Route("AddStudent")]
		public async Task<ActionResult> AddStudent(string name)
		{
			await _student.AddNewStudent(name);
			return Ok();
		}

		[HttpGet]
		[Route("GetStudents")]
		public async Task<ActionResult<string>> GetStudents()
		{

			return Ok(await _student.GetAllStudents());
		}
	}
}

