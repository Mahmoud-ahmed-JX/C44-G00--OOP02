using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_asmnt2
{
    internal class Hire_Date
    {
        #region Q2
        /*
Develop a Class to represent the Hiring Date Data:
consisting of fields to hold the day, month and Years.

*/
        #region properities
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        #endregion

        #region Constructor
        public Hire_Date(int day,int month,int year) {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        #endregion

        #region Getter And Setters
        //public int getDay() { return day; }
        //public void setDay(int day)
        //{
        //    this.day = day;
        //}
        //public int getMonth() { return month; }
        //public void setMonth(int month) { this.month = month; }
        //public int getYear() { return year; }
        //public void setYear(int year) { this.year = year; }
        #endregion

        
        #endregion


        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
