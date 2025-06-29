using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AudioSynesthesia.MeterResults", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public struct FMeterResults
{
	private static bool TimeSeconds_IsValid;

	private static int TimeSeconds_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterResults:TimeSeconds")]
	public float TimeSeconds;

	private static bool MeterValue_IsValid;

	private static int MeterValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterResults:MeterValue")]
	public float MeterValue;

	private static bool PeakValue_IsValid;

	private static int PeakValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterResults:PeakValue")]
	public float PeakValue;

	private static bool NumSamplesClipping_IsValid;

	private static int NumSamplesClipping_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterResults:NumSamplesClipping")]
	public int NumSamplesClipping;

	private static bool ClippingValue_IsValid;

	private static int ClippingValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterResults:ClippingValue")]
	public float ClippingValue;

	private static bool FMeterResults_IsValid;

	private static int FMeterResults_StructSize;

	public FMeterResults Copy()
	{
		return this;
	}

	public static FMeterResults FromNative(IntPtr nativeBuffer)
	{
		return new FMeterResults(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMeterResults value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMeterResults FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMeterResults(nativeBuffer + arrayIndex * FMeterResults_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMeterResults value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMeterResults_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMeterResults_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioSynesthesia.MeterResults");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TimeSeconds_Offset), TimeSeconds);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MeterValue_Offset), MeterValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PeakValue_Offset), PeakValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumSamplesClipping_Offset), NumSamplesClipping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ClippingValue_Offset), ClippingValue);
	}

	public FMeterResults(IntPtr nativeStruct)
	{
		if (!FMeterResults_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioSynesthesia.MeterResults");
			TimeSeconds = 0f;
			MeterValue = 0f;
			PeakValue = 0f;
			NumSamplesClipping = 0;
			ClippingValue = 0f;
		}
		else
		{
			TimeSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TimeSeconds_Offset));
			MeterValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MeterValue_Offset));
			PeakValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PeakValue_Offset));
			NumSamplesClipping = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumSamplesClipping_Offset));
			ClippingValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ClippingValue_Offset));
		}
	}

	static FMeterResults()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMeterResults)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeterResults));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AudioSynesthesia.MeterResults");
		FMeterResults_StructSize = NativeReflection.GetStructSize(intPtr);
		TimeSeconds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TimeSeconds");
		TimeSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TimeSeconds", Classes.FFloatProperty);
		MeterValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeterValue");
		MeterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeterValue", Classes.FFloatProperty);
		PeakValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PeakValue");
		PeakValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PeakValue", Classes.FFloatProperty);
		NumSamplesClipping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumSamplesClipping");
		NumSamplesClipping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumSamplesClipping", Classes.FIntProperty);
		ClippingValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClippingValue");
		ClippingValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClippingValue", Classes.FFloatProperty);
		FMeterResults_IsValid = intPtr != IntPtr.Zero && TimeSeconds_IsValid && MeterValue_IsValid && PeakValue_IsValid && NumSamplesClipping_IsValid && ClippingValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/AudioSynesthesia.MeterResults", FMeterResults_IsValid);
	}
}
