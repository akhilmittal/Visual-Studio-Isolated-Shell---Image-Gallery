// Guids.cs
// MUST match guids.h
using System;

namespace ImageSlideShow.AboutBoxPackage
{
    static class GuidList
    {
        public const string guidAboutBoxPackagePkgString = "651847f5-3a87-48fc-8fce-b806b31114eb";
        public const string guidAboutBoxPackageCmdSetString = "fb0501ff-e47c-44f0-853c-e98c804f8b73";

        public static readonly Guid guidAboutBoxPackageCmdSet = new Guid(guidAboutBoxPackageCmdSetString);
    };
}