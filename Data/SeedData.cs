using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CommunityApp.Models;

namespace CommunityApp.Models
{
    public static class SeedData
    {
        // This is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var provinces = GetProvinces();
            var cities = GetCities(provinces);

            modelBuilder.Entity<Province>().HasData(provinces);
            modelBuilder.Entity<City>().HasData(cities);
        }

        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>()
            {
                new Province
                {
                    ProvinceCode = "BC",
                    ProvinceName = "BC",
                },
                new Province
                {
                    ProvinceCode = "ONT",
                    ProvinceName = "ONT",
                },
                new Province
                {
                    ProvinceCode = "ALB",
                    ProvinceName = "AL",
                }
            };

            return provinces;
        }

        public static List<City> GetCities(List<Province> provinces)
        {
            List<City> cities = new List<City>()
            {
                // Province 1 (BC)
                new City() {    
                    CityId = 1,
                    CityName = "Surrey",
                    Population = 999990,
                    ProvinceCode = provinces[0].ProvinceCode
                },
                new City() {    
                    CityId = 2,
                    CityName = "Delta",
                    Population = 1110,
                    ProvinceCode = provinces[0].ProvinceCode
                },
                new City() {    
                    CityId = 3,
                    CityName = "Burnaby",
                    Population = 89898,
                    ProvinceCode = provinces[0].ProvinceCode
                },
                // Province 2 (ONT)
                new City() {    
                    CityId = 4,
                    CityName = "Toronto",
                    Population = 999990,
                    ProvinceCode = provinces[1].ProvinceCode
                },
                new City() {    
                    CityId = 5,
                    CityName = "Welland",
                    Population = 1111,
                    ProvinceCode = provinces[1].ProvinceCode
                },
                new City() {    
                    CityId = 6,
                    CityName = "Markham",
                    Population = 111111,
                    ProvinceCode = provinces[1].ProvinceCode
                },
                // Province 3 (AL)
                new City() {    
                    CityId = 7,
                    CityName = "Calgary",
                    Population = 734658,
                    ProvinceCode = provinces[2].ProvinceCode
                },
                new City() {    
                    CityId = 8,
                    CityName = "Airdrie",
                    Population = 8943,
                    ProvinceCode = provinces[2].ProvinceCode
                },
                new City() {    
                    CityId = 9,
                    CityName = "Irricana",
                    Population = 435,
                    ProvinceCode = provinces[2].ProvinceCode
                },
            };

            return cities;
        }
    }
}
