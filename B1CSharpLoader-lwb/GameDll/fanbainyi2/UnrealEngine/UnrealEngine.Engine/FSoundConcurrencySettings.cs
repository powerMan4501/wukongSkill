using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundConcurrencySettings", "Engine", UnrealModuleType.Engine)]
public struct FSoundConcurrencySettings
{
	private static bool MaxCount_IsValid;

	private static int MaxCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundConcurrencySettings:MaxCount")]
	public int MaxCount;

	private static bool LimitToOwner_IsValid;

	private static FFieldAddress LimitToOwner_PropertyAddress;

	private static int LimitToOwner_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundConcurrencySettings:bLimitToOwner")]
	public bool LimitToOwner;

	private static bool ResolutionRule_IsValid;

	private static FFieldAddress ResolutionRule_PropertyAddress;

	private static int ResolutionRule_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundConcurrencySettings:ResolutionRule")]
	public EMaxConcurrentResolutionRule ResolutionRule;

	private static bool RetriggerTime_IsValid;

	private static int RetriggerTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundConcurrencySettings:RetriggerTime")]
	public float RetriggerTime;

	private static bool VolumeScaleMode_IsValid;

	private static FFieldAddress VolumeScaleMode_PropertyAddress;

	private static int VolumeScaleMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundConcurrencySettings:VolumeScaleMode")]
	public EConcurrencyVolumeScaleMode VolumeScaleMode;

	private static bool VolumeScaleAttackTime_IsValid;

	private static int VolumeScaleAttackTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundConcurrencySettings:VolumeScaleAttackTime")]
	public float VolumeScaleAttackTime;

	private static bool VolumeScaleCanRelease_IsValid;

	private static FFieldAddress VolumeScaleCanRelease_PropertyAddress;

	private static int VolumeScaleCanRelease_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundConcurrencySettings:bVolumeScaleCanRelease")]
	public bool VolumeScaleCanRelease;

	private static bool VolumeScaleReleaseTime_IsValid;

	private static int VolumeScaleReleaseTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundConcurrencySettings:VolumeScaleReleaseTime")]
	public float VolumeScaleReleaseTime;

	private static bool VoiceStealReleaseTime_IsValid;

	private static int VoiceStealReleaseTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundConcurrencySettings:VoiceStealReleaseTime")]
	public float VoiceStealReleaseTime;

	private static bool FSoundConcurrencySettings_IsValid;

	private static int FSoundConcurrencySettings_StructSize;

	public FSoundConcurrencySettings Copy()
	{
		return this;
	}

	public static FSoundConcurrencySettings FromNative(IntPtr nativeBuffer)
	{
		return new FSoundConcurrencySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundConcurrencySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundConcurrencySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundConcurrencySettings(nativeBuffer + arrayIndex * FSoundConcurrencySettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundConcurrencySettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundConcurrencySettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundConcurrencySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundConcurrencySettings");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxCount_Offset), MaxCount);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, LimitToOwner_Offset), 0, LimitToOwner_PropertyAddress.Address, LimitToOwner);
		EnumMarshaler<EMaxConcurrentResolutionRule>.ToNative(IntPtr.Add(nativeStruct, ResolutionRule_Offset), 0, ResolutionRule_PropertyAddress.Address, ResolutionRule);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RetriggerTime_Offset), RetriggerTime);
		EnumMarshaler<EConcurrencyVolumeScaleMode>.ToNative(IntPtr.Add(nativeStruct, VolumeScaleMode_Offset), 0, VolumeScaleMode_PropertyAddress.Address, VolumeScaleMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VolumeScaleAttackTime_Offset), VolumeScaleAttackTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, VolumeScaleCanRelease_Offset), 0, VolumeScaleCanRelease_PropertyAddress.Address, VolumeScaleCanRelease);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VolumeScaleReleaseTime_Offset), VolumeScaleReleaseTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VoiceStealReleaseTime_Offset), VoiceStealReleaseTime);
	}

	public FSoundConcurrencySettings(IntPtr nativeStruct)
	{
		if (!FSoundConcurrencySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundConcurrencySettings");
			MaxCount = 0;
			LimitToOwner = false;
			ResolutionRule = EMaxConcurrentResolutionRule.PreventNew;
			RetriggerTime = 0f;
			VolumeScaleMode = EConcurrencyVolumeScaleMode.Default;
			VolumeScaleAttackTime = 0f;
			VolumeScaleCanRelease = false;
			VolumeScaleReleaseTime = 0f;
			VoiceStealReleaseTime = 0f;
		}
		else
		{
			MaxCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxCount_Offset));
			LimitToOwner = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, LimitToOwner_Offset), 0, LimitToOwner_PropertyAddress.Address);
			ResolutionRule = EnumMarshaler<EMaxConcurrentResolutionRule>.FromNative(IntPtr.Add(nativeStruct, ResolutionRule_Offset), 0, ResolutionRule_PropertyAddress.Address);
			RetriggerTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RetriggerTime_Offset));
			VolumeScaleMode = EnumMarshaler<EConcurrencyVolumeScaleMode>.FromNative(IntPtr.Add(nativeStruct, VolumeScaleMode_Offset), 0, VolumeScaleMode_PropertyAddress.Address);
			VolumeScaleAttackTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VolumeScaleAttackTime_Offset));
			VolumeScaleCanRelease = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, VolumeScaleCanRelease_Offset), 0, VolumeScaleCanRelease_PropertyAddress.Address);
			VolumeScaleReleaseTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VolumeScaleReleaseTime_Offset));
			VoiceStealReleaseTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VoiceStealReleaseTime_Offset));
		}
	}

	static FSoundConcurrencySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundConcurrencySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundConcurrencySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundConcurrencySettings");
		FSoundConcurrencySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		MaxCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxCount");
		MaxCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LimitToOwner_PropertyAddress, intPtr, "bLimitToOwner");
		LimitToOwner_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLimitToOwner");
		LimitToOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLimitToOwner", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ResolutionRule_PropertyAddress, intPtr, "ResolutionRule");
		ResolutionRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ResolutionRule");
		ResolutionRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ResolutionRule", Classes.FByteProperty);
		RetriggerTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RetriggerTime");
		RetriggerTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RetriggerTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VolumeScaleMode_PropertyAddress, intPtr, "VolumeScaleMode");
		VolumeScaleMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeScaleMode");
		VolumeScaleMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeScaleMode", Classes.FEnumProperty);
		VolumeScaleAttackTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeScaleAttackTime");
		VolumeScaleAttackTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeScaleAttackTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VolumeScaleCanRelease_PropertyAddress, intPtr, "bVolumeScaleCanRelease");
		VolumeScaleCanRelease_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVolumeScaleCanRelease");
		VolumeScaleCanRelease_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVolumeScaleCanRelease", Classes.FBoolProperty);
		VolumeScaleReleaseTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeScaleReleaseTime");
		VolumeScaleReleaseTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeScaleReleaseTime", Classes.FFloatProperty);
		VoiceStealReleaseTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VoiceStealReleaseTime");
		VoiceStealReleaseTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VoiceStealReleaseTime", Classes.FFloatProperty);
		FSoundConcurrencySettings_IsValid = intPtr != IntPtr.Zero && MaxCount_IsValid && LimitToOwner_IsValid && ResolutionRule_IsValid && RetriggerTime_IsValid && VolumeScaleMode_IsValid && VolumeScaleAttackTime_IsValid && VolumeScaleCanRelease_IsValid && VolumeScaleReleaseTime_IsValid && VoiceStealReleaseTime_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundConcurrencySettings", FSoundConcurrencySettings_IsValid);
	}
}
