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
    using System.Web;

    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.DatHang_ChiTiet = new HashSet<DatHang_ChiTiet>();
        }

        public int ID { get; set; }
        [Display(Name = "Mã loại sản phẩm")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<int> Loai_ID { get; set; }
        

        [Display(Name = "Mã hãng sản phẩm")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<int> Hang_ID { get; set; }
       
        [Display(Name = "Mã nơi sản xuất")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<int> NoiSanXuat_ID { get; set; }
       

        [Display(Name = "Tên sản phẩm")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string TenSanPham { get; set; }
       

        [Display(Name = "Nồng độ")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string NongDo { get; set; }
       
        [Display(Name = "Thể tích")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string TheTich { get; set; }
       

       
        [Display(Name = "Ngày nhập")]
        [Required(ErrorMessage = "Ngày nhập không được bỏ trống!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> NgayNhap { get; set; }
        

        [Display(Name = "Đơn giá")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<int> DonGia { get; set; }
        
        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<int> SoLuong { get; set; }
        
        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string MoTa { get; set; }
       
        [Display(Name = "Hình ảnh bìa")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string HinhAnhBia { get; set; }

        [Display(Name = "Hình ảnh bìa")]
        public HttpPostedFileBase DuLieuHinhAnhBia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [Display(Name = "Đặt hàng chi tiết")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public virtual ICollection<DatHang_ChiTiet> DatHang_ChiTiet { get; set; }
        
        [Display(Name = "Hãng")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public virtual Hang Hang { get; set; }
        
        [Display(Name = "Loại")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public virtual Loai Loai { get; set; }
       

        [Display(Name = "Nơi sản xuất")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public virtual NoiSanXuat NoiSanXuat { get; set; }
        

    }
}
