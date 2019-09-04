using System;
using System.Collections.Generic;

namespace CCapi {

    public static class Constants {

        public static DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public const string NotFound = "User not found";

        public static Dictionary<char, string> UserFlags
            = new Dictionary<char, string>() {
                { 'a', "Site/Forum Administrator" },
                { 'b', "Banned from Forums" },
                { 'd', "ClassiCube Developer" },
                { 'e', "ClassiCube Blog Editor" },
                { 'm', "Forum Moderator" },
                { 'p', "ClassiCube Patron" }
            };

        public static Dictionary<string, string> Country
            = new Dictionary<string, string>() {
                { "US", "United States" },
                { "UK", "United Kingdom" },
                { "FR", "France" },
                { "DE", "Germany"}
            };
        
    }
}
