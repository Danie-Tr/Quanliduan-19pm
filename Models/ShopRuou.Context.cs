﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShopRuouEntities : DbContext
    {
        public ShopRuouEntities()
            : base("name=ShopRuouEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DatHang> DatHang { get; set; }
        public virtual DbSet<DatHang_ChiTiet> DatHang_ChiTiet { get; set; }
        public virtual DbSet<Hang> Hang { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<Loai> Loai { get; set; }
        public virtual DbSet<NoiSanXuat> NoiSanXuat { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
    }
}
