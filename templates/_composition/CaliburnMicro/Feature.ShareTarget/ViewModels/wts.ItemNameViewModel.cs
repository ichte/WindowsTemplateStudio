﻿using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.DataTransfer.ShareTarget;
using Caliburn.Micro;

namespace Param_ItemNamespace.ViewModels
{
    public class wts.ItemNameViewModel : Screen
    {
        private ShareOperation _shareOperation;

        private SharedDataViewModelBase _sharedData;

        public SharedDataViewModelBase SharedData
        {
            get => _sharedData;
            set => Set(ref _sharedData, value);
        }

        public wts.ItemNameViewModel()
        {
        }

        public async Task LoadAsync(ShareOperation shareOperation)
        {
            // TODO WTS: Configure your Share Target Declaration to allow other data formats.
            // Share Target declarations are defined in Package.appxmanifest.
            // Current declarations allow to share WebLink and image files with the app.
            // ShareTarget can be tested sharing the WebLink from Microsoft Edge or sharing images from Windows Photos.

            // TODO WTS: Customize SharedDataModelBase or derived classes adding properties for data that you need to extract from _shareOperation
            _shareOperation = shareOperation;
            if (shareOperation.Data.Contains(StandardDataFormats.StorageItems))
            {
                SharedData = new SharedDataStorageItemsViewModel();
            }

            if (shareOperation.Data.Contains(StandardDataFormats.WebLink))
            {
                SharedData = new SharedDataWebLinkViewModel();
            }

            await SharedData?.LoadDataAsync(_shareOperation);
        }

        public void Complete()
        {
            // TODO WTS: Implement the actions you want to realize with the shared data before compleate the share operation.
            // For further details check https://docs.microsoft.com/en-us/windows/uwp/app-to-app/receive-data
            _shareOperation.ReportCompleted();
        }
    }
}
