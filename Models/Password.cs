using Microsoft.VisualBasic;

namespace PasswordMgr.Models
{
    public class Password
    {
        public int Id { get; set; }
        public string Site { get; set; }
        public string Username { get; set; }
        public string Secret { get; set; }

        public Password() { }
    }
}
