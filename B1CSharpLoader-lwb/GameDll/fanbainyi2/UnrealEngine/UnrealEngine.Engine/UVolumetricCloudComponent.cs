using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)820523172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.VolumetricCloudComponent", "Engine", UnrealModuleType.Engine)]
public class UVolumetricCloudComponent : USceneComponent
{
	private static bool LayerBottomAltitude_IsValid;

	private static int LayerBottomAltitude_Offset;

	private static bool LayerHeight_IsValid;

	private static int LayerHeight_Offset;

	private static bool TracingStartMaxDistance_IsValid;

	private static int TracingStartMaxDistance_Offset;

	private static bool TracingMaxDistanceMode_IsValid;

	private static FFieldAddress TracingMaxDistanceMode_PropertyAddress;

	private static int TracingMaxDistanceMode_Offset;

	private static bool TracingMaxDistance_IsValid;

	private static int TracingMaxDistance_Offset;

	private static bool PlanetRadius_IsValid;

	private static int PlanetRadius_Offset;

	private static bool GroundAlbedo_IsValid;

	private static int GroundAlbedo_Offset;

	private static bool Material_IsValid;

	private static int Material_Offset;

	private static bool UsePerSampleAtmosphericLightTransmittance_IsValid;

	private static FFieldAddress UsePerSampleAtmosphericLightTransmittance_PropertyAddress;

	private static int UsePerSampleAtmosphericLightTransmittance_Offset;

	private static bool SkyLightCloudBottomOcclusion_IsValid;

	private static int SkyLightCloudBottomOcclusion_Offset;

	private static bool ViewSampleCountScale_IsValid;

	private static int ViewSampleCountScale_Offset;

	private static bool ReflectionViewSampleCountScaleValue_IsValid;

	private static int ReflectionViewSampleCountScaleValue_Offset;

	private static bool ShadowViewSampleCountScale_IsValid;

	private static int ShadowViewSampleCountScale_Offset;

	private static bool ShadowReflectionViewSampleCountScaleValue_IsValid;

	private static int ShadowReflectionViewSampleCountScaleValue_Offset;

	private static bool ShadowTracingDistance_IsValid;

	private static int ShadowTracingDistance_Offset;

	private static bool StopTracingTransmittanceThreshold_IsValid;

	private static int StopTracingTransmittanceThreshold_Offset;

	private static bool AerialPespectiveRayleighScatteringStartDistance_IsValid;

	private static int AerialPespectiveRayleighScatteringStartDistance_Offset;

	private static bool AerialPespectiveRayleighScatteringFadeDistance_IsValid;

	private static int AerialPespectiveRayleighScatteringFadeDistance_Offset;

	private static bool AerialPespectiveMieScatteringStartDistance_IsValid;

	private static int AerialPespectiveMieScatteringStartDistance_Offset;

	private static bool AerialPespectiveMieScatteringFadeDistance_IsValid;

	private static int AerialPespectiveMieScatteringFadeDistance_Offset;

	private static bool SetViewSampleCountScale_IsValid;

	private static IntPtr SetViewSampleCountScale_FunctionAddress;

	private static int SetViewSampleCountScale_ParamsSize;

	private static bool SetViewSampleCountScale_NewValue_IsValid;

	private static FFieldAddress SetViewSampleCountScale_NewValue_PropertyAddress;

	private static int SetViewSampleCountScale_NewValue_Offset;

	private static bool SetTracingStartMaxDistance_IsValid;

	private static IntPtr SetTracingStartMaxDistance_FunctionAddress;

	private static int SetTracingStartMaxDistance_ParamsSize;

	private static bool SetTracingStartMaxDistance_NewValue_IsValid;

	private static FFieldAddress SetTracingStartMaxDistance_NewValue_PropertyAddress;

	private static int SetTracingStartMaxDistance_NewValue_Offset;

	private static bool SetTracingMaxDistance_IsValid;

	private static IntPtr SetTracingMaxDistance_FunctionAddress;

	private static int SetTracingMaxDistance_ParamsSize;

	private static bool SetTracingMaxDistance_NewValue_IsValid;

	private static FFieldAddress SetTracingMaxDistance_NewValue_PropertyAddress;

	private static int SetTracingMaxDistance_NewValue_Offset;

	private static bool SetStopTracingTransmittanceThreshold_IsValid;

	private static IntPtr SetStopTracingTransmittanceThreshold_FunctionAddress;

	private static int SetStopTracingTransmittanceThreshold_ParamsSize;

	private static bool SetStopTracingTransmittanceThreshold_NewValue_IsValid;

	private static FFieldAddress SetStopTracingTransmittanceThreshold_NewValue_PropertyAddress;

	private static int SetStopTracingTransmittanceThreshold_NewValue_Offset;

	private static bool SetSkyLightCloudBottomOcclusion_IsValid;

