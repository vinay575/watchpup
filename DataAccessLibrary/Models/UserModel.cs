using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class UserModel
    {
        public Int32 UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string AltEmailId { get; set; }
        public string AgreeTermsConditions { get; set; }
        public Int16 StealthMode { get; set; }
        public string VerificationId { get; set; }
        public DateTime VerificationIdCreatedAt { get; set; }
        public DateTime VerificationIdExpiresAt { get; set; }
        public Int16 Verified { get; set; }
        public string ForgotPasswordId { get; set; }
        public DateTime ForgotPasswordIdCreatedAt { get; set; }
        public DateTime ForgotPasswordIdExpiresAt { get; set; }
        public DateTime CreateDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }

    }
}
