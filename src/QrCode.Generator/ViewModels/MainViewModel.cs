﻿using BB84.Notifications;
using BB84.Notifications.Interfaces;

using WIFI.QRCode.Builder.Interfaces.Services;

namespace WIFI.QRCode.Builder.ViewModels;

/// <summary>
/// The main view model class.
/// </summary>
/// <remarks>
/// Initializes an instance of <see cref="MainViewModel"/> class.
/// </remarks>
/// <param name="navigationService">The navigation service instance to use.</param>
public sealed class MainViewModel(INavigationService navigationService) : NotificationObject
{
  private IRelayCommand? _aboutCommand;
  private IRelayCommand? _exitCommand;
  private IRelayCommand? _eventCommand;
  private IRelayCommand? _wifiCommand;

  /// <summary>
  /// The navigation service instance.
  /// </summary>
  public INavigationService NavigationService
  {
    get => navigationService;
    private set => SetProperty(ref navigationService, value);
  }

  /// <summary>
  /// The command to show the about window.
  /// </summary>
  public IRelayCommand AboutCommand
    => _aboutCommand ??= new RelayCommand(x => Environment.Exit(1));

  /// <summary>
  /// The command to exit the application.
  /// </summary>
  public IRelayCommand ExitCommand
    => _exitCommand ??= new RelayCommand(x => Environment.Exit(0));

  /// <summary>
  /// The command to show the event qr code window.
  /// </summary>
  public IRelayCommand EventCommand
    => _eventCommand ??= new RelayCommand(x => NavigationService.NavigateTo<EventViewModel>());

  /// <summary>
  /// The command to show the event qr code window.
  /// </summary>
  public IRelayCommand WifiCommand
    => _wifiCommand ??= new RelayCommand(x => NavigationService.NavigateTo<WifiViewModel>());
}