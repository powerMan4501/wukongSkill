using System;

namespace UnrealEngine.Runtime;

public struct FScriptInterface
{
	public IntPtr ObjectPointer;

	public IntPtr InterfacePointer;

	public FScriptInterface(IntPtr objectPointer, IntPtr interfacePointer)
	{
		ObjectPointer = objectPointer;
		InterfacePointer = interfacePointer;
	}
}
