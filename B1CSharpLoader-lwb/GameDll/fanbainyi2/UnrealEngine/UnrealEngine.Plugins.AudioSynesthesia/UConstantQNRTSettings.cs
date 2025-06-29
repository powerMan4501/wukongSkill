using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public class UConstantQNRTSettings : UAudioSynesthesiaNRTSettings
{
	private static bool StartingFrequency_IsValid;

	private static int StartingFrequency_Offset;

	private static bool NumBands_IsValid;

	private static int NumBands_Offset;

	private static bool NumBandsPerOctave_IsValid;

	private static int NumBandsPerOctave_Offset;

	private static bool AnalysisPeriod_IsValid;

	private static int AnalysisPeriod_Offset;

	private static bool DownmixToMono_IsValid;

	private static FFieldAddress DownmixToMono_PropertyAddress;

	private static int DownmixToMono_Offset;

	private static bool FFTSize_IsValid;

	private static FFieldAddress FFTSize_PropertyAddress;

	private static int FFTSize_Offset;

	private static bool WindowType_IsValid;

	private static FFieldAddress WindowType_PropertyAddress;

	private static int WindowType_Offset;

	private static bool SpectrumType_IsValid;

	private static FFieldAddress SpectrumType_PropertyAddress;

	private static int SpectrumType_Offset;

	private static bool BandWidthStretch_IsValid;

	private static int BandWidthStretch_Offset;

	private static bool CQTNormalization_IsValid;

	private static FFieldAddress CQTNormalization_PropertyAddress;

	private static int CQTNormalization_Offset;

	private static bool NoiseFloorDb_IsValid;

	private static int NoiseFloorDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings:StartingFrequency")]
	public float StartingFrequency
	{
		get
		{
			CheckDestroyed();
			if (!StartingFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:StartingFrequency");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartingFrequency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartingFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:StartingFrequency");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartingFrequency_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings:NumBands")]
	public int NumBands
	{
		get
		{
			CheckDestroyed();
			if (!NumBands_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:NumBands");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumBands_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumBands_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:NumBands");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumBands_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings:NumBandsPerOctave")]
	public float NumBandsPerOctave
	{
		get
		{
			CheckDestroyed();
			if (!NumBandsPerOctave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:NumBandsPerOctave");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NumBandsPerOctave_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumBandsPerOctave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:NumBandsPerOctave");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NumBandsPerOctave_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings:AnalysisPeriod")]
	public float AnalysisPeriod
	{
		get
		{
			CheckDestroyed();
			if (!AnalysisPeriod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:AnalysisPeriod");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnalysisPeriod_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnalysisPeriod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:AnalysisPeriod");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnalysisPeriod_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings:bDownmixToMono")]
	public bool DownmixToMono
	{
		get
		{
			CheckDestroyed();
			if (!DownmixToMono_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:bDownmixToMono");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DownmixToMono_Offset), 0, DownmixToMono_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DownmixToMono_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:bDownmixToMono");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DownmixToMono_Offset), 0, DownmixToMono_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings:FFTSize")]
	public EConstantQFFTSizeEnum FFTSize
	{
		get
		{
			CheckDestroyed();
			if (!FFTSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:FFTSize");
				return EConstantQFFTSizeEnum.Min;
			}
			return EnumMarshaler<EConstantQFFTSizeEnum>.FromNative(IntPtr.Add(base.Address, FFTSize_Offset), 0, FFTSize_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FFTSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:FFTSize");
			}
			else
			{
				EnumMarshaler<EConstantQFFTSizeEnum>.ToNative(IntPtr.Add(base.Address, FFTSize_Offset), 0, FFTSize_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings:WindowType")]
	public EFFTWindowType WindowType
	{
		get
		{
			CheckDestroyed();
			if (!WindowType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:WindowType");
				return EFFTWindowType.None;
			}
			return EnumMarshaler<EFFTWindowType>.FromNative(IntPtr.Add(base.Address, WindowType_Offset), 0, WindowType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WindowType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:WindowType");
			}
			else
			{
				EnumMarshaler<EFFTWindowType>.ToNative(IntPtr.Add(base.Address, WindowType_Offset), 0, WindowType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings:SpectrumType")]
	public EAudioSpectrumType SpectrumType
	{
		get
		{
			CheckDestroyed();
			if (!SpectrumType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:SpectrumType");
				return EAudioSpectrumType.MagnitudeSpectrum;
			}
			return EnumMarshaler<EAudioSpectrumType>.FromNative(IntPtr.Add(base.Address, SpectrumType_Offset), 0, SpectrumType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpectrumType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:SpectrumType");
			}
			else
			{
				EnumMarshaler<EAudioSpectrumType>.ToNative(IntPtr.Add(base.Address, SpectrumType_Offset), 0, SpectrumType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings:BandWidthStretch")]
	public float BandWidthStretch
	{
		get
		{
			CheckDestroyed();
			if (!BandWidthStretch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:BandWidthStretch");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BandWidthStretch_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BandWidthStretch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:BandWidthStretch");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BandWidthStretch_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings:CQTNormalization")]
	public EConstantQNormalizationEnum CQTNormalization
	{
		get
		{
			CheckDestroyed();
			if (!CQTNormalization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:CQTNormalization");
				return EConstantQNormalizationEnum.EqualEuclideanNorm;
			}
			return EnumMarshaler<EConstantQNormalizationEnum>.FromNative(IntPtr.Add(base.Address, CQTNormalization_Offset), 0, CQTNormalization_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CQTNormalization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:CQTNormalization");
			}
			else
			{
				EnumMarshaler<EConstantQNormalizationEnum>.ToNative(IntPtr.Add(base.Address, CQTNormalization_Offset), 0, CQTNormalization_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/AudioSynesthesia.ConstantQNRTSettings:NoiseFloorDb")]
	public float NoiseFloorDb
	{
		get
		{
			CheckDestroyed();
			if (!NoiseFloorDb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:NoiseFloorDb");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NoiseFloorDb_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoiseFloorDb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.ConstantQNRTSettings:NoiseFloorDb");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NoiseFloorDb_Offset), value);
			}
		}
	}

	static UConstantQNRTSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UConstantQNRTSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UConstantQNRTSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AudioSynesthesia.ConstantQNRTSettings");
		StartingFrequency_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StartingFrequency");
		StartingFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StartingFrequency", Classes.FFloatProperty);
		NumBands_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NumBands");
		NumBands_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NumBands", Classes.FIntProperty);
		NumBandsPerOctave_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NumBandsPerOctave");
		NumBandsPerOctave_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NumBandsPerOctave", Classes.FFloatProperty);
		AnalysisPeriod_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AnalysisPeriod");
		AnalysisPeriod_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AnalysisPeriod", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DownmixToMono_PropertyAddress, unrealStruct, "bDownmixToMono");
		DownmixToMono_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDownmixToMono");
		DownmixToMono_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDownmixToMono", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FFTSize_PropertyAddress, unrealStruct, "FFTSize");
		FFTSize_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FFTSize");
		FFTSize_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FFTSize", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref WindowType_PropertyAddress, unrealStruct, "WindowType");
		WindowType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WindowType");
		WindowType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WindowType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SpectrumType_PropertyAddress, unrealStruct, "SpectrumType");
		SpectrumType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpectrumType");
		SpectrumType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpectrumType", Classes.FEnumProperty);
		BandWidthStretch_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BandWidthStretch");
		BandWidthStretch_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BandWidthStretch", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CQTNormalization_PropertyAddress, unrealStruct, "CQTNormalization");
		CQTNormalization_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CQTNormalization");
		CQTNormalization_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CQTNormalization", Classes.FEnumProperty);
		NoiseFloorDb_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NoiseFloorDb");
		NoiseFloorDb_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NoiseFloorDb", Classes.FFloatProperty);
	}
}
