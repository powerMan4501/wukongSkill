using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FName
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_FromEName(out FName outName, int n);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FromENameNumber(out FName outName, int n, int inNumber);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FromString(out FName outName, ref FScriptArray str, FName.EFindName findType);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FromStringNumber(out FName outName, ref FScriptArray str, int number, FName.EFindName findType);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ToString(ref FName name, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetPlainNameString(ref FName name, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsEqual(ref FName name, ref FName other, FName.ENameCase compareMethod, csbool compareNumber);

	[MonoNativeFunctionWrapper]
	public delegate int Del_Compare(ref FName name, ref FName other);

	public static Del_FromEName FromEName;

	public static Del_FromENameNumber FromENameNumber;

	public static Del_FromString FromString;

	public static Del_FromStringNumber FromStringNumber;

	public new static Del_ToString ToString;

	public static Del_GetPlainNameString GetPlainNameString;

	public static Del_IsEqual IsEqual;

	public static Del_Compare Compare;
}
