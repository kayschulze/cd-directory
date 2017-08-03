using System.Collections.Generic;
using System;

namespace CDDirectory.Models
{
  public class Artist
  {
    private string _artist;
    private static List<CompactDisc> _albums = new List<CompactDisc> {};
    private int _id;

    private static List<Artist> _artists = new List<Artist> {};

    public Artist (string albumtitle, string artist, string year)
    {
      _artist = artist;
      _id = _artists.Count;
      _artists.Add(this);
    }

    public string GetArtist()
    {
      return _artist;
    }

    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }

    public List<CompactDisc> GetAlbums()
    {
      return _albums;
    }

    public static List<Artist> GetAllArtists()
    {
      return _artists;
    }

    public static void ClearAll()
    {
      _artists.Clear();
    }
  }
}
