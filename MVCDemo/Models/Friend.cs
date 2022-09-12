using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using Xunit.Sdk;

namespace MVCDemo.Models
{
    public class Friend
    {
        [Required]
        public int FriendID { get; set; }

        [DisallowNull]
        public string FriendName { get; set; }

        [MaxLength(25)]

        public string Place { get; set; }
    }
}
