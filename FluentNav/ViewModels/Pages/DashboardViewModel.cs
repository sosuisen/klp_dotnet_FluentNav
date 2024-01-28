// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using FluentNav.ViewModels.Windows;
using Wpf.Ui.Common;
using Wpf.Ui.Controls;

namespace FluentNav.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _counter = 0;
        
        private readonly ISnackbarService _snackbarService;
        private readonly IContentDialogService _contentDialogService;

        public DashboardViewModel(
            ISnackbarService snackbarService,
            IContentDialogService contentDialogService
        )
        {
            _snackbarService = snackbarService;
            _contentDialogService = contentDialogService;
        }

            [RelayCommand]
        private void OnCounterIncrement()
        {
            Counter++;
            // _snackbarService.Show("Notice", "Counter incremented.");
            // _snackbarService.Show("Notice", "Counter incremented.", ControlAppearance.Danger);

            // _contentDialogService.ShowAlertAsync("Notice", "Counter incremented.", "Close");
        }
    }
}
