namespace CodingEvents;
using Microsoft.AspNetCore.Mvc;
using CodingEvents.Models;

public class EventsController : Controller
{
    private static List<Event> Events = new List<Event>();

    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.events = Events;
        return View();
    }


    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost("/Events/Add")]
    public IActionResult NewEvent(string name, string desc)
    {
        Events.Add(new Event(name, desc));

        return Redirect("/Events");
    }

}
