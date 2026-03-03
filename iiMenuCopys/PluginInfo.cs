/*
 *  HEY SKIDDERS
 *  you can take the code ig
*/

using System;
using System.Collections.Generic;
using System.IO;

namespace iiMenu
{
    internal class PluginInfo
    {
        public const string GUID = "org.nova.gorillatag.iimenucopys";
        public static string Name = "ii's Stupid Menu";
        public const string Description = "Created by @goldentrophy with love <3 x Nova for porting";
        public const string BuildTimestamp = "2026-03-03T03:13:54Z";
        public const string Version = "2.7.4";

        public const string BaseDirectory = "iisStupidMenu";

        public const string ServerEndpoint = "https://iimenucopysserverdata.vercel.app";
        public static readonly string ServerDataEndpoint = $"{ServerEndpoint}/serverdata";

#if DEBUG
        public static bool BetaBuild = true;
#else
        public static bool BetaBuild = false;
#endif

        // https://pastebin.com/raw/yApU6qHZ - version link
    }


    [Serializable]
    public class ServerData : Il2CppSystem.Object
    {
        public string menu_version;
        public string min_version;
        public string min_console_version;
        public string discord_invite;
        public string motd;
        public Admin[] admins;
        public string[] super_admins;
        public string[] patreon;
        public string[] detected_mods;
        public string poll;
        public string option_a;
        public string option_b;
        public bool locked;
    }

    [Serializable]
    public class Admin
    {
        public string name;
        public string user_id;
    }
}