using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Controllers;

namespace AngularTestApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class Events2Controller : ApiController
    {
        public IEnumerable<Event> Get()
        {
            return WebApiApplication.NgEvents;
        }

        public Event GetEventById(int id)
        {
            return WebApiApplication.NgEvents.FirstOrDefault(x => x.Id == id);
        }

        public Event Post(Event @event)
        {
            @event.Id = @event.GetHashCode();

            WebApiApplication.NgEvents.Add(@event);

            return @event;
        }
    }
}
