using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioSynesthesia.OnsetNRTSettings", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public class UOnsetNRTSettings : UAudioSynesthesiaNRTSettings
{
	private static bool DownmixToMono_IsValid;

	private static FFieldAddress DownmixToMono_PropertyAddress;

	private static int DownmixToMono_Offset;

	private static bool GranularityInSeconds_IsValid;

	private static int GranularityInSeconds_Offset;

	private static bool Sensitivity_IsValid;

	private static int Sensitivity_Offset;

	private static bool MinimumFrequency_IsValid;

	private static int MinimumFrequency_Offset;

	private static bool MaximumFrequency_IsValid;

	private static int MaximumFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.OnsetNRTSettings:bDownmixToMono")]
	public bool DownmixToMono
	{
		get
		{
			CheckDestroyed();
			if (!DownmixToMono_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRTSettings:bDownmixToMono");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DownmixToMono_Offset), 0, DownmixToMono_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DownmixToMono_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRTSettings:bDownmixToMono");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DownmixToMono_Offset), 0, DownmixToMono_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.OnsetNRTSettings:GranularityInSeconds")]
	public float GranularityInSeconds
	{
		get
		{
			CheckDestroyed();
			if (!GranularityInSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRTSettings:GranularityInSeconds");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GranularityInSeconds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GranularityInSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRTSettings:GranularityInSeconds");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GranularityInSeconds_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.OnsetNRTSettings:Sensitivity")]
	public float Sensitivity
	{
		get
		{
			CheckDestroyed();
			if (!Sensitivity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRTSettings:Sensitivity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Sensitivity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Sensitivity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRTSettings:Sensitivity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Sensitivity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.OnsetNRTSettings:MinimumFrequency")]
	public float MinimumFrequency
	{
		get
		{
			CheckDestroyed();
			if (!MinimumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRTSettings:MinimumFrequency");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumFrequency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRTSettings:MinimumFrequency");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumFrequency_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.OnsetNRTSettings:MaximumFrequency")]
	public float MaximumFrequency
	{
		get
		{
			CheckDestroyed();
			if (!MaximumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRTSettings:MaximumFrequency");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaximumFrequency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaximumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.OnsetNRTSettings:MaximumFrequency");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaximumFrequency_Offset), value);
			}
		}
	}

	static UOnsetNRTSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOnsetNRTSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOnsetNRTSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AudioSynesthesia.OnsetNRTSettings");
		NativeReflectionCached.GetPropertyRef(ref DownmixToMono_PropertyAddress, unrealStruct, "bDownmixToMono");
		DownmixToMono_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDownmixToMono");
		DownmixToMono_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDownmixToMono", Classes.FBoolProperty);
		GranularityInSeconds_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GranularityInSeconds");
		GranularityInSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GranularityInSeconds", Classes.FFloatProperty);
		Sensitivity_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Sensitivity");
		Sensitivity_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Sensitivity", Classes.FFloatProperty);
		MinimumFrequency_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MinimumFrequency");
		MinimumFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MinimumFrequency", Classes.FFloatProperty);
		MaximumFrequency_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaximumFrequency");
		MaximumFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaximumFrequency", Classes.FFloatProperty);
	}
}
