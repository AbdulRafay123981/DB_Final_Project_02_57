using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OffsetPrintingSystem.Business;

namespace OffsetPrintingSystem.Logic
{
    public class ClientLogic
    {
        public List<Client> GetAllClients()
        {
            List<Client> list = new List<Client>();
            string query = "SELECT * FROM clients";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Client c = new Client();
                c.SetId(Convert.ToInt32(reader["id"]));
                c.SetName(reader["name"].ToString());
                c.SetContactPerson(reader["contact_person"].ToString());
                c.SetPhone(reader["phone"].ToString());
                c.SetEmail(reader["email"].ToString());
                c.SetAddress(reader["address"].ToString());
                list.Add(c);
            }
            reader.Close();
            return list;
        }

        public void AddClient(Client c)
        {
            string query = $"INSERT INTO clients (name, contact_person, phone, email, address) " +
                           $"VALUES ('{c.GetName()}', '{c.GetContactPerson()}', '{c.GetPhone()}', '{c.GetEmail()}', '{c.GetAddress()}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void UpdateClient(Client c)
        {
            string query = $"UPDATE clients SET name = '{c.GetName()}', contact_person = '{c.GetContactPerson()}', " +
                           $"phone = '{c.GetPhone()}', email = '{c.GetEmail()}', address = '{c.GetAddress()}' WHERE id = {c.GetId()}";
            DatabaseHelper.Instance.Update(query);
        }

        public void DeleteClient(int id)
        {
            string query = $"DELETE FROM clients WHERE id = {id}";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
