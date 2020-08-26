using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinConsole
{
    public class ResponseUser
    {
        public ResponseUser(Users user)
        {
            this.ID = user.ID;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.MiddleName = user.MiddleName;
            this.Email = user.Email;
            this.Phone = user.Phone;
            this.Image = user.Image;
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] Image { get; set; }
    }
}
