using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821047460uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ExponentialHeightFogComponent", "Engine", UnrealModuleType.Engine)]
public class UExponentialHeightFogComponent : USceneComponent
{
	private static bool FogDensity_IsValid;

	private static int FogDensity_Offset;

	private static bool FogHeightFalloff_IsValid;

	private static int FogHeightFalloff_Offset;

	private static bool SecondFogData_IsValid;

	private static int SecondFogData_Offset;

	private static bool FogInscatteringLuminance_IsValid;

	private static int FogInscatteringLuminance_Offset;

	private static bool InscatteringColorCubemap_IsValid;

	private static int InscatteringColorCubemap_Offset;

	private static bool InscatteringColorCubemapAngle_IsValid;

	private static int InscatteringColorCubemapAngle_Offset;

	private static bool InscatteringTextureTint_IsValid;

	private static int InscatteringTextureTint_Offset;

	private static bool FullyDirectionalInscatteringColorDistance_IsValid;

	private static int FullyDirectionalInscatteringColorDistance_Offset;

	private static bool NonDirectionalInscatteringColorDistance_IsValid;

	private static int NonDirectionalInscatteringColorDistance_Offset;

	private static bool DirectionalInscatteringExponent_IsValid;

	private static int DirectionalInscatteringExponent_Offset;

	private static bool DirectionalInscatteringStartDistance_IsValid;

	private static int DirectionalInscatteringStartDistance_Offset;

	private static bool DirectionalInscatteringLuminance_IsValid;

	private static int DirectionalInscatteringLuminance_Offset;

	private static bool FogMaxOpacity_IsValid;

	private static int FogMaxOpacity_Offset;

	private static bool StartDistance_IsValid;

	private static int StartDistance_Offset;

	private static bool FogCutoffDistance_IsValid;

	private static int FogCutoffDistance_Offset;

	private static bool EnableVolumetricFog_IsValid;

	private static FFieldAddress EnableVolumetricFog_PropertyAddress;

	private static int EnableVolumetricFog_Offset;

	private static bool VolumetricFogScatteringDistribution_IsValid;

	private static int VolumetricFogScatteringDistribution_Offset;

	private static bool VolumetricFogAlbedo_IsValid;

	private static int VolumetricFogAlbedo_Offset;

	private static bool VolumetricFogEmissive_IsValid;

	private static int VolumetricFogEmissive_Offset;

	private static bool VolumetricFogExtinctionScale_IsValid;

	private static int VolumetricFogExtinctionScale_Offset;

	private static bool VolumetricFogDistance_IsValid;

	private static int VolumetricFogDistance_Offset;

	private static bool VolumetricFogStaticLightingScatteringIntensity_IsValid;

	private static int VolumetricFogStaticLightingScatteringIntensity_Offset;

	private static bool OverrideLightColorsWithFogInscatteringColors_IsValid;

	private static FFieldAddress OverrideLightColorsWithFogInscatteringColors_PropertyAddress;

	private static int OverrideLightColorsWithFogInscatteringColors_Offset;

	private static bool SetVolumetricFogScatteringDistribution_IsValid;

	private static IntPtr SetVolumetricFogScatteringDistribution_FunctionAddress;

	private static int SetVolumetricFogScatteringDistribution_ParamsSize;

	private static bool SetVolumetricFogScatteringDistribution_NewValue_IsValid;

	private static FFieldAddress SetVolumetricFogScatteringDistribution_NewValue_PropertyAddress;

	private static int SetVolumetricFogScatteringDistribution_NewValue_Offset;

	private static bool SetVolumetricFogExtinctionScale_IsValid;

	private static IntPtr SetVolumetricFogExtinctionScale_FunctionAddress;

	private static int SetVolumetricFogExtinctionScale_ParamsSize;

	private static bool SetVolumetricFogExtinctionScale_NewValue_IsValid;

	private static FFieldAddress SetVolumetricFogExtinctionScale_NewValue_PropertyAddress;

	private static int SetVolumetricFogExtinctionScale_NewValue_Offset;

	private static bool SetVolumetricFogEmissive_IsValid;

	private static IntPtr SetVolumetricFogEmissive_FunctionAddress;

	private static int SetVolumetricFogEmissive_ParamsSize;

	private static bool SetVolumetricFogEmissive_NewValue_IsValid;

	private static FFieldAddress SetVolumetricFogEmissive_NewValue_PropertyAddress;

	private static int SetVolumetricFogEmissive_NewValue_Offset;

	private static bool SetVolumetricFogDistance_IsValid;

	private static IntPtr SetVolumetricFogDistance_FunctionAddress;

	private static int SetVolumetricFogDistance_ParamsSize;

	private static bool SetVolumetricFogDistance_NewValue_IsValid;

	private static FFieldAddress SetVolumetricFogDistance_NewValue_PropertyAddress;

	private static int SetVolumetricFogDistance_NewValue_Offset;

	private static bool SetVolumetricFogAlbedo_IsValid;

	private static IntPtr SetVolumetricFogAlbedo_FunctionAddress;

	private static int SetVolumetricFogAlbedo_ParamsSize;

	private static bool SetVolumetricFogAlbedo_NewValue_IsValid;

	private static FFieldAddress SetVolumetricFogAlbedo_NewValue_PropertyAddress;

	private static int SetVolumetricFogAlbedo_NewValue_Offset;

	private static bool SetVolumetricFog_IsValid;

	private static IntPtr SetVolumetricFog_FunctionAddress;

	private static int SetVolumetricFog_ParamsSize;

	private static bool SetVolumetricFog_bNewValue_IsValid;

	private static FFieldAddress SetVolumetricFog_bNewValue_PropertyAddress;

	private static int SetVolumetricFog_bNewValue_Offset;

	private static bool SetStartDistance_IsValid;

	private static IntPtr SetStartDistance_FunctionAddress;

	private static int SetStartDistance_ParamsSize;

	private static bool SetStartDistance_Value_IsValid;

	private static FFieldAddress SetStartDistance_Value_PropertyAddress;

