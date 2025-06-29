using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_LightningFXSpawnComp")]
public class BUS_LightningFXSpawnComp : UActorEditCompBase
{
	private static bool LightningFXSpawnConfig_IsValid;

	private static int LightningFXSpawnConfig_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("FXActorConfig")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_LightningFXSpawnComp:LightningFXSpawnConfig")]
	public FLightningFXSpawnConfig LightningFXSpawnConfig
	{
		get
		{
			CheckDestroyed();
			if (!LightningFXSpawnConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LightningFXSpawnComp:LightningFXSpawnConfig");
				return default(FLightningFXSpawnConfig);
			}
			return FLightningFXSpawnConfig.FromNative(IntPtr.Add(base.Address, LightningFXSpawnConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightningFXSpawnConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LightningFXSpawnComp:LightningFXSpawnConfig");
			}
			else
			{
				FLightningFXSpawnConfig.ToNative(IntPtr.Add(base.Address, LightningFXSpawnConfig_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		LightningFXSpawnConfig = new FLightningFXSpawnConfig
		{
			SpawnWaves = 0,
			WaveGap = 0f,
			SpawnNumPerWave = 0,
			LightningDelaySpawnDecalTime = 0f,
			LightningTemplate = null
		};
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_LightningFXData bUC_LightningFXData = RequireWritableData<b1.BUC_LightningFXData>();
		bUC_LightningFXData.CurSpawnWaves = LightningFXSpawnConfig.SpawnWaves;
		bUC_LightningFXData.WaveGap = LightningFXSpawnConfig.WaveGap;
		bUC_LightningFXData.SpawnNumPerWave = LightningFXSpawnConfig.SpawnNumPerWave;
		bUC_LightningFXData.LightningDelaySpawnDecalTime = LightningFXSpawnConfig.LightningDelaySpawnDecalTime;
		bUC_LightningFXData.LightningTemplate = LightningFXSpawnConfig.LightningTemplate;
		bUC_LightningFXData.DecalActorClass = LightningFXSpawnConfig.DecalActorClass.GetDefaultObject();
		bUC_LightningFXData.bRecalcPointPerWave = LightningFXSpawnConfig.bRecalcPointPerWave;
		bUC_LightningFXData.bSpawnBySelfMode = LightningFXSpawnConfig.bSpawnBySelfMode;
		bUC_LightningFXData.DirBaseOnParent = LightningFXSpawnConfig.DirBaseOnParent;
		bUC_LightningFXData.RangeDir_X = LightningFXSpawnConfig.RangeDir_X;
		bUC_LightningFXData.RangeDir_Y = LightningFXSpawnConfig.RangeDir_Y;
		bUC_LightningFXData.RangeDir_Z = LightningFXSpawnConfig.RangeDir_Z;
		bUC_LightningFXData.LineTraceMaxLength = LightningFXSpawnConfig.LineTraceMaxLength;
		bUC_LightningFXData.TraceTypeQuery = LightningFXSpawnConfig.TraceTypeQuery;
		bUC_LightningFXData.PointMinBetween = LightningFXSpawnConfig.PointMinBetween;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_LightningFXSpawnComp");
		LightningFXSpawnConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LightningFXSpawnConfig");
		LightningFXSpawnConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LightningFXSpawnConfig", Classes.FStructProperty);
	}

	static BUS_LightningFXSpawnComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_LightningFXSpawnComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_LightningFXSpawnComp));
	}
}
