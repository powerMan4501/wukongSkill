using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FCoreRedirectObjectName
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_CtorString(ref FScriptArray inString, out FCoreRedirectObjectName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CtorObject(IntPtr obj, out FCoreRedirectObjectName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ToString(ref FCoreRedirectObjectName instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reset(ref FCoreRedirectObjectName instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Matches(ref FCoreRedirectObjectName instance, ref FCoreRedirectObjectName other, csbool checkSubstring);

	[MonoNativeFunctionWrapper]
	public delegate int Del_MatchScore(ref FCoreRedirectObjectName instance, ref FCoreRedirectObjectName other);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetSearchKey(ref FCoreRedirectObjectName instance, ECoreRedirectFlags type, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsValid(ref FCoreRedirectObjectName instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasValidCharacters(ref FCoreRedirectObjectName instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ExpandNames(ref FScriptArray fullString, ref FName outName, ref FName outOuter, ref FName outPackage);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CombineNames(ref FName newName, ref FName newOuter, ref FName newPackage, ref FScriptArray result);

	public static Del_CtorString CtorString;

	public static Del_CtorObject CtorObject;

	public new static Del_ToString ToString;

	public static Del_Reset Reset;

	public static Del_Matches Matches;

	public static Del_MatchScore MatchScore;

	public static Del_GetSearchKey GetSearchKey;

	public static Del_IsValid IsValid;

	public static Del_HasValidCharacters HasValidCharacters;

	public static Del_ExpandNames ExpandNames;

	public static Del_CombineNames CombineNames;
}
