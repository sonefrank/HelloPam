using System;

namespace HelloPam.BO
{
    public class User
    {
        public int id { get; set; }

        public string  Username { get; set; }

        public string Password { get; set; }

        public string Fullname { get; set; }
        
        public int Profile { get; set; }

        public bool Stutus { get; set; }

        public byte[] Picture { get; set; }

        public DateTime CreatedAT { get; set; }

        public User()
        {

        }

        public User(int id, string username, string password, string fullname, int profile, bool stutus, byte[] picture,DateTime createdAT)
        {
            this.id = id;
            Username = username;
            Password = password;
            Fullname = fullname;
            Profile = profile;
            Stutus = stutus;
            Picture = picture;
            CreatedAT = createdAT;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   id == user.id;
        }
    }
}
