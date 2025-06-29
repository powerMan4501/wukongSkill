using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig")]
public class BGWDataAsset_LocalFluid2DConfig : UBGWDataAsset
{
	private static bool toggleSim_IsValid;

	private static int toggleSim_Offset;

	private static FFieldAddress toggleSim_PropertyAddress;

	private static bool bPostProcessCollisionData_IsValid;

	private static int bPostProcessCollisionData_Offset;

	private static FFieldAddress bPostProcessCollisionData_PropertyAddress;

	private static bool blueprintDrivenParameters_IsValid;

	private static int blueprintDrivenParameters_Offset;

	private static FFieldAddress blueprintDrivenParameters_PropertyAddress;

	private static bool bMovedCheck_IsValid;

	private static int bMovedCheck_Offset;

	private static FFieldAddress bMovedCheck_PropertyAddress;

	private static bool blocationCheck_IsValid;

	private static int blocationCheck_Offset;

	private static FFieldAddress blocationCheck_PropertyAddress;

	private static bool bLocalSim_IsValid;

	private static int bLocalSim_Offset;

	private static FFieldAddress bLocalSim_PropertyAddress;

	private static bool bHighQualitySim_IsValid;

	private static int bHighQualitySim_Offset;

	private static FFieldAddress bHighQualitySim_PropertyAddress;

	private static bool bSimAreaClamp_IsValid;

	private static int bSimAreaClamp_Offset;

	private static FFieldAddress bSimAreaClamp_PropertyAddress;

	private static bool MaxIteration_IsValid;

	private static int MaxIteration_Offset;

	private static bool SimulationResX_IsValid;

	private static int SimulationResX_Offset;

	private static bool SimulationResY_IsValid;

	private static int SimulationResY_Offset;

	private static bool SimAreaSizeInCM_IsValid;

	private static int SimAreaSizeInCM_Offset;

	private static bool SnappedPosParameterName_IsValid;

	private static int SnappedPosParameterName_Offset;

	private static bool dynamicSDFMpc_IsValid;

	private static int dynamicSDFMpc_Offset;

	private static bool worldOffsetThreshold_IsValid;

	private static int worldOffsetThreshold_Offset;

	private static bool moveThreadhold_IsValid;

	private static int moveThreadhold_Offset;

	private static bool edgeExtendSize_IsValid;

	private static int edgeExtendSize_Offset;

	private static bool bExportVeloDensity_IsValid;

	private static int bExportVeloDensity_Offset;

	private static FFieldAddress bExportVeloDensity_PropertyAddress;

	private static bool bExportPressureDivergence_IsValid;

	private static int bExportPressureDivergence_Offset;

	private static FFieldAddress bExportPressureDivergence_PropertyAddress;

	private static bool veloDensityOutput_IsValid;

	private static int veloDensityOutput_Offset;

	private static bool pressureDivergenceOutput_IsValid;

	private static int pressureDivergenceOutput_Offset;

	private static bool CollisionQueryMaterial_IsValid;

	private static int CollisionQueryMaterial_Offset;

	private static bool PPCollisionQueryMaterial_IsValid;

	private static int PPCollisionQueryMaterial_Offset;

	private static bool CompositeMaterial_IsValid;

	private static int CompositeMaterial_Offset;

	private static bool AdvectMaterial_IsValid;

	private static int AdvectMaterial_Offset;

	private static bool DivergenceMaterial_IsValid;

	private static int DivergenceMaterial_Offset;

	private static bool PressureStep1Material_IsValid;

	private static int PressureStep1Material_Offset;

	private static bool PressureStep2Material_IsValid;

	private static int PressureStep2Material_Offset;

	private static bool BrushPuncture_IsValid;

	private static int BrushPuncture_Offset;

	private static bool VeloDirNoise_IsValid;

	private static int VeloDirNoise_Offset;

	private static bool Speed_IsValid;

	private static int Speed_Offset;

	private static bool VeloFromSimAreaMotion_IsValid;

	private static int VeloFromSimAreaMotion_Offset;

	private static bool SimEdgeBouncyness_IsValid;

	private static int SimEdgeBouncyness_Offset;

	private static bool FadeDensityAtSimEdge_IsValid;

	private static int FadeDensityAtSimEdge_Offset;

	private static bool VeloDirNoiseSize_IsValid;

