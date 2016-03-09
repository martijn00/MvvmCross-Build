// IListLayout.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System.Collections.Generic;

namespace CrossUI.Core.Elements.Lists
{
    public interface IListLayout : IBaseListLayout
    {
        IListItemLayout DefaultLayout { get; }
        Dictionary<string, IListItemLayout> ItemLayouts { get; }
    }
}