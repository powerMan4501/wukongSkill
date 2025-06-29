using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.LightComponentBase", "Engine", UnrealModuleType.Engine)]
public class ULightComponentBase : USceneComponent
{
	private static bool Intensity_IsValid;

	private static int Intensity_Offset;

	private static bool LightColor_IsValid;

	private static int LightColor_Offset;

	private static bool AffectsWorld_IsValid;

	private static FFieldAddress AffectsWorld_PropertyAddress;

	private static int AffectsWorld_Offset;

	private static bool CastShadowMapShadow_IsValid;

	private static FFieldAddress CastShadowMapShadow_PropertyAddress;

	private static int CastShadowMapShadow_Offset;

	private static bool CastCapsuleShadow_IsValid;

	private static FFieldAddress CastCapsuleShadow_PropertyAddress;

	private static int CastCapsuleShadow_Offset;

	private static bool CastShadows_IsValid;

	private static FFieldAddress CastShadows_PropertyAddress;

	private static int CastShadows_Offset;

	private static bool CastStaticShadows_IsValid;

	private static FFieldAddress CastStaticShadows_PropertyAddress;

	private static int CastStaticShadows_Offset;

	private static bool CastDynamicShadows_IsValid;

	private static FFieldAddress CastDynamicShadows_PropertyAddress;

	private static int CastDynamicShadows_Offset;

	private static bool AffectTranslucentLighting_IsValid;

	private static FFieldAddress AffectTranslucentLighting_PropertyAddress;

	private static int AffectTranslucentLighting_Offset;

	private static bool Transmission_IsValid;

	private static FFieldAddress Transmission_PropertyAddress;

	private static int Transmission_Offset;

	private static bool CastVolumetricShadow_IsValid;

	private static FFieldAddress CastVolumetricShadow_PropertyAddress;

	private static int CastVolumetricShadow_Offset;

	private static bool CastDeepShadow_IsValid;

	private static FFieldAddress CastDeepShadow_PropertyAddress;

	private static int CastDeepShadow_Offset;

	private static bool CastRaytracedShadow_IsValid;

	private static FFieldAddress CastRaytracedShadow_PropertyAddress;

	private static int CastRaytracedShadow_Offset;

	private static bool AffectReflection_IsValid;

	private static FFieldAddress AffectReflection_PropertyAddress;

	private static int AffectReflection_Offset;

	private static bool AffectGlobalIllumination_IsValid;

	private static FFieldAddress AffectGlobalIllumination_PropertyAddress;

	private static int AffectGlobalIllumination_Offset;

	private static bool DeepShadowLayerDistribution_IsValid;

	private static int DeepShadowLayerDistribution_Offset;

	private static bool IndirectLightingIntensity_IsValid;

	private static int IndirectLightingIntensity_Offset;

	private static bool VolumetricScatteringIntensity_IsValid;

	private static int VolumetricScatteringIntensity_Offset;

	private static bool SamplesPerPixel_IsValid;

	private static int SamplesPerPixel_Offset;

	private static bool SetSamplesPerPixel_IsValid;

	private static IntPtr SetSamplesPerPixel_FunctionAddress;

	private static int SetSamplesPerPixel_ParamsSize;

	private static bool SetSamplesPerPixel_NewValue_IsValid;

	private static FFieldAddress SetSamplesPerPixel_NewValue_PropertyAddress;

	private static int SetSamplesPerPixel_NewValue_Offset;

	private static bool SetCastVolumetricShadow_IsValid;

	private static IntPtr SetCastVolumetricShadow_FunctionAddress;

	private static int SetCastVolumetricShadow_ParamsSize;

	private static bool SetCastVolumetricShadow_bNewValue_IsValid;

	private static FFieldAddress SetCastVolumetricShadow_bNewValue_PropertyAddress;

	private static int SetCastVolumetricShadow_bNewValue_Offset;

	private static bool SetCastShadows_IsValid;

	private static IntPtr SetCastShadows_FunctionAddress;

