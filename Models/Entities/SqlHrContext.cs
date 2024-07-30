using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace eTicaretMVC.Models;

public partial class SqlHrContext : DbContext
{
    public SqlHrContext()
    {
    }

    public SqlHrContext(DbContextOptions<SqlHrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DboAddress> DboAddresses { get; set; }

    public virtual DbSet<DboBand> DboBands { get; set; }

    public virtual DbSet<DboBanner> DboBanners { get; set; }

    public virtual DbSet<DboBlog> DboBlogs { get; set; }

    public virtual DbSet<DboBlogCat> DboBlogCats { get; set; }

    public virtual DbSet<DboBlogFile> DboBlogFiles { get; set; }

    public virtual DbSet<DboBlogImage> DboBlogImages { get; set; }

    public virtual DbSet<DboBlogTag> DboBlogTags { get; set; }

    public virtual DbSet<DboBrand> DboBrands { get; set; }

    public virtual DbSet<DboCity> DboCities { get; set; }

    public virtual DbSet<DboComment> DboComments { get; set; }

    public virtual DbSet<DboContactForm> DboContactForms { get; set; }

    public virtual DbSet<DboCountry> DboCountries { get; set; }

    public virtual DbSet<DboCoupon> DboCoupons { get; set; }

    public virtual DbSet<DboCustomer> DboCustomers { get; set; }

    public virtual DbSet<DboDistrict> DboDistricts { get; set; }

    public virtual DbSet<DboEditor> DboEditors { get; set; }

    public virtual DbSet<DboLike> DboLikes { get; set; }

    public virtual DbSet<DboMessage> DboMessages { get; set; }

    public virtual DbSet<DboNeighborhood> DboNeighborhoods { get; set; }

    public virtual DbSet<DboNewsletter> DboNewsletters { get; set; }

    public virtual DbSet<DboOrder> DboOrders { get; set; }

    public virtual DbSet<DboOrderDetail> DboOrderDetails { get; set; }

    public virtual DbSet<DboPayment> DboPayments { get; set; }

    public virtual DbSet<DboProduct> DboProducts { get; set; }

    public virtual DbSet<DboProductCat> DboProductCats { get; set; }

    public virtual DbSet<DboProductColor> DboProductColors { get; set; }

    public virtual DbSet<DboProductFile> DboProductFiles { get; set; }

    public virtual DbSet<DboProductImage> DboProductImages { get; set; }

    public virtual DbSet<DboProductSize> DboProductSizes { get; set; }

    public virtual DbSet<DboShipper> DboShippers { get; set; }

    public virtual DbSet<DboSite> DboSites { get; set; }

    public virtual DbSet<DboSlide> DboSlides { get; set; }

    public virtual DbSet<DboStreet> DboStreets { get; set; }

    public virtual DbSet<DboSysdiagram> DboSysdiagrams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=sql_hr;user=root;password=Mcanece.02", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.2.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<DboAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Address");

