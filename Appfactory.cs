using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appfactory
{

    class Appfactory
    {
        string name, location, studentNumber;
        byte age;
        char gender;

        string imeiNumber;
        string phoneNumber;

        string description, serialNum, macAddress;

        string dateOfDay, timeIn, timeOut;

        int images;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public byte Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }


        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }

            set
            {
                studentNumber = value;
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string PhoneNumber {
            get {
                return phoneNumber;
            }

            set {
                phoneNumber = value;
            }
            
        }

        public string ImeiNumber
        {
            get
            {
                return imeiNumber;
            }

            set
            {
                imeiNumber = value;
            }

        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string SerialNum
        {
            get
            {
                return serialNum;
            }
            set
            {
                serialNum = value;
            }
        }

        public string MacAddress
        {
            get
            {
                return macAddress;
            }

            set
            {
                macAddress = value;
            }
        }


        public string DateOfDay
        {
            get
            {
                return dateOfDay;
            }
            set
            {
                dateOfDay = value;
            }
        }

        public string TimeIn
        {
            get
            {
                return timeIn;
            }
            set
            {
                timeIn = value;
            }
        }

        public string TimeOut
        {
            get
            {
                return timeOut;
            }
            set
            {
                timeOut = value;
            }
        }

        public int Images {
            get 
            {
                return images;
            }
            set
            {
                images = value;
            }

        }

    }


}
