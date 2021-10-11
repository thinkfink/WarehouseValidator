using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseValidator.Models
{
    public class Error
    {
        public Guid Id { get; set; }
        public string LicensePlateName { get; set; }
        public string LocationName { get; set; }

    }
}
