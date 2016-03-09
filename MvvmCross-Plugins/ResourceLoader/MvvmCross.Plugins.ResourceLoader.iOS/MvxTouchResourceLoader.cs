﻿// MvxIosResourceLoader.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using System.IO;
using MvvmCross.Platform;
using MvvmCross.Platform.Exceptions;
using MvvmCross.Plugins.File;
using MvvmCross.Plugins.File.iOS;

namespace MvvmCross.Plugins.ResourceLoader.iOS
{
    public class MvxIosResourceLoader
        : MvxResourceLoader

    {
        public override void GetResourceStream(string resourcePath, Action<Stream> streamAction)
        {
            resourcePath = MvxIosFileStore.ResScheme + resourcePath;
            var fileService = Mvx.Resolve<IMvxFileStore>();
            if (!fileService.TryReadBinaryFile(resourcePath, (stream) =>
                {
                    streamAction?.Invoke(stream);
                    return true;
                }))
                throw new MvxException("Failed to read file {0}", resourcePath);
        }
    }
}