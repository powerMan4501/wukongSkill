using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Landmass;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Landmass.BrushEffectSmoothBlending", "Landmass", UnrealModuleType.EnginePlugin)]
public struct FBrushEffectSmoothBlending
{
	private static bool InnerSmoothDistance_IsValid;

	private static int InnerSmoothDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectSmoothBlending:InnerSmoothDistance")]
	public float InnerSmoothDistance;

	private static bool OuterSmoothDistance_IsValid;

	private static int OuterSmoothDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectSmoothBlending:OuterSmoothDistance")]
	public float OuterSmoothDistance;

	private static bool FBrushEffectSmoothBlending_IsValid;

	private static int FBrushEffectSmoothBlending_StructSize;

	public FBrushEffectSmoothBlending Copy()
	{
		return this;
	}

	public static FBrushEffectSmoothBlending FromNative(IntPtr nativeBuffer)
	{
		return new FBrushEffectSmoothBlending(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBrushEffectSmoothBlending value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBrushEffectSmoothBlending FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBrushEffectSmoothBlending(nativeBuffer + arrayIndex * FBrushEffectSmoothBlending_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBrushEffectSmoothBlending value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBrushEffectSmoothBlending_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBrushEffectSmoothBlending_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectSmoothBlending");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InnerSmoothDistance_Offset), InnerSmoothDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OuterSmoothDistance_Offset), OuterSmoothDistance);
	}

	public FBrushEffectSmoothBlending(IntPtr nativeStruct)
	{
		if (!FBrushEffectSmoothBlending_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectSmoothBlending");
			InnerSmoothDistance = 0f;
			OuterSmoothDistance = 0f;
		}
		else
		{
			InnerSmoothDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InnerSmoothDistance_Offset));
			OuterSmoothDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OuterSmoothDistance_Offset));
		}
	}

	static FBrushEffectSmoothBlending()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBrushEffectSmoothBlending)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBrushEffectSmoothBlending));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Landmass.BrushEffectSmoothBlending");
		FBrushEffectSmoothBlending_StructSize = NativeReflection.GetStructSize(intPtr);
		InnerSmoothDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InnerSmoothDistance");
		InnerSmoothDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InnerSmoothDistance", Classes.FFloatProperty);
		OuterSmoothDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OuterSmoothDistance");
		OuterSmoothDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OuterSmoothDistance", Classes.FFloatProperty);
		FBrushEffectSmoothBlending_IsValid = intPtr != IntPtr.Zero && InnerSmoothDistance_IsValid && OuterSmoothDistance_IsValid;
		NativeReflection.LogStructIsValid("/Script/Landmass.BrushEffectSmoothBlending", FBrushEffectSmoothBlending_IsValid);
	}
}
