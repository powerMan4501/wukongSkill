namespace System.Net;

[global::__DynamicallyInvokable]
public interface ICredentials
{
	[global::__DynamicallyInvokable]
	NetworkCredential GetCredential(Uri uri, string authType);
}
