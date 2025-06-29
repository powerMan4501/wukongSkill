using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UBlueprint
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_ParentClass(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ParentClass(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetBlueprintFromClass(IntPtr inClass);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_GetBlueprintHierarchyFromClass(IntPtr inClass, IntPtr outBlueprintParents);

	public static Del_Get_ParentClass Get_ParentClass;

	public static Del_Set_ParentClass Set_ParentClass;

	public static Del_GetBlueprintFromClass GetBlueprintFromClass;

	public static Del_GetBlueprintHierarchyFromClass GetBlueprintHierarchyFromClass;
}
