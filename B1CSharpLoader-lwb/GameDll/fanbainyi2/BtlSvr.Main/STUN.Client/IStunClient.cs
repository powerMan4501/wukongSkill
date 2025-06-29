using System;

namespace STUN.Client;

public interface IStunClient : IDisposable
{
	void ConnectProxyAsync();

	void CloseProxyAsync();

	void QueryAsync();
}
