// =============================================================================
// Outpost31.Core.Framework.Folders.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250904_code
// u250904_documentation
// =============================================================================

namespace Outpost31.Core.Framework
{
    public class Folders
    {
        public string BaseWww { get; set; }
        public string BaseData { get; set; }
        public string Archive { get; set; }
        public string Blueprint { get; set; }
        public string Configuration { get; set; }
        public string Export { get; set; }
        public string Import { get; set; }
        public string Session { get; set; }


        public static Folders Load(string baseDataFolder, string baseWwwFolder, string avatarUser, string date, string time)
        {
            return new Folders
            {
                BaseWww       = baseWwwFolder,
                BaseData      = baseDataFolder,
                Archive       = $@"{baseDataFolder}\Archive",
                Blueprint     = $@"{baseDataFolder}\AppData\Blueprint",
                Configuration = $@"{baseDataFolder}\Config",
                Export        = $@"{baseDataFolder}\Export",
                Import        = $@"{baseDataFolder}\Import",
                Session       = $@"{baseDataFolder}\Session\{date}\{avatarUser}\{time}"
            };
        }
    }
}