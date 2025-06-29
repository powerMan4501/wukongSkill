using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_TStatId
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_GetStatDescriptionANSI(ref TStatId instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetStatDescriptionWIDE(ref TStatId instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate int Del_CreateStatID(string StatName);

	[MonoNativeFunctionWrapper]
	public delegate int Del_CreateStatIDInSlateGroup(string StatName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_BeginSampleWithStatID(int StatID);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EndSample();

	public static Del_GetStatDescriptionANSI GetStatDescriptionANSI;

	public static Del_GetStatDescriptionWIDE GetStatDescriptionWIDE;

	public static Del_CreateStatID CreateStatID;

	public static Del_CreateStatIDInSlateGroup CreateStatIDInSlateGroup;

	public static Del_BeginSampleWithStatID BeginSampleWithStatID;

	public static Del_EndSample EndSample;
}
