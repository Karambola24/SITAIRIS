using System.ComponentModel.DataAnnotations;
namespace Server.Model
{
    public class Client_Order
    {
        [Key]
       public int ID_Order { get; set; }  
        public DateTime Order_Date { get; set; }
        public string Work_Description { get; set; }
        public string Status { get; set;}
        public int ID_Client { get; set; }
        public int ID_Employee { get; set; }
    }
}
