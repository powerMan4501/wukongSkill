using System;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_LocalFluid2DMgr : GameStateSystemBase
{
	private BGC_LocalFluid2DMgrData LocalFluid2DMgrData;

	private int Fluid2DWorkMode = 1;

	public override void OnAttach()
	{
		LocalFluid2DMgrData = RequireWritableData<BGC_LocalFluid2DMgrData>();
	}

	public override void PreBeginPlay()
	{
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.Fluid2D.WorkMode");
		if (consoleVariable != null)
		{
			Fluid2DWorkMode = consoleVariable.GetInt();
		}
		if (Fluid2DWorkMode == 2)
		{
			InitData();
		}
	}

	public override void OnBeginPlay()
	{
		if (Fluid2DWorkMode == 2)
		{
			LocalFluid2DMgrData.InitConfigFromDA(BGW_PreloadAssetMgr.Get(this).DefaultLocalFluid2DConfig);
			craeteRenderTarget();
			createSimMaterialInstance();
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (Fluid2DWorkMode != 2)
		{
			return;
		}
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.Fluid2D.Enabled");
		if ((object)consoleVariable != null && consoleVariable.GetInt() == 0)
		{
			return;
		}
		updateMPCInfo();
		if (simCheck())
		{
			movedCheck();
			if (LocalFluid2DMgrData.bLocalSim)
			{
				updateWorldOffset();
			}
			coreFluidSim();
			updateSimParameters();
			exportSimResult();
		}
	}

	private void InitData()
	{
		LocalFluid2DMgrData.bHighQualitySim = false;
		LocalFluid2DMgrData.MaxIteration = 1;
		LocalFluid2DMgrData.SimulationResX = 512;
		LocalFluid2DMgrData.SimulationResY = 512;
		LocalFluid2DMgrData.bExportVeloDensity = false;
		LocalFluid2DMgrData.bExportPressureDivergence = false;
		LocalFluid2DMgrData.DensityTemplate = null;
		LocalFluid2DMgrData.VelocityTemplate = null;
		LocalFluid2DMgrData.RT_Advection = null;
		LocalFluid2DMgrData.RT_PressureDivergence = null;
		LocalFluid2DMgrData.RT_Composite = null;
		LocalFluid2DMgrData.RT_PressureDivergenceTemp = null;
		LocalFluid2DMgrData.CompositeMaterial = null;
		LocalFluid2DMgrData.AdvectMaterial = null;
		LocalFluid2DMgrData.DivergenceMaterial = null;
		LocalFluid2DMgrData.PressureStep1Material = null;
		LocalFluid2DMgrData.PressureStep2Material = null;
		LocalFluid2DMgrData.dynamicSDFMpc = null;
		LocalFluid2DMgrData.SimAreaCenterWorldSpace = new FVector(0.0, 0.0, 0.0);
		LocalFluid2DMgrData.deltaSnappedPos = new FVector(0.0, 0.0, 0.0);
		LocalFluid2DMgrData.lastSnappedPos = new FVector(0.0, 0.0, 0.0);
		LocalFluid2DMgrData.SimAreaSizeInCM = 4000f;
		LocalFluid2DMgrData.worldOffsetX = 0f;
		LocalFluid2DMgrData.worldOffsetY = 0f;
		LocalFluid2DMgrData.edgeExtendSize = 0f;
		LocalFluid2DMgrData.bSimAreaClamp = false;
		LocalFluid2DMgrData.bLocalSim = true;
		LocalFluid2DMgrData.toggleSim = true;
		LocalFluid2DMgrData.blocationCheck = true;
		LocalFluid2DMgrData.bMovedCheck = true;
		LocalFluid2DMgrData.blueprintDrivenParameters = true;
		LocalFluid2DMgrData.bPostProcessCollisionData = false;
		LocalFluid2DMgrData.SnappedPosParameterName = B1GlobalFNames.CenterSnappedPos_WorldSpace;
	}

	private bool simCheck()
	{
		if (playerLocaltionCheck())
		{
			return toggleSimCheck();
		}
		return false;
	}

	private bool toggleSimCheck()
	{
		return LocalFluid2DMgrData.toggleSim;
	}

	private bool playerLocaltionCheck()
	{
		return true;
	}

	private void coreFluidSim()
	{
		if (LocalFluid2DMgrData.bPostProcessCollisionData)
		{
			URenderingLibrary.DrawMaterialToRenderTarget(Owner, LocalFluid2DMgrData.RT_CollisionResult, LocalFluid2DMgrData.CollisionQueryMaterialInstance);
			URenderingLibrary.DrawMaterialToRenderTarget(Owner, LocalFluid2DMgrData.RT_PPCollisionResult, LocalFluid2DMgrData.PPCollisionQueryMaterialInstance);
		}
		URenderingLibrary.DrawMaterialToRenderTarget(Owner, LocalFluid2DMgrData.RT_Composite, LocalFluid2DMgrData.CompositeMaterialInstance);
		URenderingLibrary.DrawMaterialToRenderTarget(Owner, LocalFluid2DMgrData.RT_Advection, LocalFluid2DMgrData.AdvectMaterialInstance);
		URenderingLibrary.DrawMaterialToRenderTarget(Owner, LocalFluid2DMgrData.RT_PressureDivergence, LocalFluid2DMgrData.DivergenceMaterialInstance);
		int num = LocalFluid2DMgrData.MaxIteration - 1;
		int i = 0;
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.Fluid2D.KernelMultiplyer");
		int num2 = (((object)consoleVariable != null && consoleVariable.GetInt() == 0) ? 5 : 15);
		for (; i <= num; i++)
		{
			float value = CheckSingleIterationFlag(i, num);
			LocalFluid2DMgrData.PressureStep1MaterialInstance.SetScalarParameterValue(new FName("SingleIterationFlag"), value);
			URenderingLibrary.DrawMaterialToRenderTarget(Owner, LocalFluid2DMgrData.RT_PressureDivergenceTemp, LocalFluid2DMgrData.PressureStep1MaterialInstance);
			LocalFluid2DMgrData.PressureStep1MaterialInstance.SetScalarParameterValue(new FName("KernelMult"), num2);
			float value2 = CheckKeepDivergenceBuffer(i, num);
			LocalFluid2DMgrData.PressureStep2MaterialInstance.SetScalarParameterValue(new FName("SingleIterationFlag"), value);
			LocalFluid2DMgrData.PressureStep2MaterialInstance.SetScalarParameterValue(new FName("KeepDivergenceBuffer"), value2);
			URenderingLibrary.DrawMaterialToRenderTarget(Owner, LocalFluid2DMgrData.RT_PressureDivergence, LocalFluid2DMgrData.PressureStep2MaterialInstance);
			LocalFluid2DMgrData.PressureStep2MaterialInstance.SetScalarParameterValue(new FName("KernelMult"), num2);
		}
		static int CheckKeepDivergenceBuffer(int a, int b)
		{
			return (a != b) ? 1 : 0;
		}
		static int CheckSingleIterationFlag(int a, int b)
		{
			if (a != b && b > 0)
			{
				return 0;
			}
			return 1;
		}
	}

	private void updateMPCInfo()
	{
		FLinearColor vectorParameterValue = UMaterialLibrary.GetVectorParameterValue(Owner, LocalFluid2DMgrData.dynamicSDFMpc, LocalFluid2DMgrData.SnappedPosParameterName);
		FVector snappedPos = new FVector(vectorParameterValue);
		LocalFluid2DMgrData.lastSnappedPos = LocalFluid2DMgrData.snappedPos;
		LocalFluid2DMgrData.snappedPos = snappedPos;
	}

	private void movedCheck()
	{
		LocalFluid2DMgrData.bMovedLastFrame = false;
		if (!(LocalFluid2DMgrData.lastSnappedPos == FVector.ZeroVector))
		{
			LocalFluid2DMgrData.deltaDir = LocalFluid2DMgrData.snappedPos - LocalFluid2DMgrData.lastSnappedPos;
			if (LocalFluid2DMgrData.deltaDir.Size() > LocalFluid2DMgrData.moveThreadhold)
			{
				LocalFluid2DMgrData.bMovedLastFrame = true;
			}
		}
	}

	private void updateWorldOffset()
	{
		FTransform fTransform = default(FTransform);
		fTransform.SetLocation(new FVector(0.0, 0.0, 0.0));
		fTransform.SetRotation(FQuat.MakeFromEuler(new FVector(0.0, 0.0, 0.0)));
		fTransform.SetScale3D(new FVector(1.0, 1.0, 1.0));
		LocalFluid2DMgrData.deltaDir = fTransform.InverseTransformVector(LocalFluid2DMgrData.deltaDir);
		LocalFluid2DMgrData.deltaDir *= (double)LocalFluid2DMgrData.OffsetFromSimAreaMotion * 0.001;
		LocalFluid2DMgrData.deltaSnappedPos += LocalFluid2DMgrData.deltaDir;
		LocalFluid2DMgrData.worldOffsetX = ((Math.Abs(LocalFluid2DMgrData.deltaDir.X) > LocalFluid2DMgrData.worldOffsetThreshold) ? LocalFluid2DMgrData.deltaDir.X : 0f);
		LocalFluid2DMgrData.worldOffsetY = ((Math.Abs(LocalFluid2DMgrData.deltaDir.Y) > LocalFluid2DMgrData.worldOffsetThreshold) ? LocalFluid2DMgrData.deltaDir.Y : 0f);
		LocalFluid2DMgrData.DivergenceMaterialInstance.SetScalarParameterValue(new FName("WorldOffsetX"), LocalFluid2DMgrData.worldOffsetX);
		LocalFluid2DMgrData.DivergenceMaterialInstance.SetScalarParameterValue(new FName("WorldOffsetY"), LocalFluid2DMgrData.worldOffsetY);
		LocalFluid2DMgrData.AdvectMaterialInstance.SetScalarParameterValue(new FName("WorldOffsetX"), LocalFluid2DMgrData.worldOffsetX);
		LocalFluid2DMgrData.AdvectMaterialInstance.SetScalarParameterValue(new FName("WorldOffsetY"), LocalFluid2DMgrData.worldOffsetY);
		LocalFluid2DMgrData.PressureStep1MaterialInstance.SetScalarParameterValue(new FName("WorldOffsetX"), LocalFluid2DMgrData.worldOffsetX);
		LocalFluid2DMgrData.PressureStep1MaterialInstance.SetScalarParameterValue(new FName("WorldOffsetY"), LocalFluid2DMgrData.worldOffsetY);
		LocalFluid2DMgrData.outputWorldOffsetX = LocalFluid2DMgrData.deltaSnappedPos.X * LocalFluid2DMgrData.OffsetFromSimAreaMotion;
		LocalFluid2DMgrData.outputWorldOffsetY = LocalFluid2DMgrData.deltaSnappedPos.Y * LocalFluid2DMgrData.OffsetFromSimAreaMotion;
	}

	private void updateSimParameters()
	{
		LocalFluid2DMgrData.SimAreaCenterWorldSpace = LocalFluid2DMgrData.snappedPos;
		if (LocalFluid2DMgrData.blueprintDrivenParameters)
		{
			float value = 1f;
			if (LocalFluid2DMgrData.bMovedCheck && !LocalFluid2DMgrData.bMovedLastFrame)
			{
				value = 0f;
			}
			if (LocalFluid2DMgrData.bPostProcessCollisionData)
			{
				LocalFluid2DMgrData.CollisionQueryMaterialInstance.SetVectorParameterValue(new FName("WorldSpaceSimCenter"), new FLinearColor(LocalFluid2DMgrData.SimAreaCenterWorldSpace));
			}
			LocalFluid2DMgrData.DivergenceMaterialInstance.SetScalarParameterValue(new FName("Divergence"), LocalFluid2DMgrData.Divergence);
			LocalFluid2DMgrData.DivergenceMaterialInstance.SetScalarParameterValue(new FName("BrushPuncture"), LocalFluid2DMgrData.BrushPuncture);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetVectorParameterValue(new FName("WorldSpaceSimCenter"), new FLinearColor(LocalFluid2DMgrData.SimAreaCenterWorldSpace));
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("DensityTxtScale"), LocalFluid2DMgrData.DensityTxtScale);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("DensityTxtOffsetX"), LocalFluid2DMgrData.DensityTxtOffsetX);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("DensityTxtOffsetY"), LocalFluid2DMgrData.DensityTxtOffsetY);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("DensityNoiseAmount"), LocalFluid2DMgrData.DensityInputNoiseAmp);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("DensityNoiseSpeed"), LocalFluid2DMgrData.DensityInputNoiseOffset);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("DensityTxtMult"), LocalFluid2DMgrData.DensityTxtMult);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("FlowFeedback"), LocalFluid2DMgrData.FlowFeedback);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("FadeDensityAtSimEdge"), LocalFluid2DMgrData.FadeDensityAtSimEdge);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("EdgeMaskWidth"), LocalFluid2DMgrData.EdgeMaskWidth);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloFromBrushMotion"), LocalFluid2DMgrData.VeloFromBrushMotion);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloStrength"), LocalFluid2DMgrData.VeloStrength);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloOffsetX"), LocalFluid2DMgrData.VeloOffsetX);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloOffsetY"), LocalFluid2DMgrData.VeloOffsetY);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloAmpNoise"), LocalFluid2DMgrData.VeloAmpNoise);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloDirNoise"), LocalFluid2DMgrData.VeloDirNoise);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloRotate"), LocalFluid2DMgrData.VeloRotate);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("SimEdgeBouncyness"), LocalFluid2DMgrData.SimEdgeBouncyness);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloDirNoiseSize"), LocalFluid2DMgrData.VeloDirNoiseSize);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloDirNoiseSpeed"), LocalFluid2DMgrData.VeloDirNoiseSpeed);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloInputTile"), LocalFluid2DMgrData.VeloInputTile);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloInputOffsetSpeed"), LocalFluid2DMgrData.VelocityOffsetSpeed);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloInputValid"), value);
		}
	}

	private void craeteRenderTarget()
	{
		ETextureRenderTargetFormat eTextureRenderTargetFormat = (LocalFluid2DMgrData.bHighQualitySim ? ETextureRenderTargetFormat.RTF_RGBA32f : ETextureRenderTargetFormat.RTF_RGBA16f);
		ETextureRenderTargetFormat eTextureRenderTargetFormat2 = eTextureRenderTargetFormat;
		int? num = IConsoleManager.Get().FindConsoleVariable("b.Fluid2D.ForceLowBufferQuality")?.GetInt();
		if (num == 1)
		{
			eTextureRenderTargetFormat2 = ETextureRenderTargetFormat.RTF_RG8;
		}
		else if (num == 2)
		{
			eTextureRenderTargetFormat2 = ETextureRenderTargetFormat.RTF_RG16f;
		}
		int x = IConsoleManager.Get().FindConsoleVariable("b.Fluid2D.ForceLowBufferQuality").GetInt();
		eTextureRenderTargetFormat2 = ETextureRenderTargetFormat.RTF_RG16f;
		int width = LocalFluid2DMgrData.SimulationResX / FMath.Clamp(x, 1, 16);
		int height = LocalFluid2DMgrData.SimulationResY / FMath.Clamp(x, 1, 16);
		if (LocalFluid2DMgrData.bPostProcessCollisionData)
		{
			LocalFluid2DMgrData.RT_CollisionResult = URenderingLibrary.CreateRenderTarget2D(Owner, width, height, eTextureRenderTargetFormat, FLinearColor.Black, bAutoGenerateMipMaps: false);
			LocalFluid2DMgrData.RT_CollisionResult.Filter = ETextureFilter.TF_Bilinear;
			LocalFluid2DMgrData.RT_CollisionResult.AddressX = (LocalFluid2DMgrData.bSimAreaClamp ? ETextureAddress.TA_Clamp : ETextureAddress.TA_Wrap);
			LocalFluid2DMgrData.RT_CollisionResult.AddressY = (LocalFluid2DMgrData.bSimAreaClamp ? ETextureAddress.TA_Clamp : ETextureAddress.TA_Wrap);
			LocalFluid2DMgrData.RT_PPCollisionResult = URenderingLibrary.CreateRenderTarget2D(Owner, width, height, eTextureRenderTargetFormat, FLinearColor.Black, bAutoGenerateMipMaps: false);
			LocalFluid2DMgrData.RT_PPCollisionResult.Filter = ETextureFilter.TF_Bilinear;
			LocalFluid2DMgrData.RT_PPCollisionResult.AddressX = (LocalFluid2DMgrData.bSimAreaClamp ? ETextureAddress.TA_Clamp : ETextureAddress.TA_Wrap);
			LocalFluid2DMgrData.RT_PPCollisionResult.AddressY = (LocalFluid2DMgrData.bSimAreaClamp ? ETextureAddress.TA_Clamp : ETextureAddress.TA_Wrap);
		}
		LocalFluid2DMgrData.RT_Advection = URenderingLibrary.CreateRenderTarget2D(Owner, width, height, eTextureRenderTargetFormat, FLinearColor.Black, bAutoGenerateMipMaps: false);
		LocalFluid2DMgrData.RT_Advection.Filter = ETextureFilter.TF_Bilinear;
		LocalFluid2DMgrData.RT_Advection.AddressX = (LocalFluid2DMgrData.bSimAreaClamp ? ETextureAddress.TA_Clamp : ETextureAddress.TA_Wrap);
		LocalFluid2DMgrData.RT_Advection.AddressY = (LocalFluid2DMgrData.bSimAreaClamp ? ETextureAddress.TA_Clamp : ETextureAddress.TA_Wrap);
		LocalFluid2DMgrData.RT_PressureDivergence = LocalFluid2DMgrData.pressureDivergenceOutput;
		LocalFluid2DMgrData.RT_PressureDivergenceTemp = URenderingLibrary.CreateRenderTarget2D(Owner, width, height, eTextureRenderTargetFormat2, FLinearColor.Black, bAutoGenerateMipMaps: false);
		LocalFluid2DMgrData.RT_PressureDivergenceTemp.Filter = ETextureFilter.TF_Bilinear;
		LocalFluid2DMgrData.RT_PressureDivergenceTemp.AddressX = (LocalFluid2DMgrData.bSimAreaClamp ? ETextureAddress.TA_Clamp : ETextureAddress.TA_Wrap);
		LocalFluid2DMgrData.RT_PressureDivergenceTemp.AddressY = (LocalFluid2DMgrData.bSimAreaClamp ? ETextureAddress.TA_Clamp : ETextureAddress.TA_Wrap);
		LocalFluid2DMgrData.RT_Composite = URenderingLibrary.CreateRenderTarget2D(Owner, width, height, eTextureRenderTargetFormat, FLinearColor.Black, bAutoGenerateMipMaps: false);
		LocalFluid2DMgrData.RT_Composite.Filter = ETextureFilter.TF_Bilinear;
		LocalFluid2DMgrData.RT_Composite.AddressX = (LocalFluid2DMgrData.bSimAreaClamp ? ETextureAddress.TA_Clamp : ETextureAddress.TA_Wrap);
		LocalFluid2DMgrData.RT_Composite.AddressY = (LocalFluid2DMgrData.bSimAreaClamp ? ETextureAddress.TA_Clamp : ETextureAddress.TA_Wrap);
	}

	private void createSimMaterialInstance()
	{
		float scalarParameterValue = UMaterialLibrary.GetScalarParameterValue(Owner, LocalFluid2DMgrData.dynamicSDFMpc, B1GlobalFNames.SimulationSize);
		LocalFluid2DMgrData.OffsetFromSimAreaMotion = 1f / scalarParameterValue * 1000f;
		LocalFluid2DMgrData.snappedPos = Owner.GetActorLocation();
		float value = 1f;
		LocalFluid2DMgrData.CompositeMaterialInstance = UMaterialLibrary.CreateDynamicMaterialInstance(Owner, LocalFluid2DMgrData.CompositeMaterial, FName.None, EMIDCreationFlags.None);
		LocalFluid2DMgrData.CompositeMaterialInstance.SetTextureParameterValue(new FName("Texture"), LocalFluid2DMgrData.RT_Advection);
		LocalFluid2DMgrData.CompositeMaterialInstance.SetTextureParameterValue(new FName("PressureTexture"), LocalFluid2DMgrData.RT_PressureDivergence);
		LocalFluid2DMgrData.CompositeMaterialInstance.SetTextureParameterValue(new FName("VeloInputTexture"), LocalFluid2DMgrData.VelocityTemplate);
		LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("VeloInputSelect"), 1f);
		LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("Randomize"), 0f);
		LocalFluid2DMgrData.CompositeMaterialInstance.SetTextureParameterValue(new FName("TextureAdd2"), LocalFluid2DMgrData.DensityTemplate);
		LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("FlowFeedback"), LocalFluid2DMgrData.FlowFeedback);
		LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("DensityTxtRandomOffset"), 0f);
		LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("NullValue"), 1E-06f);
		LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("TexelSizeMult"), LocalFluid2DMgrData.Speed);
		if (LocalFluid2DMgrData.bPostProcessCollisionData)
		{
			LocalFluid2DMgrData.CollisionQueryMaterialInstance = UMaterialLibrary.CreateDynamicMaterialInstance(Owner, LocalFluid2DMgrData.CollisionQueryMaterial, FName.None, EMIDCreationFlags.None);
			LocalFluid2DMgrData.CollisionQueryMaterialInstance.SetScalarParameterValue(new FName("bLocalSim"), value);
			LocalFluid2DMgrData.CollisionQueryMaterialInstance.SetScalarParameterValue(new FName("waterHeight"), LocalFluid2DMgrData.snappedPos.Z);
			LocalFluid2DMgrData.CollisionQueryMaterialInstance.SetVectorParameterValue(new FName("WorldSpaceSimCenter"), new FLinearColor(LocalFluid2DMgrData.SimAreaCenterWorldSpace));
			LocalFluid2DMgrData.CollisionQueryMaterialInstance.SetScalarParameterValue(new FName("simAreaSize"), LocalFluid2DMgrData.SimAreaSizeInCM);
			LocalFluid2DMgrData.PPCollisionQueryMaterialInstance = UMaterialLibrary.CreateDynamicMaterialInstance(Owner, LocalFluid2DMgrData.PPCollisionQueryMaterial, FName.None, EMIDCreationFlags.None);
			LocalFluid2DMgrData.PPCollisionQueryMaterialInstance.SetTextureParameterValue(new FName("CollisionQueryResult"), LocalFluid2DMgrData.RT_CollisionResult);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetTextureParameterValue(new FName("CollisionQueryResult"), LocalFluid2DMgrData.RT_PPCollisionResult);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("PostProcessCollisionResult"), 1f);
		}
		else
		{
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("PostProcessCollisionResult"), 0f);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("bLocalSim"), value);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("waterHeight"), LocalFluid2DMgrData.snappedPos.Z);
			LocalFluid2DMgrData.CompositeMaterialInstance.SetVectorParameterValue(new FName("WorldSpaceSimCenter"), new FLinearColor(LocalFluid2DMgrData.SimAreaCenterWorldSpace));
			LocalFluid2DMgrData.CompositeMaterialInstance.SetScalarParameterValue(new FName("simAreaSize"), LocalFluid2DMgrData.SimAreaSizeInCM);
		}
		LocalFluid2DMgrData.AdvectMaterialInstance = UMaterialLibrary.CreateDynamicMaterialInstance(Owner, LocalFluid2DMgrData.AdvectMaterial, FName.None, EMIDCreationFlags.None);
		LocalFluid2DMgrData.AdvectMaterialInstance.SetTextureParameterValue(new FName("Texture"), LocalFluid2DMgrData.RT_Composite);
		LocalFluid2DMgrData.AdvectMaterialInstance.SetScalarParameterValue(new FName("TexelSizeMult"), LocalFluid2DMgrData.Speed);
		LocalFluid2DMgrData.DivergenceMaterialInstance = UMaterialLibrary.CreateDynamicMaterialInstance(Owner, LocalFluid2DMgrData.DivergenceMaterial, FName.None, EMIDCreationFlags.None);
		LocalFluid2DMgrData.DivergenceMaterialInstance.SetTextureParameterValue(new FName("Texture"), LocalFluid2DMgrData.RT_Advection);
		LocalFluid2DMgrData.DivergenceMaterialInstance.SetScalarParameterValue(new FName("TexelSizeMult"), LocalFluid2DMgrData.Speed);
		LocalFluid2DMgrData.PressureStep1MaterialInstance = UMaterialLibrary.CreateDynamicMaterialInstance(Owner, LocalFluid2DMgrData.PressureStep1Material, FName.None, EMIDCreationFlags.None);
		LocalFluid2DMgrData.PressureStep1MaterialInstance.SetTextureParameterValue(new FName("Texture"), LocalFluid2DMgrData.RT_PressureDivergence);
		LocalFluid2DMgrData.PressureStep1MaterialInstance.SetScalarParameterValue(new FName("KernelIndexOffset"), 0f);
		LocalFluid2DMgrData.PressureStep1MaterialInstance.SetScalarParameterValue(new FName("FeedbackDampening"), 0.999f);
		LocalFluid2DMgrData.PressureStep1MaterialInstance.SetScalarParameterValue(new FName("DisablePressureEdgeMasking"), 1f);
		LocalFluid2DMgrData.PressureStep1MaterialInstance.SetScalarParameterValue(new FName("PressureEdgeMasking"), 0f);
		LocalFluid2DMgrData.PressureStep1MaterialInstance.SetScalarParameterValue(new FName("TexelSizeMult"), LocalFluid2DMgrData.Speed);
		LocalFluid2DMgrData.PressureStep2MaterialInstance = UMaterialLibrary.CreateDynamicMaterialInstance(Owner, LocalFluid2DMgrData.PressureStep2Material, FName.None, EMIDCreationFlags.None);
		LocalFluid2DMgrData.PressureStep2MaterialInstance.SetTextureParameterValue(new FName("Texture"), LocalFluid2DMgrData.RT_PressureDivergenceTemp);
		LocalFluid2DMgrData.PressureStep2MaterialInstance.SetScalarParameterValue(new FName("KernelIndexOffset"), 0f);
		LocalFluid2DMgrData.PressureStep2MaterialInstance.SetScalarParameterValue(new FName("FeedbackDampening"), 0.999f);
		LocalFluid2DMgrData.PressureStep2MaterialInstance.SetScalarParameterValue(new FName("DisablePressureEdgeMasking"), 1f);
		LocalFluid2DMgrData.PressureStep2MaterialInstance.SetScalarParameterValue(new FName("PressureEdgeMasking"), 0f);
		LocalFluid2DMgrData.PressureStep2MaterialInstance.SetScalarParameterValue(new FName("TexelSizeMult"), LocalFluid2DMgrData.Speed);
	}

	private void exportSimResult()
	{
		exportVeloDensity();
		exportPressureDivergency();
	}

	private void exportVeloDensity()
	{
		if (LocalFluid2DMgrData.bExportVeloDensity)
		{
			URenderingLibrary.DrawMaterialToRenderTarget(Owner, LocalFluid2DMgrData.veloDensityOutput, LocalFluid2DMgrData.CompositeMaterialInstance);
		}
	}

	private void exportPressureDivergency()
	{
	}
}
