using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency
{
    class Patient
    {
        private string _name;
        private int _condition;
        private int _patientID;
        private static int _patientNum;

        public Patient(string name, int condition)
        {
            _patientNum++;
            _patientID = _patientNum;
            Name = name;
            Condition = condition;
        }
        public Patient()
        {
            _patientNum++;
            _patientID = _patientNum;
            Name = "";
            Condition = 0;
        }
        public int PatientID { get { return _patientID; } }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Condition
        {
            get
            {
                return _condition;
            }
            set
            {
                _condition = value;
            }
        }
        public string Print()
        {
            return string.Format("{0,-30:D} {1,30:D}", Name, Condition);
        }

        public static bool operator <=(Patient Patient, Patient otherPatient)
        {
            return (Patient._condition <= otherPatient._condition ? true : false);
        }

        public static bool operator >=(Patient Patient, Patient otherPatient)
        {
            return Patient._condition >= otherPatient._condition ? true : false;
        }

        public static bool operator <(Patient Patient, Patient otherPatient)
        {
            return (Patient._condition < otherPatient._condition ? true : false);
        }

        public static bool operator >(Patient Patient, Patient otherPatient)
        {
            return Patient._condition > otherPatient._condition ? true : false;
        }
        public static bool operator ==(Patient Patient, Patient otherPatient)
        {
            return Patient._condition == otherPatient._condition ? true : false;
        }
        public static bool operator !=(Patient Patient, Patient otherPatient)
        {
            return Patient._condition != otherPatient._condition ? true : false;
        }

    }
}