	private static int VeloDirNoiseSize_Offset;

	private static bool VeloDirNoiseSpeed_IsValid;

	private static int VeloDirNoiseSpeed_Offset;

	private static bool VeloOffsetX_IsValid;

	private static int VeloOffsetX_Offset;

	private static bool VeloOffsetY_IsValid;

	private static int VeloOffsetY_Offset;

	private static bool VeloFromBrushMotion_IsValid;

	private static int VeloFromBrushMotion_Offset;

	private static bool VeloStrength_IsValid;

	private static int VeloStrength_Offset;

	private static bool VeloRotate_IsValid;

	private static int VeloRotate_Offset;

	private static bool VeloAmpNoise_IsValid;

	private static int VeloAmpNoise_Offset;

	private static bool InputFeedback_IsValid;

	private static int InputFeedback_Offset;

	private static bool FlowFeedback_IsValid;

	private static int FlowFeedback_Offset;

	private static bool Divergence_IsValid;

	private static int Divergence_Offset;

	private static bool BrushSize_IsValid;

	private static int BrushSize_Offset;

	private static bool BrushStrength_IsValid;

	private static int BrushStrength_Offset;

	private static bool EraserMode_IsValid;

	private static int EraserMode_Offset;

	private static bool BrushHardness_IsValid;

	private static int BrushHardness_Offset;

	private static bool DensityTemplate_IsValid;

	private static int DensityTemplate_Offset;

	private static bool VelocityTemplate_IsValid;

	private static int VelocityTemplate_Offset;

	private static bool VelocityOffsetSpeed_IsValid;

	private static int VelocityOffsetSpeed_Offset;

	private static bool EdgeMaskWidth_IsValid;

	private static int EdgeMaskWidth_Offset;

	private static bool DensityTxtMult_IsValid;

	private static int DensityTxtMult_Offset;

	private static bool DensityTxtScale_IsValid;

	private static int DensityTxtScale_Offset;

	private static bool DensityTxtOffsetX_IsValid;

	private static int DensityTxtOffsetX_Offset;

	private static bool DensityTxtOffsetY_IsValid;

	private static int DensityTxtOffsetY_Offset;

	private static bool BrushNoise_IsValid;

	private static int BrushNoise_Offset;

	private static bool VeloInputTile_IsValid;

	private static int VeloInputTile_Offset;

	private static bool DensityInputNoiseAmp_IsValid;

	private static int DensityInputNoiseAmp_Offset;

	private static bool DensityInputNoiseOffset_IsValid;

	private static int DensityInputNoiseOffset_Offset;

	private static bool DensityInputNoiseTile_IsValid;

	private static int DensityInputNoiseTile_Offset;

	private static bool BrushRnd_IsValid;

	private static int BrushRnd_Offset;

	[Category("General Parameters")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:toggleSim")]
	public bool toggleSim
	{
		get
		{
			CheckDestroyed();
			if (!toggleSim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:toggleSim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, toggleSim_Offset), 0, toggleSim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!toggleSim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:toggleSim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, toggleSim_Offset), 0, toggleSim_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("General Parameters")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bPostProcessCollisionData")]
	public bool bPostProcessCollisionData
	{
		get
		{
			CheckDestroyed();
			if (!bPostProcessCollisionData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bPostProcessCollisionData");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPostProcessCollisionData_Offset), 0, bPostProcessCollisionData_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPostProcessCollisionData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bPostProcessCollisionData");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPostProcessCollisionData_Offset), 0, bPostProcessCollisionData_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("General Parameters")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:blueprintDrivenParameters")]
	public bool blueprintDrivenParameters
	{
		get
		{
			CheckDestroyed();
			if (!blueprintDrivenParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:blueprintDrivenParameters");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, blueprintDrivenParameters_Offset), 0, blueprintDrivenParameters_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!blueprintDrivenParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:blueprintDrivenParameters");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, blueprintDrivenParameters_Offset), 0, blueprintDrivenParameters_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("General Parameters")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bMovedCheck")]
	public bool bMovedCheck
	{
		get
		{
			CheckDestroyed();
			if (!bMovedCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bMovedCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bMovedCheck_Offset), 0, bMovedCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bMovedCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bMovedCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bMovedCheck_Offset), 0, bMovedCheck_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("General Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:blocationCheck")]
	public bool blocationCheck
	{
		get
		{
			CheckDestroyed();
			if (!blocationCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:blocationCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, blocationCheck_Offset), 0, blocationCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!blocationCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:blocationCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, blocationCheck_Offset), 0, blocationCheck_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("General Parameters")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bLocalSim")]
	public bool bLocalSim
	{
		get
		{
			CheckDestroyed();
			if (!bLocalSim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bLocalSim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLocalSim_Offset), 0, bLocalSim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLocalSim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bLocalSim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLocalSim_Offset), 0, bLocalSim_PropertyAddress.Address, value);
			}
		}
	}

	[Category("General Parameters")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bHighQualitySim")]
	public bool bHighQualitySim
	{
		get
		{
			CheckDestroyed();
			if (!bHighQualitySim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bHighQualitySim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHighQualitySim_Offset), 0, bHighQualitySim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHighQualitySim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bHighQualitySim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHighQualitySim_Offset), 0, bHighQualitySim_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("General Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bSimAreaClamp")]
	public bool bSimAreaClamp
	{
		get
		{
			CheckDestroyed();
			if (!bSimAreaClamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bSimAreaClamp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSimAreaClamp_Offset), 0, bSimAreaClamp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSimAreaClamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bSimAreaClamp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSimAreaClamp_Offset), 0, bSimAreaClamp_PropertyAddress.Address, value);
			}
		}
	}

