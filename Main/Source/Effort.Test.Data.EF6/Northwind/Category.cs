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
    
    public class Category
    {
        public virtual int CategoryID { get; set; }
    
        public virtual string CategoryName { get; set; }
    
        public virtual string Description { get; set; }
    
        public virtual byte[] Picture { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    
    
    }
}
