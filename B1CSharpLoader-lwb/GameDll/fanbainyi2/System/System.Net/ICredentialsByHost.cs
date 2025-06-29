namespace System.Net;

[global::__DynamicallyInvokable]
public interface ICredentialsByHost
{
	[global::__DynamicallyInvokable]
	NetworkCredential GetCredential(string host, int port, string authenticationType);
}
