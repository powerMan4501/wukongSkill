using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptUVTriangle", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptUVTriangle
{
	private static bool UV0_IsValid;

	private static int UV0_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptUVTriangle:UV0")]
	public FVector2D UV0;

	private static bool UV1_IsValid;

	private static int UV1_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptUVTriangle:UV1")]
	public FVector2D UV1;

	private static bool UV2_IsValid;

	private static int UV2_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptUVTriangle:UV2")]
	public FVector2D UV2;

	private static bool FGeometryScriptUVTriangle_IsValid;

	private static int FGeometryScriptUVTriangle_StructSize;

	public FGeometryScriptUVTriangle Copy()
	{
		return this;
	}

	public static FGeometryScriptUVTriangle FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptUVTriangle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptUVTriangle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptUVTriangle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptUVTriangle(nativeBuffer + arrayIndex * FGeometryScriptUVTriangle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptUVTriangle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptUVTriangle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptUVTriangle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptUVTriangle");
			return;
		}
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, UV0_Offset), UV0);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, UV1_Offset), UV1);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, UV2_Offset), UV2);
	}

	public FGeometryScriptUVTriangle(IntPtr nativeStruct)
	{
		if (!FGeometryScriptUVTriangle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptUVTriangle");
			UV0 = default(FVector2D);
			UV1 = default(FVector2D);
			UV2 = default(FVector2D);
		}
		else
		{
			UV0 = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, UV0_Offset));
			UV1 = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, UV1_Offset));
			UV2 = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, UV2_Offset));
		}
	}

	static FGeometryScriptUVTriangle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptUVTriangle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptUVTriangle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptUVTriangle");
		FGeometryScriptUVTriangle_StructSize = NativeReflection.GetStructSize(intPtr);
		UV0_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV0");
		UV0_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV0", Classes.FStructProperty);
		UV1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV1");
		UV1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV1", Classes.FStructProperty);
		UV2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UV2");
		UV2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UV2", Classes.FStructProperty);
		FGeometryScriptUVTriangle_IsValid = intPtr != IntPtr.Zero && UV0_IsValid && UV1_IsValid && UV2_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptUVTriangle", FGeometryScriptUVTriangle_IsValid);
	}
}
