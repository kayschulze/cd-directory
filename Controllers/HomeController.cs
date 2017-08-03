using Microsoft.AspNetCore.Mvc;
using CDDirectory.Models;
using System.Collections.Generic;
using System;

namespace CDDirectory.Contollers
{
  public class HomeController : Controller
  {

    // Homepage welcomes visitor and gives a link to viewing all CDs, adding a CD, or adding an artist.
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    // Lists all CDs.
    [HttpGet("/cds")]
    public ActionResult AllCDs()
    {
      return View();
    }

    // Lists all Artists with links to that artist's albums.
    [HttpGet("/artists")]
    public ActionResult AllArtists()
    {
      return View();
    }

    // Allows user to add a new CD.
    [HttpPost("/cd/add")]
    public ActionResult AddCD()
    {
      CompactDisk newDisk = new CompactDisk (Request.Form["new-disk"]);
      return View(newDisk);
    }

    // Allows user to add a new artist.
    [HttpPost("/artist/add")]
    public ActionResult AddArtist()
    {
      Artist newArtist = new Artist (Request.Form["new-artist"]);
      return View(newArtist);
    }
  }
}
