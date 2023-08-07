using Demo1.Enums;

namespace Demo1.Model.ResponseModel
{
    public class UserResponse
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool isActive { get; set; }
        public Roles Role { get; set; }
    }
}
