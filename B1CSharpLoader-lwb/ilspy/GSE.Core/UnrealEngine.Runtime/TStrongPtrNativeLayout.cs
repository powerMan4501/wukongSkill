using System;

namespace UnrealEngine.Runtime;

public struct TStrongPtrNativeLayout
{
	public IntPtr ReferenceCollector;

	public unsafe IntPtr GetObject()
	{
		return ((FGSInternalReferenceCollector*)(void*)ReferenceCollector)->Object;
	}
}
