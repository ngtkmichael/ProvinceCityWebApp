using ProvinceCityWebApp.Models.GeoMap;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace ProvinceCityWebApp.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        // Create access points tables Cities & Provinces
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }

        // Insert data in table Province
        public static System.Collections.Generic.List<Province> getProvinces()
        {
            List<Province> provinces = new List<Province>()
            {
                new Province() {
                    ProvinceCode="BC",
                    ProvinceName="British Columbia"
                },
                new Province() {
                    ProvinceCode="QC",
                    ProvinceName="Quebec"
                },
                new Province() {
                    ProvinceCode="AB",
                    ProvinceName="Alberta"
                }
            };

            return provinces;
        }

        // Insert data in table Cities
        public static List<City> getCities(ApplicationDbContext context)
        {
            List<City> cities = new List<City>() {
                new City {
                    CityName="Vancouver",
                    Population=603000,
                    ProvinceCode = context.Provinces.Find("BC").ProvinceCode
                },
                new City {
                    CityName="Surrey",
                    Population=468000,
                    ProvinceCode = context.Provinces.Find("BC").ProvinceCode
                },
                new City {
                    CityName="Richmond",
                    Population=190000,
                    ProvinceCode = context.Provinces.Find("BC").ProvinceCode
                },
                new City {
                    CityName="Montreal",
                    Population=165000,
                    ProvinceCode = context.Provinces.Find("QC").ProvinceCode
                },
                new City {
                    CityName="Brossard",
                    Population=83500,
                    ProvinceCode = context.Provinces.Find("QC").ProvinceCode
                },
                new City {
                    CityName="Laval",
                    Population=401550,
                    ProvinceCode = context.Provinces.Find("QC").ProvinceCode
                },
                new City {
                    CityName="Calgary",
                    Population=1097000,
                    ProvinceCode = context.Provinces.Find("AB").ProvinceCode
                },
                new City {
                    CityName="Edmonton",
                    Population=812200,
                    ProvinceCode = context.Provinces.Find("AB").ProvinceCode
                },
                new City {
                    CityName="Red Deer",
                    Population=91000,
                    ProvinceCode = context.Provinces.Find("AB").ProvinceCode
                },
            };

            return cities;
        }
    }
}
