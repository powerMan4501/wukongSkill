using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)820523172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SkyAtmosphereComponent", "Engine", UnrealModuleType.Engine)]
public class USkyAtmosphereComponent : USceneComponent
{
	private static bool TransformMode_IsValid;

	private static FFieldAddress TransformMode_PropertyAddress;

	private static int TransformMode_Offset;

	private static bool BottomRadius_IsValid;

	private static int BottomRadius_Offset;

	private static bool GroundAlbedo_IsValid;

	private static int GroundAlbedo_Offset;

	private static bool AtmosphereHeight_IsValid;

	private static int AtmosphereHeight_Offset;

	private static bool MultiScatteringFactor_IsValid;

	private static int MultiScatteringFactor_Offset;

	private static bool TraceSampleCountScale_IsValid;

	private static int TraceSampleCountScale_Offset;

	private static bool RayleighScatteringScale_IsValid;

	private static int RayleighScatteringScale_Offset;

	private static bool RayleighScattering_IsValid;

	private static int RayleighScattering_Offset;

	private static bool RayleighExponentialDistribution_IsValid;

	private static int RayleighExponentialDistribution_Offset;

	private static bool MieScatteringScale_IsValid;

	private static int MieScatteringScale_Offset;

	private static bool MieScattering_IsValid;

	private static int MieScattering_Offset;

	private static bool MieAbsorptionScale_IsValid;

	private static int MieAbsorptionScale_Offset;

	private static bool MieAbsorption_IsValid;

	private static int MieAbsorption_Offset;

	private static bool MieAnisotropy_IsValid;

	private static int MieAnisotropy_Offset;

	private static bool MieExponentialDistribution_IsValid;

	private static int MieExponentialDistribution_Offset;

	private static bool OtherAbsorptionScale_IsValid;

	private static int OtherAbsorptionScale_Offset;

	private static bool OtherAbsorption_IsValid;

	private static int OtherAbsorption_Offset;

	private static bool OtherTentDistribution_IsValid;

	private static int OtherTentDistribution_Offset;

	private static bool SkyLuminanceFactor_IsValid;

	private static int SkyLuminanceFactor_Offset;

	private static bool AerialPespectiveViewDistanceScale_IsValid;

	private static int AerialPespectiveViewDistanceScale_Offset;

	private static bool HeightFogContribution_IsValid;

	private static int HeightFogContribution_Offset;

	private static bool TransmittanceMinLightElevationAngle_IsValid;

	private static int TransmittanceMinLightElevationAngle_Offset;

	private static bool AerialPerspectiveStartDepth_IsValid;

	private static int AerialPerspectiveStartDepth_Offset;

	private static bool SetSkyLuminanceFactor_IsValid;

	private static IntPtr SetSkyLuminanceFactor_FunctionAddress;

	private static int SetSkyLuminanceFactor_ParamsSize;

	private static bool SetSkyLuminanceFactor_NewValue_IsValid;

	private static FFieldAddress SetSkyLuminanceFactor_NewValue_PropertyAddress;

	private static int SetSkyLuminanceFactor_NewValue_Offset;

	private static bool SetRayleighScatteringScale_IsValid;

	private static IntPtr SetRayleighScatteringScale_FunctionAddress;

	private static int SetRayleighScatteringScale_ParamsSize;

	private static bool SetRayleighScatteringScale_NewValue_IsValid;

	private static FFieldAddress SetRayleighScatteringScale_NewValue_PropertyAddress;

	private static int SetRayleighScatteringScale_NewValue_Offset;

	private static bool SetRayleighScattering_IsValid;

	private static IntPtr SetRayleighScattering_FunctionAddress;

	private static int SetRayleighScattering_ParamsSize;

	private static bool SetRayleighScattering_NewValue_IsValid;

	private static FFieldAddress SetRayleighScattering_NewValue_PropertyAddress;

	private static int SetRayleighScattering_NewValue_Offset;

	private static bool SetRayleighExponentialDistribution_IsValid;

	private static IntPtr SetRayleighExponentialDistribution_FunctionAddress;

	private static int SetRayleighExponentialDistribution_ParamsSize;

	private static bool SetRayleighExponentialDistribution_NewValue_IsValid;

	private static FFieldAddress SetRayleighExponentialDistribution_NewValue_PropertyAddress;

	private static int SetRayleighExponentialDistribution_NewValue_Offset;

	private static bool SetOtherAbsorptionScale_IsValid;

	private static IntPtr SetOtherAbsorptionScale_FunctionAddress;

	private static int SetOtherAbsorptionScale_ParamsSize;

	private static bool SetOtherAbsorptionScale_NewValue_IsValid;

	private static FFieldAddress SetOtherAbsorptionScale_NewValue_PropertyAddress;

	private static int SetOtherAbsorptionScale_NewValue_Offset;

	private static bool SetOtherAbsorption_IsValid;

	private static IntPtr SetOtherAbsorption_FunctionAddress;

	private static int SetOtherAbsorption_ParamsSize;

	private static bool SetOtherAbsorption_NewValue_IsValid;

	private static FFieldAddress SetOtherAbsorption_NewValue_PropertyAddress;

	private static int SetOtherAbsorption_NewValue_Offset;

	private static bool SetMultiScatteringFactor_IsValid;

	private static IntPtr SetMultiScatteringFactor_FunctionAddress;

	private static int SetMultiScatteringFactor_ParamsSize;

	private static bool SetMultiScatteringFactor_NewValue_IsValid;

	private static FFieldAddress SetMultiScatteringFactor_NewValue_PropertyAddress;

	private static int SetMultiScatteringFactor_NewValue_Offset;

	private static bool SetMieScatteringScale_IsValid;

