using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProvinceCityWebApp.Models.GeoMap
{
    public class City
    {
        [Required]
        [Display(Name = "City ID")]
        public int CityId { get; set; }

        [Required]
        [Display(Name = "City Name")]
        [StringLength(40, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        public string CityName { get; set; }

        [Display(Name = "Population")]
        public int Population { get; set; }

        [Required]
        [Display(Name = "Province Name")]
        [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        public string ProvinceCode { get; set; }

        [Display(Name = "Province Name")]
        public Province Province { get; set; }
    }
}
