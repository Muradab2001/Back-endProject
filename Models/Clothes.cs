using MultiShop.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiShop.Models
{
    public class Clothes:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Text { get; set; }
        public string Desc { get; set; }
        public int InformationId{ get; set; }
        public ClothesInformation ClothesInformation { get; set; }
        public List<ClothesColor> ClothesColors { get; set; }
        List <ClothesSizes> ClothesSizes { get; set; }
    }
}
