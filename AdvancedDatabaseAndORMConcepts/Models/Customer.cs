namespace AdvancedDatabaseAndORMConcepts.Models
{
    public class Customer
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual List<Address> Addresses { get; set; }


        public Customer() { }
        public Customer(Guid iD, string firstName, string lastName, string companyName, string phone, List<Address> addresses)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            CompanyName = companyName;
            Phone = phone;
            Addresses = addresses;
        }
    }
}
