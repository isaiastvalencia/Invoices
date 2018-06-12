using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEMO09.DataLayerMSSQLWithEF
{
    [Table("TaxProfiles")]
    public class TaxProfile
    {
        [Key]
        public int IdTaxProfile { get; set; }
        public string Identification { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string ExteriorNumber { get; set; }
        public string InteriorNumber { get; set; }
        public string Suburb { get; set; }
        public string Municipality { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PostCode { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
