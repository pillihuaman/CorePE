using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPICIp.Models
{
    public class Employee
    {

      

        public string FirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
     
        public string LastName
        {
            get { return LastName; }
            set { LastName = value; }
        }


        public int EmpCode
        {
            get { return EmpCode; }
            set { EmpCode = value; }
        }

        public string Designation
        {
            get { return Designation; }
            set { Designation = value; }
        }
//public string getEmployeeName()
        public string getemployeesName()
        {
            string FullName = FirstName + LastName;
            return FullName;
        
        }
                }
}