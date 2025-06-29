namespace System.Runtime.InteropServices;

[Flags]
[__DynamicallyInvokable]
public enum DllImportSearchPath
{
	[__DynamicallyInvokable]
	UseDllDirectoryForDependencies = 0x100,
	[__DynamicallyInvokable]
	ApplicationDirectory = 0x200,
	[__DynamicallyInvokable]
	UserDirectories = 0x400,
	[__DynamicallyInvokable]
	System32 = 0x800,
	[__DynamicallyInvokable]
	SafeDirectories = 0x1000,
	[__DynamicallyInvokable]
	AssemblyDirectory = 2,
	[__DynamicallyInvokable]
	LegacyBehavior = 0
}
