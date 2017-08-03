using System.Collections.Generic;

namespace CDDirectory.Models
{
  public class CompactDisc
  {
    private string _artist;
    private string _albumtitle;
    private string _year;
    private string _id;
    private static List<CompactDisc> _albums = new List<string> {};

    public Task (string description)
    {
      _description = description;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public static List<string> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(_description);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
