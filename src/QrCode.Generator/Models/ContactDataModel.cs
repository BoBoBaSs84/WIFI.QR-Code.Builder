﻿using System.ComponentModel.DataAnnotations;

using BB84.Extensions;

using QrCode.Generator.Models.Base;

using static QRCoder.PayloadGenerator.ContactData;

namespace QrCode.Generator.Models;

/// <summary>
/// The contact data model class.
/// </summary>
public sealed class ContactDataModel : QrCodeModel
{
  private ContactOutputType _outputType;
  private string _firstName;
  private string _lastName;
  private string? _nickName;
  private string? _phone;
  private string? _mobilePhone;
  private string? _workPhone;
  private string? _email;
  private DateTime? _dateOfBirth;
  private string? _webSite;
  private string? _street;
  private string? _houseNumber;
  private string? _city;
  private string? _country;
  private string? _zipCode;
  private string? _note;
  private string? _stateRegion;
  private AddressOrder _addressOrder;
  private string? _org;
  private string? _orgTitle;
  private bool _isValid;
  

  /// <summary>
  /// Initializes an instance of <see cref="ContactDataModel"/> class.
  /// </summary>
  public ContactDataModel()
  {
    _outputType = ContactOutputType.VCard3;
    _firstName = string.Empty;
    _lastName = string.Empty;
    _addressOrder = AddressOrder.Default;

    PropertyChanged += (s, e) => IsValid = HasErrors.IsFalse();
  }

  /// <summary>
  /// The payload output type.
  /// </summary>
  public ContactOutputType OutputType
  {
    get => _outputType;
    set => SetProperty(ref _outputType, value);
  }

  /// <summary>
  /// The first name.
  /// </summary>
  [Required]
  public string FirstName
  {
    get => _firstName;
    set => SetPropertyAndValidate(ref _firstName, value);
  }

  /// <summary>
  /// The last name.
  /// </summary>
  [Required]
  public string LastName
  {
    get => _lastName;
    set => SetPropertyAndValidate(ref _lastName, value);
  }

  /// <summary>
  /// The display name.
  /// </summary>
  public string? NickName
  {
    get => _nickName;
    set => SetProperty(ref _nickName, value);
  }

  /// <summary>
  /// The normal phone number.
  /// </summary>
  [Phone]
  public string? Phone
  {
    get => _phone;
    set => SetPropertyAndValidate(ref _phone, value);
  }

  /// <summary>
  /// The mobile phone number.
  /// </summary>
  [Phone]
  public string? MobilePhone
  {
    get => _mobilePhone;
    set => SetPropertyAndValidate(ref _mobilePhone, value);
  }

  /// <summary>
  /// The office phone number.
  /// </summary>
  [Phone]
  public string? WorkPhone
  {
    get => _workPhone;
    set => SetPropertyAndValidate(ref _workPhone, value);
  }

  /// <summary>
  /// The E-Mail address.
  /// </summary>
  [EmailAddress]
  public string? Email
  {
    get => _email;
    set => SetPropertyAndValidate(ref _email, value);
  }

  /// <summary>
  /// The date of birth.
  /// </summary>
  public DateTime? Birthday
  {
    get => _dateOfBirth;
    set => SetProperty(ref _dateOfBirth, value);
  }

  /// <summary>
  ///	Website / Homepage
  /// </summary>
  public string? WebSite
  {
    get => _webSite;
    set => SetProperty(ref _webSite, value);
  }

  /// <summary>
  /// The street.
  /// </summary>
  public string? Street
  {
    get => _street;
    set => SetProperty(ref _street, value);
  }

  /// <summary>
  /// The house number.
  /// </summary>
  public string? HouseNumber
  {
    get => _houseNumber;
    set => SetProperty(ref _houseNumber, value);
  }

  /// <summary>
  /// The city.
  /// </summary>
  public string? City
  {
    get => _city;
    set => SetProperty(ref _city, value);
  }

  /// <summary>
  /// The counrty.
  /// </summary>
  public string? Country
  {
    get => _country;
    set => SetProperty(ref _country, value);
  }

  /// <summary>
  /// The postal zip code.
  /// </summary>
  public string? ZipCode
  {
    get => _zipCode;
    set => SetProperty(ref _zipCode, value);
  }

  /// <summary>
  ///	Memo text / notes.
  /// </summary>
  public string? Note
  {
    get => _note;
    set => SetProperty(ref _note, value);
  }

  /// <summary>
  /// State / Region.
  /// </summary>
  public string? StateRegion
  {
    get => _stateRegion;
    set => SetProperty(ref _stateRegion, value);
  }

  /// <summary>
  /// Defines the address order.
  /// </summary>
  /// <remarks>
  /// Specifies in which format the address is rendered.
  /// </remarks>
  public AddressOrder AddressOrder
  {
    get => _addressOrder;
    set => SetProperty(ref _addressOrder, value);
  }

  /// <summary>
  /// The organization / company.
  /// </summary>
  public string? Org
  {
    get => _org;
    set => SetProperty(ref _org, value);
  }

  /// <summary>
  /// The organization / company title.
  /// </summary>
  public string? OrgTitle
  {
    get => _orgTitle;
    set => SetProperty(ref _orgTitle, value);
  }

  /// <inheritdoc/>
  public override bool IsValid
  {
    get => _isValid;
    protected set => SetProperty(ref _isValid, value);
  }
}
