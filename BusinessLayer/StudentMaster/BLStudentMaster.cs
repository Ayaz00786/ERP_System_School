using CommonLayer.EmployeeMaster;
using DataAccessLayer.EmployeeMaster;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLayer.EmployeeMaster
{
    public class BLStudentMaster
    {
        DbStudentMaster dbEmployee = new DbStudentMaster();

        public List<StudentEntity> GetStudents()
        {
            List<StudentEntity> lstEmployee = new List<StudentEntity>();
            try
            {
                var result = dbEmployee.GetStudents();
                foreach(DataRow item in result.Rows)
                {
                    StudentEntity entity = new StudentEntity();
                    entity.id = (int)item["id"];
                    entity.Name = item["Name"].ToString();
                    entity.FatherName = item["FatherName"].ToString();
                    entity.MotherName = item["MotherName"].ToString();
                    entity.Class = (int)item["Class"];
                    entity.Gender = item["Gender"].ToString();
                    entity.DOB = item["DOB"].ToString();
                    entity.Mobile = item["Mobile"].ToString();
                    entity.AadharNo = item["AadharNo"].ToString();
                    entity.AdmissionDate = item["AdmissionDate"].ToString();
                    entity.Address = item["Address"].ToString();
                    lstEmployee.Add(entity);

                }
            }
            catch (Exception ex)
            {   
                throw ex;
            }
            return lstEmployee;
        }


        public List<StudentEntity> GetStudent(int id)
        {
            List<StudentEntity> lstEmployee = new List<StudentEntity>();
            try
            {
                var result = dbEmployee.GetStudent(id);
                foreach (DataRow item in result.Rows)
                {
                    StudentEntity entity = new StudentEntity();
                   entity.id = (int)item["id"];
                    entity.Name = item["Name"].ToString();
                    entity.FatherName = item["FatherName"].ToString();
                    entity.MotherName = item["MotherName"].ToString();
                    entity.Class = (int)item["Class"];
                    entity.Gender = item["Gender"].ToString();
                    entity.DOB = item["DOB"].ToString();
                    entity.Mobile = item["Mobile"].ToString();
                    entity.AadharNo = item["AadharNo"].ToString();
                    entity.AdmissionDate = item["AdmissionDate"].ToString();
                    entity.Address = item["Address"].ToString();
                    lstEmployee.Add(entity);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstEmployee;
        }

        public string CreateStudent(StudentEntity entity)
        {
            string result;
            try
            {
                 result = dbEmployee.CreateStudent(entity);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }


        public string DeleteStudent(int id)
        {
            string message = string.Empty;
            try
            {
                dbEmployee.DeleteStudent(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return message;
        }



        public string UpdateStudent(StudentEntity student)
        {
            string message = string.Empty;
            try
            {
                dbEmployee.UpdateStudent(student);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return message;
        }



        public List<StudentEntity> GetStudentbyClass(int Class)
        {
            List<StudentEntity> lstEmployee = new List<StudentEntity>();
            try
            {
                var result = dbEmployee.GetStudentbyClass(Class);
                foreach (DataRow item in result.Rows)
                {
                    StudentEntity entity = new StudentEntity();
                    entity.id = (int)item["id"];
                    entity.Name = item["Name"].ToString();
                    entity.FatherName = item["FatherName"].ToString();
                    entity.MotherName = item["MotherName"].ToString();
                    entity.Class = (int)item["Class"];
                    entity.Gender = item["Gender"].ToString();
                    entity.DOB = item["DOB"].ToString();
                    entity.Mobile = item["Mobile"].ToString();
                    entity.AadharNo = item["AadharNo"].ToString();
                    entity.AdmissionDate = item["AdmissionDate"].ToString();
                    entity.Address = item["Address"].ToString();
                    lstEmployee.Add(entity);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstEmployee;
        }
    }
}
