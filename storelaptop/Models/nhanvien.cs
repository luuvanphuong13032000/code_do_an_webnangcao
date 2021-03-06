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

    public partial class nhanvien
    {
        [DisplayName("Mã Nhân Viên")]
        public int manhanvien { get; set; }
        [DisplayName("Ảnh")]
        [Required(ErrorMessage = "Bạn phải nhập ảnh")]
        public string anh { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập tên nhân viên")]
        [DisplayName("Tên Nhân Viên")]
        public string tennhanvien { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập ngày sinh")]
        [DisplayName("Ngày Sinh")]
        public Nullable<System.DateTime> ngaysinh { get; set; }
        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Bạn phải nhập địa chỉ")]
        public string diachi { get; set; }
        [DisplayName("Số Điện Thoại")]
        [Required(ErrorMessage = "Bạn phải nhập số điện thoại")]
        [MaxLength(10)]
        public string sodienthoai { get; set; }
    }
}
