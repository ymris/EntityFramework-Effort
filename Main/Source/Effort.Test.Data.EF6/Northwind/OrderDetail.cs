//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Effort.Test.Data.Northwind
{
    
    public class OrderDetail
    {
        public virtual int OrderID { get; set; }
    
        public virtual int ProductID { get; set; }
    
        public virtual decimal UnitPrice { get; set; }
    
        public virtual short Quantity { get; set; }
    
        public virtual float Discount { get; set; }
    
        public virtual Order Order { get; set; }
    
        public virtual Product Product { get; set; }
    
    
    }
}
