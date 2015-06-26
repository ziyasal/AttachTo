// Guids.cs
// MUST match guids.h
using System;

namespace Whut.AttachTo
{
    public static class GuidList
    {
        public const string guidAttachToPkgString = "A7E222F8-5841-484D-9C8D-2A88619F0153";

        public const string guidAttachToCmdSetString = "16e2ac5c-ec3d-4ff1-a237-11ccef54fe0f";

        public static readonly Guid guidAttachToCmdSet = new Guid(guidAttachToCmdSetString);
    }
}