namespace CodingEvents;
using Microsoft.AspNetCore.Mvc;

public class EventsController : Controller
{
    private static List<string> Events = new List<string>();

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
    public IActionResult NewEvent(string name, string Bravo)
    {
        Events.Add(name);
        Events.Add(Bravo);

        return Redirect("/Events");
    }

}
