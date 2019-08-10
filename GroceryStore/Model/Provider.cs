using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    public class Provider : INotifyPropertyChanged
    {
        private int id;
        private string companyName;
        private string agentName;
        private string mobilePhone;
        private string officePhone;
        private string address;
        private string description;

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged("id");
            }
        }
        public string CompanyName
        {
            get => companyName;
            set
            {
                companyName = value;
                OnPropertyChanged("CompanyName");
            }
        }
        public string AgentName
        {
            get => agentName;
            set
            {
                agentName = value;
                OnPropertyChanged("AgentName");
            }
        }
        public string MobilePhone
        {
            get => mobilePhone;
            set
            {
                mobilePhone = value;
                OnPropertyChanged("MobilePhone");
            }
        }

        public string OfficePhone
        {
            get => officePhone;
            set
            {
                officePhone = value;
                OnPropertyChanged("OfficePhone");
            }
        }

        public string Address
        {
            get => address;
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
