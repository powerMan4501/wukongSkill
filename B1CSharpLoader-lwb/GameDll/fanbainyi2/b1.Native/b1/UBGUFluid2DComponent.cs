using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUFluid2DComponent", "b1", UnrealModuleType.Game)]
public class UBGUFluid2DComponent : UActorComponent
{
	private static bool toggleSim_IsValid;

	private static FFieldAddress toggleSim_PropertyAddress;

	private static int toggleSim_Offset;

	private static bool PostProcessCollisionData_IsValid;

	private static FFieldAddress PostProcessCollisionData_PropertyAddress;

	private static int PostProcessCollisionData_Offset;

	private static bool blueprintDrivenParameters_IsValid;

	private static FFieldAddress blueprintDrivenParameters_PropertyAddress;

	private static int blueprintDrivenParameters_Offset;

	private static bool MovedCheck_IsValid;

	private static FFieldAddress MovedCheck_PropertyAddress;

	private static int MovedCheck_Offset;

	private static bool blocationCheck_IsValid;

	private static FFieldAddress blocationCheck_PropertyAddress;

	private static int blocationCheck_Offset;

	private static bool LocalSim_IsValid;

	private static FFieldAddress LocalSim_PropertyAddress;

	private static int LocalSim_Offset;

	private static bool HighQualitySim_IsValid;

	private static FFieldAddress HighQualitySim_PropertyAddress;

	private static int HighQualitySim_Offset;

	private static bool SimAreaClamp_IsValid;

	private static FFieldAddress SimAreaClamp_PropertyAddress;

	private static int SimAreaClamp_Offset;

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

	private static bool ExportVeloDensity_IsValid;

	private static FFieldAddress ExportVeloDensity_PropertyAddress;

	private static int ExportVeloDensity_Offset;

	private static bool ExportPressureDivergence_IsValid;

	private static FFieldAddress ExportPressureDivergence_PropertyAddress;

	private static int ExportPressureDivergence_Offset;

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

	private static bool worldOffsetX_IsValid;

	private static int worldOffsetX_Offset;

	private static bool worldOffsetY_IsValid;

	private static int worldOffsetY_Offset;

	private static bool GetVeloDensityTexture_IsValid;

	private static IntPtr GetVeloDensityTexture_FunctionAddress;

	private static int GetVeloDensityTexture_ParamsSize;

	private static bool GetVeloDensityTexture_ReturnValue_IsValid;

	private static FFieldAddress GetVeloDensityTexture_ReturnValue_PropertyAddress;

	private static int GetVeloDensityTexture_ReturnValue_Offset;

	private static bool GetPressureDivergenceTexture_IsValid;

	private static IntPtr GetPressureDivergenceTexture_FunctionAddress;

	private static int GetPressureDivergenceTexture_ParamsSize;

	private static bool GetPressureDivergenceTexture_ReturnValue_IsValid;

	private static FFieldAddress GetPressureDivergenceTexture_ReturnValue_PropertyAddress;

