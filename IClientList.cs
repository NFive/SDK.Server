using System.Collections;
using System.Collections.Generic;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server
{
	public interface IClientList : IEnumerable<IClient>, IEnumerable
	{
	}
}
