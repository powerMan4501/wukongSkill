using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.AudioImpulseResponse", "Synthesis", UnrealModuleType.EnginePlugin)]
public class UAudioImpulseResponse : UObject
{
	private static bool NormalizationVolumeDb_IsValid;

	private static int NormalizationVolumeDb_Offset;

	private static bool TrueStereo_IsValid;

	private static FFieldAddress TrueStereo_PropertyAddress;

	private static int TrueStereo_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.AudioImpulseResponse:NormalizationVolumeDb")]
	public float NormalizationVolumeDb
	{
		get
		{
			CheckDestroyed();
			if (!NormalizationVolumeDb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.AudioImpulseResponse:NormalizationVolumeDb");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NormalizationVolumeDb_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalizationVolumeDb_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.AudioImpulseResponse:NormalizationVolumeDb");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NormalizationVolumeDb_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.AudioImpulseResponse:bTrueStereo")]
	public bool TrueStereo
	{
		get
		{
			CheckDestroyed();
			if (!TrueStereo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.AudioImpulseResponse:bTrueStereo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TrueStereo_Offset), 0, TrueStereo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TrueStereo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.AudioImpulseResponse:bTrueStereo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TrueStereo_Offset), 0, TrueStereo_PropertyAddress.Address, value);
			}
		}
	}

	static UAudioImpulseResponse()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAudioImpulseResponse)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAudioImpulseResponse));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Synthesis.AudioImpulseResponse");
		NormalizationVolumeDb_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NormalizationVolumeDb");
		NormalizationVolumeDb_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NormalizationVolumeDb", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TrueStereo_PropertyAddress, unrealStruct, "bTrueStereo");
		TrueStereo_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bTrueStereo");
		TrueStereo_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bTrueStereo", Classes.FBoolProperty);
	}
}
