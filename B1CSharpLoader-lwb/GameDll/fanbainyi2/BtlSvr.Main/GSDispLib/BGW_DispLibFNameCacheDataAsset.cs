using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset")]
public class BGW_DispLibFNameCacheDataAsset : UBGWDataAsset
{
	private static bool GSUnitHeight_IsValid;

	private static int GSUnitHeight_Offset;

	private static bool GSCPUNoiseFloat_IsValid;

	private static int GSCPUNoiseFloat_Offset;

	private static bool UseGSArtFresnel_IsValid;

	private static int UseGSArtFresnel_Offset;

	private static bool InvertGSArtFresnel_IsValid;

	private static int InvertGSArtFresnel_Offset;

	private static bool UseContrastInsteadPower_IsValid;

	private static int UseContrastInsteadPower_Offset;

	private static bool BrightValue_IsValid;

	private static int BrightValue_Offset;

	private static bool DarkValue_IsValid;

	private static int DarkValue_Offset;

	private static bool GSArtFresnelPower_IsValid;

	private static int GSArtFresnelPower_Offset;

	private static bool ClampGSArtFresnelDotProduct_IsValid;

	private static int ClampGSArtFresnelDotProduct_Offset;

	private static bool UAFUseVertexNormalNotTex_IsValid;

	private static int UAFUseVertexNormalNotTex_Offset;

	private static bool UseUAFHeightGradientRamp_IsValid;

	private static int UseUAFHeightGradientRamp_Offset;

	private static bool UAFTopAlpha_IsValid;

	private static int UAFTopAlpha_Offset;

	private static bool UAFBottomAlpha_IsValid;

	private static int UAFBottomAlpha_Offset;

	private static bool FColor_Out_IsValid;

	private static int FColor_Out_Offset;

	private static bool FColor_In_IsValid;

	private static int FColor_In_Offset;

	private static bool GSOverrideOpacity_IsValid;

	private static int GSOverrideOpacity_Offset;

	private static bool EfxStop_IsValid;

	private static int EfxStop_Offset;

	private static bool EfxEmitterPos_IsValid;

	private static int EfxEmitterPos_Offset;

	private static bool EfxTargetPos_IsValid;

	private static int EfxTargetPos_Offset;

	private static bool EfxV4Param_IsValid;

	private static int EfxV4Param_Offset;

	private static bool EfxEmitterDeath_IsValid;

	private static int EfxEmitterDeath_Offset;

	private static bool EfxPlanePPSize_IsValid;

	private static int EfxPlanePPSize_Offset;

	private static bool EfxDuration_IsValid;

	private static int EfxDuration_Offset;

	private static bool EfxSelfSkeletalMesh_IsValid;

	private static int EfxSelfSkeletalMesh_Offset;

	private static bool EfxMinorSkeletalMesh_IsValid;

	private static int EfxMinorSkeletalMesh_Offset;

	private static bool EfxSelfStaticMesh_IsValid;

	private static int EfxSelfStaticMesh_Offset;

	private static bool EfxMinorStaticMesh_IsValid;

	private static int EfxMinorStaticMesh_Offset;

	private static bool WEFM_CurFrameWindEventCount_IsValid;

	private static int WEFM_CurFrameWindEventCount_Offset;

	private static bool WEFM_WindDataV4_IsValid;

	private static int WEFM_WindDataV4_Offset;

	private static bool WEFM_WindDistanceDampingRate_IsValid;

	private static int WEFM_WindDistanceDampingRate_Offset;

	private static bool WEFM_WindType_IsValid;

	private static int WEFM_WindType_Offset;

	private static bool WEFM_WindIntensity_IsValid;

	private static int WEFM_WindIntensity_Offset;

	private static bool WEFM_WindSizeV3_IsValid;

	private static int WEFM_WindSizeV3_Offset;

	private static bool WEFM_WindDirWS_IsValid;

	private static int WEFM_WindDirWS_Offset;

	private static bool WEFM_WindCenterPosWS_IsValid;

	private static int WEFM_WindCenterPosWS_Offset;

	private static bool WEFM_CurFrameHeatEventCount_IsValid;

	private static int WEFM_CurFrameHeatEventCount_Offset;

	private static bool WEFM_HeatDataV4_IsValid;

	private static int WEFM_HeatDataV4_Offset;

	private static bool WEFM_HeatDistanceDampingRate_IsValid;

