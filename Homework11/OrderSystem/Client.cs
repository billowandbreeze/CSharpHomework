using System;

namespace OrderManageSystem
{
    public class Client
    {
        public String Id { get; set; }
        public String Name { get; set; }

        public Client()
        {

        }

        public Client(String Id, String Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Id + ": " + Name;
        }
    }
}