            entity.Property(e => e.Adress).HasMaxLength(0);
            entity.Property(e => e.CityId)
                .HasMaxLength(0)
                .HasColumnName("CityID");
            entity.Property(e => e.CountryId)
                .HasMaxLength(0)
                .HasColumnName("CountryID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(0)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DistrictId)
                .HasMaxLength(0)
                .HasColumnName("DistrictID");
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(0);
            entity.Property(e => e.NeighborhoodId)
                .HasMaxLength(0)
                .HasColumnName("NeighborhoodID");
            entity.Property(e => e.StreetId)
                .HasMaxLength(0)
                .HasColumnName("StreetID");
        });

        modelBuilder.Entity<DboBand>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Band");

            entity.Property(e => e.Detail).HasMaxLength(0);
            entity.Property(e => e.Extension).HasMaxLength(3);
            entity.Property(e => e.Headline).HasMaxLength(0);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(8);
            entity.Property(e => e.Target).HasMaxLength(0);
            entity.Property(e => e.Title).HasMaxLength(7);
            entity.Property(e => e.Url)
                .HasMaxLength(11)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<DboBanner>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Banner");

            entity.Property(e => e.Detail).HasColumnType("text");
            entity.Property(e => e.Extension).HasMaxLength(3);
            entity.Property(e => e.Headline).HasMaxLength(195);
            entity.Property(e => e.Height).HasMaxLength(0);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(36);
            entity.Property(e => e.Target).HasMaxLength(0);
            entity.Property(e => e.Title).HasMaxLength(31);
            entity.Property(e => e.Url)
                .HasMaxLength(36)
                .HasColumnName("URL");
            entity.Property(e => e.Width).HasMaxLength(0);
        });

        modelBuilder.Entity<DboBlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Blog");

            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.Date).HasMaxLength(19);
            entity.Property(e => e.Detail).HasColumnType("text");
            entity.Property(e => e.EditorId).HasColumnName("EditorID");
            entity.Property(e => e.Extension).HasMaxLength(3);
            entity.Property(e => e.Headline).HasMaxLength(11);
            entity.Property(e => e.Height).HasMaxLength(0);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(36);
            entity.Property(e => e.Title).HasMaxLength(33);
            entity.Property(e => e.Width).HasMaxLength(0);
        });

        modelBuilder.Entity<DboBlogCat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.BlogCat");

            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.Detail).HasMaxLength(11);
            entity.Property(e => e.Extension).HasMaxLength(3);
            entity.Property(e => e.Headline).HasMaxLength(6);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(36);
            entity.Property(e => e.Title).HasMaxLength(5);
        });

        modelBuilder.Entity<DboBlogFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.BlogFile");

            entity.Property(e => e.Detail).HasMaxLength(0);
            entity.Property(e => e.Extension).HasMaxLength(0);
            entity.Property(e => e.Headline).HasMaxLength(0);
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.IsConfirm).HasMaxLength(0);
            entity.Property(e => e.Name).HasMaxLength(0);
            entity.Property(e => e.RowNumber).HasMaxLength(0);
            entity.Property(e => e.Size).HasMaxLength(0);
            entity.Property(e => e.Title).HasMaxLength(0);
            entity.Property(e => e.TypeId)
                .HasMaxLength(0)
                .HasColumnName("TypeID");
        });

        modelBuilder.Entity<DboBlogImage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.BlogImage");

            entity.Property(e => e.Detail).HasMaxLength(0);
            entity.Property(e => e.Extension).HasMaxLength(3);
            entity.Property(e => e.Headline).HasMaxLength(0);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(36);
            entity.Property(e => e.Title).HasMaxLength(7);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
        });

        modelBuilder.Entity<DboBlogTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.BlogTag");

            entity.Property(e => e.BlogId).HasColumnName("BlogID");
            entity.Property(e => e.Title).HasMaxLength(7);
        });

        modelBuilder.Entity<DboBrand>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Brand");

            entity.Property(e => e.Date).HasMaxLength(19);
            entity.Property(e => e.Detail).HasMaxLength(12);
            entity.Property(e => e.Extension).HasMaxLength(3);
            entity.Property(e => e.Headline).HasMaxLength(12);
            entity.Property(e => e.Height).HasMaxLength(1);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(36);
            entity.Property(e => e.Title).HasMaxLength(9);
            entity.Property(e => e.Url)
                .HasMaxLength(0)
                .HasColumnName("URL");
            entity.Property(e => e.Width).HasMaxLength(1);
        });

        modelBuilder.Entity<DboCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.City");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(14);
        });

        modelBuilder.Entity<DboComment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Comment");

            entity.Property(e => e.Comment).HasMaxLength(0);
            entity.Property(e => e.Date).HasMaxLength(0);
            entity.Property(e => e.Email).HasMaxLength(0);
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.IsConfirm).HasMaxLength(0);
            entity.Property(e => e.IsRead).HasMaxLength(0);
            entity.Property(e => e.Name).HasMaxLength(0);
            entity.Property(e => e.Phone).HasMaxLength(0);
            entity.Property(e => e.Rate).HasMaxLength(0);
            entity.Property(e => e.Subject).HasMaxLength(0);
            entity.Property(e => e.Type).HasMaxLength(0);
            entity.Property(e => e.TypeId)
                .HasMaxLength(0)
                .HasColumnName("TypeID");
        });

        modelBuilder.Entity<DboContactForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ContactForm");

            entity.Property(e => e.Date).HasMaxLength(0);
            entity.Property(e => e.Email).HasMaxLength(0);
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.IsConfirm).HasMaxLength(0);
            entity.Property(e => e.Message).HasMaxLength(0);
            entity.Property(e => e.Name).HasMaxLength(0);
            entity.Property(e => e.Phone).HasMaxLength(0);
            entity.Property(e => e.Subject).HasMaxLength(0);
        });

        modelBuilder.Entity<DboCountry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Country");

            entity.Property(e => e.Code).HasMaxLength(2);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Language).HasMaxLength(3);
            entity.Property(e => e.Name).HasMaxLength(34);
            entity.Property(e => e.PhoneCode).HasMaxLength(2);
        });

        modelBuilder.Entity<DboCoupon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Coupon");

            entity.Property(e => e.Code).HasMaxLength(9);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.EndDate).HasMaxLength(19);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.StartDate).HasMaxLength(19);
            entity.Property(e => e.Type).HasMaxLength(1);
        });

        modelBuilder.Entity<DboCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Customer");

            entity.Property(e => e.Code).HasMaxLength(0);
            entity.Property(e => e.Date).HasMaxLength(0);
            entity.Property(e => e.Detail).HasMaxLength(0);
            entity.Property(e => e.Email).HasMaxLength(0);
            entity.Property(e => e.Extension).HasMaxLength(0);
            entity.Property(e => e.Facebook).HasMaxLength(0);
            entity.Property(e => e.Gender).HasMaxLength(0);
            entity.Property(e => e.Headline).HasMaxLength(0);
            entity.Property(e => e.Height).HasMaxLength(0);
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(0);
            entity.Property(e => e.Instagram).HasMaxLength(0);
            entity.Property(e => e.IsAgreement).HasMaxLength(0);
            entity.Property(e => e.IsConfirm).HasMaxLength(0);
            entity.Property(e => e.IsEmailView).HasMaxLength(0);
            entity.Property(e => e.IsFacebookView).HasMaxLength(0);
            entity.Property(e => e.IsInstagramView).HasMaxLength(0);
            entity.Property(e => e.IsLinkedinVİew).HasMaxLength(0);
            entity.Property(e => e.IsRemember).HasMaxLength(0);
            entity.Property(e => e.IsTwitterView).HasMaxLength(0);
            entity.Property(e => e.Lastname).HasMaxLength(0);
            entity.Property(e => e.Likes).HasMaxLength(0);
            entity.Property(e => e.Linkedin).HasMaxLength(0);
            entity.Property(e => e.Name).HasMaxLength(0);
            entity.Property(e => e.Password).HasMaxLength(0);
            entity.Property(e => e.PasswordNew).HasMaxLength(0);
            entity.Property(e => e.PasswordNewConfirm).HasMaxLength(0);
            entity.Property(e => e.Phone).HasMaxLength(0);
            entity.Property(e => e.RowNumber).HasMaxLength(0);
            entity.Property(e => e.Twitter).HasMaxLength(0);
            entity.Property(e => e.Views).HasMaxLength(0);
            entity.Property(e => e.Width).HasMaxLength(0);
        });

        modelBuilder.Entity<DboDistrict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.District");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(16);
        });

        modelBuilder.Entity<DboEditor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Editor");

            entity.Property(e => e.Date).HasMaxLength(19);
            entity.Property(e => e.Detail).HasMaxLength(42);
            entity.Property(e => e.Email).HasMaxLength(18);
            entity.Property(e => e.Extension).HasMaxLength(3);
            entity.Property(e => e.Headline).HasMaxLength(42);
            entity.Property(e => e.Height).HasMaxLength(0);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(36);
            entity.Property(e => e.Linkedin).HasMaxLength(0);
            entity.Property(e => e.Password).HasMaxLength(8);
            entity.Property(e => e.Title).HasMaxLength(18);
            entity.Property(e => e.Url)
                .HasMaxLength(35)
                .HasColumnName("URL");
            entity.Property(e => e.Width).HasMaxLength(0);
        });

        modelBuilder.Entity<DboLike>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Like");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(0)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.ProductId)
                .HasMaxLength(0)
                .HasColumnName("ProductID");
        });

        modelBuilder.Entity<DboMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Message");

            entity.Property(e => e.Date).HasMaxLength(19);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Message).HasMaxLength(20);
            entity.Property(e => e.RecipientId).HasColumnName("RecipientID");
            entity.Property(e => e.SenderId).HasColumnName("SenderID");
        });

        modelBuilder.Entity<DboNeighborhood>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Neighborhood");

            entity.Property(e => e.Code).HasColumnType("mediumint");
            entity.Property(e => e.DistrictId)
                .HasColumnType("mediumint")
                .HasColumnName("DistrictID");
            entity.Property(e => e.Id)
                .HasColumnType("mediumint")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(48);
        });

        modelBuilder.Entity<DboNewsletter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Newsletter");

            entity.Property(e => e.Email).HasMaxLength(0);
            entity.Property(e => e.Gsm).HasMaxLength(0);
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.IsConfirm).HasMaxLength(0);
            entity.Property(e => e.Name).HasMaxLength(0);
        });

        modelBuilder.Entity<DboOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Order");

            entity.Property(e => e.AdressId)
                .HasMaxLength(0)
                .HasColumnName("AdressID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(0)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.IsComplated).HasMaxLength(0);
            entity.Property(e => e.IsPaid).HasMaxLength(0);
            entity.Property(e => e.OrderDate).HasMaxLength(0);
            entity.Property(e => e.PaymentId)
                .HasMaxLength(0)
                .HasColumnName("PaymentID");
            entity.Property(e => e.ShipperId)
                .HasMaxLength(0)
                .HasColumnName("ShipperID");
        });

        modelBuilder.Entity<DboOrderDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.OrderDetail");

            entity.Property(e => e.ColorId)
                .HasMaxLength(0)
                .HasColumnName("ColorID");
            entity.Property(e => e.Discount).HasMaxLength(0);
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.OrderId)
                .HasMaxLength(0)
                .HasColumnName("OrderID");
            entity.Property(e => e.Price).HasMaxLength(0);
            entity.Property(e => e.ProductId)
                .HasMaxLength(0)
                .HasColumnName("ProductID");
            entity.Property(e => e.Quantity).HasMaxLength(0);
            entity.Property(e => e.RowNumber).HasMaxLength(0);
            entity.Property(e => e.SizeId)
                .HasMaxLength(0)
                .HasColumnName("SizeID");
            entity.Property(e => e.Total).HasMaxLength(0);
        });

        modelBuilder.Entity<DboPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Payment");

            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.IsAllow).HasMaxLength(0);
            entity.Property(e => e.Name).HasMaxLength(0);
        });

        modelBuilder.Entity<DboProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Product");

            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.Date).HasMaxLength(19);
            entity.Property(e => e.Detail).HasMaxLength(20);
            entity.Property(e => e.EditorId).HasColumnName("EditorID");
            entity.Property(e => e.Extension).HasMaxLength(3);
            entity.Property(e => e.Headline).HasMaxLength(18);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(36);
            entity.Property(e => e.Price).HasPrecision(3, 1);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<DboProductCat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ProductCat");

            entity.Property(e => e.CatId).HasColumnName("CatID");
            entity.Property(e => e.Detail).HasMaxLength(0);
            entity.Property(e => e.Extension).HasMaxLength(3);
            entity.Property(e => e.Headline).HasMaxLength(0);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(36);
            entity.Property(e => e.Title).HasMaxLength(25);
        });

        modelBuilder.Entity<DboProductColor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ProductColor");

            entity.Property(e => e.Color).HasMaxLength(0);
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.IsConfirm).HasMaxLength(0);
            entity.Property(e => e.ProductId)
                .HasMaxLength(0)
                .HasColumnName("ProductID");
            entity.Property(e => e.RowNumber).HasMaxLength(0);
        });

        modelBuilder.Entity<DboProductFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ProductFile");

            entity.Property(e => e.Detail).HasMaxLength(0);
            entity.Property(e => e.Extension).HasMaxLength(0);
            entity.Property(e => e.Headline).HasMaxLength(0);
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.IsConfirm).HasMaxLength(0);
            entity.Property(e => e.Name).HasMaxLength(0);
            entity.Property(e => e.RowNumber).HasMaxLength(0);
            entity.Property(e => e.Size).HasMaxLength(0);
            entity.Property(e => e.Title).HasMaxLength(0);
            entity.Property(e => e.TypeId)
                .HasMaxLength(0)
                .HasColumnName("TypeID");
        });

        modelBuilder.Entity<DboProductImage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ProductImage");

            entity.Property(e => e.Detail).HasMaxLength(0);
            entity.Property(e => e.Extension).HasMaxLength(0);
            entity.Property(e => e.Headline).HasMaxLength(0);
            entity.Property(e => e.Height).HasMaxLength(0);
            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.Image).HasMaxLength(0);
            entity.Property(e => e.IsConfirm).HasMaxLength(0);
            entity.Property(e => e.RowNumber).HasMaxLength(0);
            entity.Property(e => e.Title).HasMaxLength(0);
            entity.Property(e => e.TypeId)
                .HasMaxLength(0)
                .HasColumnName("TypeID");
            entity.Property(e => e.Width).HasMaxLength(0);
        });

        modelBuilder.Entity<DboProductSize>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ProductSize");

            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.IsConfirm).HasMaxLength(0);
            entity.Property(e => e.ProductId)
                .HasMaxLength(0)
                .HasColumnName("ProductID");
            entity.Property(e => e.RowNumber).HasMaxLength(0);
            entity.Property(e => e.Size).HasMaxLength(0);
        });

        modelBuilder.Entity<DboShipper>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Shipper");

            entity.Property(e => e.Id)
                .HasMaxLength(0)
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(0);
            entity.Property(e => e.Price).HasMaxLength(0);
            entity.Property(e => e.TrakingNumber).HasMaxLength(0);
            entity.Property(e => e.Url)
                .HasMaxLength(0)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<DboSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Site");

            entity.Property(e => e.Address).HasMaxLength(28);
            entity.Property(e => e.AdminEmail).HasMaxLength(17);
            entity.Property(e => e.AdminName).HasMaxLength(18);
            entity.Property(e => e.ContactInfo).HasMaxLength(1);
            entity.Property(e => e.Description).HasMaxLength(61);
            entity.Property(e => e.Email).HasMaxLength(15);
            entity.Property(e => e.Error).HasMaxLength(0);
            entity.Property(e => e.Facebook).HasMaxLength(34);
            entity.Property(e => e.FaviconExtension).HasMaxLength(3);
            entity.Property(e => e.FaviconHeight).HasMaxLength(0);
            entity.Property(e => e.FaviconImage).HasMaxLength(36);
            entity.Property(e => e.FaviconWidth).HasMaxLength(0);
            entity.Property(e => e.Instagram).HasMaxLength(35);
            entity.Property(e => e.Intro).HasMaxLength(0);
            entity.Property(e => e.IntroExtension).HasMaxLength(0);
            entity.Property(e => e.IntroHeight).HasMaxLength(0);
            entity.Property(e => e.IntroImage).HasMaxLength(0);
            entity.Property(e => e.IntroWidth).HasMaxLength(0);
            entity.Property(e => e.Keywords).HasMaxLength(47);
            entity.Property(e => e.LoginTime).HasMaxLength(19);
            entity.Property(e => e.LogoExtension).HasMaxLength(3);
            entity.Property(e => e.LogoHeight).HasMaxLength(0);
            entity.Property(e => e.LogoImage).HasMaxLength(36);
            entity.Property(e => e.LogoWidth).HasMaxLength(0);
            entity.Property(e => e.Maps).HasColumnType("text");
            entity.Property(e => e.Password).HasMaxLength(10);
            entity.Property(e => e.PasswordNew).HasMaxLength(9);
            entity.Property(e => e.PasswordNewConfirm).HasMaxLength(9);
            entity.Property(e => e.PopupExtension).HasMaxLength(0);
            entity.Property(e => e.PopupHeight).HasMaxLength(0);
            entity.Property(e => e.PopupImage).HasMaxLength(0);
            entity.Property(e => e.PopupTarget).HasMaxLength(5);
            entity.Property(e => e.PopupUrl)
                .HasMaxLength(0)
                .HasColumnName("PopupURL");
            entity.Property(e => e.PopupWidth).HasMaxLength(0);
            entity.Property(e => e.Shift).HasMaxLength(0);
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
            entity.Property(e => e.Smtppassword)
                .HasMaxLength(10)
                .HasColumnName("SMTPPassword");
            entity.Property(e => e.Smtpport).HasColumnName("SMTPPort");
            entity.Property(e => e.Smtpserver)
                .HasMaxLength(18)
                .HasColumnName("SMTPServer");
            entity.Property(e => e.Smtpssl).HasColumnName("SMTPSSL");
            entity.Property(e => e.Smtpuser)
                .HasMaxLength(18)
                .HasColumnName("SMTPUser");
            entity.Property(e => e.Title).HasMaxLength(32);
            entity.Property(e => e.Twitter).HasMaxLength(33);
            entity.Property(e => e.Url)
                .HasMaxLength(14)
                .HasColumnName("URL");
            entity.Property(e => e.Username).HasMaxLength(15);
            entity.Property(e => e.Youtube).HasMaxLength(33);
        });

        modelBuilder.Entity<DboSlide>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Slide");

            entity.Property(e => e.ButtonText).HasMaxLength(8);
            entity.Property(e => e.Detail).HasMaxLength(0);
            entity.Property(e => e.Extension).HasMaxLength(3);
            entity.Property(e => e.Headline).HasMaxLength(110);
            entity.Property(e => e.Image).HasMaxLength(6);
            entity.Property(e => e.OffCard).HasMaxLength(35);
            entity.Property(e => e.SlideId).HasColumnName("SlideID");
            entity.Property(e => e.Subtitle).HasMaxLength(10);
            entity.Property(e => e.Target).HasMaxLength(6);
            entity.Property(e => e.Title).HasMaxLength(12);
            entity.Property(e => e.Url)
                .HasMaxLength(22)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<DboStreet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.Street");

            entity.Property(e => e.Id)
                .HasColumnType("mediumint")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(70);
            entity.Property(e => e.NeighborhoodId)
                .HasColumnType("mediumint")
                .HasColumnName("NeighborhoodID");
        });

        modelBuilder.Entity<DboSysdiagram>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.sysdiagrams");

            entity.Property(e => e.Definition)
                .HasColumnType("text")
                .HasColumnName("definition");
            entity.Property(e => e.DiagramId).HasColumnName("diagram_id");
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .HasColumnName("name");
            entity.Property(e => e.PrincipalId).HasColumnName("principal_id");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
