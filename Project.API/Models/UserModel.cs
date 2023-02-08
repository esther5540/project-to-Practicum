
namespace Project.API.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Tz { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string healthFund { get; set; }
        public int Children { get; set; }
        public string FatherTz { get; set; }
        public string MotherTz { get; set; }

    }
}
