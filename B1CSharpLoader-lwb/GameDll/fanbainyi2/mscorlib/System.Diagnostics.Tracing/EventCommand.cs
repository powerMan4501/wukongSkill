namespace System.Diagnostics.Tracing;

[__DynamicallyInvokable]
public enum EventCommand
{
	[__DynamicallyInvokable]
	Update = 0,
	[__DynamicallyInvokable]
	SendManifest = -1,
	[__DynamicallyInvokable]
	Enable = -2,
	[__DynamicallyInvokable]
	Disable = -3
}
