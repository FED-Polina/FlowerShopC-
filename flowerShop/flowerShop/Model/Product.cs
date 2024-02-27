//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace flowerShop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderProduct = new HashSet<OrderProduct>();
        }
    
        public string ProductArticle { get; set; }
        public string ProductName { get; set; }
        public int ProductUnit { get; set; }
        public decimal ProductCost { get; set; }
        public int ProductDiscountMax { get; set; }
        public int ProductManufacturer { get; set; }
        public int ProductProvider { get; set; }
        public int ProductCategory { get; set; }
        public int ProductDiscount { get; set; }
        public int ProductCount { get; set; }
        public string ProductDiscription { get; set; }
        public string ProductPhoto { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