	private static IntPtr SetMieScatteringScale_FunctionAddress;

	private static int SetMieScatteringScale_ParamsSize;

	private static bool SetMieScatteringScale_NewValue_IsValid;

	private static FFieldAddress SetMieScatteringScale_NewValue_PropertyAddress;

	private static int SetMieScatteringScale_NewValue_Offset;

	private static bool SetMieScattering_IsValid;

	private static IntPtr SetMieScattering_FunctionAddress;

	private static int SetMieScattering_ParamsSize;

	private static bool SetMieScattering_NewValue_IsValid;

	private static FFieldAddress SetMieScattering_NewValue_PropertyAddress;

	private static int SetMieScattering_NewValue_Offset;

	private static bool SetMieExponentialDistribution_IsValid;

	private static IntPtr SetMieExponentialDistribution_FunctionAddress;

	private static int SetMieExponentialDistribution_ParamsSize;

	private static bool SetMieExponentialDistribution_NewValue_IsValid;

	private static FFieldAddress SetMieExponentialDistribution_NewValue_PropertyAddress;

	private static int SetMieExponentialDistribution_NewValue_Offset;

	private static bool SetMieAnisotropy_IsValid;

	private static IntPtr SetMieAnisotropy_FunctionAddress;

	private static int SetMieAnisotropy_ParamsSize;

	private static bool SetMieAnisotropy_NewValue_IsValid;

	private static FFieldAddress SetMieAnisotropy_NewValue_PropertyAddress;

	private static int SetMieAnisotropy_NewValue_Offset;

	private static bool SetMieAbsorptionScale_IsValid;

	private static IntPtr SetMieAbsorptionScale_FunctionAddress;

	private static int SetMieAbsorptionScale_ParamsSize;

	private static bool SetMieAbsorptionScale_NewValue_IsValid;

	private static FFieldAddress SetMieAbsorptionScale_NewValue_PropertyAddress;

	private static int SetMieAbsorptionScale_NewValue_Offset;

	private static bool SetMieAbsorption_IsValid;

	private static IntPtr SetMieAbsorption_FunctionAddress;

	private static int SetMieAbsorption_ParamsSize;

	private static bool SetMieAbsorption_NewValue_IsValid;

	private static FFieldAddress SetMieAbsorption_NewValue_PropertyAddress;

	private static int SetMieAbsorption_NewValue_Offset;

	private static bool SetHeightFogContribution_IsValid;

	private static IntPtr SetHeightFogContribution_FunctionAddress;

	private static int SetHeightFogContribution_ParamsSize;

	private static bool SetHeightFogContribution_NewValue_IsValid;

	private static FFieldAddress SetHeightFogContribution_NewValue_PropertyAddress;

	private static int SetHeightFogContribution_NewValue_Offset;

	private static bool SetAtmosphereHeight_IsValid;

	private static IntPtr SetAtmosphereHeight_FunctionAddress;

	private static int SetAtmosphereHeight_ParamsSize;

	private static bool SetAtmosphereHeight_NewValue_IsValid;

	private static FFieldAddress SetAtmosphereHeight_NewValue_PropertyAddress;

	private static int SetAtmosphereHeight_NewValue_Offset;

	private static bool SetAerialPespectiveViewDistanceScale_IsValid;

	private static IntPtr SetAerialPespectiveViewDistanceScale_FunctionAddress;

	private static int SetAerialPespectiveViewDistanceScale_ParamsSize;

	private static bool SetAerialPespectiveViewDistanceScale_NewValue_IsValid;

	private static FFieldAddress SetAerialPespectiveViewDistanceScale_NewValue_PropertyAddress;

	private static int SetAerialPespectiveViewDistanceScale_NewValue_Offset;

	private static bool OverrideAtmosphereLightDirection_IsValid;

	private static IntPtr OverrideAtmosphereLightDirection_FunctionAddress;

	private static int OverrideAtmosphereLightDirection_ParamsSize;

	private static bool OverrideAtmosphereLightDirection_AtmosphereLightIndex_IsValid;

	private static FFieldAddress OverrideAtmosphereLightDirection_AtmosphereLightIndex_PropertyAddress;

	private static int OverrideAtmosphereLightDirection_AtmosphereLightIndex_Offset;

	private static bool OverrideAtmosphereLightDirection_LightDirection_IsValid;

	private static FFieldAddress OverrideAtmosphereLightDirection_LightDirection_PropertyAddress;

	private static int OverrideAtmosphereLightDirection_LightDirection_Offset;

	private static bool GetAtmosphereTransmitanceOnGroundAtPlanetTop_IsValid;

	private static IntPtr GetAtmosphereTransmitanceOnGroundAtPlanetTop_FunctionAddress;

	private static int GetAtmosphereTransmitanceOnGroundAtPlanetTop_ParamsSize;

	private static bool GetAtmosphereTransmitanceOnGroundAtPlanetTop_DirectionalLight_IsValid;

	private static FFieldAddress GetAtmosphereTransmitanceOnGroundAtPlanetTop_DirectionalLight_PropertyAddress;

	private static int GetAtmosphereTransmitanceOnGroundAtPlanetTop_DirectionalLight_Offset;

	private static bool GetAtmosphereTransmitanceOnGroundAtPlanetTop_ReturnValue_IsValid;

	private static FFieldAddress GetAtmosphereTransmitanceOnGroundAtPlanetTop_ReturnValue_PropertyAddress;

