using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FScriptBitArray
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsValidIndex(ref FScriptBitArray instance, int index);

	[MonoNativeFunctionWrapper]
	public delegate FBitReference Del_Get(ref FScriptBitArray instance, int index);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Empty(ref FScriptBitArray instance, int slack);

	[MonoNativeFunctionWrapper]
	public delegate int Del_Add(ref FScriptBitArray instance, csbool value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Destroy(ref FScriptBitArray instance);

	public static Del_IsValidIndex IsValidIndex;

	public static Del_Get Get;

	public static Del_Empty Empty;

	public static Del_Add Add;

	public static Del_Destroy Destroy;
}
