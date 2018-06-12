
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEMO09.DataLayerMSSQLWithEF
{
    [Table("InvoiceRequest")]
    public class InvoiceRequest
    {
        [Key]
        public int IdSender { get; set; }
        public string FolioNumber { get; set; }
        public int IdUser { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
