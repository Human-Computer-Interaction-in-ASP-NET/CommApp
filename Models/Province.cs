using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace CommunityApp.Models
{
    public class Province {
        [Key]
        public string? ProvinceCode { get; set; }
        public string? ProvinceName { get; set; }
        public List<City>? Cities { get; set; }
    }
}
