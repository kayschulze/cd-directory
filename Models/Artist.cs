using System.Collections.Generic;
using System;

namespace CDDirectory.Models
{
  public class Artist
  {
    private string _artistname;
    private static List<CompactDisc> _albums = new List<CompactDisc> {};
    private int _artistid;

    private static List<Artist> _artists = new List<Artist> {};

    public Artist (string artistname)
    {
      _artistname = artistname;
      _artistid = _artists.Count;
      _artists.Add(this);
    }

    public string GetArtist()
    {
      return _artistname;
    }

    public void SetArtist(string newArtist)
    {
      _artistname = newArtist;
    }

    public int GetArtistID()
    {
      return _artistid;
    }

    public List<CompactDisc> GetCDs()
    {
      return _albums;
    }

    public List<CompactDisc> GetAlbums()
    {
      return _albums;
    }

    public static List<Artist> GetAllArtists()
    {
      return _artists;
    }

    public static Artist FindArtistID(int searchID)
    {
      return _artists[searchID];
    }
    public static void ClearAll()
    {
      _artists.Clear();
    }
  }
}
