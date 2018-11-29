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
using Android.Widget;
using FlexiMvvm.Bindings.Custom;
using Java.Lang;
using JetBrains.Annotations;

namespace FlexiMvvm.Bindings
{
    public static class ToggleButtonBindings
    {
        [NotNull]
        public static TargetItemBinding<ToggleButton, string> TextOffBinding(
            [NotNull] this IItemReference<ToggleButton> toggleButtonReference)
        {
            if (toggleButtonReference == null)
                throw new ArgumentNullException(nameof(toggleButtonReference));

            return new TargetItemOneWayCustomBinding<ToggleButton, string>(
                toggleButtonReference,
                (toggleButton, textOff) => toggleButton.NotNull().TextOff = textOff,
                () => "TextOff");
        }

        [NotNull]
        public static TargetItemBinding<ToggleButton, ICharSequence> TextOffFormattedBinding(
            [NotNull] this IItemReference<ToggleButton> toggleButtonReference)
        {
            if (toggleButtonReference == null)
                throw new ArgumentNullException(nameof(toggleButtonReference));

            return new TargetItemOneWayCustomBinding<ToggleButton, ICharSequence>(
                toggleButtonReference,
                (toggleButton, textOffFormatted) => toggleButton.NotNull().TextOffFormatted = textOffFormatted,
                () => "TextOffFormatted");
        }

        [NotNull]
        public static TargetItemBinding<ToggleButton, string> TextOnBinding(
            [NotNull] this IItemReference<ToggleButton> toggleButtonReference)
        {
            if (toggleButtonReference == null)
                throw new ArgumentNullException(nameof(toggleButtonReference));

            return new TargetItemOneWayCustomBinding<ToggleButton, string>(
                toggleButtonReference,
                (toggleButton, textOn) => toggleButton.NotNull().TextOn = textOn,
                () => "TextOn");
        }

        [NotNull]
        public static TargetItemBinding<ToggleButton, ICharSequence> TextOnFormattedBinding(
            [NotNull] this IItemReference<ToggleButton> toggleButtonReference)
        {
            if (toggleButtonReference == null)
                throw new ArgumentNullException(nameof(toggleButtonReference));

            return new TargetItemOneWayCustomBinding<ToggleButton, ICharSequence>(
                toggleButtonReference,
                (toggleButton, textOnFormatted) => toggleButton.NotNull().TextOnFormatted = textOnFormatted,
                () => "TextOnFormatted");
        }
    }
}