	private static int WEFM_HeatDistanceDampingRate_Offset;

	private static bool WEFM_HeatIntensity_IsValid;

	private static int WEFM_HeatIntensity_Offset;

	private static bool WEFM_HeatSizeV3_IsValid;

	private static int WEFM_HeatSizeV3_Offset;

	private static bool WEFM_HeatCenterPosWS_IsValid;

	private static int WEFM_HeatCenterPosWS_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("材质参数名缓存_GSUnitHeight4UAF")]
	[Category("FX Base Params")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSUnitHeight")]
	public FName GSUnitHeight
	{
		get
		{
			CheckDestroyed();
			if (!GSUnitHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSUnitHeight");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, GSUnitHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSUnitHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSUnitHeight");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, GSUnitHeight_Offset), value);
			}
		}
	}

	[Category("FX Base Params")]
	[EditAnywhere]
	[DisplayName("材质参数名缓存_GSCPUNoiseFloat")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSCPUNoiseFloat")]
	public FName GSCPUNoiseFloat
	{
		get
		{
			CheckDestroyed();
			if (!GSCPUNoiseFloat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSCPUNoiseFloat");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, GSCPUNoiseFloat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSCPUNoiseFloat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSCPUNoiseFloat");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, GSCPUNoiseFloat_Offset), value);
			}
		}
	}

	[Category("GS Art Fresnel")]
	[DisplayName("材质参数名缓存_UseGSArtFresnel")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UseGSArtFresnel")]
	public FName UseGSArtFresnel
	{
		get
		{
			CheckDestroyed();
			if (!UseGSArtFresnel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UseGSArtFresnel");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, UseGSArtFresnel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UseGSArtFresnel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UseGSArtFresnel");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, UseGSArtFresnel_Offset), value);
			}
		}
	}

	[Category("GS Art Fresnel")]
	[DisplayName("材质参数名缓存_InvertGSArtFresnel")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:InvertGSArtFresnel")]
	public FName InvertGSArtFresnel
	{
		get
		{
			CheckDestroyed();
			if (!InvertGSArtFresnel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:InvertGSArtFresnel");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, InvertGSArtFresnel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InvertGSArtFresnel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:InvertGSArtFresnel");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, InvertGSArtFresnel_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("材质参数名缓存_UseContrastInsteadPower")]
	[Category("GS Art Fresnel")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UseContrastInsteadPower")]
	public FName UseContrastInsteadPower
	{
		get
		{
			CheckDestroyed();
			if (!UseContrastInsteadPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UseContrastInsteadPower");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, UseContrastInsteadPower_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UseContrastInsteadPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UseContrastInsteadPower");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, UseContrastInsteadPower_Offset), value);
			}
		}
	}

	[Category("GS Art Fresnel")]
	[DisplayName("材质参数名缓存_BrightValue")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:BrightValue")]
	public FName BrightValue
	{
		get
		{
			CheckDestroyed();
			if (!BrightValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:BrightValue");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, BrightValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrightValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:BrightValue");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, BrightValue_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("材质参数名缓存_DarkValue")]
	[Category("GS Art Fresnel")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:DarkValue")]
	public FName DarkValue
	{
		get
		{
			CheckDestroyed();
			if (!DarkValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:DarkValue");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DarkValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DarkValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:DarkValue");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DarkValue_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("材质参数名缓存_GSArtFresnelPower")]
	[Category("GS Art Fresnel")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSArtFresnelPower")]
	public FName GSArtFresnelPower
	{
		get
		{
			CheckDestroyed();
			if (!GSArtFresnelPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSArtFresnelPower");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, GSArtFresnelPower_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSArtFresnelPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSArtFresnelPower");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, GSArtFresnelPower_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("材质参数名缓存_ClampGSArtFresnelDotProduct")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GS Art Fresnel")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:ClampGSArtFresnelDotProduct")]
	public FName ClampGSArtFresnelDotProduct
	{
		get
		{
			CheckDestroyed();
			if (!ClampGSArtFresnelDotProduct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:ClampGSArtFresnelDotProduct");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ClampGSArtFresnelDotProduct_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ClampGSArtFresnelDotProduct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:ClampGSArtFresnelDotProduct");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ClampGSArtFresnelDotProduct_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GS Art Fresnel")]
	[DisplayName("材质参数名缓存_UAFUseVertexNormalNotTex")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UAFUseVertexNormalNotTex")]
	public FName UAFUseVertexNormalNotTex
	{
		get
		{
			CheckDestroyed();
			if (!UAFUseVertexNormalNotTex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UAFUseVertexNormalNotTex");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, UAFUseVertexNormalNotTex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UAFUseVertexNormalNotTex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UAFUseVertexNormalNotTex");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, UAFUseVertexNormalNotTex_Offset), value);
			}
		}
	}

	[Category("GS Art Fresnel")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("材质参数名缓存_UseUAFHeightGradientRamp")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UseUAFHeightGradientRamp")]
	public FName UseUAFHeightGradientRamp
	{
		get
		{
			CheckDestroyed();
			if (!UseUAFHeightGradientRamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UseUAFHeightGradientRamp");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, UseUAFHeightGradientRamp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UseUAFHeightGradientRamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UseUAFHeightGradientRamp");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, UseUAFHeightGradientRamp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("材质参数名缓存_UAFTopAlpha")]
	[Category("GS Art Fresnel")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UAFTopAlpha")]
	public FName UAFTopAlpha
	{
		get
		{
			CheckDestroyed();
			if (!UAFTopAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UAFTopAlpha");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, UAFTopAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UAFTopAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UAFTopAlpha");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, UAFTopAlpha_Offset), value);
			}
		}
	}

	[Category("GS Art Fresnel")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("材质参数名缓存_UAFBottomAlpha")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UAFBottomAlpha")]
	public FName UAFBottomAlpha
	{
		get
		{
			CheckDestroyed();
			if (!UAFBottomAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UAFBottomAlpha");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, UAFBottomAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UAFBottomAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:UAFBottomAlpha");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, UAFBottomAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("GS Art Fresnel")]
	[DisplayName("材质参数名缓存_FColor_Out")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:FColor_Out")]
	public FName FColor_Out
	{
		get
		{
			CheckDestroyed();
			if (!FColor_Out_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:FColor_Out");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FColor_Out_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FColor_Out_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:FColor_Out");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FColor_Out_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("材质参数名缓存_FColor_In")]
	[Category("GS Art Fresnel")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:FColor_In")]
	public FName FColor_In
	{
		get
		{
			CheckDestroyed();
			if (!FColor_In_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:FColor_In");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FColor_In_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FColor_In_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:FColor_In");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FColor_In_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("材质参数名缓存_GSOverrideOpacity")]
	[Category("GS Override Opacity")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSOverrideOpacity")]
	public FName GSOverrideOpacity
	{
		get
		{
			CheckDestroyed();
			if (!GSOverrideOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSOverrideOpacity");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, GSOverrideOpacity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSOverrideOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:GSOverrideOpacity");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, GSOverrideOpacity_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Niagara User Params")]
	[DisplayName("Niagara_EfxStop")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxStop")]
	public FName EfxStop
	{
		get
		{
			CheckDestroyed();
			if (!EfxStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxStop");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EfxStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EfxStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxStop");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EfxStop_Offset), value);
			}
		}
	}

	[DisplayName("Niagara_EmitterPos")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Niagara User Params")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxEmitterPos")]
	public FName EfxEmitterPos
	{
		get
		{
			CheckDestroyed();
			if (!EfxEmitterPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxEmitterPos");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EfxEmitterPos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EfxEmitterPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxEmitterPos");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EfxEmitterPos_Offset), value);
			}
		}
	}

	[Category("Niagara User Params")]
	[BlueprintReadWrite]
	[DisplayName("Niagara_TargetPos")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxTargetPos")]
	public FName EfxTargetPos
	{
		get
		{
			CheckDestroyed();
			if (!EfxTargetPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxTargetPos");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EfxTargetPos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EfxTargetPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxTargetPos");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EfxTargetPos_Offset), value);
			}
		}
	}

	[Category("Niagara User Params")]
	[DisplayName("Niagara_GSEfxV4Param")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxV4Param")]
	public FName EfxV4Param
	{
		get
		{
			CheckDestroyed();
			if (!EfxV4Param_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxV4Param");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EfxV4Param_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EfxV4Param_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxV4Param");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EfxV4Param_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Niagara User Params")]
	[DisplayName("Niagara_EmitterDeath")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxEmitterDeath")]
	public FName EfxEmitterDeath
	{
		get
		{
			CheckDestroyed();
			if (!EfxEmitterDeath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxEmitterDeath");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EfxEmitterDeath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EfxEmitterDeath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxEmitterDeath");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EfxEmitterDeath_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Niagara User Params")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("Niagara_PlanePPSize")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxPlanePPSize")]
	public FName EfxPlanePPSize
	{
		get
		{
			CheckDestroyed();
			if (!EfxPlanePPSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxPlanePPSize");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EfxPlanePPSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EfxPlanePPSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxPlanePPSize");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EfxPlanePPSize_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Niagara_Duration")]
	[Category("Niagara User Params")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxDuration")]
	public FName EfxDuration
	{
		get
		{
			CheckDestroyed();
			if (!EfxDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxDuration");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EfxDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EfxDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxDuration");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EfxDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("Niagara_SelfSkeletalMesh")]
	[Category("Niagara User Params")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxSelfSkeletalMesh")]
	public FName EfxSelfSkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!EfxSelfSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxSelfSkeletalMesh");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EfxSelfSkeletalMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EfxSelfSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxSelfSkeletalMesh");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EfxSelfSkeletalMesh_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Niagara_MinorSkeletalMesh")]
	[Category("Niagara User Params")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxMinorSkeletalMesh")]
	public FName EfxMinorSkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!EfxMinorSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxMinorSkeletalMesh");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EfxMinorSkeletalMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EfxMinorSkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxMinorSkeletalMesh");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EfxMinorSkeletalMesh_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("Niagara_SelfStaticMesh")]
	[BlueprintReadWrite]
	[Category("Niagara User Params")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxSelfStaticMesh")]
	public FName EfxSelfStaticMesh
	{
		get
		{
			CheckDestroyed();
			if (!EfxSelfStaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxSelfStaticMesh");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EfxSelfStaticMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EfxSelfStaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxSelfStaticMesh");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EfxSelfStaticMesh_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Niagara_MinorStaticMesh")]
	[Category("Niagara User Params")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxMinorStaticMesh")]
	public FName EfxMinorStaticMesh
	{
		get
		{
			CheckDestroyed();
			if (!EfxMinorStaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxMinorStaticMesh");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EfxMinorStaticMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EfxMinorStaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:EfxMinorStaticMesh");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EfxMinorStaticMesh_Offset), value);
			}
		}
	}

	[Category("WEFM")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("WEFM CurFrameWindEventCount")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_CurFrameWindEventCount")]
	public FName WEFM_CurFrameWindEventCount
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_CurFrameWindEventCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_CurFrameWindEventCount");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_CurFrameWindEventCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_CurFrameWindEventCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_CurFrameWindEventCount");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_CurFrameWindEventCount_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("WEFM WindDataV4")]
	[Category("WEFM")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindDataV4")]
	public FName WEFM_WindDataV4
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_WindDataV4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindDataV4");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_WindDataV4_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_WindDataV4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindDataV4");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_WindDataV4_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("WEFM WindDistanceDampingRate")]
	[Category("WEFM")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindDistanceDampingRate")]
	public FName WEFM_WindDistanceDampingRate
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_WindDistanceDampingRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindDistanceDampingRate");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_WindDistanceDampingRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_WindDistanceDampingRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindDistanceDampingRate");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_WindDistanceDampingRate_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("WEFM WindType")]
	[Category("WEFM")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindType")]
	public FName WEFM_WindType
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_WindType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindType");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_WindType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_WindType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindType");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_WindType_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("WEFM WindIntensity")]
	[Category("WEFM")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindIntensity")]
	public FName WEFM_WindIntensity
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_WindIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindIntensity");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_WindIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_WindIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindIntensity");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_WindIntensity_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("WEFM WindSizeV3")]
	[Category("WEFM")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindSizeV3")]
	public FName WEFM_WindSizeV3
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_WindSizeV3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindSizeV3");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_WindSizeV3_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_WindSizeV3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindSizeV3");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_WindSizeV3_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("WEFM DirWS")]
	[Category("WEFM")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindDirWS")]
	public FName WEFM_WindDirWS
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_WindDirWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindDirWS");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_WindDirWS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_WindDirWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindDirWS");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_WindDirWS_Offset), value);
			}
		}
	}

	[Category("WEFM")]
	[DisplayName("WEFM CenterPosWS")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindCenterPosWS")]
	public FName WEFM_WindCenterPosWS
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_WindCenterPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindCenterPosWS");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_WindCenterPosWS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_WindCenterPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_WindCenterPosWS");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_WindCenterPosWS_Offset), value);
			}
		}
	}

	[Category("WEFM")]
	[DisplayName("WEFM CurFrameHeatEventCount")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_CurFrameHeatEventCount")]
	public FName WEFM_CurFrameHeatEventCount
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_CurFrameHeatEventCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_CurFrameHeatEventCount");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_CurFrameHeatEventCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_CurFrameHeatEventCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_CurFrameHeatEventCount");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_CurFrameHeatEventCount_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("WEFM HeatDataV4")]
	[Category("WEFM")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatDataV4")]
	public FName WEFM_HeatDataV4
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_HeatDataV4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatDataV4");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_HeatDataV4_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_HeatDataV4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatDataV4");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_HeatDataV4_Offset), value);
			}
		}
	}

	[Category("WEFM")]
	[DisplayName("WEFM HeatDistanceDampingRate")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatDistanceDampingRate")]
	public FName WEFM_HeatDistanceDampingRate
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_HeatDistanceDampingRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatDistanceDampingRate");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_HeatDistanceDampingRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_HeatDistanceDampingRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatDistanceDampingRate");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_HeatDistanceDampingRate_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("WEFM")]
	[DisplayName("WEFM HeatIntensity")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatIntensity")]
	public FName WEFM_HeatIntensity
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_HeatIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatIntensity");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_HeatIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_HeatIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatIntensity");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_HeatIntensity_Offset), value);
			}
		}
	}

	[Category("WEFM")]
	[DisplayName("WEFM HeatSizeV3")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatSizeV3")]
	public FName WEFM_HeatSizeV3
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_HeatSizeV3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatSizeV3");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_HeatSizeV3_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_HeatSizeV3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatSizeV3");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_HeatSizeV3_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("WEFM HeatCenterPosWS")]
	[Category("WEFM")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatCenterPosWS")]
	public FName WEFM_HeatCenterPosWS
	{
		get
		{
			CheckDestroyed();
			if (!WEFM_HeatCenterPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatCenterPosWS");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WEFM_HeatCenterPosWS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WEFM_HeatCenterPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset:WEFM_HeatCenterPosWS");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WEFM_HeatCenterPosWS_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_DispLibFNameCacheDataAsset");
		GSUnitHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSUnitHeight");
		GSUnitHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSUnitHeight", Classes.FNameProperty);
		GSCPUNoiseFloat_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSCPUNoiseFloat");
		GSCPUNoiseFloat_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSCPUNoiseFloat", Classes.FNameProperty);
		UseGSArtFresnel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseGSArtFresnel");
		UseGSArtFresnel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseGSArtFresnel", Classes.FNameProperty);
		InvertGSArtFresnel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InvertGSArtFresnel");
		InvertGSArtFresnel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InvertGSArtFresnel", Classes.FNameProperty);
		UseContrastInsteadPower_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseContrastInsteadPower");
		UseContrastInsteadPower_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseContrastInsteadPower", Classes.FNameProperty);
		BrightValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BrightValue");
		BrightValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BrightValue", Classes.FNameProperty);
		DarkValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DarkValue");
		DarkValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DarkValue", Classes.FNameProperty);
		GSArtFresnelPower_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSArtFresnelPower");
		GSArtFresnelPower_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSArtFresnelPower", Classes.FNameProperty);
		ClampGSArtFresnelDotProduct_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ClampGSArtFresnelDotProduct");
		ClampGSArtFresnelDotProduct_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ClampGSArtFresnelDotProduct", Classes.FNameProperty);
		UAFUseVertexNormalNotTex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UAFUseVertexNormalNotTex");
		UAFUseVertexNormalNotTex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UAFUseVertexNormalNotTex", Classes.FNameProperty);
		UseUAFHeightGradientRamp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseUAFHeightGradientRamp");
		UseUAFHeightGradientRamp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseUAFHeightGradientRamp", Classes.FNameProperty);
		UAFTopAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UAFTopAlpha");
		UAFTopAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UAFTopAlpha", Classes.FNameProperty);
		UAFBottomAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UAFBottomAlpha");
		UAFBottomAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UAFBottomAlpha", Classes.FNameProperty);
		FColor_Out_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FColor_Out");
		FColor_Out_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FColor_Out", Classes.FNameProperty);
		FColor_In_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FColor_In");
		FColor_In_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FColor_In", Classes.FNameProperty);
		GSOverrideOpacity_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSOverrideOpacity");
		GSOverrideOpacity_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSOverrideOpacity", Classes.FNameProperty);
		EfxStop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EfxStop");
		EfxStop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EfxStop", Classes.FNameProperty);
		EfxEmitterPos_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EfxEmitterPos");
		EfxEmitterPos_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EfxEmitterPos", Classes.FNameProperty);
		EfxTargetPos_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EfxTargetPos");
		EfxTargetPos_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EfxTargetPos", Classes.FNameProperty);
		EfxV4Param_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EfxV4Param");
		EfxV4Param_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EfxV4Param", Classes.FNameProperty);
		EfxEmitterDeath_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EfxEmitterDeath");
		EfxEmitterDeath_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EfxEmitterDeath", Classes.FNameProperty);
		EfxPlanePPSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EfxPlanePPSize");
		EfxPlanePPSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EfxPlanePPSize", Classes.FNameProperty);
		EfxDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EfxDuration");
		EfxDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EfxDuration", Classes.FNameProperty);
		EfxSelfSkeletalMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EfxSelfSkeletalMesh");
		EfxSelfSkeletalMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EfxSelfSkeletalMesh", Classes.FNameProperty);
		EfxMinorSkeletalMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EfxMinorSkeletalMesh");
		EfxMinorSkeletalMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EfxMinorSkeletalMesh", Classes.FNameProperty);
		EfxSelfStaticMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EfxSelfStaticMesh");
		EfxSelfStaticMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EfxSelfStaticMesh", Classes.FNameProperty);
		EfxMinorStaticMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EfxMinorStaticMesh");
		EfxMinorStaticMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EfxMinorStaticMesh", Classes.FNameProperty);
		WEFM_CurFrameWindEventCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_CurFrameWindEventCount");
		WEFM_CurFrameWindEventCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_CurFrameWindEventCount", Classes.FNameProperty);
		WEFM_WindDataV4_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_WindDataV4");
		WEFM_WindDataV4_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_WindDataV4", Classes.FNameProperty);
		WEFM_WindDistanceDampingRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_WindDistanceDampingRate");
		WEFM_WindDistanceDampingRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_WindDistanceDampingRate", Classes.FNameProperty);
		WEFM_WindType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_WindType");
		WEFM_WindType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_WindType", Classes.FNameProperty);
		WEFM_WindIntensity_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_WindIntensity");
		WEFM_WindIntensity_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_WindIntensity", Classes.FNameProperty);
		WEFM_WindSizeV3_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_WindSizeV3");
		WEFM_WindSizeV3_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_WindSizeV3", Classes.FNameProperty);
		WEFM_WindDirWS_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_WindDirWS");
		WEFM_WindDirWS_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_WindDirWS", Classes.FNameProperty);
		WEFM_WindCenterPosWS_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_WindCenterPosWS");
		WEFM_WindCenterPosWS_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_WindCenterPosWS", Classes.FNameProperty);
		WEFM_CurFrameHeatEventCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_CurFrameHeatEventCount");
		WEFM_CurFrameHeatEventCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_CurFrameHeatEventCount", Classes.FNameProperty);
		WEFM_HeatDataV4_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_HeatDataV4");
		WEFM_HeatDataV4_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_HeatDataV4", Classes.FNameProperty);
		WEFM_HeatDistanceDampingRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_HeatDistanceDampingRate");
		WEFM_HeatDistanceDampingRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_HeatDistanceDampingRate", Classes.FNameProperty);
		WEFM_HeatIntensity_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_HeatIntensity");
		WEFM_HeatIntensity_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_HeatIntensity", Classes.FNameProperty);
		WEFM_HeatSizeV3_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_HeatSizeV3");
		WEFM_HeatSizeV3_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_HeatSizeV3", Classes.FNameProperty);
		WEFM_HeatCenterPosWS_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WEFM_HeatCenterPosWS");
		WEFM_HeatCenterPosWS_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WEFM_HeatCenterPosWS", Classes.FNameProperty);
	}

	static BGW_DispLibFNameCacheDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DispLibFNameCacheDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DispLibFNameCacheDataAsset));
	}
}
