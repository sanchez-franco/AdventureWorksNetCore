using System;

namespace AdventureWorks.Common.Model
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JwtToken { get; set; }
    }
}
