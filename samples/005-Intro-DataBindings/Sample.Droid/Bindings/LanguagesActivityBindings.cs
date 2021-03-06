﻿using System;
using FlexiMvvm.Bindings;
using FlexiMvvm.Bindings.Custom;
using Sample.Droid.Views;

namespace Sample.Droid.Bindings
{
    public static class LanguagesActivityBindings
    {
        public static TargetItemBinding<LanguagesActivity, string> LanguageSelectedBinding(this IItemReference<LanguagesActivity> target)
        {
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            return new TargetItemOneWayToSourceCustomBinding<LanguagesActivity, string, string>(
                target,
                (t, eventHandler) => t.LanguageSelected += eventHandler,
                (t, eventHandler) => t.LanguageSelected -= eventHandler,
                (t, canExecuteCommand) => { },
                (t, @value) => @value,
                () => "LanguageSelected");
        }
    }
}
