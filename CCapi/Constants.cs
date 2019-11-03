using System;
using System.Collections.Generic;

namespace CCapi {

    public static class Constants {

        public static DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public const string NotFound = "User not found";

        public static Dictionary<char, string> UserFlags
            = new Dictionary<char, string>() {
                { 'a', "Administrator" },
                { 'b', "Banned" },
                { 'd', "Developer" },
                { 'e', "Editor" },
                { 'm', "Moderator" },
                { 'p', "Patron" },
                { 'r', "Recovering Account" },
                { 'u', "Unverified" }
            };

        public static Dictionary<string, string> Country
            = new Dictionary<string, string>() {
                { "AU", "Australia" },
                { "CA", "Canada" },
                { "ES", "Spain" },
                { "DE", "Germany"},
                { "FR", "France" },
                { "GB", "United Kingdom/Great Britain" },
                { "NZ", "New Zealand" },
                { "PT", "Portugal" },
                { "US", "United States" }           
            };
        
    }
}