	[Category("General Parameters")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:MaxIteration")]
	public int MaxIteration
	{
		get
		{
			CheckDestroyed();
			if (!MaxIteration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:MaxIteration");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxIteration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxIteration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:MaxIteration");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxIteration_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("General Parameters")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimulationResX")]
	public int SimulationResX
	{
		get
		{
			CheckDestroyed();
			if (!SimulationResX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimulationResX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SimulationResX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimulationResX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimulationResX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SimulationResX_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("General Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimulationResY")]
	public int SimulationResY
	{
		get
		{
			CheckDestroyed();
			if (!SimulationResY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimulationResY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SimulationResY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimulationResY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimulationResY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SimulationResY_Offset), value);
			}
		}
	}

	[Category("General Parameters")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimAreaSizeInCM")]
	public float SimAreaSizeInCM
	{
		get
		{
			CheckDestroyed();
			if (!SimAreaSizeInCM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimAreaSizeInCM");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SimAreaSizeInCM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimAreaSizeInCM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimAreaSizeInCM");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SimAreaSizeInCM_Offset), value);
			}
		}
	}

	[Category("General Parameters")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SnappedPosParameterName")]
	public FName SnappedPosParameterName
	{
		get
		{
			CheckDestroyed();
			if (!SnappedPosParameterName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SnappedPosParameterName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SnappedPosParameterName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SnappedPosParameterName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SnappedPosParameterName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SnappedPosParameterName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Interactive")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:dynamicSDFMpc")]
	public UMaterialParameterCollection dynamicSDFMpc
	{
		get
		{
			CheckDestroyed();
			if (!dynamicSDFMpc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:dynamicSDFMpc");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, dynamicSDFMpc_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!dynamicSDFMpc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:dynamicSDFMpc");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, dynamicSDFMpc_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Interactive")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:worldOffsetThreshold")]
	public float worldOffsetThreshold
	{
		get
		{
			CheckDestroyed();
			if (!worldOffsetThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:worldOffsetThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, worldOffsetThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!worldOffsetThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:worldOffsetThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, worldOffsetThreshold_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Interactive")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:moveThreadhold")]
	public float moveThreadhold
	{
		get
		{
			CheckDestroyed();
			if (!moveThreadhold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:moveThreadhold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, moveThreadhold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!moveThreadhold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:moveThreadhold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, moveThreadhold_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Interactive")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:edgeExtendSize")]
	public float edgeExtendSize
	{
		get
		{
			CheckDestroyed();
			if (!edgeExtendSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:edgeExtendSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, edgeExtendSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!edgeExtendSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:edgeExtendSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, edgeExtendSize_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Export")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bExportVeloDensity")]
	public bool bExportVeloDensity
	{
		get
		{
			CheckDestroyed();
			if (!bExportVeloDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bExportVeloDensity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bExportVeloDensity_Offset), 0, bExportVeloDensity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bExportVeloDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bExportVeloDensity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bExportVeloDensity_Offset), 0, bExportVeloDensity_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Export")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bExportPressureDivergence")]
	public bool bExportPressureDivergence
	{
		get
		{
			CheckDestroyed();
			if (!bExportPressureDivergence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bExportPressureDivergence");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bExportPressureDivergence_Offset), 0, bExportPressureDivergence_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bExportPressureDivergence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:bExportPressureDivergence");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bExportPressureDivergence_Offset), 0, bExportPressureDivergence_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Export")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:veloDensityOutput")]
	public UTextureRenderTarget2D veloDensityOutput
	{
		get
		{
			CheckDestroyed();
			if (!veloDensityOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:veloDensityOutput");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, veloDensityOutput_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!veloDensityOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:veloDensityOutput");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, veloDensityOutput_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Export")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:pressureDivergenceOutput")]
	public UTextureRenderTarget2D pressureDivergenceOutput
	{
		get
		{
			CheckDestroyed();
			if (!pressureDivergenceOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:pressureDivergenceOutput");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, pressureDivergenceOutput_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!pressureDivergenceOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:pressureDivergenceOutput");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, pressureDivergenceOutput_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Sim Materials")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:CollisionQueryMaterial")]
	public UMaterialInterface CollisionQueryMaterial
	{
		get
		{
			CheckDestroyed();
			if (!CollisionQueryMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:CollisionQueryMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, CollisionQueryMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionQueryMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:CollisionQueryMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, CollisionQueryMaterial_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Materials")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:PPCollisionQueryMaterial")]
	public UMaterialInterface PPCollisionQueryMaterial
	{
		get
		{
			CheckDestroyed();
			if (!PPCollisionQueryMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:PPCollisionQueryMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, PPCollisionQueryMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PPCollisionQueryMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:PPCollisionQueryMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, PPCollisionQueryMaterial_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Sim Materials")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:CompositeMaterial")]
	public UMaterialInterface CompositeMaterial
	{
		get
		{
			CheckDestroyed();
			if (!CompositeMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:CompositeMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, CompositeMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompositeMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:CompositeMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, CompositeMaterial_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Materials")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:AdvectMaterial")]
	public UMaterialInterface AdvectMaterial
	{
		get
		{
			CheckDestroyed();
			if (!AdvectMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:AdvectMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, AdvectMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdvectMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:AdvectMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, AdvectMaterial_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Sim Materials")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DivergenceMaterial")]
	public UMaterialInterface DivergenceMaterial
	{
		get
		{
			CheckDestroyed();
			if (!DivergenceMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DivergenceMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, DivergenceMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DivergenceMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DivergenceMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, DivergenceMaterial_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Sim Materials")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:PressureStep1Material")]
	public UMaterialInterface PressureStep1Material
	{
		get
		{
			CheckDestroyed();
			if (!PressureStep1Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:PressureStep1Material");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, PressureStep1Material_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressureStep1Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:PressureStep1Material");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, PressureStep1Material_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Materials")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:PressureStep2Material")]
	public UMaterialInterface PressureStep2Material
	{
		get
		{
			CheckDestroyed();
			if (!PressureStep2Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:PressureStep2Material");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, PressureStep2Material_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressureStep2Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:PressureStep2Material");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, PressureStep2Material_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushPuncture")]
	public float BrushPuncture
	{
		get
		{
			CheckDestroyed();
			if (!BrushPuncture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushPuncture");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushPuncture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushPuncture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushPuncture");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushPuncture_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloDirNoise")]
	public float VeloDirNoise
	{
		get
		{
			CheckDestroyed();
			if (!VeloDirNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloDirNoise");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloDirNoise_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloDirNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloDirNoise");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloDirNoise_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:Speed")]
	public float Speed
	{
		get
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:Speed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Speed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:Speed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Speed_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Sim Parameters")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloFromSimAreaMotion")]
	public float VeloFromSimAreaMotion
	{
		get
		{
			CheckDestroyed();
			if (!VeloFromSimAreaMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloFromSimAreaMotion");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloFromSimAreaMotion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloFromSimAreaMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloFromSimAreaMotion");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloFromSimAreaMotion_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimEdgeBouncyness")]
	public float SimEdgeBouncyness
	{
		get
		{
			CheckDestroyed();
			if (!SimEdgeBouncyness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimEdgeBouncyness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SimEdgeBouncyness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimEdgeBouncyness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:SimEdgeBouncyness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SimEdgeBouncyness_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:FadeDensityAtSimEdge")]
	public float FadeDensityAtSimEdge
	{
		get
		{
			CheckDestroyed();
			if (!FadeDensityAtSimEdge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:FadeDensityAtSimEdge");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FadeDensityAtSimEdge_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeDensityAtSimEdge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:FadeDensityAtSimEdge");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FadeDensityAtSimEdge_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloDirNoiseSize")]
	public float VeloDirNoiseSize
	{
		get
		{
			CheckDestroyed();
			if (!VeloDirNoiseSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloDirNoiseSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloDirNoiseSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloDirNoiseSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloDirNoiseSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloDirNoiseSize_Offset), value);
			}
		}
	}

	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloDirNoiseSpeed")]
	public float VeloDirNoiseSpeed
	{
		get
		{
			CheckDestroyed();
			if (!VeloDirNoiseSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloDirNoiseSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloDirNoiseSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloDirNoiseSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloDirNoiseSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloDirNoiseSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloOffsetX")]
	public float VeloOffsetX
	{
		get
		{
			CheckDestroyed();
			if (!VeloOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloOffsetX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloOffsetX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloOffsetX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloOffsetX_Offset), value);
			}
		}
	}

	[Category("Sim Parameters")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloOffsetY")]
	public float VeloOffsetY
	{
		get
		{
			CheckDestroyed();
			if (!VeloOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloOffsetY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloOffsetY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloOffsetY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloOffsetY_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloFromBrushMotion")]
	public float VeloFromBrushMotion
	{
		get
		{
			CheckDestroyed();
			if (!VeloFromBrushMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloFromBrushMotion");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloFromBrushMotion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloFromBrushMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloFromBrushMotion");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloFromBrushMotion_Offset), value);
			}
		}
	}

	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloStrength")]
	public float VeloStrength
	{
		get
		{
			CheckDestroyed();
			if (!VeloStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloStrength_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloRotate")]
	public float VeloRotate
	{
		get
		{
			CheckDestroyed();
			if (!VeloRotate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloRotate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloRotate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloRotate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloRotate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloRotate_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloAmpNoise")]
	public float VeloAmpNoise
	{
		get
		{
			CheckDestroyed();
			if (!VeloAmpNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloAmpNoise");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloAmpNoise_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloAmpNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloAmpNoise");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloAmpNoise_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Sim Parameters")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:InputFeedback")]
	public float InputFeedback
	{
		get
		{
			CheckDestroyed();
			if (!InputFeedback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:InputFeedback");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InputFeedback_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputFeedback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:InputFeedback");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InputFeedback_Offset), value);
			}
		}
	}

	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:FlowFeedback")]
	public float FlowFeedback
	{
		get
		{
			CheckDestroyed();
			if (!FlowFeedback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:FlowFeedback");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlowFeedback_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlowFeedback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:FlowFeedback");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlowFeedback_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:Divergence")]
	public float Divergence
	{
		get
		{
			CheckDestroyed();
			if (!Divergence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:Divergence");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Divergence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Divergence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:Divergence");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Divergence_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Sim Parameters")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushSize")]
	public float BrushSize
	{
		get
		{
			CheckDestroyed();
			if (!BrushSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushSize_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushStrength")]
	public float BrushStrength
	{
		get
		{
			CheckDestroyed();
			if (!BrushStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushStrength_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:EraserMode")]
	public float EraserMode
	{
		get
		{
			CheckDestroyed();
			if (!EraserMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:EraserMode");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EraserMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EraserMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:EraserMode");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EraserMode_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushHardness")]
	public float BrushHardness
	{
		get
		{
			CheckDestroyed();
			if (!BrushHardness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushHardness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushHardness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushHardness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushHardness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushHardness_Offset), value);
			}
		}
	}

	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTemplate")]
	public UTexture2D DensityTemplate
	{
		get
		{
			CheckDestroyed();
			if (!DensityTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTemplate");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, DensityTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTemplate");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, DensityTemplate_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Sim Parameters")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VelocityTemplate")]
	public UTexture2D VelocityTemplate
	{
		get
		{
			CheckDestroyed();
			if (!VelocityTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VelocityTemplate");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, VelocityTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VelocityTemplate");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, VelocityTemplate_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VelocityOffsetSpeed")]
	public float VelocityOffsetSpeed
	{
		get
		{
			CheckDestroyed();
			if (!VelocityOffsetSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VelocityOffsetSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityOffsetSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityOffsetSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VelocityOffsetSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityOffsetSpeed_Offset), value);
			}
		}
	}

	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:EdgeMaskWidth")]
	public float EdgeMaskWidth
	{
		get
		{
			CheckDestroyed();
			if (!EdgeMaskWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:EdgeMaskWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EdgeMaskWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EdgeMaskWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:EdgeMaskWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EdgeMaskWidth_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtMult")]
	public float DensityTxtMult
	{
		get
		{
			CheckDestroyed();
			if (!DensityTxtMult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtMult");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityTxtMult_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityTxtMult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtMult");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityTxtMult_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Sim Parameters")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtScale")]
	public float DensityTxtScale
	{
		get
		{
			CheckDestroyed();
			if (!DensityTxtScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityTxtScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityTxtScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityTxtScale_Offset), value);
			}
		}
	}

	[Category("Sim Parameters")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtOffsetX")]
	public float DensityTxtOffsetX
	{
		get
		{
			CheckDestroyed();
			if (!DensityTxtOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtOffsetX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityTxtOffsetX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityTxtOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtOffsetX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityTxtOffsetX_Offset), value);
			}
		}
	}

	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtOffsetY")]
	public float DensityTxtOffsetY
	{
		get
		{
			CheckDestroyed();
			if (!DensityTxtOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtOffsetY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityTxtOffsetY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityTxtOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityTxtOffsetY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityTxtOffsetY_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Sim Parameters")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushNoise")]
	public float BrushNoise
	{
		get
		{
			CheckDestroyed();
			if (!BrushNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushNoise");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushNoise_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushNoise");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushNoise_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloInputTile")]
	public float VeloInputTile
	{
		get
		{
			CheckDestroyed();
			if (!VeloInputTile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloInputTile");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloInputTile_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloInputTile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:VeloInputTile");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloInputTile_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Sim Parameters")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityInputNoiseAmp")]
	public float DensityInputNoiseAmp
	{
		get
		{
			CheckDestroyed();
			if (!DensityInputNoiseAmp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityInputNoiseAmp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityInputNoiseAmp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityInputNoiseAmp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityInputNoiseAmp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityInputNoiseAmp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityInputNoiseOffset")]
	public float DensityInputNoiseOffset
	{
		get
		{
			CheckDestroyed();
			if (!DensityInputNoiseOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityInputNoiseOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityInputNoiseOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityInputNoiseOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityInputNoiseOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityInputNoiseOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityInputNoiseTile")]
	public float DensityInputNoiseTile
	{
		get
		{
			CheckDestroyed();
			if (!DensityInputNoiseTile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityInputNoiseTile");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityInputNoiseTile_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityInputNoiseTile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:DensityInputNoiseTile");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityInputNoiseTile_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Sim Parameters")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushRnd")]
	public float BrushRnd
	{
		get
		{
			CheckDestroyed();
			if (!BrushRnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushRnd");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushRnd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushRnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig:BrushRnd");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushRnd_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_LocalFluid2DConfig");
		NativeReflection.GetPropertyRef(ref toggleSim_PropertyAddress, unrealStruct, "toggleSim");
		toggleSim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "toggleSim");
		toggleSim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "toggleSim", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bPostProcessCollisionData_PropertyAddress, unrealStruct, "bPostProcessCollisionData");
		bPostProcessCollisionData_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bPostProcessCollisionData");
		bPostProcessCollisionData_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bPostProcessCollisionData", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref blueprintDrivenParameters_PropertyAddress, unrealStruct, "blueprintDrivenParameters");
		blueprintDrivenParameters_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "blueprintDrivenParameters");
		blueprintDrivenParameters_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "blueprintDrivenParameters", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bMovedCheck_PropertyAddress, unrealStruct, "bMovedCheck");
		bMovedCheck_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bMovedCheck");
		bMovedCheck_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bMovedCheck", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref blocationCheck_PropertyAddress, unrealStruct, "blocationCheck");
		blocationCheck_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "blocationCheck");
		blocationCheck_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "blocationCheck", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLocalSim_PropertyAddress, unrealStruct, "bLocalSim");
		bLocalSim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLocalSim");
		bLocalSim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLocalSim", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHighQualitySim_PropertyAddress, unrealStruct, "bHighQualitySim");
		bHighQualitySim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bHighQualitySim");
		bHighQualitySim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bHighQualitySim", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSimAreaClamp_PropertyAddress, unrealStruct, "bSimAreaClamp");
		bSimAreaClamp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bSimAreaClamp");
		bSimAreaClamp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bSimAreaClamp", Classes.FBoolProperty);
		MaxIteration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxIteration");
		MaxIteration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxIteration", Classes.FIntProperty);
		SimulationResX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SimulationResX");
		SimulationResX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SimulationResX", Classes.FIntProperty);
		SimulationResY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SimulationResY");
		SimulationResY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SimulationResY", Classes.FIntProperty);
		SimAreaSizeInCM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SimAreaSizeInCM");
		SimAreaSizeInCM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SimAreaSizeInCM", Classes.FFloatProperty);
		SnappedPosParameterName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SnappedPosParameterName");
		SnappedPosParameterName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SnappedPosParameterName", Classes.FNameProperty);
		dynamicSDFMpc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "dynamicSDFMpc");
		dynamicSDFMpc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "dynamicSDFMpc", Classes.FObjectProperty);
		worldOffsetThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "worldOffsetThreshold");
		worldOffsetThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "worldOffsetThreshold", Classes.FFloatProperty);
		moveThreadhold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "moveThreadhold");
		moveThreadhold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "moveThreadhold", Classes.FFloatProperty);
		edgeExtendSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "edgeExtendSize");
		edgeExtendSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "edgeExtendSize", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bExportVeloDensity_PropertyAddress, unrealStruct, "bExportVeloDensity");
		bExportVeloDensity_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bExportVeloDensity");
		bExportVeloDensity_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bExportVeloDensity", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bExportPressureDivergence_PropertyAddress, unrealStruct, "bExportPressureDivergence");
		bExportPressureDivergence_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bExportPressureDivergence");
		bExportPressureDivergence_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bExportPressureDivergence", Classes.FBoolProperty);
		veloDensityOutput_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "veloDensityOutput");
		veloDensityOutput_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "veloDensityOutput", Classes.FObjectProperty);
		pressureDivergenceOutput_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "pressureDivergenceOutput");
		pressureDivergenceOutput_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "pressureDivergenceOutput", Classes.FObjectProperty);
		CollisionQueryMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CollisionQueryMaterial");
		CollisionQueryMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CollisionQueryMaterial", Classes.FObjectProperty);
		PPCollisionQueryMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PPCollisionQueryMaterial");
		PPCollisionQueryMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PPCollisionQueryMaterial", Classes.FObjectProperty);
		CompositeMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CompositeMaterial");
		CompositeMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CompositeMaterial", Classes.FObjectProperty);
		AdvectMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AdvectMaterial");
		AdvectMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AdvectMaterial", Classes.FObjectProperty);
		DivergenceMaterial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DivergenceMaterial");
		DivergenceMaterial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DivergenceMaterial", Classes.FObjectProperty);
		PressureStep1Material_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PressureStep1Material");
		PressureStep1Material_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PressureStep1Material", Classes.FObjectProperty);
		PressureStep2Material_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PressureStep2Material");
		PressureStep2Material_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PressureStep2Material", Classes.FObjectProperty);
		BrushPuncture_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BrushPuncture");
		BrushPuncture_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BrushPuncture", Classes.FFloatProperty);
		VeloDirNoise_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VeloDirNoise");
		VeloDirNoise_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VeloDirNoise", Classes.FFloatProperty);
		Speed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Speed");
		Speed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Speed", Classes.FFloatProperty);
		VeloFromSimAreaMotion_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VeloFromSimAreaMotion");
		VeloFromSimAreaMotion_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VeloFromSimAreaMotion", Classes.FFloatProperty);
		SimEdgeBouncyness_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SimEdgeBouncyness");
		SimEdgeBouncyness_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SimEdgeBouncyness", Classes.FFloatProperty);
		FadeDensityAtSimEdge_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FadeDensityAtSimEdge");
		FadeDensityAtSimEdge_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FadeDensityAtSimEdge", Classes.FFloatProperty);
		VeloDirNoiseSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VeloDirNoiseSize");
		VeloDirNoiseSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VeloDirNoiseSize", Classes.FFloatProperty);
		VeloDirNoiseSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VeloDirNoiseSpeed");
		VeloDirNoiseSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VeloDirNoiseSpeed", Classes.FFloatProperty);
		VeloOffsetX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VeloOffsetX");
		VeloOffsetX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VeloOffsetX", Classes.FFloatProperty);
		VeloOffsetY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VeloOffsetY");
		VeloOffsetY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VeloOffsetY", Classes.FFloatProperty);
		VeloFromBrushMotion_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VeloFromBrushMotion");
		VeloFromBrushMotion_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VeloFromBrushMotion", Classes.FFloatProperty);
		VeloStrength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VeloStrength");
		VeloStrength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VeloStrength", Classes.FFloatProperty);
		VeloRotate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VeloRotate");
		VeloRotate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VeloRotate", Classes.FFloatProperty);
		VeloAmpNoise_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VeloAmpNoise");
		VeloAmpNoise_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VeloAmpNoise", Classes.FFloatProperty);
		InputFeedback_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InputFeedback");
		InputFeedback_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InputFeedback", Classes.FFloatProperty);
		FlowFeedback_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FlowFeedback");
		FlowFeedback_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FlowFeedback", Classes.FFloatProperty);
		Divergence_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Divergence");
		Divergence_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Divergence", Classes.FFloatProperty);
		BrushSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BrushSize");
		BrushSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BrushSize", Classes.FFloatProperty);
		BrushStrength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BrushStrength");
		BrushStrength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BrushStrength", Classes.FFloatProperty);
		EraserMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EraserMode");
		EraserMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EraserMode", Classes.FFloatProperty);
		BrushHardness_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BrushHardness");
		BrushHardness_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BrushHardness", Classes.FFloatProperty);
		DensityTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DensityTemplate");
		DensityTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DensityTemplate", Classes.FObjectProperty);
		VelocityTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VelocityTemplate");
		VelocityTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VelocityTemplate", Classes.FObjectProperty);
		VelocityOffsetSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VelocityOffsetSpeed");
		VelocityOffsetSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VelocityOffsetSpeed", Classes.FFloatProperty);
		EdgeMaskWidth_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EdgeMaskWidth");
		EdgeMaskWidth_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EdgeMaskWidth", Classes.FFloatProperty);
		DensityTxtMult_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DensityTxtMult");
		DensityTxtMult_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DensityTxtMult", Classes.FFloatProperty);
		DensityTxtScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DensityTxtScale");
		DensityTxtScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DensityTxtScale", Classes.FFloatProperty);
		DensityTxtOffsetX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DensityTxtOffsetX");
		DensityTxtOffsetX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DensityTxtOffsetX", Classes.FFloatProperty);
		DensityTxtOffsetY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DensityTxtOffsetY");
		DensityTxtOffsetY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DensityTxtOffsetY", Classes.FFloatProperty);
		BrushNoise_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BrushNoise");
		BrushNoise_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BrushNoise", Classes.FFloatProperty);
		VeloInputTile_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "VeloInputTile");
		VeloInputTile_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "VeloInputTile", Classes.FFloatProperty);
		DensityInputNoiseAmp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DensityInputNoiseAmp");
		DensityInputNoiseAmp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DensityInputNoiseAmp", Classes.FFloatProperty);
		DensityInputNoiseOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DensityInputNoiseOffset");
		DensityInputNoiseOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DensityInputNoiseOffset", Classes.FFloatProperty);
		DensityInputNoiseTile_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DensityInputNoiseTile");
		DensityInputNoiseTile_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DensityInputNoiseTile", Classes.FFloatProperty);
		BrushRnd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BrushRnd");
		BrushRnd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BrushRnd", Classes.FFloatProperty);
	}

	static BGWDataAsset_LocalFluid2DConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_LocalFluid2DConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_LocalFluid2DConfig));
	}
}
