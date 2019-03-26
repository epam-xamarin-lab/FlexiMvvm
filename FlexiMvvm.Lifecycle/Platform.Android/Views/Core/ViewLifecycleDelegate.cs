﻿// =========================================================================
// Copyright 2019 EPAM Systems, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// =========================================================================

using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using FlexiMvvm.Formatters;
using FlexiMvvm.Persistence.Core;
using FlexiMvvm.ViewModels;
using FlexiMvvm.ViewModels.Core;
using JetBrains.Annotations;

namespace FlexiMvvm.Views.Core
{
    public class ViewLifecycleDelegate<TView> : IViewLifecycleDelegate
        where TView : class, IAndroidView
    {
        public ViewLifecycleDelegate([NotNull] TView view)
        {
            View = view ?? throw new ArgumentNullException(nameof(view));
        }

        [NotNull]
        protected TView View { get; }

        public virtual void OnCreate(Bundle savedInstanceState)
        {
        }

        public virtual void OnStart()
        {
        }

        public virtual void OnActivityResult(int requestCode, Android.App.Result resultCode, Intent data)
        {
        }

        public virtual void OnSaveInstanceState(Bundle outState)
        {
        }

        public virtual void OnDestroyView()
        {
        }

        public virtual void OnDestroy()
        {
        }
    }

    public class ViewLifecycleDelegate<TView, TViewModel> : ViewLifecycleDelegate<TView>
        where TView : class, IAndroidView, INavigationView<TViewModel>, ILifecycleViewModelOwner<TViewModel>
        where TViewModel : class, ILifecycleViewModel, IStateOwner
    {
        private const string ViewModelKeyKey = "FlexiMvvm_ViewModel_Key";
        private const string ViewModelStateKey = "FlexiMvvm_ViewModel_State";
        private const string ViewRequestCodeStateKey = "FlexiMvvm_View_RequestCode_State";

        [CanBeNull]
        private string _viewModelKey;
        private bool _isViewModelCreated;
        [NotNull]
        private Task _viewModelAsyncInitialization = Task.CompletedTask;

        public ViewLifecycleDelegate([NotNull] TView view)
            : base(view)
        {
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _viewModelKey = savedInstanceState?.GetString(ViewModelKeyKey) ?? Guid.NewGuid().ToString();
            var viewModelState = savedInstanceState?.GetState(ViewModelStateKey);
            var viewRequestCodeState = savedInstanceState?.GetState(ViewRequestCodeStateKey);

            var viewModelStore = LifecycleViewModelStoreProvider.Get(View);
            var viewModelFactory = LifecycleViewModelProvider.GetFactory();
            var viewModel = LifecycleViewModelProvider.Get<TViewModel>(viewModelStore!, _viewModelKey, viewModelFactory, viewModelState, out _isViewModelCreated);

            View.SetViewModel(viewModel);
            View.RequestCode.ImportState(viewRequestCodeState);
            ViewCache.Add(View);
        }

        public override void OnStart()
        {
            base.OnStart();

            if (_isViewModelCreated)
            {
                _viewModelAsyncInitialization = View.InitializeViewModelAsync();
                _isViewModelCreated = false;
            }
        }

        public override async void OnActivityResult(int requestCode, Android.App.Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (View.ViewModel is ILifecycleViewModelWithResultHandler viewModelWithResultHandler)
            {
                var resultMapper = View.RequestCode.GetResultMapper(requestCode);

                if (resultMapper != null)
                {
                    await _viewModelAsyncInitialization;
                    viewModelWithResultHandler.HandleResult(resultCode, resultMapper.Map(data));
                }
                else
                {
                    throw new InvalidOperationException($"\"{TypeFormatter.FormatName(View.GetType())}\" view can't handle activity result for \"{requestCode}\" request code. " +
                        $"Check that the request code is generated by \"{TypeFormatter.FormatName<RequestCode>()}.{nameof(RequestCode.GetFor)}\" " +
                        $"method and you call \"{nameof(Activity.StartActivityForResult)}\" method for appropriate activity/fragment.");
                }
            }
        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);

            outState.PutString(ViewModelKeyKey, _viewModelKey);
            outState.PutState(ViewModelStateKey, View.ViewModel.ExportState());
            outState.PutState(ViewRequestCodeStateKey, View.RequestCode.ExportState());
        }

        public override void OnDestroy()
        {
            base.OnDestroy();

            var store = LifecycleViewModelStoreProvider.Get(View);
            store?.Remove(_viewModelKey.NotNull());
            ViewCache.Remove(View);
        }
    }
}
