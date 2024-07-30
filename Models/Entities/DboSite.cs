using System;
using System.Collections.Generic;

namespace eTicaretMVC.Models;

public partial class DboSite
{
    public sbyte? SiteId { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public string? Intro { get; set; }

    public string? Keywords { get; set; }

    public string? IntroImage { get; set; }

    public string? IntroExtension { get; set; }

    public string? LogoImage { get; set; }

    public string? LogoExtension { get; set; }

    public string? Shift { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? AdminName { get; set; }

    public string? LoginTime { get; set; }

    public string? AdminEmail { get; set; }

    public string? Smtpserver { get; set; }

    public string? Smtpuser { get; set; }

    public string? Smtppassword { get; set; }

    public string? Email { get; set; }

    public string? Description { get; set; }

    public string? Address { get; set; }

    public long? Phone { get; set; }

    public int? Phone2 { get; set; }

    public long? Faks { get; set; }

    public sbyte? CityId { get; set; }

    public sbyte? DistrictId { get; set; }

    public string? Facebook { get; set; }

    public string? Twitter { get; set; }

    public string? Youtube { get; set; }

    public string? Instagram { get; set; }

    public string? PasswordNew { get; set; }

    public string? PasswordNewConfirm { get; set; }

    public string? Maps { get; set; }

    public string? ContactInfo { get; set; }

    public string? PopupImage { get; set; }

    public string? PopupExtension { get; set; }

    public sbyte? Popup { get; set; }

    public short? Smtpport { get; set; }

    public sbyte? Smtpssl { get; set; }

    public string? LogoWidth { get; set; }

    public string? LogoHeight { get; set; }

    public string? IntroWidth { get; set; }

    public string? IntroHeight { get; set; }

    public string? PopupWidth { get; set; }

    public string? PopupHeight { get; set; }

    public string? PopupUrl { get; set; }

    public string? PopupTarget { get; set; }

    public string? Error { get; set; }

    public sbyte? CountryPhoneCode { get; set; }

    public short? CountryId { get; set; }

    public string? FaviconImage { get; set; }

    public string? FaviconExtension { get; set; }

    public string? FaviconWidth { get; set; }

    public string? FaviconHeight { get; set; }
}
