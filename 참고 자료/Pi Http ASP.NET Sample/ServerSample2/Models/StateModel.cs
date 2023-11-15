using System.Text.Json;

namespace ServerSample2.Models
{
	public class StateModel
	{
		public string msg { get; set; }
		public int statusCode { get; set; }

		public StateModel() { }	

		public StateModel( string msg, int statusCode )
		{
			this.msg = msg;
			this.statusCode = statusCode;
		}

		public string toJson()
		{
			return JsonSerializer.Serialize( this );
		}
	}
}
