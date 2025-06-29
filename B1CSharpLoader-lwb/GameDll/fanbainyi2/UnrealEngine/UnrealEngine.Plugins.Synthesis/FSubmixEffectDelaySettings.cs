using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectDelaySettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSubmixEffectDelaySettings
{
	private static bool MaximumDelayLength_IsValid;

	private static int MaximumDelayLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelaySettings:MaximumDelayLength")]
	public float MaximumDelayLength;

	private static bool InterpolationTime_IsValid;

	private static int InterpolationTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelaySettings:InterpolationTime")]
	public float InterpolationTime;

	private static bool DelayLength_IsValid;

	private static int DelayLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectDelaySettings:DelayLength")]
	public float DelayLength;

	private static bool FSubmixEffectDelaySettings_IsValid;

	private static int FSubmixEffectDelaySettings_StructSize;

	public FSubmixEffectDelaySettings Copy()
	{
		return this;
	}

	public static FSubmixEffectDelaySettings FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectDelaySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectDelaySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectDelaySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectDelaySettings(nativeBuffer + arrayIndex * FSubmixEffectDelaySettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectDelaySettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectDelaySettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectDelaySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectDelaySettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaximumDelayLength_Offset), MaximumDelayLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InterpolationTime_Offset), InterpolationTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayLength_Offset), DelayLength);
	}

	public FSubmixEffectDelaySettings(IntPtr nativeStruct)
	{
		if (!FSubmixEffectDelaySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectDelaySettings");
			MaximumDelayLength = 0f;
			InterpolationTime = 0f;
			DelayLength = 0f;
		}
		else
		{
			MaximumDelayLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaximumDelayLength_Offset));
			InterpolationTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InterpolationTime_Offset));
			DelayLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayLength_Offset));
		}
	}

	static FSubmixEffectDelaySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectDelaySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectDelaySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SubmixEffectDelaySettings");
		FSubmixEffectDelaySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		MaximumDelayLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaximumDelayLength");
		MaximumDelayLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaximumDelayLength", Classes.FFloatProperty);
		InterpolationTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpolationTime");
		InterpolationTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpolationTime", Classes.FFloatProperty);
		DelayLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DelayLength");
		DelayLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DelayLength", Classes.FFloatProperty);
		FSubmixEffectDelaySettings_IsValid = intPtr != IntPtr.Zero && MaximumDelayLength_IsValid && InterpolationTime_IsValid && DelayLength_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SubmixEffectDelaySettings", FSubmixEffectDelaySettings_IsValid);
	}
}
