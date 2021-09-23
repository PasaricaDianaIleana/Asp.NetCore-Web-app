using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class User:IdentityUser
    {
        [MaxLength(25)]
        [Required]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [DataType(DataType.CreditCard)]
        [ProtectedPersonalData]
        public string CardNumber { get; set; }
        [ProtectedPersonalData]
        public short? CNP { get; set; }
        [MaxLength(70)]
        public string HomeAddress { get; set; }
        [DataType(DataType.PostalCode)]
        public int? ZipCode { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
