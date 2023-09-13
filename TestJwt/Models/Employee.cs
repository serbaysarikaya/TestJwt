﻿using System.ComponentModel.DataAnnotations;

namespace TestJwt.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string? NationalIDNumber { get; set; }
        public string? EmployeeName { get; set; }
        public string? LoginID { get; set; }
        public string? JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Gender { get; set; }
        public DateTime HireDate { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public Guid? RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
