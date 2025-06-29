using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundClassAdjuster", "Engine", UnrealModuleType.Engine)]
public struct FSoundClassAdjuster
{
	private static bool SoundClassObject_IsValid;

	private static int SoundClassObject_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.SoundClassAdjuster:SoundClassObject")]
	public USoundClass SoundClassObject;

	private static bool VolumeAdjuster_IsValid;

	private static int VolumeAdjuster_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassAdjuster:VolumeAdjuster")]
	public float VolumeAdjuster;

	private static bool PitchAdjuster_IsValid;

	private static int PitchAdjuster_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassAdjuster:PitchAdjuster")]
	public float PitchAdjuster;

	private static bool LowPassFilterFrequency_IsValid;

	private static int LowPassFilterFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassAdjuster:LowPassFilterFrequency")]
	public float LowPassFilterFrequency;

	private static bool ApplyToChildren_IsValid;

	private static FFieldAddress ApplyToChildren_PropertyAddress;

	private static int ApplyToChildren_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.SoundClassAdjuster:bApplyToChildren")]
	public bool ApplyToChildren;

	private static bool VoiceCenterChannelVolumeAdjuster_IsValid;

	private static int VoiceCenterChannelVolumeAdjuster_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassAdjuster:VoiceCenterChannelVolumeAdjuster")]
	public float VoiceCenterChannelVolumeAdjuster;

	private static bool FSoundClassAdjuster_IsValid;

	private static int FSoundClassAdjuster_StructSize;

	public FSoundClassAdjuster Copy()
	{
		return this;
	}

	public static FSoundClassAdjuster FromNative(IntPtr nativeBuffer)
	{
		return new FSoundClassAdjuster(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundClassAdjuster value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundClassAdjuster FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundClassAdjuster(nativeBuffer + arrayIndex * FSoundClassAdjuster_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundClassAdjuster value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundClassAdjuster_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundClassAdjuster_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundClassAdjuster");
			return;
		}
		UObjectMarshaler<USoundClass>.ToNative(IntPtr.Add(nativeStruct, SoundClassObject_Offset), SoundClassObject);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VolumeAdjuster_Offset), VolumeAdjuster);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PitchAdjuster_Offset), PitchAdjuster);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LowPassFilterFrequency_Offset), LowPassFilterFrequency);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyToChildren_Offset), 0, ApplyToChildren_PropertyAddress.Address, ApplyToChildren);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VoiceCenterChannelVolumeAdjuster_Offset), VoiceCenterChannelVolumeAdjuster);
	}

	public FSoundClassAdjuster(IntPtr nativeStruct)
	{
		if (!FSoundClassAdjuster_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundClassAdjuster");
			SoundClassObject = null;
			VolumeAdjuster = 0f;
			PitchAdjuster = 0f;
			LowPassFilterFrequency = 0f;
			ApplyToChildren = false;
			VoiceCenterChannelVolumeAdjuster = 0f;
		}
		else
		{
			SoundClassObject = UObjectMarshaler<USoundClass>.FromNative(IntPtr.Add(nativeStruct, SoundClassObject_Offset));
			VolumeAdjuster = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VolumeAdjuster_Offset));
			PitchAdjuster = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PitchAdjuster_Offset));
			LowPassFilterFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LowPassFilterFrequency_Offset));
			ApplyToChildren = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyToChildren_Offset), 0, ApplyToChildren_PropertyAddress.Address);
			VoiceCenterChannelVolumeAdjuster = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VoiceCenterChannelVolumeAdjuster_Offset));
		}
	}

	static FSoundClassAdjuster()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundClassAdjuster)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundClassAdjuster));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundClassAdjuster");
		FSoundClassAdjuster_StructSize = NativeReflection.GetStructSize(intPtr);
		SoundClassObject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoundClassObject");
		SoundClassObject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoundClassObject", Classes.FObjectProperty);
		VolumeAdjuster_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeAdjuster");
		VolumeAdjuster_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeAdjuster", Classes.FFloatProperty);
		PitchAdjuster_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PitchAdjuster");
		PitchAdjuster_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PitchAdjuster", Classes.FFloatProperty);
		LowPassFilterFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowPassFilterFrequency");
		LowPassFilterFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowPassFilterFrequency", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyToChildren_PropertyAddress, intPtr, "bApplyToChildren");
		ApplyToChildren_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyToChildren");
		ApplyToChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyToChildren", Classes.FBoolProperty);
		VoiceCenterChannelVolumeAdjuster_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VoiceCenterChannelVolumeAdjuster");
		VoiceCenterChannelVolumeAdjuster_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VoiceCenterChannelVolumeAdjuster", Classes.FFloatProperty);
		FSoundClassAdjuster_IsValid = intPtr != IntPtr.Zero && SoundClassObject_IsValid && VolumeAdjuster_IsValid && PitchAdjuster_IsValid && LowPassFilterFrequency_IsValid && ApplyToChildren_IsValid && VoiceCenterChannelVolumeAdjuster_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundClassAdjuster", FSoundClassAdjuster_IsValid);
	}
}
