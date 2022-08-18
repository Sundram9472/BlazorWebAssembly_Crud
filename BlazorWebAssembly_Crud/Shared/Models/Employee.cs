using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssembly_Crud.Shared.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Display(Name ="FirstName")]
        public string? EmpName { get; set; }

        [Display(Name = "LastName")]
        public string? EmpLastName { get; set; }

        public string? Team { get;set; }

        [DataType(DataType.EmailAddress)]
        public string? Gmail { get; set; }   

        public string? AssignProject { get; set; }   
        public string? ProjectStatus { get; set; }   

        public string? ProjectRemark { get; set; }
    }
}
