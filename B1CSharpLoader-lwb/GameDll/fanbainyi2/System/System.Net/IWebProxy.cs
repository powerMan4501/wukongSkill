namespace System.Net;

[global::__DynamicallyInvokable]
public interface IWebProxy
{
	[global::__DynamicallyInvokable]
	ICredentials Credentials
	{
		[global::__DynamicallyInvokable]
		get;
		[global::__DynamicallyInvokable]
		set;
	}

	[global::__DynamicallyInvokable]
	Uri GetProxy(Uri destination);

	[global::__DynamicallyInvokable]
	bool IsBypassed(Uri host);
}
