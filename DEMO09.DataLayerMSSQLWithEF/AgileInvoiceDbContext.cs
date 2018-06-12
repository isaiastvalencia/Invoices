
namespace DEMO09.DataLayerMSSQLWithEF
{
    using System.Data.Entity;

    public class AgileInvoiceDbContext:DbContext
    {
        public AgileInvoiceDbContext(string connString) : base(connString)
        { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TaxProfile> TaxProfiles { get; set; }
        public virtual DbSet<InvoiceRequest> InvoiceRequests { get; set; }

    }
}
