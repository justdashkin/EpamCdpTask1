using System;
using System.Collections.Generic;

namespace SolidViolations.LiskovSubstitution
{
    //OnlineGame could not be launched same way as VideoGame
    //and available for any platform
    //It should be a separate abstraction

    public class OnlineGame : VideoGame
    {
        private string _host;

        public OnlineGame(string name, List<string> platforms, string developer, string publisher, List<string> genres,
            int minNumberOfPlayers, int maxNumberOfPlayers, string host)
            : base(name, platforms, developer, publisher, genres,
            minNumberOfPlayers, maxNumberOfPlayers)
        {
            _host = host;
        }

        public string GetHost()
        {
            return _host;
        }

        public void SetHost(string host)
        {
            _host = host;
        }


        public new void SetPlatforms(List<string> platforms)
        {
            base.SetPlatforms(new List<string> { "Any" });
        }

        public new void Play()
        {
            Console.WriteLine($"I am opening online game {GetName()} in a browser to play");
        }


        public override string ToString()
        {
            return $"OnlineGame host {_host} + {base.ToString()}";
        }
    }
}
