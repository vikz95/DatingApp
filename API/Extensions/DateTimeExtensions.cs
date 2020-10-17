using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dayOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dayOfBirth.Year;
            if (dayOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}