	private static int SetCastShadows_ParamsSize;

	private static bool SetCastShadows_bNewValue_IsValid;

	private static FFieldAddress SetCastShadows_bNewValue_PropertyAddress;

	private static int SetCastShadows_bNewValue_Offset;

	private static bool SetCastRaytracedShadows_IsValid;

	private static IntPtr SetCastRaytracedShadows_FunctionAddress;

	private static int SetCastRaytracedShadows_ParamsSize;

	private static bool SetCastRaytracedShadows_bNewValue_IsValid;

	private static FFieldAddress SetCastRaytracedShadows_bNewValue_PropertyAddress;

	private static int SetCastRaytracedShadows_bNewValue_Offset;

	private static bool SetCastDeepShadow_IsValid;

	private static IntPtr SetCastDeepShadow_FunctionAddress;

	private static int SetCastDeepShadow_ParamsSize;

	private static bool SetCastDeepShadow_bNewValue_IsValid;

	private static FFieldAddress SetCastDeepShadow_bNewValue_PropertyAddress;

	private static int SetCastDeepShadow_bNewValue_Offset;

	private static bool SetAffectReflection_IsValid;

	private static IntPtr SetAffectReflection_FunctionAddress;

	private static int SetAffectReflection_ParamsSize;

	private static bool SetAffectReflection_bNewValue_IsValid;

	private static FFieldAddress SetAffectReflection_bNewValue_PropertyAddress;

	private static int SetAffectReflection_bNewValue_Offset;

	private static bool SetAffectGlobalIllumination_IsValid;

	private static IntPtr SetAffectGlobalIllumination_FunctionAddress;

	private static int SetAffectGlobalIllumination_ParamsSize;

	private static bool SetAffectGlobalIllumination_bNewValue_IsValid;

	private static FFieldAddress SetAffectGlobalIllumination_bNewValue_PropertyAddress;

	private static int SetAffectGlobalIllumination_bNewValue_Offset;

	private static bool GetLightColor_IsValid;

	private static IntPtr GetLightColor_FunctionAddress;

	private static int GetLightColor_ParamsSize;

	private static bool GetLightColor_ReturnValue_IsValid;

	private static FFieldAddress GetLightColor_ReturnValue_PropertyAddress;

