using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Data
{
    public class Customer
    {
        int customerId;
        string firstName, lastName, contactPhone, email, note;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string ContactPhone { get => contactPhone; set => contactPhone = value; }
        public string Email { get => email; set => email = value; }
        public string Note { get => note; set => note = value; }

        public Customer()
        {

        }

        public Customer(int customerId, string firstName, string lastName, string contactPhone, string email, string note)
        {
            this.customerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactPhone = contactPhone;
            this.email = email;
            this.note = note;
        }
    }
}

