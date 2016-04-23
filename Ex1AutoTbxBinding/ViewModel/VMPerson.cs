using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex1AutoTbxBinding.Model;

namespace Ex1AutoTbxBinding.ViewModel
{
    class VMPerson : Notication
    {
        private Person _personObj;
        private string _firstName;
        private string _lastName;
        private string _fullName;

        public VMPerson()
        {
            PersonObj = new Person();
        }

        internal Person PersonObj
        {
            get
            {
                return _personObj;
            }

            set
            {
                _personObj = value;
                OnPropertyChanged("PersonObj");
            }
        }

        public string FullName
        {
            //Returns concatenation of firstname and lastname
            get { return _firstName + " " + _lastName; }
            set
            {
                _fullName = value;
                //Only updates the firstname-value if the value is not already the same as input
                if (_fullName != value)
                {
                    _fullName = value;
                    //Sends a message back to the view, that the FullName is also changed. If any members of the view is binded to FirstName property, they will update their values
                    OnPropertyChanged("FullName");
                }
            }
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                //Only updates the firstname-value if the value is not already the same as input
                if (value != _firstName)
                {
                    _firstName = value;
                    //Sends a message back to the view, that FirstName is changed. If any members of the view is binded to FirstName property, they will update their values
                    OnPropertyChanged("FirstName");
                    //Sends a message back to the view, that the FullName is also changed. If any members of the view is binded to FirstName property, they will update their values
                    OnPropertyChanged("FullName");
                }
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                //Only updates the lastname-value if the value is not already the same as input
                if (_lastName != value)
                {
                    _lastName = value;
                    //Sends a message back to the view, that LastName is changed. If any members of the view is binded to FirstName property, they will update their values
                    OnPropertyChanged("LastName");
                    //Sends a message back to the view, that FullName is changed. If any members of the view is binded to FirstName property, they will update their values
                    OnPropertyChanged("FullName");
                }
            }
        }
    }
}