	private static int SetStartDistance_Value_Offset;

	private static bool SetNonDirectionalInscatteringColorDistance_IsValid;

	private static IntPtr SetNonDirectionalInscatteringColorDistance_FunctionAddress;

	private static int SetNonDirectionalInscatteringColorDistance_ParamsSize;

	private static bool SetNonDirectionalInscatteringColorDistance_Value_IsValid;

	private static FFieldAddress SetNonDirectionalInscatteringColorDistance_Value_PropertyAddress;

	private static int SetNonDirectionalInscatteringColorDistance_Value_Offset;

	private static bool SetInscatteringTextureTint_IsValid;

	private static IntPtr SetInscatteringTextureTint_FunctionAddress;

	private static int SetInscatteringTextureTint_ParamsSize;

	private static bool SetInscatteringTextureTint_Value_IsValid;

	private static FFieldAddress SetInscatteringTextureTint_Value_PropertyAddress;

	private static int SetInscatteringTextureTint_Value_Offset;

	private static bool SetInscatteringColorCubemapAngle_IsValid;

	private static IntPtr SetInscatteringColorCubemapAngle_FunctionAddress;

	private static int SetInscatteringColorCubemapAngle_ParamsSize;

	private static bool SetInscatteringColorCubemapAngle_Value_IsValid;

	private static FFieldAddress SetInscatteringColorCubemapAngle_Value_PropertyAddress;

	private static int SetInscatteringColorCubemapAngle_Value_Offset;

	private static bool SetInscatteringColorCubemap_IsValid;

	private static IntPtr SetInscatteringColorCubemap_FunctionAddress;

	private static int SetInscatteringColorCubemap_ParamsSize;

	private static bool SetInscatteringColorCubemap_Value_IsValid;

	private static FFieldAddress SetInscatteringColorCubemap_Value_PropertyAddress;

	private static int SetInscatteringColorCubemap_Value_Offset;

	private static bool SetFullyDirectionalInscatteringColorDistance_IsValid;

	private static IntPtr SetFullyDirectionalInscatteringColorDistance_FunctionAddress;

	private static int SetFullyDirectionalInscatteringColorDistance_ParamsSize;

	private static bool SetFullyDirectionalInscatteringColorDistance_Value_IsValid;

	private static FFieldAddress SetFullyDirectionalInscatteringColorDistance_Value_PropertyAddress;

	private static int SetFullyDirectionalInscatteringColorDistance_Value_Offset;

	private static bool SetFogMaxOpacity_IsValid;

	private static IntPtr SetFogMaxOpacity_FunctionAddress;

	private static int SetFogMaxOpacity_ParamsSize;

	private static bool SetFogMaxOpacity_Value_IsValid;

	private static FFieldAddress SetFogMaxOpacity_Value_PropertyAddress;

	private static int SetFogMaxOpacity_Value_Offset;

	private static bool SetFogInscatteringColor_IsValid;

	private static IntPtr SetFogInscatteringColor_FunctionAddress;

	private static int SetFogInscatteringColor_ParamsSize;

	private static bool SetFogInscatteringColor_Value_IsValid;

	private static FFieldAddress SetFogInscatteringColor_Value_PropertyAddress;

	private static int SetFogInscatteringColor_Value_Offset;

	private static bool SetFogHeightFalloff_IsValid;

	private static IntPtr SetFogHeightFalloff_FunctionAddress;

	private static int SetFogHeightFalloff_ParamsSize;

	private static bool SetFogHeightFalloff_Value_IsValid;

	private static FFieldAddress SetFogHeightFalloff_Value_PropertyAddress;

	private static int SetFogHeightFalloff_Value_Offset;

	private static bool SetFogDensity_IsValid;

	private static IntPtr SetFogDensity_FunctionAddress;

	private static int SetFogDensity_ParamsSize;

	private static bool SetFogDensity_Value_IsValid;

	private static FFieldAddress SetFogDensity_Value_PropertyAddress;

	private static int SetFogDensity_Value_Offset;

	private static bool SetFogCutoffDistance_IsValid;

	private static IntPtr SetFogCutoffDistance_FunctionAddress;

	private static int SetFogCutoffDistance_ParamsSize;

	private static bool SetFogCutoffDistance_Value_IsValid;

	private static FFieldAddress SetFogCutoffDistance_Value_PropertyAddress;

	private static int SetFogCutoffDistance_Value_Offset;

	private static bool SetDirectionalInscatteringStartDistance_IsValid;

	private static IntPtr SetDirectionalInscatteringStartDistance_FunctionAddress;

	private static int SetDirectionalInscatteringStartDistance_ParamsSize;

	private static bool SetDirectionalInscatteringStartDistance_Value_IsValid;

	private static FFieldAddress SetDirectionalInscatteringStartDistance_Value_PropertyAddress;

	private static int SetDirectionalInscatteringStartDistance_Value_Offset;

	private static bool SetDirectionalInscatteringExponent_IsValid;

	private static IntPtr SetDirectionalInscatteringExponent_FunctionAddress;

	private static int SetDirectionalInscatteringExponent_ParamsSize;

	private static bool SetDirectionalInscatteringExponent_Value_IsValid;

	private static FFieldAddress SetDirectionalInscatteringExponent_Value_PropertyAddress;

	private static int SetDirectionalInscatteringExponent_Value_Offset;

	private static bool SetDirectionalInscatteringColor_IsValid;

	private static IntPtr SetDirectionalInscatteringColor_FunctionAddress;

	private static int SetDirectionalInscatteringColor_ParamsSize;

	private static bool SetDirectionalInscatteringColor_Value_IsValid;

	private static FFieldAddress SetDirectionalInscatteringColor_Value_PropertyAddress;

