using System.Collections.Generic;
using UnrealEngine.Plugins.Niagara;

namespace b1;

internal class BUC_NeutralFXAnimalSpawnData
{
	public EFXAnimalSpawnMomentType SpawnMomentType;

	public float Outside_Spd_Threshold;

	public float Outside_Dist;

	public float DestroyTime_FX;

	public List<UNiagaraSystem> RandomNiagaraTemplateList;

	public UNiagaraComponent NGComp;

	public float DestroyTimer_FX;

	public float DelayDestroyTime_Spawnner;

	public bool bActorPendingDestroy;

	public BUC_NeutralFXAnimalSpawnData()
	{
		RandomNiagaraTemplateList = new List<UNiagaraSystem>();
		DestroyTimer_FX = -1f;
		bActorPendingDestroy = false;
	}
}