	private static int GetAtmosphereTransmitanceOnGroundAtPlanetTop_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:TransformMode")]
	public ESkyAtmosphereTransformMode TransformMode
	{
		get
		{
			CheckDestroyed();
			if (!TransformMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:TransformMode");
				return ESkyAtmosphereTransformMode.PlanetTopAtAbsoluteWorldOrigin;
			}
			return EnumMarshaler<ESkyAtmosphereTransformMode>.FromNative(IntPtr.Add(base.Address, TransformMode_Offset), 0, TransformMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TransformMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:TransformMode");
			}
			else
			{
				EnumMarshaler<ESkyAtmosphereTransformMode>.ToNative(IntPtr.Add(base.Address, TransformMode_Offset), 0, TransformMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:BottomRadius")]
	public float BottomRadius
	{
		get
		{
			CheckDestroyed();
			if (!BottomRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:BottomRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BottomRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BottomRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:BottomRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BottomRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:GroundAlbedo")]
	public FColor GroundAlbedo
	{
		get
		{
			CheckDestroyed();
			if (!GroundAlbedo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:GroundAlbedo");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, GroundAlbedo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroundAlbedo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:GroundAlbedo");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, GroundAlbedo_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:AtmosphereHeight")]
	public float AtmosphereHeight
	{
		get
		{
			CheckDestroyed();
			if (!AtmosphereHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:AtmosphereHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AtmosphereHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AtmosphereHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:AtmosphereHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AtmosphereHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:MultiScatteringFactor")]
	public float MultiScatteringFactor
	{
		get
		{
			CheckDestroyed();
			if (!MultiScatteringFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MultiScatteringFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MultiScatteringFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiScatteringFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MultiScatteringFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MultiScatteringFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:TraceSampleCountScale")]
	public float TraceSampleCountScale
	{
		get
		{
			CheckDestroyed();
			if (!TraceSampleCountScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:TraceSampleCountScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceSampleCountScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceSampleCountScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:TraceSampleCountScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceSampleCountScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:RayleighScatteringScale")]
	public float RayleighScatteringScale
	{
		get
		{
			CheckDestroyed();
			if (!RayleighScatteringScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:RayleighScatteringScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RayleighScatteringScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RayleighScatteringScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:RayleighScatteringScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RayleighScatteringScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:RayleighScattering")]
	public FLinearColor RayleighScattering
	{
		get
		{
			CheckDestroyed();
			if (!RayleighScattering_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:RayleighScattering");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, RayleighScattering_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RayleighScattering_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:RayleighScattering");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, RayleighScattering_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:RayleighExponentialDistribution")]
	public float RayleighExponentialDistribution
	{
		get
		{
			CheckDestroyed();
			if (!RayleighExponentialDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:RayleighExponentialDistribution");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RayleighExponentialDistribution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RayleighExponentialDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:RayleighExponentialDistribution");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RayleighExponentialDistribution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:MieScatteringScale")]
	public float MieScatteringScale
	{
		get
		{
			CheckDestroyed();
			if (!MieScatteringScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieScatteringScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MieScatteringScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MieScatteringScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieScatteringScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MieScatteringScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:MieScattering")]
	public FLinearColor MieScattering
	{
		get
		{
			CheckDestroyed();
			if (!MieScattering_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieScattering");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, MieScattering_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MieScattering_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieScattering");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, MieScattering_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:MieAbsorptionScale")]
	public float MieAbsorptionScale
	{
		get
		{
			CheckDestroyed();
			if (!MieAbsorptionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieAbsorptionScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MieAbsorptionScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MieAbsorptionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieAbsorptionScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MieAbsorptionScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:MieAbsorption")]
	public FLinearColor MieAbsorption
	{
		get
		{
			CheckDestroyed();
			if (!MieAbsorption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieAbsorption");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, MieAbsorption_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MieAbsorption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieAbsorption");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, MieAbsorption_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:MieAnisotropy")]
	public float MieAnisotropy
	{
		get
		{
			CheckDestroyed();
			if (!MieAnisotropy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieAnisotropy");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MieAnisotropy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MieAnisotropy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieAnisotropy");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MieAnisotropy_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:MieExponentialDistribution")]
	public float MieExponentialDistribution
	{
		get
		{
			CheckDestroyed();
			if (!MieExponentialDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieExponentialDistribution");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MieExponentialDistribution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MieExponentialDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:MieExponentialDistribution");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MieExponentialDistribution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:OtherAbsorptionScale")]
	public float OtherAbsorptionScale
	{
		get
		{
			CheckDestroyed();
			if (!OtherAbsorptionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:OtherAbsorptionScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OtherAbsorptionScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OtherAbsorptionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:OtherAbsorptionScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OtherAbsorptionScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:OtherAbsorption")]
	public FLinearColor OtherAbsorption
	{
		get
		{
			CheckDestroyed();
			if (!OtherAbsorption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:OtherAbsorption");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, OtherAbsorption_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OtherAbsorption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:OtherAbsorption");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, OtherAbsorption_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:OtherTentDistribution")]
	public FTentDistribution OtherTentDistribution
	{
		get
		{
			CheckDestroyed();
			if (!OtherTentDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:OtherTentDistribution");
				return default(FTentDistribution);
			}
			return FTentDistribution.FromNative(IntPtr.Add(base.Address, OtherTentDistribution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OtherTentDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:OtherTentDistribution");
			}
			else
			{
				FTentDistribution.ToNative(IntPtr.Add(base.Address, OtherTentDistribution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SkyLuminanceFactor")]
	public FLinearColor SkyLuminanceFactor
	{
		get
		{
			CheckDestroyed();
			if (!SkyLuminanceFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:SkyLuminanceFactor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, SkyLuminanceFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkyLuminanceFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:SkyLuminanceFactor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, SkyLuminanceFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:AerialPespectiveViewDistanceScale")]
	public float AerialPespectiveViewDistanceScale
	{
		get
		{
			CheckDestroyed();
			if (!AerialPespectiveViewDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:AerialPespectiveViewDistanceScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AerialPespectiveViewDistanceScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AerialPespectiveViewDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:AerialPespectiveViewDistanceScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AerialPespectiveViewDistanceScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:HeightFogContribution")]
	public float HeightFogContribution
	{
		get
		{
			CheckDestroyed();
			if (!HeightFogContribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:HeightFogContribution");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeightFogContribution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeightFogContribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:HeightFogContribution");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeightFogContribution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:TransmittanceMinLightElevationAngle")]
	public float TransmittanceMinLightElevationAngle
	{
		get
		{
			CheckDestroyed();
			if (!TransmittanceMinLightElevationAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:TransmittanceMinLightElevationAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TransmittanceMinLightElevationAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TransmittanceMinLightElevationAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:TransmittanceMinLightElevationAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TransmittanceMinLightElevationAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:AerialPerspectiveStartDepth")]
	public float AerialPerspectiveStartDepth
	{
		get
		{
			CheckDestroyed();
			if (!AerialPerspectiveStartDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:AerialPerspectiveStartDepth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AerialPerspectiveStartDepth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AerialPerspectiveStartDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphereComponent:AerialPerspectiveStartDepth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AerialPerspectiveStartDepth_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629571u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetSkyLuminanceFactor")]
	public unsafe void SetSkyLuminanceFactor(FLinearColor NewValue)
	{
		CheckDestroyed();
		if (!SetSkyLuminanceFactor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetSkyLuminanceFactor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkyLuminanceFactor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkyLuminanceFactor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetSkyLuminanceFactor_NewValue_Offset), 0, SetSkyLuminanceFactor_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSkyLuminanceFactor_FunctionAddress, intPtr, SetSkyLuminanceFactor_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetRayleighScatteringScale")]
	public unsafe void SetRayleighScatteringScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetRayleighScatteringScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetRayleighScatteringScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRayleighScatteringScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRayleighScatteringScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRayleighScatteringScale_NewValue_Offset), 0, SetRayleighScatteringScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRayleighScatteringScale_FunctionAddress, intPtr, SetRayleighScatteringScale_ParamsSize);
	}

	[UFunction(Flags = 75629571u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetRayleighScattering")]
	public unsafe void SetRayleighScattering(FLinearColor NewValue)
	{
		CheckDestroyed();
		if (!SetRayleighScattering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetRayleighScattering");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRayleighScattering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRayleighScattering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetRayleighScattering_NewValue_Offset), 0, SetRayleighScattering_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRayleighScattering_FunctionAddress, intPtr, SetRayleighScattering_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetRayleighExponentialDistribution")]
	public unsafe void SetRayleighExponentialDistribution(float NewValue)
	{
		CheckDestroyed();
		if (!SetRayleighExponentialDistribution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetRayleighExponentialDistribution");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRayleighExponentialDistribution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRayleighExponentialDistribution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRayleighExponentialDistribution_NewValue_Offset), 0, SetRayleighExponentialDistribution_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRayleighExponentialDistribution_FunctionAddress, intPtr, SetRayleighExponentialDistribution_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetOtherAbsorptionScale")]
	public unsafe void SetOtherAbsorptionScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetOtherAbsorptionScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetOtherAbsorptionScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOtherAbsorptionScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOtherAbsorptionScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOtherAbsorptionScale_NewValue_Offset), 0, SetOtherAbsorptionScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOtherAbsorptionScale_FunctionAddress, intPtr, SetOtherAbsorptionScale_ParamsSize);
	}

	[UFunction(Flags = 75629571u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetOtherAbsorption")]
	public unsafe void SetOtherAbsorption(FLinearColor NewValue)
	{
		CheckDestroyed();
		if (!SetOtherAbsorption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetOtherAbsorption");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOtherAbsorption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOtherAbsorption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetOtherAbsorption_NewValue_Offset), 0, SetOtherAbsorption_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOtherAbsorption_FunctionAddress, intPtr, SetOtherAbsorption_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetMultiScatteringFactor")]
	public unsafe void SetMultiScatteringFactor(float NewValue)
	{
		CheckDestroyed();
		if (!SetMultiScatteringFactor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetMultiScatteringFactor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMultiScatteringFactor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMultiScatteringFactor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMultiScatteringFactor_NewValue_Offset), 0, SetMultiScatteringFactor_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMultiScatteringFactor_FunctionAddress, intPtr, SetMultiScatteringFactor_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetMieScatteringScale")]
	public unsafe void SetMieScatteringScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetMieScatteringScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetMieScatteringScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMieScatteringScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMieScatteringScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMieScatteringScale_NewValue_Offset), 0, SetMieScatteringScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMieScatteringScale_FunctionAddress, intPtr, SetMieScatteringScale_ParamsSize);
	}

	[UFunction(Flags = 75629571u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetMieScattering")]
	public unsafe void SetMieScattering(FLinearColor NewValue)
	{
		CheckDestroyed();
		if (!SetMieScattering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetMieScattering");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMieScattering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMieScattering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetMieScattering_NewValue_Offset), 0, SetMieScattering_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMieScattering_FunctionAddress, intPtr, SetMieScattering_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetMieExponentialDistribution")]
	public unsafe void SetMieExponentialDistribution(float NewValue)
	{
		CheckDestroyed();
		if (!SetMieExponentialDistribution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetMieExponentialDistribution");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMieExponentialDistribution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMieExponentialDistribution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMieExponentialDistribution_NewValue_Offset), 0, SetMieExponentialDistribution_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMieExponentialDistribution_FunctionAddress, intPtr, SetMieExponentialDistribution_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetMieAnisotropy")]
	public unsafe void SetMieAnisotropy(float NewValue)
	{
		CheckDestroyed();
		if (!SetMieAnisotropy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetMieAnisotropy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMieAnisotropy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMieAnisotropy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMieAnisotropy_NewValue_Offset), 0, SetMieAnisotropy_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMieAnisotropy_FunctionAddress, intPtr, SetMieAnisotropy_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetMieAbsorptionScale")]
	public unsafe void SetMieAbsorptionScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetMieAbsorptionScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetMieAbsorptionScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMieAbsorptionScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMieAbsorptionScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMieAbsorptionScale_NewValue_Offset), 0, SetMieAbsorptionScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMieAbsorptionScale_FunctionAddress, intPtr, SetMieAbsorptionScale_ParamsSize);
	}

	[UFunction(Flags = 75629571u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetMieAbsorption")]
	public unsafe void SetMieAbsorption(FLinearColor NewValue)
	{
		CheckDestroyed();
		if (!SetMieAbsorption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetMieAbsorption");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMieAbsorption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMieAbsorption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetMieAbsorption_NewValue_Offset), 0, SetMieAbsorption_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMieAbsorption_FunctionAddress, intPtr, SetMieAbsorption_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetHeightFogContribution")]
	public unsafe void SetHeightFogContribution(float NewValue)
	{
		CheckDestroyed();
		if (!SetHeightFogContribution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetHeightFogContribution");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHeightFogContribution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHeightFogContribution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetHeightFogContribution_NewValue_Offset), 0, SetHeightFogContribution_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHeightFogContribution_FunctionAddress, intPtr, SetHeightFogContribution_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetAtmosphereHeight")]
	public unsafe void SetAtmosphereHeight(float NewValue)
	{
		CheckDestroyed();
		if (!SetAtmosphereHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetAtmosphereHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAtmosphereHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAtmosphereHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAtmosphereHeight_NewValue_Offset), 0, SetAtmosphereHeight_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAtmosphereHeight_FunctionAddress, intPtr, SetAtmosphereHeight_ParamsSize);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:SetAerialPespectiveViewDistanceScale")]
	public unsafe void SetAerialPespectiveViewDistanceScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetAerialPespectiveViewDistanceScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:SetAerialPespectiveViewDistanceScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAerialPespectiveViewDistanceScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAerialPespectiveViewDistanceScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAerialPespectiveViewDistanceScale_NewValue_Offset), 0, SetAerialPespectiveViewDistanceScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAerialPespectiveViewDistanceScale_FunctionAddress, intPtr, SetAerialPespectiveViewDistanceScale_ParamsSize);
	}

	[UFunction(Flags = 79823875u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:OverrideAtmosphereLightDirection")]
	public unsafe void OverrideAtmosphereLightDirection(int AtmosphereLightIndex, FVector LightDirection)
	{
		CheckDestroyed();
		if (!OverrideAtmosphereLightDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:OverrideAtmosphereLightDirection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OverrideAtmosphereLightDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OverrideAtmosphereLightDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OverrideAtmosphereLightDirection_AtmosphereLightIndex_Offset), 0, OverrideAtmosphereLightDirection_AtmosphereLightIndex_PropertyAddress.Address, AtmosphereLightIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OverrideAtmosphereLightDirection_LightDirection_Offset), 0, OverrideAtmosphereLightDirection_LightDirection_PropertyAddress.Address, LightDirection);
		NativeReflection.InvokeFunctionOptimized(base.Address, OverrideAtmosphereLightDirection_FunctionAddress, intPtr, OverrideAtmosphereLightDirection_ParamsSize);
	}

	[UFunction(Flags = 75629571u)]
	[UMetaPath("/Script/Engine.SkyAtmosphereComponent:GetAtmosphereTransmitanceOnGroundAtPlanetTop")]
	public unsafe FLinearColor GetAtmosphereTransmitanceOnGroundAtPlanetTop(UDirectionalLightComponent DirectionalLight)
	{
		CheckDestroyed();
		if (!GetAtmosphereTransmitanceOnGroundAtPlanetTop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkyAtmosphereComponent:GetAtmosphereTransmitanceOnGroundAtPlanetTop");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAtmosphereTransmitanceOnGroundAtPlanetTop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAtmosphereTransmitanceOnGroundAtPlanetTop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDirectionalLightComponent>.ToNative(IntPtr.Add(intPtr, GetAtmosphereTransmitanceOnGroundAtPlanetTop_DirectionalLight_Offset), 0, GetAtmosphereTransmitanceOnGroundAtPlanetTop_DirectionalLight_PropertyAddress.Address, DirectionalLight);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAtmosphereTransmitanceOnGroundAtPlanetTop_FunctionAddress, intPtr, GetAtmosphereTransmitanceOnGroundAtPlanetTop_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetAtmosphereTransmitanceOnGroundAtPlanetTop_ReturnValue_Offset), 0, GetAtmosphereTransmitanceOnGroundAtPlanetTop_ReturnValue_PropertyAddress.Address);
	}

	static USkyAtmosphereComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USkyAtmosphereComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USkyAtmosphereComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SkyAtmosphereComponent");
		NativeReflectionCached.GetPropertyRef(ref TransformMode_PropertyAddress, intPtr, "TransformMode");
		TransformMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransformMode");
		TransformMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransformMode", Classes.FEnumProperty);
		BottomRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BottomRadius");
		BottomRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BottomRadius", Classes.FFloatProperty);
		GroundAlbedo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroundAlbedo");
		GroundAlbedo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroundAlbedo", Classes.FStructProperty);
		AtmosphereHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AtmosphereHeight");
		AtmosphereHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AtmosphereHeight", Classes.FFloatProperty);
		MultiScatteringFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MultiScatteringFactor");
		MultiScatteringFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MultiScatteringFactor", Classes.FFloatProperty);
		TraceSampleCountScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TraceSampleCountScale");
		TraceSampleCountScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TraceSampleCountScale", Classes.FFloatProperty);
		RayleighScatteringScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RayleighScatteringScale");
		RayleighScatteringScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RayleighScatteringScale", Classes.FFloatProperty);
		RayleighScattering_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RayleighScattering");
		RayleighScattering_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RayleighScattering", Classes.FStructProperty);
		RayleighExponentialDistribution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RayleighExponentialDistribution");
		RayleighExponentialDistribution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RayleighExponentialDistribution", Classes.FFloatProperty);
		MieScatteringScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MieScatteringScale");
		MieScatteringScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MieScatteringScale", Classes.FFloatProperty);
		MieScattering_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MieScattering");
		MieScattering_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MieScattering", Classes.FStructProperty);
		MieAbsorptionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MieAbsorptionScale");
		MieAbsorptionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MieAbsorptionScale", Classes.FFloatProperty);
		MieAbsorption_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MieAbsorption");
		MieAbsorption_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MieAbsorption", Classes.FStructProperty);
		MieAnisotropy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MieAnisotropy");
		MieAnisotropy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MieAnisotropy", Classes.FFloatProperty);
		MieExponentialDistribution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MieExponentialDistribution");
		MieExponentialDistribution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MieExponentialDistribution", Classes.FFloatProperty);
		OtherAbsorptionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OtherAbsorptionScale");
		OtherAbsorptionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OtherAbsorptionScale", Classes.FFloatProperty);
		OtherAbsorption_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OtherAbsorption");
		OtherAbsorption_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OtherAbsorption", Classes.FStructProperty);
		OtherTentDistribution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OtherTentDistribution");
		OtherTentDistribution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OtherTentDistribution", Classes.FStructProperty);
		SkyLuminanceFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyLuminanceFactor");
		SkyLuminanceFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyLuminanceFactor", Classes.FStructProperty);
		AerialPespectiveViewDistanceScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AerialPespectiveViewDistanceScale");
		AerialPespectiveViewDistanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AerialPespectiveViewDistanceScale", Classes.FFloatProperty);
		HeightFogContribution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeightFogContribution");
		HeightFogContribution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeightFogContribution", Classes.FFloatProperty);
		TransmittanceMinLightElevationAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransmittanceMinLightElevationAngle");
		TransmittanceMinLightElevationAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransmittanceMinLightElevationAngle", Classes.FFloatProperty);
		AerialPerspectiveStartDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AerialPerspectiveStartDepth");
		AerialPerspectiveStartDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AerialPerspectiveStartDepth", Classes.FFloatProperty);
		SetSkyLuminanceFactor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSkyLuminanceFactor");
		SetSkyLuminanceFactor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkyLuminanceFactor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkyLuminanceFactor_NewValue_PropertyAddress, SetSkyLuminanceFactor_FunctionAddress, "NewValue");
		SetSkyLuminanceFactor_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSkyLuminanceFactor_FunctionAddress, "NewValue");
		SetSkyLuminanceFactor_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkyLuminanceFactor_FunctionAddress, "NewValue", Classes.FStructProperty);
		SetSkyLuminanceFactor_IsValid = SetSkyLuminanceFactor_FunctionAddress != IntPtr.Zero && SetSkyLuminanceFactor_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetSkyLuminanceFactor", SetSkyLuminanceFactor_IsValid);
		SetRayleighScatteringScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRayleighScatteringScale");
		SetRayleighScatteringScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRayleighScatteringScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRayleighScatteringScale_NewValue_PropertyAddress, SetRayleighScatteringScale_FunctionAddress, "NewValue");
		SetRayleighScatteringScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRayleighScatteringScale_FunctionAddress, "NewValue");
		SetRayleighScatteringScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRayleighScatteringScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetRayleighScatteringScale_IsValid = SetRayleighScatteringScale_FunctionAddress != IntPtr.Zero && SetRayleighScatteringScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetRayleighScatteringScale", SetRayleighScatteringScale_IsValid);
		SetRayleighScattering_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRayleighScattering");
		SetRayleighScattering_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRayleighScattering_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRayleighScattering_NewValue_PropertyAddress, SetRayleighScattering_FunctionAddress, "NewValue");
		SetRayleighScattering_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRayleighScattering_FunctionAddress, "NewValue");
		SetRayleighScattering_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRayleighScattering_FunctionAddress, "NewValue", Classes.FStructProperty);
		SetRayleighScattering_IsValid = SetRayleighScattering_FunctionAddress != IntPtr.Zero && SetRayleighScattering_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetRayleighScattering", SetRayleighScattering_IsValid);
		SetRayleighExponentialDistribution_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRayleighExponentialDistribution");
		SetRayleighExponentialDistribution_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRayleighExponentialDistribution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRayleighExponentialDistribution_NewValue_PropertyAddress, SetRayleighExponentialDistribution_FunctionAddress, "NewValue");
		SetRayleighExponentialDistribution_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRayleighExponentialDistribution_FunctionAddress, "NewValue");
		SetRayleighExponentialDistribution_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRayleighExponentialDistribution_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetRayleighExponentialDistribution_IsValid = SetRayleighExponentialDistribution_FunctionAddress != IntPtr.Zero && SetRayleighExponentialDistribution_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetRayleighExponentialDistribution", SetRayleighExponentialDistribution_IsValid);
		SetOtherAbsorptionScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOtherAbsorptionScale");
		SetOtherAbsorptionScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOtherAbsorptionScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOtherAbsorptionScale_NewValue_PropertyAddress, SetOtherAbsorptionScale_FunctionAddress, "NewValue");
		SetOtherAbsorptionScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetOtherAbsorptionScale_FunctionAddress, "NewValue");
		SetOtherAbsorptionScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOtherAbsorptionScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetOtherAbsorptionScale_IsValid = SetOtherAbsorptionScale_FunctionAddress != IntPtr.Zero && SetOtherAbsorptionScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetOtherAbsorptionScale", SetOtherAbsorptionScale_IsValid);
		SetOtherAbsorption_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOtherAbsorption");
		SetOtherAbsorption_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOtherAbsorption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOtherAbsorption_NewValue_PropertyAddress, SetOtherAbsorption_FunctionAddress, "NewValue");
		SetOtherAbsorption_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetOtherAbsorption_FunctionAddress, "NewValue");
		SetOtherAbsorption_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOtherAbsorption_FunctionAddress, "NewValue", Classes.FStructProperty);
		SetOtherAbsorption_IsValid = SetOtherAbsorption_FunctionAddress != IntPtr.Zero && SetOtherAbsorption_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetOtherAbsorption", SetOtherAbsorption_IsValid);
		SetMultiScatteringFactor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMultiScatteringFactor");
		SetMultiScatteringFactor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMultiScatteringFactor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMultiScatteringFactor_NewValue_PropertyAddress, SetMultiScatteringFactor_FunctionAddress, "NewValue");
		SetMultiScatteringFactor_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMultiScatteringFactor_FunctionAddress, "NewValue");
		SetMultiScatteringFactor_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultiScatteringFactor_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetMultiScatteringFactor_IsValid = SetMultiScatteringFactor_FunctionAddress != IntPtr.Zero && SetMultiScatteringFactor_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetMultiScatteringFactor", SetMultiScatteringFactor_IsValid);
		SetMieScatteringScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMieScatteringScale");
		SetMieScatteringScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMieScatteringScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMieScatteringScale_NewValue_PropertyAddress, SetMieScatteringScale_FunctionAddress, "NewValue");
		SetMieScatteringScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMieScatteringScale_FunctionAddress, "NewValue");
		SetMieScatteringScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMieScatteringScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetMieScatteringScale_IsValid = SetMieScatteringScale_FunctionAddress != IntPtr.Zero && SetMieScatteringScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetMieScatteringScale", SetMieScatteringScale_IsValid);
		SetMieScattering_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMieScattering");
		SetMieScattering_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMieScattering_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMieScattering_NewValue_PropertyAddress, SetMieScattering_FunctionAddress, "NewValue");
		SetMieScattering_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMieScattering_FunctionAddress, "NewValue");
		SetMieScattering_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMieScattering_FunctionAddress, "NewValue", Classes.FStructProperty);
		SetMieScattering_IsValid = SetMieScattering_FunctionAddress != IntPtr.Zero && SetMieScattering_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetMieScattering", SetMieScattering_IsValid);
		SetMieExponentialDistribution_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMieExponentialDistribution");
		SetMieExponentialDistribution_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMieExponentialDistribution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMieExponentialDistribution_NewValue_PropertyAddress, SetMieExponentialDistribution_FunctionAddress, "NewValue");
		SetMieExponentialDistribution_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMieExponentialDistribution_FunctionAddress, "NewValue");
		SetMieExponentialDistribution_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMieExponentialDistribution_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetMieExponentialDistribution_IsValid = SetMieExponentialDistribution_FunctionAddress != IntPtr.Zero && SetMieExponentialDistribution_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetMieExponentialDistribution", SetMieExponentialDistribution_IsValid);
		SetMieAnisotropy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMieAnisotropy");
		SetMieAnisotropy_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMieAnisotropy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMieAnisotropy_NewValue_PropertyAddress, SetMieAnisotropy_FunctionAddress, "NewValue");
		SetMieAnisotropy_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMieAnisotropy_FunctionAddress, "NewValue");
		SetMieAnisotropy_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMieAnisotropy_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetMieAnisotropy_IsValid = SetMieAnisotropy_FunctionAddress != IntPtr.Zero && SetMieAnisotropy_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetMieAnisotropy", SetMieAnisotropy_IsValid);
		SetMieAbsorptionScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMieAbsorptionScale");
		SetMieAbsorptionScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMieAbsorptionScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMieAbsorptionScale_NewValue_PropertyAddress, SetMieAbsorptionScale_FunctionAddress, "NewValue");
		SetMieAbsorptionScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMieAbsorptionScale_FunctionAddress, "NewValue");
		SetMieAbsorptionScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMieAbsorptionScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetMieAbsorptionScale_IsValid = SetMieAbsorptionScale_FunctionAddress != IntPtr.Zero && SetMieAbsorptionScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetMieAbsorptionScale", SetMieAbsorptionScale_IsValid);
		SetMieAbsorption_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMieAbsorption");
		SetMieAbsorption_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMieAbsorption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMieAbsorption_NewValue_PropertyAddress, SetMieAbsorption_FunctionAddress, "NewValue");
		SetMieAbsorption_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMieAbsorption_FunctionAddress, "NewValue");
		SetMieAbsorption_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMieAbsorption_FunctionAddress, "NewValue", Classes.FStructProperty);
		SetMieAbsorption_IsValid = SetMieAbsorption_FunctionAddress != IntPtr.Zero && SetMieAbsorption_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetMieAbsorption", SetMieAbsorption_IsValid);
		SetHeightFogContribution_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHeightFogContribution");
		SetHeightFogContribution_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHeightFogContribution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHeightFogContribution_NewValue_PropertyAddress, SetHeightFogContribution_FunctionAddress, "NewValue");
		SetHeightFogContribution_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetHeightFogContribution_FunctionAddress, "NewValue");
		SetHeightFogContribution_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHeightFogContribution_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetHeightFogContribution_IsValid = SetHeightFogContribution_FunctionAddress != IntPtr.Zero && SetHeightFogContribution_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetHeightFogContribution", SetHeightFogContribution_IsValid);
		SetAtmosphereHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAtmosphereHeight");
		SetAtmosphereHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAtmosphereHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAtmosphereHeight_NewValue_PropertyAddress, SetAtmosphereHeight_FunctionAddress, "NewValue");
		SetAtmosphereHeight_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAtmosphereHeight_FunctionAddress, "NewValue");
		SetAtmosphereHeight_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAtmosphereHeight_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetAtmosphereHeight_IsValid = SetAtmosphereHeight_FunctionAddress != IntPtr.Zero && SetAtmosphereHeight_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetAtmosphereHeight", SetAtmosphereHeight_IsValid);
		SetAerialPespectiveViewDistanceScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAerialPespectiveViewDistanceScale");
		SetAerialPespectiveViewDistanceScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAerialPespectiveViewDistanceScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAerialPespectiveViewDistanceScale_NewValue_PropertyAddress, SetAerialPespectiveViewDistanceScale_FunctionAddress, "NewValue");
		SetAerialPespectiveViewDistanceScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAerialPespectiveViewDistanceScale_FunctionAddress, "NewValue");
		SetAerialPespectiveViewDistanceScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAerialPespectiveViewDistanceScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetAerialPespectiveViewDistanceScale_IsValid = SetAerialPespectiveViewDistanceScale_FunctionAddress != IntPtr.Zero && SetAerialPespectiveViewDistanceScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:SetAerialPespectiveViewDistanceScale", SetAerialPespectiveViewDistanceScale_IsValid);
		OverrideAtmosphereLightDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OverrideAtmosphereLightDirection");
		OverrideAtmosphereLightDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(OverrideAtmosphereLightDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OverrideAtmosphereLightDirection_AtmosphereLightIndex_PropertyAddress, OverrideAtmosphereLightDirection_FunctionAddress, "AtmosphereLightIndex");
		OverrideAtmosphereLightDirection_AtmosphereLightIndex_Offset = NativeReflectionCached.GetPropertyOffset(OverrideAtmosphereLightDirection_FunctionAddress, "AtmosphereLightIndex");
		OverrideAtmosphereLightDirection_AtmosphereLightIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideAtmosphereLightDirection_FunctionAddress, "AtmosphereLightIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideAtmosphereLightDirection_LightDirection_PropertyAddress, OverrideAtmosphereLightDirection_FunctionAddress, "LightDirection");
		OverrideAtmosphereLightDirection_LightDirection_Offset = NativeReflectionCached.GetPropertyOffset(OverrideAtmosphereLightDirection_FunctionAddress, "LightDirection");
		OverrideAtmosphereLightDirection_LightDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideAtmosphereLightDirection_FunctionAddress, "LightDirection", Classes.FStructProperty);
		OverrideAtmosphereLightDirection_IsValid = OverrideAtmosphereLightDirection_FunctionAddress != IntPtr.Zero && OverrideAtmosphereLightDirection_AtmosphereLightIndex_IsValid && OverrideAtmosphereLightDirection_LightDirection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:OverrideAtmosphereLightDirection", OverrideAtmosphereLightDirection_IsValid);
		GetAtmosphereTransmitanceOnGroundAtPlanetTop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAtmosphereTransmitanceOnGroundAtPlanetTop");
		GetAtmosphereTransmitanceOnGroundAtPlanetTop_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAtmosphereTransmitanceOnGroundAtPlanetTop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAtmosphereTransmitanceOnGroundAtPlanetTop_DirectionalLight_PropertyAddress, GetAtmosphereTransmitanceOnGroundAtPlanetTop_FunctionAddress, "DirectionalLight");
		GetAtmosphereTransmitanceOnGroundAtPlanetTop_DirectionalLight_Offset = NativeReflectionCached.GetPropertyOffset(GetAtmosphereTransmitanceOnGroundAtPlanetTop_FunctionAddress, "DirectionalLight");
		GetAtmosphereTransmitanceOnGroundAtPlanetTop_DirectionalLight_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAtmosphereTransmitanceOnGroundAtPlanetTop_FunctionAddress, "DirectionalLight", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAtmosphereTransmitanceOnGroundAtPlanetTop_ReturnValue_PropertyAddress, GetAtmosphereTransmitanceOnGroundAtPlanetTop_FunctionAddress, "ReturnValue");
		GetAtmosphereTransmitanceOnGroundAtPlanetTop_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAtmosphereTransmitanceOnGroundAtPlanetTop_FunctionAddress, "ReturnValue");
		GetAtmosphereTransmitanceOnGroundAtPlanetTop_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAtmosphereTransmitanceOnGroundAtPlanetTop_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAtmosphereTransmitanceOnGroundAtPlanetTop_IsValid = GetAtmosphereTransmitanceOnGroundAtPlanetTop_FunctionAddress != IntPtr.Zero && GetAtmosphereTransmitanceOnGroundAtPlanetTop_DirectionalLight_IsValid && GetAtmosphereTransmitanceOnGroundAtPlanetTop_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkyAtmosphereComponent:GetAtmosphereTransmitanceOnGroundAtPlanetTop", GetAtmosphereTransmitanceOnGroundAtPlanetTop_IsValid);
	}
}
