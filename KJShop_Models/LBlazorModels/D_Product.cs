using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KJShop_Models.LBlazorModels
{
    public class D_Product
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }
        public bool IsActive { get; set; }
        public List<D_ProductProp> ProductProperties { get; set; }
    }
}
