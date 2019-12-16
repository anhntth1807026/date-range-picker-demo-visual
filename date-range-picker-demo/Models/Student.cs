using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace date_range_picker_demo.Models
{
    public class Student
    {
        [Key]
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        public StudentStatus Status { get; set; }

        public bool IsDeleted()
        {
            return this.Status == StudentStatus.Delete;
        }
    }

    public enum StudentStatus
    {
        Active = 1, Deactive = 0, Delete = -1
    }
}