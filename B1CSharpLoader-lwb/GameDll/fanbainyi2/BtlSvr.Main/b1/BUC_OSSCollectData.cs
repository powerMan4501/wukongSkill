using b1.ECS;
using OssB1;

namespace b1;

public class BUC_OSSCollectData : IBUC_OSSCollectData, IPersistentECSData
{
	public FOSS_SkillHitActorInfo SkillHitActorInfo;

	public bool bHasExtEndType;

	public BattleEndType Ext_EndType;

	public bool bIsSpecialMonster;

	public int TotalFrame;

	public float TotalFrameRate;

	public bool CurBattle_HasPlayerIn;

	public ReportEventPlayerTransEvent PlayerTransEvent;

	public int StartTime_PlayerTrans;

	public EOSS_CharacterType OSS_CharacterType { get; set; }

	public int BeginFightTime { get; set; }

	public BattlePlayer BattlePlayerData { get; set; }

	public BattleMonster BattleAiData { get; set; }

	public bool IsFight { get; set; }

	public BUC_OSSCollectData()
	{
		SkillHitActorInfo.Clear();
	}

	public bool bIsRecordingBattleInfo()
	{
		return (float)BeginFightTime > 0f;
	}
}
