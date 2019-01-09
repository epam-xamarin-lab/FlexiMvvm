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
using FlexiMvvm.Bindings.Custom;
using Foundation;
using JetBrains.Annotations;
using UIKit;

namespace FlexiMvvm.Bindings
{
    public static class UILabelBindings
    {
        /// <summary>
        /// One way binding on <see cref="UILabel.AdjustsFontForContentSizeCategory"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.AdjustsFontForContentSizeCategory"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, bool> AdjustsFontForContentSizeCategoryBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, bool>(
                labelReference,
                (label, adjustFontForContentSizeCategory) => label.NotNull().AdjustsFontForContentSizeCategory = adjustFontForContentSizeCategory,
                () => "AdjustsFontForContentSizeCategory");
        }

        /// <summary>
        /// One way binding on <see cref="UILabel.AdjustsFontSizeToFitWidth"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.AdjustsFontSizeToFitWidth"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, bool> AdjustsFontSizeToFitWidthBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, bool>(
                labelReference,
                (label, adjustFontSizeToFitWidth) => label.NotNull().AdjustsFontSizeToFitWidth = adjustFontSizeToFitWidth,
                () => "AdjustsFontSizeToFitWidth");
        }

        /// <summary>
        /// One way binding on <see cref="UILabel.AdjustsLetterSpacingToFitWidth"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.AdjustsLetterSpacingToFitWidth"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, bool> AdjustsLetterSpacingToFitWidthBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, bool>(
                labelReference,
                (label, adjustsLetterSpacingToFitWidth) => label.NotNull().AdjustsLetterSpacingToFitWidth = adjustsLetterSpacingToFitWidth,
                () => "AdjustsLetterSpacingToFitWidth");
        }

        /// <summary>
        /// One way binding on <see cref="UILabel.AllowsDefaultTighteningForTruncation"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.AllowsDefaultTighteningForTruncation"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, bool> AllowsDefaultTighteningForTruncationBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, bool>(
                labelReference,
                (label, allowDefaultTighteningForTruncation) => label.NotNull().AllowsDefaultTighteningForTruncation = allowDefaultTighteningForTruncation,
                () => "AllowsDefaultTighteningForTruncation");
        }

        /// <summary>
        /// One way binding on <see cref="UILabel.AttributedText"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.AttributedText"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, NSAttributedString> AttributedTextBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, NSAttributedString>(
                labelReference,
                (label, attributedText) => label.NotNull().AttributedText = attributedText,
                () => "AttributedText");
        }

        /// <summary>
        /// One way binding on <see cref="UILabel.Enabled"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.Enabled"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, bool> EnabledBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, bool>(
                labelReference,
                (label, enabled) => label.NotNull().Enabled = enabled,
                () => "Enabled");
        }

        /// <summary>
        /// One way binding on <see cref="UILabel.Highlighted"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.Highlighted"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, bool> HighlightedBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, bool>(
                labelReference,
                (label, highlighted) => label.NotNull().Highlighted = highlighted,
                () => "Highlighted");
        }

        /// <summary>
        /// One way binding on <see cref="UILabel.Lines"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.Lines"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, nint> LinesBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, nint>(
                labelReference,
                (label, lines) => label.NotNull().Lines = lines,
                () => "Lines");
        }

        /// <summary>
        /// One way binding on <see cref="UILabel.MinimumFontSize"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.MinimumFontSize"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, nfloat> MinimumFontSizeBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, nfloat>(
                labelReference,
                (label, minimumFontSize) => label.NotNull().MinimumFontSize = minimumFontSize,
                () => "MinimumFontSize");
        }

        /// <summary>
        /// One way binding on <see cref="UILabel.MinimumScaleFactor"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.MinimumScaleFactor"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, nfloat> MinimumScaleFactorBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, nfloat>(
                labelReference,
                (label, minimumScaleFactor) => label.NotNull().MinimumScaleFactor = minimumScaleFactor,
                () => "MinimumScaleFactor");
        }

        /// <summary>
        /// One way binding on <see cref="UILabel.PreferredMaxLayoutWidth"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.PreferredMaxLayoutWidth"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, nfloat> PreferredMaxLayoutWidthBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, nfloat>(
                labelReference,
                (label, preferredMaxLayoutWidth) => label.NotNull().PreferredMaxLayoutWidth = preferredMaxLayoutWidth,
                () => "PreferredMaxLayoutWidth");
        }

        /// <summary>
        /// One way binding on <see cref="UILabel.Text"/> property.
        /// </summary>
        /// <param name="labelReference">The item reference.</param>
        /// <returns>One way binding on <see cref="UILabel.Text"/> property.</returns>
        /// <exception cref="ArgumentNullException">labelReference is null.</exception>
        [NotNull]
        public static TargetItemBinding<UILabel, string> TextBinding(
            [NotNull] this IItemReference<UILabel> labelReference)
        {
            if (labelReference == null)
                throw new ArgumentNullException(nameof(labelReference));

            return new TargetItemOneWayCustomBinding<UILabel, string>(
                labelReference,
                (label, text) => label.NotNull().Text = text,
                () => "Text");
        }
    }
}
