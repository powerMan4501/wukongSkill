using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptColorList", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptColorList
{
	private static bool FGeometryScriptColorList_IsValid;

	private static int FGeometryScriptColorList_StructSize;

	public FGeometryScriptColorList Copy()
	{
		return this;
	}

	public static FGeometryScriptColorList FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptColorList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptColorList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptColorList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptColorList(nativeBuffer + arrayIndex * FGeometryScriptColorList_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptColorList value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptColorList_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptColorList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptColorList");
		}
	}

	public FGeometryScriptColorList(IntPtr nativeStruct)
	{
		if (!FGeometryScriptColorList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptColorList");
		}
	}

	static FGeometryScriptColorList()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptColorList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptColorList));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptColorList");
		FGeometryScriptColorList_StructSize = NativeReflection.GetStructSize(intPtr);
		FGeometryScriptColorList_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptColorList", FGeometryScriptColorList_IsValid);
	}
}
