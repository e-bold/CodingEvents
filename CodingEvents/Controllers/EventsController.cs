namespace CodingEvents;
using Microsoft.AspNetCore.Mvc;
using CodingEvents.Models;
using CodingEvents.Data;

public class EventsController : Controller
{
    // GET: /<controllers>/
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.events = EventData.GetAll();
        return View();
    }


    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }


    [HttpPost("/Events/Add")]
    public IActionResult NewEvent(Event newEvent)
    {
        EventData.Add(newEvent);

        return Redirect("/Events");
    }
    

    public IActionResult Delete ()
    {
        ViewBag.events =EventData.GetAll();
        return View();
    }

    [HttpPost]
    public IActionResult Delete(int[] eventIds)
    {
        foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }
        return Redirect("/Events");
    }

}
