using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1AutoTbxBinding.Model
{
    class Person : Notication
    {
        private string _fullName;
        private string _firstName;
        private string _lastName;

        public Person()
        {
            
        }


        #region Properties
        public string FullName
        {
            //Returns concatenation of firstname and lastname
            get { return _firstName + " " + _lastName; }
            set
            {
                _fullName = value;
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
            }
        }
        #endregion
    }
}
