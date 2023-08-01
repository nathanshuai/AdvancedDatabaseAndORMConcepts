namespace AdvancedDatabaseAndORMConcepts.Models
{
    public class Address
    {
        public Guid ID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }

        public virtual List<Customer> Customers { get; set; }

        public Address() { }
        public Address(Guid iD, string addressLine1, string addressLine2, string city, string stateProvince, string countryRegion, List<Customer> customers)
        {
            ID = iD;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            StateProvince = stateProvince;
            CountryRegion = countryRegion;
            Customers = customers;
        }
    }

}
