using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerSample2.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ServerSample2.Controllers
{
	[Route( "pi/[controller]" )]
	[ApiController]
	public class StateController : ControllerBase
	{
		[HttpGet( "{id}" ) ]
		public string getState( int id )
		{
			StateModel s = new StateModel();
			s.msg = "OK";
			s.statusCode = 200;

			return JsonSerializer.Serialize( s );
		}
	}
}
