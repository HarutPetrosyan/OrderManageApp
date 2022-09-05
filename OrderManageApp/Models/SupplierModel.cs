using System.ComponentModel.DataAnnotations;

namespace OrderManageApp.Models
{
    public class SupplierModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        [EmailAddress]
        public string EMail { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string State { get; set; }
        public Boolean Disable { get; set; }=true;
    }
}
