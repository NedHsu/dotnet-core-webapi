﻿using System;
using System.Collections.Generic;

namespace dotnet_core_webapi.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseInstructor = new HashSet<CourseInstructor>();
            Enrollment = new HashSet<Enrollment>();
        }

        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<CourseInstructor> CourseInstructor { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}