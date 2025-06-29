using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SkyLightComponent", "Engine", UnrealModuleType.Engine)]
public class USkyLightComponent : ULightComponentBase
{
	private static bool RealTimeCapture_IsValid;

	private static FFieldAddress RealTimeCapture_PropertyAddress;

	private static int RealTimeCapture_Offset;

	private static bool SourceType_IsValid;

	private static FFieldAddress SourceType_PropertyAddress;

	private static int SourceType_Offset;

	private static bool Cubemap_IsValid;

	private static int Cubemap_Offset;

	private static bool CaptureSceneForReflection_IsValid;

	private static FFieldAddress CaptureSceneForReflection_PropertyAddress;

	private static int CaptureSceneForReflection_Offset;

	private static bool SourceCubemapAngle_IsValid;

	private static int SourceCubemapAngle_Offset;

	private static bool CubemapResolution_IsValid;

	private static int CubemapResolution_Offset;

	private static bool SkyDistanceThreshold_IsValid;

	private static int SkyDistanceThreshold_Offset;

	private static bool CaptureEmissiveOnly_IsValid;

	private static FFieldAddress CaptureEmissiveOnly_PropertyAddress;

	private static int CaptureEmissiveOnly_Offset;

	private static bool LowerHemisphereIsBlack_IsValid;

	private static FFieldAddress LowerHemisphereIsBlack_PropertyAddress;

	private static int LowerHemisphereIsBlack_Offset;

	private static bool LowerHemisphereColor_IsValid;

	private static int LowerHemisphereColor_Offset;

	private static bool OcclusionMaxDistance_IsValid;

	private static int OcclusionMaxDistance_Offset;

	private static bool Contrast_IsValid;

	private static int Contrast_Offset;

	private static bool OcclusionExponent_IsValid;

	private static int OcclusionExponent_Offset;

	private static bool MinOcclusion_IsValid;

	private static int MinOcclusion_Offset;

	private static bool OcclusionTint_IsValid;

	private static int OcclusionTint_Offset;

	private static bool CloudAmbientOcclusion_IsValid;

	private static FFieldAddress CloudAmbientOcclusion_PropertyAddress;

	private static int CloudAmbientOcclusion_Offset;

	private static bool CloudAmbientOcclusionStrength_IsValid;

	private static int CloudAmbientOcclusionStrength_Offset;

	private static bool CloudAmbientOcclusionExtent_IsValid;

	private static int CloudAmbientOcclusionExtent_Offset;

	private static bool CloudAmbientOcclusionMapResolutionScale_IsValid;

	private static int CloudAmbientOcclusionMapResolutionScale_Offset;

	private static bool CloudAmbientOcclusionApertureScale_IsValid;

	private static int CloudAmbientOcclusionApertureScale_Offset;

	private static bool OcclusionCombineMode_IsValid;

	private static FFieldAddress OcclusionCombineMode_PropertyAddress;

	private static int OcclusionCombineMode_Offset;

	private static bool SetVolumetricScatteringIntensity_IsValid;

	private static IntPtr SetVolumetricScatteringIntensity_FunctionAddress;

	private static int SetVolumetricScatteringIntensity_ParamsSize;

	private static bool SetVolumetricScatteringIntensity_NewIntensity_IsValid;

	private static FFieldAddress SetVolumetricScatteringIntensity_NewIntensity_PropertyAddress;

	private static int SetVolumetricScatteringIntensity_NewIntensity_Offset;

	private static bool SetOcclusionTint_IsValid;

	private static IntPtr SetOcclusionTint_FunctionAddress;

	private static int SetOcclusionTint_ParamsSize;

	private static bool SetOcclusionTint_InTint_IsValid;

	private static FFieldAddress SetOcclusionTint_InTint_PropertyAddress;

	private static int SetOcclusionTint_InTint_Offset;

	private static bool SetOcclusionExponent_IsValid;

	private static IntPtr SetOcclusionExponent_FunctionAddress;

	private static int SetOcclusionExponent_ParamsSize;

	private static bool SetOcclusionExponent_InOcclusionExponent_IsValid;

	private static FFieldAddress SetOcclusionExponent_InOcclusionExponent_PropertyAddress;

	private static int SetOcclusionExponent_InOcclusionExponent_Offset;

	private static bool SetOcclusionContrast_IsValid;

	private static IntPtr SetOcclusionContrast_FunctionAddress;

	private static int SetOcclusionContrast_ParamsSize;

