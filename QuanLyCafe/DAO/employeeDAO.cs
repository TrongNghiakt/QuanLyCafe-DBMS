﻿using QuanLyCafe.VIEW.UC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCafe.DAO
{
    internal class employeeDAO
    {

        private static employeeDAO instance ; 
        public static employeeDAO Instance 
        {
            get { if (instance == null) instance = new employeeDAO(); return instance; }
            private set { instance  = value; }
        }
        public employeeDAO() { }
        public DataTable listemployee ()
        {
            string query = "select * from Employee";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public void updateeployee (string idEmployee, string Ename, string Email,string dateOfBirth, string phoneNumber, string gender)
        {
            string query = "UPDATE Employee SET Ename = N'"+ Ename + "', Email = N'"+ Email + "', dateOfBirth = '"+ dateOfBirth + "', phoneNumber = '"+ phoneNumber + "', gender = N'"+ gender + "' WHERE idEmployee = '"+ idEmployee + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool checkednv (string idEmployee)
        {
            string query = "select * from Account where idAccount =N'" + idEmployee +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public void deleteeployee(string idEmployee)
        {
            string query = "EXEC DeleteEmployeeAndAccounts @idEmployee = N'"+ idEmployee + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void Addeployee(string idEmployee, string Ename, string Email, string dateOfBirth, string phoneNumber, string gender)
        {
            string query = $"INSERT INTO Employee (idEmployee, Ename, dateOfBirth, gender, Email, phoneNumber) VALUES ('{idEmployee}', N'{Ename}', '{dateOfBirth}', N'{gender}', N'{Email}', '{phoneNumber}')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable findeeploy(string id )
        {
            string query = "select * from Employee where idEmployee =N'" + id + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
