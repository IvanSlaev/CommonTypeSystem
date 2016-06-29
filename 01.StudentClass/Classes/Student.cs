namespace _01.StudentClass
{
    using System;
    using Enumerations;

    public class Student : ICloneable, IComparable<Student>
    {
        // fields
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private int _ssn;
        private string _permanentAddress;
        private string _mobile;
        private string _email;
        private string _course;
        private Specialty _specialty;
        private University _university;
        private Faculty _faculty;

        // constructors
        public Student(string firstName, string middleName, string lastName, int ssn, string permanentAddress,
            string mobile, string email)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.Mobile = mobile;
            this.Email = email;
        }

        public Student(string firstName, string middleName, string lastName, int ssn, string permanentAddress,
            string mobile, string email, Faculty faculty) : this(firstName, middleName, lastName, ssn, permanentAddress, mobile, email)
        {
            this._faculty = faculty;
        }

        // properties
        public string FirstName
        {
            get { return _firstName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                _firstName = value;
            }
        }

        public string MiddleName
        {
            get { return _firstName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                _middleName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                _lastName = value;
            }
        }

        public int SSN
        {
            get { return _ssn; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("SSN cannot be 0 or negative");
                }
                _ssn = value;
            }
        }

        public string PermanentAddress
        {
            get { return _permanentAddress; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Address cannot be empty");
                }
                _permanentAddress = value;
            }
        }

        public string Mobile
        {
            get { return _mobile; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Mobile phone field cannot be empty");
                }
                _mobile = value;
            }
        }

        public string Email
        {
            get { return _email; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("E-mail field cannot be empty");
                }
                _email = value;
            }
        }


        public string Course
        {
            get { return _course; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Course field cannot be empty");
                }
                _course = value;
            }
        }

        public Specialty Specialty => _specialty;

        public University University => _university;

        public Faculty Faculty { get; set; }
        
        // methods
        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (this.FirstName == student.FirstName)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Student first, Student second)
        {
            return object.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !object.Equals(first, second);
        }

        public int CompareTo(Student other)
        {
            int firstNameCriteria = this.FirstName.CompareTo(other.FirstName);
            int middleNameCriteria = this.MiddleName.CompareTo(other.MiddleName);
            int lastNameCriteria = this.LastName.CompareTo(other.LastName);
            int ssnCriteria = this.SSN.CompareTo(other.SSN);

            if (firstNameCriteria != 0)
            {
                return firstNameCriteria;
            }
            else if (middleNameCriteria != 0)
            {
                return middleNameCriteria;
            }
            else if (lastNameCriteria != 0)
            {
                return lastNameCriteria;
            }
                return ssnCriteria;
        }

        public override string ToString()
        {
            return $"I am {FirstName} {MiddleName} {LastName}";
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public object Clone()
        {
            object result = this.MemberwiseClone();
            return result;
        }
    }
}
