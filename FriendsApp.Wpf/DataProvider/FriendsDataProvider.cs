using FriendsApp.Wpf.Model;
using System.Collections.Generic;

namespace FriendsApp.Wpf.DataProvider
{
    public class FriendsDataProvider
    {
        public IEnumerable<Friend> LoadFriends()
        {
            yield return new Friend
            {
                FirstName = "Satya",
                LastName = "Nadella",
                City = "Redmond",
                Latitude = 47.673988,
                Longitude = -122.121513
            };

            yield return new Friend
            {
                FirstName = "Terence",
                LastName = "Hill",
                City = "Stockbridge",
                Latitude = 33.5442781,
                Longitude = -84.2338093
            };

            yield return new Friend
            {
                FirstName = "Thomas",
                LastName = "Huber",
                City = "Müllheim",
                Latitude = 47.8,
                Longitude = 7.6333
            };
        }
    }
}
