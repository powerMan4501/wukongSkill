using System;
using UnrealEngine.AudioAnalyzer;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UClass(Flags = (ClassFlags)818942112uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioSynesthesia.LoudnessAnalyzer", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public class ULoudnessAnalyzer : UAudioAnalyzer
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool OnOverallLoudnessResults_IsValid;

	private static int OnOverallLoudnessResults_Offset;

	private FOnOverallLoudnessResults OnOverallLoudnessResults_DelegateCached;

	private static bool OnPerChannelLoudnessResults_IsValid;

	private static int OnPerChannelLoudnessResults_Offset;

	private FOnPerChannelLoudnessResults OnPerChannelLoudnessResults_DelegateCached;

	private static bool OnLatestOverallLoudnessResults_IsValid;

	private static int OnLatestOverallLoudnessResults_Offset;

	private FOnLatestOverallLoudnessResults OnLatestOverallLoudnessResults_DelegateCached;

	private static bool OnLatestPerChannelLoudnessResults_IsValid;

	private static int OnLatestPerChannelLoudnessResults_Offset;

	private FOnLatestPerChannelLoudnessResults OnLatestPerChannelLoudnessResults_DelegateCached;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessAnalyzer:Settings")]
	public ULoudnessSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessAnalyzer:Settings");
				return null;
			}
			return UObjectMarshaler<ULoudnessSettings>.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessAnalyzer:Settings");
			}
			else
			{
				UObjectMarshaler<ULoudnessSettings>.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessAnalyzer:OnOverallLoudnessResults")]
	public FOnOverallLoudnessResults OnOverallLoudnessResults
	{
		get
		{
			CheckDestroyed();
			if (!OnOverallLoudnessResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessAnalyzer:OnOverallLoudnessResults");
				return new FOnOverallLoudnessResults();
			}
			if (OnOverallLoudnessResults_DelegateCached == null)
			{
				OnOverallLoudnessResults_DelegateCached = new FOnOverallLoudnessResults();
				OnOverallLoudnessResults_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnOverallLoudnessResults_Offset));
			}
			return OnOverallLoudnessResults_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessAnalyzer:OnPerChannelLoudnessResults")]
	public FOnPerChannelLoudnessResults OnPerChannelLoudnessResults
	{
		get
		{
			CheckDestroyed();
			if (!OnPerChannelLoudnessResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessAnalyzer:OnPerChannelLoudnessResults");
				return new FOnPerChannelLoudnessResults();
			}
			if (OnPerChannelLoudnessResults_DelegateCached == null)
			{
				OnPerChannelLoudnessResults_DelegateCached = new FOnPerChannelLoudnessResults();
				OnPerChannelLoudnessResults_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPerChannelLoudnessResults_Offset));
			}
			return OnPerChannelLoudnessResults_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessAnalyzer:OnLatestOverallLoudnessResults")]
	public FOnLatestOverallLoudnessResults OnLatestOverallLoudnessResults
	{
		get
		{
			CheckDestroyed();
			if (!OnLatestOverallLoudnessResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessAnalyzer:OnLatestOverallLoudnessResults");
				return new FOnLatestOverallLoudnessResults();
			}
			if (OnLatestOverallLoudnessResults_DelegateCached == null)
			{
				OnLatestOverallLoudnessResults_DelegateCached = new FOnLatestOverallLoudnessResults();
				OnLatestOverallLoudnessResults_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnLatestOverallLoudnessResults_Offset));
			}
			return OnLatestOverallLoudnessResults_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessAnalyzer:OnLatestPerChannelLoudnessResults")]
	public FOnLatestPerChannelLoudnessResults OnLatestPerChannelLoudnessResults
	{
		get
		{
			CheckDestroyed();
			if (!OnLatestPerChannelLoudnessResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessAnalyzer:OnLatestPerChannelLoudnessResults");
				return new FOnLatestPerChannelLoudnessResults();
			}
			if (OnLatestPerChannelLoudnessResults_DelegateCached == null)
			{
				OnLatestPerChannelLoudnessResults_DelegateCached = new FOnLatestPerChannelLoudnessResults();
				OnLatestPerChannelLoudnessResults_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnLatestPerChannelLoudnessResults_Offset));
			}
			return OnLatestPerChannelLoudnessResults_DelegateCached;
		}
	}

	static ULoudnessAnalyzer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULoudnessAnalyzer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULoudnessAnalyzer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AudioSynesthesia.LoudnessAnalyzer");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Settings", Classes.FObjectProperty);
		OnOverallLoudnessResults_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnOverallLoudnessResults");
		OnOverallLoudnessResults_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnOverallLoudnessResults", Classes.FMulticastDelegateProperty);
		OnPerChannelLoudnessResults_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnPerChannelLoudnessResults");
		OnPerChannelLoudnessResults_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnPerChannelLoudnessResults", Classes.FMulticastDelegateProperty);
		OnLatestOverallLoudnessResults_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnLatestOverallLoudnessResults");
		OnLatestOverallLoudnessResults_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnLatestOverallLoudnessResults", Classes.FMulticastDelegateProperty);
		OnLatestPerChannelLoudnessResults_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnLatestPerChannelLoudnessResults");
		OnLatestPerChannelLoudnessResults_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnLatestPerChannelLoudnessResults", Classes.FMulticastDelegateProperty);
	}
}
