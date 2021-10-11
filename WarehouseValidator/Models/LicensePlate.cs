using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseValidator.Models
{
    public class LicensePlate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public string Qty { get; set; }
        public string LotNumber { get; set; }
        public string LocationName { get; set; }
        public static LicensePlate FromCSV(string csvLine)
        {
            string[] values = csvLine.Split(',');
            LicensePlate licensePlate = new LicensePlate();
            licensePlate.Id = Guid.NewGuid();
            licensePlate.Name = values[1].ToString();
            licensePlate.LotNumber = values[2].ToString();
            licensePlate.PartNumber = values[3].ToString();
            licensePlate.PartDescription = values[4].ToString();
            licensePlate.Qty = values[5].ToString();
            licensePlate.LocationName = values[6].ToString();
            return licensePlate;
        }
    }
}
