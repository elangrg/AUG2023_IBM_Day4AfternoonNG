using AUG2023_IBM_Day4AfternoonNG.Infra;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AUG2023_IBM_Day4AfternoonNG.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Required]
        [MaxLength(40)]
        
        [Display(Name = "Name of The Project")]
       [Remote(action: "ProjectNameTaken", controller: "ValidationEg")]

        public string ProjectName { get; set; }
        [Required]
        [MustContainPrjType]
        [Display(Name = "Project Description")]
        public string PrjDesc { get; set; }

    }


}
