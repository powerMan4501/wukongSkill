using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_UnitCastAllSkill : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		SetFXConfig,
		FindEnemy_ByUClass,
		Read_SkillList,
		Pause_BT,
		Cast_Skill_Start,
		Cast_Skill_Monitor,
		Cast_Skill_Wait
	}

	private InnerState CurrentState;

	private BGUCharacterCS Enemy;

	private readonly UClass MonsterClass;

	private readonly UClass TamerClass;

	private List<int> AllSkillID;

	private int CurrentIndexID = -1;

	private int TickCounter;

	private AActor NiagaraStatUI;

	private bool WaitSkillEffect;

	private int CurrentWaitCounter;

	private bool isPlayer;

	private int RoleDataConfig;

	private string FXConfigName;

	private List<int> SkillIDBlackList;

	private bool OpenTrace;

	private bool WaitPreLoadAndShaderCompiling;

	private bool IsFirstCast = true;

	private int IdleNiagaraSystemInstanceNum;

	private bool SkipSpawnTamerFail;

	private string TamerClassName = string.Empty;

	public TestState_UnitCastAllSkill(UObject WorldContext, UClass Class, bool isPlayer = false, int RoleDataConfig = 0, List<int> SkillIDBlackList = null, bool OpenTrace = false, bool WaitPreLoadAndShaderCompiling = false)
	{
		base.WorldContext = WorldContext;
		this.OpenTrace = OpenTrace;
		BUTamerActor bUTamerActor = Class.ClassDefaultObject.Cast<BUTamerActor>();
		if (bUTamerActor == null)
		{
			MonsterClass = Class;
		}
		else
		{
			TamerClass = Class;
			MonsterClass = bUTamerActor.GetMonsterClass();
		}
		this.isPlayer = isPlayer;
		this.RoleDataConfig = RoleDataConfig;
		this.SkillIDBlackList = SkillIDBlackList;
		this.WaitPreLoadAndShaderCompiling = WaitPreLoadAndShaderCompiling;
	}

	public TestState_UnitCastAllSkill(UObject WorldContext, string TamerClassName, bool isPlayer = false, int RoleDataConfig = 0, List<int> SkillIDBlackList = null, bool OpenTrace = false, bool WaitPreLoadAndShaderCompiling = false, bool SkipSpawnTamerFail = false)
	{
		base.WorldContext = WorldContext;
		this.OpenTrace = OpenTrace;
		this.TamerClassName = TamerClassName;
		UBlueprint uBlueprint = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UBlueprint>(TamerClassName, ELoadResourceType.SyncLoadAndCache);
		if (uBlueprint == null)
		{
			UClass uClass = (TamerClass = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>(TamerClassName, ELoadResourceType.SyncLoadAndCache));
			if (!TamerClass.IsNullOrDestroyed())
			{
				MonsterClass = uClass.ClassDefaultObject.Cast<BUTamerActor>().GetMonsterClass();
			}
		}
		else
		{
			TamerClass = uBlueprint.GeneratedClass;
			MonsterClass = uBlueprint.GeneratedClass.ClassDefaultObject.Cast<BUTamerActor>().GetMonsterClass();
		}
		this.isPlayer = isPlayer;
		this.RoleDataConfig = RoleDataConfig;
		this.SkillIDBlackList = SkillIDBlackList;
		this.WaitPreLoadAndShaderCompiling = WaitPreLoadAndShaderCompiling;
		this.SkipSpawnTamerFail = SkipSpawnTamerFail;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	private SpellType GetSpellTypeBySkillID(int SkillID)
	{
		foreach (SpellDesc item in GameDBRuntime.GetTBSpellDesc().List)
		{
			if (item.SkillId == SkillID)
			{
				return item.Type;
			}
		}
		return SpellType.Min;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "";
		return AutoTestNodeLib.NodeState.Running;
	}
}
