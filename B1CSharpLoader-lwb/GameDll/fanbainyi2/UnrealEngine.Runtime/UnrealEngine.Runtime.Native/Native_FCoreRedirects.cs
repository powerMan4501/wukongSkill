using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FCoreRedirects
{
	[MonoNativeFunctionWrapper]
	public delegate FCoreRedirectObjectName Del_GetRedirectedName(ECoreRedirectFlags type, ref FCoreRedirectObjectName oldObjectName);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsKnownMissing(ECoreRedirectFlags type, ref FCoreRedirectObjectName objectName);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_AddKnownMissing(ECoreRedirectFlags type, ref FCoreRedirectObjectName objectName);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_RemoveKnownMissing(ECoreRedirectFlags type, ref FCoreRedirectObjectName objectName);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_FindPreviousNames(ECoreRedirectFlags type, ref FCoreRedirectObjectName newObjectName, IntPtr previousNames);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ReadRedirectsFromIni(ref FScriptArray iniName);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInitialized();

	[MonoNativeFunctionWrapper]
	public delegate ECoreRedirectFlags Del_GetFlagsForTypeName(ref FName packageName, ref FName typeName);

	[MonoNativeFunctionWrapper]
	public delegate ECoreRedirectFlags Del_GetFlagsForTypeClass(IntPtr typeClass);

	public static Del_GetRedirectedName GetRedirectedName;

	public static Del_IsKnownMissing IsKnownMissing;

	public static Del_AddKnownMissing AddKnownMissing;

	public static Del_RemoveKnownMissing RemoveKnownMissing;

	public static Del_FindPreviousNames FindPreviousNames;

	public static Del_ReadRedirectsFromIni ReadRedirectsFromIni;

	public static Del_IsInitialized IsInitialized;

	public static Del_GetFlagsForTypeName GetFlagsForTypeName;

	public static Del_GetFlagsForTypeClass GetFlagsForTypeClass;
}
