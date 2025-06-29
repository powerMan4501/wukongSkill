using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FNumericProperty
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsFloatingPoint(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInteger(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsEnum(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetIntPropertyEnum(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetIntPropertyValueUnsigned(IntPtr instance, IntPtr data, ulong value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetIntPropertyValueSigned(IntPtr instance, IntPtr data, long value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetFloatingPointPropertyValue(IntPtr instance, IntPtr data, double value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetNumericPropertyValueFromString(IntPtr instance, IntPtr data, ref FScriptArray value);

	[MonoNativeFunctionWrapper]
	public delegate long Del_GetSignedIntPropertyValue(IntPtr instance, IntPtr data);

	[MonoNativeFunctionWrapper]
	public delegate ulong Del_GetUnsignedIntPropertyValue(IntPtr instance, IntPtr data);

	[MonoNativeFunctionWrapper]
	public delegate double Del_GetFloatingPointPropertyValue(IntPtr instance, IntPtr data);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetNumericPropertyValueToString(IntPtr instance, IntPtr data, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_IsFloatingPoint IsFloatingPoint;

	public static Del_IsInteger IsInteger;

	public static Del_IsEnum IsEnum;

	public static Del_GetIntPropertyEnum GetIntPropertyEnum;

	public static Del_SetIntPropertyValueUnsigned SetIntPropertyValueUnsigned;

	public static Del_SetIntPropertyValueSigned SetIntPropertyValueSigned;

	public static Del_SetFloatingPointPropertyValue SetFloatingPointPropertyValue;

	public static Del_SetNumericPropertyValueFromString SetNumericPropertyValueFromString;

	public static Del_GetSignedIntPropertyValue GetSignedIntPropertyValue;

	public static Del_GetUnsignedIntPropertyValue GetUnsignedIntPropertyValue;

	public static Del_GetFloatingPointPropertyValue GetFloatingPointPropertyValue;

	public static Del_GetNumericPropertyValueToString GetNumericPropertyValueToString;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
