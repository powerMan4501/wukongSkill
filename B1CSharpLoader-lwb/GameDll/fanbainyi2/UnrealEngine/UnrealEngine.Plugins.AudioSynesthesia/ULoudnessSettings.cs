using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioSynesthesia.LoudnessSettings", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public class ULoudnessSettings : UAudioSynesthesiaSettings
{
	private static bool AnalysisPeriod_IsValid;

	private static int AnalysisPeriod_Offset;

	private static bool MinimumFrequency_IsValid;

	private static int MinimumFrequency_Offset;

	private static bool MaximumFrequency_IsValid;

	private static int MaximumFrequency_Offset;

	private static bool CurveType_IsValid;

	private static FFieldAddress CurveType_PropertyAddress;

	private static int CurveType_Offset;

	private static bool NoiseFloorDb_IsValid;

	private static int NoiseFloorDb_Offset;

	private static bool ExpectedMaxLoudness_IsValid;

	private static int ExpectedMaxLoudness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessSettings:AnalysisPeriod")]
	public float AnalysisPeriod
	{
		get
		{
			CheckDestroyed();
			if (!AnalysisPeriod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:AnalysisPeriod");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnalysisPeriod_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnalysisPeriod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:AnalysisPeriod");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnalysisPeriod_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessSettings:MinimumFrequency")]
	public float MinimumFrequency
	{
		get
		{
			CheckDestroyed();
			if (!MinimumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:MinimumFrequency");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumFrequency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:MinimumFrequency");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumFrequency_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessSettings:MaximumFrequency")]
	public float MaximumFrequency
	{
		get
		{
			CheckDestroyed();
			if (!MaximumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:MaximumFrequency");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaximumFrequency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaximumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:MaximumFrequency");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaximumFrequency_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessSettings:CurveType")]
	public ELoudnessCurveTypeEnum CurveType
	{
		get
		{
			CheckDestroyed();
			if (!CurveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:CurveType");
				return ELoudnessCurveTypeEnum.A;
			}
			return EnumMarshaler<ELoudnessCurveTypeEnum>.FromNative(IntPtr.Add(base.Address, CurveType_Offset), 0, CurveType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CurveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:CurveType");
			}
			else
			{
				EnumMarshaler<ELoudnessCurveTypeEnum>.ToNative(IntPtr.Add(base.Address, CurveType_Offset), 0, CurveType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessSettings:NoiseFloorDb")]
	public float NoiseFloorDb
	{
		get
		{
			CheckDestroyed();
			if (!NoiseFloorDb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:NoiseFloorDb");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NoiseFloorDb_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoiseFloorDb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:NoiseFloorDb");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NoiseFloorDb_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessSettings:ExpectedMaxLoudness")]
	public float ExpectedMaxLoudness
	{
		get
		{
			CheckDestroyed();
			if (!ExpectedMaxLoudness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:ExpectedMaxLoudness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ExpectedMaxLoudness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExpectedMaxLoudness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessSettings:ExpectedMaxLoudness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ExpectedMaxLoudness_Offset), value);
			}
		}
	}

	static ULoudnessSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULoudnessSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULoudnessSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AudioSynesthesia.LoudnessSettings");
		AnalysisPeriod_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AnalysisPeriod");
		AnalysisPeriod_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AnalysisPeriod", Classes.FFloatProperty);
		MinimumFrequency_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MinimumFrequency");
		MinimumFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MinimumFrequency", Classes.FFloatProperty);
		MaximumFrequency_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaximumFrequency");
		MaximumFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaximumFrequency", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CurveType_PropertyAddress, unrealStruct, "CurveType");
		CurveType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CurveType");
		CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CurveType", Classes.FEnumProperty);
		NoiseFloorDb_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NoiseFloorDb");
		NoiseFloorDb_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NoiseFloorDb", Classes.FFloatProperty);
		ExpectedMaxLoudness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExpectedMaxLoudness");
		ExpectedMaxLoudness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExpectedMaxLoudness", Classes.FFloatProperty);
	}
}
