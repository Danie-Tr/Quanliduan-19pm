//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopRuou.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatHang()
        {
            this.DatHang_ChiTiet = new HashSet<DatHang_ChiTiet>();
        }
    
        public int ID { get; set; }

        [Display(Name = "Mã tài khoản")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<int> TaiKhoan_ID { get; set; }


        [Display(Name = "Mã khách hàng")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<int> KhachHang_ID { get; set; }


        [Display(Name = "Điện thoại giao hàng")]
        [RegularExpression(@"^((09|03|07|08|05)\d{8})$", ErrorMessage = "Số điện thoại không đúng")]
        public string DienThoaiGiaoHang { get; set; }

        [Display(Name = "Địa chỉ giao hàng")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string DiaChiGiaoHang { get; set; }
       

        [Display(Name = "Ngày đặt hàng")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<System.DateTime> NgayDatHang { get; set; }


        [Display(Name = "Tình trạng đơn hàng")]

        public Nullable<short> TinhTrang { get; set; }


        [Display(Name = "Khách hàng")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public virtual KhachHang KhachHang { get; set; }


        [Display(Name = "Tài khoản")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public virtual TaiKhoan TaiKhoan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]


        [Display(Name = "Chi tiết đặt hàng ")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public virtual ICollection<DatHang_ChiTiet> DatHang_ChiTiet { get; set; }
    }
}
