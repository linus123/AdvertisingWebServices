using System.Collections.Generic;

namespace MvcServices.Helpers
{
    public class CustomerRepository
    {
        private readonly List<Customer> _customers;

        public CustomerRepository()
        {
            _customers = new List<Customer>();

            _customers.Add(new Customer() { CustomerId = 1, Company = "Company A", LastName = "Bedecs", FirstName = "Anna", JobTitle = "Owner", Address = "123 1st Street", City = "Seattle", State = "WA" });
            _customers.Add(new Customer() { CustomerId = 2, Company = "Company B", LastName = "Gratacos Solsona", FirstName = "Antonio", JobTitle = "Owner", Address = "123 2nd Street", City = "Boston", State = "MA" });
            _customers.Add(new Customer() { CustomerId = 3, Company = "Company C", LastName = "Axen", FirstName = "Thomas", JobTitle = "Purchasing Representative", Address = "123 3rd Street", City = "Los Angelas", State = "CA" });
            _customers.Add(new Customer() { CustomerId = 4, Company = "Company D", LastName = "Lee", FirstName = "Christina", JobTitle = "Purchasing Manager", Address = "123 4th Street", City = "New York", State = "NY" });
            _customers.Add(new Customer() { CustomerId = 5, Company = "Company E", LastName = "O’Donnell", FirstName = "Martin", JobTitle = "Owner", Address = "123 5th Street", City = "Minneapolis", State = "MN" });
            _customers.Add(new Customer() { CustomerId = 6, Company = "Company F", LastName = "Pérez-Olaeta", FirstName = "Francisco", JobTitle = "Purchasing Manager", Address = "123 6th Street", City = "Milwaukee", State = "WI" });
            _customers.Add(new Customer() { CustomerId = 7, Company = "Company G", LastName = "Xie", FirstName = "Ming-Yang", JobTitle = "Owner", Address = "123 7th Street", City = "Boise", State = "ID" });
            _customers.Add(new Customer() { CustomerId = 8, Company = "Company H", LastName = "Andersen", FirstName = "Elizabeth", JobTitle = "Purchasing Representative", Address = "123 8th Street", City = "Portland", State = "OR" });
            _customers.Add(new Customer() { CustomerId = 9, Company = "Company I", LastName = "Mortensen", FirstName = "Sven", JobTitle = "Purchasing Manager", Address = "123 9th Street", City = "Salt Lake City", State = "UT" });
            _customers.Add(new Customer() { CustomerId = 10, Company = "Company J", LastName = "Wacker", FirstName = "Roland", JobTitle = "Purchasing Manager", Address = "123 10th Street", City = "Chicago", State = "IL" });
            _customers.Add(new Customer() { CustomerId = 11, Company = "Company K", LastName = "Krschne", FirstName = "Peter", JobTitle = "Purchasing Manager", Address = "123 11th Street", City = "Miami", State = "FL" });
            _customers.Add(new Customer() { CustomerId = 12, Company = "Company L", LastName = "Edwards", FirstName = "John", JobTitle = "Purchasing Manager", Address = "123 12th Street", City = "Las Vegas", State = "NV" });
            _customers.Add(new Customer() { CustomerId = 13, Company = "Company M", LastName = "Ludick", FirstName = "Andre", JobTitle = "Purchasing Representative", Address = "456 13th Street", City = "Memphis", State = "TN" });
            _customers.Add(new Customer() { CustomerId = 14, Company = "Company N", LastName = "Grilo", FirstName = "Carlos", JobTitle = "Purchasing Representative", Address = "456 14th Street", City = "Denver", State = "CO" });
            _customers.Add(new Customer() { CustomerId = 15, Company = "Company O", LastName = "Kupkova", FirstName = "Helena", JobTitle = "Purchasing Manager", Address = "456 15th Street", City = "Honolulu", State = "HI" });
            _customers.Add(new Customer() { CustomerId = 16, Company = "Company P", LastName = "Goldschmidt", FirstName = "Daniel", JobTitle = "Purchasing Representative", Address = "456 16th Street", City = "San Francisco", State = "CA" });
            _customers.Add(new Customer() { CustomerId = 17, Company = "Company Q", LastName = "Bagel", FirstName = "Jean Philippe", JobTitle = "Owner", Address = "456 17th Street", City = "Seattle", State = "WA" });
            _customers.Add(new Customer() { CustomerId = 18, Company = "Company R", LastName = "Autier Miconi", FirstName = "Catherine", JobTitle = "Purchasing Representative", Address = "456 18th Street", City = "Boston", State = "MA" });
            _customers.Add(new Customer() { CustomerId = 19, Company = "Company S", LastName = "Eggerer", FirstName = "Alexander", JobTitle = "Accounting Assistant", Address = "789 19th Street", City = "Los Angelas", State = "CA" });
            _customers.Add(new Customer() { CustomerId = 20, Company = "Company T", LastName = "Li", FirstName = "George", JobTitle = "Purchasing Manager", Address = "789 20th Street", City = "New York", State = "NY" });
            _customers.Add(new Customer() { CustomerId = 21, Company = "Company U", LastName = "Tham", FirstName = "Bernard", JobTitle = "Accounting Manager", Address = "789 21th Street", City = "Minneapolis", State = "MN" });
            _customers.Add(new Customer() { CustomerId = 22, Company = "Company V", LastName = "Ramos", FirstName = "Luciana", JobTitle = "Purchasing Assistant", Address = "789 22th Street", City = "Milwaukee", State = "WI" });
            _customers.Add(new Customer() { CustomerId = 23, Company = "Company W", LastName = "Entin", FirstName = "Michael", JobTitle = "Purchasing Manager", Address = "789 23th Street", City = "Portland", State = "OR" });
            _customers.Add(new Customer() { CustomerId = 24, Company = "Company X", LastName = "Hasselberg", FirstName = "Jonas", JobTitle = "Owner", Address = "789 24th Street", City = "Salt Lake City", State = "UT" });
            _customers.Add(new Customer() { CustomerId = 25, Company = "Company Y", LastName = "Rodman", FirstName = "John", JobTitle = "Purchasing Manager", Address = "789 25th Street", City = "Chicago", State = "IL" });
            _customers.Add(new Customer() { CustomerId = 26, Company = "Company Z", LastName = "Liu", FirstName = "Run", JobTitle = "Accounting Assistant", Address = "789 26th Street", City = "Miami", State = "FL" });
            _customers.Add(new Customer() { CustomerId = 27, Company = "Company AA", LastName = "Toh", FirstName = "Karen", JobTitle = "Purchasing Manager", Address = "789 27th Street", City = "Las Vegas", State = "NV" });
            _customers.Add(new Customer() { CustomerId = 28, Company = "Company BB", LastName = "Raghav", FirstName = "Amritansh", JobTitle = "Purchasing Manager", Address = "789 28th Street", City = "Memphis", State = "TN" });
            _customers.Add(new Customer() { CustomerId = 29, Company = "Company CC", LastName = "Lee", FirstName = "Soo Jung", JobTitle = "Purchasing Manager", Address = "789 29th Street", City = "Denver", State = "CO" });
        }

        public Customer[] GetAllCustomers()
        {
            return _customers.ToArray();
        }
    }
}