using Microsoft.AspNetCore.Mvc;
using CDDirectory.Models;
using System.Collections.Generic;
using System;

namespace CDDirectory.Contollers
{
  public class HomeController : Controller
  {

    // Homepage welcomes visitor and allows visitor to add a CD or an Artist.  Gives a link to viewing all CDs, adding a CD, or adding an artist.
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    // Lists all CDs.
    [HttpGet("/cds")]
    public ActionResult AllCDs()
    {
      List<CompactDisc> allDiscs = CompactDisc.GetAll();
      return View(allDiscs);
    }

    // Lists all CDs.
    [HttpPost("/cds")]
    public ActionResult AddCD()
    {
      string albumtitle = Request.Form["albumtitle"];
      string artist = Request.Form["artist"];
      string year = Request.Form["year"];
      // string comments = Request.Form["comments"];

      CompactDisc newDisc = new CompactDisc(albumtitle, artist, year);

      List<CompactDisc> allDiscs = CompactDisc.GetAll();
      return View("AllCDs", allDiscs);
    }

    [HttpGet("/artists/add")]
    public ActionResult AddArtist()
    {
      return View();
    }

    [HttpGet("/artists")]
    public ActionResult AllArtists()
    {
      List<Artist> allArtists = Artist.GetAllArtists();
      return View(allArtists);
    }

    // Lists all Artists with links to that artist's albums.
    [HttpPost("/artists")]
    public ActionResult IncludeArtist()
    {
      string artistname = Request.Form["artistname"];
      Artist newArtist = new Artist(artistname);

      List<Artist> allArtists = Artist.GetAllArtists();

      return View("AllArtists", allArtists);
    }

    // Displays a particular album based on its album id.
    [HttpGet("/artists/{artistid}")]
    public ActionResult ArtistDetail(int artistid)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist selectedArtist = Artist.FindArtistID(artistid);
      List<CompactDisc> artistCDs = selectedArtist.GetCDs();
      model.Add("artist", selectedArtist);
      model.Add("cds", artistCDs);

      return View(model);
    }

    // Displays individual artist with a listing of the associated albums
    [HttpGet("/cds/{id}")]
    public ActionResult CDDetail(int id)
    {
      CompactDisc disc = CompactDisc.Find(id);
      return View(disc);
    }
  }
}
