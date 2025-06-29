namespace System.Net.Security;

[Flags]
[global::__DynamicallyInvokable]
public enum SslPolicyErrors
{
	[global::__DynamicallyInvokable]
	None = 0,
	[global::__DynamicallyInvokable]
	RemoteCertificateNotAvailable = 1,
	[global::__DynamicallyInvokable]
	RemoteCertificateNameMismatch = 2,
	[global::__DynamicallyInvokable]
	RemoteCertificateChainErrors = 4
}
