namespace System.Net;

[global::__DynamicallyInvokable]
public enum WebExceptionStatus
{
	[global::__DynamicallyInvokable]
	Success,
	NameResolutionFailure,
	[global::__DynamicallyInvokable]
	ConnectFailure,
	ReceiveFailure,
	[global::__DynamicallyInvokable]
	SendFailure,
	PipelineFailure,
	[global::__DynamicallyInvokable]
	RequestCanceled,
	ProtocolError,
	ConnectionClosed,
	TrustFailure,
	SecureChannelFailure,
	ServerProtocolViolation,
	KeepAliveFailure,
	[global::__DynamicallyInvokable]
	Pending,
	Timeout,
	ProxyNameResolutionFailure,
	[global::__DynamicallyInvokable]
	UnknownError,
	[global::__DynamicallyInvokable]
	MessageLengthLimitExceeded,
	CacheEntryNotFound,
	RequestProhibitedByCachePolicy,
	RequestProhibitedByProxy
}
