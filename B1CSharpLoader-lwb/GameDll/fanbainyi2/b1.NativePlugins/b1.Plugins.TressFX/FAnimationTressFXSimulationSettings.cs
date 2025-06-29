using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/TressFX.AnimationTressFXSimulationSettings", "TressFX", UnrealModuleType.GamePlugin)]
public struct FAnimationTressFXSimulationSettings
{
	private static bool Animation_IsValid;

	private static int Animation_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/TressFX.AnimationTressFXSimulationSettings:Animation")]
	public UAnimationAsset Animation;

	private static bool TressFXSimulationSettingsName_IsValid;

	private static int TressFXSimulationSettingsName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/TressFX.AnimationTressFXSimulationSettings:TressFXSimulationSettingsName")]
	public string TressFXSimulationSettingsName;

	private static bool AnimResetPositionPeriods_IsValid;

	private static FFieldAddress AnimResetPositionPeriods_PropertyAddress;

	private static int AnimResetPositionPeriods_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/TressFX.AnimationTressFXSimulationSettings:AnimResetPositionPeriods")]
	public List<FAnimationResetPositionPeriod> AnimResetPositionPeriods;

	private static bool FAnimationTressFXSimulationSettings_IsValid;

	private static int FAnimationTressFXSimulationSettings_StructSize;

	public FAnimationTressFXSimulationSettings Copy()
	{
		FAnimationTressFXSimulationSettings result = this;
		if (AnimResetPositionPeriods != null)
		{
			result.AnimResetPositionPeriods = new List<FAnimationResetPositionPeriod>(AnimResetPositionPeriods);
		}
		return result;
	}

	public static FAnimationTressFXSimulationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAnimationTressFXSimulationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimationTressFXSimulationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimationTressFXSimulationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimationTressFXSimulationSettings(nativeBuffer + arrayIndex * FAnimationTressFXSimulationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimationTressFXSimulationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimationTressFXSimulationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimationTressFXSimulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TressFX.AnimationTressFXSimulationSettings");
			return;
		}
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(nativeStruct, Animation_Offset), Animation);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, TressFXSimulationSettingsName_Offset), TressFXSimulationSettingsName);
		new TArrayCopyMarshaler<FAnimationResetPositionPeriod>(1, AnimResetPositionPeriods_PropertyAddress, CachedMarshalingDelegates<FAnimationResetPositionPeriod, FAnimationResetPositionPeriod>.FromNative, CachedMarshalingDelegates<FAnimationResetPositionPeriod, FAnimationResetPositionPeriod>.ToNative).ToNative(IntPtr.Add(nativeStruct, AnimResetPositionPeriods_Offset), AnimResetPositionPeriods);
	}

	public FAnimationTressFXSimulationSettings(IntPtr nativeStruct)
	{
		if (!FAnimationTressFXSimulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TressFX.AnimationTressFXSimulationSettings");
			Animation = null;
			TressFXSimulationSettingsName = FStringMarshaler.DefaultString;
			AnimResetPositionPeriods = null;
		}
		else
		{
			Animation = UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(nativeStruct, Animation_Offset));
			TressFXSimulationSettingsName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, TressFXSimulationSettingsName_Offset));
			AnimResetPositionPeriods = new TArrayCopyMarshaler<FAnimationResetPositionPeriod>(1, AnimResetPositionPeriods_PropertyAddress, CachedMarshalingDelegates<FAnimationResetPositionPeriod, FAnimationResetPositionPeriod>.FromNative, CachedMarshalingDelegates<FAnimationResetPositionPeriod, FAnimationResetPositionPeriod>.ToNative).FromNative(IntPtr.Add(nativeStruct, AnimResetPositionPeriods_Offset));
		}
	}

	static FAnimationTressFXSimulationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimationTressFXSimulationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimationTressFXSimulationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TressFX.AnimationTressFXSimulationSettings");
		FAnimationTressFXSimulationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Animation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Animation");
		Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Animation", Classes.FObjectProperty);
		TressFXSimulationSettingsName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TressFXSimulationSettingsName");
		TressFXSimulationSettingsName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TressFXSimulationSettingsName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimResetPositionPeriods_PropertyAddress, intPtr, "AnimResetPositionPeriods");
		AnimResetPositionPeriods_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimResetPositionPeriods");
		AnimResetPositionPeriods_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimResetPositionPeriods", Classes.FArrayProperty);
		FAnimationTressFXSimulationSettings_IsValid = intPtr != IntPtr.Zero && Animation_IsValid && TressFXSimulationSettingsName_IsValid && AnimResetPositionPeriods_IsValid;
		NativeReflection.LogStructIsValid("/Script/TressFX.AnimationTressFXSimulationSettings", FAnimationTressFXSimulationSettings_IsValid);
	}
}
