using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectStereoDelaySettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSubmixEffectStereoDelaySettings
{
	private static bool DelayMode_IsValid;

	private static FFieldAddress DelayMode_PropertyAddress;

	private static int DelayMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectStereoDelaySettings:DelayMode")]
	public EStereoDelaySourceEffect DelayMode;

	private static bool DelayTimeMsec_IsValid;

	private static int DelayTimeMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectStereoDelaySettings:DelayTimeMsec")]
	public float DelayTimeMsec;

	private static bool Feedback_IsValid;

	private static int Feedback_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectStereoDelaySettings:Feedback")]
	public float Feedback;

	private static bool DelayRatio_IsValid;

	private static int DelayRatio_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectStereoDelaySettings:DelayRatio")]
	public float DelayRatio;

	private static bool WetLevel_IsValid;

	private static int WetLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectStereoDelaySettings:WetLevel")]
	public float WetLevel;

	private static bool DryLevel_IsValid;

	private static int DryLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectStereoDelaySettings:DryLevel")]
	public float DryLevel;

	private static bool FilterEnabled_IsValid;

	private static FFieldAddress FilterEnabled_PropertyAddress;

	private static int FilterEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectStereoDelaySettings:bFilterEnabled")]
	public bool FilterEnabled;

	private static bool FilterType_IsValid;

	private static FFieldAddress FilterType_PropertyAddress;

	private static int FilterType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectStereoDelaySettings:FilterType")]
	public EStereoDelayFiltertype FilterType;

	private static bool FilterFrequency_IsValid;

	private static int FilterFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectStereoDelaySettings:FilterFrequency")]
	public float FilterFrequency;

	private static bool FilterQ_IsValid;

	private static int FilterQ_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectStereoDelaySettings:FilterQ")]
	public float FilterQ;

	private static bool FSubmixEffectStereoDelaySettings_IsValid;

	private static int FSubmixEffectStereoDelaySettings_StructSize;

	public FSubmixEffectStereoDelaySettings Copy()
	{
		return this;
	}

	public static FSubmixEffectStereoDelaySettings FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectStereoDelaySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectStereoDelaySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectStereoDelaySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectStereoDelaySettings(nativeBuffer + arrayIndex * FSubmixEffectStereoDelaySettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectStereoDelaySettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectStereoDelaySettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectStereoDelaySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectStereoDelaySettings");
			return;
		}
		EnumMarshaler<EStereoDelaySourceEffect>.ToNative(IntPtr.Add(nativeStruct, DelayMode_Offset), 0, DelayMode_PropertyAddress.Address, DelayMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTimeMsec_Offset), DelayTimeMsec);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Feedback_Offset), Feedback);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayRatio_Offset), DelayRatio);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WetLevel_Offset), WetLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DryLevel_Offset), DryLevel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FilterEnabled_Offset), 0, FilterEnabled_PropertyAddress.Address, FilterEnabled);
		EnumMarshaler<EStereoDelayFiltertype>.ToNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address, FilterType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FilterFrequency_Offset), FilterFrequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FilterQ_Offset), FilterQ);
	}

	public FSubmixEffectStereoDelaySettings(IntPtr nativeStruct)
	{
		if (!FSubmixEffectStereoDelaySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectStereoDelaySettings");
			DelayMode = EStereoDelaySourceEffect.Normal;
			DelayTimeMsec = 0f;
			Feedback = 0f;
			DelayRatio = 0f;
			WetLevel = 0f;
			DryLevel = 0f;
			FilterEnabled = false;
			FilterType = EStereoDelayFiltertype.Lowpass;
			FilterFrequency = 0f;
			FilterQ = 0f;
		}
		else
		{
			DelayMode = EnumMarshaler<EStereoDelaySourceEffect>.FromNative(IntPtr.Add(nativeStruct, DelayMode_Offset), 0, DelayMode_PropertyAddress.Address);
			DelayTimeMsec = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTimeMsec_Offset));
			Feedback = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Feedback_Offset));
			DelayRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayRatio_Offset));
			WetLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WetLevel_Offset));
			DryLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DryLevel_Offset));
			FilterEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FilterEnabled_Offset), 0, FilterEnabled_PropertyAddress.Address);
			FilterType = EnumMarshaler<EStereoDelayFiltertype>.FromNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address);
			FilterFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FilterFrequency_Offset));
			FilterQ = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FilterQ_Offset));
		}
	}

	static FSubmixEffectStereoDelaySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectStereoDelaySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectStereoDelaySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SubmixEffectStereoDelaySettings");
		FSubmixEffectStereoDelaySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DelayMode_PropertyAddress, intPtr, "DelayMode");
		DelayMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DelayMode");
		DelayMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DelayMode", Classes.FEnumProperty);
		DelayTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DelayTimeMsec");
		DelayTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DelayTimeMsec", Classes.FFloatProperty);
		Feedback_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Feedback");
		Feedback_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Feedback", Classes.FFloatProperty);
		DelayRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DelayRatio");
		DelayRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DelayRatio", Classes.FFloatProperty);
		WetLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WetLevel");
		WetLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WetLevel", Classes.FFloatProperty);
		DryLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DryLevel");
		DryLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DryLevel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterEnabled_PropertyAddress, intPtr, "bFilterEnabled");
		FilterEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFilterEnabled");
		FilterEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFilterEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterType_PropertyAddress, intPtr, "FilterType");
		FilterType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterType");
		FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterType", Classes.FEnumProperty);
		FilterFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterFrequency");
		FilterFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterFrequency", Classes.FFloatProperty);
		FilterQ_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterQ");
		FilterQ_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterQ", Classes.FFloatProperty);
		FSubmixEffectStereoDelaySettings_IsValid = intPtr != IntPtr.Zero && DelayMode_IsValid && DelayTimeMsec_IsValid && Feedback_IsValid && DelayRatio_IsValid && WetLevel_IsValid && DryLevel_IsValid && FilterEnabled_IsValid && FilterType_IsValid && FilterFrequency_IsValid && FilterQ_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SubmixEffectStereoDelaySettings", FSubmixEffectStereoDelaySettings_IsValid);
	}
}
