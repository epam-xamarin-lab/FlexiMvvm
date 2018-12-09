﻿// =========================================================================
// Copyright 2018 EPAM Systems, Inc.
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
using Android.Graphics.Drawables;
using Android.Widget;
using FlexiMvvm.Bindings.Custom;
using Java.Lang;
using JetBrains.Annotations;

namespace FlexiMvvm.Bindings
{
    public static class SpinnerBindings
    {
        /// <summary>
        /// Binding on <see cref="Spinner.DropDownHorizontalOffset"/> property.
        /// </summary>
        /// <param name="spinnerReference">The item reference.</param>
        /// <returns>Binding on <see cref="Spinner.DropDownHorizontalOffset"/> property.</returns>
        /// <exception cref="ArgumentNullException">spinnerReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<Spinner, int> DropDownHorizontalOffsetBinding(
            [NotNull] this IItemReference<Spinner> spinnerReference)
        {
            if (spinnerReference == null)
                throw new ArgumentNullException(nameof(spinnerReference));

            return new TargetItemOneWayCustomBinding<Spinner, int>(
                spinnerReference,
                (spinner, dropDownHorizontalOffset) => spinner.NotNull().DropDownHorizontalOffset = dropDownHorizontalOffset,
                () => "DropDownHorizontalOffset");
        }

        /// <summary>
        /// Binding on <see cref="Spinner.DropDownVerticalOffset"/> property.
        /// </summary>
        /// <param name="spinnerReference">The item reference.</param>
        /// <returns>Binding on <see cref="Spinner.DropDownVerticalOffset"/> property.</returns>
        /// <exception cref="ArgumentNullException">spinnerReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<Spinner, int> DropDownVerticalOffsetBinding(
            [NotNull] this IItemReference<Spinner> spinnerReference)
        {
            if (spinnerReference == null)
                throw new ArgumentNullException(nameof(spinnerReference));

            return new TargetItemOneWayCustomBinding<Spinner, int>(
                spinnerReference,
                (spinner, dropDownVerticalOffset) => spinner.NotNull().DropDownVerticalOffset = dropDownVerticalOffset,
                () => "DropDownVerticalOffset");
        }

        /// <summary>
        /// Binding on <see cref="Spinner.DropDownWidth"/> property.
        /// </summary>
        /// <param name="spinnerReference">The item reference.</param>
        /// <returns>Binding on <see cref="Spinner.DropDownWidth"/> property.</returns>
        /// <exception cref="ArgumentNullException">spinnerReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<Spinner, int> DropDownWidthBinding(
            [NotNull] this IItemReference<Spinner> spinnerReference)
        {
            if (spinnerReference == null)
                throw new ArgumentNullException(nameof(spinnerReference));

            return new TargetItemOneWayCustomBinding<Spinner, int>(
                spinnerReference,
                (spinner, dropDownWidth) => spinner.NotNull().DropDownWidth = dropDownWidth,
                () => "DropDownWidth");
        }

        /// <summary>
        /// Binding on <see cref="Spinner.Prompt"/> property.
        /// </summary>
        /// <param name="spinnerReference">The item reference.</param>
        /// <returns>Binding on <see cref="Spinner.Prompt"/> property.</returns>
        /// <exception cref="ArgumentNullException">spinnerReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<Spinner, string> PromptBinding(
            [NotNull] this IItemReference<Spinner> spinnerReference)
        {
            if (spinnerReference == null)
                throw new ArgumentNullException(nameof(spinnerReference));

            return new TargetItemOneWayCustomBinding<Spinner, string>(
                spinnerReference,
                (spinner, prompt) => spinner.NotNull().Prompt = prompt,
                () => "Prompt");
        }

        /// <summary>
        /// Binding on <see cref="Spinner.PromptFormatted"/> property.
        /// </summary>
        /// <param name="spinnerReference">The item reference.</param>
        /// <returns>Binding on <see cref="Spinner.PromptFormatted"/> property.</returns>
        /// <exception cref="ArgumentNullException">spinnerReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<Spinner, ICharSequence> PromptFormattedBinding(
            [NotNull] this IItemReference<Spinner> spinnerReference)
        {
            if (spinnerReference == null)
                throw new ArgumentNullException(nameof(spinnerReference));

            return new TargetItemOneWayCustomBinding<Spinner, ICharSequence>(
                spinnerReference,
                (spinner, promptFormatted) => spinner.NotNull().PromptFormatted = promptFormatted,
                () => "PromptFormatted");
        }

        /// <summary>
        /// Binding on <see cref="Spinner.SetPopupBackgroundDrawable(Drawable)"/> method.
        /// </summary>
        /// <param name="spinnerReference">The item reference.</param>
        /// <returns>Binding on <see cref="Spinner.SetPopupBackgroundDrawable(Drawable)"/> method.</returns>
        /// <exception cref="ArgumentNullException">spinnerReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<Spinner, Drawable> SetPopupBackgroundDrawableBinding(
            [NotNull] this IItemReference<Spinner> spinnerReference)
        {
            if (spinnerReference == null)
                throw new ArgumentNullException(nameof(spinnerReference));

            return new TargetItemOneWayCustomBinding<Spinner, Drawable>(
                spinnerReference,
                (spinner, background) => spinner.NotNull().SetPopupBackgroundDrawable(background),
                () => "SetPopupBackgroundDrawable");
        }

        /// <summary>
        /// Binding on <see cref="Spinner.SetPopupBackgroundResource(int)"/> method.
        /// </summary>
        /// <param name="spinnerReference">The item reference.</param>
        /// <returns>Binding on <see cref="Spinner.SetPopupBackgroundResource(int)"/> method.</returns>
        /// <exception cref="ArgumentNullException">spinnerReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<Spinner, int> SetPopupBackgroundResourceBinding(
            [NotNull] this IItemReference<Spinner> spinnerReference)
        {
            if (spinnerReference == null)
                throw new ArgumentNullException(nameof(spinnerReference));

            return new TargetItemOneWayCustomBinding<Spinner, int>(
                spinnerReference,
                (spinner, resId) => spinner.NotNull().SetPopupBackgroundResource(resId),
                () => "SetPopupBackgroundResource");
        }

        /// <summary>
        /// Binding on <see cref="Spinner.SetPromptId(int)"/> method.
        /// </summary>
        /// <param name="spinnerReference">The item reference.</param>
        /// <returns>Binding on <see cref="Spinner.SetPromptId(int)"/> method.</returns>
        /// <exception cref="ArgumentNullException">spinnerReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<Spinner, int> SetPromptIdBinding(
            [NotNull] this IItemReference<Spinner> spinnerReference)
        {
            if (spinnerReference == null)
                throw new ArgumentNullException(nameof(spinnerReference));

            return new TargetItemOneWayCustomBinding<Spinner, int>(
                spinnerReference,
                (spinner, promptId) => spinner.NotNull().SetPromptId(promptId),
                () => "SetPromptId");
        }
    }
}
