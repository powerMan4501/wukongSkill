namespace System.Net;

[Flags]
[global::__DynamicallyInvokable]
public enum AuthenticationSchemes
{
	[global::__DynamicallyInvokable]
	None = 0,
	[global::__DynamicallyInvokable]
	Digest = 1,
	[global::__DynamicallyInvokable]
	Negotiate = 2,
	[global::__DynamicallyInvokable]
	Ntlm = 4,
	[global::__DynamicallyInvokable]
	Basic = 8,
	[global::__DynamicallyInvokable]
	Anonymous = 0x8000,
	[global::__DynamicallyInvokable]
	IntegratedWindowsAuthentication = 6
}
