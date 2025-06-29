using System;

namespace UnrealEngine.Runtime.Native;

public static class Native_UGameViewportClientDelegates
{
	public delegate void Del_Reg_OnViewportCreated(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnViewportCreated;
}
