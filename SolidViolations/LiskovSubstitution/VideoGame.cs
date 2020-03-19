using System;
using System.Collections.Generic;

namespace SolidViolations.LiskovSubstitution
{
    public class VideoGame
    {
        private string _name;
        private List<string> _platforms;
        private string _developer;
        private string _publisher;
        private List<string> _genres;
        private int _minNumberOfPlayers;
        private int _maxNumberOfPlayers;

        public VideoGame() { }

        public VideoGame(string name, List<string> platforms, string developer, string publisher,
            List<string> genres, int minNumberOfPlayers, int maxNumberOfPlayers)
        {
            _name = name;
            _platforms = platforms;
            _developer = developer;
            _publisher = publisher;
            _genres = genres;
            _minNumberOfPlayers = minNumberOfPlayers;
            _maxNumberOfPlayers = maxNumberOfPlayers;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public List<string> GetPlatforms()
        {
            return _platforms;
        }

        public void SetPlatforms(List<string> platforms)
        {
            _platforms = platforms;
        }

        public string GetDeveloper()
        {
            return _developer;
        }

        public void SetDeveloper(string developer)
        {
            _developer = developer;
        }

        public string GetPublisher()
        {
            return _publisher;
        }

        public void SetPublisher(string publisher)
        {
            _publisher = publisher;
        }

        public List<string> GetGenres()
        {
            return _genres;
        }

        public void SetGenres(List<string> genres)
        {
            _genres = genres;
        }

        public int GetMinNumberOfPlayers()
        {
            return _minNumberOfPlayers;
        }

        public void SetMinNumberOfPlayers(int minNumberOfPlayers)
        {
            _minNumberOfPlayers = minNumberOfPlayers;
        }

        public int GetMaxNumberOfPlayers()
        {
            return _maxNumberOfPlayers;
        }

        public void SetMaxNumberOfPlayers(int maxNumberOfPlayers)
        {
            _maxNumberOfPlayers = maxNumberOfPlayers;
        }

        public void Play()
        {
            Console.WriteLine($"I am launching '{_name}' game to play");
        }

        public override string ToString()
        {
            return $"VideoGame name = {_name}" + "'\'" +
                   $", platforms = {_platforms}" + "'\'" +
                   $", developer = {_developer}" + "'\'" +
                   $", publisher = {_publisher}" + "'\'" +
                   $", genres = {_genres}" + "'\'" +
                   $", minNumberOfPlayers = {_minNumberOfPlayers}" + "'\'" +
                   $", maxNumberOfPlayers = {_maxNumberOfPlayers}";
        }
    }
}
