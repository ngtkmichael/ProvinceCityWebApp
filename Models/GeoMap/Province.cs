using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProvinceCityWebApp.Models.GeoMap
{
    public class Province
    {
        [Key]
        [MaxLength(30)]
        [Required]
        [Display(Name = "Province Code")]
        public string ProvinceCode { get; set; }

        [Required]
        [Display(Name = "Province Name")]
        [StringLength(40, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        public string ProvinceName { get; set; }

        [Display(Name = "Cities")]
        public List<City> Cities { get; set; }
    }
}
