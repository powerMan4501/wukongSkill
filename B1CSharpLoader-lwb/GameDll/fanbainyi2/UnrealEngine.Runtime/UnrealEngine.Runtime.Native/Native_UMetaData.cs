using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UMetaData
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_GetValue(IntPtr instance, IntPtr obj, ref FScriptArray key, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetValueFName(IntPtr instance, IntPtr obj, ref FName key, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasValue(IntPtr instance, IntPtr obj, ref FScriptArray key);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasValueFName(IntPtr instance, IntPtr obj, ref FName key);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasObjectValues(IntPtr instance, IntPtr obj);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetObjectValues(IntPtr instance, IntPtr obj, IntPtr keys, IntPtr values);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetValue(IntPtr instance, IntPtr obj, ref FScriptArray key, ref FScriptArray value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetValueFName(IntPtr instance, IntPtr obj, ref FName key, ref FScriptArray value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RemoveValue(IntPtr instance, IntPtr obj, ref FScriptArray key);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RemoveValueFName(IntPtr instance, IntPtr obj, ref FName key);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetMapForObject(IntPtr obj, IntPtr keys, IntPtr values);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CopyMetadata(IntPtr sourceObject, IntPtr destObject);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RemoveMetaDataOutsidePackage(IntPtr instance);

	public static Del_GetValue GetValue;

	public static Del_GetValueFName GetValueFName;

	public static Del_HasValue HasValue;

	public static Del_HasValueFName HasValueFName;

	public static Del_HasObjectValues HasObjectValues;

	public static Del_SetObjectValues SetObjectValues;

	public static Del_SetValue SetValue;

	public static Del_SetValueFName SetValueFName;

	public static Del_RemoveValue RemoveValue;

	public static Del_RemoveValueFName RemoveValueFName;

	public static Del_GetMapForObject GetMapForObject;

	public static Del_CopyMetadata CopyMetadata;

	public static Del_RemoveMetaDataOutsidePackage RemoveMetaDataOutsidePackage;
}
