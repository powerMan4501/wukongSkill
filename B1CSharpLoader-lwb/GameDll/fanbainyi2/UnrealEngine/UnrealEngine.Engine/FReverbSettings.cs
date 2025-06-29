using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/Engine.ReverbSettings", "Engine", UnrealModuleType.Engine)]
public struct FReverbSettings
{
	private static bool ApplyReverb_IsValid;

	private static FFieldAddress ApplyReverb_PropertyAddress;

	private static int ApplyReverb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ReverbSettings:bApplyReverb")]
	public bool ApplyReverb;

	private static bool ReverbEffect_IsValid;

	private static int ReverbEffect_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.ReverbSettings:ReverbEffect")]
	public UReverbEffect ReverbEffect;

	private static bool ReverbPluginEffect_IsValid;

	private static int ReverbPluginEffect_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.ReverbSettings:ReverbPluginEffect")]
	public USoundEffectSubmixPreset ReverbPluginEffect;

	private static bool Volume_IsValid;

	private static int Volume_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ReverbSettings:Volume")]
	public float Volume;

	private static bool FadeTime_IsValid;

	private static int FadeTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ReverbSettings:FadeTime")]
	public float FadeTime;

	private static bool FReverbSettings_IsValid;

	private static int FReverbSettings_StructSize;

	public FReverbSettings Copy()
	{
		return this;
	}

	public static FReverbSettings FromNative(IntPtr nativeBuffer)
	{
		return new FReverbSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FReverbSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FReverbSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FReverbSettings(nativeBuffer + arrayIndex * FReverbSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FReverbSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FReverbSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FReverbSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ReverbSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyReverb_Offset), 0, ApplyReverb_PropertyAddress.Address, ApplyReverb);
		UObjectMarshaler<UReverbEffect>.ToNative(IntPtr.Add(nativeStruct, ReverbEffect_Offset), ReverbEffect);
		UObjectMarshaler<USoundEffectSubmixPreset>.ToNative(IntPtr.Add(nativeStruct, ReverbPluginEffect_Offset), ReverbPluginEffect);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Volume_Offset), Volume);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FadeTime_Offset), FadeTime);
	}

	public FReverbSettings(IntPtr nativeStruct)
	{
		if (!FReverbSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ReverbSettings");
			ApplyReverb = false;
			ReverbEffect = null;
			ReverbPluginEffect = null;
			Volume = 0f;
			FadeTime = 0f;
		}
		else
		{
			ApplyReverb = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyReverb_Offset), 0, ApplyReverb_PropertyAddress.Address);
			ReverbEffect = UObjectMarshaler<UReverbEffect>.FromNative(IntPtr.Add(nativeStruct, ReverbEffect_Offset));
			ReverbPluginEffect = UObjectMarshaler<USoundEffectSubmixPreset>.FromNative(IntPtr.Add(nativeStruct, ReverbPluginEffect_Offset));
			Volume = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Volume_Offset));
			FadeTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FadeTime_Offset));
		}
	}

	static FReverbSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FReverbSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FReverbSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ReverbSettings");
		FReverbSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ApplyReverb_PropertyAddress, intPtr, "bApplyReverb");
		ApplyReverb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyReverb");
		ApplyReverb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyReverb", Classes.FBoolProperty);
		ReverbEffect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReverbEffect");
		ReverbEffect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReverbEffect", Classes.FObjectProperty);
		ReverbPluginEffect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReverbPluginEffect");
		ReverbPluginEffect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReverbPluginEffect", Classes.FObjectProperty);
		Volume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Volume");
		Volume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Volume", Classes.FFloatProperty);
		FadeTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FadeTime");
		FadeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FadeTime", Classes.FFloatProperty);
		FReverbSettings_IsValid = intPtr != IntPtr.Zero && ApplyReverb_IsValid && ReverbEffect_IsValid && ReverbPluginEffect_IsValid && Volume_IsValid && FadeTime_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ReverbSettings", FReverbSettings_IsValid);
	}
}
