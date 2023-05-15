using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Guide_Version_Control
{
    public class Profile
    {
        public string Name { get; set; }
        public List<string> FavoriteFilms    { get; set; }
        public List<string> FavoriteTVShows { get; set; }

        public Profile(string name)
        {
            Name = name;
            FavoriteFilms = new List<string>();
            FavoriteTVShows = new List<string>();
        }

        public bool AddFavoriteFilm(string film)
        {
            if (FavoriteFilms.Count < 3)
            {
                FavoriteFilms.Add(film);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveFavoriteFilm(string film)
        {
            return FavoriteFilms.Remove(film);
        }

        public bool AddFavoriteTVShow(string tvShow)
        {
            if (FavoriteTVShows.Count < 3)
            {
                FavoriteTVShows.Add(tvShow);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveFavoriteTVShow(string tvShow)
        {
            return FavoriteTVShows.Remove(tvShow);
        }
    }
}

