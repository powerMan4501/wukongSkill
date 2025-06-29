using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioSynesthesia.MeterSettings", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public class UMeterSettings : UAudioSynesthesiaSettings
{
	private static bool AnalysisPeriod_IsValid;

	private static int AnalysisPeriod_Offset;

	private static bool PeakMode_IsValid;

	private static FFieldAddress PeakMode_PropertyAddress;

	private static int PeakMode_Offset;

	private static bool MeterAttackTime_IsValid;

	private static int MeterAttackTime_Offset;

	private static bool MeterReleaseTime_IsValid;

	private static int MeterReleaseTime_Offset;

	private static bool PeakHoldTime_IsValid;

	private static int PeakHoldTime_Offset;

	private static bool ClippingThreshold_IsValid;

	private static int ClippingThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterSettings:AnalysisPeriod")]
	public float AnalysisPeriod
	{
		get
		{
			CheckDestroyed();
			if (!AnalysisPeriod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:AnalysisPeriod");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnalysisPeriod_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnalysisPeriod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:AnalysisPeriod");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnalysisPeriod_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterSettings:PeakMode")]
	public EMeterPeakType PeakMode
	{
		get
		{
			CheckDestroyed();
			if (!PeakMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:PeakMode");
				return EMeterPeakType.MeanSquared;
			}
			return EnumMarshaler<EMeterPeakType>.FromNative(IntPtr.Add(base.Address, PeakMode_Offset), 0, PeakMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PeakMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:PeakMode");
			}
			else
			{
				EnumMarshaler<EMeterPeakType>.ToNative(IntPtr.Add(base.Address, PeakMode_Offset), 0, PeakMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterSettings:MeterAttackTime")]
	public int MeterAttackTime
	{
		get
		{
			CheckDestroyed();
			if (!MeterAttackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:MeterAttackTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MeterAttackTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeterAttackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:MeterAttackTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MeterAttackTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterSettings:MeterReleaseTime")]
	public int MeterReleaseTime
	{
		get
		{
			CheckDestroyed();
			if (!MeterReleaseTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:MeterReleaseTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MeterReleaseTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeterReleaseTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:MeterReleaseTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MeterReleaseTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterSettings:PeakHoldTime")]
	public int PeakHoldTime
	{
		get
		{
			CheckDestroyed();
			if (!PeakHoldTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:PeakHoldTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PeakHoldTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PeakHoldTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:PeakHoldTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PeakHoldTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterSettings:ClippingThreshold")]
	public float ClippingThreshold
	{
		get
		{
			CheckDestroyed();
			if (!ClippingThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:ClippingThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ClippingThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ClippingThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterSettings:ClippingThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ClippingThreshold_Offset), value);
			}
		}
	}

	static UMeterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMeterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMeterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AudioSynesthesia.MeterSettings");
		AnalysisPeriod_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AnalysisPeriod");
		AnalysisPeriod_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AnalysisPeriod", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PeakMode_PropertyAddress, unrealStruct, "PeakMode");
		PeakMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PeakMode");
		PeakMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PeakMode", Classes.FEnumProperty);
		MeterAttackTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MeterAttackTime");
		MeterAttackTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MeterAttackTime", Classes.FIntProperty);
		MeterReleaseTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MeterReleaseTime");
		MeterReleaseTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MeterReleaseTime", Classes.FIntProperty);
		PeakHoldTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PeakHoldTime");
		PeakHoldTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PeakHoldTime", Classes.FIntProperty);
		ClippingThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ClippingThreshold");
		ClippingThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ClippingThreshold", Classes.FFloatProperty);
	}
}
