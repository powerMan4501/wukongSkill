using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.ExponentialHeightFogData", "Engine", UnrealModuleType.Engine)]
public struct FExponentialHeightFogData
{
	private static bool FogDensity_IsValid;

	private static int FogDensity_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogData:FogDensity")]
	public float FogDensity;

	private static bool FogHeightFalloff_IsValid;

	private static int FogHeightFalloff_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogData:FogHeightFalloff")]
	public float FogHeightFalloff;

	private static bool FogHeightOffset_IsValid;

	private static int FogHeightOffset_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogData:FogHeightOffset")]
	public float FogHeightOffset;

	private static bool FExponentialHeightFogData_IsValid;

	private static int FExponentialHeightFogData_StructSize;

	public FExponentialHeightFogData Copy()
	{
		return this;
	}

	public static FExponentialHeightFogData FromNative(IntPtr nativeBuffer)
	{
		return new FExponentialHeightFogData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FExponentialHeightFogData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FExponentialHeightFogData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FExponentialHeightFogData(nativeBuffer + arrayIndex * FExponentialHeightFogData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FExponentialHeightFogData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FExponentialHeightFogData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FExponentialHeightFogData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ExponentialHeightFogData");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FogDensity_Offset), FogDensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FogHeightFalloff_Offset), FogHeightFalloff);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FogHeightOffset_Offset), FogHeightOffset);
	}

	public FExponentialHeightFogData(IntPtr nativeStruct)
	{
		if (!FExponentialHeightFogData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ExponentialHeightFogData");
			FogDensity = 0f;
			FogHeightFalloff = 0f;
			FogHeightOffset = 0f;
		}
		else
		{
			FogDensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FogDensity_Offset));
			FogHeightFalloff = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FogHeightFalloff_Offset));
			FogHeightOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FogHeightOffset_Offset));
		}
	}

	static FExponentialHeightFogData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FExponentialHeightFogData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FExponentialHeightFogData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ExponentialHeightFogData");
		FExponentialHeightFogData_StructSize = NativeReflection.GetStructSize(intPtr);
		FogDensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogDensity");
		FogDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogDensity", Classes.FFloatProperty);
		FogHeightFalloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogHeightFalloff");
		FogHeightFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogHeightFalloff", Classes.FFloatProperty);
		FogHeightOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogHeightOffset");
		FogHeightOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogHeightOffset", Classes.FFloatProperty);
		FExponentialHeightFogData_IsValid = intPtr != IntPtr.Zero && FogDensity_IsValid && FogHeightFalloff_IsValid && FogHeightOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ExponentialHeightFogData", FExponentialHeightFogData_IsValid);
	}
}
