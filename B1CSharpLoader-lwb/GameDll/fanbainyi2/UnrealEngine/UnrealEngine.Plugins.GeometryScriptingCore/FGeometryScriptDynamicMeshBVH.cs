using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDynamicMeshBVH", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptDynamicMeshBVH
{
	private static bool FGeometryScriptDynamicMeshBVH_IsValid;

	private static int FGeometryScriptDynamicMeshBVH_StructSize;

	public FGeometryScriptDynamicMeshBVH Copy()
	{
		return this;
	}

	public static FGeometryScriptDynamicMeshBVH FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptDynamicMeshBVH(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptDynamicMeshBVH value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptDynamicMeshBVH FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptDynamicMeshBVH(nativeBuffer + arrayIndex * FGeometryScriptDynamicMeshBVH_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptDynamicMeshBVH value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptDynamicMeshBVH_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptDynamicMeshBVH_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptDynamicMeshBVH");
		}
	}

	public FGeometryScriptDynamicMeshBVH(IntPtr nativeStruct)
	{
		if (!FGeometryScriptDynamicMeshBVH_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptDynamicMeshBVH");
		}
	}

	static FGeometryScriptDynamicMeshBVH()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptDynamicMeshBVH)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptDynamicMeshBVH));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptDynamicMeshBVH");
		FGeometryScriptDynamicMeshBVH_StructSize = NativeReflection.GetStructSize(intPtr);
		FGeometryScriptDynamicMeshBVH_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptDynamicMeshBVH", FGeometryScriptDynamicMeshBVH_IsValid);
	}
}