	private static IntPtr SetSkyLightCloudBottomOcclusion_FunctionAddress;

	private static int SetSkyLightCloudBottomOcclusion_ParamsSize;

	private static bool SetSkyLightCloudBottomOcclusion_NewValue_IsValid;

	private static FFieldAddress SetSkyLightCloudBottomOcclusion_NewValue_PropertyAddress;

	private static int SetSkyLightCloudBottomOcclusion_NewValue_Offset;

	private static bool SetShadowViewSampleCountScale_IsValid;

	private static IntPtr SetShadowViewSampleCountScale_FunctionAddress;

	private static int SetShadowViewSampleCountScale_ParamsSize;

	private static bool SetShadowViewSampleCountScale_NewValue_IsValid;

	private static FFieldAddress SetShadowViewSampleCountScale_NewValue_PropertyAddress;

	private static int SetShadowViewSampleCountScale_NewValue_Offset;

	private static bool SetShadowTracingDistance_IsValid;

	private static IntPtr SetShadowTracingDistance_FunctionAddress;

	private static int SetShadowTracingDistance_ParamsSize;

	private static bool SetShadowTracingDistance_NewValue_IsValid;

	private static FFieldAddress SetShadowTracingDistance_NewValue_PropertyAddress;

	private static int SetShadowTracingDistance_NewValue_Offset;

	private static bool SetShadowReflectionViewSampleCountScale_IsValid;

	private static IntPtr SetShadowReflectionViewSampleCountScale_FunctionAddress;

	private static int SetShadowReflectionViewSampleCountScale_ParamsSize;

	private static bool SetShadowReflectionViewSampleCountScale_NewValue_IsValid;

	private static FFieldAddress SetShadowReflectionViewSampleCountScale_NewValue_PropertyAddress;

	private static int SetShadowReflectionViewSampleCountScale_NewValue_Offset;

	private static bool SetReflectionViewSampleCountScale_IsValid;

	private static IntPtr SetReflectionViewSampleCountScale_FunctionAddress;

	private static int SetReflectionViewSampleCountScale_ParamsSize;

	private static bool SetReflectionViewSampleCountScale_NewValue_IsValid;

	private static FFieldAddress SetReflectionViewSampleCountScale_NewValue_PropertyAddress;

	private static int SetReflectionViewSampleCountScale_NewValue_Offset;

	private static bool SetPlanetRadius_IsValid;

	private static IntPtr SetPlanetRadius_FunctionAddress;

	private static int SetPlanetRadius_ParamsSize;

	private static bool SetPlanetRadius_NewValue_IsValid;

	private static FFieldAddress SetPlanetRadius_NewValue_PropertyAddress;

	private static int SetPlanetRadius_NewValue_Offset;

	private static bool SetMaterial_IsValid;

	private static IntPtr SetMaterial_FunctionAddress;

	private static int SetMaterial_ParamsSize;

	private static bool SetMaterial_NewValue_IsValid;

	private static FFieldAddress SetMaterial_NewValue_PropertyAddress;

	private static int SetMaterial_NewValue_Offset;

	private static bool SetLayerHeight_IsValid;

	private static IntPtr SetLayerHeight_FunctionAddress;

	private static int SetLayerHeight_ParamsSize;

	private static bool SetLayerHeight_NewValue_IsValid;

	private static FFieldAddress SetLayerHeight_NewValue_PropertyAddress;

	private static int SetLayerHeight_NewValue_Offset;

	private static bool SetLayerBottomAltitude_IsValid;

	private static IntPtr SetLayerBottomAltitude_FunctionAddress;

	private static int SetLayerBottomAltitude_ParamsSize;

	private static bool SetLayerBottomAltitude_NewValue_IsValid;

	private static FFieldAddress SetLayerBottomAltitude_NewValue_PropertyAddress;

	private static int SetLayerBottomAltitude_NewValue_Offset;

	private static bool SetGroundAlbedo_IsValid;

	private static IntPtr SetGroundAlbedo_FunctionAddress;

	private static int SetGroundAlbedo_ParamsSize;

	private static bool SetGroundAlbedo_NewValue_IsValid;

	private static FFieldAddress SetGroundAlbedo_NewValue_PropertyAddress;

	private static int SetGroundAlbedo_NewValue_Offset;

	private static bool SetbUsePerSampleAtmosphericLightTransmittance_IsValid;

	private static IntPtr SetbUsePerSampleAtmosphericLightTransmittance_FunctionAddress;

	private static int SetbUsePerSampleAtmosphericLightTransmittance_ParamsSize;

	private static bool SetbUsePerSampleAtmosphericLightTransmittance_NewValue_IsValid;

	private static FFieldAddress SetbUsePerSampleAtmosphericLightTransmittance_NewValue_PropertyAddress;

