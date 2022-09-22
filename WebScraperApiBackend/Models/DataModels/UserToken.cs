﻿using System.Globalization;

namespace WebScraperApiBackend.Models.DataModels
{
    public class UserToken
    {
        public int Id { get; set; } 
        public string Token { get; set; }
        public string UserName { get; set; }
        public Role UserRole { get; set; }
        public TimeSpan Validity { get; set; } 
        public string RefreshToken { get; set; }
        public string EmailId { get; set; }
        public Guid GuidId { get; set; }
        public DaylightTime ExpiredTime { get; set; }
    }
}
