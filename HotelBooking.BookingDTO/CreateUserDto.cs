﻿
namespace HotelBooking.BookingDTO
{
    public class CreateUserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int AccessLevel { get; set; } = 0;
    }
}
