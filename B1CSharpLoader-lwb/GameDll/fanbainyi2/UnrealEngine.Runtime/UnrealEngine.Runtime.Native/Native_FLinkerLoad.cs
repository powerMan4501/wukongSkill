using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FLinkerLoad
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_FindPreviousNamesForClass(ref FScriptArray currentClassPath, csbool isInstance, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FindNewNameForClass(ref FName oldClassName, csbool isInstance, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FindNewNameForEnum(ref FName oldEnumName, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FindNewNameForStruct(ref FName oldStructName, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_InvalidateExport(IntPtr oldObject);

	public static Del_FindPreviousNamesForClass FindPreviousNamesForClass;

	public static Del_FindNewNameForClass FindNewNameForClass;

	public static Del_FindNewNameForEnum FindNewNameForEnum;

	public static Del_FindNewNameForStruct FindNewNameForStruct;

	public static Del_InvalidateExport InvalidateExport;
}
