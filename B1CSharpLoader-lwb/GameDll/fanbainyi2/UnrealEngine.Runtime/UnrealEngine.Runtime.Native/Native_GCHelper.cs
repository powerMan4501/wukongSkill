using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_GCHelper
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_Void_Void();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_OnPostGarbageCollect(Del_Void_Void func);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_OnAdd(Del_Add func);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_OnRemove(Del_Remove func);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Add(IntPtr native);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Remove(IntPtr native);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CollectGarbage();

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetInternalIndexOffset();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Clear();

	public static Del_Set_OnPostGarbageCollect Set_OnPostGarbageCollect;

	public static Del_Set_OnAdd Set_OnAdd;

	public static Del_Set_OnRemove Set_OnRemove;

	public static Del_Add Add;

	public static Del_Remove Remove;

	public static Del_CollectGarbage CollectGarbage;

	public static Del_Clear Clear;

	public static Del_GetInternalIndexOffset GetInternalIndexOffset;
}
