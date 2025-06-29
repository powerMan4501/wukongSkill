using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptExpMapUVOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptExpMapUVOptions
{
	private static bool NormalSmoothingRounds_IsValid;

	private static int NormalSmoothingRounds_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptExpMapUVOptions:NormalSmoothingRounds")]
	public int NormalSmoothingRounds;

	private static bool NormalSmoothingAlpha_IsValid;

	private static int NormalSmoothingAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptExpMapUVOptions:NormalSmoothingAlpha")]
	public float NormalSmoothingAlpha;

	private static bool FGeometryScriptExpMapUVOptions_IsValid;

	private static int FGeometryScriptExpMapUVOptions_StructSize;

	public FGeometryScriptExpMapUVOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptExpMapUVOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptExpMapUVOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptExpMapUVOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptExpMapUVOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptExpMapUVOptions(nativeBuffer + arrayIndex * FGeometryScriptExpMapUVOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptExpMapUVOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptExpMapUVOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptExpMapUVOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptExpMapUVOptions");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NormalSmoothingRounds_Offset), NormalSmoothingRounds);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalSmoothingAlpha_Offset), NormalSmoothingAlpha);
	}

	public FGeometryScriptExpMapUVOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptExpMapUVOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptExpMapUVOptions");
			NormalSmoothingRounds = 0;
			NormalSmoothingAlpha = 0f;
		}
		else
		{
			NormalSmoothingRounds = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NormalSmoothingRounds_Offset));
			NormalSmoothingAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalSmoothingAlpha_Offset));
		}
	}

	static FGeometryScriptExpMapUVOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptExpMapUVOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptExpMapUVOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptExpMapUVOptions");
		FGeometryScriptExpMapUVOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NormalSmoothingRounds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalSmoothingRounds");
		NormalSmoothingRounds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalSmoothingRounds", Classes.FIntProperty);
		NormalSmoothingAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalSmoothingAlpha");
		NormalSmoothingAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalSmoothingAlpha", Classes.FFloatProperty);
		FGeometryScriptExpMapUVOptions_IsValid = intPtr != IntPtr.Zero && NormalSmoothingRounds_IsValid && NormalSmoothingAlpha_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptExpMapUVOptions", FGeometryScriptExpMapUVOptions_IsValid);
	}
}
