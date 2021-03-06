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
using Android.Content;
using Android.OS;
using FlexiMvvm.ViewModels;

namespace FlexiMvvm.Views
{
    /// <summary>
    /// Provides a set of static methods for the <see cref="Intent"/>.
    /// </summary>
    public static class IntentExtensions
    {
        /// <summary>
        /// Gets the lifecycle-aware view model parameters from the <paramref name="intent"/>.
        /// </summary>
        /// <typeparam name="TParameters">The type of the view model parameters.</typeparam>
        /// <param name="intent">The intent to extract the view model parameters from.</param>
        /// <returns>The view model parameters instance if the <paramref name="intent"/> contains the parameters; otherwise, <see langword="null"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="intent"/> is <see langword="null"/>.</exception>
        public static TParameters? GetParameters<TParameters>(this Intent intent)
            where TParameters : Parameters
        {
            if (intent == null)
                throw new ArgumentNullException(nameof(intent));

            return intent.Extras?.GetParameters<TParameters>();
        }

        /// <summary>
        /// Puts the lifecycle-aware view model parameters to the <paramref name="intent"/>.
        /// </summary>
        /// <typeparam name="TParameters">The type of the view model parameters.</typeparam>
        /// <param name="intent">The intent to put the view model parameters to.</param>
        /// <param name="parameters">The view model parameters. Can be <see langword="null"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="intent"/> is <see langword="null"/>.</exception>
        public static void PutParameters<TParameters>(this Intent intent, TParameters? parameters)
            where TParameters : Parameters
        {
            if (intent == null)
                throw new ArgumentNullException(nameof(intent));

            if (parameters != null)
            {
                var bundle = intent.Extras ?? new Bundle();
                bundle.PutParameters(parameters);
                intent.ReplaceExtras(bundle);
            }
        }

        /// <summary>
        /// Gets the lifecycle-aware view model result from the <paramref name="intent"/>.
        /// </summary>
        /// <typeparam name="TResult">The type of the view model result.</typeparam>
        /// <param name="intent">The intent to extract the view model result from.</param>
        /// <returns>The view model result instance if the <paramref name="intent"/> contains the result; otherwise, <see langword="null"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="intent"/> is <see langword="null"/>.</exception>
        public static TResult? GetResult<TResult>(this Intent intent)
            where TResult : Result
        {
            if (intent == null)
                throw new ArgumentNullException(nameof(intent));

            return intent.Extras?.GetResult<TResult>();
        }

        /// <summary>
        /// Puts the lifecycle-aware view model result to the <paramref name="intent"/>.
        /// </summary>
        /// <typeparam name="TResult">The type of the view model result.</typeparam>
        /// <param name="intent">The intent to put the view model result to.</param>
        /// <param name="result">The view model result. Can be <see langword="null"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="intent"/> is <see langword="null"/>.</exception>
        public static void PutResult<TResult>(this Intent intent, TResult? result)
            where TResult : Result
        {
            if (intent == null)
                throw new ArgumentNullException(nameof(intent));

            if (result != null)
            {
                var bundle = intent.Extras ?? new Bundle();
                bundle.PutResult(result);
                intent.ReplaceExtras(bundle);
            }
        }
    }
}
