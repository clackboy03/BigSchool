﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab456.Models
{
    public class Course
    {
        public int id
        {
            get; set;
        }
        public ApplicationUser Lecturer { get; set; }
        [Recquired]
        public string LecturerId { get; set; }
        [Recquired]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
        public object Lecturerid { get; internal set; }
        public byte Categoryid { get; internal set; }
    }
    
}