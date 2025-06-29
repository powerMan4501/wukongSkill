using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTriangleList", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptTriangleList
{
	private static bool FGeometryScriptTriangleList_IsValid;

	private static int FGeometryScriptTriangleList_StructSize;

	public FGeometryScriptTriangleList Copy()
	{
		return this;
	}

	public static FGeometryScriptTriangleList FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptTriangleList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptTriangleList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptTriangleList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptTriangleList(nativeBuffer + arrayIndex * FGeometryScriptTriangleList_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptTriangleList value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptTriangleList_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptTriangleList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptTriangleList");
		}
	}

	public FGeometryScriptTriangleList(IntPtr nativeStruct)
	{
		if (!FGeometryScriptTriangleList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptTriangleList");
		}
	}

	static FGeometryScriptTriangleList()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptTriangleList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptTriangleList));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptTriangleList");
		FGeometryScriptTriangleList_StructSize = NativeReflection.GetStructSize(intPtr);
		FGeometryScriptTriangleList_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptTriangleList", FGeometryScriptTriangleList_IsValid);
	}
}
