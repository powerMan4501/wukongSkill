using System;
using UnrealEngine.AudioAnalyzer;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UClass(Flags = (ClassFlags)818942112uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioSynesthesia.MeterAnalyzer", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public class UMeterAnalyzer : UAudioAnalyzer
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool OnOverallMeterResults_IsValid;

	private static int OnOverallMeterResults_Offset;

	private FOnOverallMeterResults OnOverallMeterResults_DelegateCached;

	private static bool OnPerChannelMeterResults_IsValid;

	private static int OnPerChannelMeterResults_Offset;

	private FOnPerChannelMeterResults OnPerChannelMeterResults_DelegateCached;

	private static bool OnLatestOverallMeterResults_IsValid;

	private static int OnLatestOverallMeterResults_Offset;

	private FOnLatestOverallMeterResults OnLatestOverallMeterResults_DelegateCached;

	private static bool OnLatestPerChannelMeterResults_IsValid;

	private static int OnLatestPerChannelMeterResults_Offset;

	private FOnLatestPerChannelMeterResults OnLatestPerChannelMeterResults_DelegateCached;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterAnalyzer:Settings")]
	public UMeterSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterAnalyzer:Settings");
				return null;
			}
			return UObjectMarshaler<UMeterSettings>.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterAnalyzer:Settings");
			}
			else
			{
				UObjectMarshaler<UMeterSettings>.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterAnalyzer:OnOverallMeterResults")]
	public FOnOverallMeterResults OnOverallMeterResults
	{
		get
		{
			CheckDestroyed();
			if (!OnOverallMeterResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterAnalyzer:OnOverallMeterResults");
				return new FOnOverallMeterResults();
			}
			if (OnOverallMeterResults_DelegateCached == null)
			{
				OnOverallMeterResults_DelegateCached = new FOnOverallMeterResults();
				OnOverallMeterResults_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnOverallMeterResults_Offset));
			}
			return OnOverallMeterResults_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterAnalyzer:OnPerChannelMeterResults")]
	public FOnPerChannelMeterResults OnPerChannelMeterResults
	{
		get
		{
			CheckDestroyed();
			if (!OnPerChannelMeterResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterAnalyzer:OnPerChannelMeterResults");
				return new FOnPerChannelMeterResults();
			}
			if (OnPerChannelMeterResults_DelegateCached == null)
			{
				OnPerChannelMeterResults_DelegateCached = new FOnPerChannelMeterResults();
				OnPerChannelMeterResults_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPerChannelMeterResults_Offset));
			}
			return OnPerChannelMeterResults_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterAnalyzer:OnLatestOverallMeterResults")]
	public FOnLatestOverallMeterResults OnLatestOverallMeterResults
	{
		get
		{
			CheckDestroyed();
			if (!OnLatestOverallMeterResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterAnalyzer:OnLatestOverallMeterResults");
				return new FOnLatestOverallMeterResults();
			}
			if (OnLatestOverallMeterResults_DelegateCached == null)
			{
				OnLatestOverallMeterResults_DelegateCached = new FOnLatestOverallMeterResults();
				OnLatestOverallMeterResults_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnLatestOverallMeterResults_Offset));
			}
			return OnLatestOverallMeterResults_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AudioSynesthesia.MeterAnalyzer:OnLatestPerChannelMeterResults")]
	public FOnLatestPerChannelMeterResults OnLatestPerChannelMeterResults
	{
		get
		{
			CheckDestroyed();
			if (!OnLatestPerChannelMeterResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.MeterAnalyzer:OnLatestPerChannelMeterResults");
				return new FOnLatestPerChannelMeterResults();
			}
			if (OnLatestPerChannelMeterResults_DelegateCached == null)
			{
				OnLatestPerChannelMeterResults_DelegateCached = new FOnLatestPerChannelMeterResults();
				OnLatestPerChannelMeterResults_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnLatestPerChannelMeterResults_Offset));
			}
			return OnLatestPerChannelMeterResults_DelegateCached;
		}
	}

	static UMeterAnalyzer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMeterAnalyzer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMeterAnalyzer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AudioSynesthesia.MeterAnalyzer");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Settings", Classes.FObjectProperty);
		OnOverallMeterResults_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnOverallMeterResults");
		OnOverallMeterResults_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnOverallMeterResults", Classes.FMulticastDelegateProperty);
		OnPerChannelMeterResults_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnPerChannelMeterResults");
		OnPerChannelMeterResults_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnPerChannelMeterResults", Classes.FMulticastDelegateProperty);
		OnLatestOverallMeterResults_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnLatestOverallMeterResults");
		OnLatestOverallMeterResults_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnLatestOverallMeterResults", Classes.FMulticastDelegateProperty);
		OnLatestPerChannelMeterResults_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnLatestPerChannelMeterResults");
		OnLatestPerChannelMeterResults_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnLatestPerChannelMeterResults", Classes.FMulticastDelegateProperty);
	}
}
