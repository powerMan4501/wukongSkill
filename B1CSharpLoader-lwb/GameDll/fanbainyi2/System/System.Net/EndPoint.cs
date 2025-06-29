using System.Net.Sockets;

namespace System.Net;

[Serializable]
[global::__DynamicallyInvokable]
public abstract class EndPoint
{
	[global::__DynamicallyInvokable]
	public virtual AddressFamily AddressFamily
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual SocketAddress Serialize()
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	[global::__DynamicallyInvokable]
	public virtual EndPoint Create(SocketAddress socketAddress)
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	[global::__DynamicallyInvokable]
	protected EndPoint()
	{
	}
}
