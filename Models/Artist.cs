using System.Collections.Generic;
using System;

namespace Artist.Models
{
  public class Artist
  {
    private string _artist;
    private string _album;
    private string _id;
    private static List<CompactDisc> _albums = new List<CompactDisc> {};

    private static List<Artist> _artists = new List<Artist> {};

    public CompactDisc (string albumtitle, string artist, string year)
    {
      _artist = artist;
      _album = album;
      _id = _artists.Count;
      _artists.Add(this);
    }

    public string GetAlbumTitle()
    {
      return _albumtitle;
    }

    public void SetAlbumTitle(string newAlbumTitle)
    {
      _albumtitle = newAlbumTitle;
    }

    public string GetArtist()
    {
      return _artist;
    }

    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }

    public string GetYear()
    {
      return _year;
    }

    public void SetYear(string newYear)
    {
      _year = newYear;
    }

    public string GetComments()
    {
      return _comments;
    }

    public void SetComments(string newComments)
    {
      _comments = newComments;
    }

    public static List<CompactDisc> GetAll()
    {
      return _albums;
    }

    public static void ClearAll()
    {
      _albums.Clear();
    }
  }
}
