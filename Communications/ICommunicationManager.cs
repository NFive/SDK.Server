using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFive.SDK.Server.Communications
{
	public interface ICommunicationManager
	{
		ICommunicationTarget Event(string @event);
	}
}
