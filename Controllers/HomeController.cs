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

    // Lists all Artists with links to that artist's albums.
    [HttpGet("/artists")]
    public ActionResult AllArtists()
    {
      return View();
    }

    // Allows user to add a new CD.
    [HttpPost("/cds/add")]
    public ActionResult AddCD()
    {
      //CompactDisc newDisc = new CompactDisc (Request.Form["new-disk"]);
      return View();
    }

    // Allows user to add a new artist.
    [HttpPost("/artists/add")]
    public ActionResult AddArtist()
    {
      //Artist newArtist = new Artist (Request.Form["new-artist"]);
      return View();
    }

    // Displays a particular album based on its album id.
    [HttpGet("/artists/{id}")]
    public ActionResult CDDetail()
    {
      return View();
    }

    // Displays individual artist with a listing of the associated albums
    [HttpGet("/cds/CDDetail/{id}")]
    public ActionResult ArtistDetail()
    {
      return View();
    }
  }
}
