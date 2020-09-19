using System.ComponentModel.DataAnnotations;

namespace MotobikeShop.Models.Entities
{
    public class Info
    {
        public int Id { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public int WardId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [MaxLength(200)]
        [Required(ErrorMessage = "Trường này không được bỏ trống")]
        public string HouseNum { get; set; }
    }
}
