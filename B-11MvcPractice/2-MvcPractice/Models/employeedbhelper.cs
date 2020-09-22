using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2_MvcPractice.Models
{
    public class employeedbhelper
    {
        public List<employee> getemployee()
        {
            return new List<employee>()
            {
                new employee() {Id=1,Name="Vishal",Gender="Male" },
                new employee() {Id=2,Name="Mahesh",Gender="Male" },
                new employee() {Id=3,Name="Shital",Gender="Female" },
                new employee() {Id=4,Name="Richa",Gender="Female" }

            };
        }
    }
}