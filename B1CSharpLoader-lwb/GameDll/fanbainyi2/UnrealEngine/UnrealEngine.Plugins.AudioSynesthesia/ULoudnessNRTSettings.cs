using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioSynesthesia.LoudnessNRTSettings", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public class ULoudnessNRTSettings : UAudioSynesthesiaNRTSettings
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

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessNRTSettings:AnalysisPeriod")]
	public float AnalysisPeriod
	{
		get
		{
			CheckDestroyed();
			if (!AnalysisPeriod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRTSettings:AnalysisPeriod");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AnalysisPeriod_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnalysisPeriod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRTSettings:AnalysisPeriod");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AnalysisPeriod_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessNRTSettings:MinimumFrequency")]
	public float MinimumFrequency
	{
		get
		{
			CheckDestroyed();
			if (!MinimumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRTSettings:MinimumFrequency");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumFrequency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRTSettings:MinimumFrequency");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumFrequency_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessNRTSettings:MaximumFrequency")]
	public float MaximumFrequency
	{
		get
		{
			CheckDestroyed();
			if (!MaximumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRTSettings:MaximumFrequency");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaximumFrequency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaximumFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRTSettings:MaximumFrequency");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaximumFrequency_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessNRTSettings:CurveType")]
	public ELoudnessNRTCurveTypeEnum CurveType
	{
		get
		{
			CheckDestroyed();
			if (!CurveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRTSettings:CurveType");
				return ELoudnessNRTCurveTypeEnum.A;
			}
			return EnumMarshaler<ELoudnessNRTCurveTypeEnum>.FromNative(IntPtr.Add(base.Address, CurveType_Offset), 0, CurveType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CurveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRTSettings:CurveType");
			}
			else
			{
				EnumMarshaler<ELoudnessNRTCurveTypeEnum>.ToNative(IntPtr.Add(base.Address, CurveType_Offset), 0, CurveType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessNRTSettings:NoiseFloorDb")]
	public float NoiseFloorDb
	{
		get
		{
			CheckDestroyed();
			if (!NoiseFloorDb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRTSettings:NoiseFloorDb");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NoiseFloorDb_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoiseFloorDb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioSynesthesia.LoudnessNRTSettings:NoiseFloorDb");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NoiseFloorDb_Offset), value);
			}
		}
	}

	static ULoudnessNRTSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULoudnessNRTSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULoudnessNRTSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AudioSynesthesia.LoudnessNRTSettings");
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
	}
}
