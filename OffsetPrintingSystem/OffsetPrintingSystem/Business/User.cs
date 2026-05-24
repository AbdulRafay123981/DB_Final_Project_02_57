using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffsetPrintingSystem.Business
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string role;

        public void SetId(int id) { this.id = id; }
        public int GetId() { return this.id; }

        public void SetUsername(string username) { this.username = username; }
        public string GetUsername() { return this.username; }

        public void SetPassword(string password) { this.password = password; }
        public string GetPassword() { return this.password; }

        public void SetRole(string role) { this.role = role; }
        public string GetRole() { return this.role; }
    }
}