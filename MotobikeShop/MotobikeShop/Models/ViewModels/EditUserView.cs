using Microsoft.AspNetCore.Http;
using MotobikeShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Models.ViewModels
{
    public class EditUserView
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public Address Address { get; set; }
        public string Avatar_Path { get; set; }
        public string RoleId { get; set; }
        public IFormFile Iformfile_path { get; set; }
    }
}
