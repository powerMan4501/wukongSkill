using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTriangle", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptTriangle
{
	private static bool Vector0_IsValid;

	private static int Vector0_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTriangle:Vector0")]
	public FVector Vector0;

	private static bool Vector1_IsValid;

	private static int Vector1_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTriangle:Vector1")]
	public FVector Vector1;

	private static bool Vector2_IsValid;

	private static int Vector2_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptTriangle:Vector2")]
	public FVector Vector2;

	private static bool FGeometryScriptTriangle_IsValid;

	private static int FGeometryScriptTriangle_StructSize;

	public FGeometryScriptTriangle Copy()
	{
		return this;
	}

	public static FGeometryScriptTriangle FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptTriangle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptTriangle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptTriangle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptTriangle(nativeBuffer + arrayIndex * FGeometryScriptTriangle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptTriangle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptTriangle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptTriangle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptTriangle");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Vector0_Offset), Vector0);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Vector1_Offset), Vector1);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Vector2_Offset), Vector2);
	}

	public FGeometryScriptTriangle(IntPtr nativeStruct)
	{
		if (!FGeometryScriptTriangle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptTriangle");
			Vector0 = default(FVector);
			Vector1 = default(FVector);
			Vector2 = default(FVector);
		}
		else
		{
			Vector0 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Vector0_Offset));
			Vector1 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Vector1_Offset));
			Vector2 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Vector2_Offset));
		}
	}

	static FGeometryScriptTriangle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptTriangle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptTriangle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptTriangle");
		FGeometryScriptTriangle_StructSize = NativeReflection.GetStructSize(intPtr);
		Vector0_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Vector0");
		Vector0_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Vector0", Classes.FStructProperty);
		Vector1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Vector1");
		Vector1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Vector1", Classes.FStructProperty);
		Vector2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Vector2");
		Vector2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Vector2", Classes.FStructProperty);
		FGeometryScriptTriangle_IsValid = intPtr != IntPtr.Zero && Vector0_IsValid && Vector1_IsValid && Vector2_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptTriangle", FGeometryScriptTriangle_IsValid);
	}
}
