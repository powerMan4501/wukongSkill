using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSRTAvatarConfigPreset", "UnrealExtent", UnrealModuleType.Game)]
public class UGSRTAvatarConfigPreset : UPrimaryDataAsset
{
	private static bool HeroActorBPPath_IsValid;

	private static int HeroActorBPPath_Offset;

	private static bool HeroTransform_IsValid;

	private static int HeroTransform_Offset;

	private static bool RTCamTransform_IsValid;

	private static int RTCamTransform_Offset;

	private static bool RTCamFOV_IsValid;

	private static int RTCamFOV_Offset;

	private static bool LightConfigs_IsValid;

	private static FFieldAddress LightConfigs_PropertyAddress;

	private static int LightConfigs_Offset;

	private TArrayReadWriteMarshaler<FRTAvatarRectLightConfig> LightConfigs_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.GSRTAvatarConfigPreset:HeroActorBPPath")]
	public string HeroActorBPPath
	{
		get
		{
			CheckDestroyed();
			if (!HeroActorBPPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRTAvatarConfigPreset:HeroActorBPPath");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, HeroActorBPPath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeroActorBPPath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRTAvatarConfigPreset:HeroActorBPPath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, HeroActorBPPath_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/UnrealExtent.GSRTAvatarConfigPreset:HeroTransform")]
	public FTransform HeroTransform
	{
		get
		{
			CheckDestroyed();
			if (!HeroTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRTAvatarConfigPreset:HeroTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, HeroTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeroTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRTAvatarConfigPreset:HeroTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, HeroTransform_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/UnrealExtent.GSRTAvatarConfigPreset:RTCamTransform")]
	public FTransform RTCamTransform
	{
		get
		{
			CheckDestroyed();
			if (!RTCamTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRTAvatarConfigPreset:RTCamTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, RTCamTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RTCamTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRTAvatarConfigPreset:RTCamTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, RTCamTransform_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSRTAvatarConfigPreset:RTCamFOV")]
	public float RTCamFOV
	{
		get
		{
			CheckDestroyed();
			if (!RTCamFOV_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRTAvatarConfigPreset:RTCamFOV");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RTCamFOV_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RTCamFOV_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRTAvatarConfigPreset:RTCamFOV");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RTCamFOV_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/UnrealExtent.GSRTAvatarConfigPreset:LightConfigs")]
	public TArrayReadWrite<FRTAvatarRectLightConfig> LightConfigs
	{
		get
		{
			CheckDestroyed();
			if (!LightConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRTAvatarConfigPreset:LightConfigs");
				return null;
			}
			if (LightConfigs_MarshalerCached == null)
			{
				LightConfigs_MarshalerCached = new TArrayReadWriteMarshaler<FRTAvatarRectLightConfig>(1, LightConfigs_PropertyAddress, CachedMarshalingDelegates<FRTAvatarRectLightConfig, FRTAvatarRectLightConfig>.FromNative, CachedMarshalingDelegates<FRTAvatarRectLightConfig, FRTAvatarRectLightConfig>.ToNative);
			}
			return LightConfigs_MarshalerCached.FromNative(IntPtr.Add(base.Address, LightConfigs_Offset));
		}
	}

	static UGSRTAvatarConfigPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSRTAvatarConfigPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSRTAvatarConfigPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.GSRTAvatarConfigPreset");
		HeroActorBPPath_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HeroActorBPPath");
		HeroActorBPPath_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HeroActorBPPath", Classes.FStrProperty);
		HeroTransform_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HeroTransform");
		HeroTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HeroTransform", Classes.FStructProperty);
		RTCamTransform_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RTCamTransform");
		RTCamTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RTCamTransform", Classes.FStructProperty);
		RTCamFOV_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RTCamFOV");
		RTCamFOV_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RTCamFOV", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LightConfigs_PropertyAddress, unrealStruct, "LightConfigs");
		LightConfigs_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LightConfigs");
		LightConfigs_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LightConfigs", Classes.FArrayProperty);
	}
}
