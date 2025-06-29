using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FText
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_CreateEmpty(IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CreateText(ref FScriptArray nameSpace, ref FScriptArray key, ref FScriptArray literal, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetInvariantTimeZone(ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_FindText(ref FScriptArray nameSpace, ref FScriptArray key, IntPtr outText, ref FScriptArray sourceString);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FromStringTable(ref FName tableId, ref FScriptArray key, EStringTableLoadingPolicy loadingPolicy, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FromName(ref FName val, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FromString(ref FScriptArray str, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AsCultureInvariant(ref FScriptArray str, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AsCultureInvariantText(IntPtr text, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ToString(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_BuildSourceString(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsNumeric(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_CompareTo(IntPtr instance, IntPtr other, ETextComparisonLevel comparisonLevel);

	[MonoNativeFunctionWrapper]
	public delegate int Del_CompareToCaseIgnored(IntPtr instance, IntPtr other);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_EqualTo(IntPtr instance, IntPtr other, ETextComparisonLevel comparisonLevel);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_EqualToCaseIgnored(IntPtr instance, IntPtr other);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IdenticalTo(IntPtr instance, IntPtr other);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsEmpty(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsEmptyOrWhitespace(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ToLower(IntPtr instance, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ToUpper(IntPtr instance, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_TrimPreceding(IntPtr instance, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_TrimTrailing(IntPtr instance, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_TrimPrecedingAndTrailing(IntPtr instance, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsTransient(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsCultureInvariant(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsFromStringTable(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ShouldGatherForLocalization(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ChangeKey(ref FScriptArray nameSpace, ref FScriptArray key, IntPtr text, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Format_1(IntPtr instance, IntPtr result, IntPtr arg0);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Format_2(IntPtr instance, IntPtr result, IntPtr arg0, IntPtr arg1);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Format_3(IntPtr instance, IntPtr result, IntPtr arg0, IntPtr arg1, IntPtr arg2);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Format_4(IntPtr instance, IntPtr result, IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Format_5(IntPtr instance, IntPtr result, IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Format_6(IntPtr instance, IntPtr result, IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Format_7(IntPtr instance, IntPtr result, IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Format_8(IntPtr instance, IntPtr result, IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Format_9(IntPtr instance, IntPtr result, IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Format_10(IntPtr instance, IntPtr result, IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9);

	public static Del_CreateEmpty CreateEmpty;

	public static Del_CreateText CreateText;

	public static Del_GetInvariantTimeZone GetInvariantTimeZone;

	public static Del_FindText FindText;

	public static Del_FromStringTable FromStringTable;

	public static Del_FromName FromName;

	public static Del_FromString FromString;

	public static Del_AsCultureInvariant AsCultureInvariant;

	public static Del_AsCultureInvariantText AsCultureInvariantText;

	public new static Del_ToString ToString;

	public static Del_BuildSourceString BuildSourceString;

	public static Del_IsNumeric IsNumeric;

	public static Del_CompareTo CompareTo;

	public static Del_CompareToCaseIgnored CompareToCaseIgnored;

	public static Del_EqualTo EqualTo;

	public static Del_EqualToCaseIgnored EqualToCaseIgnored;

	public static Del_IdenticalTo IdenticalTo;

	public static Del_IsEmpty IsEmpty;

	public static Del_IsEmptyOrWhitespace IsEmptyOrWhitespace;

	public static Del_ToLower ToLower;

	public static Del_ToUpper ToUpper;

	public static Del_TrimPreceding TrimPreceding;

	public static Del_TrimTrailing TrimTrailing;

	public static Del_TrimPrecedingAndTrailing TrimPrecedingAndTrailing;

	public static Del_IsTransient IsTransient;

	public static Del_IsCultureInvariant IsCultureInvariant;

	public static Del_IsFromStringTable IsFromStringTable;

	public static Del_ShouldGatherForLocalization ShouldGatherForLocalization;

	public static Del_ChangeKey ChangeKey;

	public static Del_Format_1 Format_1;

	public static Del_Format_2 Format_2;

	public static Del_Format_3 Format_3;

	public static Del_Format_4 Format_4;

	public static Del_Format_5 Format_5;

	public static Del_Format_6 Format_6;

	public static Del_Format_7 Format_7;

	public static Del_Format_8 Format_8;

	public static Del_Format_9 Format_9;

	public static Del_Format_10 Format_10;
}
