using System.Collections.Generic;
using System;

namespace CDDirectory.Models
{
  public class CompactDisc
  {
    private string _albumtitle;
    private string _artist;
    private string _year;
    private string _comments;
    private int _id;

    private static List<CompactDisc> _albums = new List<CompactDisc> {};

    public CompactDisc (string albumtitle, string artist, string year)
    {
      _albumtitle = albumtitle;
      _artist = artist;
      _year = year;
      _id = _albums.Count;
      _albums.Add(this);
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
