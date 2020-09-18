using MotobikeShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Models.ViewModels
{
    public class ReStoreCategoryView
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public bool IsRestore{ get; set; }
    }
}