	private static int GetPressureDivergenceTexture_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:toggleSim")]
	protected bool toggleSim
	{
		get
		{
			CheckDestroyed();
			if (!toggleSim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:toggleSim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, toggleSim_Offset), 0, toggleSim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!toggleSim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:toggleSim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, toggleSim_Offset), 0, toggleSim_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:bPostProcessCollisionData")]
	protected bool PostProcessCollisionData
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessCollisionData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bPostProcessCollisionData");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PostProcessCollisionData_Offset), 0, PostProcessCollisionData_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessCollisionData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bPostProcessCollisionData");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PostProcessCollisionData_Offset), 0, PostProcessCollisionData_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:blueprintDrivenParameters")]
	protected bool blueprintDrivenParameters
	{
		get
		{
			CheckDestroyed();
			if (!blueprintDrivenParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:blueprintDrivenParameters");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, blueprintDrivenParameters_Offset), 0, blueprintDrivenParameters_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!blueprintDrivenParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:blueprintDrivenParameters");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, blueprintDrivenParameters_Offset), 0, blueprintDrivenParameters_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:bMovedCheck")]
	protected bool MovedCheck
	{
		get
		{
			CheckDestroyed();
			if (!MovedCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bMovedCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MovedCheck_Offset), 0, MovedCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MovedCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bMovedCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MovedCheck_Offset), 0, MovedCheck_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:blocationCheck")]
	protected bool blocationCheck
	{
		get
		{
			CheckDestroyed();
			if (!blocationCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:blocationCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, blocationCheck_Offset), 0, blocationCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!blocationCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:blocationCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, blocationCheck_Offset), 0, blocationCheck_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:bLocalSim")]
	protected bool LocalSim
	{
		get
		{
			CheckDestroyed();
			if (!LocalSim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bLocalSim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LocalSim_Offset), 0, LocalSim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LocalSim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bLocalSim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LocalSim_Offset), 0, LocalSim_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:bHighQualitySim")]
	protected bool HighQualitySim
	{
		get
		{
			CheckDestroyed();
			if (!HighQualitySim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bHighQualitySim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HighQualitySim_Offset), 0, HighQualitySim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HighQualitySim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bHighQualitySim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HighQualitySim_Offset), 0, HighQualitySim_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:bSimAreaClamp")]
	protected bool SimAreaClamp
	{
		get
		{
			CheckDestroyed();
			if (!SimAreaClamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bSimAreaClamp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SimAreaClamp_Offset), 0, SimAreaClamp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimAreaClamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bSimAreaClamp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SimAreaClamp_Offset), 0, SimAreaClamp_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:MaxIteration")]
	protected int MaxIteration
	{
		get
		{
			CheckDestroyed();
			if (!MaxIteration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:MaxIteration");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxIteration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxIteration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:MaxIteration");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxIteration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:SimulationResX")]
	protected int SimulationResX
	{
		get
		{
			CheckDestroyed();
			if (!SimulationResX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:SimulationResX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SimulationResX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimulationResX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:SimulationResX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SimulationResX_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:SimulationResY")]
	protected int SimulationResY
	{
		get
		{
			CheckDestroyed();
			if (!SimulationResY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:SimulationResY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SimulationResY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimulationResY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:SimulationResY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SimulationResY_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:SimAreaSizeInCM")]
	protected float SimAreaSizeInCM
	{
		get
		{
			CheckDestroyed();
			if (!SimAreaSizeInCM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:SimAreaSizeInCM");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SimAreaSizeInCM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimAreaSizeInCM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:SimAreaSizeInCM");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SimAreaSizeInCM_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:SnappedPosParameterName")]
	protected FName SnappedPosParameterName
	{
		get
		{
			CheckDestroyed();
			if (!SnappedPosParameterName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:SnappedPosParameterName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SnappedPosParameterName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SnappedPosParameterName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:SnappedPosParameterName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SnappedPosParameterName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:dynamicSDFMpc")]
	protected UMaterialParameterCollection dynamicSDFMpc
	{
		get
		{
			CheckDestroyed();
			if (!dynamicSDFMpc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:dynamicSDFMpc");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, dynamicSDFMpc_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!dynamicSDFMpc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:dynamicSDFMpc");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, dynamicSDFMpc_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:worldOffsetThreshold")]
	protected float worldOffsetThreshold
	{
		get
		{
			CheckDestroyed();
			if (!worldOffsetThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:worldOffsetThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, worldOffsetThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!worldOffsetThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:worldOffsetThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, worldOffsetThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:moveThreadhold")]
	protected float moveThreadhold
	{
		get
		{
			CheckDestroyed();
			if (!moveThreadhold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:moveThreadhold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, moveThreadhold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!moveThreadhold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:moveThreadhold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, moveThreadhold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:edgeExtendSize")]
	protected float edgeExtendSize
	{
		get
		{
			CheckDestroyed();
			if (!edgeExtendSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:edgeExtendSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, edgeExtendSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!edgeExtendSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:edgeExtendSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, edgeExtendSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:bExportVeloDensity")]
	protected bool ExportVeloDensity
	{
		get
		{
			CheckDestroyed();
			if (!ExportVeloDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bExportVeloDensity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExportVeloDensity_Offset), 0, ExportVeloDensity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExportVeloDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bExportVeloDensity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExportVeloDensity_Offset), 0, ExportVeloDensity_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:bExportPressureDivergence")]
	protected bool ExportPressureDivergence
	{
		get
		{
			CheckDestroyed();
			if (!ExportPressureDivergence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bExportPressureDivergence");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExportPressureDivergence_Offset), 0, ExportPressureDivergence_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExportPressureDivergence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:bExportPressureDivergence");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExportPressureDivergence_Offset), 0, ExportPressureDivergence_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:veloDensityOutput")]
	protected UTextureRenderTarget2D veloDensityOutput
	{
		get
		{
			CheckDestroyed();
			if (!veloDensityOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:veloDensityOutput");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, veloDensityOutput_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!veloDensityOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:veloDensityOutput");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, veloDensityOutput_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:pressureDivergenceOutput")]
	protected UTextureRenderTarget2D pressureDivergenceOutput
	{
		get
		{
			CheckDestroyed();
			if (!pressureDivergenceOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:pressureDivergenceOutput");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, pressureDivergenceOutput_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!pressureDivergenceOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:pressureDivergenceOutput");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, pressureDivergenceOutput_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:CollisionQueryMaterial")]
	protected UMaterialInterface CollisionQueryMaterial
	{
		get
		{
			CheckDestroyed();
			if (!CollisionQueryMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:CollisionQueryMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, CollisionQueryMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionQueryMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:CollisionQueryMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, CollisionQueryMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:PPCollisionQueryMaterial")]
	protected UMaterialInterface PPCollisionQueryMaterial
	{
		get
		{
			CheckDestroyed();
			if (!PPCollisionQueryMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:PPCollisionQueryMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, PPCollisionQueryMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PPCollisionQueryMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:PPCollisionQueryMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, PPCollisionQueryMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:CompositeMaterial")]
	protected UMaterialInterface CompositeMaterial
	{
		get
		{
			CheckDestroyed();
			if (!CompositeMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:CompositeMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, CompositeMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompositeMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:CompositeMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, CompositeMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:AdvectMaterial")]
	protected UMaterialInterface AdvectMaterial
	{
		get
		{
			CheckDestroyed();
			if (!AdvectMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:AdvectMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, AdvectMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdvectMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:AdvectMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, AdvectMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:DivergenceMaterial")]
	protected UMaterialInterface DivergenceMaterial
	{
		get
		{
			CheckDestroyed();
			if (!DivergenceMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DivergenceMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, DivergenceMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DivergenceMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DivergenceMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, DivergenceMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:PressureStep1Material")]
	protected UMaterialInterface PressureStep1Material
	{
		get
		{
			CheckDestroyed();
			if (!PressureStep1Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:PressureStep1Material");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, PressureStep1Material_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressureStep1Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:PressureStep1Material");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, PressureStep1Material_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:PressureStep2Material")]
	protected UMaterialInterface PressureStep2Material
	{
		get
		{
			CheckDestroyed();
			if (!PressureStep2Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:PressureStep2Material");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, PressureStep2Material_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressureStep2Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:PressureStep2Material");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, PressureStep2Material_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:BrushPuncture")]
	protected float BrushPuncture
	{
		get
		{
			CheckDestroyed();
			if (!BrushPuncture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushPuncture");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushPuncture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushPuncture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushPuncture");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushPuncture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VeloDirNoise")]
	protected float VeloDirNoise
	{
		get
		{
			CheckDestroyed();
			if (!VeloDirNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloDirNoise");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloDirNoise_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloDirNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloDirNoise");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloDirNoise_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:Speed")]
	protected float Speed
	{
		get
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:Speed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Speed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Speed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:Speed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Speed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VeloFromSimAreaMotion")]
	protected float VeloFromSimAreaMotion
	{
		get
		{
			CheckDestroyed();
			if (!VeloFromSimAreaMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloFromSimAreaMotion");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloFromSimAreaMotion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloFromSimAreaMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloFromSimAreaMotion");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloFromSimAreaMotion_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:SimEdgeBouncyness")]
	protected float SimEdgeBouncyness
	{
		get
		{
			CheckDestroyed();
			if (!SimEdgeBouncyness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:SimEdgeBouncyness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SimEdgeBouncyness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimEdgeBouncyness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:SimEdgeBouncyness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SimEdgeBouncyness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:FadeDensityAtSimEdge")]
	protected float FadeDensityAtSimEdge
	{
		get
		{
			CheckDestroyed();
			if (!FadeDensityAtSimEdge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:FadeDensityAtSimEdge");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FadeDensityAtSimEdge_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeDensityAtSimEdge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:FadeDensityAtSimEdge");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FadeDensityAtSimEdge_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VeloDirNoiseSize")]
	protected float VeloDirNoiseSize
	{
		get
		{
			CheckDestroyed();
			if (!VeloDirNoiseSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloDirNoiseSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloDirNoiseSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloDirNoiseSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloDirNoiseSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloDirNoiseSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VeloDirNoiseSpeed")]
	protected float VeloDirNoiseSpeed
	{
		get
		{
			CheckDestroyed();
			if (!VeloDirNoiseSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloDirNoiseSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloDirNoiseSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloDirNoiseSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloDirNoiseSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloDirNoiseSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VeloOffsetX")]
	protected float VeloOffsetX
	{
		get
		{
			CheckDestroyed();
			if (!VeloOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloOffsetX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloOffsetX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloOffsetX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloOffsetX_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VeloOffsetY")]
	protected float VeloOffsetY
	{
		get
		{
			CheckDestroyed();
			if (!VeloOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloOffsetY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloOffsetY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloOffsetY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloOffsetY_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VeloFromBrushMotion")]
	protected float VeloFromBrushMotion
	{
		get
		{
			CheckDestroyed();
			if (!VeloFromBrushMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloFromBrushMotion");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloFromBrushMotion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloFromBrushMotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloFromBrushMotion");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloFromBrushMotion_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VeloStrength")]
	protected float VeloStrength
	{
		get
		{
			CheckDestroyed();
			if (!VeloStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloStrength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VeloRotate")]
	protected float VeloRotate
	{
		get
		{
			CheckDestroyed();
			if (!VeloRotate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloRotate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloRotate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloRotate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloRotate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloRotate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VeloAmpNoise")]
	protected float VeloAmpNoise
	{
		get
		{
			CheckDestroyed();
			if (!VeloAmpNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloAmpNoise");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloAmpNoise_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloAmpNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloAmpNoise");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloAmpNoise_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:InputFeedback")]
	protected float InputFeedback
	{
		get
		{
			CheckDestroyed();
			if (!InputFeedback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:InputFeedback");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InputFeedback_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputFeedback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:InputFeedback");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InputFeedback_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:FlowFeedback")]
	protected float FlowFeedback
	{
		get
		{
			CheckDestroyed();
			if (!FlowFeedback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:FlowFeedback");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlowFeedback_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlowFeedback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:FlowFeedback");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlowFeedback_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:Divergence")]
	protected float Divergence
	{
		get
		{
			CheckDestroyed();
			if (!Divergence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:Divergence");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Divergence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Divergence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:Divergence");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Divergence_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:BrushSize")]
	protected float BrushSize
	{
		get
		{
			CheckDestroyed();
			if (!BrushSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:BrushStrength")]
	protected float BrushStrength
	{
		get
		{
			CheckDestroyed();
			if (!BrushStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushStrength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:EraserMode")]
	protected float EraserMode
	{
		get
		{
			CheckDestroyed();
			if (!EraserMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:EraserMode");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EraserMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EraserMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:EraserMode");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EraserMode_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:BrushHardness")]
	protected float BrushHardness
	{
		get
		{
			CheckDestroyed();
			if (!BrushHardness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushHardness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushHardness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushHardness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushHardness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushHardness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:DensityTemplate")]
	protected UTexture2D DensityTemplate
	{
		get
		{
			CheckDestroyed();
			if (!DensityTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityTemplate");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, DensityTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityTemplate");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, DensityTemplate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VelocityTemplate")]
	protected UTexture2D VelocityTemplate
	{
		get
		{
			CheckDestroyed();
			if (!VelocityTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VelocityTemplate");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, VelocityTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VelocityTemplate");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, VelocityTemplate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VelocityOffsetSpeed")]
	protected float VelocityOffsetSpeed
	{
		get
		{
			CheckDestroyed();
			if (!VelocityOffsetSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VelocityOffsetSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityOffsetSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityOffsetSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VelocityOffsetSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityOffsetSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:EdgeMaskWidth")]
	protected float EdgeMaskWidth
	{
		get
		{
			CheckDestroyed();
			if (!EdgeMaskWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:EdgeMaskWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EdgeMaskWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EdgeMaskWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:EdgeMaskWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EdgeMaskWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:DensityTxtMult")]
	protected float DensityTxtMult
	{
		get
		{
			CheckDestroyed();
			if (!DensityTxtMult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityTxtMult");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityTxtMult_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityTxtMult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityTxtMult");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityTxtMult_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:DensityTxtScale")]
	protected float DensityTxtScale
	{
		get
		{
			CheckDestroyed();
			if (!DensityTxtScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityTxtScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityTxtScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityTxtScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityTxtScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityTxtScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:DensityTxtOffsetX")]
	protected float DensityTxtOffsetX
	{
		get
		{
			CheckDestroyed();
			if (!DensityTxtOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityTxtOffsetX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityTxtOffsetX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityTxtOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityTxtOffsetX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityTxtOffsetX_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:DensityTxtOffsetY")]
	protected float DensityTxtOffsetY
	{
		get
		{
			CheckDestroyed();
			if (!DensityTxtOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityTxtOffsetY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityTxtOffsetY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityTxtOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityTxtOffsetY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityTxtOffsetY_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:BrushNoise")]
	protected float BrushNoise
	{
		get
		{
			CheckDestroyed();
			if (!BrushNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushNoise");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushNoise_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushNoise");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushNoise_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:VeloInputTile")]
	protected float VeloInputTile
	{
		get
		{
			CheckDestroyed();
			if (!VeloInputTile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloInputTile");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VeloInputTile_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VeloInputTile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:VeloInputTile");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VeloInputTile_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:DensityInputNoiseAmp")]
	protected float DensityInputNoiseAmp
	{
		get
		{
			CheckDestroyed();
			if (!DensityInputNoiseAmp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityInputNoiseAmp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityInputNoiseAmp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityInputNoiseAmp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityInputNoiseAmp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityInputNoiseAmp_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:DensityInputNoiseOffset")]
	protected float DensityInputNoiseOffset
	{
		get
		{
			CheckDestroyed();
			if (!DensityInputNoiseOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityInputNoiseOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityInputNoiseOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityInputNoiseOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityInputNoiseOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityInputNoiseOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:DensityInputNoiseTile")]
	protected float DensityInputNoiseTile
	{
		get
		{
			CheckDestroyed();
			if (!DensityInputNoiseTile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityInputNoiseTile");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DensityInputNoiseTile_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DensityInputNoiseTile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:DensityInputNoiseTile");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DensityInputNoiseTile_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:BrushRnd")]
	protected float BrushRnd
	{
		get
		{
			CheckDestroyed();
			if (!BrushRnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushRnd");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrushRnd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushRnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:BrushRnd");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrushRnd_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:worldOffsetX")]
	protected float worldOffsetX
	{
		get
		{
			CheckDestroyed();
			if (!worldOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:worldOffsetX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, worldOffsetX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!worldOffsetX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:worldOffsetX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, worldOffsetX_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:worldOffsetY")]
	protected float worldOffsetY
	{
		get
		{
			CheckDestroyed();
			if (!worldOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:worldOffsetY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, worldOffsetY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!worldOffsetY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUFluid2DComponent:worldOffsetY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, worldOffsetY_Offset), value);
			}
		}
	}

	[UFunction(Flags = 336069633u)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:GetVeloDensityTexture")]
	protected unsafe UTextureRenderTarget2D GetVeloDensityTexture()
	{
		CheckDestroyed();
		if (!GetVeloDensityTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFluid2DComponent:GetVeloDensityTexture");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVeloDensityTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVeloDensityTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVeloDensityTexture_FunctionAddress, intPtr, GetVeloDensityTexture_ParamsSize);
		return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, GetVeloDensityTexture_ReturnValue_Offset), 0, GetVeloDensityTexture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 336069633u)]
	[UMetaPath("/Script/b1.BGUFluid2DComponent:GetPressureDivergenceTexture")]
	protected unsafe UTextureRenderTarget2D GetPressureDivergenceTexture()
	{
		CheckDestroyed();
		if (!GetPressureDivergenceTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFluid2DComponent:GetPressureDivergenceTexture");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPressureDivergenceTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPressureDivergenceTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPressureDivergenceTexture_FunctionAddress, intPtr, GetPressureDivergenceTexture_ParamsSize);
		return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, GetPressureDivergenceTexture_ReturnValue_Offset), 0, GetPressureDivergenceTexture_ReturnValue_PropertyAddress.Address);
	}

	static UBGUFluid2DComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFluid2DComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFluid2DComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUFluid2DComponent");
		NativeReflectionCached.GetPropertyRef(ref toggleSim_PropertyAddress, intPtr, "toggleSim");
		toggleSim_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "toggleSim");
		toggleSim_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "toggleSim", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PostProcessCollisionData_PropertyAddress, intPtr, "bPostProcessCollisionData");
		PostProcessCollisionData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPostProcessCollisionData");
		PostProcessCollisionData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPostProcessCollisionData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref blueprintDrivenParameters_PropertyAddress, intPtr, "blueprintDrivenParameters");
		blueprintDrivenParameters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "blueprintDrivenParameters");
		blueprintDrivenParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "blueprintDrivenParameters", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MovedCheck_PropertyAddress, intPtr, "bMovedCheck");
		MovedCheck_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMovedCheck");
		MovedCheck_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMovedCheck", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref blocationCheck_PropertyAddress, intPtr, "blocationCheck");
		blocationCheck_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "blocationCheck");
		blocationCheck_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "blocationCheck", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalSim_PropertyAddress, intPtr, "bLocalSim");
		LocalSim_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLocalSim");
		LocalSim_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLocalSim", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HighQualitySim_PropertyAddress, intPtr, "bHighQualitySim");
		HighQualitySim_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHighQualitySim");
		HighQualitySim_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHighQualitySim", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SimAreaClamp_PropertyAddress, intPtr, "bSimAreaClamp");
		SimAreaClamp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSimAreaClamp");
		SimAreaClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSimAreaClamp", Classes.FBoolProperty);
		MaxIteration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxIteration");
		MaxIteration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxIteration", Classes.FIntProperty);
		SimulationResX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimulationResX");
		SimulationResX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimulationResX", Classes.FIntProperty);
		SimulationResY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimulationResY");
		SimulationResY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimulationResY", Classes.FIntProperty);
		SimAreaSizeInCM_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimAreaSizeInCM");
		SimAreaSizeInCM_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimAreaSizeInCM", Classes.FFloatProperty);
		SnappedPosParameterName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SnappedPosParameterName");
		SnappedPosParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SnappedPosParameterName", Classes.FNameProperty);
		dynamicSDFMpc_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "dynamicSDFMpc");
		dynamicSDFMpc_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "dynamicSDFMpc", Classes.FObjectProperty);
		worldOffsetThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "worldOffsetThreshold");
		worldOffsetThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "worldOffsetThreshold", Classes.FFloatProperty);
		moveThreadhold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "moveThreadhold");
		moveThreadhold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "moveThreadhold", Classes.FFloatProperty);
		edgeExtendSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "edgeExtendSize");
		edgeExtendSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "edgeExtendSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportVeloDensity_PropertyAddress, intPtr, "bExportVeloDensity");
		ExportVeloDensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bExportVeloDensity");
		ExportVeloDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bExportVeloDensity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportPressureDivergence_PropertyAddress, intPtr, "bExportPressureDivergence");
		ExportPressureDivergence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bExportPressureDivergence");
		ExportPressureDivergence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bExportPressureDivergence", Classes.FBoolProperty);
		veloDensityOutput_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "veloDensityOutput");
		veloDensityOutput_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "veloDensityOutput", Classes.FObjectProperty);
		pressureDivergenceOutput_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "pressureDivergenceOutput");
		pressureDivergenceOutput_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "pressureDivergenceOutput", Classes.FObjectProperty);
		CollisionQueryMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionQueryMaterial");
		CollisionQueryMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionQueryMaterial", Classes.FObjectProperty);
		PPCollisionQueryMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PPCollisionQueryMaterial");
		PPCollisionQueryMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PPCollisionQueryMaterial", Classes.FObjectProperty);
		CompositeMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CompositeMaterial");
		CompositeMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CompositeMaterial", Classes.FObjectProperty);
		AdvectMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AdvectMaterial");
		AdvectMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AdvectMaterial", Classes.FObjectProperty);
		DivergenceMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DivergenceMaterial");
		DivergenceMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DivergenceMaterial", Classes.FObjectProperty);
		PressureStep1Material_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PressureStep1Material");
		PressureStep1Material_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PressureStep1Material", Classes.FObjectProperty);
		PressureStep2Material_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PressureStep2Material");
		PressureStep2Material_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PressureStep2Material", Classes.FObjectProperty);
		BrushPuncture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushPuncture");
		BrushPuncture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushPuncture", Classes.FFloatProperty);
		VeloDirNoise_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VeloDirNoise");
		VeloDirNoise_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VeloDirNoise", Classes.FFloatProperty);
		Speed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Speed");
		Speed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Speed", Classes.FFloatProperty);
		VeloFromSimAreaMotion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VeloFromSimAreaMotion");
		VeloFromSimAreaMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VeloFromSimAreaMotion", Classes.FFloatProperty);
		SimEdgeBouncyness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimEdgeBouncyness");
		SimEdgeBouncyness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimEdgeBouncyness", Classes.FFloatProperty);
		FadeDensityAtSimEdge_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FadeDensityAtSimEdge");
		FadeDensityAtSimEdge_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FadeDensityAtSimEdge", Classes.FFloatProperty);
		VeloDirNoiseSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VeloDirNoiseSize");
		VeloDirNoiseSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VeloDirNoiseSize", Classes.FFloatProperty);
		VeloDirNoiseSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VeloDirNoiseSpeed");
		VeloDirNoiseSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VeloDirNoiseSpeed", Classes.FFloatProperty);
		VeloOffsetX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VeloOffsetX");
		VeloOffsetX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VeloOffsetX", Classes.FFloatProperty);
		VeloOffsetY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VeloOffsetY");
		VeloOffsetY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VeloOffsetY", Classes.FFloatProperty);
		VeloFromBrushMotion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VeloFromBrushMotion");
		VeloFromBrushMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VeloFromBrushMotion", Classes.FFloatProperty);
		VeloStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VeloStrength");
		VeloStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VeloStrength", Classes.FFloatProperty);
		VeloRotate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VeloRotate");
		VeloRotate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VeloRotate", Classes.FFloatProperty);
		VeloAmpNoise_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VeloAmpNoise");
		VeloAmpNoise_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VeloAmpNoise", Classes.FFloatProperty);
		InputFeedback_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputFeedback");
		InputFeedback_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputFeedback", Classes.FFloatProperty);
		FlowFeedback_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FlowFeedback");
		FlowFeedback_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FlowFeedback", Classes.FFloatProperty);
		Divergence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Divergence");
		Divergence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Divergence", Classes.FFloatProperty);
		BrushSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushSize");
		BrushSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushSize", Classes.FFloatProperty);
		BrushStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushStrength");
		BrushStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushStrength", Classes.FFloatProperty);
		EraserMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EraserMode");
		EraserMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EraserMode", Classes.FFloatProperty);
		BrushHardness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushHardness");
		BrushHardness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushHardness", Classes.FFloatProperty);
		DensityTemplate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DensityTemplate");
		DensityTemplate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DensityTemplate", Classes.FObjectProperty);
		VelocityTemplate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VelocityTemplate");
		VelocityTemplate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VelocityTemplate", Classes.FObjectProperty);
		VelocityOffsetSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VelocityOffsetSpeed");
		VelocityOffsetSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VelocityOffsetSpeed", Classes.FFloatProperty);
		EdgeMaskWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EdgeMaskWidth");
		EdgeMaskWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EdgeMaskWidth", Classes.FFloatProperty);
		DensityTxtMult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DensityTxtMult");
		DensityTxtMult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DensityTxtMult", Classes.FFloatProperty);
		DensityTxtScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DensityTxtScale");
		DensityTxtScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DensityTxtScale", Classes.FFloatProperty);
		DensityTxtOffsetX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DensityTxtOffsetX");
		DensityTxtOffsetX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DensityTxtOffsetX", Classes.FFloatProperty);
		DensityTxtOffsetY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DensityTxtOffsetY");
		DensityTxtOffsetY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DensityTxtOffsetY", Classes.FFloatProperty);
		BrushNoise_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushNoise");
		BrushNoise_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushNoise", Classes.FFloatProperty);
		VeloInputTile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VeloInputTile");
		VeloInputTile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VeloInputTile", Classes.FFloatProperty);
		DensityInputNoiseAmp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DensityInputNoiseAmp");
		DensityInputNoiseAmp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DensityInputNoiseAmp", Classes.FFloatProperty);
		DensityInputNoiseOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DensityInputNoiseOffset");
		DensityInputNoiseOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DensityInputNoiseOffset", Classes.FFloatProperty);
		DensityInputNoiseTile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DensityInputNoiseTile");
		DensityInputNoiseTile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DensityInputNoiseTile", Classes.FFloatProperty);
		BrushRnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrushRnd");
		BrushRnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrushRnd", Classes.FFloatProperty);
		worldOffsetX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "worldOffsetX");
		worldOffsetX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "worldOffsetX", Classes.FFloatProperty);
		worldOffsetY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "worldOffsetY");
		worldOffsetY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "worldOffsetY", Classes.FFloatProperty);
		GetVeloDensityTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVeloDensityTexture");
		GetVeloDensityTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVeloDensityTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVeloDensityTexture_ReturnValue_PropertyAddress, GetVeloDensityTexture_FunctionAddress, "ReturnValue");
		GetVeloDensityTexture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVeloDensityTexture_FunctionAddress, "ReturnValue");
		GetVeloDensityTexture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVeloDensityTexture_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetVeloDensityTexture_IsValid = GetVeloDensityTexture_FunctionAddress != IntPtr.Zero && GetVeloDensityTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFluid2DComponent:GetVeloDensityTexture", GetVeloDensityTexture_IsValid);
		GetPressureDivergenceTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPressureDivergenceTexture");
		GetPressureDivergenceTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPressureDivergenceTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPressureDivergenceTexture_ReturnValue_PropertyAddress, GetPressureDivergenceTexture_FunctionAddress, "ReturnValue");
		GetPressureDivergenceTexture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPressureDivergenceTexture_FunctionAddress, "ReturnValue");
		GetPressureDivergenceTexture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPressureDivergenceTexture_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPressureDivergenceTexture_IsValid = GetPressureDivergenceTexture_FunctionAddress != IntPtr.Zero && GetPressureDivergenceTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFluid2DComponent:GetPressureDivergenceTexture", GetPressureDivergenceTexture_IsValid);
	}
}
