using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseValidator.Models
{
    public class Scan
    {
        public Guid Id { get; set; }
        public string LicensePlateName { get; set; }
        public string SystemLocationName { get; set; }
        public string ScannedLocationName { get; set; }
        public string Match { get; set; }
    }
}