	private static int SetbUsePerSampleAtmosphericLightTransmittance_NewValue_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:LayerBottomAltitude")]
	public float LayerBottomAltitude
	{
		get
		{
			CheckDestroyed();
			if (!LayerBottomAltitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:LayerBottomAltitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LayerBottomAltitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LayerBottomAltitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:LayerBottomAltitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LayerBottomAltitude_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:LayerHeight")]
	public float LayerHeight
	{
		get
		{
			CheckDestroyed();
			if (!LayerHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:LayerHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LayerHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LayerHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:LayerHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LayerHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:TracingStartMaxDistance")]
	public float TracingStartMaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!TracingStartMaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:TracingStartMaxDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TracingStartMaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TracingStartMaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:TracingStartMaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TracingStartMaxDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:TracingMaxDistanceMode")]
	public EVolumetricCloudTracingMaxDistanceMode TracingMaxDistanceMode
	{
		get
		{
			CheckDestroyed();
			if (!TracingMaxDistanceMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:TracingMaxDistanceMode");
				return EVolumetricCloudTracingMaxDistanceMode.DistanceFromCloudLayerEntryPoint;
			}
			return EnumMarshaler<EVolumetricCloudTracingMaxDistanceMode>.FromNative(IntPtr.Add(base.Address, TracingMaxDistanceMode_Offset), 0, TracingMaxDistanceMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TracingMaxDistanceMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:TracingMaxDistanceMode");
			}
			else
			{
				EnumMarshaler<EVolumetricCloudTracingMaxDistanceMode>.ToNative(IntPtr.Add(base.Address, TracingMaxDistanceMode_Offset), 0, TracingMaxDistanceMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:TracingMaxDistance")]
	public float TracingMaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!TracingMaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:TracingMaxDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TracingMaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TracingMaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:TracingMaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TracingMaxDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:PlanetRadius")]
	public float PlanetRadius
	{
		get
		{
			CheckDestroyed();
			if (!PlanetRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:PlanetRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PlanetRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlanetRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:PlanetRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PlanetRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:GroundAlbedo")]
	public FColor GroundAlbedo
	{
		get
		{
			CheckDestroyed();
			if (!GroundAlbedo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:GroundAlbedo");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, GroundAlbedo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroundAlbedo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:GroundAlbedo");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, GroundAlbedo_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:Material")]
	public UMaterialInterface Material
	{
		get
		{
			CheckDestroyed();
			if (!Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:Material");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, Material_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:Material");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, Material_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:bUsePerSampleAtmosphericLightTransmittance")]
	public bool UsePerSampleAtmosphericLightTransmittance
	{
		get
		{
			CheckDestroyed();
			if (!UsePerSampleAtmosphericLightTransmittance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:bUsePerSampleAtmosphericLightTransmittance");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsePerSampleAtmosphericLightTransmittance_Offset), 0, UsePerSampleAtmosphericLightTransmittance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsePerSampleAtmosphericLightTransmittance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:bUsePerSampleAtmosphericLightTransmittance");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsePerSampleAtmosphericLightTransmittance_Offset), 0, UsePerSampleAtmosphericLightTransmittance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SkyLightCloudBottomOcclusion")]
	public float SkyLightCloudBottomOcclusion
	{
		get
		{
			CheckDestroyed();
			if (!SkyLightCloudBottomOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:SkyLightCloudBottomOcclusion");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SkyLightCloudBottomOcclusion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkyLightCloudBottomOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:SkyLightCloudBottomOcclusion");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SkyLightCloudBottomOcclusion_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:ViewSampleCountScale")]
	public float ViewSampleCountScale
	{
		get
		{
			CheckDestroyed();
			if (!ViewSampleCountScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:ViewSampleCountScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ViewSampleCountScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewSampleCountScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:ViewSampleCountScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ViewSampleCountScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:ReflectionViewSampleCountScaleValue")]
	public float ReflectionViewSampleCountScaleValue
	{
		get
		{
			CheckDestroyed();
			if (!ReflectionViewSampleCountScaleValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:ReflectionViewSampleCountScaleValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ReflectionViewSampleCountScaleValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReflectionViewSampleCountScaleValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:ReflectionViewSampleCountScaleValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ReflectionViewSampleCountScaleValue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:ShadowViewSampleCountScale")]
	public float ShadowViewSampleCountScale
	{
		get
		{
			CheckDestroyed();
			if (!ShadowViewSampleCountScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:ShadowViewSampleCountScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowViewSampleCountScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowViewSampleCountScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:ShadowViewSampleCountScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowViewSampleCountScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:ShadowReflectionViewSampleCountScaleValue")]
	public float ShadowReflectionViewSampleCountScaleValue
	{
		get
		{
			CheckDestroyed();
			if (!ShadowReflectionViewSampleCountScaleValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:ShadowReflectionViewSampleCountScaleValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowReflectionViewSampleCountScaleValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowReflectionViewSampleCountScaleValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:ShadowReflectionViewSampleCountScaleValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowReflectionViewSampleCountScaleValue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:ShadowTracingDistance")]
	public float ShadowTracingDistance
	{
		get
		{
			CheckDestroyed();
			if (!ShadowTracingDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:ShadowTracingDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowTracingDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowTracingDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:ShadowTracingDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowTracingDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:StopTracingTransmittanceThreshold")]
	public float StopTracingTransmittanceThreshold
	{
		get
		{
			CheckDestroyed();
			if (!StopTracingTransmittanceThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:StopTracingTransmittanceThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StopTracingTransmittanceThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StopTracingTransmittanceThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:StopTracingTransmittanceThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StopTracingTransmittanceThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759875870720533uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:AerialPespectiveRayleighScatteringStartDistance")]
	public float AerialPespectiveRayleighScatteringStartDistance
	{
		get
		{
			CheckDestroyed();
			if (!AerialPespectiveRayleighScatteringStartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:AerialPespectiveRayleighScatteringStartDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AerialPespectiveRayleighScatteringStartDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AerialPespectiveRayleighScatteringStartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:AerialPespectiveRayleighScatteringStartDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AerialPespectiveRayleighScatteringStartDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759875870720533uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:AerialPespectiveRayleighScatteringFadeDistance")]
	public float AerialPespectiveRayleighScatteringFadeDistance
	{
		get
		{
			CheckDestroyed();
			if (!AerialPespectiveRayleighScatteringFadeDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:AerialPespectiveRayleighScatteringFadeDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AerialPespectiveRayleighScatteringFadeDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AerialPespectiveRayleighScatteringFadeDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:AerialPespectiveRayleighScatteringFadeDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AerialPespectiveRayleighScatteringFadeDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759875870720533uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:AerialPespectiveMieScatteringStartDistance")]
	public float AerialPespectiveMieScatteringStartDistance
	{
		get
		{
			CheckDestroyed();
			if (!AerialPespectiveMieScatteringStartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:AerialPespectiveMieScatteringStartDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AerialPespectiveMieScatteringStartDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AerialPespectiveMieScatteringStartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:AerialPespectiveMieScatteringStartDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AerialPespectiveMieScatteringStartDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759875870720533uL)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:AerialPespectiveMieScatteringFadeDistance")]
	public float AerialPespectiveMieScatteringFadeDistance
	{
		get
		{
			CheckDestroyed();
			if (!AerialPespectiveMieScatteringFadeDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:AerialPespectiveMieScatteringFadeDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AerialPespectiveMieScatteringFadeDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AerialPespectiveMieScatteringFadeDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VolumetricCloudComponent:AerialPespectiveMieScatteringFadeDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AerialPespectiveMieScatteringFadeDistance_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetViewSampleCountScale")]
	public unsafe void SetViewSampleCountScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetViewSampleCountScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetViewSampleCountScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewSampleCountScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewSampleCountScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetViewSampleCountScale_NewValue_Offset), 0, SetViewSampleCountScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewSampleCountScale_FunctionAddress, intPtr, SetViewSampleCountScale_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetTracingStartMaxDistance")]
	public unsafe void SetTracingStartMaxDistance(float NewValue)
	{
		CheckDestroyed();
		if (!SetTracingStartMaxDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetTracingStartMaxDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTracingStartMaxDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTracingStartMaxDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTracingStartMaxDistance_NewValue_Offset), 0, SetTracingStartMaxDistance_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTracingStartMaxDistance_FunctionAddress, intPtr, SetTracingStartMaxDistance_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetTracingMaxDistance")]
	public unsafe void SetTracingMaxDistance(float NewValue)
	{
		CheckDestroyed();
		if (!SetTracingMaxDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetTracingMaxDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTracingMaxDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTracingMaxDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTracingMaxDistance_NewValue_Offset), 0, SetTracingMaxDistance_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTracingMaxDistance_FunctionAddress, intPtr, SetTracingMaxDistance_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetStopTracingTransmittanceThreshold")]
	public unsafe void SetStopTracingTransmittanceThreshold(float NewValue)
	{
		CheckDestroyed();
		if (!SetStopTracingTransmittanceThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetStopTracingTransmittanceThreshold");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStopTracingTransmittanceThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStopTracingTransmittanceThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStopTracingTransmittanceThreshold_NewValue_Offset), 0, SetStopTracingTransmittanceThreshold_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStopTracingTransmittanceThreshold_FunctionAddress, intPtr, SetStopTracingTransmittanceThreshold_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetSkyLightCloudBottomOcclusion")]
	public unsafe void SetSkyLightCloudBottomOcclusion(float NewValue)
	{
		CheckDestroyed();
		if (!SetSkyLightCloudBottomOcclusion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetSkyLightCloudBottomOcclusion");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkyLightCloudBottomOcclusion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkyLightCloudBottomOcclusion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSkyLightCloudBottomOcclusion_NewValue_Offset), 0, SetSkyLightCloudBottomOcclusion_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSkyLightCloudBottomOcclusion_FunctionAddress, intPtr, SetSkyLightCloudBottomOcclusion_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetShadowViewSampleCountScale")]
	public unsafe void SetShadowViewSampleCountScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetShadowViewSampleCountScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetShadowViewSampleCountScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowViewSampleCountScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowViewSampleCountScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetShadowViewSampleCountScale_NewValue_Offset), 0, SetShadowViewSampleCountScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowViewSampleCountScale_FunctionAddress, intPtr, SetShadowViewSampleCountScale_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetShadowTracingDistance")]
	public unsafe void SetShadowTracingDistance(float NewValue)
	{
		CheckDestroyed();
		if (!SetShadowTracingDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetShadowTracingDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowTracingDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowTracingDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetShadowTracingDistance_NewValue_Offset), 0, SetShadowTracingDistance_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowTracingDistance_FunctionAddress, intPtr, SetShadowTracingDistance_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetShadowReflectionViewSampleCountScale")]
	public unsafe void SetShadowReflectionViewSampleCountScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetShadowReflectionViewSampleCountScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetShadowReflectionViewSampleCountScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowReflectionViewSampleCountScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowReflectionViewSampleCountScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetShadowReflectionViewSampleCountScale_NewValue_Offset), 0, SetShadowReflectionViewSampleCountScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowReflectionViewSampleCountScale_FunctionAddress, intPtr, SetShadowReflectionViewSampleCountScale_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetReflectionViewSampleCountScale")]
	public unsafe void SetReflectionViewSampleCountScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetReflectionViewSampleCountScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetReflectionViewSampleCountScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReflectionViewSampleCountScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReflectionViewSampleCountScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetReflectionViewSampleCountScale_NewValue_Offset), 0, SetReflectionViewSampleCountScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReflectionViewSampleCountScale_FunctionAddress, intPtr, SetReflectionViewSampleCountScale_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetPlanetRadius")]
	public unsafe void SetPlanetRadius(float NewValue)
	{
		CheckDestroyed();
		if (!SetPlanetRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetPlanetRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlanetRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlanetRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlanetRadius_NewValue_Offset), 0, SetPlanetRadius_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlanetRadius_FunctionAddress, intPtr, SetPlanetRadius_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetMaterial")]
	public unsafe void SetMaterial(UMaterialInterface NewValue)
	{
		CheckDestroyed();
		if (!SetMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetMaterial_NewValue_Offset), 0, SetMaterial_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaterial_FunctionAddress, intPtr, SetMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetLayerHeight")]
	public unsafe void SetLayerHeight(float NewValue)
	{
		CheckDestroyed();
		if (!SetLayerHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetLayerHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLayerHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLayerHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLayerHeight_NewValue_Offset), 0, SetLayerHeight_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLayerHeight_FunctionAddress, intPtr, SetLayerHeight_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetLayerBottomAltitude")]
	public unsafe void SetLayerBottomAltitude(float NewValue)
	{
		CheckDestroyed();
		if (!SetLayerBottomAltitude_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetLayerBottomAltitude");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLayerBottomAltitude_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLayerBottomAltitude_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLayerBottomAltitude_NewValue_Offset), 0, SetLayerBottomAltitude_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLayerBottomAltitude_FunctionAddress, intPtr, SetLayerBottomAltitude_ParamsSize);
	}

	[UFunction(Flags = 75629571u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetGroundAlbedo")]
	public unsafe void SetGroundAlbedo(FColor NewValue)
	{
		CheckDestroyed();
		if (!SetGroundAlbedo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetGroundAlbedo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGroundAlbedo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGroundAlbedo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetGroundAlbedo_NewValue_Offset), 0, SetGroundAlbedo_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGroundAlbedo_FunctionAddress, intPtr, SetGroundAlbedo_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.VolumetricCloudComponent:SetbUsePerSampleAtmosphericLightTransmittance")]
	public unsafe void SetbUsePerSampleAtmosphericLightTransmittance(bool NewValue)
	{
		CheckDestroyed();
		if (!SetbUsePerSampleAtmosphericLightTransmittance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VolumetricCloudComponent:SetbUsePerSampleAtmosphericLightTransmittance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetbUsePerSampleAtmosphericLightTransmittance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetbUsePerSampleAtmosphericLightTransmittance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetbUsePerSampleAtmosphericLightTransmittance_NewValue_Offset), 0, SetbUsePerSampleAtmosphericLightTransmittance_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetbUsePerSampleAtmosphericLightTransmittance_FunctionAddress, intPtr, SetbUsePerSampleAtmosphericLightTransmittance_ParamsSize);
	}

	static UVolumetricCloudComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVolumetricCloudComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVolumetricCloudComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.VolumetricCloudComponent");
		LayerBottomAltitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LayerBottomAltitude");
		LayerBottomAltitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LayerBottomAltitude", Classes.FFloatProperty);
		LayerHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LayerHeight");
		LayerHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LayerHeight", Classes.FFloatProperty);
		TracingStartMaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TracingStartMaxDistance");
		TracingStartMaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TracingStartMaxDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TracingMaxDistanceMode_PropertyAddress, intPtr, "TracingMaxDistanceMode");
		TracingMaxDistanceMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TracingMaxDistanceMode");
		TracingMaxDistanceMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TracingMaxDistanceMode", Classes.FEnumProperty);
		TracingMaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TracingMaxDistance");
		TracingMaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TracingMaxDistance", Classes.FFloatProperty);
		PlanetRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlanetRadius");
		PlanetRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlanetRadius", Classes.FFloatProperty);
		GroundAlbedo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroundAlbedo");
		GroundAlbedo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroundAlbedo", Classes.FStructProperty);
		Material_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Material");
		Material_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UsePerSampleAtmosphericLightTransmittance_PropertyAddress, intPtr, "bUsePerSampleAtmosphericLightTransmittance");
		UsePerSampleAtmosphericLightTransmittance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUsePerSampleAtmosphericLightTransmittance");
		UsePerSampleAtmosphericLightTransmittance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUsePerSampleAtmosphericLightTransmittance", Classes.FBoolProperty);
		SkyLightCloudBottomOcclusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyLightCloudBottomOcclusion");
		SkyLightCloudBottomOcclusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyLightCloudBottomOcclusion", Classes.FFloatProperty);
		ViewSampleCountScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ViewSampleCountScale");
		ViewSampleCountScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ViewSampleCountScale", Classes.FFloatProperty);
		ReflectionViewSampleCountScaleValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReflectionViewSampleCountScaleValue");
		ReflectionViewSampleCountScaleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReflectionViewSampleCountScaleValue", Classes.FFloatProperty);
		ShadowViewSampleCountScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowViewSampleCountScale");
		ShadowViewSampleCountScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowViewSampleCountScale", Classes.FFloatProperty);
		ShadowReflectionViewSampleCountScaleValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowReflectionViewSampleCountScaleValue");
		ShadowReflectionViewSampleCountScaleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowReflectionViewSampleCountScaleValue", Classes.FFloatProperty);
		ShadowTracingDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowTracingDistance");
		ShadowTracingDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowTracingDistance", Classes.FFloatProperty);
		StopTracingTransmittanceThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StopTracingTransmittanceThreshold");
		StopTracingTransmittanceThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StopTracingTransmittanceThreshold", Classes.FFloatProperty);
		AerialPespectiveRayleighScatteringStartDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AerialPespectiveRayleighScatteringStartDistance");
		AerialPespectiveRayleighScatteringStartDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AerialPespectiveRayleighScatteringStartDistance", Classes.FFloatProperty);
		AerialPespectiveRayleighScatteringFadeDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AerialPespectiveRayleighScatteringFadeDistance");
		AerialPespectiveRayleighScatteringFadeDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AerialPespectiveRayleighScatteringFadeDistance", Classes.FFloatProperty);
		AerialPespectiveMieScatteringStartDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AerialPespectiveMieScatteringStartDistance");
		AerialPespectiveMieScatteringStartDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AerialPespectiveMieScatteringStartDistance", Classes.FFloatProperty);
		AerialPespectiveMieScatteringFadeDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AerialPespectiveMieScatteringFadeDistance");
		AerialPespectiveMieScatteringFadeDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AerialPespectiveMieScatteringFadeDistance", Classes.FFloatProperty);
		SetViewSampleCountScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetViewSampleCountScale");
		SetViewSampleCountScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewSampleCountScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewSampleCountScale_NewValue_PropertyAddress, SetViewSampleCountScale_FunctionAddress, "NewValue");
		SetViewSampleCountScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetViewSampleCountScale_FunctionAddress, "NewValue");
		SetViewSampleCountScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewSampleCountScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetViewSampleCountScale_IsValid = SetViewSampleCountScale_FunctionAddress != IntPtr.Zero && SetViewSampleCountScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetViewSampleCountScale", SetViewSampleCountScale_IsValid);
		SetTracingStartMaxDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTracingStartMaxDistance");
		SetTracingStartMaxDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTracingStartMaxDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTracingStartMaxDistance_NewValue_PropertyAddress, SetTracingStartMaxDistance_FunctionAddress, "NewValue");
		SetTracingStartMaxDistance_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTracingStartMaxDistance_FunctionAddress, "NewValue");
		SetTracingStartMaxDistance_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTracingStartMaxDistance_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetTracingStartMaxDistance_IsValid = SetTracingStartMaxDistance_FunctionAddress != IntPtr.Zero && SetTracingStartMaxDistance_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetTracingStartMaxDistance", SetTracingStartMaxDistance_IsValid);
		SetTracingMaxDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTracingMaxDistance");
		SetTracingMaxDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTracingMaxDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTracingMaxDistance_NewValue_PropertyAddress, SetTracingMaxDistance_FunctionAddress, "NewValue");
		SetTracingMaxDistance_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTracingMaxDistance_FunctionAddress, "NewValue");
		SetTracingMaxDistance_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTracingMaxDistance_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetTracingMaxDistance_IsValid = SetTracingMaxDistance_FunctionAddress != IntPtr.Zero && SetTracingMaxDistance_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetTracingMaxDistance", SetTracingMaxDistance_IsValid);
		SetStopTracingTransmittanceThreshold_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStopTracingTransmittanceThreshold");
		SetStopTracingTransmittanceThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStopTracingTransmittanceThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStopTracingTransmittanceThreshold_NewValue_PropertyAddress, SetStopTracingTransmittanceThreshold_FunctionAddress, "NewValue");
		SetStopTracingTransmittanceThreshold_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStopTracingTransmittanceThreshold_FunctionAddress, "NewValue");
		SetStopTracingTransmittanceThreshold_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStopTracingTransmittanceThreshold_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetStopTracingTransmittanceThreshold_IsValid = SetStopTracingTransmittanceThreshold_FunctionAddress != IntPtr.Zero && SetStopTracingTransmittanceThreshold_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetStopTracingTransmittanceThreshold", SetStopTracingTransmittanceThreshold_IsValid);
		SetSkyLightCloudBottomOcclusion_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSkyLightCloudBottomOcclusion");
		SetSkyLightCloudBottomOcclusion_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkyLightCloudBottomOcclusion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkyLightCloudBottomOcclusion_NewValue_PropertyAddress, SetSkyLightCloudBottomOcclusion_FunctionAddress, "NewValue");
		SetSkyLightCloudBottomOcclusion_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSkyLightCloudBottomOcclusion_FunctionAddress, "NewValue");
		SetSkyLightCloudBottomOcclusion_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkyLightCloudBottomOcclusion_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetSkyLightCloudBottomOcclusion_IsValid = SetSkyLightCloudBottomOcclusion_FunctionAddress != IntPtr.Zero && SetSkyLightCloudBottomOcclusion_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetSkyLightCloudBottomOcclusion", SetSkyLightCloudBottomOcclusion_IsValid);
		SetShadowViewSampleCountScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowViewSampleCountScale");
		SetShadowViewSampleCountScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowViewSampleCountScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowViewSampleCountScale_NewValue_PropertyAddress, SetShadowViewSampleCountScale_FunctionAddress, "NewValue");
		SetShadowViewSampleCountScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowViewSampleCountScale_FunctionAddress, "NewValue");
		SetShadowViewSampleCountScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowViewSampleCountScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetShadowViewSampleCountScale_IsValid = SetShadowViewSampleCountScale_FunctionAddress != IntPtr.Zero && SetShadowViewSampleCountScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetShadowViewSampleCountScale", SetShadowViewSampleCountScale_IsValid);
		SetShadowTracingDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowTracingDistance");
		SetShadowTracingDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowTracingDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowTracingDistance_NewValue_PropertyAddress, SetShadowTracingDistance_FunctionAddress, "NewValue");
		SetShadowTracingDistance_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowTracingDistance_FunctionAddress, "NewValue");
		SetShadowTracingDistance_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowTracingDistance_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetShadowTracingDistance_IsValid = SetShadowTracingDistance_FunctionAddress != IntPtr.Zero && SetShadowTracingDistance_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetShadowTracingDistance", SetShadowTracingDistance_IsValid);
		SetShadowReflectionViewSampleCountScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowReflectionViewSampleCountScale");
		SetShadowReflectionViewSampleCountScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowReflectionViewSampleCountScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowReflectionViewSampleCountScale_NewValue_PropertyAddress, SetShadowReflectionViewSampleCountScale_FunctionAddress, "NewValue");
		SetShadowReflectionViewSampleCountScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowReflectionViewSampleCountScale_FunctionAddress, "NewValue");
		SetShadowReflectionViewSampleCountScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowReflectionViewSampleCountScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetShadowReflectionViewSampleCountScale_IsValid = SetShadowReflectionViewSampleCountScale_FunctionAddress != IntPtr.Zero && SetShadowReflectionViewSampleCountScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetShadowReflectionViewSampleCountScale", SetShadowReflectionViewSampleCountScale_IsValid);
		SetReflectionViewSampleCountScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetReflectionViewSampleCountScale");
		SetReflectionViewSampleCountScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReflectionViewSampleCountScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReflectionViewSampleCountScale_NewValue_PropertyAddress, SetReflectionViewSampleCountScale_FunctionAddress, "NewValue");
		SetReflectionViewSampleCountScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetReflectionViewSampleCountScale_FunctionAddress, "NewValue");
		SetReflectionViewSampleCountScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReflectionViewSampleCountScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetReflectionViewSampleCountScale_IsValid = SetReflectionViewSampleCountScale_FunctionAddress != IntPtr.Zero && SetReflectionViewSampleCountScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetReflectionViewSampleCountScale", SetReflectionViewSampleCountScale_IsValid);
		SetPlanetRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlanetRadius");
		SetPlanetRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlanetRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlanetRadius_NewValue_PropertyAddress, SetPlanetRadius_FunctionAddress, "NewValue");
		SetPlanetRadius_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPlanetRadius_FunctionAddress, "NewValue");
		SetPlanetRadius_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlanetRadius_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetPlanetRadius_IsValid = SetPlanetRadius_FunctionAddress != IntPtr.Zero && SetPlanetRadius_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetPlanetRadius", SetPlanetRadius_IsValid);
		SetMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaterial");
		SetMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_NewValue_PropertyAddress, SetMaterial_FunctionAddress, "NewValue");
		SetMaterial_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "NewValue");
		SetMaterial_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "NewValue", Classes.FObjectProperty);
		SetMaterial_IsValid = SetMaterial_FunctionAddress != IntPtr.Zero && SetMaterial_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetMaterial", SetMaterial_IsValid);
		SetLayerHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLayerHeight");
		SetLayerHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLayerHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLayerHeight_NewValue_PropertyAddress, SetLayerHeight_FunctionAddress, "NewValue");
		SetLayerHeight_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLayerHeight_FunctionAddress, "NewValue");
		SetLayerHeight_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayerHeight_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetLayerHeight_IsValid = SetLayerHeight_FunctionAddress != IntPtr.Zero && SetLayerHeight_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetLayerHeight", SetLayerHeight_IsValid);
		SetLayerBottomAltitude_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLayerBottomAltitude");
		SetLayerBottomAltitude_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLayerBottomAltitude_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLayerBottomAltitude_NewValue_PropertyAddress, SetLayerBottomAltitude_FunctionAddress, "NewValue");
		SetLayerBottomAltitude_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLayerBottomAltitude_FunctionAddress, "NewValue");
		SetLayerBottomAltitude_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayerBottomAltitude_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetLayerBottomAltitude_IsValid = SetLayerBottomAltitude_FunctionAddress != IntPtr.Zero && SetLayerBottomAltitude_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetLayerBottomAltitude", SetLayerBottomAltitude_IsValid);
		SetGroundAlbedo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGroundAlbedo");
		SetGroundAlbedo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGroundAlbedo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGroundAlbedo_NewValue_PropertyAddress, SetGroundAlbedo_FunctionAddress, "NewValue");
		SetGroundAlbedo_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetGroundAlbedo_FunctionAddress, "NewValue");
		SetGroundAlbedo_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGroundAlbedo_FunctionAddress, "NewValue", Classes.FStructProperty);
		SetGroundAlbedo_IsValid = SetGroundAlbedo_FunctionAddress != IntPtr.Zero && SetGroundAlbedo_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetGroundAlbedo", SetGroundAlbedo_IsValid);
		SetbUsePerSampleAtmosphericLightTransmittance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetbUsePerSampleAtmosphericLightTransmittance");
		SetbUsePerSampleAtmosphericLightTransmittance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetbUsePerSampleAtmosphericLightTransmittance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetbUsePerSampleAtmosphericLightTransmittance_NewValue_PropertyAddress, SetbUsePerSampleAtmosphericLightTransmittance_FunctionAddress, "NewValue");
		SetbUsePerSampleAtmosphericLightTransmittance_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetbUsePerSampleAtmosphericLightTransmittance_FunctionAddress, "NewValue");
		SetbUsePerSampleAtmosphericLightTransmittance_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetbUsePerSampleAtmosphericLightTransmittance_FunctionAddress, "NewValue", Classes.FBoolProperty);
		SetbUsePerSampleAtmosphericLightTransmittance_IsValid = SetbUsePerSampleAtmosphericLightTransmittance_FunctionAddress != IntPtr.Zero && SetbUsePerSampleAtmosphericLightTransmittance_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VolumetricCloudComponent:SetbUsePerSampleAtmosphericLightTransmittance", SetbUsePerSampleAtmosphericLightTransmittance_IsValid);
	}
}
