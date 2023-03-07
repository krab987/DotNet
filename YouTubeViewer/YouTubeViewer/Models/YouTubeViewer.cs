using System;
namespace YouTubeViewer.Models
{
    public class YouTubeViewer
    {

        public string? Username { get;}
        public bool IsSubscribed { get; }
        public bool IsMembered { get; }
        public YouTubeViewer(string? username, bool isSubscribed, bool isMembered)
        {
            Username = username;
            IsSubscribed = isSubscribed;
            IsMembered = isMembered;
        }

    }
}
