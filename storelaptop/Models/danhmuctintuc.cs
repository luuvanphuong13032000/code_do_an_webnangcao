//------------------------------------------------------------------------------
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

    public partial class danhmuctintuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public danhmuctintuc()
        {
            this.tintucs = new HashSet<tintuc>();
        }

        [DisplayName("Mã Danh Mục Tin Tức")]
        public int madanhmuctintuc { get; set; }
        [DisplayName("Tên Danh Mục Tin Tức")]
        [Required(ErrorMessage = "Bạn phải nhập tên danh mục tin tức")]
        public string tendanhmuctintuc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tintuc> tintucs { get; set; }
    }
}
