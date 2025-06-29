using System;

namespace UnrealEngine.Runtime;

public struct FOutParmRec
{
	public IntPtr Property;

	public IntPtr PropAddr;

	public IntPtr NextOutParm;

	public unsafe FOutParmRec* NextOutParamPtr => (FOutParmRec*)(void*)NextOutParm;
}
