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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Android.Views;

namespace FlexiMvvm.ValueConverters
{
    public class VisibleGoneValueConverter : ValueConverter<object, ViewStates>
    {
        protected override ConversionResult<ViewStates> Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case bool boolValue:
                    return ConversionResult<ViewStates>.SetValue(boolValue ? ViewStates.Visible : ViewStates.Gone);
                case int intValue:
                    return ConversionResult<ViewStates>.SetValue(intValue > 0 ? ViewStates.Visible : ViewStates.Gone);
                case float floatValue:
                    return ConversionResult<ViewStates>.SetValue(floatValue > 0 ? ViewStates.Visible : ViewStates.Gone);
                case double doubleValue:
                    return ConversionResult<ViewStates>.SetValue(doubleValue > 0 ? ViewStates.Visible : ViewStates.Gone);
                case string stringValue:
                    return ConversionResult<ViewStates>.SetValue(!string.IsNullOrEmpty(stringValue) ? ViewStates.Visible : ViewStates.Gone);
                case IEnumerable<object> enumerableValue:
                    return ConversionResult<ViewStates>.SetValue(enumerableValue?.Any() ?? false ? ViewStates.Visible : ViewStates.Gone);
                default:
                    return ConversionResult<ViewStates>.SetValue(value != null ? ViewStates.Visible : ViewStates.Gone);
            }
        }

        protected override ConversionResult<object> ConvertBack(ViewStates value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (targetType)
            {
                case Type boolType when boolType == typeof(bool):
                    return ConversionResult<object>.SetValue(value == ViewStates.Visible);
                case Type intType when intType == typeof(int):
                    return ConversionResult<object>.SetValue(value == ViewStates.Visible ? 1 : 0);
                case Type floatType when floatType == typeof(float):
                    return ConversionResult<object>.SetValue(value == ViewStates.Visible ? 1 : 0);
                case Type doubleType when doubleType == typeof(double):
                    return ConversionResult<object>.SetValue(value == ViewStates.Visible ? 1 : 0);
                default:
                    return ConversionResult<object>.UnsetValue();
            }
        }
    }
}