	private static bool SetOcclusionContrast_InOcclusionContrast_IsValid;

	private static FFieldAddress SetOcclusionContrast_InOcclusionContrast_PropertyAddress;

	private static int SetOcclusionContrast_InOcclusionContrast_Offset;

	private static bool SetMinOcclusion_IsValid;

	private static IntPtr SetMinOcclusion_FunctionAddress;

	private static int SetMinOcclusion_ParamsSize;

	private static bool SetMinOcclusion_InMinOcclusion_IsValid;

	private static FFieldAddress SetMinOcclusion_InMinOcclusion_PropertyAddress;

	private static int SetMinOcclusion_InMinOcclusion_Offset;

	private static bool SetLowerHemisphereColor_IsValid;

	private static IntPtr SetLowerHemisphereColor_FunctionAddress;

	private static int SetLowerHemisphereColor_ParamsSize;

	private static bool SetLowerHemisphereColor_InLowerHemisphereColor_IsValid;

	private static FFieldAddress SetLowerHemisphereColor_InLowerHemisphereColor_PropertyAddress;

	private static int SetLowerHemisphereColor_InLowerHemisphereColor_Offset;

	private static bool SetLightColor_IsValid;

	private static IntPtr SetLightColor_FunctionAddress;

	private static int SetLightColor_ParamsSize;

	private static bool SetLightColor_NewLightColor_IsValid;

	private static FFieldAddress SetLightColor_NewLightColor_PropertyAddress;

	private static int SetLightColor_NewLightColor_Offset;

	private static bool SetIntensity_IsValid;

	private static IntPtr SetIntensity_FunctionAddress;

	private static int SetIntensity_ParamsSize;

	private static bool SetIntensity_NewIntensity_IsValid;

	private static FFieldAddress SetIntensity_NewIntensity_PropertyAddress;

	private static int SetIntensity_NewIntensity_Offset;

	private static bool SetIndirectLightingIntensity_IsValid;

	private static IntPtr SetIndirectLightingIntensity_FunctionAddress;

	private static int SetIndirectLightingIntensity_ParamsSize;

	private static bool SetIndirectLightingIntensity_NewIntensity_IsValid;

	private static FFieldAddress SetIndirectLightingIntensity_NewIntensity_PropertyAddress;

	private static int SetIndirectLightingIntensity_NewIntensity_Offset;

	private static bool SetCubemapBlend_IsValid;

	private static IntPtr SetCubemapBlend_FunctionAddress;

	private static int SetCubemapBlend_ParamsSize;

	private static bool SetCubemapBlend_SourceCubemap_IsValid;

	private static FFieldAddress SetCubemapBlend_SourceCubemap_PropertyAddress;

	private static int SetCubemapBlend_SourceCubemap_Offset;

	private static bool SetCubemapBlend_DestinationCubemap_IsValid;

	private static FFieldAddress SetCubemapBlend_DestinationCubemap_PropertyAddress;

	private static int SetCubemapBlend_DestinationCubemap_Offset;

	private static bool SetCubemapBlend_InBlendFraction_IsValid;

	private static FFieldAddress SetCubemapBlend_InBlendFraction_PropertyAddress;

	private static int SetCubemapBlend_InBlendFraction_Offset;

	private static bool SetCubemap_IsValid;

	private static IntPtr SetCubemap_FunctionAddress;

	private static int SetCubemap_ParamsSize;

	private static bool SetCubemap_NewCubemap_IsValid;

	private static FFieldAddress SetCubemap_NewCubemap_PropertyAddress;

	private static int SetCubemap_NewCubemap_Offset;

	private static bool RecaptureSky_IsValid;

	private static IntPtr RecaptureSky_FunctionAddress;

