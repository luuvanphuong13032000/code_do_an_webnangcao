﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace storelaptop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class danhmucsanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public danhmucsanpham()
        {
            this.sanphams = new HashSet<sanpham>();
        }

        [DisplayName("Mã Hãng Sản Phẩm")]
        public int madanhmucsanpham { get; set; }
       
        [DisplayName("Tên Hãng Sản Phẩm")]
        [Required(ErrorMessage = "Bạn phải nhập tên hãng sản phẩm")]
        public string tendanhmucsanpham { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sanpham> sanphams { get; set; }
    }
}
