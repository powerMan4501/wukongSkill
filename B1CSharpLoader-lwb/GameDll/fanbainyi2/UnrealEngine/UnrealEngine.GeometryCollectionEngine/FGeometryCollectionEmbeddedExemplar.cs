using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionEmbeddedExemplar", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public struct FGeometryCollectionEmbeddedExemplar
{
	private static bool FGeometryCollectionEmbeddedExemplar_IsValid;

	private static int FGeometryCollectionEmbeddedExemplar_StructSize;

	public FGeometryCollectionEmbeddedExemplar Copy()
	{
		return this;
	}

	public static FGeometryCollectionEmbeddedExemplar FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryCollectionEmbeddedExemplar(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryCollectionEmbeddedExemplar value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryCollectionEmbeddedExemplar FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryCollectionEmbeddedExemplar(nativeBuffer + arrayIndex * FGeometryCollectionEmbeddedExemplar_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryCollectionEmbeddedExemplar value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryCollectionEmbeddedExemplar_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryCollectionEmbeddedExemplar_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.GeometryCollectionEmbeddedExemplar");
		}
	}

	public FGeometryCollectionEmbeddedExemplar(IntPtr nativeStruct)
	{
		if (!FGeometryCollectionEmbeddedExemplar_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.GeometryCollectionEmbeddedExemplar");
		}
	}

	static FGeometryCollectionEmbeddedExemplar()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryCollectionEmbeddedExemplar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryCollectionEmbeddedExemplar));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryCollectionEngine.GeometryCollectionEmbeddedExemplar");
		FGeometryCollectionEmbeddedExemplar_StructSize = NativeReflection.GetStructSize(intPtr);
		FGeometryCollectionEmbeddedExemplar_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GeometryCollectionEngine.GeometryCollectionEmbeddedExemplar", FGeometryCollectionEmbeddedExemplar_IsValid);
	}
}
