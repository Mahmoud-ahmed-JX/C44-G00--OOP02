using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_asmnt2
{

    internal class Employee
    {
        #region Q1 properities
        /*Design and implement a Class for the employees in a company:
Employee is identified by an ID, Name, security level, salary, hire date and Gender.
*/
        public int Id {  get; set; } 
        public string Name { get; set; }
        public Security_Level security_level { get; set; }
        public int salary { get; set; }
        public Hire_Date hire_date { get; set; }

        public char Gender
        {
            get
            {
                return Gender;
            }
            set
            {
                if(value == 'F' || value == 'M')
                {
                    this.Gender = value;
                }
            }
              
            
        }




        #endregion

        #region Constructor
        public Employee(int id, string name, Security_Level security_level, int salary, Hire_Date hire_date, char gender)
        {
            this.Id = id;
            this.Name = name;
            this.security_level = security_level;
            this.salary = salary;
            this.hire_date = hire_date;
            this.Gender = gender;

        }
        #endregion

        #region Getter and setters
        //public int getId()
        //{
        //    return Id;
        //}
        //public void setId(int Id)
        //{
        //    this.Id = Id;
        //}

        //public string getName()
        //{
        //    return Name;
        //}
        //public void setName(string name) { 
        //    Name=name;
        //}

        //public Security_Level getSecurity_Level()
        //{
        //    return security_level;
        //}

        //public void setSecurity_Level(Security_Level security_level)
        //{
        //    this.security_level = security_level;
        //}

        //public int getSalary()
        //{
        //    return salary;
        //}

        //public void setSalary(int salary)
        //{
        //    this.salary=salary;
        //}

        //public Hire_Date getHire_Date()
        //{
        //    return hire_date;
        //}

        //public void setHire_Date(Hire_Date hire_date)
        //{
        //    this.hire_date=hire_date;
        //}

        //public char getGender()
        //{
        //    return Gender;
        //}

        //public void setGender(char Gender)
        //{
        //    this.Gender=Gender;
        //}
        #endregion

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nSecurity Level: {security_level}\nSalary: {string.Format("{0:C}",salary)}\nHire Date: {hire_date}\nGender: {Gender  }";
        }
    }
}
