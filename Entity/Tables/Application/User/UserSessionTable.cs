using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainEntity.Tables.User
{
    public class UserSessionTable 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SessionId { get; set; }
        
        public int UserId { get; set; }
        [ForeignKey("UserId"), InverseProperty("UserSessionTables")]
        public UserTable UserTable { get; set; }

        private DateTime _loginUtcDateTime = DateTime.UtcNow;
        private DateTime _logoutUtcDateTime = DateTime.UtcNow;
        public DateTime LoginUtcDateTime
        {
            get { return _loginUtcDateTime; }
            set { _loginUtcDateTime = value; }
        }
        public DateTime LogoutUtcDateTime
        {
            get { return _logoutUtcDateTime; }
            set { _logoutUtcDateTime = value; }
        }
        [NotMapped]
        public DateTime LoginDateTime
        {
            get { return _loginUtcDateTime.ToLocalTime(); }
            set { _loginUtcDateTime = value.ToUniversalTime(); }
        }
        [NotMapped]
        public DateTime LogoutDateTime
        {
            get { return _logoutUtcDateTime.ToLocalTime(); }
            set { _logoutUtcDateTime = value.ToUniversalTime(); }
        }

        public bool IsLogout { get; set; }
    }
}