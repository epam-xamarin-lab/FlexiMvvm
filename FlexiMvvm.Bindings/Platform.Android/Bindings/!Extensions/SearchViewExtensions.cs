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
using Android.Views;
using Android.Widget;
using FlexiMvvm.Bindings.Custom;

namespace FlexiMvvm.Bindings
{
    public static class SearchViewExtensions
    {
        public static TargetItemBinding<SearchView, object> CloseBinding(
            this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, object, SearchView.CloseEventArgs>(
                searchViewReference,
                (searchView, handler) => searchView.Close += handler,
                (searchView, handler) => searchView.Close -= handler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.Enabled = canExecuteCommand;
                    }
                },
                (searchView, args) => null,
                () => $"{nameof(SearchView.Close)}");
        }

        public static TargetItemBinding<SearchView, string> QueryTextChangeBinding(
            this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, string, SearchView.QueryTextChangeEventArgs>(
                searchViewReference,
                (searchView, handler) => searchView.QueryTextChange += handler,
                (searchView, handler) => searchView.QueryTextChange -= handler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.Enabled = canExecuteCommand;
                    }
                },
                (searchView, args) => args.NewText,
                () => $"{nameof(SearchView.QueryTextChange)}");
        }

        public static TargetItemBinding<SearchView, object> QueryTextFocusChangeBinding(
            this IItemReference<SearchView> searchViewReference,
            FocusDirection focusDirection = FocusDirection.InOut,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, object, View.FocusChangeEventArgs>(
                searchViewReference,
                (searchView, handler) => searchView.QueryTextFocusChange += handler,
                (searchView, handler) => searchView.QueryTextFocusChange -= handler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.Enabled = canExecuteCommand;
                    }
                },
                (searchView, args) => null,
                (searchView, args) =>
                {
                    switch (focusDirection)
                    {
                        case FocusDirection.InOut:
                            return true;
                        case FocusDirection.In:
                            return args.HasFocus;
                        case FocusDirection.Out:
                            return !args.HasFocus;
                        default:
                            return false;
                    }
                },
                () => $"{nameof(SearchView.QueryTextFocusChange)}");
        }

        public static TargetItemBinding<SearchView, string> QueryTextSubmitBinding(
            this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, string, SearchView.QueryTextSubmitEventArgs>(
                searchViewReference,
                (searchView, handler) => searchView.QueryTextSubmit += handler,
                (searchView, handler) => searchView.QueryTextSubmit -= handler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.Enabled = canExecuteCommand;
                    }
                },
                (searchView, args) => args.Query,
                () => $"{nameof(SearchView.QueryTextSubmit)}");
        }

        public static TargetItemBinding<SearchView, object> SearchClickBinding(
            this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, object>(
                searchViewReference,
                (searchView, handler) => searchView.SearchClick += handler,
                (searchView, handler) => searchView.SearchClick -= handler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.Enabled = canExecuteCommand;
                    }
                },
                searchView => null,
                () => $"{nameof(SearchView.SearchClick)}");
        }

        public static TargetItemBinding<SearchView, string> SetQueryAndQueryTextChangeBinding(
            this IItemReference<SearchView> searchViewReference,
            bool submit = true,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemTwoWayCustomBinding<SearchView, string, SearchView.QueryTextChangeEventArgs>(
                searchViewReference,
                (searchView, handler) => searchView.QueryTextChange += handler,
                (searchView, handler) => searchView.QueryTextChange -= handler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.Enabled = canExecuteCommand;
                    }
                },
                (searchView, args) => args != null ? args.NewText : searchView.Query,
                (searchView, query) => searchView.SetQuery(query, submit),
                () => $"{nameof(SearchView.SetQuery)}And{nameof(SearchView.QueryTextChange)}");
        }

        public static TargetItemBinding<SearchView, string> SetQueryBinding(
            this IItemReference<SearchView> searchViewReference,
            bool submit = true)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayCustomBinding<SearchView, string>(
                searchViewReference,
                (searchView, query) => searchView.SetQuery(query, submit),
                () => $"{nameof(SearchView.SetQuery)}");
        }

        public static TargetItemBinding<SearchView, string> SetQueryHintBinding(
            this IItemReference<SearchView> searchViewReference)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayCustomBinding<SearchView, string>(
                searchViewReference,
                (searchView, hint) => searchView.SetQueryHint(hint),
                () => $"{nameof(SearchView.SetQueryHint)}");
        }

        public static TargetItemBinding<SearchView, bool> SubmitButtonEnabledBinding(
            this IItemReference<SearchView> searchViewReference)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayCustomBinding<SearchView, bool>(
                searchViewReference,
                (searchView, submitButtonEnabled) => searchView.SubmitButtonEnabled = submitButtonEnabled,
                () => $"{nameof(SearchView.SubmitButtonEnabled)}");
        }

        public static TargetItemBinding<SearchView, int> SuggestionClickBinding(
            this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, int, SearchView.SuggestionClickEventArgs>(
                searchViewReference,
                (searchView, handler) => searchView.SuggestionClick += handler,
                (searchView, handler) => searchView.SuggestionClick -= handler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.Enabled = canExecuteCommand;
                    }
                },
                (searchView, args) => args.Position,
                () => $"{nameof(SearchView.SuggestionClick)}");
        }

        public static TargetItemBinding<SearchView, int> SuggestionSelectBinding(
            this IItemReference<SearchView> searchViewReference,
            bool trackCanExecuteCommandChanged = false)
        {
            if (searchViewReference == null)
                throw new ArgumentNullException(nameof(searchViewReference));

            return new TargetItemOneWayToSourceCustomBinding<SearchView, int, SearchView.SuggestionSelectEventArgs>(
                searchViewReference,
                (searchView, handler) => searchView.SuggestionSelect += handler,
                (searchView, handler) => searchView.SuggestionSelect -= handler,
                (searchView, canExecuteCommand) =>
                {
                    if (trackCanExecuteCommandChanged)
                    {
                        searchView.Enabled = canExecuteCommand;
                    }
                },
                (searchView, args) => args.Position,
                () => $"{nameof(SearchView.SuggestionSelect)}");
        }
    }
}
