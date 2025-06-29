using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_LightningFXData
{
	private TStrongObjectPtr<UNiagaraSystem> mLightningTemplate = new TStrongObjectPtr<UNiagaraSystem>();

	private TStrongObjectPtr<BGUDecalActor> mDecalActorClass = new TStrongObjectPtr<BGUDecalActor>();

	private TStrongObjectPtr<UMeshComponent> mAttachMeshComp = new TStrongObjectPtr<UMeshComponent>();

	public List<FName> SocketNameList;

	public int CurSpawnWaves;

	public float WaveGap;

	public float CurWaveGap;

	public int SpawnNumPerWave;

	public int CurSpawnIndex;

	public float LightningDelaySpawnDecalTime;

	public List<FLightningSpawnDecalInfo> DecalSpawnQuene;

	public List<FVector> PointQuene;

	public bool bRecalcPointPerWave;

	public bool bSpawnBySelfMode;

	public bool DirBaseOnParent;

	public FFloatRange RangeDir_X;

	public FFloatRange RangeDir_Y;

	public FFloatRange RangeDir_Z;

	public float LineTraceMaxLength;

	public ETraceTypeQuery TraceTypeQuery;

	public float PointMinBetween;

	public UNiagaraSystem LightningTemplate
	{
		get
		{
			return mLightningTemplate.Get();
		}
		set
		{
			mLightningTemplate.Set(value);
		}
	}

	public BGUDecalActor DecalActorClass
	{
		get
		{
			return mDecalActorClass.Get();
		}
		set
		{
			mDecalActorClass.Set(value);
		}
	}

	public UMeshComponent AttachMeshComp
	{
		get
		{
			return mAttachMeshComp.Get();
		}
		set
		{
			mAttachMeshComp.Set(value);
		}
	}

	public BUC_LightningFXData()
	{
		CurSpawnWaves = 0;
		WaveGap = 0f;
		CurWaveGap = 0f;
		SpawnNumPerWave = 0;
		CurSpawnIndex = 0;
		LightningDelaySpawnDecalTime = 0f;
		SocketNameList = new List<FName>();
		DecalSpawnQuene = new List<FLightningSpawnDecalInfo>();
		PointQuene = new List<FVector>();
		bRecalcPointPerWave = false;
	}
}
