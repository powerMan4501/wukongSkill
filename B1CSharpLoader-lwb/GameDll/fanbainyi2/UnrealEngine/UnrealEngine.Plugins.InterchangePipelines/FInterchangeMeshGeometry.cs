using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangePipelines;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/InterchangePipelines.InterchangeMeshGeometry", "InterchangePipelines", UnrealModuleType.EnginePlugin)]
public struct FInterchangeMeshGeometry
{
	private static bool FInterchangeMeshGeometry_IsValid;

	private static int FInterchangeMeshGeometry_StructSize;

	public FInterchangeMeshGeometry Copy()
	{
		return this;
	}

	public static FInterchangeMeshGeometry FromNative(IntPtr nativeBuffer)
	{
		return new FInterchangeMeshGeometry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInterchangeMeshGeometry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInterchangeMeshGeometry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInterchangeMeshGeometry(nativeBuffer + arrayIndex * FInterchangeMeshGeometry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInterchangeMeshGeometry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInterchangeMeshGeometry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInterchangeMeshGeometry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/InterchangePipelines.InterchangeMeshGeometry");
		}
	}

	public FInterchangeMeshGeometry(IntPtr nativeStruct)
	{
		if (!FInterchangeMeshGeometry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/InterchangePipelines.InterchangeMeshGeometry");
		}
	}

	static FInterchangeMeshGeometry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterchangeMeshGeometry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterchangeMeshGeometry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/InterchangePipelines.InterchangeMeshGeometry");
		FInterchangeMeshGeometry_StructSize = NativeReflection.GetStructSize(intPtr);
		FInterchangeMeshGeometry_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/InterchangePipelines.InterchangeMeshGeometry", FInterchangeMeshGeometry_IsValid);
	}
}
