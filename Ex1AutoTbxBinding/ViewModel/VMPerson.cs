using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Ex1AutoTbxBinding.Model;

namespace Ex1AutoTbxBinding.ViewModel
{
    class VMPerson : Notication
    {
        private Person _personObj;

        public VMPerson()
        {
            PersonObj = new Person();
            //Optional: Sets some values when working in Designview. Values are removed when application is compiled
            if (DesignMode.DesignModeEnabled)
            {
                this.FirstName = "John";
                this.LastName = "Doe";
            }
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
            //Returns concatenation of firstname and lastname using model properties
            get { return PersonObj.FirstName + " " + PersonObj.LastName; }
            set
            {
                PersonObj.FullName = value;
                //Only updates the firstname-value if the value is not already the same as input
                if (PersonObj.FullName != value)
                {
                    PersonObj.FullName = value;
                    //Sends a message back to the view, that the FullName is also changed. If any members of the view is binded to FirstName property, they will update their values
                    OnPropertyChanged("FullName");
                }
            }
        }
        public string FirstName
        {
            get { return PersonObj.FirstName; }
            set
            {
                //Only updates the firstname-value if the value is not already the same as input
                if (value != PersonObj.FirstName)
                {
                    PersonObj.FirstName = value;
                    //Sends a message back to the view, that FirstName is changed. If any members of the view is binded to FirstName property, they will update their values
                    OnPropertyChanged("FirstName");
                    //Sends a message back to the view, that the FullName is also changed. If any members of the view is binded to FirstName property, they will update their values
                    OnPropertyChanged("FullName");
                }
            }
        }
        public string LastName
        {
            get { return PersonObj.LastName; }
            set
            {
                //Only updates the lastname-value if the value is not already the same as input
                if (PersonObj.LastName != value)
                {
                    PersonObj.LastName = value;
                    //Sends a message back to the view, that LastName is changed. If any members of the view is binded to FirstName property, they will update their values
                    OnPropertyChanged("LastName");
                    //Sends a message back to the view, that FullName is changed. If any members of the view is binded to FirstName property, they will update their values
                    OnPropertyChanged("FullName");
                }
            }
        }
    }
}
