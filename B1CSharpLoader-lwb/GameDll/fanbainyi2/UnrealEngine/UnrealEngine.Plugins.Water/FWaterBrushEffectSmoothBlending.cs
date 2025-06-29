using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.WaterBrushEffectSmoothBlending", "Water", UnrealModuleType.EnginePlugin)]
public struct FWaterBrushEffectSmoothBlending
{
	private static bool InnerSmoothDistance_IsValid;

	private static int InnerSmoothDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectSmoothBlending:InnerSmoothDistance")]
	public float InnerSmoothDistance;

	private static bool OuterSmoothDistance_IsValid;

	private static int OuterSmoothDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectSmoothBlending:OuterSmoothDistance")]
	public float OuterSmoothDistance;

	private static bool FWaterBrushEffectSmoothBlending_IsValid;

	private static int FWaterBrushEffectSmoothBlending_StructSize;

	public FWaterBrushEffectSmoothBlending Copy()
	{
		return this;
	}

	public static FWaterBrushEffectSmoothBlending FromNative(IntPtr nativeBuffer)
	{
		return new FWaterBrushEffectSmoothBlending(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterBrushEffectSmoothBlending value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterBrushEffectSmoothBlending FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterBrushEffectSmoothBlending(nativeBuffer + arrayIndex * FWaterBrushEffectSmoothBlending_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterBrushEffectSmoothBlending value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWaterBrushEffectSmoothBlending_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffectSmoothBlending_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffectSmoothBlending");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InnerSmoothDistance_Offset), InnerSmoothDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OuterSmoothDistance_Offset), OuterSmoothDistance);
	}

	public FWaterBrushEffectSmoothBlending(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffectSmoothBlending_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffectSmoothBlending");
			InnerSmoothDistance = 0f;
			OuterSmoothDistance = 0f;
		}
		else
		{
			InnerSmoothDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InnerSmoothDistance_Offset));
			OuterSmoothDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OuterSmoothDistance_Offset));
		}
	}

	static FWaterBrushEffectSmoothBlending()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWaterBrushEffectSmoothBlending)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterBrushEffectSmoothBlending));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.WaterBrushEffectSmoothBlending");
		FWaterBrushEffectSmoothBlending_StructSize = NativeReflection.GetStructSize(intPtr);
		InnerSmoothDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InnerSmoothDistance");
		InnerSmoothDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InnerSmoothDistance", Classes.FFloatProperty);
		OuterSmoothDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OuterSmoothDistance");
		OuterSmoothDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OuterSmoothDistance", Classes.FFloatProperty);
		FWaterBrushEffectSmoothBlending_IsValid = intPtr != IntPtr.Zero && InnerSmoothDistance_IsValid && OuterSmoothDistance_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.WaterBrushEffectSmoothBlending", FWaterBrushEffectSmoothBlending_IsValid);
	}
}
