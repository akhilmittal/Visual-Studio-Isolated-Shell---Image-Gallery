// Guids.cs
// MUST match guids.h
using System;

namespace Magic.VSPackage1
{
    static class GuidList
    {
        public const string guidVSPackage1PkgString = "4b732ad0-6fc0-4838-98c9-94910ccead45";
        public const string guidVSPackage1CmdSetString = "305008b8-0600-454d-a999-688b376236ad";
        public const string guidToolWindowPersistanceString = "59bb6ab1-a6c9-4c7b-8a98-3f9bc73b11f5";

        public static readonly Guid guidVSPackage1CmdSet = new Guid(guidVSPackage1CmdSetString);
    };
}