using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerSample2.Models;

namespace ServerSample2.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class ProcessController : ControllerBase
	{
		[HttpPost]
		public string setData( ProcessModel processModel )
		{
			string name = processModel.name;
			int value = processModel.value;

			return new StateModel( $"recv : {name}, {value}", 200 ).toJson();
		}
	}
}
