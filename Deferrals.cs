using CitizenFX.Core;
using System.Dynamic;
using System.Linq;

namespace NFive.SDK.Server
{
	public class Deferrals
	{
		public CallbackDelegate Defer;
		public CallbackDelegate Done;
		public CallbackDelegate Update;
		public CallbackDelegate Drop;

		public Deferrals(ExpandoObject callbacks, CallbackDelegate drop)
		{
			var callbackList = callbacks.Select(c => (CallbackDelegate)c.Value).ToList();
			this.Defer = callbackList[0];
			this.Done = callbackList[1];
			this.Update = callbackList[2];
			this.Drop = drop;
		}
	}
}
