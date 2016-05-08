namespace Courseware.Models
{
    public abstract class UserBase
    {
        public string name { get; set; }
        public string image { get; set; }

    }
    public class User : UserBase
    {    }
}