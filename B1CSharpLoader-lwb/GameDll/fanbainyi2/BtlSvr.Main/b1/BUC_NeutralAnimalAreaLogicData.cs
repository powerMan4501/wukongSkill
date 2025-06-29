using System.Collections.Generic;
using UnrealEngine.AIModule;

namespace b1;

public class BUC_NeutralAnimalAreaLogicData
{
	public bool bDrawDebug;

	public bool DestroyAllAnimalWhenPlaySeq;

	public bool DontSpawnInCloudMove;

	public List<FAnimalSpawnTemplate> AnimalTemplates;

	public EAnimalDistributionSpawnTendency DistributionSpawnTendency;

	public float DestroyProtectCD;

	public float PresetCD;

	public float SpawnCD;

	public EAnimalSpawnPosType SpawnPosType;

	public UEnvQuery EQSTemplate;

	public EAnimalSpawnRotType SpawnRotType;

	public bool ConfigError = true;

	public bool HasAnimalSpawned;

	public bool LocalPlayerInner;

	public float AnimalAllDeadTime;

	public float LastEnterTriggerAreaTime;

	public float LastSpawnTime;

	public BUC_NeutralAnimalAreaLogicData()
	{
		AnimalTemplates = new List<FAnimalSpawnTemplate>();
		HasAnimalSpawned = false;
		LocalPlayerInner = false;
		AnimalAllDeadTime = 0f;
		LastSpawnTime = 0f;
	}
}
