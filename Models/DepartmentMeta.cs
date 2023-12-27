using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartialView.Models
{
    
    public class DepartmentMeta
    {
        [Display(Name = "Id")]
        public int Dept_Id { get; set; }
        [Display(Name = "Name")]
        [MinLength(3)]
        public string Dept_Name { get; set; }
        [Display(Name = "Description")]
        [MinLength(5)]
        public string Dept_Desc { get; set; }
        [Display(Name = "Loacation")]

        public string Dept_Location { get; set; }
        public int? Dept_Manager { get; set; }

    }
}