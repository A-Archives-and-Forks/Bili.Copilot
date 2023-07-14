﻿// Copyright (c) Bili Copilot. All rights reserved.

using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Bili.Copilot.Libs.Provider;
using Bili.Copilot.Libs.Toolkit;
using Bili.Copilot.Models.App.Args;
using Bili.Copilot.Models.App.Other;
using Bili.Copilot.Models.Constants.App;
using CommunityToolkit.Mvvm.Input;

namespace Bili.Copilot.ViewModels;

/// <summary>
/// 应用视图模型.
/// </summary>
public sealed partial class AppViewModel : ViewModelBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AppViewModel"/> class.
    /// </summary>
    private AppViewModel()
        => NavigateItems = new ObservableCollection<NavigateItem>();

    /// <summary>
    /// 初始化.
    /// </summary>
    /// <returns><see cref="Task"/>.</returns>
    public async Task InitializeAsync()
    {
        IsNavigationMenuShown = false;
        IsSigningIn = true;
        var isSignedIn = await AuthorizeProvider.Instance.TrySignInAsync();
        IsSigningIn = false;
        if (!isSignedIn)
        {
            Navigate(PageType.SignIn);
        }
        else
        {
            LoadNavItems();
            var lastOpenPage = SettingsToolkit.ReadLocalSetting(SettingNames.LastOpenPageType, PageType.Home);
            if (!NavigateItems.Any(p => p.Id == lastOpenPage))
            {
                lastOpenPage = NavigateItems.First().Id;
            }

            Navigate(lastOpenPage);
        }

        Logger.Trace("应用完成初始化");
    }

    /// <summary>
    /// 导航到指定页面.
    /// </summary>
    /// <param name="page">页面.</param>
    /// <param name="parameter">参数.</param>
    public void Navigate(PageType page, object parameter = null)
    {
        if (CurrentPage == page)
        {
            return;
        }

        Logger.Trace($"Navigate {page}");
        NavigateRequest?.Invoke(this, new AppNavigationEventArgs(page, parameter));
        CurrentPage = page;
        if (CurrentNavigateItem?.Id != page)
        {
            CurrentNavigateItem = NavigateItems.FirstOrDefault(p => p.Id == CurrentPage);
        }

        IsNavigationMenuShown = page != PageType.SignIn;
        if (IsNavigationMenuShown && page != PageType.Settings)
        {
            SettingsToolkit.WriteLocalSetting(SettingNames.LastOpenPageType, page);
        }
    }

    /// <summary>
    /// 显示提示.
    /// </summary>
    /// <param name="message">提示内容.</param>
    /// <param name="type">提示类型.</param>
    public void ShowTip(string message, InfoType type = InfoType.Information)
        => RequestShowTip?.Invoke(this, new AppTipNotificationEventArgs(message, type));

    /// <summary>
    /// 显示消息.
    /// </summary>
    /// <param name="message">消息内容.</param>
    public void ShowMessage(string message)
        => RequestShowMessage?.Invoke(this, message);

    [RelayCommand]
    private void Back()
    {
        if (!IsBackButtonShown)
        {
            return;
        }

        BackRequest?.Invoke(this, EventArgs.Empty);
    }

    private void LoadNavItems()
    {
        TryClear(NavigateItems);
        NavigateItems.Add(new NavigateItem(PageType.Home, ResourceToolkit.GetLocalizedString(StringNames.Home), FluentSymbol.Home));
        NavigateItems.Add(new NavigateItem(PageType.Partition, ResourceToolkit.GetLocalizedString(StringNames.Partition), FluentSymbol.Apps));
        NavigateItems.Add(new NavigateItem(PageType.Dynamic, ResourceToolkit.GetLocalizedString(StringNames.DynamicFeed), FluentSymbol.DesignIdeas));
        NavigateItems.Add(new NavigateItem(PageType.Hot, ResourceToolkit.GetLocalizedString(StringNames.Popular), FluentSymbol.Fire));
        NavigateItems.Add(new NavigateItem(PageType.Live, ResourceToolkit.GetLocalizedString(StringNames.Live), FluentSymbol.Video));
        NavigateItems.Add(new NavigateItem(PageType.Anime, ResourceToolkit.GetLocalizedString(StringNames.Anime), FluentSymbol.Dust));
        NavigateItems.Add(new NavigateItem(PageType.Film, ResourceToolkit.GetLocalizedString(StringNames.Film), FluentSymbol.FilmstripPlay));
    }

    partial void OnCurrentNavigateItemChanged(NavigateItem value)
    {
        if (value != null)
        {
            Navigate(value.Id);
        }
    }
}
