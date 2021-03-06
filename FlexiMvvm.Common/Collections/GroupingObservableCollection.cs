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

using System.Collections.Generic;
using System.Linq;

namespace FlexiMvvm.Collections
{
    public class GroupingObservableCollection<TKey, TItem> : ObservableCollection<TItem>, IGrouping<TKey, TItem>
    {
        public GroupingObservableCollection(TKey key)
        {
            Key = key;
        }

        public GroupingObservableCollection(TKey key, IEnumerable<TItem> items)
            : base(items)
        {
            Key = key;
        }

        public GroupingObservableCollection(TKey key, params TItem[] items)
            : base(items)
        {
            Key = key;
        }

        public TKey Key { get; }
    }

    public class GroupingObservableCollection : GroupingObservableCollection<object, object>
    {
        public GroupingObservableCollection(object key)
            : base(key)
        {
        }

        public GroupingObservableCollection(object key, IEnumerable<object> items)
            : base(key, items)
        {
        }

        public GroupingObservableCollection(object key, params object[] items)
            : base(key, items)
        {
        }
    }
}
