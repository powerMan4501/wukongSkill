namespace System;

[Flags]
[global::__DynamicallyInvokable]
public enum UriComponents
{
	[global::__DynamicallyInvokable]
	Scheme = 1,
	[global::__DynamicallyInvokable]
	UserInfo = 2,
	[global::__DynamicallyInvokable]
	Host = 4,
	[global::__DynamicallyInvokable]
	Port = 8,
	[global::__DynamicallyInvokable]
	Path = 0x10,
	[global::__DynamicallyInvokable]
	Query = 0x20,
	[global::__DynamicallyInvokable]
	Fragment = 0x40,
	[global::__DynamicallyInvokable]
	StrongPort = 0x80,
	[global::__DynamicallyInvokable]
	NormalizedHost = 0x100,
	[global::__DynamicallyInvokable]
	KeepDelimiter = 0x40000000,
	[global::__DynamicallyInvokable]
	SerializationInfoString = int.MinValue,
	[global::__DynamicallyInvokable]
	AbsoluteUri = 0x7F,
	[global::__DynamicallyInvokable]
	HostAndPort = 0x84,
	[global::__DynamicallyInvokable]
	StrongAuthority = 0x86,
	[global::__DynamicallyInvokable]
	SchemeAndServer = 0xD,
	[global::__DynamicallyInvokable]
	HttpRequestUrl = 0x3D,
	[global::__DynamicallyInvokable]
	PathAndQuery = 0x30
}
