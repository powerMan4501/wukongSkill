using System.Collections.Generic;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_NpcPlayMontage : FIdleProcessExecutorBase
{
	private class NPCPlayMontageTask
	{
		private string UnitGuid;

		private int SkillID;

		public NPCPlayMontageTask(string _UnitGuid, int _SkillID)
		{
			UnitGuid = _UnitGuid;
			SkillID = _SkillID;
		}

		public bool TryPlayMontage(UObject WorldContext)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(WorldContext, UnitGuid);
			if (actorByGuid == null)
			{
				return false;
			}
			return BGUFunctionLibraryCS.BGUTryCastSpell(actorByGuid, SkillID, ECastSkillSourceType.CPG) == 0;
		}
	}

	public override EIdleProcessActionType ActionType => EIdleProcessActionType.NpcPlayMontage;

	private int NPCActionSkillID { get; set; }

	private string UnitGuid { get; set; }

	private List<NPCPlayMontageTask> NpcPlayMontageTasks { get; } = new List<NPCPlayMontageTask>();

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		NPCActionSkillID = InIdleProcessAction.NpcActionSkillId;
		PsmInstance psmInstance = InPsmNodeInstance?.ParentInstance;
		if (psmInstance != null)
		{
			UnitGuid = psmInstance.ConvertParamID2UnitGuid(InIdleProcessAction.UnitGuid);
		}
	}

	public override void Run(UObject InWorldContext)
	{
		NpcPlayMontageTasks.Clear();
		if (BGUFunctionLibraryCS.BGUTryCastSpell(BGU_DataUtil.GetActorByGuid(InWorldContext, UnitGuid), NPCActionSkillID, ECastSkillSourceType.CPG) != 0)
		{
			NpcPlayMontageTasks.Add(new NPCPlayMontageTask(UnitGuid, NPCActionSkillID));
		}
	}

	public override void OnTick(UObject InWorldContext, float InDeltaTime)
	{
		for (int num = NpcPlayMontageTasks.Count - 1; num >= 0; num--)
		{
			if (NpcPlayMontageTasks[num].TryPlayMontage(InWorldContext))
			{
				NpcPlayMontageTasks.RemoveAt(num);
			}
		}
	}

	public override bool IsFinished()
	{
		return NpcPlayMontageTasks.Count == 0;
	}
}
