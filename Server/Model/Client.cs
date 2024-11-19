using System.ComponentModel.DataAnnotations;
namespace Server.Model
{
    public class Client
    {
        [Key]
        public int ID_Client { get; set; }
        public string Client_Name { get; set; }
        public string Address { get; set;}
        public string Phone_Number { get; set;}
        public string Email { get;}
    }
}