	private static int GetLightColor_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:Intensity")]
	public float Intensity
	{
		get
		{
			CheckDestroyed();
			if (!Intensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:Intensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Intensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Intensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:Intensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Intensity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:LightColor")]
	public FColor LightColor
	{
		get
		{
			CheckDestroyed();
			if (!LightColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:LightColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, LightColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:LightColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, LightColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:bAffectsWorld")]
	public bool AffectsWorld
	{
		get
		{
			CheckDestroyed();
			if (!AffectsWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bAffectsWorld");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectsWorld_Offset), 0, AffectsWorld_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectsWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bAffectsWorld");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectsWorld_Offset), 0, AffectsWorld_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:CastShadowMapShadow")]
	public bool CastShadowMapShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastShadowMapShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastShadowMapShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadowMapShadow_Offset), 0, CastShadowMapShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadowMapShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastShadowMapShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadowMapShadow_Offset), 0, CastShadowMapShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:CastCapsuleShadow")]
	public bool CastCapsuleShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastCapsuleShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastCapsuleShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastCapsuleShadow_Offset), 0, CastCapsuleShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastCapsuleShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastCapsuleShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastCapsuleShadow_Offset), 0, CastCapsuleShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:CastShadows")]
	public bool CastShadows
	{
		get
		{
			CheckDestroyed();
			if (!CastShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastShadows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadows_Offset), 0, CastShadows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastShadows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadows_Offset), 0, CastShadows_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:CastStaticShadows")]
	public bool CastStaticShadows
	{
		get
		{
			CheckDestroyed();
			if (!CastStaticShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastStaticShadows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastStaticShadows_Offset), 0, CastStaticShadows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastStaticShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastStaticShadows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastStaticShadows_Offset), 0, CastStaticShadows_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:CastDynamicShadows")]
	public bool CastDynamicShadows
	{
		get
		{
			CheckDestroyed();
			if (!CastDynamicShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastDynamicShadows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastDynamicShadows_Offset), 0, CastDynamicShadows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastDynamicShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastDynamicShadows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastDynamicShadows_Offset), 0, CastDynamicShadows_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:bAffectTranslucentLighting")]
	public bool AffectTranslucentLighting
	{
		get
		{
			CheckDestroyed();
			if (!AffectTranslucentLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bAffectTranslucentLighting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectTranslucentLighting_Offset), 0, AffectTranslucentLighting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectTranslucentLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bAffectTranslucentLighting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectTranslucentLighting_Offset), 0, AffectTranslucentLighting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:bTransmission")]
	public bool Transmission
	{
		get
		{
			CheckDestroyed();
			if (!Transmission_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bTransmission");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Transmission_Offset), 0, Transmission_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Transmission_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bTransmission");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Transmission_Offset), 0, Transmission_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:bCastVolumetricShadow")]
	public bool CastVolumetricShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastVolumetricShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bCastVolumetricShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastVolumetricShadow_Offset), 0, CastVolumetricShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastVolumetricShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bCastVolumetricShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastVolumetricShadow_Offset), 0, CastVolumetricShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:bCastDeepShadow")]
	public bool CastDeepShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastDeepShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bCastDeepShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastDeepShadow_Offset), 0, CastDeepShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastDeepShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bCastDeepShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastDeepShadow_Offset), 0, CastDeepShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:CastRaytracedShadow")]
	public ECastRayTracedShadow CastRaytracedShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastRaytracedShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastRaytracedShadow");
				return ECastRayTracedShadow.Disabled;
			}
			return EnumMarshaler<ECastRayTracedShadow>.FromNative(IntPtr.Add(base.Address, CastRaytracedShadow_Offset), 0, CastRaytracedShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastRaytracedShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:CastRaytracedShadow");
			}
			else
			{
				EnumMarshaler<ECastRayTracedShadow>.ToNative(IntPtr.Add(base.Address, CastRaytracedShadow_Offset), 0, CastRaytracedShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:bAffectReflection")]
	public bool AffectReflection
	{
		get
		{
			CheckDestroyed();
			if (!AffectReflection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bAffectReflection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectReflection_Offset), 0, AffectReflection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectReflection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bAffectReflection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectReflection_Offset), 0, AffectReflection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:bAffectGlobalIllumination")]
	public bool AffectGlobalIllumination
	{
		get
		{
			CheckDestroyed();
			if (!AffectGlobalIllumination_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bAffectGlobalIllumination");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectGlobalIllumination_Offset), 0, AffectGlobalIllumination_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectGlobalIllumination_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:bAffectGlobalIllumination");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectGlobalIllumination_Offset), 0, AffectGlobalIllumination_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:DeepShadowLayerDistribution")]
	public float DeepShadowLayerDistribution
	{
		get
		{
			CheckDestroyed();
			if (!DeepShadowLayerDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:DeepShadowLayerDistribution");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DeepShadowLayerDistribution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DeepShadowLayerDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:DeepShadowLayerDistribution");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DeepShadowLayerDistribution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:IndirectLightingIntensity")]
	public float IndirectLightingIntensity
	{
		get
		{
			CheckDestroyed();
			if (!IndirectLightingIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:IndirectLightingIntensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IndirectLightingIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IndirectLightingIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:IndirectLightingIntensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IndirectLightingIntensity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:VolumetricScatteringIntensity")]
	public float VolumetricScatteringIntensity
	{
		get
		{
			CheckDestroyed();
			if (!VolumetricScatteringIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:VolumetricScatteringIntensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VolumetricScatteringIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumetricScatteringIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:VolumetricScatteringIntensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VolumetricScatteringIntensity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.LightComponentBase:SamplesPerPixel")]
	public int SamplesPerPixel
	{
		get
		{
			CheckDestroyed();
			if (!SamplesPerPixel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:SamplesPerPixel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SamplesPerPixel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SamplesPerPixel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponentBase:SamplesPerPixel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SamplesPerPixel_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponentBase:SetSamplesPerPixel")]
	public unsafe void SetSamplesPerPixel(int NewValue)
	{
		CheckDestroyed();
		if (!SetSamplesPerPixel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponentBase:SetSamplesPerPixel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSamplesPerPixel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSamplesPerPixel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSamplesPerPixel_NewValue_Offset), 0, SetSamplesPerPixel_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSamplesPerPixel_FunctionAddress, intPtr, SetSamplesPerPixel_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponentBase:SetCastVolumetricShadow")]
	public unsafe void SetCastVolumetricShadow(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetCastVolumetricShadow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponentBase:SetCastVolumetricShadow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastVolumetricShadow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastVolumetricShadow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastVolumetricShadow_bNewValue_Offset), 0, SetCastVolumetricShadow_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCastVolumetricShadow_FunctionAddress, intPtr, SetCastVolumetricShadow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponentBase:SetCastShadows")]
	public unsafe void SetCastShadows(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetCastShadows_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponentBase:SetCastShadows");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastShadows_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastShadows_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastShadows_bNewValue_Offset), 0, SetCastShadows_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCastShadows_FunctionAddress, intPtr, SetCastShadows_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponentBase:SetCastRaytracedShadows")]
	public unsafe void SetCastRaytracedShadows(ECastRayTracedShadow bNewValue)
	{
		CheckDestroyed();
		if (!SetCastRaytracedShadows_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponentBase:SetCastRaytracedShadows");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastRaytracedShadows_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastRaytracedShadows_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECastRayTracedShadow>.ToNative(IntPtr.Add(intPtr, SetCastRaytracedShadows_bNewValue_Offset), 0, SetCastRaytracedShadows_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCastRaytracedShadows_FunctionAddress, intPtr, SetCastRaytracedShadows_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponentBase:SetCastDeepShadow")]
	public unsafe void SetCastDeepShadow(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetCastDeepShadow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponentBase:SetCastDeepShadow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastDeepShadow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastDeepShadow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastDeepShadow_bNewValue_Offset), 0, SetCastDeepShadow_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCastDeepShadow_FunctionAddress, intPtr, SetCastDeepShadow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponentBase:SetAffectReflection")]
	public unsafe void SetAffectReflection(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetAffectReflection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponentBase:SetAffectReflection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAffectReflection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAffectReflection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAffectReflection_bNewValue_Offset), 0, SetAffectReflection_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAffectReflection_FunctionAddress, intPtr, SetAffectReflection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponentBase:SetAffectGlobalIllumination")]
	public unsafe void SetAffectGlobalIllumination(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetAffectGlobalIllumination_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponentBase:SetAffectGlobalIllumination");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAffectGlobalIllumination_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAffectGlobalIllumination_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAffectGlobalIllumination_bNewValue_Offset), 0, SetAffectGlobalIllumination_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAffectGlobalIllumination_FunctionAddress, intPtr, SetAffectGlobalIllumination_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.LightComponentBase:GetLightColor")]
	public unsafe FLinearColor GetLightColor()
	{
		CheckDestroyed();
		if (!GetLightColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponentBase:GetLightColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLightColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLightColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLightColor_FunctionAddress, intPtr, GetLightColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetLightColor_ReturnValue_Offset), 0, GetLightColor_ReturnValue_PropertyAddress.Address);
	}

	static ULightComponentBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULightComponentBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULightComponentBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.LightComponentBase");
		Intensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Intensity");
		Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Intensity", Classes.FFloatProperty);
		LightColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightColor");
		LightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectsWorld_PropertyAddress, intPtr, "bAffectsWorld");
		AffectsWorld_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAffectsWorld");
		AffectsWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAffectsWorld", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadowMapShadow_PropertyAddress, intPtr, "CastShadowMapShadow");
		CastShadowMapShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CastShadowMapShadow");
		CastShadowMapShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CastShadowMapShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastCapsuleShadow_PropertyAddress, intPtr, "CastCapsuleShadow");
		CastCapsuleShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CastCapsuleShadow");
		CastCapsuleShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CastCapsuleShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadows_PropertyAddress, intPtr, "CastShadows");
		CastShadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CastShadows");
		CastShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CastShadows", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastStaticShadows_PropertyAddress, intPtr, "CastStaticShadows");
		CastStaticShadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CastStaticShadows");
		CastStaticShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CastStaticShadows", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastDynamicShadows_PropertyAddress, intPtr, "CastDynamicShadows");
		CastDynamicShadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CastDynamicShadows");
		CastDynamicShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CastDynamicShadows", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectTranslucentLighting_PropertyAddress, intPtr, "bAffectTranslucentLighting");
		AffectTranslucentLighting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAffectTranslucentLighting");
		AffectTranslucentLighting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAffectTranslucentLighting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Transmission_PropertyAddress, intPtr, "bTransmission");
		Transmission_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTransmission");
		Transmission_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTransmission", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastVolumetricShadow_PropertyAddress, intPtr, "bCastVolumetricShadow");
		CastVolumetricShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastVolumetricShadow");
		CastVolumetricShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastVolumetricShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastDeepShadow_PropertyAddress, intPtr, "bCastDeepShadow");
		CastDeepShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastDeepShadow");
		CastDeepShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastDeepShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastRaytracedShadow_PropertyAddress, intPtr, "CastRaytracedShadow");
		CastRaytracedShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CastRaytracedShadow");
		CastRaytracedShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CastRaytracedShadow", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectReflection_PropertyAddress, intPtr, "bAffectReflection");
		AffectReflection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAffectReflection");
		AffectReflection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAffectReflection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectGlobalIllumination_PropertyAddress, intPtr, "bAffectGlobalIllumination");
		AffectGlobalIllumination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAffectGlobalIllumination");
		AffectGlobalIllumination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAffectGlobalIllumination", Classes.FBoolProperty);
		DeepShadowLayerDistribution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DeepShadowLayerDistribution");
		DeepShadowLayerDistribution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DeepShadowLayerDistribution", Classes.FFloatProperty);
		IndirectLightingIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndirectLightingIntensity");
		IndirectLightingIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndirectLightingIntensity", Classes.FFloatProperty);
		VolumetricScatteringIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumetricScatteringIntensity");
		VolumetricScatteringIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumetricScatteringIntensity", Classes.FFloatProperty);
		SamplesPerPixel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SamplesPerPixel");
		SamplesPerPixel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SamplesPerPixel", Classes.FIntProperty);
		SetSamplesPerPixel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSamplesPerPixel");
		SetSamplesPerPixel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSamplesPerPixel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSamplesPerPixel_NewValue_PropertyAddress, SetSamplesPerPixel_FunctionAddress, "NewValue");
		SetSamplesPerPixel_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSamplesPerPixel_FunctionAddress, "NewValue");
		SetSamplesPerPixel_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSamplesPerPixel_FunctionAddress, "NewValue", Classes.FIntProperty);
		SetSamplesPerPixel_IsValid = SetSamplesPerPixel_FunctionAddress != IntPtr.Zero && SetSamplesPerPixel_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponentBase:SetSamplesPerPixel", SetSamplesPerPixel_IsValid);
		SetCastVolumetricShadow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCastVolumetricShadow");
		SetCastVolumetricShadow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastVolumetricShadow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastVolumetricShadow_bNewValue_PropertyAddress, SetCastVolumetricShadow_FunctionAddress, "bNewValue");
		SetCastVolumetricShadow_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCastVolumetricShadow_FunctionAddress, "bNewValue");
		SetCastVolumetricShadow_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastVolumetricShadow_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetCastVolumetricShadow_IsValid = SetCastVolumetricShadow_FunctionAddress != IntPtr.Zero && SetCastVolumetricShadow_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponentBase:SetCastVolumetricShadow", SetCastVolumetricShadow_IsValid);
		SetCastShadows_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCastShadows");
		SetCastShadows_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastShadows_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastShadows_bNewValue_PropertyAddress, SetCastShadows_FunctionAddress, "bNewValue");
		SetCastShadows_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCastShadows_FunctionAddress, "bNewValue");
		SetCastShadows_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastShadows_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetCastShadows_IsValid = SetCastShadows_FunctionAddress != IntPtr.Zero && SetCastShadows_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponentBase:SetCastShadows", SetCastShadows_IsValid);
		SetCastRaytracedShadows_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCastRaytracedShadows");
		SetCastRaytracedShadows_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastRaytracedShadows_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastRaytracedShadows_bNewValue_PropertyAddress, SetCastRaytracedShadows_FunctionAddress, "bNewValue");
		SetCastRaytracedShadows_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCastRaytracedShadows_FunctionAddress, "bNewValue");
		SetCastRaytracedShadows_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastRaytracedShadows_FunctionAddress, "bNewValue", Classes.FByteProperty);
		SetCastRaytracedShadows_IsValid = SetCastRaytracedShadows_FunctionAddress != IntPtr.Zero && SetCastRaytracedShadows_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponentBase:SetCastRaytracedShadows", SetCastRaytracedShadows_IsValid);
		SetCastDeepShadow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCastDeepShadow");
		SetCastDeepShadow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastDeepShadow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastDeepShadow_bNewValue_PropertyAddress, SetCastDeepShadow_FunctionAddress, "bNewValue");
		SetCastDeepShadow_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCastDeepShadow_FunctionAddress, "bNewValue");
		SetCastDeepShadow_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastDeepShadow_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetCastDeepShadow_IsValid = SetCastDeepShadow_FunctionAddress != IntPtr.Zero && SetCastDeepShadow_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponentBase:SetCastDeepShadow", SetCastDeepShadow_IsValid);
		SetAffectReflection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAffectReflection");
		SetAffectReflection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAffectReflection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAffectReflection_bNewValue_PropertyAddress, SetAffectReflection_FunctionAddress, "bNewValue");
		SetAffectReflection_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAffectReflection_FunctionAddress, "bNewValue");
		SetAffectReflection_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAffectReflection_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetAffectReflection_IsValid = SetAffectReflection_FunctionAddress != IntPtr.Zero && SetAffectReflection_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponentBase:SetAffectReflection", SetAffectReflection_IsValid);
		SetAffectGlobalIllumination_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAffectGlobalIllumination");
		SetAffectGlobalIllumination_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAffectGlobalIllumination_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAffectGlobalIllumination_bNewValue_PropertyAddress, SetAffectGlobalIllumination_FunctionAddress, "bNewValue");
		SetAffectGlobalIllumination_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAffectGlobalIllumination_FunctionAddress, "bNewValue");
		SetAffectGlobalIllumination_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAffectGlobalIllumination_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetAffectGlobalIllumination_IsValid = SetAffectGlobalIllumination_FunctionAddress != IntPtr.Zero && SetAffectGlobalIllumination_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponentBase:SetAffectGlobalIllumination", SetAffectGlobalIllumination_IsValid);
		GetLightColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLightColor");
		GetLightColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLightColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLightColor_ReturnValue_PropertyAddress, GetLightColor_FunctionAddress, "ReturnValue");
		GetLightColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLightColor_FunctionAddress, "ReturnValue");
		GetLightColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLightColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLightColor_IsValid = GetLightColor_FunctionAddress != IntPtr.Zero && GetLightColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponentBase:GetLightColor", GetLightColor_IsValid);
	}
}
