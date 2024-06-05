using System;
using System.Collections.Generic;

namespace PetShop.DataAccessLayer.Models
{
    public partial class ProductImage
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateModified { get; set; }
        public bool Data { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}
