using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FObjectPropertyBase
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_PropertyClass(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_PropertyClass(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetCPPTypeCustom(IntPtr instance, ref FScriptArray extendedTypeText, uint cppExportFlags, ref FScriptArray innerNativeTypeName, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ParseObjectPropertyValue(IntPtr property, IntPtr ownerObject, IntPtr requiredMetaClass, uint portFlags, ref FScriptArray buffer, ref IntPtr out_ResolvedValue);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_FindImportedObject(IntPtr property, IntPtr ownerObject, IntPtr objectClass, IntPtr requiredMetaClass, ref FScriptArray text, uint portFlags);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetExportPath(IntPtr Object, IntPtr parent, IntPtr exportRootScope, uint portFlags, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetObjectPropertyValue(IntPtr instance, IntPtr propertyValueAddress);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetObjectPropertyValue_InContainer(IntPtr instance, IntPtr propertyValueAddress, int arrayIndex);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetObjectPropertyValue(IntPtr instance, IntPtr propertyValueAddress, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetObjectPropertyValue_InContainer(IntPtr instance, IntPtr propertyValueAddress, IntPtr value, int arrayIndex);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetPropertyClass(IntPtr instance, IntPtr newPropertyClass);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_Get_PropertyClass Get_PropertyClass;

	public static Del_Set_PropertyClass Set_PropertyClass;

	public static Del_GetCPPTypeCustom GetCPPTypeCustom;

	public static Del_ParseObjectPropertyValue ParseObjectPropertyValue;

	public static Del_FindImportedObject FindImportedObject;

	public static Del_GetExportPath GetExportPath;

	public static Del_GetObjectPropertyValue GetObjectPropertyValue;

	public static Del_GetObjectPropertyValue_InContainer GetObjectPropertyValue_InContainer;

	public static Del_SetObjectPropertyValue SetObjectPropertyValue;

	public static Del_SetObjectPropertyValue_InContainer SetObjectPropertyValue_InContainer;

	public static Del_SetPropertyClass SetPropertyClass;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
