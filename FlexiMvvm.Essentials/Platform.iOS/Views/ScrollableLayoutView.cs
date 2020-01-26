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

using CoreGraphics;
using UIKit;

namespace FlexiMvvm.Views
{
    public class ScrollableLayoutView : LayoutViewBase
    {
        private UIScrollView? _scrollView;

        public ScrollableLayoutView()
        {
            Initialize();
        }

        public ScrollableLayoutView(CGRect frame)
            : base(frame)
        {
            Initialize();
        }

        public virtual UIScrollView ScrollView => _scrollView ??= new UIScrollView();

        protected override void SetupLayout()
        {
            LayoutViewSetup.SetupScrollableLayout(this, ScrollView, ContentView, ContentOverlayView);
        }

        protected override void SetupLayoutConstraints()
        {
            AllSubviewsDoNotTranslateAutoresizingMaskIntoConstraints(this);

            LayoutViewSetup.SetupScrollableLayoutConstraints(this, ScrollView, ContentView, ContentOverlayView);
        }
    }

    public class ScrollableLayoutView<TConfig> : LayoutViewBase<TConfig>
    {
        private UIScrollView? _scrollView;

        public ScrollableLayoutView(TConfig config)
            : base(config)
        {
            Initialize();
        }

        public ScrollableLayoutView(TConfig config, CGRect frame)
            : base(config, frame)
        {
            Initialize();
        }

        public virtual UIScrollView ScrollView => _scrollView ??= new UIScrollView();

        protected override void SetupLayout()
        {
            LayoutViewSetup.SetupScrollableLayout(this, ScrollView, ContentView, ContentOverlayView);
        }

        protected override void SetupLayoutConstraints()
        {
            AllSubviewsDoNotTranslateAutoresizingMaskIntoConstraints(this);

            LayoutViewSetup.SetupScrollableLayoutConstraints(this, ScrollView, ContentView, ContentOverlayView);
        }
    }
}