	private static int RecaptureSky_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:bRealTimeCapture")]
	public bool RealTimeCapture
	{
		get
		{
			CheckDestroyed();
			if (!RealTimeCapture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:bRealTimeCapture");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RealTimeCapture_Offset), 0, RealTimeCapture_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RealTimeCapture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:bRealTimeCapture");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RealTimeCapture_Offset), 0, RealTimeCapture_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SourceType")]
	public ESkyLightSourceType SourceType
	{
		get
		{
			CheckDestroyed();
			if (!SourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:SourceType");
				return ESkyLightSourceType.SLS_CapturedScene;
			}
			return EnumMarshaler<ESkyLightSourceType>.FromNative(IntPtr.Add(base.Address, SourceType_Offset), 0, SourceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:SourceType");
			}
			else
			{
				EnumMarshaler<ESkyLightSourceType>.ToNative(IntPtr.Add(base.Address, SourceType_Offset), 0, SourceType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:Cubemap")]
	public UTextureCube Cubemap
	{
		get
		{
			CheckDestroyed();
			if (!Cubemap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:Cubemap");
				return null;
			}
			return UObjectMarshaler<UTextureCube>.FromNative(IntPtr.Add(base.Address, Cubemap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Cubemap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:Cubemap");
			}
			else
			{
				UObjectMarshaler<UTextureCube>.ToNative(IntPtr.Add(base.Address, Cubemap_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:bCaptureSceneForReflection")]
	public bool CaptureSceneForReflection
	{
		get
		{
			CheckDestroyed();
			if (!CaptureSceneForReflection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:bCaptureSceneForReflection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CaptureSceneForReflection_Offset), 0, CaptureSceneForReflection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CaptureSceneForReflection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:bCaptureSceneForReflection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CaptureSceneForReflection_Offset), 0, CaptureSceneForReflection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SourceCubemapAngle")]
	public float SourceCubemapAngle
	{
		get
		{
			CheckDestroyed();
			if (!SourceCubemapAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:SourceCubemapAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SourceCubemapAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceCubemapAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:SourceCubemapAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SourceCubemapAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:CubemapResolution")]
	public int CubemapResolution
	{
		get
		{
			CheckDestroyed();
			if (!CubemapResolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:CubemapResolution");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CubemapResolution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CubemapResolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:CubemapResolution");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CubemapResolution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SkyDistanceThreshold")]
	public float SkyDistanceThreshold
	{
		get
		{
			CheckDestroyed();
			if (!SkyDistanceThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:SkyDistanceThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SkyDistanceThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkyDistanceThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:SkyDistanceThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SkyDistanceThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:bCaptureEmissiveOnly")]
	public bool CaptureEmissiveOnly
	{
		get
		{
			CheckDestroyed();
			if (!CaptureEmissiveOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:bCaptureEmissiveOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CaptureEmissiveOnly_Offset), 0, CaptureEmissiveOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CaptureEmissiveOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:bCaptureEmissiveOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CaptureEmissiveOnly_Offset), 0, CaptureEmissiveOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:bLowerHemisphereIsBlack")]
	public bool LowerHemisphereIsBlack
	{
		get
		{
			CheckDestroyed();
			if (!LowerHemisphereIsBlack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:bLowerHemisphereIsBlack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LowerHemisphereIsBlack_Offset), 0, LowerHemisphereIsBlack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LowerHemisphereIsBlack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:bLowerHemisphereIsBlack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LowerHemisphereIsBlack_Offset), 0, LowerHemisphereIsBlack_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:LowerHemisphereColor")]
	public FLinearColor LowerHemisphereColor
	{
		get
		{
			CheckDestroyed();
			if (!LowerHemisphereColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:LowerHemisphereColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, LowerHemisphereColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LowerHemisphereColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:LowerHemisphereColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, LowerHemisphereColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:OcclusionMaxDistance")]
	public float OcclusionMaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!OcclusionMaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:OcclusionMaxDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OcclusionMaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OcclusionMaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:OcclusionMaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OcclusionMaxDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:Contrast")]
	public float Contrast
	{
		get
		{
			CheckDestroyed();
			if (!Contrast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:Contrast");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Contrast_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Contrast_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:Contrast");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Contrast_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:OcclusionExponent")]
	public float OcclusionExponent
	{
		get
		{
			CheckDestroyed();
			if (!OcclusionExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:OcclusionExponent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OcclusionExponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OcclusionExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:OcclusionExponent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OcclusionExponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:MinOcclusion")]
	public float MinOcclusion
	{
		get
		{
			CheckDestroyed();
			if (!MinOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:MinOcclusion");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinOcclusion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:MinOcclusion");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinOcclusion_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:OcclusionTint")]
	public FColor OcclusionTint
	{
		get
		{
			CheckDestroyed();
			if (!OcclusionTint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:OcclusionTint");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, OcclusionTint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OcclusionTint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:OcclusionTint");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, OcclusionTint_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:bCloudAmbientOcclusion")]
	public bool CloudAmbientOcclusion
	{
		get
		{
			CheckDestroyed();
			if (!CloudAmbientOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:bCloudAmbientOcclusion");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CloudAmbientOcclusion_Offset), 0, CloudAmbientOcclusion_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CloudAmbientOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:bCloudAmbientOcclusion");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CloudAmbientOcclusion_Offset), 0, CloudAmbientOcclusion_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionStrength")]
	public float CloudAmbientOcclusionStrength
	{
		get
		{
			CheckDestroyed();
			if (!CloudAmbientOcclusionStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudAmbientOcclusionStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudAmbientOcclusionStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudAmbientOcclusionStrength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionExtent")]
	public float CloudAmbientOcclusionExtent
	{
		get
		{
			CheckDestroyed();
			if (!CloudAmbientOcclusionExtent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionExtent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudAmbientOcclusionExtent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudAmbientOcclusionExtent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionExtent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudAmbientOcclusionExtent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionMapResolutionScale")]
	public float CloudAmbientOcclusionMapResolutionScale
	{
		get
		{
			CheckDestroyed();
			if (!CloudAmbientOcclusionMapResolutionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionMapResolutionScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudAmbientOcclusionMapResolutionScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudAmbientOcclusionMapResolutionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionMapResolutionScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudAmbientOcclusionMapResolutionScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionApertureScale")]
	public float CloudAmbientOcclusionApertureScale
	{
		get
		{
			CheckDestroyed();
			if (!CloudAmbientOcclusionApertureScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionApertureScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudAmbientOcclusionApertureScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudAmbientOcclusionApertureScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:CloudAmbientOcclusionApertureScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudAmbientOcclusionApertureScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkyLightComponent:OcclusionCombineMode")]
	public EOcclusionCombineMode OcclusionCombineMode
	{
		get
		{
			CheckDestroyed();
			if (!OcclusionCombineMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:OcclusionCombineMode");
				return EOcclusionCombineMode.OCM_Minimum;
			}
			return EnumMarshaler<EOcclusionCombineMode>.FromNative(IntPtr.Add(base.Address, OcclusionCombineMode_Offset), 0, OcclusionCombineMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OcclusionCombineMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLightComponent:OcclusionCombineMode");
			}
			else
			{
				EnumMarshaler<EOcclusionCombineMode>.ToNative(IntPtr.Add(base.Address, OcclusionCombineMode_Offset), 0, OcclusionCombineMode_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SetVolumetricScatteringIntensity")]
	public unsafe void SetVolumetricScatteringIntensity(float NewIntensity)
	{
		CheckDestroyed();
		if (!SetVolumetricScatteringIntensity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:SetVolumetricScatteringIntensity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolumetricScatteringIntensity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolumetricScatteringIntensity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVolumetricScatteringIntensity_NewIntensity_Offset), 0, SetVolumetricScatteringIntensity_NewIntensity_PropertyAddress.Address, NewIntensity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolumetricScatteringIntensity_FunctionAddress, intPtr, SetVolumetricScatteringIntensity_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SetOcclusionTint")]
	public unsafe void SetOcclusionTint(FColor InTint)
	{
		CheckDestroyed();
		if (!SetOcclusionTint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:SetOcclusionTint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOcclusionTint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOcclusionTint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetOcclusionTint_InTint_Offset), 0, SetOcclusionTint_InTint_PropertyAddress.Address, InTint);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOcclusionTint_FunctionAddress, intPtr, SetOcclusionTint_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SetOcclusionExponent")]
	public unsafe void SetOcclusionExponent(float InOcclusionExponent)
	{
		CheckDestroyed();
		if (!SetOcclusionExponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:SetOcclusionExponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOcclusionExponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOcclusionExponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOcclusionExponent_InOcclusionExponent_Offset), 0, SetOcclusionExponent_InOcclusionExponent_PropertyAddress.Address, InOcclusionExponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOcclusionExponent_FunctionAddress, intPtr, SetOcclusionExponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SetOcclusionContrast")]
	public unsafe void SetOcclusionContrast(float InOcclusionContrast)
	{
		CheckDestroyed();
		if (!SetOcclusionContrast_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:SetOcclusionContrast");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOcclusionContrast_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOcclusionContrast_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOcclusionContrast_InOcclusionContrast_Offset), 0, SetOcclusionContrast_InOcclusionContrast_PropertyAddress.Address, InOcclusionContrast);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOcclusionContrast_FunctionAddress, intPtr, SetOcclusionContrast_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SetMinOcclusion")]
	public unsafe void SetMinOcclusion(float InMinOcclusion)
	{
		CheckDestroyed();
		if (!SetMinOcclusion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:SetMinOcclusion");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinOcclusion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinOcclusion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMinOcclusion_InMinOcclusion_Offset), 0, SetMinOcclusion_InMinOcclusion_PropertyAddress.Address, InMinOcclusion);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinOcclusion_FunctionAddress, intPtr, SetMinOcclusion_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SetLowerHemisphereColor")]
	public unsafe void SetLowerHemisphereColor(FLinearColor InLowerHemisphereColor)
	{
		CheckDestroyed();
		if (!SetLowerHemisphereColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:SetLowerHemisphereColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLowerHemisphereColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLowerHemisphereColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetLowerHemisphereColor_InLowerHemisphereColor_Offset), 0, SetLowerHemisphereColor_InLowerHemisphereColor_PropertyAddress.Address, InLowerHemisphereColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLowerHemisphereColor_FunctionAddress, intPtr, SetLowerHemisphereColor_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SetLightColor")]
	public unsafe void SetLightColor(FLinearColor NewLightColor)
	{
		CheckDestroyed();
		if (!SetLightColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:SetLightColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetLightColor_NewLightColor_Offset), 0, SetLightColor_NewLightColor_PropertyAddress.Address, NewLightColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightColor_FunctionAddress, intPtr, SetLightColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SetIntensity")]
	public unsafe void SetIntensity(float NewIntensity)
	{
		CheckDestroyed();
		if (!SetIntensity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:SetIntensity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIntensity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIntensity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetIntensity_NewIntensity_Offset), 0, SetIntensity_NewIntensity_PropertyAddress.Address, NewIntensity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIntensity_FunctionAddress, intPtr, SetIntensity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SetIndirectLightingIntensity")]
	public unsafe void SetIndirectLightingIntensity(float NewIntensity)
	{
		CheckDestroyed();
		if (!SetIndirectLightingIntensity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:SetIndirectLightingIntensity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIndirectLightingIntensity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIndirectLightingIntensity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetIndirectLightingIntensity_NewIntensity_Offset), 0, SetIndirectLightingIntensity_NewIntensity_PropertyAddress.Address, NewIntensity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIndirectLightingIntensity_FunctionAddress, intPtr, SetIndirectLightingIntensity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SetCubemapBlend")]
	public unsafe void SetCubemapBlend(UTextureCube SourceCubemap, UTextureCube DestinationCubemap, float InBlendFraction)
	{
		CheckDestroyed();
		if (!SetCubemapBlend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:SetCubemapBlend");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCubemapBlend_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCubemapBlend_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureCube>.ToNative(IntPtr.Add(intPtr, SetCubemapBlend_SourceCubemap_Offset), 0, SetCubemapBlend_SourceCubemap_PropertyAddress.Address, SourceCubemap);
		UObjectMarshaler<UTextureCube>.ToNative(IntPtr.Add(intPtr, SetCubemapBlend_DestinationCubemap_Offset), 0, SetCubemapBlend_DestinationCubemap_PropertyAddress.Address, DestinationCubemap);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCubemapBlend_InBlendFraction_Offset), 0, SetCubemapBlend_InBlendFraction_PropertyAddress.Address, InBlendFraction);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCubemapBlend_FunctionAddress, intPtr, SetCubemapBlend_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:SetCubemap")]
	public unsafe void SetCubemap(UTextureCube NewCubemap)
	{
		CheckDestroyed();
		if (!SetCubemap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:SetCubemap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCubemap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCubemap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureCube>.ToNative(IntPtr.Add(intPtr, SetCubemap_NewCubemap_Offset), 0, SetCubemap_NewCubemap_PropertyAddress.Address, NewCubemap);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCubemap_FunctionAddress, intPtr, SetCubemap_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkyLightComponent:RecaptureSky")]
	public unsafe void RecaptureSky()
	{
		CheckDestroyed();
		if (!RecaptureSky_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyLightComponent:RecaptureSky");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecaptureSky_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecaptureSky_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecaptureSky_FunctionAddress, argsSize: RecaptureSky_ParamsSize);
	}

	static USkyLightComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USkyLightComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USkyLightComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SkyLightComponent");
		NativeReflectionCached.GetPropertyRef(ref RealTimeCapture_PropertyAddress, intPtr, "bRealTimeCapture");
		RealTimeCapture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRealTimeCapture");
		RealTimeCapture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRealTimeCapture", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SourceType_PropertyAddress, intPtr, "SourceType");
		SourceType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceType");
		SourceType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceType", Classes.FByteProperty);
		Cubemap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Cubemap");
		Cubemap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Cubemap", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CaptureSceneForReflection_PropertyAddress, intPtr, "bCaptureSceneForReflection");
		CaptureSceneForReflection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCaptureSceneForReflection");
		CaptureSceneForReflection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCaptureSceneForReflection", Classes.FBoolProperty);
		SourceCubemapAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceCubemapAngle");
		SourceCubemapAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceCubemapAngle", Classes.FFloatProperty);
		CubemapResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CubemapResolution");
		CubemapResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CubemapResolution", Classes.FIntProperty);
		SkyDistanceThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyDistanceThreshold");
		SkyDistanceThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyDistanceThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CaptureEmissiveOnly_PropertyAddress, intPtr, "bCaptureEmissiveOnly");
		CaptureEmissiveOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCaptureEmissiveOnly");
		CaptureEmissiveOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCaptureEmissiveOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LowerHemisphereIsBlack_PropertyAddress, intPtr, "bLowerHemisphereIsBlack");
		LowerHemisphereIsBlack_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLowerHemisphereIsBlack");
		LowerHemisphereIsBlack_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLowerHemisphereIsBlack", Classes.FBoolProperty);
		LowerHemisphereColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowerHemisphereColor");
		LowerHemisphereColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowerHemisphereColor", Classes.FStructProperty);
		OcclusionMaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionMaxDistance");
		OcclusionMaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionMaxDistance", Classes.FFloatProperty);
		Contrast_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Contrast");
		Contrast_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Contrast", Classes.FFloatProperty);
		OcclusionExponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionExponent");
		OcclusionExponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionExponent", Classes.FFloatProperty);
		MinOcclusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinOcclusion");
		MinOcclusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinOcclusion", Classes.FFloatProperty);
		OcclusionTint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionTint");
		OcclusionTint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionTint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CloudAmbientOcclusion_PropertyAddress, intPtr, "bCloudAmbientOcclusion");
		CloudAmbientOcclusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCloudAmbientOcclusion");
		CloudAmbientOcclusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCloudAmbientOcclusion", Classes.FBoolProperty);
		CloudAmbientOcclusionStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudAmbientOcclusionStrength");
		CloudAmbientOcclusionStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudAmbientOcclusionStrength", Classes.FFloatProperty);
		CloudAmbientOcclusionExtent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudAmbientOcclusionExtent");
		CloudAmbientOcclusionExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudAmbientOcclusionExtent", Classes.FFloatProperty);
		CloudAmbientOcclusionMapResolutionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudAmbientOcclusionMapResolutionScale");
		CloudAmbientOcclusionMapResolutionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudAmbientOcclusionMapResolutionScale", Classes.FFloatProperty);
		CloudAmbientOcclusionApertureScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudAmbientOcclusionApertureScale");
		CloudAmbientOcclusionApertureScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudAmbientOcclusionApertureScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OcclusionCombineMode_PropertyAddress, intPtr, "OcclusionCombineMode");
		OcclusionCombineMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionCombineMode");
		OcclusionCombineMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionCombineMode", Classes.FByteProperty);
		SetVolumetricScatteringIntensity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolumetricScatteringIntensity");
		SetVolumetricScatteringIntensity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolumetricScatteringIntensity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolumetricScatteringIntensity_NewIntensity_PropertyAddress, SetVolumetricScatteringIntensity_FunctionAddress, "NewIntensity");
		SetVolumetricScatteringIntensity_NewIntensity_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumetricScatteringIntensity_FunctionAddress, "NewIntensity");
		SetVolumetricScatteringIntensity_NewIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumetricScatteringIntensity_FunctionAddress, "NewIntensity", Classes.FFloatProperty);
		SetVolumetricScatteringIntensity_IsValid = SetVolumetricScatteringIntensity_FunctionAddress != IntPtr.Zero && SetVolumetricScatteringIntensity_NewIntensity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:SetVolumetricScatteringIntensity", SetVolumetricScatteringIntensity_IsValid);
		SetOcclusionTint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOcclusionTint");
		SetOcclusionTint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOcclusionTint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOcclusionTint_InTint_PropertyAddress, SetOcclusionTint_FunctionAddress, "InTint");
		SetOcclusionTint_InTint_Offset = NativeReflectionCached.GetPropertyOffset(SetOcclusionTint_FunctionAddress, "InTint");
		SetOcclusionTint_InTint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOcclusionTint_FunctionAddress, "InTint", Classes.FStructProperty);
		SetOcclusionTint_IsValid = SetOcclusionTint_FunctionAddress != IntPtr.Zero && SetOcclusionTint_InTint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:SetOcclusionTint", SetOcclusionTint_IsValid);
		SetOcclusionExponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOcclusionExponent");
		SetOcclusionExponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOcclusionExponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOcclusionExponent_InOcclusionExponent_PropertyAddress, SetOcclusionExponent_FunctionAddress, "InOcclusionExponent");
		SetOcclusionExponent_InOcclusionExponent_Offset = NativeReflectionCached.GetPropertyOffset(SetOcclusionExponent_FunctionAddress, "InOcclusionExponent");
		SetOcclusionExponent_InOcclusionExponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOcclusionExponent_FunctionAddress, "InOcclusionExponent", Classes.FFloatProperty);
		SetOcclusionExponent_IsValid = SetOcclusionExponent_FunctionAddress != IntPtr.Zero && SetOcclusionExponent_InOcclusionExponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:SetOcclusionExponent", SetOcclusionExponent_IsValid);
		SetOcclusionContrast_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOcclusionContrast");
		SetOcclusionContrast_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOcclusionContrast_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOcclusionContrast_InOcclusionContrast_PropertyAddress, SetOcclusionContrast_FunctionAddress, "InOcclusionContrast");
		SetOcclusionContrast_InOcclusionContrast_Offset = NativeReflectionCached.GetPropertyOffset(SetOcclusionContrast_FunctionAddress, "InOcclusionContrast");
		SetOcclusionContrast_InOcclusionContrast_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOcclusionContrast_FunctionAddress, "InOcclusionContrast", Classes.FFloatProperty);
		SetOcclusionContrast_IsValid = SetOcclusionContrast_FunctionAddress != IntPtr.Zero && SetOcclusionContrast_InOcclusionContrast_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:SetOcclusionContrast", SetOcclusionContrast_IsValid);
		SetMinOcclusion_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinOcclusion");
		SetMinOcclusion_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinOcclusion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinOcclusion_InMinOcclusion_PropertyAddress, SetMinOcclusion_FunctionAddress, "InMinOcclusion");
		SetMinOcclusion_InMinOcclusion_Offset = NativeReflectionCached.GetPropertyOffset(SetMinOcclusion_FunctionAddress, "InMinOcclusion");
		SetMinOcclusion_InMinOcclusion_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinOcclusion_FunctionAddress, "InMinOcclusion", Classes.FFloatProperty);
		SetMinOcclusion_IsValid = SetMinOcclusion_FunctionAddress != IntPtr.Zero && SetMinOcclusion_InMinOcclusion_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:SetMinOcclusion", SetMinOcclusion_IsValid);
		SetLowerHemisphereColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLowerHemisphereColor");
		SetLowerHemisphereColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLowerHemisphereColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLowerHemisphereColor_InLowerHemisphereColor_PropertyAddress, SetLowerHemisphereColor_FunctionAddress, "InLowerHemisphereColor");
		SetLowerHemisphereColor_InLowerHemisphereColor_Offset = NativeReflectionCached.GetPropertyOffset(SetLowerHemisphereColor_FunctionAddress, "InLowerHemisphereColor");
		SetLowerHemisphereColor_InLowerHemisphereColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLowerHemisphereColor_FunctionAddress, "InLowerHemisphereColor", Classes.FStructProperty);
		SetLowerHemisphereColor_IsValid = SetLowerHemisphereColor_FunctionAddress != IntPtr.Zero && SetLowerHemisphereColor_InLowerHemisphereColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:SetLowerHemisphereColor", SetLowerHemisphereColor_IsValid);
		SetLightColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightColor");
		SetLightColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightColor_NewLightColor_PropertyAddress, SetLightColor_FunctionAddress, "NewLightColor");
		SetLightColor_NewLightColor_Offset = NativeReflectionCached.GetPropertyOffset(SetLightColor_FunctionAddress, "NewLightColor");
		SetLightColor_NewLightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightColor_FunctionAddress, "NewLightColor", Classes.FStructProperty);
		SetLightColor_IsValid = SetLightColor_FunctionAddress != IntPtr.Zero && SetLightColor_NewLightColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:SetLightColor", SetLightColor_IsValid);
		SetIntensity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIntensity");
		SetIntensity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIntensity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIntensity_NewIntensity_PropertyAddress, SetIntensity_FunctionAddress, "NewIntensity");
		SetIntensity_NewIntensity_Offset = NativeReflectionCached.GetPropertyOffset(SetIntensity_FunctionAddress, "NewIntensity");
		SetIntensity_NewIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntensity_FunctionAddress, "NewIntensity", Classes.FFloatProperty);
		SetIntensity_IsValid = SetIntensity_FunctionAddress != IntPtr.Zero && SetIntensity_NewIntensity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:SetIntensity", SetIntensity_IsValid);
		SetIndirectLightingIntensity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIndirectLightingIntensity");
		SetIndirectLightingIntensity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIndirectLightingIntensity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIndirectLightingIntensity_NewIntensity_PropertyAddress, SetIndirectLightingIntensity_FunctionAddress, "NewIntensity");
		SetIndirectLightingIntensity_NewIntensity_Offset = NativeReflectionCached.GetPropertyOffset(SetIndirectLightingIntensity_FunctionAddress, "NewIntensity");
		SetIndirectLightingIntensity_NewIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIndirectLightingIntensity_FunctionAddress, "NewIntensity", Classes.FFloatProperty);
		SetIndirectLightingIntensity_IsValid = SetIndirectLightingIntensity_FunctionAddress != IntPtr.Zero && SetIndirectLightingIntensity_NewIntensity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:SetIndirectLightingIntensity", SetIndirectLightingIntensity_IsValid);
		SetCubemapBlend_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCubemapBlend");
		SetCubemapBlend_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCubemapBlend_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCubemapBlend_SourceCubemap_PropertyAddress, SetCubemapBlend_FunctionAddress, "SourceCubemap");
		SetCubemapBlend_SourceCubemap_Offset = NativeReflectionCached.GetPropertyOffset(SetCubemapBlend_FunctionAddress, "SourceCubemap");
		SetCubemapBlend_SourceCubemap_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCubemapBlend_FunctionAddress, "SourceCubemap", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCubemapBlend_DestinationCubemap_PropertyAddress, SetCubemapBlend_FunctionAddress, "DestinationCubemap");
		SetCubemapBlend_DestinationCubemap_Offset = NativeReflectionCached.GetPropertyOffset(SetCubemapBlend_FunctionAddress, "DestinationCubemap");
		SetCubemapBlend_DestinationCubemap_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCubemapBlend_FunctionAddress, "DestinationCubemap", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCubemapBlend_InBlendFraction_PropertyAddress, SetCubemapBlend_FunctionAddress, "InBlendFraction");
		SetCubemapBlend_InBlendFraction_Offset = NativeReflectionCached.GetPropertyOffset(SetCubemapBlend_FunctionAddress, "InBlendFraction");
		SetCubemapBlend_InBlendFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCubemapBlend_FunctionAddress, "InBlendFraction", Classes.FFloatProperty);
		SetCubemapBlend_IsValid = SetCubemapBlend_FunctionAddress != IntPtr.Zero && SetCubemapBlend_SourceCubemap_IsValid && SetCubemapBlend_DestinationCubemap_IsValid && SetCubemapBlend_InBlendFraction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:SetCubemapBlend", SetCubemapBlend_IsValid);
		SetCubemap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCubemap");
		SetCubemap_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCubemap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCubemap_NewCubemap_PropertyAddress, SetCubemap_FunctionAddress, "NewCubemap");
		SetCubemap_NewCubemap_Offset = NativeReflectionCached.GetPropertyOffset(SetCubemap_FunctionAddress, "NewCubemap");
		SetCubemap_NewCubemap_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCubemap_FunctionAddress, "NewCubemap", Classes.FObjectProperty);
		SetCubemap_IsValid = SetCubemap_FunctionAddress != IntPtr.Zero && SetCubemap_NewCubemap_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:SetCubemap", SetCubemap_IsValid);
		RecaptureSky_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RecaptureSky");
		RecaptureSky_ParamsSize = NativeReflection.GetFunctionParamsSize(RecaptureSky_FunctionAddress);
		RecaptureSky_IsValid = RecaptureSky_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyLightComponent:RecaptureSky", RecaptureSky_IsValid);
	}
}
