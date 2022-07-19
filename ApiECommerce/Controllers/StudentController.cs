using BusinessLayer.EmployeeMaster;
using CommonLayer;
using CommonLayer.EmployeeMaster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private BLStudentMaster BLEmployee = new BLStudentMaster();
        private ApiResponse response;

        [Route ("GetAllStudent")]
        public IActionResult GetStudents()
        {
            response = new ApiResponse();
            try
            {
                var result = BLEmployee.GetStudents();
                response.Data = result;
                response.Mesaage = "All Students Data Found!";
                response.Ok = true;
                response.Status = 200;
            }
            catch (Exception ex)
            {
                response.Mesaage = ex.Message;
                response.Ok = false;
                response.Status = 501;
            }
            return Ok(response);
        }


        [Route("GetStudentById")]
        public IActionResult GetStudent(int id)
        
        {
            response = new ApiResponse();
            try
            {
                var result = BLEmployee.GetStudent(id);
                response.Data = result;
                response.Mesaage = "Student Data Found!";
                response.Ok = true;
                response.Status = 200;
            }
            catch (Exception ex)
            {
                response.Mesaage = ex.Message;
                response.Ok = false;
                response.Status = 501;
            }
            return Ok(response);

        }

        [Route("CreateStudent")]
        [HttpPost]
        public IActionResult CreateStudent(StudentEntity entity)

        {
            response = new ApiResponse();
            try
            {
                var result = BLEmployee.CreateStudent(entity);
                if (string.IsNullOrEmpty(result))
                {
                    response.Mesaage = "Something Went Wrong!";
                    response.Ok = false;
                    response.Status = 501;

                }
                else
                {
                    response.Data = result;
                    response.Mesaage = "Student Data Created Successfully!";
                    response.Ok = true;
                    response.Status = 200;
                }     
            }
            catch (Exception ex)
            {
                response.Mesaage = ex.Message;
                response.Ok = false;
                response.Status = 501;
            }
            return Ok(response);
        }


        [Route("DeleteStudent")]
        [HttpPost]
        public IActionResult DeleteStudent(int id)

        {
            response = new ApiResponse();
            try
            {
                var result = BLEmployee.DeleteStudent(id);
                response.Data = result;
                response.Mesaage = "Student Data Deleted Successfully!";
                response.Ok = true;
                response.Status = 200;
            }
            catch (Exception ex)
            {
                response.Mesaage = ex.Message;
                response.Ok = false;
                response.Status = 501;
            }
            return Ok(response);

        }


        [Route("UpdateStudent")]
        [HttpPost]
        public IActionResult UpdateStudent(StudentEntity student)

        {
            response = new ApiResponse();
            try
            {
                var result = BLEmployee.UpdateStudent(student);
                response.Data = result;
                response.Mesaage = "Student Data Updated Successfully!";
                response.Ok = true;
                response.Status = 200;
            }
            catch (Exception ex)
            {
                response.Mesaage = ex.Message;
                response.Ok = false;
                response.Status = 501;
            }
            return Ok(response);

        }


        [Route("GetStudentByClass")]
        public IActionResult GetStudentbyClass(int Class)

        {
            response = new ApiResponse();
            try
            {
                var result = BLEmployee.GetStudentbyClass(Class);
                response.Data = result;
                response.Mesaage = "Student Data Found!";
                response.Ok = true;
                response.Status = 200;
            }
            catch (Exception ex)
            {
                response.Mesaage = ex.Message;
                response.Ok = false;
                response.Status = 501;
            }
            return Ok(response);

        }

    }
}
