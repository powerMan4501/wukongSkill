namespace b1;

public interface IBPC_PlayerAttrData
{
	float PlayerLifeSavingCoolDownRemainTime { get; }

	BindListPlayerPersistentAttr PlayerPersistentAttr { get; }

	BindListPlayerMagicSkillCd PlayerMagicSkillCd { get; }

	BindDictString_Int KeyMonsterMeetCount { get; }

	BindDictString_Int KeyMonsterBattlePlayerDieTimes { get; }
}
