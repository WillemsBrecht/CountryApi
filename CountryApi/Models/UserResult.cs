using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CountryApi.Models
{
    public class UserResult : Result
    {
        public UserResult(bool success, string message = "")
        {
            Success = success;
            Message = message;
        }
        public List<User> userList { get; set; }
        public User OneUser { get; set; }
    }
}
