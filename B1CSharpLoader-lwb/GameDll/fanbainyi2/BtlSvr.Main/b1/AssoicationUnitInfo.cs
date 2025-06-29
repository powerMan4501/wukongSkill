namespace b1;

public class AssoicationUnitInfo
{
	public string AssociationUnitEntityGUID;

	public float SpawnDelayTime;

	public bool bCanActive;

	public bool bIsActive;

	public bool bIsSpawn;

	public EAssociationUnitSpawnType SpawnType;

	public string TargetGUID;

	public int OnFightSkillID;

	public AssoicationUnitInfo(bool _bCanActive, EAssociationUnitSpawnType _SpawnType, string _TargetGUID, float _SpawnDelayTime, int _OnFightSkillID)
	{
		AssociationUnitEntityGUID = string.Empty;
		bIsSpawn = false;
		bIsActive = false;
		SpawnDelayTime = _SpawnDelayTime;
		SpawnType = _SpawnType;
		bCanActive = _bCanActive;
		TargetGUID = _TargetGUID;
		OnFightSkillID = _OnFightSkillID;
	}

	public AssoicationUnitInfo()
	{
		AssociationUnitEntityGUID = string.Empty;
		bIsSpawn = false;
		bIsActive = false;
		SpawnDelayTime = 0f;
		SpawnType = EAssociationUnitSpawnType.ByEQS;
		bCanActive = false;
		TargetGUID = string.Empty;
		OnFightSkillID = 0;
	}
}
