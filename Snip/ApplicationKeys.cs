using System;
using System.Text;

namespace Winter
{
    public static class ApplicationKeys
    {
        public static string SpotifyClientId = "7da969f5951d43d884c7cf118c25d1d7";
        public static string clientsecret = "625f590e202f4ee89e2da4a07a339239";
        public static string Spotify = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", SpotifyClientId, clientsecret)));
    }
}