	private static int SetDirectionalInscatteringColor_Value_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:FogDensity")]
	public float FogDensity
	{
		get
		{
			CheckDestroyed();
			if (!FogDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FogDensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FogDensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FogDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FogDensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FogDensity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:FogHeightFalloff")]
	public float FogHeightFalloff
	{
		get
		{
			CheckDestroyed();
			if (!FogHeightFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FogHeightFalloff");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FogHeightFalloff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FogHeightFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FogHeightFalloff");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FogHeightFalloff_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SecondFogData")]
	public FExponentialHeightFogData SecondFogData
	{
		get
		{
			CheckDestroyed();
			if (!SecondFogData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:SecondFogData");
				return default(FExponentialHeightFogData);
			}
			return FExponentialHeightFogData.FromNative(IntPtr.Add(base.Address, SecondFogData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SecondFogData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:SecondFogData");
			}
			else
			{
				FExponentialHeightFogData.ToNative(IntPtr.Add(base.Address, SecondFogData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:FogInscatteringLuminance")]
	public FLinearColor FogInscatteringLuminance
	{
		get
		{
			CheckDestroyed();
			if (!FogInscatteringLuminance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FogInscatteringLuminance");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, FogInscatteringLuminance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FogInscatteringLuminance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FogInscatteringLuminance");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, FogInscatteringLuminance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:InscatteringColorCubemap")]
	public UTextureCube InscatteringColorCubemap
	{
		get
		{
			CheckDestroyed();
			if (!InscatteringColorCubemap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:InscatteringColorCubemap");
				return null;
			}
			return UObjectMarshaler<UTextureCube>.FromNative(IntPtr.Add(base.Address, InscatteringColorCubemap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InscatteringColorCubemap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:InscatteringColorCubemap");
			}
			else
			{
				UObjectMarshaler<UTextureCube>.ToNative(IntPtr.Add(base.Address, InscatteringColorCubemap_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:InscatteringColorCubemapAngle")]
	public float InscatteringColorCubemapAngle
	{
		get
		{
			CheckDestroyed();
			if (!InscatteringColorCubemapAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:InscatteringColorCubemapAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InscatteringColorCubemapAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InscatteringColorCubemapAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:InscatteringColorCubemapAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InscatteringColorCubemapAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:InscatteringTextureTint")]
	public FLinearColor InscatteringTextureTint
	{
		get
		{
			CheckDestroyed();
			if (!InscatteringTextureTint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:InscatteringTextureTint");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, InscatteringTextureTint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InscatteringTextureTint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:InscatteringTextureTint");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, InscatteringTextureTint_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:FullyDirectionalInscatteringColorDistance")]
	public float FullyDirectionalInscatteringColorDistance
	{
		get
		{
			CheckDestroyed();
			if (!FullyDirectionalInscatteringColorDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FullyDirectionalInscatteringColorDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FullyDirectionalInscatteringColorDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FullyDirectionalInscatteringColorDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FullyDirectionalInscatteringColorDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FullyDirectionalInscatteringColorDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:NonDirectionalInscatteringColorDistance")]
	public float NonDirectionalInscatteringColorDistance
	{
		get
		{
			CheckDestroyed();
			if (!NonDirectionalInscatteringColorDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:NonDirectionalInscatteringColorDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NonDirectionalInscatteringColorDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NonDirectionalInscatteringColorDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:NonDirectionalInscatteringColorDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NonDirectionalInscatteringColorDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:DirectionalInscatteringExponent")]
	public float DirectionalInscatteringExponent
	{
		get
		{
			CheckDestroyed();
			if (!DirectionalInscatteringExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:DirectionalInscatteringExponent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DirectionalInscatteringExponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionalInscatteringExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:DirectionalInscatteringExponent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DirectionalInscatteringExponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:DirectionalInscatteringStartDistance")]
	public float DirectionalInscatteringStartDistance
	{
		get
		{
			CheckDestroyed();
			if (!DirectionalInscatteringStartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:DirectionalInscatteringStartDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DirectionalInscatteringStartDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionalInscatteringStartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:DirectionalInscatteringStartDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DirectionalInscatteringStartDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:DirectionalInscatteringLuminance")]
	public FLinearColor DirectionalInscatteringLuminance
	{
		get
		{
			CheckDestroyed();
			if (!DirectionalInscatteringLuminance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:DirectionalInscatteringLuminance");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, DirectionalInscatteringLuminance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionalInscatteringLuminance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:DirectionalInscatteringLuminance");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, DirectionalInscatteringLuminance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:FogMaxOpacity")]
	public float FogMaxOpacity
	{
		get
		{
			CheckDestroyed();
			if (!FogMaxOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FogMaxOpacity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FogMaxOpacity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FogMaxOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FogMaxOpacity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FogMaxOpacity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:StartDistance")]
	public float StartDistance
	{
		get
		{
			CheckDestroyed();
			if (!StartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:StartDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:StartDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:FogCutoffDistance")]
	public float FogCutoffDistance
	{
		get
		{
			CheckDestroyed();
			if (!FogCutoffDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FogCutoffDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FogCutoffDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FogCutoffDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:FogCutoffDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FogCutoffDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:bEnableVolumetricFog")]
	public bool EnableVolumetricFog
	{
		get
		{
			CheckDestroyed();
			if (!EnableVolumetricFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:bEnableVolumetricFog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableVolumetricFog_Offset), 0, EnableVolumetricFog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableVolumetricFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:bEnableVolumetricFog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableVolumetricFog_Offset), 0, EnableVolumetricFog_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogScatteringDistribution")]
	public float VolumetricFogScatteringDistribution
	{
		get
		{
			CheckDestroyed();
			if (!VolumetricFogScatteringDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogScatteringDistribution");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VolumetricFogScatteringDistribution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumetricFogScatteringDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogScatteringDistribution");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VolumetricFogScatteringDistribution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogAlbedo")]
	public FColor VolumetricFogAlbedo
	{
		get
		{
			CheckDestroyed();
			if (!VolumetricFogAlbedo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogAlbedo");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, VolumetricFogAlbedo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumetricFogAlbedo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogAlbedo");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, VolumetricFogAlbedo_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogEmissive")]
	public FLinearColor VolumetricFogEmissive
	{
		get
		{
			CheckDestroyed();
			if (!VolumetricFogEmissive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogEmissive");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, VolumetricFogEmissive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumetricFogEmissive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogEmissive");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, VolumetricFogEmissive_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogExtinctionScale")]
	public float VolumetricFogExtinctionScale
	{
		get
		{
			CheckDestroyed();
			if (!VolumetricFogExtinctionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogExtinctionScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VolumetricFogExtinctionScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumetricFogExtinctionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogExtinctionScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VolumetricFogExtinctionScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogDistance")]
	public float VolumetricFogDistance
	{
		get
		{
			CheckDestroyed();
			if (!VolumetricFogDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VolumetricFogDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumetricFogDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VolumetricFogDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogStaticLightingScatteringIntensity")]
	public float VolumetricFogStaticLightingScatteringIntensity
	{
		get
		{
			CheckDestroyed();
			if (!VolumetricFogStaticLightingScatteringIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogStaticLightingScatteringIntensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VolumetricFogStaticLightingScatteringIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumetricFogStaticLightingScatteringIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:VolumetricFogStaticLightingScatteringIntensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VolumetricFogStaticLightingScatteringIntensity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:bOverrideLightColorsWithFogInscatteringColors")]
	public bool OverrideLightColorsWithFogInscatteringColors
	{
		get
		{
			CheckDestroyed();
			if (!OverrideLightColorsWithFogInscatteringColors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:bOverrideLightColorsWithFogInscatteringColors");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideLightColorsWithFogInscatteringColors_Offset), 0, OverrideLightColorsWithFogInscatteringColors_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideLightColorsWithFogInscatteringColors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ExponentialHeightFogComponent:bOverrideLightColorsWithFogInscatteringColors");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideLightColorsWithFogInscatteringColors_Offset), 0, OverrideLightColorsWithFogInscatteringColors_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogScatteringDistribution")]
	public unsafe void SetVolumetricFogScatteringDistribution(float NewValue)
	{
		CheckDestroyed();
		if (!SetVolumetricFogScatteringDistribution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogScatteringDistribution");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolumetricFogScatteringDistribution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolumetricFogScatteringDistribution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVolumetricFogScatteringDistribution_NewValue_Offset), 0, SetVolumetricFogScatteringDistribution_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolumetricFogScatteringDistribution_FunctionAddress, intPtr, SetVolumetricFogScatteringDistribution_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogExtinctionScale")]
	public unsafe void SetVolumetricFogExtinctionScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetVolumetricFogExtinctionScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogExtinctionScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolumetricFogExtinctionScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolumetricFogExtinctionScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVolumetricFogExtinctionScale_NewValue_Offset), 0, SetVolumetricFogExtinctionScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolumetricFogExtinctionScale_FunctionAddress, intPtr, SetVolumetricFogExtinctionScale_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogEmissive")]
	public unsafe void SetVolumetricFogEmissive(FLinearColor NewValue)
	{
		CheckDestroyed();
		if (!SetVolumetricFogEmissive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogEmissive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolumetricFogEmissive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolumetricFogEmissive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetVolumetricFogEmissive_NewValue_Offset), 0, SetVolumetricFogEmissive_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolumetricFogEmissive_FunctionAddress, intPtr, SetVolumetricFogEmissive_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogDistance")]
	public unsafe void SetVolumetricFogDistance(float NewValue)
	{
		CheckDestroyed();
		if (!SetVolumetricFogDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolumetricFogDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolumetricFogDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVolumetricFogDistance_NewValue_Offset), 0, SetVolumetricFogDistance_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolumetricFogDistance_FunctionAddress, intPtr, SetVolumetricFogDistance_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogAlbedo")]
	public unsafe void SetVolumetricFogAlbedo(FColor NewValue)
	{
		CheckDestroyed();
		if (!SetVolumetricFogAlbedo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogAlbedo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolumetricFogAlbedo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolumetricFogAlbedo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetVolumetricFogAlbedo_NewValue_Offset), 0, SetVolumetricFogAlbedo_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolumetricFogAlbedo_FunctionAddress, intPtr, SetVolumetricFogAlbedo_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFog")]
	public unsafe void SetVolumetricFog(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetVolumetricFog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFog");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolumetricFog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolumetricFog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetVolumetricFog_bNewValue_Offset), 0, SetVolumetricFog_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolumetricFog_FunctionAddress, intPtr, SetVolumetricFog_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetStartDistance")]
	public unsafe void SetStartDistance(float Value)
	{
		CheckDestroyed();
		if (!SetStartDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetStartDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStartDistance_Value_Offset), 0, SetStartDistance_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartDistance_FunctionAddress, intPtr, SetStartDistance_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetNonDirectionalInscatteringColorDistance")]
	public unsafe void SetNonDirectionalInscatteringColorDistance(float Value)
	{
		CheckDestroyed();
		if (!SetNonDirectionalInscatteringColorDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetNonDirectionalInscatteringColorDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNonDirectionalInscatteringColorDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNonDirectionalInscatteringColorDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNonDirectionalInscatteringColorDistance_Value_Offset), 0, SetNonDirectionalInscatteringColorDistance_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNonDirectionalInscatteringColorDistance_FunctionAddress, intPtr, SetNonDirectionalInscatteringColorDistance_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetInscatteringTextureTint")]
	public unsafe void SetInscatteringTextureTint(FLinearColor Value)
	{
		CheckDestroyed();
		if (!SetInscatteringTextureTint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetInscatteringTextureTint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInscatteringTextureTint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInscatteringTextureTint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetInscatteringTextureTint_Value_Offset), 0, SetInscatteringTextureTint_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInscatteringTextureTint_FunctionAddress, intPtr, SetInscatteringTextureTint_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetInscatteringColorCubemapAngle")]
	public unsafe void SetInscatteringColorCubemapAngle(float Value)
	{
		CheckDestroyed();
		if (!SetInscatteringColorCubemapAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetInscatteringColorCubemapAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInscatteringColorCubemapAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInscatteringColorCubemapAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetInscatteringColorCubemapAngle_Value_Offset), 0, SetInscatteringColorCubemapAngle_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInscatteringColorCubemapAngle_FunctionAddress, intPtr, SetInscatteringColorCubemapAngle_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetInscatteringColorCubemap")]
	public unsafe void SetInscatteringColorCubemap(UTextureCube Value)
	{
		CheckDestroyed();
		if (!SetInscatteringColorCubemap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetInscatteringColorCubemap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInscatteringColorCubemap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInscatteringColorCubemap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureCube>.ToNative(IntPtr.Add(intPtr, SetInscatteringColorCubemap_Value_Offset), 0, SetInscatteringColorCubemap_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInscatteringColorCubemap_FunctionAddress, intPtr, SetInscatteringColorCubemap_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetFullyDirectionalInscatteringColorDistance")]
	public unsafe void SetFullyDirectionalInscatteringColorDistance(float Value)
	{
		CheckDestroyed();
		if (!SetFullyDirectionalInscatteringColorDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetFullyDirectionalInscatteringColorDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFullyDirectionalInscatteringColorDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFullyDirectionalInscatteringColorDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFullyDirectionalInscatteringColorDistance_Value_Offset), 0, SetFullyDirectionalInscatteringColorDistance_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFullyDirectionalInscatteringColorDistance_FunctionAddress, intPtr, SetFullyDirectionalInscatteringColorDistance_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetFogMaxOpacity")]
	public unsafe void SetFogMaxOpacity(float Value)
	{
		CheckDestroyed();
		if (!SetFogMaxOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetFogMaxOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFogMaxOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFogMaxOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFogMaxOpacity_Value_Offset), 0, SetFogMaxOpacity_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFogMaxOpacity_FunctionAddress, intPtr, SetFogMaxOpacity_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetFogInscatteringColor")]
	public unsafe void SetFogInscatteringColor(FLinearColor Value)
	{
		CheckDestroyed();
		if (!SetFogInscatteringColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetFogInscatteringColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFogInscatteringColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFogInscatteringColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetFogInscatteringColor_Value_Offset), 0, SetFogInscatteringColor_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFogInscatteringColor_FunctionAddress, intPtr, SetFogInscatteringColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetFogHeightFalloff")]
	public unsafe void SetFogHeightFalloff(float Value)
	{
		CheckDestroyed();
		if (!SetFogHeightFalloff_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetFogHeightFalloff");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFogHeightFalloff_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFogHeightFalloff_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFogHeightFalloff_Value_Offset), 0, SetFogHeightFalloff_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFogHeightFalloff_FunctionAddress, intPtr, SetFogHeightFalloff_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetFogDensity")]
	public unsafe void SetFogDensity(float Value)
	{
		CheckDestroyed();
		if (!SetFogDensity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetFogDensity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFogDensity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFogDensity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFogDensity_Value_Offset), 0, SetFogDensity_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFogDensity_FunctionAddress, intPtr, SetFogDensity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetFogCutoffDistance")]
	public unsafe void SetFogCutoffDistance(float Value)
	{
		CheckDestroyed();
		if (!SetFogCutoffDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetFogCutoffDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFogCutoffDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFogCutoffDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFogCutoffDistance_Value_Offset), 0, SetFogCutoffDistance_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFogCutoffDistance_FunctionAddress, intPtr, SetFogCutoffDistance_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetDirectionalInscatteringStartDistance")]
	public unsafe void SetDirectionalInscatteringStartDistance(float Value)
	{
		CheckDestroyed();
		if (!SetDirectionalInscatteringStartDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetDirectionalInscatteringStartDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDirectionalInscatteringStartDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDirectionalInscatteringStartDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDirectionalInscatteringStartDistance_Value_Offset), 0, SetDirectionalInscatteringStartDistance_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDirectionalInscatteringStartDistance_FunctionAddress, intPtr, SetDirectionalInscatteringStartDistance_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetDirectionalInscatteringExponent")]
	public unsafe void SetDirectionalInscatteringExponent(float Value)
	{
		CheckDestroyed();
		if (!SetDirectionalInscatteringExponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetDirectionalInscatteringExponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDirectionalInscatteringExponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDirectionalInscatteringExponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDirectionalInscatteringExponent_Value_Offset), 0, SetDirectionalInscatteringExponent_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDirectionalInscatteringExponent_FunctionAddress, intPtr, SetDirectionalInscatteringExponent_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.ExponentialHeightFogComponent:SetDirectionalInscatteringColor")]
	public unsafe void SetDirectionalInscatteringColor(FLinearColor Value)
	{
		CheckDestroyed();
		if (!SetDirectionalInscatteringColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ExponentialHeightFogComponent:SetDirectionalInscatteringColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDirectionalInscatteringColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDirectionalInscatteringColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetDirectionalInscatteringColor_Value_Offset), 0, SetDirectionalInscatteringColor_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDirectionalInscatteringColor_FunctionAddress, intPtr, SetDirectionalInscatteringColor_ParamsSize);
	}

	static UExponentialHeightFogComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UExponentialHeightFogComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UExponentialHeightFogComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.ExponentialHeightFogComponent");
		FogDensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogDensity");
		FogDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogDensity", Classes.FFloatProperty);
		FogHeightFalloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogHeightFalloff");
		FogHeightFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogHeightFalloff", Classes.FFloatProperty);
		SecondFogData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SecondFogData");
		SecondFogData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SecondFogData", Classes.FStructProperty);
		FogInscatteringLuminance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogInscatteringLuminance");
		FogInscatteringLuminance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogInscatteringLuminance", Classes.FStructProperty);
		InscatteringColorCubemap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InscatteringColorCubemap");
		InscatteringColorCubemap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InscatteringColorCubemap", Classes.FObjectProperty);
		InscatteringColorCubemapAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InscatteringColorCubemapAngle");
		InscatteringColorCubemapAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InscatteringColorCubemapAngle", Classes.FFloatProperty);
		InscatteringTextureTint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InscatteringTextureTint");
		InscatteringTextureTint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InscatteringTextureTint", Classes.FStructProperty);
		FullyDirectionalInscatteringColorDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FullyDirectionalInscatteringColorDistance");
		FullyDirectionalInscatteringColorDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FullyDirectionalInscatteringColorDistance", Classes.FFloatProperty);
		NonDirectionalInscatteringColorDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NonDirectionalInscatteringColorDistance");
		NonDirectionalInscatteringColorDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NonDirectionalInscatteringColorDistance", Classes.FFloatProperty);
		DirectionalInscatteringExponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DirectionalInscatteringExponent");
		DirectionalInscatteringExponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DirectionalInscatteringExponent", Classes.FFloatProperty);
		DirectionalInscatteringStartDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DirectionalInscatteringStartDistance");
		DirectionalInscatteringStartDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DirectionalInscatteringStartDistance", Classes.FFloatProperty);
		DirectionalInscatteringLuminance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DirectionalInscatteringLuminance");
		DirectionalInscatteringLuminance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DirectionalInscatteringLuminance", Classes.FStructProperty);
		FogMaxOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogMaxOpacity");
		FogMaxOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogMaxOpacity", Classes.FFloatProperty);
		StartDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartDistance");
		StartDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartDistance", Classes.FFloatProperty);
		FogCutoffDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogCutoffDistance");
		FogCutoffDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogCutoffDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableVolumetricFog_PropertyAddress, intPtr, "bEnableVolumetricFog");
		EnableVolumetricFog_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableVolumetricFog");
		EnableVolumetricFog_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableVolumetricFog", Classes.FBoolProperty);
		VolumetricFogScatteringDistribution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumetricFogScatteringDistribution");
		VolumetricFogScatteringDistribution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumetricFogScatteringDistribution", Classes.FFloatProperty);
		VolumetricFogAlbedo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumetricFogAlbedo");
		VolumetricFogAlbedo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumetricFogAlbedo", Classes.FStructProperty);
		VolumetricFogEmissive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumetricFogEmissive");
		VolumetricFogEmissive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumetricFogEmissive", Classes.FStructProperty);
		VolumetricFogExtinctionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumetricFogExtinctionScale");
		VolumetricFogExtinctionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumetricFogExtinctionScale", Classes.FFloatProperty);
		VolumetricFogDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumetricFogDistance");
		VolumetricFogDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumetricFogDistance", Classes.FFloatProperty);
		VolumetricFogStaticLightingScatteringIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumetricFogStaticLightingScatteringIntensity");
		VolumetricFogStaticLightingScatteringIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumetricFogStaticLightingScatteringIntensity", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideLightColorsWithFogInscatteringColors_PropertyAddress, intPtr, "bOverrideLightColorsWithFogInscatteringColors");
		OverrideLightColorsWithFogInscatteringColors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideLightColorsWithFogInscatteringColors");
		OverrideLightColorsWithFogInscatteringColors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideLightColorsWithFogInscatteringColors", Classes.FBoolProperty);
		SetVolumetricFogScatteringDistribution_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolumetricFogScatteringDistribution");
		SetVolumetricFogScatteringDistribution_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolumetricFogScatteringDistribution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolumetricFogScatteringDistribution_NewValue_PropertyAddress, SetVolumetricFogScatteringDistribution_FunctionAddress, "NewValue");
		SetVolumetricFogScatteringDistribution_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumetricFogScatteringDistribution_FunctionAddress, "NewValue");
		SetVolumetricFogScatteringDistribution_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumetricFogScatteringDistribution_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetVolumetricFogScatteringDistribution_IsValid = SetVolumetricFogScatteringDistribution_FunctionAddress != IntPtr.Zero && SetVolumetricFogScatteringDistribution_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogScatteringDistribution", SetVolumetricFogScatteringDistribution_IsValid);
		SetVolumetricFogExtinctionScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolumetricFogExtinctionScale");
		SetVolumetricFogExtinctionScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolumetricFogExtinctionScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolumetricFogExtinctionScale_NewValue_PropertyAddress, SetVolumetricFogExtinctionScale_FunctionAddress, "NewValue");
		SetVolumetricFogExtinctionScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumetricFogExtinctionScale_FunctionAddress, "NewValue");
		SetVolumetricFogExtinctionScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumetricFogExtinctionScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetVolumetricFogExtinctionScale_IsValid = SetVolumetricFogExtinctionScale_FunctionAddress != IntPtr.Zero && SetVolumetricFogExtinctionScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogExtinctionScale", SetVolumetricFogExtinctionScale_IsValid);
		SetVolumetricFogEmissive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolumetricFogEmissive");
		SetVolumetricFogEmissive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolumetricFogEmissive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolumetricFogEmissive_NewValue_PropertyAddress, SetVolumetricFogEmissive_FunctionAddress, "NewValue");
		SetVolumetricFogEmissive_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumetricFogEmissive_FunctionAddress, "NewValue");
		SetVolumetricFogEmissive_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumetricFogEmissive_FunctionAddress, "NewValue", Classes.FStructProperty);
		SetVolumetricFogEmissive_IsValid = SetVolumetricFogEmissive_FunctionAddress != IntPtr.Zero && SetVolumetricFogEmissive_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogEmissive", SetVolumetricFogEmissive_IsValid);
		SetVolumetricFogDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolumetricFogDistance");
		SetVolumetricFogDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolumetricFogDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolumetricFogDistance_NewValue_PropertyAddress, SetVolumetricFogDistance_FunctionAddress, "NewValue");
		SetVolumetricFogDistance_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumetricFogDistance_FunctionAddress, "NewValue");
		SetVolumetricFogDistance_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumetricFogDistance_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetVolumetricFogDistance_IsValid = SetVolumetricFogDistance_FunctionAddress != IntPtr.Zero && SetVolumetricFogDistance_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogDistance", SetVolumetricFogDistance_IsValid);
		SetVolumetricFogAlbedo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolumetricFogAlbedo");
		SetVolumetricFogAlbedo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolumetricFogAlbedo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolumetricFogAlbedo_NewValue_PropertyAddress, SetVolumetricFogAlbedo_FunctionAddress, "NewValue");
		SetVolumetricFogAlbedo_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumetricFogAlbedo_FunctionAddress, "NewValue");
		SetVolumetricFogAlbedo_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumetricFogAlbedo_FunctionAddress, "NewValue", Classes.FStructProperty);
		SetVolumetricFogAlbedo_IsValid = SetVolumetricFogAlbedo_FunctionAddress != IntPtr.Zero && SetVolumetricFogAlbedo_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFogAlbedo", SetVolumetricFogAlbedo_IsValid);
		SetVolumetricFog_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolumetricFog");
		SetVolumetricFog_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolumetricFog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolumetricFog_bNewValue_PropertyAddress, SetVolumetricFog_FunctionAddress, "bNewValue");
		SetVolumetricFog_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumetricFog_FunctionAddress, "bNewValue");
		SetVolumetricFog_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumetricFog_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetVolumetricFog_IsValid = SetVolumetricFog_FunctionAddress != IntPtr.Zero && SetVolumetricFog_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetVolumetricFog", SetVolumetricFog_IsValid);
		SetStartDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStartDistance");
		SetStartDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartDistance_Value_PropertyAddress, SetStartDistance_FunctionAddress, "Value");
		SetStartDistance_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetStartDistance_FunctionAddress, "Value");
		SetStartDistance_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartDistance_FunctionAddress, "Value", Classes.FFloatProperty);
		SetStartDistance_IsValid = SetStartDistance_FunctionAddress != IntPtr.Zero && SetStartDistance_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetStartDistance", SetStartDistance_IsValid);
		SetNonDirectionalInscatteringColorDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNonDirectionalInscatteringColorDistance");
		SetNonDirectionalInscatteringColorDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNonDirectionalInscatteringColorDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNonDirectionalInscatteringColorDistance_Value_PropertyAddress, SetNonDirectionalInscatteringColorDistance_FunctionAddress, "Value");
		SetNonDirectionalInscatteringColorDistance_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNonDirectionalInscatteringColorDistance_FunctionAddress, "Value");
		SetNonDirectionalInscatteringColorDistance_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNonDirectionalInscatteringColorDistance_FunctionAddress, "Value", Classes.FFloatProperty);
		SetNonDirectionalInscatteringColorDistance_IsValid = SetNonDirectionalInscatteringColorDistance_FunctionAddress != IntPtr.Zero && SetNonDirectionalInscatteringColorDistance_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetNonDirectionalInscatteringColorDistance", SetNonDirectionalInscatteringColorDistance_IsValid);
		SetInscatteringTextureTint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInscatteringTextureTint");
		SetInscatteringTextureTint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInscatteringTextureTint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInscatteringTextureTint_Value_PropertyAddress, SetInscatteringTextureTint_FunctionAddress, "Value");
		SetInscatteringTextureTint_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetInscatteringTextureTint_FunctionAddress, "Value");
		SetInscatteringTextureTint_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInscatteringTextureTint_FunctionAddress, "Value", Classes.FStructProperty);
		SetInscatteringTextureTint_IsValid = SetInscatteringTextureTint_FunctionAddress != IntPtr.Zero && SetInscatteringTextureTint_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetInscatteringTextureTint", SetInscatteringTextureTint_IsValid);
		SetInscatteringColorCubemapAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInscatteringColorCubemapAngle");
		SetInscatteringColorCubemapAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInscatteringColorCubemapAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInscatteringColorCubemapAngle_Value_PropertyAddress, SetInscatteringColorCubemapAngle_FunctionAddress, "Value");
		SetInscatteringColorCubemapAngle_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetInscatteringColorCubemapAngle_FunctionAddress, "Value");
		SetInscatteringColorCubemapAngle_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInscatteringColorCubemapAngle_FunctionAddress, "Value", Classes.FFloatProperty);
		SetInscatteringColorCubemapAngle_IsValid = SetInscatteringColorCubemapAngle_FunctionAddress != IntPtr.Zero && SetInscatteringColorCubemapAngle_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetInscatteringColorCubemapAngle", SetInscatteringColorCubemapAngle_IsValid);
		SetInscatteringColorCubemap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInscatteringColorCubemap");
		SetInscatteringColorCubemap_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInscatteringColorCubemap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInscatteringColorCubemap_Value_PropertyAddress, SetInscatteringColorCubemap_FunctionAddress, "Value");
		SetInscatteringColorCubemap_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetInscatteringColorCubemap_FunctionAddress, "Value");
		SetInscatteringColorCubemap_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInscatteringColorCubemap_FunctionAddress, "Value", Classes.FObjectProperty);
		SetInscatteringColorCubemap_IsValid = SetInscatteringColorCubemap_FunctionAddress != IntPtr.Zero && SetInscatteringColorCubemap_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetInscatteringColorCubemap", SetInscatteringColorCubemap_IsValid);
		SetFullyDirectionalInscatteringColorDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFullyDirectionalInscatteringColorDistance");
		SetFullyDirectionalInscatteringColorDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFullyDirectionalInscatteringColorDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFullyDirectionalInscatteringColorDistance_Value_PropertyAddress, SetFullyDirectionalInscatteringColorDistance_FunctionAddress, "Value");
		SetFullyDirectionalInscatteringColorDistance_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFullyDirectionalInscatteringColorDistance_FunctionAddress, "Value");
		SetFullyDirectionalInscatteringColorDistance_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFullyDirectionalInscatteringColorDistance_FunctionAddress, "Value", Classes.FFloatProperty);
		SetFullyDirectionalInscatteringColorDistance_IsValid = SetFullyDirectionalInscatteringColorDistance_FunctionAddress != IntPtr.Zero && SetFullyDirectionalInscatteringColorDistance_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetFullyDirectionalInscatteringColorDistance", SetFullyDirectionalInscatteringColorDistance_IsValid);
		SetFogMaxOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFogMaxOpacity");
		SetFogMaxOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFogMaxOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFogMaxOpacity_Value_PropertyAddress, SetFogMaxOpacity_FunctionAddress, "Value");
		SetFogMaxOpacity_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFogMaxOpacity_FunctionAddress, "Value");
		SetFogMaxOpacity_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFogMaxOpacity_FunctionAddress, "Value", Classes.FFloatProperty);
		SetFogMaxOpacity_IsValid = SetFogMaxOpacity_FunctionAddress != IntPtr.Zero && SetFogMaxOpacity_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetFogMaxOpacity", SetFogMaxOpacity_IsValid);
		SetFogInscatteringColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFogInscatteringColor");
		SetFogInscatteringColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFogInscatteringColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFogInscatteringColor_Value_PropertyAddress, SetFogInscatteringColor_FunctionAddress, "Value");
		SetFogInscatteringColor_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFogInscatteringColor_FunctionAddress, "Value");
		SetFogInscatteringColor_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFogInscatteringColor_FunctionAddress, "Value", Classes.FStructProperty);
		SetFogInscatteringColor_IsValid = SetFogInscatteringColor_FunctionAddress != IntPtr.Zero && SetFogInscatteringColor_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetFogInscatteringColor", SetFogInscatteringColor_IsValid);
		SetFogHeightFalloff_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFogHeightFalloff");
		SetFogHeightFalloff_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFogHeightFalloff_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFogHeightFalloff_Value_PropertyAddress, SetFogHeightFalloff_FunctionAddress, "Value");
		SetFogHeightFalloff_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFogHeightFalloff_FunctionAddress, "Value");
		SetFogHeightFalloff_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFogHeightFalloff_FunctionAddress, "Value", Classes.FFloatProperty);
		SetFogHeightFalloff_IsValid = SetFogHeightFalloff_FunctionAddress != IntPtr.Zero && SetFogHeightFalloff_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetFogHeightFalloff", SetFogHeightFalloff_IsValid);
		SetFogDensity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFogDensity");
		SetFogDensity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFogDensity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFogDensity_Value_PropertyAddress, SetFogDensity_FunctionAddress, "Value");
		SetFogDensity_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFogDensity_FunctionAddress, "Value");
		SetFogDensity_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFogDensity_FunctionAddress, "Value", Classes.FFloatProperty);
		SetFogDensity_IsValid = SetFogDensity_FunctionAddress != IntPtr.Zero && SetFogDensity_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetFogDensity", SetFogDensity_IsValid);
		SetFogCutoffDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFogCutoffDistance");
		SetFogCutoffDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFogCutoffDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFogCutoffDistance_Value_PropertyAddress, SetFogCutoffDistance_FunctionAddress, "Value");
		SetFogCutoffDistance_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFogCutoffDistance_FunctionAddress, "Value");
		SetFogCutoffDistance_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFogCutoffDistance_FunctionAddress, "Value", Classes.FFloatProperty);
		SetFogCutoffDistance_IsValid = SetFogCutoffDistance_FunctionAddress != IntPtr.Zero && SetFogCutoffDistance_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetFogCutoffDistance", SetFogCutoffDistance_IsValid);
		SetDirectionalInscatteringStartDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDirectionalInscatteringStartDistance");
		SetDirectionalInscatteringStartDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDirectionalInscatteringStartDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDirectionalInscatteringStartDistance_Value_PropertyAddress, SetDirectionalInscatteringStartDistance_FunctionAddress, "Value");
		SetDirectionalInscatteringStartDistance_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetDirectionalInscatteringStartDistance_FunctionAddress, "Value");
		SetDirectionalInscatteringStartDistance_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDirectionalInscatteringStartDistance_FunctionAddress, "Value", Classes.FFloatProperty);
		SetDirectionalInscatteringStartDistance_IsValid = SetDirectionalInscatteringStartDistance_FunctionAddress != IntPtr.Zero && SetDirectionalInscatteringStartDistance_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetDirectionalInscatteringStartDistance", SetDirectionalInscatteringStartDistance_IsValid);
		SetDirectionalInscatteringExponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDirectionalInscatteringExponent");
		SetDirectionalInscatteringExponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDirectionalInscatteringExponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDirectionalInscatteringExponent_Value_PropertyAddress, SetDirectionalInscatteringExponent_FunctionAddress, "Value");
		SetDirectionalInscatteringExponent_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetDirectionalInscatteringExponent_FunctionAddress, "Value");
		SetDirectionalInscatteringExponent_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDirectionalInscatteringExponent_FunctionAddress, "Value", Classes.FFloatProperty);
		SetDirectionalInscatteringExponent_IsValid = SetDirectionalInscatteringExponent_FunctionAddress != IntPtr.Zero && SetDirectionalInscatteringExponent_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetDirectionalInscatteringExponent", SetDirectionalInscatteringExponent_IsValid);
		SetDirectionalInscatteringColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDirectionalInscatteringColor");
		SetDirectionalInscatteringColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDirectionalInscatteringColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDirectionalInscatteringColor_Value_PropertyAddress, SetDirectionalInscatteringColor_FunctionAddress, "Value");
		SetDirectionalInscatteringColor_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetDirectionalInscatteringColor_FunctionAddress, "Value");
		SetDirectionalInscatteringColor_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDirectionalInscatteringColor_FunctionAddress, "Value", Classes.FStructProperty);
		SetDirectionalInscatteringColor_IsValid = SetDirectionalInscatteringColor_FunctionAddress != IntPtr.Zero && SetDirectionalInscatteringColor_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ExponentialHeightFogComponent:SetDirectionalInscatteringColor", SetDirectionalInscatteringColor_IsValid);
	}
}
