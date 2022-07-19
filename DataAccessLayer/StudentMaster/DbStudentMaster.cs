using CommonLayer.EmployeeMaster;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using UtilityLayer;

namespace DataAccessLayer.EmployeeMaster
{
    public class DbStudentMaster
    {
        private DbAccess dbAccess = new DbAccess();

        public DataTable GetStudents()
        {
            DataTable dt;
            try 
            {
                 dt = dbAccess.ExecuteSPDatatable("usp_get_Students"); 
            }
            catch (SqlException sqx)
            {

                throw sqx;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }


        public DataTable GetStudent(int id)
        {
            DataTable dt;
            SqlParameter sqlParameter = new SqlParameter();
            ArrayList array = new ArrayList();
            try
            {
                sqlParameter.ParameterName = "@Id";
                sqlParameter.DbType = DbType.Int32;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = id;
                array.Add(sqlParameter);
                dt = dbAccess.ExecuteSPDatatable("usp_get_Students", array);
            }
            catch (SqlException sqx)
            {

                throw sqx;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public string CreateStudent(StudentEntity student)
        {
            string message = string.Empty;
            SqlParameter sqlParameter; 
            ArrayList array = new ArrayList();
            try
            {
                sqlParameter= new SqlParameter();
                sqlParameter.ParameterName = "@Id";
                sqlParameter.DbType = DbType.Int32;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.id;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Name";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.Name;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@FatherName";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.FatherName;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@MotherName";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.MotherName;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Class";
                sqlParameter.DbType = DbType.Int32;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.Class;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Gender";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.Gender;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@DOB";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.DOB;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Mobile";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.Mobile;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@AadharNo";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.AadharNo;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@AdmissionDate";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.AdmissionDate;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@address";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.Address;
                array.Add(sqlParameter);

                int i = dbAccess.ExecuteSPNonQuery("usp_create_Students", array);
                if (i==1)
                {
                    message = "Student Data Created Successfully";
                }
            }
            catch (SqlException sqx)
            {

                throw sqx;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return message;
        }


        public string DeleteStudent(int id)
        {
            string message = string.Empty;
            SqlParameter sqlParameter;
            ArrayList array = new ArrayList();
            try
            {
                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Id";
                sqlParameter.DbType = DbType.Int32;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value =id;
                array.Add(sqlParameter);

                int i = dbAccess.ExecuteSPNonQuery("usp_delete_Students", array);
                if (i == 1)
                {
                    message = "Student Data Deleted Successfully";
                }
            }
            catch (SqlException sqx)
            {

                throw sqx;
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
            SqlParameter sqlParameter;
            ArrayList array = new ArrayList();
            try
            {
                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Id";
                sqlParameter.DbType = DbType.Int32;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.id;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Name";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.Name;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@FatherName";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.FatherName;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@MotherName";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.MotherName;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Class";
                sqlParameter.DbType = DbType.Int32;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.Class;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Gender";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.Gender;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@DOB";
                sqlParameter.DbType = DbType.Date;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.DOB;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Mobile";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.Mobile;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@AadharNo";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.AadharNo;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@AdmissionDate";
                sqlParameter.DbType = DbType.Date;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.AdmissionDate;
                array.Add(sqlParameter);

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@address";
                sqlParameter.DbType = DbType.String;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = student.Address;
                array.Add(sqlParameter);

                int i = dbAccess.ExecuteSPNonQuery("usp_update_Students", array);
                if (i == 1)
                {
                    message = "Student Data Updated Successfully";
                }
            }
            catch (SqlException sqx)
            {

                throw sqx;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return message;
        }


        public DataTable GetStudentbyClass(int Class)
        {
            DataTable dt;
            SqlParameter sqlParameter = new SqlParameter();
            ArrayList array = new ArrayList();
            try
            {
                sqlParameter.ParameterName = "@Class";
                sqlParameter.DbType = DbType.Int32;
                sqlParameter.Direction = ParameterDirection.Input;
                sqlParameter.Value = Class;
                array.Add(sqlParameter);
                dt = dbAccess.ExecuteSPDatatable("usp_get_StudentbyClass", array);
            }
            catch (SqlException sqx)
            {

                throw sqx;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

    }
}
