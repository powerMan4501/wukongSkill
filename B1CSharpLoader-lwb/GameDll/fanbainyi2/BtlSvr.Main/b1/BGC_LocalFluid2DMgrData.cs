using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_LocalFluid2DMgrData : IPersistentECSData
{
	public bool toggleSim;

	public bool bPostProcessCollisionData;

	public bool blueprintDrivenParameters;

	public bool bMovedCheck;

	public bool blocationCheck;

	public bool bLocalSim;

	public bool bHighQualitySim;

	public bool bSimAreaClamp;

	public int MaxIteration;

	public int SimulationResX;

	public int SimulationResY;

	public float SimAreaSizeInCM;

	public FName SnappedPosParameterName;

	public UMaterialParameterCollection dynamicSDFMpc;

	public float worldOffsetThreshold;

	public float moveThreadhold;

	public float edgeExtendSize;

	public bool bExportVeloDensity;

	public bool bExportPressureDivergence;

	public UTextureRenderTarget2D veloDensityOutput;

	public UTextureRenderTarget2D pressureDivergenceOutput;

	public UMaterialInterface CollisionQueryMaterial;

	public UMaterialInterface PPCollisionQueryMaterial;

	public UMaterialInterface CompositeMaterial;

	public UMaterialInterface AdvectMaterial;

	public UMaterialInterface DivergenceMaterial;

	public UMaterialInterface PressureStep1Material;

	public UMaterialInterface PressureStep2Material;

	public float BrushPuncture;

	public float VeloDirNoise;

	public float Speed;

	public float VeloFromSimAreaMotion;

	public float SimEdgeBouncyness;

	public float FadeDensityAtSimEdge;

	public float VeloDirNoiseSize;

	public float VeloDirNoiseSpeed;

	public float VeloOffsetX;

	public float VeloOffsetY;

	public float VeloFromBrushMotion;

	public float VeloStrength;

	public float VeloRotate;

	public float VeloAmpNoise;

	public float InputFeedback;

	public float FlowFeedback;

	public float Divergence;

	public float BrushSize;

	public float BrushStrength;

	public float EraserMode;

	public float BrushHardness;

	public UTexture2D DensityTemplate;

	public UTexture2D VelocityTemplate;

	public float VelocityOffsetSpeed;

	public float EdgeMaskWidth;

	public float DensityTxtMult;

	public float DensityTxtScale;

	public float DensityTxtOffsetX;

	public float DensityTxtOffsetY;

	public float BrushNoise;

	public float VeloInputTile;

	public float DensityInputNoiseAmp;

	public float DensityInputNoiseOffset;

	public float DensityInputNoiseTile;

	public float BrushRnd;

	public FVector SimAreaCenterWorldSpace;

	public FVector snappedPos;

	public FVector lastSnappedPos;

	public FVector deltaSnappedPos;

	public FVector deltaDir;

	public bool bMovedLastFrame;

	public float OffsetFromSimAreaMotion;

	public float outputWorldOffsetX;

	public float outputWorldOffsetY;

	public float worldOffsetX;

	public float worldOffsetY;

	private TStrongObjectPtr<UTextureRenderTarget2D> mRT_CollisionResult = new TStrongObjectPtr<UTextureRenderTarget2D>();

	private TStrongObjectPtr<UTextureRenderTarget2D> mRT_PPCollisionResult = new TStrongObjectPtr<UTextureRenderTarget2D>();

	private TStrongObjectPtr<UTextureRenderTarget2D> mRT_Advection = new TStrongObjectPtr<UTextureRenderTarget2D>();

	private TStrongObjectPtr<UTextureRenderTarget2D> mRT_PressureDivergence = new TStrongObjectPtr<UTextureRenderTarget2D>();

	private TStrongObjectPtr<UTextureRenderTarget2D> mRT_Composite = new TStrongObjectPtr<UTextureRenderTarget2D>();

	private TStrongObjectPtr<UTextureRenderTarget2D> mRT_PressureDivergenceTemp = new TStrongObjectPtr<UTextureRenderTarget2D>();

	private TStrongObjectPtr<UMaterialInstanceDynamic> mCollisionQueryMaterialInstance = new TStrongObjectPtr<UMaterialInstanceDynamic>();

	private TStrongObjectPtr<UMaterialInstanceDynamic> mPPCollisionQueryMaterialInstance = new TStrongObjectPtr<UMaterialInstanceDynamic>();

	private TStrongObjectPtr<UMaterialInstanceDynamic> mCompositeMaterialInstance = new TStrongObjectPtr<UMaterialInstanceDynamic>();

	private TStrongObjectPtr<UMaterialInstanceDynamic> mAdvectMaterialInstance = new TStrongObjectPtr<UMaterialInstanceDynamic>();

	private TStrongObjectPtr<UMaterialInstanceDynamic> mDivergenceMaterialInstance = new TStrongObjectPtr<UMaterialInstanceDynamic>();

	private TStrongObjectPtr<UMaterialInstanceDynamic> mPressureStep1MaterialInstance = new TStrongObjectPtr<UMaterialInstanceDynamic>();

	private TStrongObjectPtr<UMaterialInstanceDynamic> mPressureStep2MaterialInstance = new TStrongObjectPtr<UMaterialInstanceDynamic>();

	public UTextureRenderTarget2D RT_CollisionResult
	{
		get
		{
			return mRT_CollisionResult.Get();
		}
		set
		{
			mRT_CollisionResult.Set(value);
		}
	}

	public UTextureRenderTarget2D RT_PPCollisionResult
	{
		get
		{
			return mRT_PPCollisionResult.Get();
		}
		set
		{
			mRT_PPCollisionResult.Set(value);
		}
	}

	public UTextureRenderTarget2D RT_Advection
	{
		get
		{
			return mRT_Advection.Get();
		}
		set
		{
			mRT_Advection.Set(value);
		}
	}

	public UTextureRenderTarget2D RT_PressureDivergence
	{
		get
		{
			return mRT_PressureDivergence.Get();
		}
		set
		{
			mRT_PressureDivergence.Set(value);
		}
	}

	public UTextureRenderTarget2D RT_Composite
	{
		get
		{
			return mRT_Composite.Get();
		}
		set
		{
			mRT_Composite.Set(value);
		}
	}

	public UTextureRenderTarget2D RT_PressureDivergenceTemp
	{
		get
		{
			return mRT_PressureDivergenceTemp.Get();
		}
		set
		{
			mRT_PressureDivergenceTemp.Set(value);
		}
	}

	public UMaterialInstanceDynamic CollisionQueryMaterialInstance
	{
		get
		{
			return mCollisionQueryMaterialInstance.Get();
		}
		set
		{
			mCollisionQueryMaterialInstance.Set(value);
		}
	}

	public UMaterialInstanceDynamic PPCollisionQueryMaterialInstance
	{
		get
		{
			return mPPCollisionQueryMaterialInstance.Get();
		}
		set
		{
			mPPCollisionQueryMaterialInstance.Set(value);
		}
	}

	public UMaterialInstanceDynamic CompositeMaterialInstance
	{
		get
		{
			return mCompositeMaterialInstance.Get();
		}
		set
		{
			mCompositeMaterialInstance.Set(value);
		}
	}

	public UMaterialInstanceDynamic AdvectMaterialInstance
	{
		get
		{
			return mAdvectMaterialInstance.Get();
		}
		set
		{
			mAdvectMaterialInstance.Set(value);
		}
	}

	public UMaterialInstanceDynamic DivergenceMaterialInstance
	{
		get
		{
			return mDivergenceMaterialInstance.Get();
		}
		set
		{
			mDivergenceMaterialInstance.Set(value);
		}
	}

	public UMaterialInstanceDynamic PressureStep1MaterialInstance
	{
		get
		{
			return mPressureStep1MaterialInstance.Get();
		}
		set
		{
			mPressureStep1MaterialInstance.Set(value);
		}
	}

	public UMaterialInstanceDynamic PressureStep2MaterialInstance
	{
		get
		{
			return mPressureStep2MaterialInstance.Get();
		}
		set
		{
			mPressureStep2MaterialInstance.Set(value);
		}
	}

	public void InitConfigFromDA(BGWDataAsset_LocalFluid2DConfig DefaultLocalFluid2DConfig)
	{
		if (!(DefaultLocalFluid2DConfig == null))
		{
			toggleSim = DefaultLocalFluid2DConfig.toggleSim;
			bPostProcessCollisionData = DefaultLocalFluid2DConfig.bPostProcessCollisionData;
			blueprintDrivenParameters = DefaultLocalFluid2DConfig.blueprintDrivenParameters;
			bMovedCheck = DefaultLocalFluid2DConfig.bMovedCheck;
			blocationCheck = DefaultLocalFluid2DConfig.blocationCheck;
			bLocalSim = DefaultLocalFluid2DConfig.bLocalSim;
			bHighQualitySim = DefaultLocalFluid2DConfig.bHighQualitySim;
			bSimAreaClamp = DefaultLocalFluid2DConfig.bSimAreaClamp;
			MaxIteration = DefaultLocalFluid2DConfig.MaxIteration;
			SimulationResX = DefaultLocalFluid2DConfig.SimulationResX;
			SimulationResY = DefaultLocalFluid2DConfig.SimulationResY;
			SimAreaSizeInCM = DefaultLocalFluid2DConfig.SimAreaSizeInCM;
			SnappedPosParameterName = DefaultLocalFluid2DConfig.SnappedPosParameterName;
			dynamicSDFMpc = DefaultLocalFluid2DConfig.dynamicSDFMpc;
			worldOffsetThreshold = DefaultLocalFluid2DConfig.worldOffsetThreshold;
			moveThreadhold = DefaultLocalFluid2DConfig.moveThreadhold;
			edgeExtendSize = DefaultLocalFluid2DConfig.edgeExtendSize;
			bExportVeloDensity = DefaultLocalFluid2DConfig.bExportVeloDensity;
			bExportPressureDivergence = DefaultLocalFluid2DConfig.bExportPressureDivergence;
			veloDensityOutput = DefaultLocalFluid2DConfig.veloDensityOutput;
			pressureDivergenceOutput = DefaultLocalFluid2DConfig.pressureDivergenceOutput;
			CollisionQueryMaterial = DefaultLocalFluid2DConfig.CollisionQueryMaterial;
			PPCollisionQueryMaterial = DefaultLocalFluid2DConfig.PPCollisionQueryMaterial;
			CompositeMaterial = DefaultLocalFluid2DConfig.CompositeMaterial;
			AdvectMaterial = DefaultLocalFluid2DConfig.AdvectMaterial;
			DivergenceMaterial = DefaultLocalFluid2DConfig.DivergenceMaterial;
			PressureStep1Material = DefaultLocalFluid2DConfig.PressureStep1Material;
			PressureStep2Material = DefaultLocalFluid2DConfig.PressureStep2Material;
			BrushPuncture = DefaultLocalFluid2DConfig.BrushPuncture;
			VeloDirNoise = DefaultLocalFluid2DConfig.VeloDirNoise;
			Speed = DefaultLocalFluid2DConfig.Speed;
			VeloFromSimAreaMotion = DefaultLocalFluid2DConfig.VeloFromSimAreaMotion;
			SimEdgeBouncyness = DefaultLocalFluid2DConfig.SimEdgeBouncyness;
			FadeDensityAtSimEdge = DefaultLocalFluid2DConfig.FadeDensityAtSimEdge;
			VeloDirNoiseSize = DefaultLocalFluid2DConfig.VeloDirNoiseSize;
			VeloDirNoiseSpeed = DefaultLocalFluid2DConfig.VeloDirNoiseSpeed;
			VeloOffsetX = DefaultLocalFluid2DConfig.VeloOffsetX;
			VeloOffsetY = DefaultLocalFluid2DConfig.VeloOffsetY;
			VeloFromBrushMotion = DefaultLocalFluid2DConfig.VeloFromBrushMotion;
			VeloStrength = DefaultLocalFluid2DConfig.VeloStrength;
			VeloRotate = DefaultLocalFluid2DConfig.VeloRotate;
			VeloAmpNoise = DefaultLocalFluid2DConfig.VeloAmpNoise;
			InputFeedback = DefaultLocalFluid2DConfig.InputFeedback;
			FlowFeedback = DefaultLocalFluid2DConfig.FlowFeedback;
			Divergence = DefaultLocalFluid2DConfig.Divergence;
			BrushSize = DefaultLocalFluid2DConfig.BrushSize;
			BrushStrength = DefaultLocalFluid2DConfig.BrushStrength;
			EraserMode = DefaultLocalFluid2DConfig.EraserMode;
			BrushHardness = DefaultLocalFluid2DConfig.BrushHardness;
			DensityTemplate = DefaultLocalFluid2DConfig.DensityTemplate;
			VelocityTemplate = DefaultLocalFluid2DConfig.VelocityTemplate;
			VelocityOffsetSpeed = DefaultLocalFluid2DConfig.VelocityOffsetSpeed;
			EdgeMaskWidth = DefaultLocalFluid2DConfig.EdgeMaskWidth;
			DensityTxtMult = DefaultLocalFluid2DConfig.DensityTxtMult;
			DensityTxtScale = DefaultLocalFluid2DConfig.DensityTxtScale;
			DensityTxtOffsetX = DefaultLocalFluid2DConfig.DensityTxtOffsetX;
			DensityTxtOffsetY = DefaultLocalFluid2DConfig.DensityTxtOffsetY;
			BrushNoise = DefaultLocalFluid2DConfig.BrushNoise;
			VeloInputTile = DefaultLocalFluid2DConfig.VeloInputTile;
			DensityInputNoiseAmp = DefaultLocalFluid2DConfig.DensityInputNoiseAmp;
			DensityInputNoiseOffset = DefaultLocalFluid2DConfig.DensityInputNoiseOffset;
			DensityInputNoiseTile = DefaultLocalFluid2DConfig.DensityInputNoiseTile;
			BrushRnd = DefaultLocalFluid2DConfig.BrushRnd;
		}
	}
}
