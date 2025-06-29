namespace System.Diagnostics.Tracing;

[Flags]
[__DynamicallyInvokable]
public enum EventKeywords : long
{
	[__DynamicallyInvokable]
	None = 0L,
	[__DynamicallyInvokable]
	All = -1L,
	MicrosoftTelemetry = 0x2000000000000L,
	[__DynamicallyInvokable]
	WdiContext = 0x2000000000000L,
	[__DynamicallyInvokable]
	WdiDiagnostic = 0x4000000000000L,
	[__DynamicallyInvokable]
	Sqm = 0x8000000000000L,
	[__DynamicallyInvokable]
	AuditFailure = 0x10000000000000L,
	[__DynamicallyInvokable]
	AuditSuccess = 0x20000000000000L,
	[__DynamicallyInvokable]
	CorrelationHint = 0x10000000000000L,
	[__DynamicallyInvokable]
	EventLogClassic = 0x80000000000000L
}
