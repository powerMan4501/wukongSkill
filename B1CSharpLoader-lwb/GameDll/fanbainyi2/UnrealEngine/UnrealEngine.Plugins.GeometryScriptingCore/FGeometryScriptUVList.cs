using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptUVList", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptUVList
{
	private static bool FGeometryScriptUVList_IsValid;

	private static int FGeometryScriptUVList_StructSize;

	public FGeometryScriptUVList Copy()
	{
		return this;
	}

	public static FGeometryScriptUVList FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptUVList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptUVList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptUVList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptUVList(nativeBuffer + arrayIndex * FGeometryScriptUVList_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptUVList value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptUVList_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptUVList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptUVList");
		}
	}

	public FGeometryScriptUVList(IntPtr nativeStruct)
	{
		if (!FGeometryScriptUVList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptUVList");
		}
	}

	static FGeometryScriptUVList()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptUVList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptUVList));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptUVList");
		FGeometryScriptUVList_StructSize = NativeReflection.GetStructSize(intPtr);
		FGeometryScriptUVList_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptUVList", FGeometryScriptUVList_IsValid);
	}
}
