using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1AutoTbxBinding
{
    public class Notication: INotifyPropertyChanged
    {
        //Implementation of INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        //Method is invoked when properties are set. (See FirstName, LastName and FullName properties in this class)
        protected void OnPropertyChanged(string propertyName)
        {
            //Tests if PropertyChangedEventHandler called "PropertyChanged" isn't null.
            if (PropertyChanged != null)
            {
                //Creates an instance of the eventhandler PropertyEventArgument using this class and PropertyChangedEventArgument as input parameters.
                //The PropertyEventArgument uses a propertyName as input parameter.
                //PropertyName is in this class the name of the properties "FirstName", "LastName" and "FullName".
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
