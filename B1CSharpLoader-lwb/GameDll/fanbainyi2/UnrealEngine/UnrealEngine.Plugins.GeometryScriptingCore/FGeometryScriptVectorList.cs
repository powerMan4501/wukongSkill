using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptVectorList", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptVectorList
{
	private static bool FGeometryScriptVectorList_IsValid;

	private static int FGeometryScriptVectorList_StructSize;

	public FGeometryScriptVectorList Copy()
	{
		return this;
	}

	public static FGeometryScriptVectorList FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptVectorList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptVectorList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptVectorList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptVectorList(nativeBuffer + arrayIndex * FGeometryScriptVectorList_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptVectorList value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptVectorList_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptVectorList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptVectorList");
		}
	}

	public FGeometryScriptVectorList(IntPtr nativeStruct)
	{
		if (!FGeometryScriptVectorList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptVectorList");
		}
	}

	static FGeometryScriptVectorList()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptVectorList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptVectorList));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptVectorList");
		FGeometryScriptVectorList_StructSize = NativeReflection.GetStructSize(intPtr);
		FGeometryScriptVectorList_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptVectorList", FGeometryScriptVectorList_IsValid);
	}
}
