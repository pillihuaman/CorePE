using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDesarrollo
{
   public  class Employee
    {


        private string _Uid;

        public string Uid
        {
            get { return _Uid; }
            set { _Uid = value; }
        }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        private string _City;

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

    

    }
}
