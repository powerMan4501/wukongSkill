namespace System.Security.Authentication;

[Flags]
[global::__DynamicallyInvokable]
public enum SslProtocols
{
	[global::__DynamicallyInvokable]
	None = 0,
	[global::__DynamicallyInvokable]
	Ssl2 = 0xC,
	[global::__DynamicallyInvokable]
	Ssl3 = 0x30,
	[global::__DynamicallyInvokable]
	Tls = 0xC0,
	[global::__DynamicallyInvokable]
	Tls11 = 0x300,
	[global::__DynamicallyInvokable]
	Tls12 = 0xC00,
	Tls13 = 0x3000,
	Default = 0xF0
}
