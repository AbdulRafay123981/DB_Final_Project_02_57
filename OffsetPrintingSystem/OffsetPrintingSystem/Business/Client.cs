using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffsetPrintingSystem.Business
{
    public class Client
    {
        private int id;
        private string name;
        private string contactPerson;
        private string phone;
        private string email;
        private string address;

        public void SetId(int id) { this.id = id; }
        public int GetId() { return this.id; }

        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }

        public void SetContactPerson(string contactPerson) { this.contactPerson = contactPerson; }
        public string GetContactPerson() { return this.contactPerson; }

        public void SetPhone(string phone) { this.phone = phone; }
        public string GetPhone() { return this.phone; }

        public void SetEmail(string email) { this.email = email; }
        public string GetEmail() { return this.email; }

        public void SetAddress(string address) { this.address = address; }
        public string GetAddress() { return this.address; }
    }
}