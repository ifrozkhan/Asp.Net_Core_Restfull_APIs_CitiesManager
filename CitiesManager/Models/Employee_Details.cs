using System;
using System.ComponentModel.DataAnnotations;

namespace CitiesManager.WebAPI.Models
{
    public class Employee_Details
    {
        [Key]
        public int Emp_ID { get; set; }

        public string? Emp_Name { get; set; }

        public string? Type { get; set; }

        public string? Gender { get; set; }

        public DateTime DOB { get; set; }

        public string? Address { get; set; }
    }
}